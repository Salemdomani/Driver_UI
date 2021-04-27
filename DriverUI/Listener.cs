using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DriverUI
{
    class TcpServer
    {
        private TcpListener _server;
        DashBoard form;
        bool isRunning = true;
        private List<Thread> runningThreads = new List<Thread>();
        class HelloMessage{

            public int vms;
            public bool isBusy;
            
            public HelloMessage(int vms,bool isBusy)
            {
                this.vms = vms;
                this.isBusy = isBusy;
            }

            public static HelloMessage Parse(string message)
            {
                return new HelloMessage(
                    Convert.ToInt32(message.Split(' ')[2]),
                    Convert.ToBoolean(message.Split(' ')[5])
                    );
            }
        }

        public TcpServer(int port,DashBoard form)
        {
            this.form = form;
            _server = new TcpListener(IPAddress.Any, port);
        }

        public void StartListening()
        {
            _server.Start();
            while (isRunning)
            {
                try
                {
                    TcpClient newClient = _server.AcceptTcpClient();
                    Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                    runningThreads.Add(t);
                    t.Start(newClient);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
               
            }
        }

        public void HandleClient(object obj)
        {

            TcpClient client = (TcpClient)obj;
            //StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            while (isRunning)
            {
                try
                {
                    var sData = sReader.ReadLineAsync().Result;
                    if (sData.Contains("Hi"))
                        validateHelloMessage(sData);
                    else
                        form.Invoke((MethodInvoker)delegate { form.addlog(sData); });
                    // sWriter.WriteLine("Meaningfull things here");
                    // sWriter.Flush();
                }
                catch (Exception ex) {
                    Console.WriteLine("Error catching message "+ex.Message);
                    break;
                }
                
            }
        }

        void validateHelloMessage(string message)
        {
            var helo = HelloMessage.Parse(message);
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            if (helo.isBusy)
                db.Vms.SingleOrDefault(v => v.Id == helo.vms).Status = "BUSY";
            else
                db.Vms.SingleOrDefault(v => v.Id == helo.vms).Status = "READY";
            db.SubmitChanges();
        }

        public void StopListening()
        {
            try
            {
                isRunning = false;
                _server.Stop();
                foreach (var thread in runningThreads)
                    thread.Abort();
                
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
           
        }
    }
}

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
        public List<Thread> clients;

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
            clients = new List<Thread>();
            this.form = form;
            _server = new TcpListener(IPAddress.Any, port);
        }

        public void StartListening()
        {
            _server.Start();
            while (true)
            {
                TcpClient newClient = _server.AcceptTcpClient();
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                clients.Add(t);
                t.Start(newClient as TcpClient);
            }
        }

        public void HandleClient(object obj)
        {

            TcpClient client = (TcpClient)obj;
            //StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            while (true)
            {
                try
                {
                    var sData = sReader.ReadLine();
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
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DriverUI
{
    public class Client
    {
      public static string Send(string ipAddress, int port, string data)
        {
            try
            {
                var client = new TcpClient();
                client.Connect(ipAddress, port);
                var sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
                var sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
                sWriter.WriteLine(data);
                sWriter.Flush();
                return sReader.ReadLineAsync().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("from client send " + ex.Message);
                return "Error ocuured";
            }


        }


    }
}

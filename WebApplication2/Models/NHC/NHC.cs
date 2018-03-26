using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using WebApplication2.Models.General;

namespace WebApplication2.Models
{
   
    public static class NHC
    {
        private static TcpClient clientSocket;
        private static NetworkStream serverStream;


        private static void Connect()
        {
            clientSocket = new TcpClient();
            string IP = "192.168.0.180";
            int port = 8000;
            clientSocket.Connect(IP, port);
            serverStream = clientSocket.GetStream();
        }
        private static void Disconnect()
        {
            serverStream.Close();
            clientSocket.Close();
        }


        public static string SystemInfo()
        {
            Connect();
            NHCCommand startCommand = new NHCCommand("startevents");
            string response1 = startCommand.execute(serverStream, clientSocket);
            NHCCommand getActionsCommand = new NHCCommand("systeminfo");
            string response2 = getActionsCommand.execute(serverStream, clientSocket);
            Disconnect();

            return response2;
        }


        public static string Actions()
        {
            Connect();
            NHCCommand startCommand = new NHCCommand("startevents");
            string response1 = startCommand.execute(serverStream, clientSocket);
            NHCCommand getActionsCommand = new NHCCommand("listactions");
            string response2 = getActionsCommand.execute(serverStream, clientSocket);
            Disconnect();
            
            return response2;



        }

       
        public static string SetParameter(string id, float value)
        {
            Connect();
            NHCCommand startCommand = new NHCCommand("startevents");
            string response1 = startCommand.execute(serverStream, clientSocket);
            NHCCommandAdvanced setActionsCommand = new NHCCommandAdvanced("executeactions", id, value.ToString());
            string response2 = setActionsCommand.execute(serverStream, clientSocket);
            Disconnect();

            return response2;

        }






        private class NHCCommand
        {
            public string cmd;


            public NHCCommand(string _command)
            {
                cmd = _command;

            }

            public string execute(NetworkStream serverStream, TcpClient clientSocket)
            {

                string sendString = JsonConvert.SerializeObject(this);

                byte[] outStream = Encoding.ASCII.GetBytes(sendString /*+ "$"*/);
                serverStream.Write(outStream, 0, outStream.Length);
                System.Threading.Thread.Sleep(1000); //TESTING
                serverStream.Flush();
                byte[] inStream = new byte[100250];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);

                int i = inStream.Length - 1;
                while (inStream[i] == 0)
                    --i;

                byte[] result = new byte[i + 1];
                Array.Copy(inStream, result, i + 1);




                string resultString = Encoding.ASCII.GetString(result);
                return resultString;
            }
        }
        private class NHCCommandAdvanced
        {
            public string cmd;
            public int id;
            public int value1;

            public NHCCommandAdvanced(string _command, string _id, string _value)
            {
                cmd = _command;
                id = int.Parse(_id);
                value1 = int.Parse(_value);
            }

            public string execute(NetworkStream serverStream, TcpClient clientSocket)
            {

                string sendString = JsonConvert.SerializeObject(this);

                byte[] outStream = Encoding.ASCII.GetBytes(sendString /*+ "$"*/);
                serverStream.Write(outStream, 0, outStream.Length);

                serverStream.Flush();
                byte[] inStream = new byte[100250];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);

                int i = inStream.Length - 1;
                while (inStream[i] == 0)
                    --i;

                byte[] result = new byte[i + 1];
                Array.Copy(inStream, result, i + 1);



                string resultString = Encoding.ASCII.GetString(inStream);
                return resultString;
            }




        }


    }

    
    





}
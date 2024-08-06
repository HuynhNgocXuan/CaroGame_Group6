using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    internal class SocketManager
    {

        #region Both (Client && Server)

        public string IP = "127.0.0.1";
        public int PORT = 5555;
        public const int BUFFER = 1024;
        public bool isServer = true;

        public bool Send(object data)
        {
            byte[] arrayData = SerializeData(data);

            return SendData(client, arrayData);
        }

        public object Receive()
        {
            byte[] arrayData = new byte[BUFFER];
            bool isReceive = ReceiveData(client, arrayData);

            return DeserializeData(arrayData);
        }


        private bool SendData(Socket target, byte[] arrayData)
        {
            return target.Send(arrayData) == 0 ? true : false;
        }

        private bool ReceiveData(Socket target, byte[] arrayData)
        {
            return target.Receive(arrayData) == 1 ? true : false;
        }


        public byte[] SerializeData(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, obj);

            return stream.ToArray();
        }

        public object DeserializeData(byte[] array)
        {
            MemoryStream stream = new MemoryStream(array);
            BinaryFormatter binary = new BinaryFormatter();
            stream.Position = 0;

            return binary.Deserialize(stream);
        }

        public string GetLocalIPv4(NetworkInterfaceType type)
        {
            string IP = ""; 

            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation info in item.GetIPProperties().UnicastAddresses)
                    {
                        if (info.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            IP = info.Address.ToString();
                        }
                    }
                }
            }

            return IP;
        }

        #endregion

        #region Client

        Socket client;

        public bool ConnectServer()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(ipPoint);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region Server

        Socket server;

        public void CreateServer()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(ipPoint);
            server.Listen(10);

            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });

            acceptClient.IsBackground = true;
            acceptClient.Start();
        }

        #endregion
    }
}

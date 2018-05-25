using System;
using System.Net;
using System.Net.Sockets;

namespace courses
{
    public class Client
    {
        static IPHostEntry ipHost = Dns.GetHostEntry("127.0.0.1");
        static IPAddress ipAddr = ipHost.AddressList[0];
        static IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 904);

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        public Client() {}

        public void connectToServer() {
            socket.Connect(ipEndPoint);
        }

        public void sendmsg(string username, string hash){

            string message = username;
            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message);
            socket.Send(buffer);
            message = hash;
            buffer = System.Text.Encoding.ASCII.GetBytes(message);
            socket.Send(buffer);

            Console.ReadLine();
        }

        public void stopConectToServer()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        public int calculate(int id, string word, string password){
            return id.GetHashCode() + word.GetHashCode() + password.GetHashCode();
        }
    }
}

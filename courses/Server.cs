using System;
using System.Net;
using System.Net.Sockets;

namespace courses
{
    public class Server {
        static IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        static IPAddress ipAddr = ipHost.AddressList[0];
        static IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

        Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        Socket client;
        public Server()
        {
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void conectClient() {
            client = sListener.Accept();
        }

        public void stopServer() {
            sListener.Shutdown(SocketShutdown.Both);
            sListener.Close();
        }

        public  bool submitUser(int id, string word,string login, string password, int hash){
            int passHash = 0;
            WorkFile workFile = new WorkFile();
            if (id.GetHashCode() + word.GetHashCode() + password.GetHashCode() == hash){
                passHash = password.GetHashCode();
                if (workFile.getpass(login).GetHashCode().Equals(passHash)){
                    return true;
                }
            }
            return false;;
        }
    }
}

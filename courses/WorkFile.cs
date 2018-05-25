using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace courses
{
    public class WorkFile
    {
        public WorkFile()
        {
            
        }

        public void writeInFile(string login, string password) {
            using (StreamWriter sw = new StreamWriter("test.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(login + " " + password);
            }
        }

        public bool readFromFile(string login) {
            using (StreamReader sr = new StreamReader("test.txt", System.Text.Encoding.Default))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line.Trim()))
                    {
                        string firstLineWord = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                        if (firstLineWord.Equals(login)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public string getpass(string login)
        {
            string pass = " ";
            using (StreamReader sr = new StreamReader("test.txt", System.Text.Encoding.Default))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string firstLineWord = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                    if (firstLineWord.Equals(login))
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            string[] mas = line.Split(new char[] { ' ' });
                            pass = mas[1];

                        }
                    }

                }
            }
            return pass;
        }
    }
}
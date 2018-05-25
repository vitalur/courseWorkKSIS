using System;
using System.Security.Cryptography;
using System.Text;
using courses;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public WorkFile workFile = new WorkFile();
    //static Server server = new Server();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {   //Exit
        Application.Quit();
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {   //autorization
        
        if (entry1.Text == "" || entry2.Text == "")
        {


            EmptyRegistration reg = new EmptyRegistration();
            reg.Show();
        }
        else {
            Client client = new Client();
            string a = (DateTime.DaysInMonth(2018, 5).GetHashCode() + "word".GetHashCode()) + "";

            client.sendmsg(entry1.Text, a);



        }
        entry1.Text = "";
        entry2.Text = "";
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {   //registration
        if (entry1.Text == "" || entry2.Text == "") {
            EmptyRegistration reg = new EmptyRegistration();
            reg.Show();
        } else if (workFile.readFromFile(entry1.Text)) {
            NotCurrentLogic notCurrentLogic = new NotCurrentLogic();
            notCurrentLogic.Show();
        } 
        else {
            string login = entry1.Text;
            string password = getMD5(entry2.Text);

            workFile.writeInFile(login, password);
        }
        entry1.Text = "";
        entry2.Text = "";
    }

    private string getMD5(string text)
    {
        MD5 md = new MD5CryptoServiceProvider();
        byte[] result = md.ComputeHash(Encoding.UTF8.GetBytes(text));
        StringBuilder sb = new StringBuilder();
        foreach (byte b in result)
        {
            sb.Append(b.ToString("x2"));
        }
        return sb.ToString();
    }
}

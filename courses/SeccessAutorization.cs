using System;
namespace courses
{
    public partial class SeccessAutorization : Gtk.Window
    {

        Client client = new Client();

        public SeccessAutorization() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            client.connectToServer();
        }

        protected void OnButton1Clicked(object sender, EventArgs e)
        {
            client.stopConectToServer();
            this.Destroy();
        }
    }
}

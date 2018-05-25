using System;
namespace courses
{
    public partial class NotAutorization : Gtk.Window
    {
        public NotAutorization() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnButton5Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}

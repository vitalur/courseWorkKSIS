using System;
namespace courses
{
    public partial class EmptyRegistration : Gtk.Window
    {
        public EmptyRegistration() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnButton4Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}

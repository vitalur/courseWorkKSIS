using System;
namespace courses
{
    public partial class NotCurrentLogic : Gtk.Window
    {
        public NotCurrentLogic() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnButton2Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}


// This file has been generated by the GUI designer. Do not modify.
namespace courses
{
	public partial class NotAutorization
	{
		private global::Gtk.Fixed fixed4;

		private global::Gtk.Label label5;

		private global::Gtk.Button button5;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget courses.NotAutorization
			this.Name = "courses.NotAutorization";
			this.Title = global::Mono.Unix.Catalog.GetString("NotAutorization");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child courses.NotAutorization.Gtk.Container+ContainerChild
			this.fixed4 = new global::Gtk.Fixed();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("You are not registrate!");
			this.fixed4.Add(this.label5);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.label5]));
			w1.X = 133;
			w1.Y = 107;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.button5 = new global::Gtk.Button();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Close");
			this.fixed4.Add(this.button5);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.button5]));
			w2.X = 292;
			w2.Y = 238;
			this.Add(this.fixed4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button5.Clicked += new global::System.EventHandler(this.OnButton5Clicked);
		}
	}
}

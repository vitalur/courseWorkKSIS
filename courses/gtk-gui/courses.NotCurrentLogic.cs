
// This file has been generated by the GUI designer. Do not modify.
namespace courses
{
	public partial class NotCurrentLogic
	{
		private global::Gtk.Fixed fixed2;

		private global::Gtk.Label label3;

		private global::Gtk.Button button2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget courses.NotCurrentLogic
			this.Name = "courses.NotCurrentLogic";
			this.Title = global::Mono.Unix.Catalog.GetString("NotCurrentLogic");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child courses.NotCurrentLogic.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("This user is already registered!");
			this.fixed2.Add(this.label3);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label3]));
			w1.X = 93;
			w1.Y = 73;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
			this.fixed2.Add(this.button2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button2]));
			w2.X = 277;
			w2.Y = 232;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		}
	}
}

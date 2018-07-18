using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace JAZUG.Sample.GtkSharp
{
    class MainClass
    {
		[STAThread]
        public static void Main(string[] args)
        {
			Gtk.Application.Init();
            Forms.Init();

            var app = new Core.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.Show();

            Gtk.Application.Run();
        }
    }
}

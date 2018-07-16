using AppKit;
using Foundation;
using JAZUG.Sample.Core;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace JAZUG.Sample.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        private NSWindow _window;

        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(200, 1000, 400, 600);
            this._window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
        }

        public override NSWindow MainWindow => this._window;

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender) => true;
    }
}

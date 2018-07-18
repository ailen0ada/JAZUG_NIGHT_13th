using System;
using System.Threading.Tasks;
using AppKit;
using JAZUG.Sample.Core;
using JAZUG.Sample.Mac;
using Xamarin.Forms;

[assembly: Dependency(typeof(NativeFileSelector))]
namespace JAZUG.Sample.Mac
{
    public class NativeFileSelector : IFileSelector
    {
        public Task<string> SelectSingle()
        {
            var ofd = new NSOpenPanel
            {
                AllowedFileTypes = new[] { "png", "jpg" }
            };
            var ret = ofd.RunModal();
            return Task.FromResult(ret < 1 ? "" : ofd.Url.Path);
        }
    }
}

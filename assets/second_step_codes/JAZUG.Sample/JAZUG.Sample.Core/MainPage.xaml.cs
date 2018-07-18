using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JAZUG.Sample.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var selector = DependencyService.Get<IFileSelector>();
            var path = await selector.SelectSingle();
            if (string.IsNullOrEmpty(path)) return;
            this.PathLabel.Text = path;
            this.ImageView.Source = ImageSource.FromFile(path);
        }
    }
}

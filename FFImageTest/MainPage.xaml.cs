using Microsoft.Maui.Graphics.Platform;
using System.Net.NetworkInformation;

namespace FFImageTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemTemplate = new ListViewTemplateSelector();

            var source = new List<DetailsInfo>();

            // Single custom template works fine, two will cause crash
            // Scroll down until buttons dissapear, then scroll up.
            // When last button supposed to appear - app crashes
            source.Add(new CustomDetailsInfo() { View = new Button() { Text = "Button 1" }, GroupName = "General" });
            source.Add(new CustomDetailsInfo() { View = new Button() { Text = "Button 2" }, GroupName = "General" });

            for (var i = 0; i < 50; i++)
            {
                source.Add(new TextDetailsInfo() { Description = $"Line {i}", GroupName = "General" });
            }

            listView.ItemsSource = source;
        }
    }
}

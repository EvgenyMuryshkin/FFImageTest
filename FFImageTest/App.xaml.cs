using Syncfusion.Maui.Buttons;
using Syncfusion.Maui.Calendar;
using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.ImageEditor;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.Picker;
using Syncfusion.Maui.PullToRefresh;
using Syncfusion.Maui.TabView;
using Syncfusion.Maui.TreeView;

namespace FFImageTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");// version 25.x.x

            MainPage = new AppShell();
        }
    }
}

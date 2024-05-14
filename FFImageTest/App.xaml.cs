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

            var anchorObjects = new object[]
            {
                typeof(Syncfusion.Licensing.SyncfusionLicenseProvider),
                typeof(SfTextInputLayout),
                typeof(SfButton),
                typeof(SfCalendar),
                typeof(SfImageEditor),
                typeof(SfDataGrid),
                typeof(SfPullToRefresh),
                typeof(SfTabView),
                typeof(SfTreeView),
                typeof(SfPicker),
                typeof(SfListView),
                // unconmment next line to get crash on Syncfusion.License loading
                //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense
            };

            if (anchorObjects.All(t => t != null))
                MainPage = new AppShell();
        }
    }
}

namespace FFImageTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var ff = new FFImageWrapper()
            {
                CacheDuration = null,
                CacheType = FFImageLoading.Cache.CacheType.None
            };

            var fastURL = "https://scontent.fsyd4-1.fna.fbcdn.net/v/t39.8562-6/434191236_1410755556274331_2008438480370203932_n.png?_nc_cat=103&ccb=1-7&_nc_sid=f537c7&_nc_ohc=k-goONlsEaEAb7fWUoL&_nc_ht=scontent.fsyd4-1.fna&oh=00_AfAQWSeZmDt40yVWnCWBVgQ0xhHgO6eQHgDVULhbikLtpQ&oe=6618D19E";
            var slowURL = "https://i.stack.imgur.com/rHVKc.png";

            ff.Source = fastURL;
            //ff.Source = slowURL;
            contentView.Content = ff;
        }
    }
}

﻿using Microsoft.Maui.Graphics.Platform;
using System.Net.NetworkInformation;

namespace FFImageTest
{
    public partial class MainPage : ContentPage
    {
        string fastURL = "https://scontent.fsyd4-1.fna.fbcdn.net/v/t39.8562-6/434191236_1410755556274331_2008438480370203932_n.png?_nc_cat=103&ccb=1-7&_nc_sid=f537c7&_nc_ohc=k-goONlsEaEAb7fWUoL&_nc_ht=scontent.fsyd4-1.fna&oh=00_AfAQWSeZmDt40yVWnCWBVgQ0xhHgO6eQHgDVULhbikLtpQ&oe=6618D19E";
        string slowURL = "https://i.stack.imgur.com/rHVKc.png";

        public MainPage()
        {
            InitializeComponent();

            // run something heavy
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    var client = new HttpClient();
                    var png = await client.GetByteArrayAsync(slowURL);
                    var rnd = new Random();

                    while (true)
                    {
                        Dispatcher.Dispatch(() =>
                        {
                            using (var stream = new MemoryStream(png))
                            using (var image = PlatformImage.FromStream(stream))
                            using (var resized = image.Resize(Math.Min(1500, (int)(image.Width * 0.9)), Math.Min(1500, (int)(image.Height * 0.9))))
                            using (var resizedStream = new MemoryStream())
                            {
                                resized.Save(resizedStream);
                                resizedStream.Seek(0, SeekOrigin.Begin);
                                var base64Content = Convert.ToBase64String(resizedStream.ToArray());
                            }

                            counter.Text = $"{clickCounter}/{++resizeCounter}";
                        });


                        await Task.Delay(rnd.Next(50, 100));
                    }
                }
                catch(Exception ex)
                {
                    Dispatcher.Dispatch(() =>
                    {
                        counter.Text = ex.Message;
                    });
                }

            });
        }

        int clickCounter = 0;
        int resizeCounter = 0;

        private void OnCounterClicked(object sender, EventArgs e)
        {
            counter.Text = $"{++clickCounter}/{resizeCounter}";

            var ff = new FFImageWrapper()
            {
                CacheDuration = null,
                CacheType = FFImageLoading.Cache.CacheType.None,
                Source = fastURL,
                //Source = slowURL,
            };

            contentView.Content = ff;
        }
    }
}

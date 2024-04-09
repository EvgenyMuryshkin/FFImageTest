using Xamarin.UITest;

namespace FFImageTest.Tests
{
    [TestClass]
    public class APKTests
    {
        public static string SolutionPath
        {
            get
            {
                var path = Directory.GetCurrentDirectory();

                while (path != null && !Directory.EnumerateFiles(path, "*.sln").Any())
                {
                    path = Path.GetDirectoryName(path);
                }

                return path;
            }
        }

        [TestMethod]
        public void LaunchAPK()
        {
            var apkPath = Path.Combine(SolutionPath, @"FFImageTest\bin\Release\net8.0-android\android-arm64\publish\com.companyname.ffimagetest-Signed.apk");
            var apkInfo = new FileInfo(apkPath);

            var app = ConfigureApp
              .Android
              .EnableLocalScreenshots()
              .ApkFile(apkInfo.FullName)
              .StartApp();
        }
    }
}
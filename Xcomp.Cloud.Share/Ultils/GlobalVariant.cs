
namespace Xcomp.Web.Cloud.Share.Ultils
{
    public static class GlobalVariants
    {
        public static string DataFolder;
        public static string ImageFolder = "Image";
        public const string ANDROID = "ANDROID";
        public const string IOS = "IOS";
        public const string ACCESSTOKEN = "data";
        private static string _fileVersion;
        public static string FileVersion { get => _fileVersion; }
        public static void InitFileVersion()
        {
            _fileVersion = DateTime.Now.Ticks.ToString();
        }
    }
}

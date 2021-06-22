using Windows.ApplicationModel.Resources;

namespace CD_01.Helpers
{
    public static class ErrorMessageHelper
    {
        private static ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("ErrorMessages");

        public static string GetErrorMessageResource(string name)
        {
            return _resourceLoader.GetString(name);
        }
    }
}

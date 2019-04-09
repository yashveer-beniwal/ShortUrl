using System;
namespace testunity.Utilities
{
    public static class CheckUrlValidity
    {
        public static bool CheckURLValid(string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
        }

        public static bool CheckHttpInUrl(string source)
        {
            if (source.Contains("http"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

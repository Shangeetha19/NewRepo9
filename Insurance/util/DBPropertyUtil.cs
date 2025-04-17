using System.IO;

namespace Insurance.util
{
    public class DBPropertyUtil
    {
        public static string GetPropertyString(string fileName)
        {
            return File.ReadAllText($"resources/{fileName}");
        }
    }
}


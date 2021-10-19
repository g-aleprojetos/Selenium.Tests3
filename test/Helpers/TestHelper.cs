using System.IO;
using System.Reflection;

namespace test.Helpers
{
    public class TestHelper
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}

using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace CD_01.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new CD_01.App(), args);
            host.Run();
        }
    }
}

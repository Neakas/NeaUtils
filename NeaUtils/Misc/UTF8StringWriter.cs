using System.IO;
using System.Text;

namespace NeaUtils.Misc
{
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}

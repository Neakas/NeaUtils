using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeaUtils.Extensions.Datentypen
{
    public static class StringExtensions
    {
        public static string DefaultIfNull(this string value, string Default = "") => value ?? Default;
    }
}

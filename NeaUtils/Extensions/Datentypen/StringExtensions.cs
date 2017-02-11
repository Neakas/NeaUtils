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

        public static string ReplaceAll(this string value, Dictionary<char, char> sourcetotarget) => sourcetotarget.Aggregate(value, (current, entry) => current.Replace(entry.Key, entry.Value));

        public static string ReplaceAll(this string value, Dictionary<string, string> sourcetotarget) => sourcetotarget.Aggregate(value, (current, entry) => current.Replace(entry.Key, entry.Value));

        public static string ReplaceAll(this string value, string replacewith, params string[] valuesToRemove) => valuesToRemove.Aggregate(value, (current, val) => current.Replace(val, replacewith));

    }
}

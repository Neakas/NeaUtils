using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeaUtils.Application
{
    public static class ApplicationHelper
    {
        public static DirectoryInfo GetApplicationExecutionDirectory()
        {
            var location = System.AppDomain.CurrentDomain.BaseDirectory;
            return location != null ? new DirectoryInfo(location) : null;
        }

        /// <summary>
        /// Gets the Ressource as Stream vom the Embedded Ressources.
        /// Path looks like: "MyNamespace.MyTextFile.txt"
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static Stream GetEmbeddedRessourceAsStream(Assembly executingAssembly,string Path)
        {
            try
            {
                return executingAssembly.GetManifestResourceStream(Path);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}

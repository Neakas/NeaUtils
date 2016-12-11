using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}

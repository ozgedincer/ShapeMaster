using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    public class DirectoryService
    {
        public static string GetDirectory() => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        public static bool Exists(string path)
        {
            if (Directory.Exists(path)) return true;
            else
            {
                Directory.CreateDirectory(path);
                return false;
            }
        }
        public static bool Exists()
        {
            string path = GetDirectory();

            if (Directory.Exists(path)) return true;
            else
            {
                Directory.CreateDirectory(path);
                return false;
            }
        }
    }
}

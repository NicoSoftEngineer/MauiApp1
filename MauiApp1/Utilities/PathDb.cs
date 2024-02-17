using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Utilities
{
    public class PathDb
    {
        public static string GetPath(string dbName)
        {
            var path = string.Empty;

            if( DeviceInfo.Platform == DevicePlatform.iOS)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = Path.Combine(path, "..", "Library", dbName);
            }
            else
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(path, dbName);
            }

            return path;
        }
    }
}


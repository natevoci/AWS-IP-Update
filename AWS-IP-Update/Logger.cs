using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_IP_Update
{
    internal class Logger
    {
        public static string LogPath = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\AWS-IP-Update";

        public delegate void LogEvent(string message);
        public static event LogEvent LogAdded = delegate { };

        public static void WriteLine(string message)
        {
            if (!System.IO.Directory.Exists(LogPath))
            {
                System.IO.Directory.CreateDirectory(LogPath);
            }

            System.IO.File.AppendAllText($"{LogPath}\\AWS-IP-Update.log", $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {message}{Environment.NewLine}");

            if (LogAdded != null )
            {
                LogAdded(message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TMS_ClearLogFiles_Console
{
    class Program
    {

        public static string iniFileDisk;
        public static string iniFileDiskSpaceBG;
        public static string iniFileDelDaysBack;
        public static string iniFileDelFilesPath;
        public static string iniFileEmailGroup;

        static void Main(string[] args)
        {

            TMSCleanlogFilesCode myCode = new TMSCleanlogFilesCode();

            string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string fullpath = directoryName + "\\" + "TMSClearLogFile.ini";

            myCode.ReadIniFile(fullpath);

            iniFileDisk = myCode.iniFileDisk;
            iniFileDiskSpaceBG = myCode.iniFileDiskSpaceBG;
            iniFileDelDaysBack = myCode.iniFileDelDaysBack;
            iniFileDelFilesPath = myCode.iniFileDelFilesPath;
            iniFileEmailGroup = myCode.iniFileEmailGroup;

            myCode.CheckFreeSpace_Click();

            // Console.ReadLine();
        }
    }
}

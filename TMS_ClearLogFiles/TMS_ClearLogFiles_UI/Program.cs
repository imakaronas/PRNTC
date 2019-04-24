using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS_ClearLogFiles_UI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TMS_ClearLogFiles_UI());
        }

        public long GetDiskspace(string DriveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == DriveName)
                {
                    // Console.WriteLine("TotalSize :" + drive.TotalSize / (1024 * 1024 * 1024));
                    // Console.WriteLine("TotalFreeSpace :" + drive.TotalFreeSpace / (1024 * 1024 * 1024));
                    return drive.TotalFreeSpace / (1024 * 1024 * 1024);
                }
            }

            return 0;
        }


        public void DeleteLogFiles(string DriveName, DateTime dtDeleteEndDate)
        {
            //string[] filePaths = Directory.GetFiles(@"c:\MyDir\");
            //foreach (string filePath in filePaths)
            //    File.Delete(filePath);

            string sourceDir = @"" + DriveName;
            //string backupDir = @"c:\archives\2008";

            //MessageBox.Show (Convert.ToString(dtDeleteEndDate));
            int delFileCount = 0;

            try
            {
                // string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                // string[] txtList = Directory.GetFiles(sourceDir, "*.txt");
                string[] logList = Directory.GetFiles(sourceDir, "*.log.*");

                //// Copy picture files.
                //foreach (string f in picList)
                //{
                //    // Remove path from the file name.
                //    string fName = f.Substring(sourceDir.Length + 1);

                //    // Use the Path.Combine method to safely append the file name to the path.
                //    // Will overwrite if the destination file already exists.
                //    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                //}

                // Copy text files.
                //foreach (string f in txtList)
                //{

                //    // Remove path from the file name.
                //    string fName = f.Substring(sourceDir.Length + 1);

                //    try
                //    {
                //        // Will not overwrite if the destination file already exists.
                //        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                //    }

                //    // Catch exception if the file was already copied.
                //    catch (IOException copyError)
                //    {
                //        Console.WriteLine(copyError.Message);
                //    }
                //}

                List<string> lDeleteFiles = new List<string>();

                foreach (string f in logList)
                {

                    // Remove path from the file name.
                    //string fName = f.Substring(sourceDir.Length + 1);

                    string fName = f.Substring(sourceDir.Length);
                    //MessageBox.Show(fName);



                    try
                    {
                        //// Will not overwrite if the destination file already exists.
                        //File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));

                        //== The files will have the form --> system.20160401.log.1

                        string strFilenameDate = "";
                        strFilenameDate = fName.Substring(7, 8);
                        //MessageBox.Show(strFilenameDate);

                        long lngFileLogDate = 0;
                        lngFileLogDate = Convert.ToInt64(strFilenameDate);

                        string strDeleteEndDate = dtDeleteEndDate.ToString("yyyyMMdd");
                        long lngDeleteEndDate = 0;
                        lngDeleteEndDate = Convert.ToInt64(strDeleteEndDate);

                        //MessageBox.Show("lngFileLogDate : " + lngFileLogDate.ToString() + " lngDeleteStartDate : " + lngDeleteEndDate.ToString());

                        if (lngDeleteEndDate > lngFileLogDate)
                        {
                            lDeleteFiles.Add(fName);
                        }

                    }

                    // Catch exception if the file was already copied.
                    catch (IOException deleteError)
                    {
                        Console.WriteLine(deleteError.Message);
                    }
                }


                // Delete source files that were copied.
                foreach (string f in logList)
                {
                    string strDelfName = f.Substring(sourceDir.Length);

                    if (lDeleteFiles.Contains(strDelfName))
                    {
                        File.Delete(f);
                        //MessageBox.Show(f);
                        delFileCount++;
                    }


                }


                //// Delete source files that were copied.
                //foreach (string f in txtList)
                //{
                //    File.Delete(f);
                //}
                //foreach (string f in picList)
                //{
                //    File.Delete(f);
                //}
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }

            string strMsgBox = "";

            if (delFileCount > 0)
            {
                strMsgBox = "Ολοκλήρωση Διαδικασίας! \n Διαγράφηκαν " + Convert.ToString(delFileCount) + " αρχεία !!";
            }
            else
            {
                strMsgBox = "Ολοκλήρωση Διαδικασίας! \n Δεν βρέθηκαν αρχεία προς διαγραφή!!";
            }

            MessageBox.Show(strMsgBox);


        }
    }
}

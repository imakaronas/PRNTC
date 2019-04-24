using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TMS_ClearLogFiles_Console
{
    class TMSCleanlogFilesCode
    {
        public string iniFileDisk;
        public string iniFileDiskSpaceBG;
        public string iniFileDelDaysBack;
        public string iniFileDelFilesPath;
        public string iniFileEmailGroup;

        public void ReadIniFile(string myfilename)
        {
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(myfilename);

            while ((line = file.ReadLine()) != null)
            {
                //CheckCommentline

                if (line.StartsWith("<!--"))
                {
                    //1st line has Comment ...
                }
                else
                {
                    char[] delimiters = new char[] { ';' };
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    iniFileDisk = (parts[0]);
                    iniFileDiskSpaceBG = (parts[1]);
                    iniFileDelDaysBack = (parts[2]);
                    iniFileDelFilesPath = (parts[3]);
                    iniFileEmailGroup = (parts[4]);
                }

            }

            file.Close();
        }

        public void CheckFreeSpace_Click()
        {
            string strDrive = iniFileDisk.ToString();
            long lngMyFreespace = 0;
            lngMyFreespace = GetDiskspace(@"" + strDrive);

            //== Check Disk Free Space and send email =========================================================
            if (lngMyFreespace <= Convert.ToInt64(iniFileDiskSpaceBG))
            {
                string strSendEmailMsgSubject = "";
                strSendEmailMsgSubject = "TMS Disk Space Info";

                string strSendEmailMsgBody = "";
                string strSendEmailMsgBody1 = string.Empty;
                string strSendEmailMsgBody2 = string.Empty;
                string strSendEmailMsgBody3 = string.Empty;

                strSendEmailMsgBody1 = "Dear All, " + "\n" + "\n";
                strSendEmailMsgBody2 = "There are only " + Convert.ToString(lngMyFreespace) + "GB Free on Disk!" + "\n" + "\n" + "\n";
                strSendEmailMsgBody3 = "Regards," + "\n" + "WATCH4 TMS Support Team";
                strSendEmailMsgBody = strSendEmailMsgBody1 + strSendEmailMsgBody2 + strSendEmailMsgBody3;

                //sendEMailThroughOUTLOOK(strSendEmailMsg);
                SendEMailThroughSMTP(iniFileEmailGroup, strSendEmailMsgSubject, strSendEmailMsgBody);
            }
            //==================================================================================================

            //== Procedure to Delete Files, free Disk Free Space and send email ================================
            if (lngMyFreespace <= Convert.ToInt64(iniFileDiskSpaceBG))
            {
                string strDelSendEmailMsgSubject = "";
                strDelSendEmailMsgSubject = "TMS Disk Space Info (Delete Files)";

                //== Initialize DateTime for Delete Files Procedure
                //== The rule is that you must check and delete files from Drive till the start of the Previous month
                //== e.g. current date 14/7/2016 --> check and delete files till --> 1/6/2016 
                DateTime dtDeleteStartDate;
                dtDeleteStartDate = DateTime.Now;
                DateTime dtDeleteEndDate;
                dtDeleteEndDate = DateTime.Now;

                //dtDeleteStartDate = DateTime.Now.AddDays(-9);
                // 2017-09-27 Changed. The Program reads value from ini File
                //and Deletes files back (till number of Days Before) Today


                int intiniFileDelDaysBack = 0;
                intiniFileDelDaysBack = Convert.ToInt32(iniFileDelDaysBack);

                dtDeleteStartDate = DateTime.Now.AddDays(-intiniFileDelDaysBack);


                
                //int iNewMonth = dtDeleteStartDate.Month;
                //int iNewYear = dtDeleteStartDate.Year;
                //string stNewDeleteStartDate = "1/" + Convert.ToString(iNewMonth) + "/" + Convert.ToString(iNewYear);
                //DateTime dtNewDeleteStartDate = Convert.ToDateTime(stNewDeleteStartDate);
                //dtDeleteEndDate = dtNewDeleteStartDate;

                dtDeleteEndDate = dtDeleteStartDate;


                // Execute Delete procedure
                int intNumOfFeilesDeleted = 0;
                intNumOfFeilesDeleted = DeleteLogFiles(iniFileDelFilesPath, dtDeleteEndDate);

                long lngMyFreespaceAfterDelete = 0;
                lngMyFreespaceAfterDelete = GetDiskspace(@"" + strDrive);

                string strDelSendEmailMsgBody = "";
                string strDelSendEmailMsgBody0 = string.Empty;
                string strDelSendEmailMsgBody1 = string.Empty;
                string strDelSendEmailMsgBody2 = string.Empty;
                string strDelSendEmailMsgBody3 = string.Empty;

                strDelSendEmailMsgBody0 = "Dear All, " + "\n" + "\n";
                strDelSendEmailMsgBody1 = "Automatically " + Convert.ToString(intNumOfFeilesDeleted) + "  log files have been deleted !" + "\n";
                strDelSendEmailMsgBody2 = "Now there are " + Convert.ToString(lngMyFreespaceAfterDelete) + "GB free on disk!" + "\n" + "\n" + "\n";
                strDelSendEmailMsgBody3 = "Regards," + "\n" + "WATCH4 TMS Support Team";
                strDelSendEmailMsgBody = strDelSendEmailMsgBody0 + strDelSendEmailMsgBody1 + strDelSendEmailMsgBody2 + strDelSendEmailMsgBody3;

                SendEMailThroughSMTP(iniFileEmailGroup, strDelSendEmailMsgSubject, strDelSendEmailMsgBody);
            }
            //==================================================================================================
        }

        public long GetDiskspace(string DriveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {

                string Cleared_Drive_Name;
                Cleared_Drive_Name = Convert.ToString(drive.Name);
                Cleared_Drive_Name = Regex.Replace(Cleared_Drive_Name, "[:\\\\]", string.Empty);


                //if (drive.IsReady && drive.Name == DriveName)
                if (drive.IsReady && Cleared_Drive_Name == DriveName)
                {
                    // Console.WriteLine("TotalSize :" + drive.TotalSize / (1024 * 1024 * 1024));
                    // Console.WriteLine("TotalFreeSpace :" + drive.TotalFreeSpace / (1024 * 1024 * 1024));
                    return drive.TotalFreeSpace / (1024 * 1024 * 1024);
                }
            }

            return 0;
        }

        public void SendEMailThroughOUTLOOK(string strSendEmailMsg)
        {
            try
            {
                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();

                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                // Set HTMLBody. 
                //add the body of the email
                //oMsg.HTMLBody = "the body of the email";
                oMsg.HTMLBody = strSendEmailMsg;

                //Add an attachment.
                //String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //now attached the file
                // Outlook.Attachment oAttach = oMsg.Attachments.Add(@"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName);
                //Subject line
                //oMsg.Subject = "Your Subject will go here.";
                oMsg.Subject = "TMS Disk free space information";
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                //Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add("jawed.ace@gmail.com");
                //Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add("i.makaronas@printecgroup.com");
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(iniFileEmailGroup);
                //oRecips.Add(iniFileEmailGroup);
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
            }//end of catch
        }

        public void SendEMailThroughSMTP(string striniFileEmailGroup, string strSendEmailMsgSubject, string strSendEmailMsgBody)
        {
            try
            {
                //SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);
                SmtpClient smtpClient = new SmtpClient("grp-msg.printecgroup.com", 25);

                //smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
                smtpClient.Credentials = new System.Net.NetworkCredential(@"PRINTEC\GRE_TMS_INFO", "Pr1N+3C!");
                //smtpClient.Credentials = new System.Net.NetworkCredential(@"PRINTEC\devtestmail", "1|5W?+EFbW");


                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();
                //Setting From , To and CC
                //mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
                mail.From = new MailAddress("GRE_TMS_INFO@printecgroup.com", "");
                //mail.From = new MailAddress("devtestmail@printecgroup.com", "");

                mail.Subject = strSendEmailMsgSubject;
                mail.Body = strSendEmailMsgBody;
                //mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
                //mail.To.Add(new MailAddress("d.konstantakos@printecgroup.com"));
                mail.To.Add(new MailAddress(striniFileEmailGroup));

                //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));
                //mail.CC.Add(new MailAddress("i.makaronas@printecgroup.com"));

                smtpClient.Send(mail);

            }//end of try block
            catch (Exception ex)
            {
            }//end of catch
        }

        public int DeleteLogFiles(string DriveName, DateTime dtDeleteEndDate)
        {
            string sourceDir = @"" + DriveName;
            int delFileCount = 0;
            int numLogFilesDeleted = 0;

            try
            {
                string[] logList = Directory.GetFiles(sourceDir, "*.log.*");

                List<string> lDeleteFiles = new List<string>();

                foreach (string f in logList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length);

                    try
                    {
                        //== The files will have the form --> system.20160401.log.1
                        string strFilenameDate = "";
                        strFilenameDate = fName.Substring(7, 8);

                        long lngFileLogDate = 0;
                        lngFileLogDate = Convert.ToInt64(strFilenameDate);

                        string strDeleteEndDate = dtDeleteEndDate.ToString("yyyyMMdd");
                        long lngDeleteEndDate = 0;
                        lngDeleteEndDate = Convert.ToInt64(strDeleteEndDate);

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

                numLogFilesDeleted = delFileCount;
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }

            return numLogFilesDeleted;

        }
    }
}

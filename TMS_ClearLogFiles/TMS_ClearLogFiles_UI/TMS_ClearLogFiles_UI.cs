using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TMS_ClearLogFiles_UI
{
    public partial class TMS_ClearLogFiles_UI : Form
    {

        public string iniFileDisk;
        public string iniFileDiskSpaceBG;
        public string iniFileDelFilesPath;
        public string iniFileEmailGroup;
        
        Program myProgram = new Program();

        public TMS_ClearLogFiles_UI()
        {
            InitializeComponent();

            string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string fullpath = directoryName + "\\" + "TMSClearLogFile.ini";
            ReadGiventxtFile(fullpath);

            InitFields();
        }


        public void InitFields()
        {
            //== Initialize Combo Box with available Drives ===
            foreach (DriveInfo f in DriveInfo.GetDrives())
                cbDrives.Items.Add(f.ToString());
            
            cbDrives.SelectedIndex = 0;
            //================================================


            //iniFileDisk
            
            lblDiskStatus.Text = "Κατάσταση Δίσκου: Άγνωστη.";
            lblDiskStatus.ForeColor = Color.Black;
            //================================================
            
            //txtDelFilesDiskPath.Text = Convert.ToString("C:\\temp\\");




            if (iniFileDelFilesPath == "") 
            {
                txtDelFilesDiskPath.Text = Convert.ToString("C:\\CWATCH4 TMS\\Euronet\\DCS\\DCS02\\Logs\\");
            }
            else
            {
                txtDelFilesDiskPath.Text = Convert.ToString(iniFileDelFilesPath);
            }

            


            

            //================================================

        }



        //Method to Read the given file
        private void ReadGiventxtFile(string myfilename)
        {

            //int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(myfilename);


            var sepList = new List<string>();

            //Dictionary<int, List<string>> sepListDict = new Dictionary<int, List<string>>();

            while ((line = file.ReadLine()) != null)
            {

                char[] delimiters = new char[] { ';' };
                string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                //for (int i = 0; i < parts.Length; i++)
                //{
                //    //sepList.Add(parts[i]);

                    iniFileDisk = (parts[0]);
                    iniFileDiskSpaceBG = (parts[1]);
                    iniFileDelFilesPath = (parts[2]);
                    iniFileEmailGroup = (parts[3]);

                   
                //}


                //sepListDict.Add(counter++, sepList);
                sepList.Clear();

            }

            file.Close();

        }




        private void btnCheckFreeSpace_Click(object sender, EventArgs e)
        {
            string textcb1 = cbDrives.SelectedItem.ToString();
            //MessageBox.Show(textcb1);

            //==========================================================
            long lngMyFreespace = 0;
            lngMyFreespace = myProgram.GetDiskspace(textcb1);
            txtDiskFreeSpace.Text = Convert.ToString(lngMyFreespace + " GB Free");

            //== Check Disk Free Space and update Status ===============
            if (lngMyFreespace <= Convert.ToInt64(iniFileDiskSpaceBG))
            {
                lblDiskStatus.Text = "Κατάσταση Δίσκου: Σχεδόν Πλήρης!!";
                lblDiskStatus.ForeColor = Color.Red;


                if (cbSendEmail.Checked == true)
                { 
                    string strSendEmailMsg = "";
                    //strSendEmailMsg = "Υπάρχουν μόνο " + Convert.ToString(lngMyFreespace) + " GB ελεύθερα στον Δίσκο!";

                    strSendEmailMsg = "There are only " + Convert.ToString(lngMyFreespace) + "GB Free on Disk!";

                    sendEMailThroughOUTLOOK(strSendEmailMsg);

                    MessageBox.Show("Έγινε αποστολή ενημερωτικού email!", "Information email");
                }
            
            }
            else
            {
                lblDiskStatus.Text = "Κατάσταση Δίσκου: ok.";
                lblDiskStatus.ForeColor = Color.Green;
            }
            //==========================================================
        }

     


        private void btnExecute_Click(object sender, EventArgs e)
        {

            //== initialize DateTime
            //== The rule is that you must check and delete files from Drive
            //== till the start of the Previous month
            //== e.g. current date 14/7/2016 --> check and delete files till --> 1/6/2016 
            DateTime dtDeleteStartDate;
            dtDeleteStartDate = DateTime.Now;

            DateTime dtDeleteEndDate;
            dtDeleteEndDate = DateTime.Now;


            //== Checking CheckBoxes Values
            if (cb15Days.Checked == true)
            {
                dtDeleteStartDate = DateTime.Now.AddDays(-15);
            }

            if (cbMonth.Checked == true)
            {
                dtDeleteStartDate = DateTime.Now.AddDays(-30);

                int iNewMonth = dtDeleteStartDate.Month;
                int iNewYear = dtDeleteStartDate.Year;
                string  stNewDeleteStartDate = "1/"+ Convert.ToString(iNewMonth) + "/"+Convert.ToString(iNewYear);
                DateTime dtNewDeleteStartDate = Convert.ToDateTime(stNewDeleteStartDate);


                dtDeleteEndDate = dtNewDeleteStartDate;



            }

            string delMsgBox = "";

            delMsgBox = "Να προχωρήσω σε διαγραφή log αρχείων μέχρι " + Convert.ToString(dtDeleteEndDate) + ";";

            DialogResult dialogResult = MessageBox.Show(delMsgBox, "Διαγραφή log αρχείων", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                //== Execute Delete Procedure ========================================
                myProgram.DeleteLogFiles(txtDelFilesDiskPath.Text, dtDeleteEndDate);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);
            //smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
            //smtpClient.UseDefaultCredentials = true;
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = true;
            //MailMessage mail = new MailMessage();
            ////Setting From , To and CC
            //mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            //mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));
            //smtpClient.Send(mail);

            sendEMailThroughOUTLOOK("");

        }


        public void sendEMailThroughOUTLOOK(string strSendEmailMsg)
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
                oMsg.Subject = "TMS Disk Space Info";
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                //Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add("jawed.ace@gmail.com");
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add("i.makaronas@printecgroup.com");
                //oRecips.Add("d.konstantakos@printecgroup.com");

                oRecips.Add(iniFileEmailGroup);


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

        private void cbSendEmail_CheckedChanged(object sender, EventArgs e)
        {

        }//end of Email Method


         


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_VMS_Management
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            string sTitle = String.Empty;
            Program myProgram = new Program();
            myProgram.Find_IP_Address();
            sTitle = string.Format("PS VM Management [I.P. : {0}] - Settings Screen", myProgram.Find_IP_Address());
            this.Text = sTitle;

            Program MyProgram1 = new Program();

            string sApplPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string sFullPath = sApplPath + @"\PS_VMS_Management.config.xml";

            if (!File.Exists(sFullPath))
            {
                MyProgram1.CreateXMLfile();
            }
            
            // MyProgram1.ReadXMLfile(@"C:\Development\GIT\PRNTC\PS_VMS_Management\PS_VMS_Management\bin\Debug\PS_VMS_Management.config.xml");
            //MyProgram1.ReadXMLfile(@"C:\temp\PS_VMS_Management.config.xml");
            MyProgram1.ReadXMLfile(sFullPath);
            
            textBox1.Text = MyProgram1.sNBGPath.ToString();
            textBox2.Text = MyProgram1.sPBGPath.ToString();
            textBox3.Text = MyProgram1.sEFGPath.ToString();
            textBox4.Text = MyProgram1.sOLISPath.ToString();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {

            string sApplPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string sFullPath = sApplPath + @"\PS_VMS_Management.config.xml";

            Program MyProgram = new Program();
            MyProgram.UpdateXMLfile(sFullPath.ToString(), textBox1.Text.ToString(), textBox3.Text.ToString(), textBox2.Text.ToString(), textBox4.Text.ToString());

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

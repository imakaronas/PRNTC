using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Program MyProgram = new Program();
            MyProgram.CreateXMLfile();


            Program MyProgram1 = new Program();
            // MyProgram1.ReadXMLfile(@"C:\Development\GIT\PRNTC\PS_VMS_Management\PS_VMS_Management\bin\Debug\PS_VMS_Management.config.xml");
            MyProgram1.ReadXMLfile(@"C:\temp\PS_VMS_Management.config.xml");

            textBox1.Text = MyProgram1.sNBGPath.ToString();
            textBox2.Text = MyProgram1.sPBGPath.ToString();
            textBox3.Text = MyProgram1.sEFGPath.ToString();
            textBox4.Text = MyProgram1.sOLISPath.ToString();


        }
    }
}

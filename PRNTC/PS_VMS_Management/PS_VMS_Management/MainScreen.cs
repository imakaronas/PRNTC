using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_VMS_Management
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            string sTitle =  String.Empty;
            
            Program myProgram = new Program();
            myProgram.Find_IP_Address();

            sTitle = string.Format("PS VM Management [I.P. : {0}]", myProgram.Find_IP_Address());
            this.Text = sTitle;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsScreen SetScreen = new SettingsScreen();
            SetScreen.Show();
        }

        private void btnIISStart_Click(object sender, EventArgs e)
        {
            Program myProgram = new Program();
            myProgram.DoIISStart();
        }

        private void btnIIStop_Click(object sender, EventArgs e)
        {
            Program myProgram = new Program();
            myProgram.DoIISStop();
        }

        private void btnIISReset_Click(object sender, EventArgs e)
        {
            Program myProgram = new Program();
            myProgram.DoIISReset();
        }


        private void btnNBG_Click(object sender, EventArgs e)
        {
            Program myProgramNBG = new Program();
            myProgramNBG.Start_NBG_APS_Mock();
        }

        private void btnPBG_Click(object sender, EventArgs e)
        {
            Program myProgram = new Program();
            myProgram.Start_PBG_APS_Mock();
        }

        private void btnPBG_OLIS_Click(object sender, EventArgs e)
        {
            Program myProgramOLIS = new Program();
            myProgramOLIS.Start_PBG_OLIS_Mock();
        }

        private void btnEFG_Click(object sender, EventArgs e)
        {
            Program myProgramEFG = new Program();
            myProgramEFG.Start_EFG_APS_Mock();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}

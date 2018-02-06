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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program MyProgram = new Program();
            MyProgram.DoIISReset();
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Program MyProgram = new Program();
        //    MyProgram.Start_PBG_APS_Mock();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Program MyProgramOLIS = new Program();
            MyProgramOLIS.Start_PBG_OLIS_Mock();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Program MyProgramEFG = new Program();
        //    MyProgramEFG.Start_EFG_APS_Mock();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
             Program MyProgramIISStart = new Program();
             MyProgramIISStart.Start_IIS();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    Program MyProgramNBG = new Program();
        //    MyProgramNBG.Start_NBG_APS_Mock();
        //}

        private void MainScreen_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsScreen SetScreen = new SettingsScreen();
            SetScreen.Show();
         }

        //private void button6_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click_1(object sender, EventArgs e)
        //{

        //}

        private void btnIISStart_Click(object sender, EventArgs e)
        {
            Program MyProgram = new Program();
            MyProgram.DoIISStart();
        }

        private void btnIIStop_Click(object sender, EventArgs e)
        {
            Program MyProgram = new Program();
            MyProgram.DoIISStop();
        }

        private void btnIISReset_Click(object sender, EventArgs e)
        {
            Program MyProgram = new Program();
            MyProgram.DoIISReset();
        }

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}

        private void btnPBG_OLIS_Click(object sender, EventArgs e)
        {
            Program MyProgramOLIS = new Program();
            MyProgramOLIS.Start_PBG_OLIS_Mock();
        }

        private void btnPBG_Click(object sender, EventArgs e)
        {
            Program MyProgram = new Program();
            MyProgram.Start_PBG_APS_Mock();
        }

        private void btnNBG_Click(object sender, EventArgs e)
        {
            Program MyProgramNBG = new Program();
            MyProgramNBG.Start_NBG_APS_Mock();
        }

        private void btnEFG_Click(object sender, EventArgs e)
        {
            Program MyProgramEFG = new Program();
            MyProgramEFG.Start_EFG_APS_Mock();
        }
    }
}

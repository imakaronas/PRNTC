﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PS_VMS_Management
{
    public class Program
    {
        //Public variables for mock paths
        public string sNBGPath = "";
        public string sPBGPath = "";
        public string sEFGPath = "";
        public string sOLISPath = "";
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }


        public void DoIISStart()
        {
            //Process iisStart = new Process();
            //iisStart.StartInfo.FileName = "iisreset.exe";
            //iisStart.StartInfo.RedirectStandardOutput = true;
            //iisStart.StartInfo.UseShellExecute = false;
            //iisStart.Start();
            //iisStart.WaitForExit();
            System.Diagnostics.Process.Start(@"C:\Windows\System32\iisreset.exe", " /start");
        }


        public void DoIISStop()
        {
            //Process DoIISStop = new Process();
            //DoIISStop.StartInfo.FileName = "iisreset.exe";
            //DoIISStop.StartInfo.RedirectStandardOutput = true;
            //DoIISStop.StartInfo.UseShellExecute = false;
            //DoIISStop.Start();
            //DoIISStop.WaitForExit();
            //System.Diagnostics.Process.Start(@"C:\Windows\System32\iis.exe");
            System.Diagnostics.Process.Start(@"C:\Windows\System32\iisreset.exe", " /stop");
        }
        

        public void DoIISReset()
        {
            //Process iisReset = new Process();
            //iisReset.StartInfo.FileName = "iisreset.exe";
            //iisReset.StartInfo.RedirectStandardOutput = true;
            //iisReset.StartInfo.UseShellExecute = false;
            //iisReset.Start();
            //iisReset.WaitForExit();
            System.Diagnostics.Process.Start(@"C:\Windows\System32\iisreset.exe");
        }


        public void Start_NBG_APS_Mock()
        {
            if (File.Exists(sNBGPath))
            {
                //System.Diagnostics.Process.Start(@"C:\SSK_Releases_UAT\SSK_NBG_APS\MockServer\bin\Release\NBG.ServerMock.exe");
                System.Diagnostics.Process.Start(sNBGPath);
            }
        }


        public void Start_PBG_APS_Mock()
        {
            if (File.Exists(sPBGPath))
            {
                //System.Diagnostics.Process.Start(@"C:\SSK_Servers\SSK_PBG_APS\MockServer\bin\Release\Piraeus.ServerMock.exe");
                System.Diagnostics.Process.Start(sPBGPath);
            }
        }


        public void Start_PBG_OLIS_Mock()
        {
            //string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "tres.xml");
            if (File.Exists(sOLISPath))
            {
                //System.Diagnostics.Process.Start(@"C:\SSK_Servers\SSK_OLIS\MockServer\bin\Release\Piraeus.ServerMock.exe");
                System.Diagnostics.Process.Start(sOLISPath);
            }
        }


        public void Start_EFG_APS_Mock()
        {
            if (File.Exists(sEFGPath))
            {
                //System.Diagnostics.Process.Start(@"C:\SSK_Servers\SSK_EFG_APS\Server.Mock\bin\Debug\Server.Mock.exe");
                System.Diagnostics.Process.Start(sEFGPath);
            }
        }

        
        public void CreateXMLfile ()
        {
            XmlTextWriter writer = new XmlTextWriter("PS_VMS_Management.config.xml", System.Text.Encoding.UTF8);
            //XmlTextWriter writer = new XmlTextWriter(@"C:\temp\PS_VMS_Management.config.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Mocks");
            //writer.WriteStartElement("Mocks");
            CreateNode("1", "NBG", @"C:\SSK_Releases_UAT\SSK_NBG_APS\MockServer\bin\Release\NBG.ServerMock.exe", writer);
            CreateNode("2", "PBG", @"C:\SSK_Servers\SSK_PBG_APS\MockServer\bin\Release\Piraeus.ServerMock.exe", writer);
            CreateNode("3", "PBG_OLIS", @"C:\SSK_Servers\SSK_OLIS\MockServer\bin\Release\Piraeus.ServerMock.exe", writer);
            CreateNode("4", "EFG", @"C:\SSK_Servers\SSK_EFG_APS\Server.Mock\bin\Debug\Server.Mock.exe", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            //Console.WriteLine("XML File created ! ");
        }


        public void UpdateXMLfile(string sConfig_Full_Path, string sNBG_Full_Path, string sPBG_Full_Path, string sPBG_OLIS_Full_Path, string sEFG_Full_Path)
        {
            XmlTextWriter writer = new XmlTextWriter(sConfig_Full_Path, System.Text.Encoding.UTF8);
            //XmlTextWriter writer = new XmlTextWriter("PS_VMS_Management.config.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Mocks");
            //writer.WriteStartElement("Mocks");
            //CreateNode("1", "NBG", @"C:\SSK_Releases_UAT\SSK_NBG_APS\MockServer\bin\Release\NBG.ServerMock.exe", writer);
            CreateNode("1", "NBG", sNBG_Full_Path, writer);
            //CreateNode("2", "PBG", @"C:\SSK_Servers\SSK_PBG_APS\MockServer\bin\Release\Piraeus.ServerMock.exe", writer);
            CreateNode("2", "PBG", sPBG_Full_Path, writer);
            //CreateNode("3", "PBG_OLIS", @"C:\SSK_Servers\SSK_OLIS\MockServer\bin\Release\Piraeus.ServerMock.exe", writer);
            CreateNode("3", "PBG_OLIS", sPBG_OLIS_Full_Path, writer);
            //CreateNode("4", "EFG", @"C:\SSK_Servers\SSK_EFG_APS\Server.Mock\bin\Debug\Server.Mock.exe", writer);
            CreateNode("4", "EFG", sEFG_Full_Path, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            //Console.WriteLine("XML File created ! ");
        }

        public void CreateNode(string pID, string pSSKInstallation, string pPath, XmlTextWriter writer)
        {
            writer.WriteStartElement("Mock");
            writer.WriteStartElement("MockID");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("SSK_Installation");
            writer.WriteString(pSSKInstallation);
            writer.WriteEndElement();
            writer.WriteStartElement("MockPath");
            writer.WriteString(pPath);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }


        public void ReadXMLfile(string fileName)
        {

            string texttoshow = string.Empty;
            
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fileName);

            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Mock");

            for (int ioo = 0; ioo <= xmlnode.Count - 1; ioo++)
            {
                xmlnode[ioo].ChildNodes.Item(0).InnerText.Trim();
                //texttoshow = xmlnode[ioo].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[ioo].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[ioo].ChildNodes.Item(2).InnerText.Trim();
                texttoshow = xmlnode[ioo].ChildNodes.Item(2).InnerText.Trim();

                if (texttoshow.Contains("NBG"))
                {
                    sNBGPath = texttoshow;
                }
                
                if (texttoshow.Contains("PBG"))
                {
                    sPBGPath = texttoshow;
                }
                
                if (texttoshow.Contains("EFG"))
                {
                    sEFGPath = texttoshow;
                }

                if (texttoshow.Contains("OLIS"))
                {
                    sOLISPath = texttoshow;
                }

            }
        }


        public string Find_IP_Address()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            //Console.WriteLine(hostName);

            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            //Console.WriteLine("My IP Address is :" + myIP);
            //Console.ReadKey();

            return myIP;

        }
    }
}

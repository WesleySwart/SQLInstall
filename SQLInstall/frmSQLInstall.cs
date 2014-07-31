using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using V4Utils;

namespace SQLInstall
{
    public partial class frmSQLInstall : Form
    {
        V4Utils.Logger logger;

        public frmSQLInstall()
        {
            InitializeComponent();

            logger = V4Utils.Logger.GetLogger("SQLInstall");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\V4\";
                if (!Directory.Exists(openFileDialog1.InitialDirectory))
                {
                    Directory.CreateDirectory(openFileDialog1.InitialDirectory);
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    this.txtSource.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception Err)
            {
                logger.LogMsg(Err.ToString(), Logger.LogLevel.LogIsErr);
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                //Dictionary<string, string> oSession = new Dictionary<string, string>();
                string mvar_SourceDir = txtSource.Text;
                if (!mvar_SourceDir.EndsWith("\\"))
                {
                    mvar_SourceDir += "\\";
                }
                //oSession.Add("SourceDir", sroot);
                //oSession.Add("Logs_Dir", sroot + "log\\");
                //Function to install (oSession, false);

                if (radSQL2008R2.Checked)
                {
                    SQL2008Install(mvar_SourceDir);
                }
                if (radSQL2012.Checked)
                {
                    SQL2012Install(mvar_SourceDir);
                }

            }
            catch (Exception Err)
            {
                
                logger.LogMsg(Err.ToString(), Logger.LogLevel.LogIsErr);
            }

        }

        //Install SQL Express 2008 R2 64bit
        private void SQL2008Install(string mvar_SourceDir)
        {
            try
            {

                System.Diagnostics.Process mInstallSQL = new System.Diagnostics.Process();
                //mInstallSQL.StartInfo = new System.Diagnostics.ProcessStartInfo("SQLEXPRADV_x64_ENU.exe", "/INSTANCEID=\"SQLExpress\" /ACTION=\"Install\" /HIDECONSOLE /IAcceptSQLServerLicenseTerms /FEATURES=SQLENGINE,REPLICATION,FULLTEXT,RS,BIDS,SSMS,OCS /QS /X86=\"False\" /ERRORREPORTING=\"False\" /SQMREPORTING=\"False\" /INSTANCENAME=\"SQLExpress\" /AGTSVCSTARTUPTYPE=\"Automatic\" /ISSVCSTARTUPTYPE=\"Automatic\" /ISSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ASSVCSTARTUPTYPE=\"Automatic\" /SQLSVCSTARTUPTYPE=\"Automatic\" /SQLSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ADDCURRENTUSERASSQLADMIN=\"True\" /TCPENABLED=\"1\" /BROWSERSVCSTARTUPTYPE=\"Automatic\" /RSSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /RSSVCSTARTUPTYPE=\"Automatic\" /RSINSTALLMODE = "DefaultNativeMode" /SECURITYMODE=\"SQL\" /SAPWD=\"100%recycled");
                mInstallSQL.StartInfo = new System.Diagnostics.ProcessStartInfo(mvar_SourceDir, "/ACTION=Install  /IAcceptSQLServerLicenseTerms=true /FEATURES=SQLENGINE,REPLICATION,FULLTEXT,SSMS,OCS,RS /QS /X86=false /ERRORREPORTING=1 /SQMREPORTING=false /INSTANCEID=SQLExpress /INSTANCENAME=MSSQLSERVER /AGTSVCSTARTUPTYPE=Automatic /ISSVCSTARTUPTYPE=Automatic /ISSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ASSVCSTARTUPTYPE=Automatic /SQLSVCSTARTUPTYPE=Automatic /SQLSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ADDCURRENTUSERASSQLADMIN=true /TCPENABLED=1 /BROWSERSVCSTARTUPTYPE=Automatic /RSSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /RSSVCSTARTUPTYPE=Automatic /RSINSTALLMODE=DefaultNativeMode /SECURITYMODE=SQL /SAPWD=100%recycled /HIDECONSOLE");
                logger.LogMsg("SourceDir: " + mvar_SourceDir, Logger.LogLevel.LogIsErr);
                mInstallSQL.Start();
                mInstallSQL.WaitForExit();
                logger.LogMsg("SQL Install Complete!", Logger.LogLevel.LogIsErr);
                MessageBox.Show("Install Complete!");
            }
            catch (Exception Err)
            {
                logger.LogMsg(Err.ToString(), Logger.LogLevel.LogIsErr);
            }
        }

        //Install SQL Express 2012 R2 64bit
        private void SQL2012Install(string mvar_SourceDir)
        {
            try
            {

                System.Diagnostics.Process mInstallSQL = new System.Diagnostics.Process();
                //mInstallSQL.StartInfo = new System.Diagnostics.ProcessStartInfo("SQLEXPRADV_x64_ENU.exe", "/INSTANCEID=\"SQLExpress\" /ACTION=\"Install\" /HIDECONSOLE /IAcceptSQLServerLicenseTerms /FEATURES=SQLENGINE,REPLICATION,FULLTEXT,RS,BIDS,SSMS,OCS /QS /X86=\"False\" /ERRORREPORTING=\"False\" /SQMREPORTING=\"False\" /INSTANCENAME=\"SQLExpress\" /AGTSVCSTARTUPTYPE=\"Automatic\" /ISSVCSTARTUPTYPE=\"Automatic\" /ISSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ASSVCSTARTUPTYPE=\"Automatic\" /SQLSVCSTARTUPTYPE=\"Automatic\" /SQLSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ADDCURRENTUSERASSQLADMIN=\"True\" /TCPENABLED=\"1\" /BROWSERSVCSTARTUPTYPE=\"Automatic\" /RSSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /RSSVCSTARTUPTYPE=\"Automatic\" /RSINSTALLMODE = "DefaultNativeMode" /SECURITYMODE=\"SQL\" /SAPWD=\"100%recycled");
                mInstallSQL.StartInfo = new System.Diagnostics.ProcessStartInfo(mvar_SourceDir, "/ACTION=Install  /IAcceptSQLServerLicenseTerms=true /FEATURES=SQLENGINE,REPLICATION,FULLTEXT,SSMS,OCS,RS /QS /X86=false /ERRORREPORTING=1 /SQMREPORTING=false /INSTANCEID=SQLExpress /INSTANCENAME=MSSQLSERVER /AGTSVCSTARTUPTYPE=Automatic /ISSVCSTARTUPTYPE=Automatic /ISSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ASSVCSTARTUPTYPE=Automatic /SQLSVCSTARTUPTYPE=Automatic /SQLSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /ADDCURRENTUSERASSQLADMIN=true /TCPENABLED=1 /BROWSERSVCSTARTUPTYPE=Automatic /RSSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /RSSVCSTARTUPTYPE=Automatic /RSINSTALLMODE=DefaultNativeMode /SECURITYMODE=SQL /SAPWD=100%recycled /HIDECONSOLE");
                logger.LogMsg("SourceDir: " + mvar_SourceDir, Logger.LogLevel.LogIsErr);
                mInstallSQL.Start();
                mInstallSQL.WaitForExit();
                logger.LogMsg("SQL Install Complete!", Logger.LogLevel.LogIsErr);
                MessageBox.Show("Install Complete!");
            }
            catch (Exception Err)
            {
                logger.LogMsg(Err.ToString(), Logger.LogLevel.LogIsErr);
            }
        }
    }
}

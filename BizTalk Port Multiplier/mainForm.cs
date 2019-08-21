using Microsoft.BizTalk.ExplorerOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BizTalk_Port_Multiplier
{
    public partial class mainForm : Form
    {
        //Global Vars
        public static string fixedOutputPath = @"c:\BTSMultiplier\";
        public string outputPath = @"c:\BTSMultiplier\";
        public static string excelFile = "";
        XmlHelper helper = new XmlHelper();

        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                statusLbl.Text = "Loading Resources...";
                System.Windows.Forms.Application.DoEvents();
                envCombo.SelectedIndex = 0;
                LoadResources();
                statusLbl.Text = "Resources loaded. Waiting...";
            }
            catch (Exception ex)
            {
                actionLbl3.Text = ex.Message;
            }
        }

        #region Receive ports - this little piggy had roast beef
        private void selectRcvPortBtn_Click(object sender, EventArgs e)
        {
            if (receiveTreeView.SelectedNode != null)
                if (receiveTreeView.SelectedNode.Parent != null)
                {
                    using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                    {
                        ReceivePortCollection enm = expl.ReceivePorts;
                        foreach (ReceivePort port in enm)
                        {
                            if (port.Name == receiveTreeView.SelectedNode.Text)
                            {
                                rcvNameLbl.Text = receiveTreeView.SelectedNode.Text;
                                rcvPortNameTxt.Text = port.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                rcvPortTypeLbl.Text = port.IsTwoWay.ToString();
                            }
                        }
                    }
                }
        }
        private void rcvDuplicatebtn_Click(object sender, EventArgs e)
        {
            if (rcvNameLbl.Text != "Select a port...")
            {
                //execute btstask to create
                //https://docs.microsoft.com/en-us/biztalk/core/addresource-command-biztalk-binding
                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    statusLbl.Text = "Export started"; System.Windows.Forms.Application.DoEvents();
                    TreeNode appNode = receiveTreeView.SelectedNode.Parent;
                    TreeNode rcvNode = receiveTreeView.SelectedNode;

                    #region Handle Original names and add App name
                    FileInfo fi = new FileInfo(saveFileDialog.FileName);
                    //Add AppName
                    saveFileDialog.FileName = fi.Directory + "\\" + appNode.Text.Replace(" ", "_") + "." + fi.Name;
                    #endregion

                    //I create a file with every port in the Application
                    BtsTask(new List<string>() { receiveTreeView.SelectedNode.Text }, "BTSTask.exe", "ExportBindings /Destination:\"" + saveFileDialog.FileName + "\" /ApplicationName:"
                             + (appNode.Text.Contains(" ") ? "\"" + appNode.Text + "\"" :
                             appNode.Text), 0, saveFileDialog.FileName);

                    #region Path and Bindings handle
                    //Then, for each Port I'll create a new file where I remove the other ports, based on the global.
                    //split the path to an array
                    string[] pathArray = saveFileDialog.FileName.Split('\\');
                    string originalPath = saveFileDialog.FileName;
                    saveFileDialog.FileName = ""; //reset the path
                    for (int i = 0; i < pathArray.Length; i++)
                    {
                        //if it's the last, add the port name to it.
                        if (i == pathArray.Length - 1)
                            saveFileDialog.FileName += rcvPortNameTxt.Text + "." + pathArray[i];
                        else
                            saveFileDialog.FileName += pathArray[i] + "\\";
                    }
                    new XmlHelper().RemoveExcessBindings(originalPath, saveFileDialog.FileName, true, rcvNode.Text, rcvPortNameTxt.Text, "");

                    #endregion

                    #region Environment handle
                    //If Env is QA or PROD, replace Configs read in file
                    if ((string)envCombo.SelectedItem == "QA" || (string)envCombo.SelectedItem == "PROD")
                    {
                        var ports = new ExcelOperations().ReadExcelFile(envCombo.SelectedItem.ToString(), saveFileDialog.FileName);
                        helper.ReplaceEnvironmentBindings(ports, saveFileDialog.FileName, "Receive");
                    }
                    #endregion
                    //resets the path
                    outputPath = fixedOutputPath;

                    #region Install options
                    if (rcvInstallCb.Checked)
                    {
                        //install binding.
                        BtsTaskInstall(saveFileDialog.FileName, appNode.Text);
                    }
                    #endregion
                }
                catch (Exception ex)
                { statusLbl.Text = "Error"; actionLbl3.Text = ex.Message; }
            }
        }
        #endregion

        #region Send Ports - This little piggy had none.
        private void sendSelectBtn_Click(object sender, EventArgs e)
        {
            if (sendTreeView.SelectedNode != null)
                if (sendTreeView.SelectedNode.Parent != null)
                {
                    using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                    {
                        SendPortCollection enm = expl.SendPorts;
                        foreach (SendPort port in enm)
                        {
                            if (port.Name == sendTreeView.SelectedNode.Text)
                            {
                                sendPortLbl.Text = sendTreeView.SelectedNode.Text;
                                sendPortNametxt.Text = port.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                sendPortUriTxt.Text = port.PrimaryTransport != null ? port.PrimaryTransport.Address : "";
                                sendPortTypelbl.Text = port.PrimaryTransport != null ? port.PrimaryTransport.TransportType.Name : "";
                            }
                        }
                    }
                }
        }
        private void sendDuplicateBtn_Click(object sender, EventArgs e)
        {
            if (sendPortLbl.Text != "Select a port...")
            {
                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    statusLbl.Text = "Export started"; System.Windows.Forms.Application.DoEvents();
                    TreeNode appNode = sendTreeView.SelectedNode.Parent;
                    TreeNode sendNode = sendTreeView.SelectedNode;

                    #region Handle Original names and add App name
                    FileInfo fi = new FileInfo(saveFileDialog.FileName);
                    //Add AppName
                    saveFileDialog.FileName = fi.Directory + "\\" + appNode.Text.Replace(" ", "_") + "." + fi.Name;
                    #endregion

                    //I create a file with every port in the Application
                    BtsTask(new List<string>() { sendTreeView.SelectedNode.Text }, "BTSTask.exe", "ExportBindings /Destination:\"" + saveFileDialog.FileName + "\" /ApplicationName:"
                             + (appNode.Text.Contains(" ") ? "\"" + appNode.Text + "\"" :
                             appNode.Text), 1, saveFileDialog.FileName);

                    #region Path and Bindings handle
                    //Then, for each Port I'll create a new file where I remove the other ports, based on the global.
                    //split the path to an array
                    string[] pathArray = saveFileDialog.FileName.Split('\\');
                    string originalPath = saveFileDialog.FileName;
                    saveFileDialog.FileName = ""; //reset the path
                    for (int i = 0; i < pathArray.Length; i++)
                    {
                        //if it's the last, add the port name to it.
                        if (i == pathArray.Length - 1)
                            saveFileDialog.FileName += sendPortNametxt.Text + "." + pathArray[i];
                        else
                            saveFileDialog.FileName += pathArray[i] + "\\";
                    }
                    new XmlHelper().RemoveExcessBindings(originalPath, saveFileDialog.FileName, false, sendNode.Text, sendPortNametxt.Text, sendPortUriTxt.Text);
                    #endregion

                    #region Handle Environments
                    //If Env is QA or PROD, replace Configs read in file
                    if ((string)envCombo.SelectedItem == "QA" || (string)envCombo.SelectedItem == "PROD")
                    {
                        var ports = new ExcelOperations().ReadExcelFile(envCombo.SelectedItem.ToString(), saveFileDialog.FileName);
                        helper.ReplaceEnvironmentBindings(ports, saveFileDialog.FileName, "Receive");
                    }
                    #endregion
                    //resets the path
                    outputPath = fixedOutputPath;
                    if (sendInstallCb.Checked)
                        BtsTaskInstall(saveFileDialog.FileName, appNode.Text);
                }
                catch (Exception ex)
                { statusLbl.Text = "Error"; actionLbl3.Text = ex.Message; }
            }
        }
        #endregion

        #region Controls lifecycle
        private void loadResourcesBtn_Click(object sender, EventArgs e)
        {
            LoadResources();
        }
        private void connStrBtn_Click(object sender, EventArgs e)
        {
            connectionForm f = new connectionForm();
            f.ShowDialog();
        }
        private void setOutputBtn_Click(object sender, EventArgs e)
        {//Initial path
            folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowDialog(); //shows dialog without possibility to click outside
            outputPath = folderBrowserDialog.SelectedPath; // sets the global var
        }
        private void openOutputBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(outputPath))
                Process.Start(outputPath); //Opens Explorer with the path.
            else
                MessageBox.Show("Output folder doesn't exist yet.", "Warning!", MessageBoxButtons.OK);
        }
        private void excelBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            excelFile = openFileDialog.FileName; //catches the returned file and path
        }
        /// <summary>
        /// Sets the Output directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setOutputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void openOutputFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void configConnectionStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void setEnvironmentFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ControlsReset()
        {
            actionLbl3.ResetText();
            actionLbl4.ResetText();
            statusLbl.Text = "Waiting";
        }
        private void loadResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void sendPortTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (sendPortUriTxt.Text == "New Port name")
                sendPortUriTxt.Text = "";
            else if (string.IsNullOrEmpty(sendPortUriTxt.Text))
                sendPortUriTxt.ResetText();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Helper Methods
        private int BtsTask(List<string> childNodes, string command, string args, int receiveSend, string path)
        {
            try
            {
                var proc = new Process()
                {
                    StartInfo = {
                        FileName = command,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        Arguments = args,
                        CreateNoWindow = false
                    }
                };

                proc.Start();
                string stdout = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                var exitCode = proc.ExitCode;
                proc.Close();
                if (exitCode != 0)
                    actionLbl3.Text = actionLbl4.Text = stdout;
                else
                {
                    actionLbl3.Text = actionLbl4.Text = "Export successful";
                    statusLbl.Text = "Operation Completed";
                }
                return exitCode;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private int BtsTaskInstall(string fileName, string appNode)
        {
            try
            {
                var proc = new Process()
                {
                    StartInfo = {
                        FileName = "BTSTask.exe",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        Arguments = @"ImportBindings -ApplicationName:"""+ appNode +@""" -Source:""" + fileName +"\"",
                        CreateNoWindow = false
                    }
                };

                proc.Start();
                string stdout = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                var exitCode = proc.ExitCode;
                proc.Close();
                if (exitCode != 0)
                    actionLbl3.Text = actionLbl4.Text = stdout;
                else
                {
                    actionLbl3.Text = actionLbl4.Text = "Export successful";
                    statusLbl.Text = "Operation Completed";
                }
                return exitCode;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void LoadResources()
        {
            using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
            {
                ApplicationCollection orqs = expl.Applications;
                #region Load TreeViews
                #region  Clear trees
                receiveTreeView.Nodes.Clear();
                sendTreeView.Nodes.Clear();
                #endregion

                foreach (Microsoft.BizTalk.ExplorerOM.Application app in orqs)
                {
                    #region  Creates a root node for each App in the corresponding Tree
                    var receiveNode = receiveTreeView.Nodes.Add(app.Name);
                    var sendNode = sendTreeView.Nodes.Add(app.Name);
                    #endregion

                    #region ReceivePorts
                    if (app.ReceivePorts.Count > 0)
                    {
                        foreach (ReceivePort port in app.ReceivePorts)
                        {
                            receiveNode.Nodes.Add(port.Name);
                        }
                    }
                    #endregion
                    #region SendPorts
                    if (app.SendPorts.Count > 0)
                    {
                        foreach (SendPort port in app.SendPorts)
                        {
                            sendNode.Nodes.Add(port.Name);
                        }
                    }
                    #endregion
                }
                #endregion
            }
        }

        #endregion

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void receiveTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (receiveTreeView.SelectedNode != null)
                if (receiveTreeView.SelectedNode.Parent != null)
                {
                    using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                    {
                        ReceivePortCollection enm = expl.ReceivePorts;
                        foreach (ReceivePort port in enm)
                        {
                            if (port.Name == receiveTreeView.SelectedNode.Text)
                            {
                                rcvNameLbl.Text = receiveTreeView.SelectedNode.Text;
                                rcvPortNameTxt.Text = port.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                rcvPortTypeLbl.Text = port.IsTwoWay.ToString();
                            }
                        }
                    }
                }
        }

        private void sendTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (sendTreeView.SelectedNode != null)
                if (sendTreeView.SelectedNode.Parent != null)
                {
                    using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                    {
                        SendPortCollection enm = expl.SendPorts;
                        foreach (SendPort port in enm)
                        {
                            if (port.Name == sendTreeView.SelectedNode.Text)
                            {
                                sendPortLbl.Text = sendTreeView.SelectedNode.Text;
                                sendPortNametxt.Text = port.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                sendPortUriTxt.Text = port.PrimaryTransport != null ? port.PrimaryTransport.Address : "";
                                sendPortTypelbl.Text = port.PrimaryTransport != null ? port.PrimaryTransport.TransportType.Name : "";
                            }
                        }
                    }
                }
        }
    }
}

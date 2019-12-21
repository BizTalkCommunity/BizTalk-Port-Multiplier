namespace BizTalk_Port_Multiplier
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabSendPorts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendPortTypelbl = new System.Windows.Forms.Label();
            this.sendPortNametxt = new System.Windows.Forms.TextBox();
            this.sendInstallCb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendPortLbl = new System.Windows.Forms.Label();
            this.sendPortUriTxt = new System.Windows.Forms.TextBox();
            this.actionLbl4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendTreeView = new System.Windows.Forms.TreeView();
            this.sendDuplicateBtn = new System.Windows.Forms.Button();
            this.sendSelectBtn = new System.Windows.Forms.Button();
            this.tabReceivePorts = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rcvPortTypeLbl = new System.Windows.Forms.Label();
            this.rcvPortNameTxt = new System.Windows.Forms.TextBox();
            this.rcvInstallCb = new System.Windows.Forms.CheckBox();
            this.rcvDuplicateBtn = new System.Windows.Forms.Button();
            this.rcvNameLbl = new System.Windows.Forms.Label();
            this.actionLbl3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectRcvPortBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.receiveTreeView = new System.Windows.Forms.TreeView();
            this.tabApps = new System.Windows.Forms.TabControl();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.envCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.excelBtn = new System.Windows.Forms.Button();
            this.openOutputBtn = new System.Windows.Forms.Button();
            this.setOutputBtn = new System.Windows.Forms.Button();
            this.connStrBtn = new System.Windows.Forms.Button();
            this.loadResourcesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabSendPorts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabReceivePorts.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.xlsx";
            this.openFileDialog.Filter = "Excel spreadsheet files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.openFileDialog.Title = "Select Bindings File location";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(48, 17);
            this.statusLbl.Text = "Waiting";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "BindingInfo.xml";
            this.saveFileDialog.Filter = "Xml Files (*.xml)|*.xml |All files (*.*)|*.*";
            this.saveFileDialog.InitialDirectory = "c:\\";
            this.saveFileDialog.Title = "Select Export File location";
            // 
            // tabSendPorts
            // 
            this.tabSendPorts.Controls.Add(this.label7);
            this.tabSendPorts.Controls.Add(this.panel1);
            this.tabSendPorts.Controls.Add(this.label2);
            this.tabSendPorts.Controls.Add(this.sendPortTypelbl);
            this.tabSendPorts.Controls.Add(this.sendPortNametxt);
            this.tabSendPorts.Controls.Add(this.sendInstallCb);
            this.tabSendPorts.Controls.Add(this.label5);
            this.tabSendPorts.Controls.Add(this.sendPortLbl);
            this.tabSendPorts.Controls.Add(this.sendPortUriTxt);
            this.tabSendPorts.Controls.Add(this.actionLbl4);
            this.tabSendPorts.Controls.Add(this.label4);
            this.tabSendPorts.Controls.Add(this.sendTreeView);
            this.tabSendPorts.Controls.Add(this.sendDuplicateBtn);
            this.tabSendPorts.Controls.Add(this.sendSelectBtn);
            this.tabSendPorts.Location = new System.Drawing.Point(4, 22);
            this.tabSendPorts.Name = "tabSendPorts";
            this.tabSendPorts.Padding = new System.Windows.Forms.Padding(3);
            this.tabSendPorts.Size = new System.Drawing.Size(841, 465);
            this.tabSendPorts.TabIndex = 3;
            this.tabSendPorts.Text = "Send Ports";
            this.tabSendPorts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(610, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 236);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(5, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(215, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(20, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 140);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 178);
            this.label2.MaximumSize = new System.Drawing.Size(310, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Port type:";
            // 
            // sendPortTypelbl
            // 
            this.sendPortTypelbl.AutoSize = true;
            this.sendPortTypelbl.Location = new System.Drawing.Point(469, 178);
            this.sendPortTypelbl.MaximumSize = new System.Drawing.Size(310, 134);
            this.sendPortTypelbl.Name = "sendPortTypelbl";
            this.sendPortTypelbl.Size = new System.Drawing.Size(0, 13);
            this.sendPortTypelbl.TabIndex = 28;
            // 
            // sendPortNametxt
            // 
            this.sendPortNametxt.Location = new System.Drawing.Point(414, 116);
            this.sendPortNametxt.Name = "sendPortNametxt";
            this.sendPortNametxt.Size = new System.Drawing.Size(408, 20);
            this.sendPortNametxt.TabIndex = 7;
            // 
            // sendInstallCb
            // 
            this.sendInstallCb.AutoSize = true;
            this.sendInstallCb.Location = new System.Drawing.Point(414, 201);
            this.sendInstallCb.Name = "sendInstallCb";
            this.sendInstallCb.Size = new System.Drawing.Size(143, 17);
            this.sendInstallCb.TabIndex = 27;
            this.sendInstallCb.Text = "Install Port in this server?";
            this.sendInstallCb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(256, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Resources To Export";
            // 
            // sendPortLbl
            // 
            this.sendPortLbl.Location = new System.Drawing.Point(414, 46);
            this.sendPortLbl.MaximumSize = new System.Drawing.Size(408, 134);
            this.sendPortLbl.Name = "sendPortLbl";
            this.sendPortLbl.Size = new System.Drawing.Size(408, 30);
            this.sendPortLbl.TabIndex = 25;
            this.sendPortLbl.Text = "Select a port...";
            // 
            // sendPortUriTxt
            // 
            this.sendPortUriTxt.Location = new System.Drawing.Point(414, 146);
            this.sendPortUriTxt.Name = "sendPortUriTxt";
            this.sendPortUriTxt.Size = new System.Drawing.Size(408, 20);
            this.sendPortUriTxt.TabIndex = 8;
            this.sendPortUriTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendPortTxt_MouseClick);
            // 
            // actionLbl4
            // 
            this.actionLbl4.Location = new System.Drawing.Point(263, 223);
            this.actionLbl4.MaximumSize = new System.Drawing.Size(300, 236);
            this.actionLbl4.Name = "actionLbl4";
            this.actionLbl4.Size = new System.Drawing.Size(300, 236);
            this.actionLbl4.TabIndex = 19;
            this.actionLbl4.Text = "Ready for action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Send Ports List";
            // 
            // sendTreeView
            // 
            this.sendTreeView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sendTreeView.Location = new System.Drawing.Point(8, 29);
            this.sendTreeView.Name = "sendTreeView";
            this.sendTreeView.Size = new System.Drawing.Size(221, 430);
            this.sendTreeView.TabIndex = 10;
            this.sendTreeView.DoubleClick += new System.EventHandler(this.sendTreeView_DoubleClick);
            // 
            // sendDuplicateBtn
            // 
            this.sendDuplicateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendDuplicateBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.duplicator_original;
            this.sendDuplicateBtn.Location = new System.Drawing.Point(259, 116);
            this.sendDuplicateBtn.Name = "sendDuplicateBtn";
            this.sendDuplicateBtn.Size = new System.Drawing.Size(130, 50);
            this.sendDuplicateBtn.TabIndex = 6;
            this.sendDuplicateBtn.Text = "Duplicate Port";
            this.sendDuplicateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendDuplicateBtn.UseVisualStyleBackColor = true;
            this.sendDuplicateBtn.Click += new System.EventHandler(this.sendDuplicateBtn_Click);
            // 
            // sendSelectBtn
            // 
            this.sendSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendSelectBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.add;
            this.sendSelectBtn.Location = new System.Drawing.Point(259, 43);
            this.sendSelectBtn.Name = "sendSelectBtn";
            this.sendSelectBtn.Size = new System.Drawing.Size(130, 50);
            this.sendSelectBtn.TabIndex = 5;
            this.sendSelectBtn.Text = "Select Port";
            this.sendSelectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendSelectBtn.UseVisualStyleBackColor = true;
            this.sendSelectBtn.Click += new System.EventHandler(this.sendSelectBtn_Click);
            // 
            // tabReceivePorts
            // 
            this.tabReceivePorts.Controls.Add(this.label1);
            this.tabReceivePorts.Controls.Add(this.panel4);
            this.tabReceivePorts.Controls.Add(this.label6);
            this.tabReceivePorts.Controls.Add(this.rcvPortTypeLbl);
            this.tabReceivePorts.Controls.Add(this.rcvPortNameTxt);
            this.tabReceivePorts.Controls.Add(this.rcvInstallCb);
            this.tabReceivePorts.Controls.Add(this.rcvDuplicateBtn);
            this.tabReceivePorts.Controls.Add(this.rcvNameLbl);
            this.tabReceivePorts.Controls.Add(this.actionLbl3);
            this.tabReceivePorts.Controls.Add(this.label9);
            this.tabReceivePorts.Controls.Add(this.selectRcvPortBtn);
            this.tabReceivePorts.Controls.Add(this.label3);
            this.tabReceivePorts.Controls.Add(this.receiveTreeView);
            this.tabReceivePorts.Location = new System.Drawing.Point(4, 22);
            this.tabReceivePorts.Name = "tabReceivePorts";
            this.tabReceivePorts.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceivePorts.Size = new System.Drawing.Size(841, 465);
            this.tabReceivePorts.TabIndex = 2;
            this.tabReceivePorts.Text = "Receive Ports";
            this.tabReceivePorts.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(610, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 236);
            this.panel4.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 148);
            this.label6.MaximumSize = new System.Drawing.Size(310, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Is Two Ways:";
            // 
            // rcvPortTypeLbl
            // 
            this.rcvPortTypeLbl.AutoSize = true;
            this.rcvPortTypeLbl.Location = new System.Drawing.Point(490, 148);
            this.rcvPortTypeLbl.MaximumSize = new System.Drawing.Size(310, 134);
            this.rcvPortTypeLbl.Name = "rcvPortTypeLbl";
            this.rcvPortTypeLbl.Size = new System.Drawing.Size(0, 13);
            this.rcvPortTypeLbl.TabIndex = 32;
            // 
            // rcvPortNameTxt
            // 
            this.rcvPortNameTxt.Location = new System.Drawing.Point(414, 116);
            this.rcvPortNameTxt.Name = "rcvPortNameTxt";
            this.rcvPortNameTxt.Size = new System.Drawing.Size(408, 20);
            this.rcvPortNameTxt.TabIndex = 3;
            // 
            // rcvInstallCb
            // 
            this.rcvInstallCb.AutoSize = true;
            this.rcvInstallCb.Location = new System.Drawing.Point(414, 172);
            this.rcvInstallCb.Name = "rcvInstallCb";
            this.rcvInstallCb.Size = new System.Drawing.Size(143, 17);
            this.rcvInstallCb.TabIndex = 31;
            this.rcvInstallCb.Text = "Install Port in this server?";
            this.rcvInstallCb.UseVisualStyleBackColor = true;
            // 
            // rcvDuplicateBtn
            // 
            this.rcvDuplicateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rcvDuplicateBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.duplicator_original;
            this.rcvDuplicateBtn.Location = new System.Drawing.Point(259, 116);
            this.rcvDuplicateBtn.Name = "rcvDuplicateBtn";
            this.rcvDuplicateBtn.Size = new System.Drawing.Size(130, 50);
            this.rcvDuplicateBtn.TabIndex = 2;
            this.rcvDuplicateBtn.Text = "Duplicate Port";
            this.rcvDuplicateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rcvDuplicateBtn.UseVisualStyleBackColor = true;
            this.rcvDuplicateBtn.Click += new System.EventHandler(this.rcvDuplicatebtn_Click);
            // 
            // rcvNameLbl
            // 
            this.rcvNameLbl.Location = new System.Drawing.Point(414, 46);
            this.rcvNameLbl.MaximumSize = new System.Drawing.Size(408, 134);
            this.rcvNameLbl.Name = "rcvNameLbl";
            this.rcvNameLbl.Size = new System.Drawing.Size(408, 30);
            this.rcvNameLbl.TabIndex = 21;
            this.rcvNameLbl.Text = "Select a port...";
            // 
            // actionLbl3
            // 
            this.actionLbl3.Location = new System.Drawing.Point(263, 223);
            this.actionLbl3.MaximumSize = new System.Drawing.Size(300, 236);
            this.actionLbl3.Name = "actionLbl3";
            this.actionLbl3.Size = new System.Drawing.Size(300, 236);
            this.actionLbl3.TabIndex = 19;
            this.actionLbl3.Text = "Ready for action";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(256, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Resources To Export";
            // 
            // selectRcvPortBtn
            // 
            this.selectRcvPortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectRcvPortBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.add;
            this.selectRcvPortBtn.Location = new System.Drawing.Point(259, 43);
            this.selectRcvPortBtn.Name = "selectRcvPortBtn";
            this.selectRcvPortBtn.Size = new System.Drawing.Size(130, 50);
            this.selectRcvPortBtn.TabIndex = 1;
            this.selectRcvPortBtn.Text = "Select Port";
            this.selectRcvPortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.selectRcvPortBtn.UseVisualStyleBackColor = true;
            this.selectRcvPortBtn.Click += new System.EventHandler(this.selectRcvPortBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receive Ports List";
            // 
            // receiveTreeView
            // 
            this.receiveTreeView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.receiveTreeView.Location = new System.Drawing.Point(8, 29);
            this.receiveTreeView.Name = "receiveTreeView";
            this.receiveTreeView.Size = new System.Drawing.Size(221, 430);
            this.receiveTreeView.TabIndex = 4;
            this.receiveTreeView.DoubleClick += new System.EventHandler(this.receiveTreeView_DoubleClick);
            // 
            // tabApps
            // 
            this.tabApps.Controls.Add(this.tabReceivePorts);
            this.tabApps.Controls.Add(this.tabSendPorts);
            this.tabApps.Location = new System.Drawing.Point(3, 83);
            this.tabApps.Name = "tabApps";
            this.tabApps.SelectedIndex = 0;
            this.tabApps.Size = new System.Drawing.Size(849, 491);
            this.tabApps.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(181, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2, 80);
            this.label18.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(88, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 76);
            this.label17.TabIndex = 31;
            this.label17.Text = "BizTalk Port Multiplier";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(601, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Environment";
            // 
            // envCombo
            // 
            this.envCombo.FormattingEnabled = true;
            this.envCombo.Items.AddRange(new object[] {
            "Standard",
            "QA",
            "PROD"});
            this.envCombo.Location = new System.Drawing.Point(601, 56);
            this.envCombo.Name = "envCombo";
            this.envCombo.Size = new System.Drawing.Size(121, 21);
            this.envCombo.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(728, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 80);
            this.label15.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(517, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 80);
            this.label14.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(433, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 80);
            this.label12.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(349, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 80);
            this.label10.TabIndex = 24;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(265, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 80);
            this.splitter1.TabIndex = 23;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.exit_logout;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.Location = new System.Drawing.Point(736, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(70, 70);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::BizTalk_Port_Multiplier.Properties.Resources.duplicator_big;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(7, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 74);
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // excelBtn
            // 
            this.excelBtn.BackColor = System.Drawing.Color.Transparent;
            this.excelBtn.FlatAppearance.BorderSize = 0;
            this.excelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excelBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.excel;
            this.excelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.excelBtn.Location = new System.Drawing.Point(525, 7);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(70, 70);
            this.excelBtn.TabIndex = 22;
            this.excelBtn.Text = "Set Excel path";
            this.excelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.excelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.excelBtn.UseVisualStyleBackColor = false;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // openOutputBtn
            // 
            this.openOutputBtn.BackColor = System.Drawing.Color.Transparent;
            this.openOutputBtn.FlatAppearance.BorderSize = 0;
            this.openOutputBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openOutputBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.folder;
            this.openOutputBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openOutputBtn.Location = new System.Drawing.Point(441, 7);
            this.openOutputBtn.Name = "openOutputBtn";
            this.openOutputBtn.Size = new System.Drawing.Size(70, 70);
            this.openOutputBtn.TabIndex = 21;
            this.openOutputBtn.Text = "Open Output";
            this.openOutputBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openOutputBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openOutputBtn.UseVisualStyleBackColor = false;
            this.openOutputBtn.Click += new System.EventHandler(this.openOutputBtn_Click);
            // 
            // setOutputBtn
            // 
            this.setOutputBtn.BackColor = System.Drawing.Color.Transparent;
            this.setOutputBtn.FlatAppearance.BorderSize = 0;
            this.setOutputBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setOutputBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.folder;
            this.setOutputBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.setOutputBtn.Location = new System.Drawing.Point(357, 7);
            this.setOutputBtn.Name = "setOutputBtn";
            this.setOutputBtn.Size = new System.Drawing.Size(70, 70);
            this.setOutputBtn.TabIndex = 20;
            this.setOutputBtn.Text = "Set Output Folder";
            this.setOutputBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setOutputBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.setOutputBtn.UseVisualStyleBackColor = false;
            this.setOutputBtn.Click += new System.EventHandler(this.setOutputBtn_Click);
            // 
            // connStrBtn
            // 
            this.connStrBtn.BackColor = System.Drawing.Color.Transparent;
            this.connStrBtn.FlatAppearance.BorderSize = 0;
            this.connStrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connStrBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.connect_database;
            this.connStrBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connStrBtn.Location = new System.Drawing.Point(273, 7);
            this.connStrBtn.Name = "connStrBtn";
            this.connStrBtn.Size = new System.Drawing.Size(70, 70);
            this.connStrBtn.TabIndex = 19;
            this.connStrBtn.Text = "Config ConnStr";
            this.connStrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connStrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.connStrBtn.UseVisualStyleBackColor = false;
            this.connStrBtn.Click += new System.EventHandler(this.connStrBtn_Click);
            // 
            // loadResourcesBtn
            // 
            this.loadResourcesBtn.AllowDrop = true;
            this.loadResourcesBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadResourcesBtn.FlatAppearance.BorderSize = 0;
            this.loadResourcesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadResourcesBtn.ForeColor = System.Drawing.Color.Black;
            this.loadResourcesBtn.Image = global::BizTalk_Port_Multiplier.Properties.Resources.sync;
            this.loadResourcesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadResourcesBtn.Location = new System.Drawing.Point(189, 7);
            this.loadResourcesBtn.Name = "loadResourcesBtn";
            this.loadResourcesBtn.Size = new System.Drawing.Size(70, 70);
            this.loadResourcesBtn.TabIndex = 18;
            this.loadResourcesBtn.Text = "Load Resources";
            this.loadResourcesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loadResourcesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loadResourcesBtn.UseVisualStyleBackColor = false;
            this.loadResourcesBtn.Click += new System.EventHandler(this.loadResourcesBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(259, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 1);
            this.label1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(259, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(563, 1);
            this.label7.TabIndex = 36;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 597);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.envCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.excelBtn);
            this.Controls.Add(this.openOutputBtn);
            this.Controls.Add(this.setOutputBtn);
            this.Controls.Add(this.connStrBtn);
            this.Controls.Add(this.loadResourcesBtn);
            this.Controls.Add(this.tabApps);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "BizTalk Server Port Multiplier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabSendPorts.ResumeLayout(false);
            this.tabSendPorts.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabReceivePorts.ResumeLayout(false);
            this.tabReceivePorts.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabSendPorts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView sendTreeView;
        private System.Windows.Forms.TabPage tabReceivePorts;
        private System.Windows.Forms.Label actionLbl3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button selectRcvPortBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView receiveTreeView;
        private System.Windows.Forms.TabControl tabApps;
        private System.Windows.Forms.Label rcvNameLbl;
        private System.Windows.Forms.Label sendPortLbl;
        private System.Windows.Forms.TextBox sendPortUriTxt;
        private System.Windows.Forms.Button sendDuplicateBtn;
        private System.Windows.Forms.Button sendSelectBtn;
        private System.Windows.Forms.Label actionLbl4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox sendInstallCb;
        private System.Windows.Forms.TextBox sendPortNametxt;
        private System.Windows.Forms.TextBox rcvPortNameTxt;
        private System.Windows.Forms.CheckBox rcvInstallCb;
        private System.Windows.Forms.Button rcvDuplicateBtn;
        private System.Windows.Forms.Label sendPortTypelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rcvPortTypeLbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox envCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label splitter1;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button openOutputBtn;
        private System.Windows.Forms.Button setOutputBtn;
        private System.Windows.Forms.Button connStrBtn;
        private System.Windows.Forms.Button loadResourcesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}


namespace travian_maps
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblServer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.tabAlliances = new System.Windows.Forms.TabPage();
            this.xworldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listAlliances = new System.Windows.Forms.ListBox();
            this.tabOperations = new System.Windows.Forms.TabControl();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.tabOperation = new System.Windows.Forms.TabPage();
            this.btnInactiveSearch = new System.Windows.Forms.Button();
            this.btnEnemies = new System.Windows.Forms.Button();
            this.btnOpSettings = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnTEST = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAlliances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xworldBindingSource)).BeginInit();
            this.tabOperations.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.tabOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSettingsToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serverSettingsToolStripMenuItem
            // 
            this.serverSettingsToolStripMenuItem.Name = "serverSettingsToolStripMenuItem";
            this.serverSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.serverSettingsToolStripMenuItem.Text = "Server settings";
            this.serverSettingsToolStripMenuItem.Click += new System.EventHandler(this.serverSettingsToolStripMenuItem_Click);
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 43);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server: -";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last updated: -";
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: -";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlayers);
            this.tabControl1.Controls.Add(this.tabAlliances);
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 535);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(362, 509);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "Players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // tabAlliances
            // 
            this.tabAlliances.Controls.Add(this.listAlliances);
            this.tabAlliances.Location = new System.Drawing.Point(4, 22);
            this.tabAlliances.Name = "tabAlliances";
            this.tabAlliances.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlliances.Size = new System.Drawing.Size(362, 509);
            this.tabAlliances.TabIndex = 1;
            this.tabAlliances.Text = "Alliances";
            this.tabAlliances.UseVisualStyleBackColor = true;
            // 
            // listAlliances
            // 
            this.listAlliances.FormattingEnabled = true;
            this.listAlliances.Location = new System.Drawing.Point(7, 7);
            this.listAlliances.Name = "listAlliances";
            this.listAlliances.Size = new System.Drawing.Size(349, 238);
            this.listAlliances.TabIndex = 0;
            // 
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.tabTools);
            this.tabOperations.Controls.Add(this.tabOperation);
            this.tabOperations.Location = new System.Drawing.Point(384, 101);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.SelectedIndex = 0;
            this.tabOperations.Size = new System.Drawing.Size(366, 535);
            this.tabOperations.TabIndex = 7;
            // 
            // tabTools
            // 
            this.tabTools.Controls.Add(this.btnInactiveSearch);
            this.tabTools.Location = new System.Drawing.Point(4, 22);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabTools.Size = new System.Drawing.Size(358, 509);
            this.tabTools.TabIndex = 0;
            this.tabTools.Text = "Tools";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // tabOperation
            // 
            this.tabOperation.Controls.Add(this.btnParticipants);
            this.tabOperation.Controls.Add(this.btnOpSettings);
            this.tabOperation.Controls.Add(this.btnEnemies);
            this.tabOperation.Location = new System.Drawing.Point(4, 22);
            this.tabOperation.Name = "tabOperation";
            this.tabOperation.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperation.Size = new System.Drawing.Size(358, 509);
            this.tabOperation.TabIndex = 1;
            this.tabOperation.Text = "Operations";
            this.tabOperation.UseVisualStyleBackColor = true;
            // 
            // btnInactiveSearch
            // 
            this.btnInactiveSearch.Location = new System.Drawing.Point(7, 7);
            this.btnInactiveSearch.Name = "btnInactiveSearch";
            this.btnInactiveSearch.Size = new System.Drawing.Size(345, 23);
            this.btnInactiveSearch.TabIndex = 0;
            this.btnInactiveSearch.Text = "List inactive players";
            this.btnInactiveSearch.UseVisualStyleBackColor = true;
            // 
            // btnEnemies
            // 
            this.btnEnemies.Location = new System.Drawing.Point(7, 36);
            this.btnEnemies.Name = "btnEnemies";
            this.btnEnemies.Size = new System.Drawing.Size(345, 23);
            this.btnEnemies.TabIndex = 0;
            this.btnEnemies.Text = "Choose target villages";
            this.btnEnemies.UseVisualStyleBackColor = true;
            // 
            // btnOpSettings
            // 
            this.btnOpSettings.Location = new System.Drawing.Point(6, 7);
            this.btnOpSettings.Name = "btnOpSettings";
            this.btnOpSettings.Size = new System.Drawing.Size(345, 23);
            this.btnOpSettings.TabIndex = 1;
            this.btnOpSettings.Text = "Operation settings";
            this.btnOpSettings.UseVisualStyleBackColor = true;
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(7, 66);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(344, 23);
            this.btnParticipants.TabIndex = 2;
            this.btnParticipants.Text = "Edit participant villages";
            this.btnParticipants.UseVisualStyleBackColor = true;
            // 
            // btnTEST
            // 
            this.btnTEST.Location = new System.Drawing.Point(231, 45);
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.Size = new System.Drawing.Size(174, 34);
            this.btnTEST.TabIndex = 8;
            this.btnTEST.Text = "test button";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.btnTEST);
            this.Controls.Add(this.tabOperations);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travian Maps";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAlliances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xworldBindingSource)).EndInit();
            this.tabOperations.ResumeLayout(false);
            this.tabTools.ResumeLayout(false);
            this.tabOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverSettingsToolStripMenuItem;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblStatus;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabAlliances;
        private System.Windows.Forms.BindingSource xworldBindingSource;
        private System.Windows.Forms.ListBox listAlliances;
        private System.Windows.Forms.TabControl tabOperations;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.TabPage tabOperation;
        private System.Windows.Forms.Button btnInactiveSearch;
        private System.Windows.Forms.Button btnEnemies;
        private System.Windows.Forms.Button btnOpSettings;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnTEST;
    }
}


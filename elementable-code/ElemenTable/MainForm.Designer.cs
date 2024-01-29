namespace ElemenTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contxtTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.conExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contxtOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conViewGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.conViewState = new System.Windows.Forms.ToolStripMenuItem();
            this.conViewType = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contxtAbout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.conAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quickinfo = new System.Windows.Forms.ToolTip(this.components);
            this.statstrip = new System.Windows.Forms.StatusStrip();
            this.statInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu.SuspendLayout();
            this.contxtTable.SuspendLayout();
            this.contxtOptions.SuspendLayout();
            this.contxtAbout.SuspendLayout();
            this.layoutTable.SuspendLayout();
            this.statstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.mainmenu, "mainmenu");
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainmenu.Name = "mainmenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDown = this.contxtTable;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // contxtTable
            // 
            this.contxtTable.BackColor = System.Drawing.SystemColors.Control;
            this.contxtTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conSearch,
            this.toolStripMenuItem3,
            this.toolStripSeparator4,
            this.conExit});
            this.contxtTable.Name = "contxtAbout";
            resources.ApplyResources(this.contxtTable, "contxtTable");
            // 
            // conSearch
            // 
            this.conSearch.Name = "conSearch";
            resources.ApplyResources(this.conSearch, "conSearch");
            this.conSearch.Click += new System.EventHandler(this.conSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // conExit
            // 
            this.conExit.Name = "conExit";
            resources.ApplyResources(this.conExit, "conExit");
            this.conExit.Click += new System.EventHandler(this.conExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDown = this.contxtOptions;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // contxtOptions
            // 
            this.contxtOptions.BackColor = System.Drawing.SystemColors.Control;
            this.contxtOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contxtOptions.Name = "contxtAbout";
            resources.ApplyResources(this.contxtOptions, "contxtOptions");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conViewGroups,
            this.conViewState,
            this.conViewType});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // conViewGroups
            // 
            this.conViewGroups.Name = "conViewGroups";
            resources.ApplyResources(this.conViewGroups, "conViewGroups");
            this.conViewGroups.Click += new System.EventHandler(this.conViews_Click);
            // 
            // conViewState
            // 
            this.conViewState.Name = "conViewState";
            resources.ApplyResources(this.conViewState, "conViewState");
            this.conViewState.Click += new System.EventHandler(this.conViews_Click);
            // 
            // conViewType
            // 
            this.conViewType.Name = "conViewType";
            resources.ApplyResources(this.conViewType, "conViewType");
            this.conViewType.Click += new System.EventHandler(this.conViews_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDown = this.contxtAbout;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // contxtAbout
            // 
            this.contxtAbout.BackColor = System.Drawing.SystemColors.Control;
            this.contxtAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.conAbout});
            this.contxtAbout.Name = "contxtAbout";
            resources.ApplyResources(this.contxtAbout, "contxtAbout");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // conAbout
            // 
            this.conAbout.Name = "conAbout";
            resources.ApplyResources(this.conAbout, "conAbout");
            this.conAbout.Click += new System.EventHandler(this.conAbout_Click);
            // 
            // layoutTable
            // 
            this.layoutTable.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.layoutTable, "layoutTable");
            this.layoutTable.Controls.Add(this.label26, 18, 0);
            this.layoutTable.Controls.Add(this.label25, 17, 0);
            this.layoutTable.Controls.Add(this.label24, 16, 0);
            this.layoutTable.Controls.Add(this.label23, 15, 0);
            this.layoutTable.Controls.Add(this.label22, 14, 0);
            this.layoutTable.Controls.Add(this.label21, 13, 0);
            this.layoutTable.Controls.Add(this.label20, 12, 0);
            this.layoutTable.Controls.Add(this.label19, 11, 0);
            this.layoutTable.Controls.Add(this.label18, 10, 0);
            this.layoutTable.Controls.Add(this.label17, 9, 0);
            this.layoutTable.Controls.Add(this.label16, 8, 0);
            this.layoutTable.Controls.Add(this.label15, 7, 0);
            this.layoutTable.Controls.Add(this.label14, 6, 0);
            this.layoutTable.Controls.Add(this.label13, 5, 0);
            this.layoutTable.Controls.Add(this.label12, 4, 0);
            this.layoutTable.Controls.Add(this.label11, 3, 0);
            this.layoutTable.Controls.Add(this.label10, 2, 0);
            this.layoutTable.Controls.Add(this.label9, 0, 0);
            this.layoutTable.Controls.Add(this.label8, 1, 0);
            this.layoutTable.Controls.Add(this.label7, 0, 7);
            this.layoutTable.Controls.Add(this.label6, 0, 6);
            this.layoutTable.Controls.Add(this.label5, 0, 5);
            this.layoutTable.Controls.Add(this.label4, 0, 4);
            this.layoutTable.Controls.Add(this.label3, 0, 3);
            this.layoutTable.Controls.Add(this.label2, 0, 2);
            this.layoutTable.Controls.Add(this.label1, 0, 1);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutTable_Paint);
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // quickinfo
            // 
            this.quickinfo.Popup += new System.Windows.Forms.PopupEventHandler(this.quickinfo_Popup);
            // 
            // statstrip
            // 
            this.statstrip.BackColor = System.Drawing.Color.LightGray;
            this.statstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statInfo});
            resources.ApplyResources(this.statstrip, "statstrip");
            this.statstrip.Name = "statstrip";
            this.statstrip.SizingGrip = false;
            // 
            // statInfo
            // 
            resources.ApplyResources(this.statInfo, "statInfo");
            this.statInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statInfo.Name = "statInfo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutTable);
            this.Controls.Add(this.statstrip);
            this.Controls.Add(this.mainmenu);
            this.MainMenuStrip = this.mainmenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.contxtTable.ResumeLayout(false);
            this.contxtOptions.ResumeLayout(false);
            this.contxtAbout.ResumeLayout(false);
            this.layoutTable.ResumeLayout(false);
            this.statstrip.ResumeLayout(false);
            this.statstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip quickinfo;
        private System.Windows.Forms.ContextMenuStrip contxtAbout;
        private System.Windows.Forms.ToolStripMenuItem conAbout;
        private System.Windows.Forms.StatusStrip statstrip;
        private System.Windows.Forms.ToolStripStatusLabel statInfo;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contxtTable;
        private System.Windows.Forms.ToolStripMenuItem conExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contxtOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conSearch;
        private System.Windows.Forms.ToolStripMenuItem conViewGroups;
        private System.Windows.Forms.ToolStripMenuItem conViewState;
        private System.Windows.Forms.ToolStripMenuItem conViewType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}


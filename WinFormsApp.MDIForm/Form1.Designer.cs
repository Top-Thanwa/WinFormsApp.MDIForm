namespace WinFormsApp.MDIForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuForm = new ToolStripMenuItem();
            mnuFromMax = new ToolStripMenuItem();
            mnuFromMin = new ToolStripMenuItem();
            mnuFormNormal = new ToolStripMenuItem();
            ปดโปรแกรมToolStripMenuItem = new ToolStripSeparator();
            mnuFormClose = new ToolStripMenuItem();
            mnuFormCloseAll = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuFormA = new ToolStripMenuItem();
            เปดฟอรมAToolStripMenuItem = new ToolStripMenuItem();
            mnuFormB = new ToolStripMenuItem();
            mnuFormC = new ToolStripMenuItem();
            ปรบรปแบบToolStripMenuItem = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuArrangeCascade = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuForm, mnuFormA, mnuFormB, mnuFormC, ปรบรปแบบToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuForm
            // 
            mnuForm.DropDownItems.AddRange(new ToolStripItem[] { mnuFromMax, mnuFromMin, mnuFormNormal, ปดโปรแกรมToolStripMenuItem, mnuFormClose, mnuFormCloseAll, toolStripMenuItem1, mnuExit });
            mnuForm.Name = "mnuForm";
            mnuForm.Size = new Size(55, 24);
            mnuForm.Text = "ฟอร์ม";
            // 
            // mnuFromMax
            // 
            mnuFromMax.Name = "mnuFromMax";
            mnuFromMax.Size = new Size(183, 26);
            mnuFromMax.Text = "ขยาย";
            mnuFromMax.Click += mnuFromMax_Click;
            // 
            // mnuFromMin
            // 
            mnuFromMin.Name = "mnuFromMin";
            mnuFromMin.Size = new Size(183, 26);
            mnuFromMin.Text = "ย่อ";
            mnuFromMin.Click += mnuFromMin_Click;
            // 
            // mnuFormNormal
            // 
            mnuFormNormal.Name = "mnuFormNormal";
            mnuFormNormal.Size = new Size(183, 26);
            mnuFormNormal.Text = "ปรับปกติ";
            mnuFormNormal.Click += mnuFormNormal_Click;
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            ปดโปรแกรมToolStripMenuItem.Size = new Size(180, 6);
            // 
            // mnuFormClose
            // 
            mnuFormClose.Name = "mnuFormClose";
            mnuFormClose.Size = new Size(183, 26);
            mnuFormClose.Text = "ปิดฟอร์ม";
            mnuFormClose.Click += mnuFormClose_Click;
            // 
            // mnuFormCloseAll
            // 
            mnuFormCloseAll.Name = "mnuFormCloseAll";
            mnuFormCloseAll.Size = new Size(183, 26);
            mnuFormCloseAll.Text = "ปิดฟอร์มทั้งหมด";
            mnuFormCloseAll.Click += mnuFormCloseAll_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(183, 26);
            mnuExit.Text = "ปิดโปรแกรม";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuFormA
            // 
            mnuFormA.DropDownItems.AddRange(new ToolStripItem[] { เปดฟอรมAToolStripMenuItem });
            mnuFormA.Name = "mnuFormA";
            mnuFormA.Size = new Size(91, 24);
            mnuFormA.Text = "เปิดฟอร์ม A";
            mnuFormA.Click += mnuFormA_Click;
            // 
            // เปดฟอรมAToolStripMenuItem
            // 
            เปดฟอรมAToolStripMenuItem.Name = "เปดฟอรมAToolStripMenuItem";
            เปดฟอรมAToolStripMenuItem.Size = new Size(160, 26);
            เปดฟอรมAToolStripMenuItem.Text = "เปิดฟอร์ม A";
            // 
            // mnuFormB
            // 
            mnuFormB.Name = "mnuFormB";
            mnuFormB.Size = new Size(84, 24);
            mnuFormB.Text = "เปิดฟอ์ม B";
            mnuFormB.Click += mnuFormB_Click;
            // 
            // mnuFormC
            // 
            mnuFormC.Name = "mnuFormC";
            mnuFormC.Size = new Size(90, 24);
            mnuFormC.Text = "เปิดฟอร์ม C";
            mnuFormC.Click += mnuFormC_Click;
            // 
            // ปรบรปแบบToolStripMenuItem
            // 
            ปรบรปแบบToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuTileHorizontal, mnuTileVertical, mnuArrangeCascade });
            ปรบรปแบบToolStripMenuItem.Name = "ปรบรปแบบToolStripMenuItem";
            ปรบรปแบบToolStripMenuItem.Size = new Size(64, 24);
            ปรบรปแบบToolStripMenuItem.Text = "จัดเรียง";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(224, 26);
            mnuTileHorizontal.Text = "แนวนอน";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(224, 26);
            mnuTileVertical.Text = "แนวตั้ง";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // mnuArrangeCascade
            // 
            mnuArrangeCascade.Name = "mnuArrangeCascade";
            mnuArrangeCascade.Size = new Size(224, 26);
            mnuArrangeCascade.Text = "ขั้นบรรได";
            mnuArrangeCascade.Click += mnuArrangeCascade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 488);
            Controls.Add(menuStrip1);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ทดสอบฟอร์ม MDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem mnuFromMax;
        private ToolStripMenuItem mnuFromMin;
        private ToolStripMenuItem mnuFormA;
        private ToolStripMenuItem mnuFormB;
        private ToolStripSeparator ปดโปรแกรมToolStripMenuItem;
        private ToolStripMenuItem mnuFormC;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem เปดฟอรมAToolStripMenuItem;
        private ToolStripMenuItem mnuFormNormal;
        private ToolStripMenuItem mnuFormClose;
        private ToolStripMenuItem mnuFormCloseAll;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ปรบรปแบบToolStripMenuItem;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuArrangeCascade;
    }
}

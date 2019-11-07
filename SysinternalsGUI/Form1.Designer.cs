namespace SysinternalsGUI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPsexec = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtNameComp = new System.Windows.Forms.TextBox();
            this.btnPsLoggedon = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.btnListKill = new System.Windows.Forms.Button();
            this.txtOutInfo = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnNetView = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPsexec
            // 
            this.btnPsexec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnPsexec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPsexec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnPsexec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnPsexec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsexec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnPsexec.Location = new System.Drawing.Point(12, 180);
            this.btnPsexec.Name = "btnPsexec";
            this.btnPsexec.Size = new System.Drawing.Size(72, 23);
            this.btnPsexec.TabIndex = 7;
            this.btnPsexec.Text = "Exec";
            this.btnPsexec.UseVisualStyleBackColor = false;
            this.btnPsexec.Click += new System.EventHandler(this.btnPsexec_Click);
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnPing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPing.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnPing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnPing.Location = new System.Drawing.Point(12, 30);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(72, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtNameComp
            // 
            this.txtNameComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.txtNameComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameComp.ForeColor = System.Drawing.Color.White;
            this.txtNameComp.Location = new System.Drawing.Point(101, 46);
            this.txtNameComp.Name = "txtNameComp";
            this.txtNameComp.Size = new System.Drawing.Size(595, 20);
            this.txtNameComp.TabIndex = 1;
            this.txtNameComp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameComp_KeyUp);
            // 
            // btnPsLoggedon
            // 
            this.btnPsLoggedon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnPsLoggedon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPsLoggedon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnPsLoggedon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnPsLoggedon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsLoggedon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsLoggedon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnPsLoggedon.Location = new System.Drawing.Point(12, 78);
            this.btnPsLoggedon.Name = "btnPsLoggedon";
            this.btnPsLoggedon.Size = new System.Drawing.Size(72, 23);
            this.btnPsLoggedon.TabIndex = 4;
            this.btnPsLoggedon.Text = "Loggedon";
            this.btnPsLoggedon.UseVisualStyleBackColor = false;
            this.btnPsLoggedon.Click += new System.EventHandler(this.btnPsLoggedon_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btnReboot.FlatAppearance.BorderSize = 0;
            this.btnReboot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnReboot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnReboot.Location = new System.Drawing.Point(12, 542);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(72, 23);
            this.btnReboot.TabIndex = 9;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnShutdown.Location = new System.Drawing.Point(12, 566);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(72, 23);
            this.btnShutdown.TabIndex = 10;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Name or IP of the remote computer";
            // 
            // timerPing
            // 
            this.timerPing.Interval = 1000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // btnListKill
            // 
            this.btnListKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnListKill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListKill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnListKill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnListKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListKill.ForeColor = System.Drawing.Color.White;
            this.btnListKill.Location = new System.Drawing.Point(12, 156);
            this.btnListKill.Name = "btnListKill";
            this.btnListKill.Size = new System.Drawing.Size(72, 23);
            this.btnListKill.TabIndex = 6;
            this.btnListKill.Text = "List/Kill";
            this.btnListKill.UseVisualStyleBackColor = false;
            this.btnListKill.Click += new System.EventHandler(this.btnListKill_Click);
            // 
            // txtOutInfo
            // 
            this.txtOutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.txtOutInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutInfo.DetectUrls = false;
            this.txtOutInfo.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOutInfo.Location = new System.Drawing.Point(101, 72);
            this.txtOutInfo.Name = "txtOutInfo";
            this.txtOutInfo.Size = new System.Drawing.Size(607, 523);
            this.txtOutInfo.TabIndex = 0;
            this.txtOutInfo.TabStop = false;
            this.txtOutInfo.Text = "";
            this.txtOutInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOutInfo_MouseDown);
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnClearLog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnClearLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnClearLog.Location = new System.Drawing.Point(12, 204);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(72, 23);
            this.btnClearLog.TabIndex = 8;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnSystemInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSystemInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnSystemInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSystemInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnSystemInfo.Location = new System.Drawing.Point(12, 54);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(72, 23);
            this.btnSystemInfo.TabIndex = 3;
            this.btnSystemInfo.Text = "System Info";
            this.btnSystemInfo.UseVisualStyleBackColor = false;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(91, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem1.Text = "Kill";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnFile.Location = new System.Drawing.Point(12, 105);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(72, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "Open Files";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.lblVersion.Location = new System.Drawing.Point(65, 5);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(168, 14);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Sysinternals GUI. ver. ";
            this.lblVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVersion_MouseDown);
            this.lblVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVersion_MouseMove);
            // 
            // btnNetView
            // 
            this.btnNetView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btnNetView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNetView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(62)))));
            this.btnNetView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(91)))), ((int)(((byte)(45)))));
            this.btnNetView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnNetView.Location = new System.Drawing.Point(12, 129);
            this.btnNetView.Name = "btnNetView";
            this.btnNetView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNetView.Size = new System.Drawing.Size(72, 23);
            this.btnNetView.TabIndex = 12;
            this.btnNetView.Text = "Net View";
            this.btnNetView.UseVisualStyleBackColor = false;
            this.btnNetView.Click += new System.EventHandler(this.btnNetView_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 595);
            this.Controls.Add(this.btnNetView);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtOutInfo);
            this.Controls.Add(this.btnListKill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnPsLoggedon);
            this.Controls.Add(this.txtNameComp);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnPsexec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(708, 542);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sysinternals GUI";
            this.TransparencyKey = this.BackColor;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPsexec;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox txtNameComp;
        private System.Windows.Forms.Button btnPsLoggedon;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Button btnListKill;
        private System.Windows.Forms.RichTextBox txtOutInfo;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnNetView;
    }
}


namespace usb_logger_fixed {
	partial class MainForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.stsLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.stsLblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.gridActionLog = new System.Windows.Forms.DataGridView();
			this.columnAlertMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPcUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnUsbVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnUsbSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnActionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridActionLog)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLblStatus,
            this.stsLblDatabase});
			this.statusStrip.Location = new System.Drawing.Point(0, 329);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(826, 23);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "testtest";
			// 
			// stsLblStatus
			// 
			this.stsLblStatus.Name = "stsLblStatus";
			this.stsLblStatus.Size = new System.Drawing.Size(68, 18);
			this.stsLblStatus.Text = "正常稼働中";
			// 
			// stsLblDatabase
			// 
			this.stsLblDatabase.Name = "stsLblDatabase";
			this.stsLblDatabase.Size = new System.Drawing.Size(0, 18);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuItemHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(826, 26);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.menuFile.Size = new System.Drawing.Size(68, 22);
			this.menuFile.Text = "ファイル";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.ShortcutKeyDisplayString = "";
			this.menuItemExit.Size = new System.Drawing.Size(124, 22);
			this.menuItemExit.Text = "終了する";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
			this.menuItemHelp.Name = "menuItemHelp";
			this.menuItemHelp.Size = new System.Drawing.Size(56, 22);
			this.menuItemHelp.Text = "ヘルプ";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Name = "menuItemAbout";
			this.menuItemAbout.Size = new System.Drawing.Size(250, 22);
			this.menuItemAbout.Text = "USB Logger for Clientについて";
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipText = "正常稼働中";
			this.notifyIcon.BalloonTipTitle = "USB Logger";
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "USB Logger";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// gridActionLog
			// 
			this.gridActionLog.AllowUserToAddRows = false;
			this.gridActionLog.AllowUserToDeleteRows = false;
			this.gridActionLog.AllowUserToResizeRows = false;
			this.gridActionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridActionLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridActionLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.gridActionLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gridActionLog.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.gridActionLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridActionLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAlertMark,
            this.columnLogTime,
            this.columnPcName,
            this.columnPcUser,
            this.columnUsbVendor,
            this.columnUsbSerialNo,
            this.columnAction,
            this.columnActionStatus});
			this.gridActionLog.Location = new System.Drawing.Point(0, 29);
			this.gridActionLog.Name = "gridActionLog";
			this.gridActionLog.ReadOnly = true;
			this.gridActionLog.RowHeadersVisible = false;
			this.gridActionLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.gridActionLog.RowTemplate.Height = 21;
			this.gridActionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridActionLog.ShowEditingIcon = false;
			this.gridActionLog.Size = new System.Drawing.Size(826, 297);
			this.gridActionLog.TabIndex = 2;
			// 
			// columnAlertMark
			// 
			this.columnAlertMark.HeaderText = "警告";
			this.columnAlertMark.Name = "columnAlertMark";
			this.columnAlertMark.ReadOnly = true;
			this.columnAlertMark.Width = 54;
			// 
			// columnLogTime
			// 
			this.columnLogTime.HeaderText = "日時";
			this.columnLogTime.Name = "columnLogTime";
			this.columnLogTime.ReadOnly = true;
			this.columnLogTime.Width = 54;
			// 
			// columnPcName
			// 
			this.columnPcName.HeaderText = "PC名";
			this.columnPcName.Name = "columnPcName";
			this.columnPcName.ReadOnly = true;
			this.columnPcName.Width = 57;
			// 
			// columnPcUser
			// 
			this.columnPcUser.HeaderText = "PC使用者";
			this.columnPcUser.Name = "columnPcUser";
			this.columnPcUser.ReadOnly = true;
			this.columnPcUser.Width = 81;
			// 
			// columnUsbVendor
			// 
			this.columnUsbVendor.HeaderText = "USBメモリ ベンダー";
			this.columnUsbVendor.Name = "columnUsbVendor";
			this.columnUsbVendor.ReadOnly = true;
			this.columnUsbVendor.Width = 119;
			// 
			// columnUsbSerialNo
			// 
			this.columnUsbSerialNo.HeaderText = "USBメモリ シリアル番号";
			this.columnUsbSerialNo.Name = "columnUsbSerialNo";
			this.columnUsbSerialNo.ReadOnly = true;
			this.columnUsbSerialNo.Width = 141;
			// 
			// columnAction
			// 
			this.columnAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnAction.HeaderText = "アクション";
			this.columnAction.Name = "columnAction";
			this.columnAction.ReadOnly = true;
			// 
			// columnActionStatus
			// 
			this.columnActionStatus.HeaderText = "状態";
			this.columnActionStatus.Name = "columnActionStatus";
			this.columnActionStatus.ReadOnly = true;
			this.columnActionStatus.Width = 54;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 352);
			this.Controls.Add(this.gridActionLog);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "USB LOGGER";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_formClosing);
			this.Load += new System.EventHandler(this.mainform_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridActionLog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripStatusLabel stsLblStatus;
        private System.Windows.Forms.DataGridView gridActionLog;
		private System.Windows.Forms.ToolStripStatusLabel stsLblDatabase;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAlertMark;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLogTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPcName;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPcUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnUsbVendor;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnUsbSerialNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAction;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnActionStatus;

	}
}


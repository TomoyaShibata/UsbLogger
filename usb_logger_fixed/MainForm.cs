using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TM = System.Timers;
using System.Data.SqlTypes;

namespace usb_logger_fixed {
	public partial class MainForm : Form {
		public MySqlConnection myConn = new MySqlConnection(@"Persist Security Info = False;
                                                            database = usblogger;
                                                            server   = localhost;
                                                            user id  = root;
                                                            pwd      = ;");
		// 接続済みのUSBメモリ情報を格納しておく変数
		public Dictionary<string, string> connUsbInfo = new Dictionary<string, string>();
		public int connNgUsb = 0;

		public MainForm() {
			InitializeComponent();
			this.notifyIcon.ShowBalloonTip(500);
		}

		// フォームロード時
		private void mainform_Load(object sender,EventArgs e) {
			//Program.run();
			connUsbInfo.Add("usbVendorName", "");
			connUsbInfo.Add("usbSerialNo"  , "");

			SelectUsbLog();
            TimerStart();

			//insertUsbLog();
		}

        //一定時間ごとに実行
		public void TimerStart() {
		    TM.Timer timer  =  new TM.Timer();
		    timer.Elapsed   += new TM.ElapsedEventHandler(insertUsbLog);
		    timer.Interval  =  1000;
		    timer.AutoReset =  true;
		    timer.Enabled   =  true;
		    timer.Start();
		}

		private void mainform_formClosing(object sender,FormClosingEventArgs e) {
			e.Cancel = true;
			this.Visible = false;
			this.notifyIcon.Visible = true;
		}

		private void menuItemExit_Click(object sender,EventArgs e) {
			this.notifyIcon.Visible = false;
			Environment.Exit(0);
		}

		private void notifyIcon_MouseDoubleClick(object sender,MouseEventArgs e) {
			this.Visible = true;
			if (this.WindowState == FormWindowState.Minimized) {
				this.WindowState = FormWindowState.Normal;
			}

			this.Activate();
		}

		// USBメモリ接続ログテーブルから全件取得
		public void SelectUsbLog() {
			DataTable dtSelectUsbLog = new DataTable();

			MySqlCommand commSelectUsbLog       = new MySqlCommand("SELECT * FROM t_log ORDER BY log_id DESC LIMIT 0, 25", myConn);
			MySqlDataAdapter adapterAlertUsbLog = new MySqlDataAdapter(commSelectUsbLog);

			try {
				myConn.Open();
				adapterAlertUsbLog.Fill(dtSelectUsbLog);

				MySqlDataReader reader =  commSelectUsbLog.ExecuteReader();
				int count = 0;

				while (reader.Read()) {
					if (gridActionLog.Rows.Count < 25) {
						gridActionLog.Rows.Add(1);
					}
					gridActionLog["columnAlertMark"   , count].Value = reader["alert_mark"];
				    gridActionLog["columnLogTime"     , count].Value = reader["log_time"];
				    gridActionLog["columnPcName"      , count].Value = reader["pc_name"];
				    gridActionLog["columnPcUser"      , count].Value = reader["pc_user_name"];
				    gridActionLog["columnUsbVendor"   , count].Value = reader["usb_vendor_name"];
				    gridActionLog["columnUsbSerialNo" , count].Value = reader["usb_serial_no"];
				    gridActionLog["columnAction"      , count].Value = reader["action"];
				    gridActionLog["columnActionStatus", count].Value = reader["action_status"];
				    count++;
				}

				myConn.Close();
			} catch (MySqlException myException) {
			}
		}

		// USBポートを監視し、USBメモリの接続が認められればDBへの挿入処理を呼び出す
        public void insertUsbLog(object source, TM.ElapsedEventArgs e) {
		//public void insertUsbLog() {
			for (int i = 0; i > gridActionLog.RowCount; i++) {
				gridActionLog.Rows.RemoveAt(i);
			}

			Mos mos = new Mos();
			// USBメモリ情報を取得
			Dictionary<string, string> usbInfo = mos.GetUsbInformation();

			// ホワイトリストと突き合わせた結果の警告値を取得
			int alertMark = CheckWhitelist(usbInfo);

			if (alertMark == 1 && connNgUsb == 0) {
				connNgUsb = 1;

				MessageBox.Show(
					"ホワイトリストに登録されていないUSBメモリの接続を確認しました。直ちに使用を中止し、接続を解除してください。",
					"USB LOGGER"
				);
			} else if (alertMark == 1 && connNgUsb == 1) {
			}

			if (usbInfo.Equals(null)) {
				connUsbInfo.Clear();
			}

			if (connUsbInfo["usbSerialNo"] != usbInfo["usbSerialNo"]) {
				connUsbInfo.Clear();

				DoInsertUsbLog(usbInfo, connUsbInfo, alertMark);
			}
		}

		// USBメモリ情報をDBへ挿入する
		public void DoInsertUsbLog(Dictionary<string, string> usbInfo, Dictionary<string, string> connUsbInfo, int alertMark) {
			Mos mos           = new Mos();
			string pcName     = mos.GetPcName();
			string pcUserName = mos.GetPcUserName();

            SqlString sqlInsertUsbLog = 
				@"INSERT t_log( log_time,  pc_name,  pc_user_name,  usb_vendor_name,  usb_serial_no,  action,  action_status,  alert_mark) 
                VALUES        (@log_time, @pc_name, @pc_user_name, @usb_vendor_name, @usb_serial_no, @action, @action_status, @alert_mark)";
			MySqlCommand commInsertUsbLog = new MySqlCommand((string)sqlInsertUsbLog, myConn);
			commInsertUsbLog.Parameters.AddWithValue("@log_time"       , DateTime.Now            );
            commInsertUsbLog.Parameters.AddWithValue("@pc_name"        , pcName                  );
            commInsertUsbLog.Parameters.AddWithValue("@pc_user_name"   , pcUserName              );
            commInsertUsbLog.Parameters.AddWithValue("@usb_vendor_name", usbInfo["usbVendorName"]);
            commInsertUsbLog.Parameters.AddWithValue("@usb_serial_no"  , usbInfo["usbSerialNo"]  );
            commInsertUsbLog.Parameters.AddWithValue("@action"         , "USBメモリの接続"        );
            commInsertUsbLog.Parameters.AddWithValue("@action_status"  , "成功"                   );
			commInsertUsbLog.Parameters.AddWithValue("@alert_mark"     , alertMark               );

			try {
				myConn.Open();
				commInsertUsbLog.ExecuteNonQuery();
				myConn.Close();
					
				connUsbInfo["usbVendorName"] = usbInfo["usbVendorName"];
				connUsbInfo["usvSerialNo"]   = usbInfo["usbSerialNo"];
			} catch (MySqlException e) {
			}

			// 表示している情報を最新に更新
			SelectUsbLog();
		}

		// ホワイトリストと接続されたUSB情報を突き合わせる
		public int CheckWhitelist(Dictionary<string, string> usbInfo) {
			int flagWhitelist = 0;
			int alertMark     = 0;
		
			SqlString sqlCheckWhitelist = 
				@"SELECT * FROM t_whitelist WHERE usb_vendor_name = '" + usbInfo["usbVendorName"] + 
				@"' AND usb_serial_no = '" + usbInfo["usbSerialNo"].Replace("\\", "\\\\") + "'";
			MySqlCommand commCheckWhitelist = new MySqlCommand((string)sqlCheckWhitelist, myConn);

			try {
                myConn.Open(); 
                flagWhitelist = Convert.ToInt32(commCheckWhitelist.ExecuteScalar());
                myConn.Close();
			} catch(MySqlException e) {
			}

			if (flagWhitelist == 0) {
				alertMark = 1;
			}

			return alertMark;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace usb_logger_web_fixed {
    public partial class Dashboard : System.Web.UI.Page {
        protected void Page_Load(object sender,EventArgs e) {
            // USB接続ログテーブルから今日・全てのレコード件数について取得
            DbUsb usbDb = new DbUsb();
            int[] arrCount = new int[2];
            arrCount       = usbDb.countUsbLog();

            ltrTodayLogCount .Text = arrCount[0].ToString();
            ltrAllLogCount.Text   = arrCount[1].ToString();

            // ホワイトリスト機能の有効/無効を取得
            DbWhitelist dbWhitelist = new DbWhitelist();
            int statusWhitelistId = dbWhitelist.statusWhitelist();

            switch (statusWhitelistId) {
                case 0:
                    ltrStatusWhitelist.Text = "無効";
                    break;
                case 1:
                    ltrStatusWhitelist.Text = "有効";
                    break;
            }

            // 未対応の警告ログを取得
            DbUsb dbUsb = new DbUsb();
            DataTable dtGetAlertUsbLog = new DataTable();
            dtGetAlertUsbLog           = dbUsb.getAlertUsbLog("all");

            //dtGetAlertUsbLog.Rows[0][0] = @"<p></p>";

            //string[] uwaaa = dtGetAlertUsbLog;

   
            //dtGetAlertUsbLog.Columns[0].ToString() = dtGetAlertUsbLog.Columns[0].ToString().Replace("1", "<img src=\"images/alert.png\">");
            gridAlertUsbLog.DataSource = dtGetAlertUsbLog;
            gridAlertUsbLog.DataBind();

            gridAlertUsbLog.Columns[0].AccessibleHeaderText = "aho";

            //gridAlertUsbLog.Columns[0].ToString().Replace("1", "<img src=\"images\alert.png\">");

            // 存在しない場合は、メッセージ表示
            if (gridAlertUsbLog.Rows.Count == 0) {
                ltrNullAlertUsbLog.Visible = Visible;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Management;
using System.Threading;
using System.IO;

namespace usb_logger_web_fixed {
    public partial class AllLog : System.Web.UI.Page {
        // ページロード
        protected void Page_Load(object sender,EventArgs e) {
            // ログインチェック
            if (Session.Count.Equals(0)) {
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            }

            //USB接続ログからの全件取得処理を呼び出し
            DbUsb dbUsb = new DbUsb();
            gridUsbLog.DataSource = dbUsb.getAllUsbLog();
            gridUsbLog.DataBind();
        }
    }
}
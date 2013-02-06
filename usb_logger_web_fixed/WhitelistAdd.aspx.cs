using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management;
using MySql.Data.MySqlClient;

namespace usb_logger_web_fixed {
    public partial class Whitelist_Add : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // ログインチェック
            if (Session.Count.Equals(0)) {
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            }

            Db db = new Db();
            MySqlCommand commGetUserName = new MySqlCommand(@"
                SELECT user_name
                FROM   t_user
                WHERE  user_id = '@user_id'
                ",
                db.conn
            );

            commGetUserName.CommandText = commGetUserName.CommandText.Replace("@user_id", (string)Session["userId"]);

            try {
                db.conn.Open();
                MySqlDataReader read = commGetUserName.ExecuteReader();
                while (read.Read()) {
                    ltrRegistrantName.Text = (string)read["user_name"];
                }
                read.Close();
                db.conn.Close();
            } catch (MySqlException mysqlE) {
            }

            // 接続されているUSBメモリ情報を表示
            ManagementObjectSearcher mosUsb = new ManagementObjectSearcher(
                "root\\CIMV2",
                "SELECT * FROM Win32_DiskDrive WHERE InterfaceType = 'USB'"
            );
            try {
                // レジストリからインターフェイスタイプがUSBであるものを検索
                if (mosUsb.Get().Count != 0) {
                    foreach (ManagementObject queryObj in mosUsb.Get()) {
                        // PNPDeviceIDに含まれるベンダー情報とシリアル番号を取得するため
                        // &区切りで配列に切り出す必要がある
                        string pnpDeviceId      = queryObj["PNPDeviceID"].ToString();
                        string[] arrPnpDeviceId = pnpDeviceId.Split('&');
                        // ベンダー情報とシリアル番号を変数へ格納
                        ltrUsbVendorName.Text = arrPnpDeviceId[1].Substring(4);
                        ltrUsbSerialNo.Text   = arrPnpDeviceId[3];
                    }
                }
            } catch (ManagementException manE) {
            }
        }
    }
}
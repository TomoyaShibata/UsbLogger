using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace usb_logger_web_fixed {
    public class DbWhitelist {
        public string exceptionMsg;
        public string errorMsg;

        Db db = new Db();

        // ホワイトリスト機能の有効/無効チェック
        public int statusWhitelist() {
            int retWhiltelistStatusId = 0;

            MySqlCommand commStatusWhilelist = new MySqlCommand("SELECT * FROM t_whitelist_status", db.conn);

            try {
                db.conn.Open();
                MySqlDataReader read = commStatusWhilelist.ExecuteReader();
                while (read.Read()) {
                    retWhiltelistStatusId = Convert.ToInt32(read["whitelist_status_id"]);
                }

                db.conn.Close();
            } catch (MySqlException e) {
            }

            return retWhiltelistStatusId;
        }
    }
}
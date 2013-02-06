using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

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

        // ホワイトリストを取得する
        public DataTable GetAllWhitelist() {
            MySqlCommand commAllSelet = new MySqlCommand(
                @"SELECT
                    whitelist.usb_vendor_name AS 'USBメモリ ベンダ名',
                    whitelist.usb_serial_no   AS 'USBメモリ シリアル番号',
                    whitelist.usb_owner_name  AS 'USBメモリ 所有者',
                    user.user_name            AS 'ホワイトリスト登録者',
                    whitelist.update_date     AS '最終更新日'
                FROM
                    t_whitelist whitelist
                JOIN
                    t_user user
                ON
                    whitelist.regist_user_id = user.user_id",
                db.conn
            );

            DataTable dtAllWhitelist = new DataTable();
            MySqlDataAdapter adapterGetAllWhitelist = new MySqlDataAdapter(commAllSelet);

            try {
                db.conn.Open();
                adapterGetAllWhitelist.Fill(dtAllWhitelist);
                db.conn.Close();
            } catch (MySqlException e) {
            }

            return dtAllWhitelist;
        }
    }
}
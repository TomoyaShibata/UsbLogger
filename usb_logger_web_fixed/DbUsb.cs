using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data.SqlTypes;

namespace usb_logger_web_fixed {
    public class DbUsb {
        Db db = new Db();

        // 全件取得する
        public DataTable getAllUsbLog() {
            MySqlCommand commAllSelect = new MySqlCommand(@"SELECT
                                                            alert_mark      AS '警告',
                                                            log_time        AS '日時',
                                                            pc_name         AS 'PC名',
                                                            pc_user_name    AS 'PCユーザ',
                                                            usb_vendor_name AS 'USBメモリベンダ名ー',
                                                            usb_serial_no   AS 'USBメモリシリアル番号',
                                                            action          AS 'アクション'
                                                            FROM  t_log
                                                            ORDER BY log_id DESC
                                                            LIMIT 0, 30", db.conn);
            DataTable dtAllSelect = new DataTable();
            MySqlDataAdapter adapterAllSelect = new MySqlDataAdapter(commAllSelect);
            // 全件取得処理を実行
            try {
                db.conn.Open();
                adapterAllSelect.Fill(dtAllSelect);
            } catch (MySqlException e) {
                db.exceptionMsg = "エラーコード：" + e.ErrorCode + "<br>エラー内容：" + e.Message + "<br>エラー原因：" + e.Source;
            } finally {
                db.conn.Close();
            }
            return dtAllSelect;
        }

        // 未対応の警告ログを取得する
        public DataTable getAlertUsbLog(string scope) {
            Db db = new Db();

            DataTable dtAlertUsbLog = new DataTable();

            MySqlCommand commGetAlertUsbLog = new MySqlCommand(@"
                SELECT  alert_mark      AS '警告',
                        log_time        AS '日時',
                        pc_name         AS 'PC名',
                        pc_user_name    AS 'PCユーザ',
                        usb_vendor_name AS 'USBメモリベンダ名',
                        usb_serial_no   AS 'USBメモリシリアル番号',
                        action          AS 'アクション'
                FROM
                        t_log
                WHERE
                        alert_mark = 1 
                ORDER BY
                        log_id DESC",
            db.conn);

            if (scope == "today") {
                DateTime dtToday = DateTime.Now;
                string today     = dtToday.ToString("yyyy-MM-dd");
                commGetAlertUsbLog.CommandText = commGetAlertUsbLog.CommandText.Replace("@condition", " AND log_time LIKE '" + today + "%' ");
            } else if (scope == "all") {
                commGetAlertUsbLog.CommandText = commGetAlertUsbLog.CommandText.Replace("@condition", "");
            }

            MySqlDataAdapter adapterAlertUsbLog = new MySqlDataAdapter(commGetAlertUsbLog);

            try {
                db.conn.Open();
                adapterAlertUsbLog.Fill(dtAlertUsbLog);
                db.conn.Close();
            } catch (MySqlException e) {
                db.exceptionMsg = "エラーコード：" + e.ErrorCode + "<br>エラー内容：" + e.Message + "<br>エラー原因：" + e.Source;
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(db.exceptionMsg);
                Debug.WriteLine(db.debugSql);
            }

            return dtAlertUsbLog;
        }

        // 未対応の警告ログ件数を取得
        public int getCountsAlertUsbLog() {
            int countsAlertUsbLog = 0;
            MySqlCommand commCountAlertUsbLog = new MySqlCommand("SELECT COUNT(log_id) FROM t_log WHERE alert_mark = 1", db.conn);

            try {
                db.conn.Open();
                countsAlertUsbLog = Convert.ToInt32(commCountAlertUsbLog.ExecuteScalar());
                db.conn.Close();
            } catch (MySqlException e) {
                db.exceptionMsg = "エラーコード：" + e.ErrorCode + "<br>エラー内容：" + e.Message + "<br>エラー原因：" + e.Source;
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(db.exceptionMsg);
                Debug.WriteLine(db.debugSql);
            }

            return countsAlertUsbLog;
        }

        // 全ての件数を取得
        public int[] countUsbLog() {
            int[] arrCount = new int[2];

            DateTime dtToday = DateTime.Now;
            string today     = dtToday.ToString("yyyy-MM-dd");

            try {
                db.conn.Open();
                // 最初のループで今日のレコード件数について取得
                for (int i = 0; i < 2; i++) {
                    MySqlCommand commCountUsbLog = new MySqlCommand("SELECT COUNT(log_id) FROM t_log", db.conn);
                    // 最初の実行で今日のログを取得するSQLを実行
                    if (i == 0) {
                        SqlString condition =  new SqlString(" WHERE log_time LIKE '" + today + "%'");
                        commCountUsbLog.CommandText += condition.ToString();
                    }

                    db.debugSql = commCountUsbLog.CommandText;
                    arrCount[i] = Convert.ToInt32(commCountUsbLog.ExecuteScalar());
                }

                db.conn.Close();
            } catch (MySqlException e) {
                db.exceptionMsg = "エラーコード：" + e.ErrorCode + "<br>エラー内容：" + e.Message + "<br>エラー原因：" + e.Source;
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(db.exceptionMsg);
                Debug.WriteLine(db.debugSql);
            }

            return arrCount;
        }
    }
}
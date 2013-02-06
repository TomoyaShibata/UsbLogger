using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace usb_logger_web_fixed {
    public class Db {
        public string exceptionMsg;
        public string errorMsg;
        public string debugSql;

        public MySqlConnection conn = new MySqlConnection(@"Persist Security Info = False;
                                                            database = usblogger;
                                                            server   = localhost;
                                                            user id  = root;
                                                            pwd      = ;");

        // ユーザテーブルを参照し、ログイン処理を行う
        public string userLogin(string userId,string userPass) {
            string hashUserPass = hashingUserPass(userPass);
            Console.WriteLine("hashUserPass:" + hashUserPass);

            MySqlCommand myCommLogin = new MySqlCommand("SELECT * FROM t_user WHERE user_id = @user_id AND hash_user_pass = @hash_user_pass",conn);
            myCommLogin.Parameters.AddWithValue("@user_id"       , userId);
            myCommLogin.Parameters.AddWithValue("@hash_user_pass", hashUserPass);

            //errorMsg = myCommLogin;

            try {
                conn.Open();

                MySqlDataReader myReader = myCommLogin.ExecuteReader();

                // ユーザID、パスワードの組み合わせが一致するレコードがない場合
                if (!myReader.Read()) {
                    errorMsg += "ユーザID、もしくはパスワードが間違っています。";
                }
            } catch (MySqlException exception) {
                errorMsg = "エラーコード：" + exception.ErrorCode + "<br>エラー内容：" + exception.Message + "<br>エラー原因：" + exception.Source;
            } finally {
                conn.Close();
            }

            return errorMsg;
        }

        public string retUserName(string userId) {
            MySqlCommand commRetUserName = new MySqlCommand("SELECT * FROM t_user WHERE user_id = '@userId'",conn);
            return null;
        }

        // パスワードをSHA256に通してハッシュ値を取得する
        public string hashingUserPass(string userPass) {
            byte[] byteUserPass = Encoding.UTF8.GetBytes(userPass);

            // ハッシュ値取得
            SHA256 crypto = new SHA256CryptoServiceProvider();
            byte[] byteHashUserPass = crypto.ComputeHash(byteUserPass);

            // バイト配列のハッシュ値を文字列に変換
            StringBuilder HashUserPass = new StringBuilder();
            for (int i = 0; i < byteHashUserPass.Length; i++) {
                HashUserPass.AppendFormat("{0:X2}",byteHashUserPass[i]);
            }

            return HashUserPass.ToString();
        }
    }
}
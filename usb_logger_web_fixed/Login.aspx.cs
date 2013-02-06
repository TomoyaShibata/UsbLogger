using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usb_logger_web_fixed {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // ログアウトリクエストをチェック
            if (Request.QueryString["request"] == "logout") {
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            }
        }

        protected void userLogin(object sender, EventArgs e) {
            Db login = new Db();
            string errorMsg = login.userLogin(txtUserId.Text, txtUserPass.Text);

            // エラーの有無を確認し、ログイン処理を行う
            if (errorMsg == null) {
                Session["loginState"] = true;
                Session["userId"]     = txtUserId.Text;

                Response.Redirect("Dashboard.aspx");
            } else {
                ltrError.Text += errorMsg;
            }
        }
    }
}
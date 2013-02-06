using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usb_logger_web_fixed {
    public partial class Whitelist : System.Web.UI.Page {
        protected void Page_Load(object sender,EventArgs e) {
            DbWhitelist dbWhitelist = new DbWhitelist();

            // ホワイトリスト機能の有効/無効を取得
            int statusWhitelistId = dbWhitelist.statusWhitelist();

            switch (statusWhitelistId) {
                case 0:
                    ltrStatusWhitelist.Text = "無効";
                    break;
                case 1:
                    ltrStatusWhitelist.Text = "有効";
                    break;
            }

            // ホワイトリスト一蘭を取得
            gridWhitelist.DataSource = dbWhitelist.GetAllWhitelist();
            gridWhitelist.DataBind();
        }
    }
}
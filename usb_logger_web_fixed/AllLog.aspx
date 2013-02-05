<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllLog.aspx.cs" Inherits="usb_logger_web_fixed.AllLog" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
    <link rel="Stylesheet" type="text/css" href="stylesheets/main.css">
    <title>USB LOGGER</title>
</head>
<body>
    <form id="mainForm" runat="server">
        <div id="outline">
            <header>
                <div id="header_wrapper">
                    <ul>
                        <li class="logo"><a href="Dashboard.aspx">USB LOGGER</a></li>
                        <li><a href="Dashboard.aspx">ダッシュボード</a></li>
                        <li><a href="AllLog.aspx">全てのログ</a></li>
						<li><a href="Whitelist.aspx">ホワイトリスト機能</a></li>
                        <li><a href="Login.aspx?request=logout">ログアウト</a></li>
                    </ul>
                </div>
            </header>   
            <section id="main">
                <div id="log_list">
                    <h4>USBメモリ 接続ログ</h4>
                    <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                    <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
                    <asp:GridView ID="gridUsbLog" runat="server" BorderStyle="None" BorderWidth="0px" GridLines="None"></asp:GridView>
                </div>
            </section>
            <footer>
                <p>Designed and built by <a href="https://www.facebook.com/shibalab" target="_blank">Ryou.Kanazawa</a></p>
            </footer>
        </div>
    </form>
</body>
</html>

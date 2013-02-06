<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllLog.aspx.cs" Inherits="usb_logger_web_fixed.AllLog" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/panel.css">
    <link rel="Stylesheet" type="text/css" href="stylesheets/main.css">
	<script type="text/javascript" src="../js/footerFixed.js"></script>
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
						<li><a href="Whitelist.aspx">ホワイトリスト</a></li>
                        <li><a href="Login.aspx?request=logout">ログアウト</a></li>
                    </ul>
                </div>
            </header>   
            <section id="main">
                <div id="info_panel">
					<div class="panel long_panel">
						<h4>全てのログ</h4>
					</div>
                    <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                    <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
                    <asp:GridView ID="gridUsbLog" runat="server" GridLines="None"></asp:GridView>
                </div>
            </section>
			<section style="clear: both"></section>
            <footer id="footer">
                <p>USB LOGGER Copyright ©2012-2013 by <a href="https://www.facebook.com/shibalab" target="_blank">Ryou.Kanazawa</a> All rights reserved.</p>
				<ul>
					<li><a href="#">USB LOGGERについて</a></li>
					<li><a href="#">ご要望・不具合報告</a></li>
					<li><a href="#">お問い合わせ</a></li>
				</ul>            
			</footer>
        </div>
    </form>
</body>
</html>

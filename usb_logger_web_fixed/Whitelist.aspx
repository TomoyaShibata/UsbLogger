<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Whitelist.aspx.cs" Inherits="usb_logger_web_fixed.Whitelist" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/gh-buttons.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/panel.css">
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
                    <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                    <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
					<div class="panel long_panel">
						<h4>ホワイトリスト設定</h4>
					</div>
					<div id="info_basic" class="panel long_panel">
						<h4>ホワイトリストの現在の状態</h4>
						<table cellpadding="0" cellspacing="0">
							<tr>
								<td><p>ホワイトリスト機能は現在<span style="color: #cc3333"><asp:Literal ID="ltrStatusWhitelist" runat="server"></asp:Literal></span>です。</p></td>
							</tr>
						</table>
					</div>
					<div id="panel_registed_whiltelist" class="panel long_panel">
						<h4>
							ホワイトリストに登録されているUSBメモリ情報
							<a href="WhitelistAddAttention.aspx" class="button" style="margin-left: 510px;">ホワイトリスト新規登録</a>
						</h4>
						<asp:GridView ID="gridWhitelist" runat="server" BorderStyle="None" BorderWidth="0px" GridLines="None"></asp:GridView>
					</div>
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

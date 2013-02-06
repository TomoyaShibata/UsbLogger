<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhitelistAddAttention.aspx.cs" Inherits="usb_logger_web_fixed.WhitelistAddAttention" %>

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
						<li><a href="Whitelist.aspx">ホワイトリスト機能</a></li>
                        <li><a href="Login.aspx?request=logout">ログアウト</a></li>
                    </ul>
                </div>
            </header>   
            <section id="main">
                <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
				<div id="panel_whitelist_add_atention" class="panel long_panel">
				<h4><img src="images/warning.png" alt="warning">ご注意 ホワイトリスト新規登録の前に</h4>
				<p>次の画面より、USBメモリのホワイトリストへの新規登録作業が開始されます。<br>
				<strong style="color: #cc3333;">登録するUSBメモリをコンピュータに接続してください。<br>
				その他のリムーバブルなUSB機器は必ず取り外して下さい。正常な登録処理が行われない恐れがあります。</strong><br>
				準備が完了致しましたら、下記ボタンより、次の画面へ移動してください。</p>
				<p style="margin-top: 50px; text-align: right;"><a href="WhitelistAdd.aspx" class="button">ホワイトリスト新規登録を開始</a></p>
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

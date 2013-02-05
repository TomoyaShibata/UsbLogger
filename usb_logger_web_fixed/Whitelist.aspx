<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Whitelist.aspx.cs" Inherits="usb_logger_web_fixed.Whitelist" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/gh-buttons.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/panel.css">
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
					<div id="info_basic" class="panel long_panel">
						<h4>ホワイトリスト</h4>
						<table cellpadding="0" cellspacing="0">
							<tr>
								<td><p>ホワイトリスト機能は現在<asp:Literal ID="ltrStatusWhitelist" runat="server"></asp:Literal></p></td>
								<td><p><a href="Whitelist_Add_Attention.aspx">ホワイトリストに新規登録する</a><p></td>
							</tr>
						</table>
					</div>
					<div id="whilte_list" class="panel long_panel">
						<h4>
							ホワイトリストに登録されているUSBメモリ情報
							<a href="WhitelistAddAttention.aspx" class="button" style="margin-left: 510px;">ホワイトリスト新規登録</a>
						</h4>
					</div>
                </div>
            </section>
            <footer>
                <p>Designed and built by <a href="https://www.facebook.com/shibalab" target="_blank">Ryou.Kanazawa</a></p>
            </footer>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhitelistAdd.aspx.cs" Inherits="usb_logger_web_fixed.Whitelist_Add" %>

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
						<li><a href="Whitelist.aspx">ホワイトリスト機能</a></li>
                        <li><a href="Login.aspx?request=logout">ログアウト</a></li>
                    </ul>
                </div>
            </header>   
            <section id="main">
                <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
				<h4>ホワイトリスト新規登録</h4>
				<div id="panel_whitelist_add" class="panel long_panel">
					<table>
						<tr>
							<td>USBメモリ ベンダー名</td>
							<td><asp:Literal ID="ltrUsbVendorName" runat="server" Text="接続されていません"></asp:Literal></td>
						</tr>
						<tr>
							<td>USBメモリ シリアル番号</td>
							<td><asp:Literal ID="ltrUsbSerialNo" runat="server" Text="接続されていません"></asp:Literal></td>
						</tr>
						<tr>
							<td>ホワイトリスト登録者</td>
							<td><asp:Literal ID="ltrRegistrantName" runat="server"></asp:Literal></td>
						</tr>
						<tr>
							<td>USBメモリ所有者</td>
							<td><asp:TextBox ID="txtUsbOwnerName" runat="server"></asp:TextBox></td>
						</tr>
					</table>
				</div>
            </section>
			<section style="clear: both"></section>
            <footer>
                <p>Designed and built by <a href="https://www.facebook.com/shibalab" target="_blank">Ryou.Kanazawa</a></p>
            </footer>
        </div>
    </form>
</body>
</html>
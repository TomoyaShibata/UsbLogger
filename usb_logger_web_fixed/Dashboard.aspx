<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="usb_logger_web_fixed.Dashboard" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/panel.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/loglist.css">
    <title>USB LOGGER</title>
</head>
<body>
    <form id="mainForm" runat="server">
        <div id="outline">
            <header>
                <div id="header_wrapper">
                    <ul>
                        <li class="logo"><a href="Main.aspx">USB LOGGER</a></li>
                        <li><a href="Dashboard.aspx">ダッシュボード</a></li>
                        <li><a href="Main.aspx">全てのログ</a></li>
						<li><a href="Whitelist.aspx">ホワイトリスト</a></li>
                        <li><a href="Login.aspx?request=logout">ログアウト</a></li>
                    </ul>
                </div>
            </header>   
            <section id="main">
                <div id="info_panel">
                    <h4>ダッシュボード</h4>
                    <asp:Literal ID="ltrError" runat="server"></asp:Literal>
                    <asp:Literal ID="ltrDebug" runat="server"></asp:Literal>
					<div id="panel_statistics" class="panel">
						<h4>ログ統計情報</h4>
						<table cellpadding="0" cellspacing="0">
							<tr>
								<td>未対応の警告ログ</td>
								<td><asp:Literal ID="ltrTodayAlertLogCount" runat="server" Text="0"></asp:Literal>件</td>
							</tr>
							<tr>
								<td>本日送信されたログ件数</td>
								<td><asp:Literal ID="ltrTodayLogCount" runat="server"></asp:Literal>件</td>
							</tr>
							<tr>
								<td>現在までに送信された全てのログ件数</td>
								<td><asp:Literal ID="ltrAllLogCount" runat="server"></asp:Literal>件</td>
							</tr>
							</table>
					</div>
					<div id="panel_whitelist_status" class="panel">
						<h4>ホワイトリスト機能</h4>
						<p>ホワイトリスト機能は現在、<asp:Literal ID="ltrStatusWhitelist" runat="server"></asp:Literal>です。</p>
						<p class="panel_footer_link"><a href="Whitelist.aspx">ホワイトリスト設定画面へ</a></p>
					</div>
					<div id="alert_log" class="panel long_panel">
						<h4>未対応の警告ログ</h4>
						<asp:Literal ID="ltrNullAlertUsbLog" runat="server" Text="<p>現在、未対応の警告ログはありません。</p>" Visible=false></asp:Literal>
						<asp:GridView ID="gridAlertUsbLog" runat="server" BorderStyle="None" BorderWidth="0px" GridLines="None">
							<Columns>
								<asp:ButtonField InsertVisible="False" Text="対応完了" />
							</Columns>
						</asp:GridView>
					<asp:DataList ID="DataList1" runat="server"></asp:DataList>
					</div>
                </div>
            </section>
			<section style="clear: both"></section>
            <footer>
                <p>Designed and built by nd built by <a href="https://www.facebook.com/shibalab" target="_blank">Ryou.Kanazawa</a></p>
            </footer>
        </div>
    </form>
</body>
</html>

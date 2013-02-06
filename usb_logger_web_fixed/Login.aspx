<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="usb_logger_web_fixed.Login" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
	<link rel="Stylesheet" type="text/css" href="stylesheets/gh-buttons.css">
    <link rel="Stylesheet" type="text/css" href="stylesheets/login.css">
	<script type="text/javascript" src="../js/footerFixed.js"></script>
    <title>USB LOGGER</title>
</head>
<body>
    <form id="form" runat="server">
        <div id="outline">
			<header>
                <div id="header_wrapper">
                    <ul>
                        <li class="logo"><a href="Login.aspx">USB LOGGER</a></li>
                    </ul>
                </div>
			</header>
            <section id="login_form">
                <table>
                    <tr>
                        <td><img src="images/logo.png" alt="logo"></td>
                    </tr>
                    <tr class="error">
                        <td><asp:Literal ID="ltrError" runat="server"></asp:Literal></td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="txtUserId" runat="server" value="RyouKanazawa" placeholder="ユーザID"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="txtUserPass" TextMode="Password" runat="server" value="RyouKanazawa" placeholder="パスワード"></asp:TextBox></td>
                    </tr>
					<tr>
						<td>
							<asp:CheckBox ID="chkSaveLogin" runat="server" />
							<label for="chkSaveLogin">ログイン状態を保存する</label>
						</td>
                    <tr>
                        <td colspan="2"><asp:Button ID="btnLogin" runat="server" Text="ログイン" OnClick="userLogin" CssClass="button"></asp:Button></td>
                    </tr>
					<tr style="font-size: 13px; height: 20px;">
						<td style="padding-top: 20px;"><a href="#">ユーザID、パスワードを忘れてしまったら</a></td>
					</tr>
					<tr style="font-size: 13px; height: 20px;">
						<td><a href="#">USB LOGGERユーザを新規登録する</a></td>
					</tr>
                </table>
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

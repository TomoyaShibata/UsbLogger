<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="usb_logger_web_fixed.Login" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <link rel="icon" href="images/usb-stick.ico">
    <link rel="Stylesheet" type="text/css" href="stylesheets/common.css">
    <link rel="Stylesheet" type="text/css" href="stylesheets/login.css">
    <title>USB LOGGER | ログイン</title>
</head>
<body>
    <form id="form" runat="server">
        <div id="outline">
            <section id="login_form">
                <table>
                    <tr>
                        <td><img src="images/logo.png" alt="logo"></td>
                    </tr>
                    <tr class="error">
                        <td><asp:Literal ID="ltrError" runat="server"></asp:Literal></td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="txtUserId" runat="server" value="guest" placeholder="ユーザID"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="txtUserPass" TextMode="Password" runat="server" value="guest" placeholder="パスワード"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="padding-top: 20px;"><asp:Button ID="btnLogin" runat="server" Text="ログイン" OnClick="userLogin"></asp:Button></td>
                    </tr>
                </table>
            </section>
        </div>
    </form>
</body>
</html>

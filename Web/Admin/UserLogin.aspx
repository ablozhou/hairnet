<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Web.Admin55.UserLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>精品用户登录界面</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    用户名&nbsp;&nbsp;<asp:TextBox ID="txtUserName" runat="server" Width="200"></asp:TextBox>
    <br />
    密&nbsp;&nbsp;码&nbsp;&nbsp;<asp:TextBox ID="txtUserPwd" runat="server" Width="200"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_OnClick" Text="登录" />&nbsp;&nbsp;<asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_OnClick" />
    </div>
    </form>
</body>
</html>

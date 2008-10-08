<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCreate.aspx.cs" Inherits="Web.Admin.UserCreate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
    <style type="text/css">
        .style1
        {
            width: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    <br />
    密码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    密码确认：<asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    用户邮箱：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    用户角色：<asp:DropDownList ID="ddlUserRole" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="lblInfo" runat="server" ForeColor="red"></asp:Label>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="添加" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopTest.aspx.cs" Inherits="Web.test.HairShopTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnTest1" runat="server" OnClick="btnTest1_OnClick" Text="给美发厅添加数据" /><br />
    <asp:Button ID="btnTest2" runat="server" OnClick="btnTest2_OnClick" Text="给美发师添加数据" /><br />
    <asp:Button ID="btnTest3" runat="server" OnClick="btnTest3_OnClick" Text="给美发产品添加数据" /><br />
    <asp:Button ID="Button1" runat="server"  Text="增加用户" onclick="adduser_Click" />
        <br />
    <asp:Button ID="Button2" runat="server"  Text="查询用户by ID" 
            onclick="queryuserbyid_Click" />
        <asp:TextBox ID="userid" runat="server">2</asp:TextBox>
        <br />
    <asp:Button ID="Button6" runat="server"  Text="删除用户by ID" 
            onclick="deletebyid_Click" />
        <asp:TextBox ID="userid1" runat="server">2</asp:TextBox>
        <br />
    <asp:Button ID="Button3" runat="server"  Text="查询用户by Name" 
            onclick="queryuserbyname_Click" />
        <asp:TextBox ID="username" runat="server">zhouhh</asp:TextBox>
        <br />
    <asp:Button ID="Button4" runat="server"  Text="查询指定数量用户" 
            onclick="queryusercount_Click" />
        <asp:TextBox ID="count" runat="server">0</asp:TextBox>
        <br />
&nbsp;<asp:Button ID="Button5" runat="server"  Text="模糊查询用户by Name" 
            onclick="searchuserbyname_Click" />
        <asp:TextBox ID="username0" runat="server">uh</asp:TextBox>
        <br />
        <br />
    </div>
    </form>
</body>
</html>

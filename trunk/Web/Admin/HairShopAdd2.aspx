<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopAdd2.aspx.cs" Inherits="Web.HairShopAdd2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发厅添加 -- 总店，分店信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    总店，分店信息
    <br /><br /><br />
    美发厅列表&nbsp;&nbsp;<asp:DropDownList ID="ddlHairShopName" runat="server"><asp:ListItem>美发厅1</asp:ListItem><asp:ListItem>美发厅2</asp:ListItem></asp:DropDownList>&nbsp;&nbs;
    <asp:Button ID="btnAddMain" runat="server" Text="添加为总店" />&nbsp;&nbsp;
    <asp:Button ID="btnAddPartial" runat="server" Text="添加为分店" />
    <asp:Panel ID="p1" runat="server">总店信息</asp:Panel>
    <asp:Panel ID="p2" runat="server">分店信息</asp:Panel>
    </div>
    <div>
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="提交 <<总店，分店信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

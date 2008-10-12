<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreGroupAdd.aspx.cs" Inherits="Web.Admin.PictureStoreGroupAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>分类添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    所属大类:<asp:Label ID="lblGroupName" runat="server"></asp:Label>
    <br />
    分类名称:<asp:TextBox ID="txtLittleGroupname" runat="server" Width="200"></asp:TextBox>
    <br />
    <asp:Label ID="lblInfo" runat="server" ForeColor="red"></asp:Label>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="添加" OnClick="btnSubmit_OnClick" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" Text="取消" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModelAdd.aspx.cs" Inherits="Web.Admin.ModelAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>模特添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:left;">
        模特添加<br /><br />
        模特名称:<asp:TextBox ID="txtModelName" runat="server" CssClass="TextBox"></asp:TextBox>
        <br />
        性别:<asp:DropDownList ID="ddlSex" runat="server"><asp:ListItem Value="female">女</asp:ListItem><asp:ListItem Value="male">男</asp:ListItem></asp:DropDownList>
        <br />
        脸型:<asp:DropDownList ID="ddlFaceStyle" runat="server"></asp:DropDownList>
        <br />
        模特小图:<input type="file" id="small" runat="server" /><asp:Label ID="lblSmall" runat="server" Visible="false"></asp:Label>
  <br />模特大图:<input type="file" id="big" runat="server" /><asp:Label ID="lblBig" runat="server" Visible="false"></asp:Label>
  &nbsp;&nbsp;<asp:Button ID="btnUpload" runat="server" Text="上传" OnClick="btnUpload_OnClick" />
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="red"></asp:Label>
        <br /><asp:Button ID="btnSubmit" runat="server" Text="添加" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

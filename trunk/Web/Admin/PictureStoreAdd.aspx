<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreAdd.aspx.cs" Inherits="Web.Admin.PictureStoreAdd" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    名称：<asp:TextBox ID="txtPictureStoreName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    关键字：<asp:TextBox ID="txtPictureStoreTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    分类：<asp:DropDownList ID="ddlPictureStoreGroup" runat="server"><asp:ListItem>分类一</asp:ListItem><asp:ListItem>分类二</asp:ListItem></asp:DropDownList>
    <br />
    描述：<FCKEDITORV2:FCKEDITOR id="txtPictureStoreDescription" runat="server" BasePath="FCKeditor/" Width="98%" Height="400"></FCKEDITORV2:FCKEDITOR>
    <br />
    图片上传空间
    </div>
    <div>
        <asp:Button ID="btnSubmit" Text="提交图片信息" runat="server" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerAdd2.aspx.cs" Inherits="Web.Admin.HairEngineerAdd2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发师添加 -- 图片信息</title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
    图片信息
    <br /><br /><br />
    名称:<asp:TextBox ID="txtPictureStoreName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    关键字:<asp:TextBox ID="txtPictureStoreTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    描述:<asp:TextBox ID="txtPictureStoreDescriptioin" runat="server" CssClass="TextBox" Wrap="true" TextMode="MultiLine" Width="200" Height="300"></asp:TextBox>
    <br />
    浏览图片，上传控件
    <br />
    <asp:Button ID="btnAddPic" runat="server" Text="添加" />
    </div>
    <div>
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="提交 <<图片信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

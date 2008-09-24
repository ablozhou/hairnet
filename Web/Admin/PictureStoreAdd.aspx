﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreAdd.aspx.cs"
    Inherits="Web.Admin.PictureStoreAdd" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="2" cellspacing="2" width="98%">
            <tr>
                <th colspan="2">
                </th>
            </tr>
            <tr>
                <td width="120" align="right">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    分类：
                </td>
                <td>
                    <asp:DropDownList ID="ddlPictureStoreGroup" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreDescription" runat="server" Rows="15" TextMode="MultiLine" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">地址：
                </td>
                <td><input id="uploadpic" type="file" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Button ID="btnSubmit" Text="提交图片信息" runat="server" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>
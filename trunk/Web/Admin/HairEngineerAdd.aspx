﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerAdd.aspx.cs" Inherits="Web.Admin.HairEngineerAdd" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发师添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="2">基本信息</th>
        </tr>
        <tr>
            <td width="120" align="right">名称：</td>
            <td><asp:TextBox ID="txtHairEngineerName" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">年龄：</td>
            <td><asp:TextBox ID="txtHairEngineerAge" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">性别：</td>
            <td><asp:RadioButtonList ID="rBtnListHairEngineerSex" runat="server"><asp:ListItem Value="1" Selected="True">男</asp:ListItem><asp:ListItem Value="2">女</asp:ListItem></asp:RadioButtonList></td>
        </tr>
        <tr>
            <td width="120" align="right">价格：</td>
            <td><asp:TextBox ID="txtHairEngineerRawPrice" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">打折价格：</td>
            <td><asp:TextBox ID="txtHairEngineerPrice" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">所属级别：</td>
            <td><asp:DropDownList ID="ddlHairShopClass" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td width="120" align="right">个人照片：</td>
            <td>
                <input id="fileLogo" type="file" runat="server"/></td>
        </tr>
        <tr>
            <td width="120" align="right">所属美发厅：</td>
            <td><asp:DropDownList ID="ddlHairShop" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td width="120" align="right">工作年限：</td>
            <td><asp:TextBox ID="txtHairEngineerYear" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">擅长：</td>
            <td><asp:TextBox ID="txtHairEngineerSkill" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">关键字：</td>
            <td><asp:TextBox ID="txtHairEngineerTag" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">描述：</td>
            <td><asp:TextBox runat="server" Width="98%" Rows="15" TextMode="MultiLine" 
                    ID="txtHairEngineerDescription"></asp:TextBox></td></tr>
    </table>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

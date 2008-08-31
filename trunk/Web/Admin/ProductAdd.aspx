﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductAdd.aspx.cs" Inherits="Web.Admin.ProductAdd" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>美发产品添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
            <tr>
                <th colspan="2">美发产品添加</th>
            </tr>
            <tr>
                <td width="120" align="right">产品名称：</td>
                <td><asp:TextBox ID="txtProductName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">价格：</td>
                <td><asp:TextBox ID="txtProductRawPrice" runat="server" CssClass="TextBox" Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">优惠价格：</td>
                <td><asp:TextBox ID="txtProductPrice" runat="server" CssClass="TextBox" Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">折扣：</td>
                <td><asp:TextBox ID="txtProductDiscount" runat="server" CssClass="TextBox" Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">关键字：</td>
                <td><asp:TextBox ID="txtProductTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">产品描述：</td>
                <td>
                    <asp:TextBox ID="txtProductDescription" runat="server" Rows="15" TextMode="MultiLine" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">公司名称：</td>
                <td><asp:TextBox ID="txtCompany" runat="server" CssClass="TextBox" Width="200" ></asp:TextBox></td>
            </tr>
            <tr>
                <td width="120" align="right">公司描述：</td>
                <td>
                    <asp:TextBox ID="txtCompanyDescription" runat="server" Rows="15" TextMode="MultiLine" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right"></td>
                <td></td>
            </tr>
        </table>

    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

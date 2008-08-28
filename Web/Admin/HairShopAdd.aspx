﻿<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false"
    CodeBehind="HairShopAdd.aspx.cs" Inherits="Web.Admin.HairShopAdd" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>美发厅添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
            <tr>
                <th colspan="2">
                    <b>基本信息</b>
                </th>
            </tr>
            <tr>
                <td width="120" align="right">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    简称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopShortName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    风格：
                </td>
                <td>
                    <asp:DropDownList ID="ddlTypeTable" runat="server">
                        <asp:ListItem>炫酷</asp:ListItem>
                        <asp:ListItem>超酷</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    官方网址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopWebSite" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    联系邮箱：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopEmail" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    美发师折扣：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    美发厅LOGO：
                </td>
                <td>
                    <input type="file" id="fileLogo" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    开业时间：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopCreateTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    城市：
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 区域：
                    <asp:DropDownList ID="ddlMapZone" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMapZone_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 地段：<asp:DropDownList ID="ddlHotZone" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    详细地址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopAddress" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    电话号码：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopPhoneNum" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    营业时间：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopOpenTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopTag" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    运营项目：
                </td>
                <td>
                    <asp:CheckBoxList ID="chkListWorkRange" runat="server" RepeatDirection="horizontal">
                        <asp:ListItem>烫</asp:ListItem>
                        <asp:ListItem>染</asp:ListItem>
                        <asp:ListItem>剪</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    是否旗舰店：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsBest" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    是否加盟店：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsJoin" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    是否停车：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostStation" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    是否刷卡：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostMachine" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Height="200px" TextMode="MultiLine"
                        Width="900px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

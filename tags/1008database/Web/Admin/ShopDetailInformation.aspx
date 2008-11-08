<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopDetailInformation.aspx.cs" Inherits="Web.Admin.ShopDetailInformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>理发店预览</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
    <style type="text/css">
        .style1
        {
            width: 175px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
           
            <tr>
                <td align="right" class="style1">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200" Enabled=false></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    简称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopShortName" runat="server" CssClass="TextBox" Width="200" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    风格：
                </td>
                <td>
                    <asp:TextBox ID="tbType" runat="server" CssClass="TextBox" Width="200" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    官方网址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopWebSite" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    联系邮箱：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopEmail" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    美发厅折扣：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr> 
            <tr>
                <td align="right" class="style1">
                    剪发价格：
                </td>
                <td>
                    <asp:TextBox ID="tbHairCutPrice" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    剪发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbHairCutDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    烫发价格：
                </td>
                <td>
                    <asp:TextBox ID="tbMarcelPrice" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    烫发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbMarclDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>   
            <tr>
                <td align="right" class="style1">
                    染发价格：
                </td>
                <td>
                    <asp:TextBox ID="tbHairDyePrice" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    染发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbHairDyeDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    造型价格：
                </td>
                <td>
                    <asp:TextBox ID="tbShapePrice" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    造型折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbShapeDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    护理价格：
                </td>
                <td>
                    <asp:TextBox ID="tbConservationPrice" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    护理折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbConservationDiscount" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    营业面积：
                </td>
                <td>
                    <asp:TextBox ID="tbSquare" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr><tr>
                <td align="right" class="style1">
                    地图URL：
                </td>
                <td>
                    <asp:TextBox ID="tbLocation" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    美发厅LOGO：
                </td>
                <td>
                    <img alt="" src="" id="imgLogo" runat="server" /></td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    开业时间：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopCreateTime" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    城市：
                </td>
                <td>
                    <asp:TextBox ID="tbCity" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">区域：</td>
                <td>
                    <asp:TextBox ID="tbZone" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">商圈：</td>
                <td>
                    <asp:TextBox ID="tbArea" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    详细地址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopAddress" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    电话号码：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopPhoneNum" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                营业时间
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopOpenTime" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopTag" runat="server" Width="200" CssClass="TextBox" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    运营项目：
                </td>
                <td>
                 <table cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td><asp:CheckBox ID="chkMarcel" runat="server"  Enable=false/>烫</td>
                        <td><asp:CheckBox ID="chkDye" runat="server" Enable=false />染</td>
                        <td><asp:CheckBox ID="chkCut" runat="server" Enable=false />剪</td>
                    </tr>
                 </table>
                </td>
            </tr>
        
            <tr>
                <td align="right" class="style1">
                    加盟连锁：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsJoin" runat="server"  Enable=false/>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    是否停车：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostStation" runat="server"  Enable=false/>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    是否刷卡：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostMachine" runat="server"  Enable=false/>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" valign="top">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Height="200px" TextMode="MultiLine"
                        Width="900px" Enable=false></asp:TextBox>
                </td>
            </tr>
            <tr><td class="style1"></td><td>
                &nbsp;</tr>
        </table>
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopEdit.aspx.cs" Inherits="Web.Admin.HairShopEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>美发厅编辑 -- 基本信息</title>
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
                    城市：
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 区域：
                    <asp:DropDownList ID="ddlMapZone" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMapZone_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 商圈：<asp:DropDownList ID="ddlHotZone" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>      
            
                 <tr>
                <td width="120" align="right">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                    *<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtHairShopName" ErrorMessage="必填项"></asp:RequiredFieldValidator>
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
                        <asp:ListItem>日韩</asp:ListItem>
                        <asp:ListItem>港台</asp:ListItem>
                         <asp:ListItem>欧美</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    官方网址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopWebSite" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                        ControlToValidate="txtHairShopWebSite" ErrorMessage="值不对" 
                        ValidationExpression="(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    联系邮箱：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopEmail" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtHairShopEmail" ErrorMessage="值不对" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    美发厅折扣：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox">-</asp:TextBox>&nbsp;
                </td>
            </tr>
           <tr>
                <td align="right" class="style1">
                    剪发价格小：
                </td>
                <td>
                    <asp:TextBox ID="txtHairCutPriceMin" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" 
                        ControlToValidate="tbHairCutDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    剪发价格大：
                </td>
                <td>
                    <asp:TextBox ID="tbHairCutPrice" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ControlToValidate="tbHairCutPrice" ErrorMessage="值不对" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            
            <tr>
                <td align="right" class="style1">
                    剪发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbHairCutDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                        ControlToValidate="tbHairCutDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    烫发价格小：
                </td>
                <td>
                    <asp:TextBox ID="txtMarcelPriceMin" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" 
                        ControlToValidate="tbMarcelPrice" ErrorMessage="值不对" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    烫发价格大：
                </td>
                <td>
                    <asp:TextBox ID="tbMarcelPrice" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                        ControlToValidate="tbMarcelPrice" ErrorMessage="值不对" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    烫发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbMarclDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                        ControlToValidate="tbMarclDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>  
            <tr>
                <td align="right" class="style1">
                    染发价格小：
                </td>
                <td>
                    <asp:TextBox ID="txtHairDyePriceMin" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator18" runat="server" 
                        ControlToValidate="tbHairDyePrice" ErrorMessage="值不对" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr> 
            <tr>
                <td align="right" class="style1">
                    染发价格大：
                </td>
                <td>
                    <asp:TextBox ID="tbHairDyePrice" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                        ControlToValidate="tbHairDyePrice" ErrorMessage="值不对" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    染发折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbHairDyeDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                        ControlToValidate="tbHairDyeDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    造型价格小：
                </td>
                <td>
                    <asp:TextBox ID="txtShapePriceMin" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator19" 
                        runat="server" ControlToValidate="tbShapePrice" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    造型价格大：
                </td>
                <td>
                    <asp:TextBox ID="tbShapePrice" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" 
                        runat="server" ControlToValidate="tbShapePrice" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    造型折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbShapeDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" 
                        runat="server" ControlToValidate="tbShapeDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    护理价格小：
                </td>
                <td>
                    <asp:TextBox ID="txtConservationPriceMin" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator20" 
                        runat="server" ControlToValidate="tbConservationPrice" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    护理价格大：
                </td>
                <td>
                    <asp:TextBox ID="tbConservationPrice" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator12" 
                        runat="server" ControlToValidate="tbConservationPrice" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    护理折扣：
                </td>
                <td>
                    <asp:TextBox ID="tbConservationDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator13" 
                        runat="server" ControlToValidate="tbConservationDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    营业面积：
                </td>
                <td>
                    <asp:TextBox ID="tbSquare" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                    平方米
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator14" 
                        runat="server" ControlToValidate="tbSquare" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    地图接口：
                </td>
                <td>
                    <asp:TextBox ID="tbLocation" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    交通信息：
                </td>
                <td>
                    <asp:TextBox ID="txtTravelInfo" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    美发厅LOGO：
                </td>
                <td>
                    <input type="file" id="fileLogo" runat="server" />
                    <asp:Image ID="imgLogo" runat="server" Width="200" Height="100" />
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
                    <asp:TextBox ID="txtHairShopPhoneNum" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>&nbsp;
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
                <!--
                    <asp:CheckBoxList ID="chkListWorkRange" runat="server" RepeatDirection="horizontal">
                        <asp:ListItem>烫</asp:ListItem>
                        <asp:ListItem>染</asp:ListItem>
                        <asp:ListItem>剪</asp:ListItem>
                    </asp:CheckBoxList>
                 -->
                 <table cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td><asp:CheckBox ID="chkMarcel" runat="server" />烫</td>
                        <td><asp:CheckBox ID="chkDye" runat="server" />染</td>
                        <td><asp:CheckBox ID="chkCut" runat="server" />剪</td>
                    </tr>
                 </table>
                </td>
            </tr>
          
            <tr>
                <td width="120" align="right">
                    加盟连锁：
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
            </tr>       <tr>
                <td align="right" class="style1">
                    加盟详细信息：
                </td>
                <td>
                    <asp:TextBox ID="txtMemberInfo" runat="server" Height="200px" Width="900px"  TextMode="MultiLine"/>
                </td>
     
            
            <tr>
                <td width="120" align="right">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Height="200px" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" valign="top">
                    产品添加：
                </td>
                <td>
                    <asp:Label ID="lblProductInfo" ForeColor="red" runat="server"></asp:Label>
                    <asp:CheckBoxList ID="chkList" runat="server" RepeatColumns="10" RepeatDirection="Horizontal" RepeatLayout="Flow"></asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />&nbsp;&nbsp;<asp:Label ID="lblInfo" runat="server" ForeColor="red" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
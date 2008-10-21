<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false"
    CodeBehind="HairShopAdd.aspx.cs" Inherits="Web.Admin.HairShopAdd" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>美发厅添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
    <style type="text/css">
        .style1
        {
            width: 175px;
        }
        .style2
        {
            width: 175px;
            height: 23px;
        }
        .style3
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
   <tr>
                <td align="right" class="style1">
                    城市：
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" Width="88px"><asp:ListItem Value="1">普通</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp; 区域：
                    <asp:DropDownList ID="ddlMapZone" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMapZone_SelectedIndexChanged">
                    <asp:ListItem Value="1">普通</asp:ListItem></asp:DropDownList>
                    &nbsp;&nbsp; 商圈：<asp:DropDownList ID="ddlHotZone" runat="server"><asp:ListItem Value="1">普通</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>         
            <tr>
                <td align="right" class="style1">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtHairShopName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtHairShopName" ErrorMessage="必填项"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    简称：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopShortName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    风格：
                </td>
                <td>
                    <asp:DropDownList ID="ddlTypeTable" runat="server">
                        <asp:ListItem Value="1" Selected="True">普通</asp:ListItem><asp:ListItem>日风</asp:ListItem>
                        <asp:ListItem>韩流</asp:ListItem><asp:ListItem>港台</asp:ListItem><asp:ListItem>大陆</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    官方网址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopWebSite" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                        ControlToValidate="txtHairShopWebSite" ErrorMessage="值不对" 
                        ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
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
                <td align="right" class="style1">
                    美发厅折扣：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="txtHairShopDiscount" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
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
                    <asp:TextBox ID="TextBox4" runat="server" Width="200" CssClass="TextBox">0</asp:TextBox>
                    平方米
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator14" 
                        runat="server" ControlToValidate="TextBox4" ErrorMessage="值不对" 
                        ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    交通路线：
                </td>
                <td class="style3">
                    <asp:TextBox ID="tbLocation" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    美发厅LOGO：
                </td>
                <td>
                <input id="fileLogo" type="file" runat="server"  /><asp:Label ID="lblInfo" 
                        runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    开业时间：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopCreateTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td align="right" class="style1">
                    详细地址：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopAddress" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    电话号码：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopPhoneNum" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator15" 
                        runat="server" ControlToValidate="txtHairShopPhoneNum" ErrorMessage="值不对" 
                        ValidationExpression="(\d{3}|\d{3}-)?\d{8}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                营业时间
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopOpenTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopTag" runat="server" Width="500" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    运营项目：
                </td>
                <td>
                <!--
                    <asp:CheckBoxList ID="chkListWorkRange" runat="server" 
                        RepeatDirection="horizontal" Width="16px" Enabled="true" Visible="true">
                        <asp:ListItem Enabled="true" Selected="True">烫</asp:ListItem>
                        <asp:ListItem Enabled="true">染</asp:ListItem>
                        <asp:ListItem Enabled="true">剪</asp:ListItem>
                    </asp:CheckBoxList>
                 -->
                 <table cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td><asp:CheckBox ID="chkMarcel" runat="server" Checked="true" />烫</td>
                        <td><asp:CheckBox ID="chkDye" runat="server" Checked="true" />染</td>
                        <td><asp:CheckBox ID="chkCut" runat="server" Checked="true" />剪</td>
                    </tr>
                 </table>
                </td>
            </tr>
         <tr>
                <td align="right" class="style1">
                    是否停车：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostStation" runat="server" Checked="True" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    是否刷卡：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsPostMachine" runat="server" Checked="True" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    加盟连锁：
                </td>
                <td>
                    <asp:CheckBox ID="chkIsJoin" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    加盟详细信息：
                </td>
                <td>
                    <asp:TextBox ID="txtMemberInfo" runat="server" Height="200px" TextMode="MultiLine"
                        Width="900px"/>
                </td>
            </tr>
           
            <tr>
                <td align="right" class="style1" valign="top">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Height="200px" TextMode="MultiLine"
                        Width="900px"></asp:TextBox>
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
            <tr><td class="style1"></td><td>
                <asp:Button ID="btnSubmit" runat="server" Text="下一步"  OnClick="btnSubmit_OnClick" Width="98px"  /></td>
                <%--<asp:Button ID="btnAddCoupon" runat="server" Text="添加优惠券" Width="100px" 
                    onclick="btnAddCoupon_Click"  />--%>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>

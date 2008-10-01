<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false"
    CodeBehind="HairShopAdd.aspx.cs" Inherits="Web.Admin.HairShopAdd" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>美发厅添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
    <style type="text/css">
        .style1
        {
            width: 85px;
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
                    <asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                    *</td>
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
                        <asp:ListItem>普通</asp:ListItem><asp:ListItem>日风</asp:ListItem>
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
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    联系邮箱：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopEmail" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    美发厅折扣：
                </td>
                <td>
                    <asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>   <tr>
                <td align="right" class="style1">
                    剪发折扣：
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>   <tr>
                <td align="right" class="style1">
                    烫发折扣：
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>   <tr>
                <td align="right" class="style1">
                    染发折扣：
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    营业面积：
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr><tr>
                <td align="right" class="style1">
                    地图URL：
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    美发厅LOGO：
                </td>
                <td>
                    <input type="file" id="fileLogo" runat="server" />
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
                    城市：
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" Width="88px">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 区域：
                    <asp:DropDownList ID="ddlMapZone" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMapZone_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp; 商圈：<asp:DropDownList ID="ddlHotZone" runat="server">
                    </asp:DropDownList>
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
                    <asp:TextBox ID="txtHairShopTag" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
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
                        <td><asp:CheckBox ID="chkItem1" runat="server" />烫</td>
                        <td><asp:CheckBox ID="chkItem2" runat="server" />染</td>
                        <td><asp:CheckBox ID="chkItem3" runat="server" />剪</td>
                    </tr>
                 </table>
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
                <td align="right" class="style1" valign="top">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Height="200px" TextMode="MultiLine"
                        Width="900px"></asp:TextBox>
                </td>
            </tr>
            <tr><td class="style1"></td><td>
                <asp:Button ID="btnSubmit" runat="server" Text="下一步"  OnClick="btnSubmit_OnClick" Width="98px"  />
                <asp:Button ID="btnAddCoupon" runat="server" Text="添加优惠券" Width="100px" 
                    onclick="btnAddCoupon_Click"  />
                </tr>
            
        </table>
    </div>
    </form>
</body>
</html>

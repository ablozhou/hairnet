<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false" CodeBehind="HairShopAdd.aspx.cs" Inherits="Web.Admin.HairShopAdd" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发厅添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>基本信息</b>
    <br /><br /><br />
    名称：<asp:TextBox ID="txtHairShopName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    简称：<asp:TextBox ID="txtHairShopShortName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    风格：<asp:DropDownList ID="ddlTypeTable" runat="server"><asp:ListItem>炫酷</asp:ListItem><asp:ListItem>超酷</asp:ListItem></asp:DropDownList>
    <br />
    官方网址：<asp:TextBox ID="txtHairShopWebSite" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    联系邮箱：<asp:TextBox ID="txtHairShopEmail" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    美发师折扣：<asp:TextBox ID="txtHairShopDiscount" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    美发厅LOGO：<asp:TextBox ID="txtHairShopLogo" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    开业时间：<asp:TextBox ID="txtHairShopCreateTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    城市： <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>&nbsp;&nbsp;     
    区域： <asp:DropDownList ID="ddlMapZone" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlMapZone_SelectedIndexChanged"></asp:DropDownList>&nbsp;&nbsp;       
    地段：<asp:DropDownList ID="ddlHotZone" runat="server"></asp:DropDownList>&nbsp;&nbsp;
    <br />
    详细地址：<asp:TextBox ID="txtHairShopAddress" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    电话号码：<asp:TextBox ID="txtHairShopPhoneNum" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    营业时间：<asp:TextBox ID="txtHairShopOpenTime" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    关键字：<asp:TextBox ID="txtHairShopTag" runat="server" Width="200" CssClass="TextBox"></asp:TextBox>
    <br />
    运营项目：<asp:CheckBoxList ID="chkListWorkRange" runat="server" RepeatDirection="horizontal"><asp:ListItem>烫</asp:ListItem><asp:ListItem>染</asp:ListItem><asp:ListItem>剪</asp:ListItem></asp:CheckBoxList>
    <br />
    是否旗舰店：<asp:CheckBox ID="chkIsBest" runat="server" />&nbsp;&nbsp;
    是否加盟店：<asp:CheckBox ID="chkIsJoin" runat="server" />&nbsp;&nbsp;
    是否停车：<asp:CheckBox ID="chkIsPostStation" runat="server" />&nbsp;&nbsp;
    是否刷卡：<asp:CheckBox ID="chkIsPostMachine" runat="server" />
    <br />
    描述：<asp:TextBox ID="txtDescription" runat="server" Height="200px" 
            TextMode="MultiLine" Width="900px"></asp:TextBox>
    </div>
    <div>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

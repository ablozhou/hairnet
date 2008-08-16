<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductAdd.aspx.cs" Inherits="Web.Admin.ProductAdd" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发产品添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    产品名称：<asp:TextBox ID="txtProductName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    价格：<asp:TextBox ID="txtProductRawPrice" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    优惠价格：<asp:TextBox ID="txtProductPrice" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    折扣：<asp:TextBox ID="txtProductDiscount" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    关键字：<asp:TextBox ID="txtProductTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    美发厅：<asp:DropDownList ID="ddlHairShop" runat="server"><asp:ListItem>美发厅1</asp:ListItem></asp:DropDownList>&nbsp;&nbsp;<asp:Button ID="btnAdd" Text="添加美发厅" runat="server" />
    <br />
    产品描述：<FCKEDITORV2:FCKEDITOR id="txtProductDescription" runat="server" BasePath="FCKeditor/" Width="98%" Height="400"></FCKEDITORV2:FCKEDITOR>
    <br />
    公司名称：<asp:TextBox ID="txtCompany" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
    <br />
    公司描述：<FCKEDITORV2:FCKEDITOR id="txtCompanyDescription" runat="server" BasePath="FCKeditor/" Width="98%" Height="400"></FCKEDITORV2:FCKEDITOR>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

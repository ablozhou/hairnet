<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerAdd.aspx.cs" Inherits="Web.Admin.HairEngineerAdd" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发师添加 -- 基本信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    名称：<asp:TextBox ID="txtHairEngineerName" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    年龄：<asp:TextBox ID="txtHairEngineerAge" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    性别：<asp:RadioButtonList ID="rBtnListHairEngineerSex" runat="server"><asp:ListItem Value="1">男</asp:ListItem><asp:ListItem Value="2">女</asp:ListItem></asp:RadioButtonList>
    <br />
    价格：<asp:TextBox ID="txtHairEngineerRawPrice" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    打折价格：<asp:TextBox ID="txtHairEngineerPrice" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    所属级别：<asp:DropDownList ID="ddlHairShopClass" runat="server"><asp:ListItem>高级美发师</asp:ListItem></asp:DropDownList>
    <br />
    个人照片：图片上传控件
    <br />
    所属美发厅：<asp:DropDownList ID="ddlHairShop" runat="server"><asp:ListItem>美发厅1</asp:ListItem></asp:DropDownList>
    <br />
    工作年限：<asp:TextBox ID="txtHairEngineerYear" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    擅长：<asp:TextBox ID="txtHairEngineerSkill" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    关键字:<asp:TextBox ID="txtHairEngineerTag" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    描述：<FCKEDITORV2:FCKEDITOR id="txtHairEngineerDescription" runat="server" BasePath="FCKeditor/" Width="98%" Height="400"></FCKEDITORV2:FCKEDITOR>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

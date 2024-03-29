﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreAdd.aspx.cs"
    Inherits="Web.Admin.PictureStoreAdd" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片添加</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="2" cellspacing="2" width="98%">
            <tr>
                <th colspan="2">
                </th>
            </tr>
            <tr>
                <td width="120" align="right">
                    名称：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                    *<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtPictureStoreName" ErrorMessage="必填项"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox><asp:Label ID="lblRedInfo1" runat="server" ForeColor="red" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    美发圈：
                </td>
                <td>
                    <asp:TextBox ID="txtBbsurl" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    街拍：
                </td>
                <td>
                <asp:CheckBoxList ID="chkJPList" RepeatColumns="8" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    明星：
                </td>
                <td>
                <asp:CheckBoxList ID="chkMXList" RepeatColumns="8" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    组图：
                </td>
                <td>
                <asp:CheckBoxList ID="chkFXList" RepeatColumns="8" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </td>
            </tr>
                <table width="98%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width=120px align="right">发质: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlHairNature" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">发量: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlHairQuantity" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">脸型: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlFaceStyle" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">性别: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlSex" runat="server" Width="120px"><asp:ListItem Value="0">女</asp:ListItem><asp:ListItem Value="1">男</asp:ListItem></asp:DropDownList></td>
            <td width="15%"></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width=120px align="right">发型: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlHairStyleClassName" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">气质: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlTemperament" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">场合: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlOccasion" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right"> </td>
            <td width=120px align="left"></td>
            <td width="15%"></td>
        </tr>
    </table>
            </tr>
            <tr>
                <td width="120" align="right">
                    描述：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreDescription" runat="server" Rows="15" TextMode="MultiLine" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">    &nbsp;&nbsp;  小图片：
                </td>
                <td><input id="uploadpicsmall" type="file" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">图片：
                </td>
                <td><asp:FileUpload ID="uploadpic1" runat="server" Width="300" />&nbsp;&nbsp;<asp:Button ID="btnPicUpload" runat="server" OnClick="btnPicUpload1_OnClick" Text="上传图片" />&nbsp;&nbsp;<asp:Label ID="lblRedInfo" runat="server" ForeColor="red" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
        
    </div>
    <script>
                function enableButton()
                {
	                var o = document.getElementById("a1");
	                var o2 = document.getElementById("a2");
	                o.style.display = "none";
	                o2.style.display = "";
	                o2.innerHTML = "信息提交中，请稍后...";
	                setTimeout("enableButton2()",3000);
                }
                function enableButton2()
                {
	                var o = document.getElementById("a1");
	                var o2 = document.getElementById("a2");
	                o2.style.display = "none";
	                o.style.display = "";
                }
                </script>
    <div>
        <span id="a2"></span><span id="a1" onclick='enableButton()'><asp:Button ID="btnSubmit" Text="提交图片信息" runat="server" OnClick="btnSubmit_OnClick" /></span>
    </div>
    <div>
        <asp:Label ID="picString" runat="server"></asp:Label><asp:Label ID="pic" runat="server" Visible="false"></asp:Label><asp:Label ID="picsmall" runat="server" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>

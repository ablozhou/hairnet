<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreEdit.aspx.cs" Inherits="Web.Admin.PictureStoreEdit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>图片编辑</title>
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
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    关键字：
                </td>
                <td>
                    <asp:TextBox ID="txtPictureStoreTag" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="120" align="right">
                    分类：
                </td>
                <td>
                    <asp:DropDownList ID="ddlPictureStoreGroup" runat="server">
                    </asp:DropDownList>
                </td>
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
                <td width="120" align="right">图片1：
                </td>
                <td><input id="uploadpic1" type="file" runat="server" />&nbsp;&nbsp;<asp:Button ID="btnPicUpload" runat="server" OnClick="btnPicUpload1_OnClick" Text="上传图片1" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">图片2：
                </td>
                <td><input id="uploadpic2" type="file" runat="server" />&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="btnPicUpload2_OnClick" Text="上传图片2" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">图片3：
                </td>
                <td><input id="uploadpic3" type="file" runat="server" />&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="btnPicUpload3_OnClick" Text="上传图片3" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">图片4：
                </td>
                <td><input id="uploadpic4" type="file" runat="server" />&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="btnPicUpload4_OnClick" Text="上传图片4" />
                </td>
            </tr>
            <tr>
                <td width="120" align="right">图片5：
                </td>
                <td><input id="uploadpic5" type="file" runat="server" />&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" OnClick="btnPicUpload5_OnClick" Text="上传图片5" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Button ID="btnSubmit" Text="提交图片信息" runat="server" OnClick="btnSubmit_OnClick" />
    </div>
    <div>
        <asp:Image ID="img1" runat="server" Visible="false" Width="200" Height="100" />&nbsp;&nbsp;
        <asp:Image ID="img2" runat="server" Visible="false" Width="200" Height="100" />&nbsp;&nbsp;
        <asp:Image ID="img3" runat="server" Visible="false" Width="200" Height="100" />&nbsp;&nbsp;
        <asp:Image ID="img4" runat="server" Visible="false" Width="200" Height="100" />&nbsp;&nbsp;
        <asp:Image ID="img5" runat="server" Visible="false" Width="200" Height="100" />&nbsp;&nbsp;
    </div>
    <div>
        <asp:Label ID="lblImg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

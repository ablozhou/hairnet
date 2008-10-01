<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EngineerOpusInfo.aspx.cs" Inherits="Web.Admin.EngineerOpusInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发师添加 -- 添加作品</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="2">美发师作品添加</th>
        </tr>
          <tr>
            <td width="120px" align="right">名称: </td>
            <td><asp:TextBox ID="txtOpusName" runat=server CssClass="TextBox" Width="300px"></asp:TextBox></td>
        </tr>
         <tr>
            <td align="right">正面图片: </td>
            <td><asp:FileUpload ID="frontsidePic" runat="server" Width="300px" /></td>
            <td><asp:Label ID="lbFPic" Width="300px" runat=server></asp:Label></td>
        </tr>
         <tr>
            <td align="right">侧面图片: </td>
            <td><asp:FileUpload ID="flanksidePic" runat="server" Width="300px" /></td>
            <td><asp:Label ID="lbFlPic" Width="300px" runat=server></asp:Label></td>
        </tr>
         <tr>
            <td align="right">背面图片: </td>
            <td><asp:FileUpload ID="backsidePic" runat="server" Width="300px" /></td>
            <td><asp:Label ID="lbBPic" Width="300px" runat=server></asp:Label></td>
        </tr>
         <tr>
            <td align="right">辅助图片: </td>
            <td><asp:FileUpload ID="assistancePic" runat="server" Width="300px" /></td>
            <td><asp:Label ID="lbAPic" Width="300px" runat=server></asp:Label></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width=120px align="right">发型: </td>
            <td width=120px align="left"><asp:DropDownList ID="listHairStyle" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">脸型: </td>
            <td width=120px align="left"><asp:DropDownList ID="listFaceType" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">发质: </td>
            <td width=120px align="left"><asp:DropDownList ID="listHairType" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">美发项目: </td>
            <td width=120px align="left"><asp:DropDownList ID="listHairItem" runat="server" Width="120px"></asp:DropDownList></td>
            <td width="15%"></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120" align="right" valign="top">介绍: </td>
            <td><asp:TextBox ID="txtDesc" runat=server CssClass="TextBox" Width="420px" Height="140"
                    TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120px" align="right" valign="top"><asp:Button ID="btnAdd" runat="server" 
                    Text="添加" Width="75px" onclick="btnAdd_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

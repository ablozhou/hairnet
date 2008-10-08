<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopAddNext1.aspx.cs" Inherits="Web.Admin.HairShopAddNext1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ìí¼ÓÃÀ·¢ÌüÍ¼Æ¬</title>
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
            <th colspan="2">ÌüÍâÍ¼Æ¬Ìí¼Ó</th>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬1: </td>
            <td><input type="file" id="out1c" runat="server" /></td>
            <td><asp:Label ID="lbFPic" Width="300" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬2: </td>
            <td><input type="file" id="out2c" runat="server" /></td>
            <td><asp:Label ID="lbFlPic" Width="300" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬3: </td>
            <td><input type="file" id="out3c" runat="server" /></td>
            <td><asp:Label ID="lbBPic" Width="300px" runat="server"></asp:Label></td>
        </tr>
        <br />
        <tr>
            <th colspan="2">ÌüÄÚÍ¼Æ¬Ìí¼Ó</th>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬1: </td>
            <td><input type="file" id="inner1c" runat="server" /></td>
            <td><asp:Label ID="Label1" Width="300" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬2: </td>
            <td><input type="file" id="inner2c" runat="server" /></td>
            <td><asp:Label ID="Label2" Width="300" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td align="right">Í¼Æ¬3: </td>
            <td><input type="file" id="inner3c" runat="server" /></td>
            <td><asp:Label ID="Label3" Width="300px" runat="server"></asp:Label></td>
        </tr>
    </table>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_OnClick" Text="Ìá½»ÃÀ·¢ÌüÍ¼Æ¬ÐÅÏ¢" />
    </div>
    </form>
</body>
</html>

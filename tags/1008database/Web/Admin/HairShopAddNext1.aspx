<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopAddNext1.aspx.cs" Inherits="Web.Admin.HairShopAddNext1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>���������ͼƬ</title>
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
        <asp:Label ID="lblInfo" runat="server" ForeColor="red" Visible="false"></asp:Label>
        
        <tr>
            <th colspan="2">����ͼƬ</th>
        </tr>
         <tr>
            <td align="right">����СͼƬ: </td>
            <td><input type="file" id="outSmall" runat="server" /></td>
            <td align="left"></td>
        </tr>


         <tr>
            <td align="right">�����ͼƬ: </td>
            <td><input type="file" id="out1c" runat="server" /></td>
            <td align="left"><asp:Button ID="btnSubmitOut" runat="server" OnClick="btnSubmitOut_OnClick" Text="�ϴ�����ͼƬ" /></td>
        </tr>
        <tr>
            <td colspan="3"><asp:Label ID="lblOutString" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3"><hr style="width:98%" /></td>
        </tr>
        <tr>
            <th colspan="2">����ͼƬ</th>
        </tr>
         <tr>
            <td align="right">����СͼƬ: </td>
            <td><input type="file" id="innerSmall" runat="server" /></td>
            <td align="left"></td>
        </tr>
        
         <tr>
            <td align="right">���ڴ�ͼƬ: </td>
            <td><input type="file" id="inner1c" runat="server" /></td>
            <td align="left"><asp:Button ID="btnSubmitInner" runat="server" Text="�ϴ�������Ƭ" OnClick="btnSubmitInner_OnClick" /></td>
        </tr>
        <tr>
            <td colspan="3"><asp:Label ID="lblInnerString" runat="server"></asp:Label></td>
        </tr>
    </table>
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_OnClick" Text="��һ��" />
    </div>
    </form>
</body>
</html>

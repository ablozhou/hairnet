<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairStyleEdit.aspx.cs" Inherits="Web.Admin.HairStyleEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>发型修改</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="2">修改</th>
        </tr>
          <tr>
            <td width="120px" align="right">名称: </td>
            <td><asp:TextBox ID="txtOpusName" runat=server CssClass="TextBox" Width="300px"></asp:TextBox></td>
        </tr>
         <tr>
            <td align="right">正面图片: </td>
            <td><asp:FileUpload ID="frontsidePic" runat="server" Width="300" /><asp:Button ID="btn1" runat="server" OnClick="btn1_OnClick" Text="上传" /><asp:Label ID="lbl1" runat="server" Visible="false"></asp:Label><asp:Label ID="lbl1new" runat="server" Visible="false"></asp:Label></td>
            <td><asp:Image ID="i1" Width="200" Height="100" runat="Server" Visible="false" /></td>
        </tr>
         <tr>
            <td align="right">侧面图片: </td>
            <td><asp:FileUpload ID="flanksidePic" runat="server" Width="300" /><asp:Button ID="btn2" runat="server" OnClick="btn2_OnClick" Text="上传" /><asp:Label ID="lbl2" runat="server" Visible="false"></asp:Label><asp:Label ID="lbl2new" runat="server" Visible="false"></asp:Label></td>
            <td><asp:Image ID="i2" Width="200" Height="100" runat="Server" Visible="false" /></td>
        </tr>
         <tr>
            <td align="right">背面图片: </td>
            <td><asp:FileUpload ID="backsidePic" runat="server" Width="300px" /><asp:Button ID="btn3" runat="server" OnClick="btn3_OnClick" Text="上传" /><asp:Label ID="lbl3" runat="server" Visible="false"></asp:Label><asp:Label ID="lbl3new" runat="server" Visible="false"></asp:Label></td>
            <td><asp:Image ID="i3" Width="200" Height="100" runat="Server" Visible="false" /></td>
        </tr>
         <tr>
            <td align="right">辅助图片: </td>
            <td><asp:FileUpload ID="assistancePic" runat="server" Width="300px" /><asp:Button ID="btn4" runat="server" OnClick="btn4_OnClick" Text="上传" /><asp:Label ID="lbl4" runat="server" Visible="false"></asp:Label><asp:Label ID="lbl4new" runat="server" Visible="false"></asp:Label></td>
            <td><asp:Image ID="i4" Width="200" Height="100" runat="Server" Visible="false" /></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
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
                    发型：
                </td>
                <td>
                <asp:CheckBoxList ID="chkFXList" RepeatColumns="8" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </td>
            </tr>
    </table>
    <table width="98%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width=120px align="right">发质: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlHairNature" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">发量: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlHairQuantity" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">脸型: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlFaceStyle" runat="server" Width="120px"></asp:DropDownList></td>
            <td width=120px align="right">性别: </td>
            <td width=120px align="left"><asp:DropDownList ID="ddlSex" runat="server" Width="120px"><asp:ListItem Value="1">男</asp:ListItem><asp:ListItem Value="2">女</asp:ListItem></asp:DropDownList></td>
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
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120" align="right" valign="top">介绍: </td>
            <td><asp:TextBox ID="txtDesc" runat="server" CssClass="TextBox" Width="420px" Height="140"
                    TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120px" align="right" valign="top"><asp:Button ID="btnAdd" runat="server" 
                    Text="更新" Width="75px" onclick="btnAdd_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="l1" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l2" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l3" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l4" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l5" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l6" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l7" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="l8" runat="server" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>

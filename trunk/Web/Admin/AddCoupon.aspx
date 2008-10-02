<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCoupon.aspx.cs" Inherits="Web.Admin.AddCoupon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加优惠券信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
    <style type="text/css">
        .style1
        {
            width: 83px;
        }
    </style>
<script language="javascript" type="text/javascript">
<!--

function Button1_onclick() {
window.location.href = "CouponManagement.aspx";
}

// -->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
            <tr>
                <th>添加优惠券</th>
            </tr>
            <tr>
                <td align="right" width="85px">优惠券名称：</td>
                <td><asp:TextBox ID="tbCouponName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="tbCouponName" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" width="85px">店铺名称：</td>
                <td><asp:DropDownList ID="ddlShopList" runat="server" Width="200px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" width="85px">优惠券折扣：</td>
                <td><asp:TextBox ID="tbDiscount" runat="server" CssClass="TextBox" 
                        Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" width="85px">优惠券有效期：</td>
                <td><asp:TextBox ID="tbExpired" runat="server" CssClass="TextBox" 
                        Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" width="85px">联系方式：</td>
                <td><asp:TextBox ID="tbDesc" runat="server" CssClass="TextBox" 
                        Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" width="85px">优惠券标签：</td>
                <td><asp:TextBox ID="tbTag" runat="server" CssClass="TextBox" 
                        Width="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" width="85px" valign="top">优惠券描述：</td>
                <td><asp:TextBox ID="tbPhone" runat="server" CssClass="TextBox" 
                        TextMode="MultiLine" Height="110px" Width="480px"></asp:TextBox></td>
            </tr>
        </table>
        <table width="98%" border="0" cellpadding="2" cellspacing="2">
            <tr>
                <td class="style1"></td>
                <td><asp:Button ID="btnAddCoupon" runat="server" Text="添加优惠券" 
                        onclick="btnAddCoupon_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Button1" type="button" value="浏览现有的优惠券" onclick="return Button1_onclick()" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

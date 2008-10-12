<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CouponAddSwitch.aspx.cs" Inherits="Web.Admin.CouponAddSwitch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_OnClick" Text="继续添加优惠券" />
    <br /><br />
    <asp:Button ID="btnBack" runat="server" OnClick ="btnBack_OnClick" Text ="返回列表" />
    </div>
    </form>
</body>
</html>

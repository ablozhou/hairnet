<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintCoupon.aspx.cs" Inherits="Web.PrintCoupon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>优惠券 -- 打印</title>
    <link href="Theme/Style/daohang-end-08.css" rel="stylesheet" type="text/css" />
</head>
<body bgcolor="#fef4d9" OnLoad="printPage()"> 
<script LANGUAGE="javascript">

<!-- Begin
function printPage() {
if (window.print) {
agree = confirm('本页将被自动打印. \n\n现在就打印吗?');
if (agree) window.print(); 
}
}
// End -->
</script>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblText" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

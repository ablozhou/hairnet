<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false" CodeBehind="ProductRecommandUpdate.aspx.cs" Inherits="Web.Admin.ProductRecommandUpdate" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>美发产品推荐信息修改</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:left;">
    推荐信息:
    <br />
        <asp:TextBox ID="content" runat="server" Rows="15" TextMode="MultiLine" Width="98%"></asp:TextBox>
    <br /><br />
    推荐扩展:
    <asp:TextBox ID="txtRecommandEx" runat="server" Width="98%"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="提交更新" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>
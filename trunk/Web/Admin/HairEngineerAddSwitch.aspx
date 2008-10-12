<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerAddSwitch.aspx.cs" Inherits="Web.Admin55.HairEngineerAddSwitch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnAddHairEngineerContinue" runat="server" OnClick="btnHairEngineerContinue_Click" Text="继续添加美发师" />
    <br /><asp:Button ID="btnAddOupusInfo" runat="server" OnClick="btnAddOupusInfo_Click" Text="添加美发师作品" />
    <br /><asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="返回美发师管理列表" />
    </div>
    </form>
</body>
</html>

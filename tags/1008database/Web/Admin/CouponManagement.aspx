<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CouponManagement.aspx.cs" Inherits="Web.Admin.CouponManagement" %>
<%@ Register Assembly="DMSTime" Namespace="DMSTime" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>优惠券管理</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    当前页面:<b>优惠券管理</b>
                </td>
            </tr>
    </table>
    <div style="text-align: center">
        <asp:DataGrid ID ="dg" runat = "server" PageSize="50" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="White" 
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="98%" 
            CellSpacing="1" GridLines="None" OnItemDataBound="dg_ItemDataBound" 
            OnPageIndexChanged="dg_OnPageIndexChanged" ondeletecommand="dg_DeleteCommand">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" NextPageText="下一页"
                PrevPageText="上一页" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <HeaderStyle BackColor="#667BD8" Font-Bold="True" ForeColor="#E7E7FF" />
            <Columns>
                <asp:BoundColumn DataField="ID" HeaderText="优惠券ID"></asp:BoundColumn>
                <asp:BoundColumn DataField="Name" HeaderText="优惠券名称"></asp:BoundColumn>
                <asp:BoundColumn DataField="HairShopName" HeaderText="所属理发店"></asp:BoundColumn>
                <asp:BoundColumn DataField="Discount" HeaderText="折扣信息"></asp:BoundColumn>
                <asp:BoundColumn DataField="ExpiredDate" HeaderText="过期日期"></asp:BoundColumn>
                <asp:ButtonColumn ButtonType="LinkButton" CommandName="Delete" Text="Delete" 
                    HeaderText="删除"></asp:ButtonColumn>
            </Columns>
        </asp:DataGrid>
    </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopAdd2.aspx.cs" Inherits="Web.Admin.HairShopAdd2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>美发厅添加 -- 总店，分店信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="2" cellspacing="2">
            <tr>
                <th>
                    <b>添加美发师</b>
                </th>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Button ID="addengineer" runat="server" Text="添加美发师" 
                        onclick="addengineer_Click" />
                 </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="p1" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="p2" runat="server">
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
    <div>
    <div style="text-align: center">
        <asp:DataGrid ID ="dg" runat = "server" PageSize="30" AllowPaging="true" AutoGenerateColumns="false" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="98%" CellSpacing="1" GridLines="None" OnItemDataBound="dg_OnItemDataBound" OnItemCommand="dg_OnItemCommand" OnPageIndexChanged="dg_OnPageIndexChanged">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" NextPageText="下一页"
                PrevPageText="上一页" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <HeaderStyle BackColor="#667BD8" Font-Bold="True" ForeColor="#E7E7FF" />
            <Columns>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:CheckBox ID="IsSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="HairEngineerName" HeaderText="姓名"></asp:BoundColumn>
                <asp:BoundColumn DataField="HairShopName" HeaderText="所属美发厅"></asp:BoundColumn>
                <asp:BoundColumn DataField="HairEngineerHits" HeaderText="点击数"></asp:BoundColumn>
                <asp:TemplateColumn HeaderText="推荐指数">
                    <ItemTemplate>
                        <asp:Label ID="lblRecommandRate" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn HeaderText="好评率">
                    <ItemTemplate>
                        <asp:Label ID="lblCommentRate" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="HairEngineerID" DataNavigateUrlFormatString="HairEngineerDetails.aspx?id={0}" Target="_blank" Text="预览"></asp:HyperLinkColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="HairEngineerID" DataNavigateUrlFormatString="HairEngineerEdit.aspx?id={0}" Target="_self" Text="编辑"></asp:HyperLinkColumn>
                <asp:ButtonColumn ButtonType="LinkButton" CommandName="recommand" Text="添加作品"></asp:ButtonColumn>
                <asp:ButtonColumn ButtonType="LinkButton" CommandName="delete" Text="删除"></asp:ButtonColumn>
            </Columns>
        </asp:DataGrid>
    </div>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="下一步" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

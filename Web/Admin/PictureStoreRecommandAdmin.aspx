﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreRecommandAdmin.aspx.cs" Inherits="Web.Admin.PictureStoreRecommandAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片库推荐信息管理</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    当前页面:<b>图片库推荐管理</b>
                </td>
            </tr>
    </table>
    <div style="text-align: center">
        <asp:DataGrid ID ="dg" PageSize="30" runat = "server" AllowPaging="true" AutoGenerateColumns="false" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="98%" CellSpacing="1" GridLines="None" OnItemDataBound="dg_OnItemDataBound" OnPageIndexChanged="dg_OnPageIndexChanged" OnItemCommand="dg_OnItemCommand">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" NextPageText="下一页"
                PrevPageText="上一页" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <HeaderStyle BackColor="#667BD8" Font-Bold="True" ForeColor="#E7E7FF" />
            <Columns>
                <asp:TemplateColumn HeaderText="序号">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="PictureStoreName" HeaderText="名称"></asp:BoundColumn>
                <asp:TemplateColumn HeaderText="图片">
                    <ItemTemplate>
                        <asp:Label ID="lblPictureUrl" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="PictureStoreHits" HeaderText="点击数"></asp:BoundColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="PictureStoreRawID" DataNavigateUrlFormatString="PictureStoreComments.aspx?id={0}" Target="_blank" Text="浏览评论"></asp:HyperLinkColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="PictureStoreRawID" DataNavigateUrlFormatString="PictureStoreDetails.aspx?id={0}" Target="_blank" Text="详细"></asp:HyperLinkColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:Label ID="lblEdit" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:ButtonColumn ButtonType="LinkButton" CommandName="delete" Text="删除"></asp:ButtonColumn>
            </Columns>
        </asp:DataGrid>
    </div>
    <div align="center">
				 <asp:LinkButton ID="PageFirst" OnClick="Page_Click" Text="首页" runat="server" CommandArgument="First"/> 
				   |  
				     <asp:LinkButton ID="PagePrev" OnClick="Page_Click" Text="上一页" runat="server" CommandArgument="Prev"/>
				 | 
				 <asp:LinkButton ID="PageNext" OnClick="Page_Click" Text="下一页" runat="server" CommandArgument="Next"/> 
				 |  
				 <asp:LinkButton ID="PageLast" OnClick="Page_Click" Text="尾页" runat="server" CommandArgument="Last"/>
				 <asp:Label ID="CountPage" runat="server" />                  
				 转到:
				 <asp:TextBox AutoPostBack="true" Columns="2" ID="ispages" runat="server" Visible="false" />   
				                
				 <asp:DropDownList AutoPostBack="true" ID="thispages" runat="server" OnSelectedIndexChanged="Page_DropDownList"></asp:DropDownList>
				 页  第 
				 <asp:Label ID="Page_nPage" runat="server" ForeColor="Red"></asp:Label> 页/共 <asp:Label ID="Page_nRecCount" ForeColor="Red" runat="server"></asp:Label> 
				 页 一共 
				 <asp:Label ID="Page_nRecCount_1" runat="server" ForeColor="Red"></asp:Label>
条  <asp:Label ID="Page_strSQL" runat="server" Visible="false"></asp:Label>	

</div></div>
    </form>
</body>
</html>

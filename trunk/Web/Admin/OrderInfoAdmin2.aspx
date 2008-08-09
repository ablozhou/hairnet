<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderInfoAdmin2.aspx.cs" Inherits="Web.Admin.OrderInfoAdmin2" %>
<%@ Register Assembly="DMSTime" Namespace="DMSTime" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>已完成订单管理</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
   <form id="form1" runat="server">
    <div align="center">
      <table width="98%" border="0" cellpadding="3" cellspacing="0" class="table2">
            <tr>
                <td align="center" valign="top" style="height: 332px">
        <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    当前页面:<b>已完成订单管理</b>
                </td>
            </tr>
            <tr>
                <td align="right" bgcolor="#F5F5F5">
                      排序方式<asp:DropDownList ID="ddlOrderWay" runat="server"><asp:ListItem Value="0">请选择排序方式</asp:ListItem><asp:ListItem Value="1">订单时间</asp:ListItem><asp:ListItem Value="2">用户名称</asp:ListItem></asp:DropDownList>&nbsp;&nbsp;&nbsp;
                     输入用户名<asp:TextBox ID="txtQueryName" runat="server" CssClass="TextBox"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                     开始时间<cc1:DMSTimeControl ID="txtStartTime" runat="server" />&nbsp;&nbsp;
                     结束时间<cc1:DMSTimeControl ID="txtEndTime" runat="server" />&nbsp;&nbsp;
                     <asp:Button ID="btnQuery" runat="server" CssClass="btn"  Text="查询" OnClick="btnQuery_OnClick" />
                </td>
            </tr>
        </table>
        <div style="text-align: center">
        <asp:DataGrid ID ="dg" runat = "server" PageSize="30" AllowPaging="true" AutoGenerateColumns="false" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="98%" CellSpacing="1" GridLines="None" OnItemDataBound="dg_OnItemDataBound" OnItemCommand="dg_OnItemCommand" OnPageIndexChanged="dg_OnPageIndexChanged">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" NextPageText="下一页"
                PrevPageText="上一页" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <HeaderStyle BackColor="#667BD8" Font-Bold="True" ForeColor="#E7E7FF" />
            <Columns>
                <asp:TemplateColumn HeaderText="序号">
                    <ItemTemplate>
                        <asp:Label ID="lblNum" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                <asp:BoundColumn DataField="OrderCreateTime" HeaderText="订单时间"></asp:BoundColumn>
                <asp:BoundColumn DataField="OrderStatus" HeaderText="订单状态"></asp:BoundColumn>
                <asp:BoundColumn DataField="ProductID1" HeaderText="订购产品1"></asp:BoundColumn>
                <asp:BoundColumn DataField="ProductID2" HeaderText="订购产品2"></asp:BoundColumn>
                <asp:BoundColumn DataField="ProductID3" HeaderText="订购产品3"></asp:BoundColumn>
                <asp:BoundColumn DataField="ReferenceUserID" HeaderText="相关用户"></asp:BoundColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="UserID" DataNavigateUrlFormatString="OrderDetails.aspx?id={0}" Target="_blank" Text="详细"></asp:HyperLinkColumn>
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
</div>
</div>
    </form>
</body>
</html>

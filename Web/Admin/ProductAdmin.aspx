﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductAdmin.aspx.cs" Inherits="Web.Admin.ProductAdmin" %>
<%@ Register Assembly="DMSTime" Namespace="DMSTime" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发产品信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    当前页面:<b>美发产品信息</b>
                </td>
            </tr>
            <tr>
                <td align="right" bgcolor="#F5F5F5">    
                搜索方式<asp:DropDownList ID="ddlQuery" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlQuery_OnSelectedIndexChanged"><asp:ListItem Value="1" Selected="true">名称</asp:ListItem><asp:ListItem Value="2">关键字</asp:ListItem></asp:DropDownList>&nbsp;&nbsp;
                     <asp:TextBox ID="txtQueryName" runat="server" CssClass="TextBox"></asp:TextBox><asp:Label ID="lblQueryNameSpace" Text="&nbsp;&nbsp;&nbsp;" runat="server"></asp:Label>
                     <asp:Label ID="lblStartTime" Text="S:" runat="server"></asp:Label> <cc1:DMSTimeControl ID="txtStartTime" runat="server" />
                     <asp:Label ID="lblEndTime" Text="&nbsp;&nbsp;E:" runat="server"></asp:Label><cc1:DMSTimeControl ID="txtEndTime" runat="server" /><asp:Label ID="lblTimeSpace" runat="server" Text="&nbsp;&nbsp;"></asp:Label>
                     <asp:Button ID="btnQuery" runat="server" CssClass="btn"  Text="查询" OnClick="btnQuery_OnClick" />&nbsp;&nbsp;
                    排序方式:<asp:DropDownList ID="ddlOrderWay" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlOrderWay_OnSelectIndexChanged"><asp:ListItem Value="1" Selected="true">发布时间</asp:ListItem><asp:ListItem Value="2">点击数</asp:ListItem></asp:DropDownList>&nbsp;&nbsp;
                    <asp:Button ID="btnSelect" runat="server" CssClass="btn" Text="全选" OnClick="btnSelect_OnClick"/>&nbsp;&nbsp;
                    <asp:Button ID="btnAdd" runat="server" CssClass="btn" Text="添加" OnClick="btnAdd_OnClick"/>&nbsp;&nbsp;
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
                        <asp:CheckBox ID="IsSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="ProductName" HeaderText="名称"></asp:BoundColumn>
                <asp:BoundColumn DataField="ProductCompany" HeaderText="厂商"></asp:BoundColumn>
                <asp:BoundColumn DataField="ProductHits" HeaderText="点击数"></asp:BoundColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="ProductID" DataNavigateUrlFormatString="ProductEdit.aspx?id={0}" Target="_self" Text="编辑"></asp:HyperLinkColumn>
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

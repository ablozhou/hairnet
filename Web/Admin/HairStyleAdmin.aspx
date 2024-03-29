﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairStyleAdmin.aspx.cs" Inherits="Web.Admin.HairStyleAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>发型库管理</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="formHairStyle" runat="server">
    <div>
    
     <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    当前页面:<b>发型管理</b></td>
            </tr>
            <tr>
                <td align="right" bgcolor="#F5F5F5">
                <%-- 搜索方式<asp:DropDownList ID="ddlQuery" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlQuery_OnSelectedIndexChanged"><asp:ListItem Value="1" Selected="true">发型名字</asp:ListItem><asp:ListItem Value="2" >工程师名称</asp:ListItem></asp:DropDownList>&nbsp;&nbsp;
                    <asp:TextBox ID="txtQueryName" runat="server" CssClass="TextBox"></asp:TextBox>
                     
                     <asp:Button ID="btnQuery" runat="server" CssClass="btn"  Text="查询" OnClick="btnQuery_OnClick" /> --%>
                    &nbsp;&nbsp;
                <asp:Button ID="btnSelect" runat="server" CssClass="btn" Text="全选" OnClick="btnSelect_OnClick"/>&nbsp;&nbsp;
                    <asp:Button ID="btnAdd" runat="server" CssClass="btn" Text="添加" OnClick="btnAdd_OnClick"/>&nbsp;&nbsp;
                    </td>
            </tr>
        </table>
        <div style="text-align: center">
        <asp:DataGrid ID ="dg" runat = "server" PageSize="30" AllowPaging="True" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="White" 
                BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="98%" 
                CellSpacing="1" GridLines="None" OnItemDataBound="dg_OnItemDataBound" 
                OnItemCommand="dg_OnItemCommand" OnPageIndexChanged="dg_OnPageIndexChanged">
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
                <asp:BoundColumn DataField="ID" HeaderText="发型ID"></asp:BoundColumn>
                <asp:BoundColumn DataField="HairName" HeaderText="发型名字"></asp:BoundColumn>
                
                <asp:TemplateColumn HeaderText="好评率">
                    <ItemTemplate>
                        <asp:Label ID="lblCommentRate" runat="server"></asp:Label>
                    </ItemTemplate>
                 
               </asp:TemplateColumn>
               <asp:TemplateColumn HeaderText="美发师">
                    <ItemTemplate>
                        <asp:Label ID="lblHairEngineer" runat="server"></asp:Label>
                    </ItemTemplate>
                 
               </asp:TemplateColumn>
               <asp:TemplateColumn HeaderText="美发厅">
                    <ItemTemplate>
                        <asp:Label ID="lblHairShop" runat="server"></asp:Label>
                    </ItemTemplate>
                 
               </asp:TemplateColumn>
 <asp:HyperLinkColumn DataNavigateUrlField="ID" 
                    DataNavigateUrlFormatString="../HairLastPage.aspx?id={0}" Target="_blank" 
                    Text="预览" HeaderText="预览"></asp:HyperLinkColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="ID" 
                    DataNavigateUrlFormatString="HairStyleEdit.aspx?id={0}" Target="_self" 
                    Text="编辑" HeaderText="编辑"></asp:HyperLinkColumn>
                    
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

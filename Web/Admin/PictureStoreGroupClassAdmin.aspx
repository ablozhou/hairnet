<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureStoreGroupClassAdmin.aspx.cs" Inherits="Web.Admin.PictureStoreGroupClassAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ר�����</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     <table width="98%" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
            <tr>
                <td bgcolor="#FFFFFF" align="left">
                    ��ǰҳ��:<b>ר�����</b></td>
            </tr>
            <tr>
                <td align="right" bgcolor="#F5F5F5">
                <asp:Button ID="btnSelect" runat="server" CssClass="btn" Text="ȫѡ" OnClick="btnSelect_OnClick"/>&nbsp;&nbsp;
                    <asp:Button ID="btnDelete" runat="server" CssClass="btn" Text="ɾ��" OnClick="btnDelete_OnClick"/>&nbsp;&nbsp;
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
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" NextPageText="��һҳ"
                PrevPageText="��һҳ" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <HeaderStyle BackColor="#667BD8" Font-Bold="True" ForeColor="#E7E7FF" />
            <Columns>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkIsSend" runat="server" />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="hairname" HeaderText="����"></asp:BoundColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:Label ID="lblAdmin" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:Label ID="lblEdit" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:ButtonColumn ButtonType="LinkButton" CommandName="delete" Text="ɾ��"></asp:ButtonColumn>
            </Columns>
        </asp:DataGrid>
 </div>
    <div align="center">
				 <asp:LinkButton ID="PageFirst" OnClick="Page_Click" Text="��ҳ" runat="server" CommandArgument="First"/> 
				   |  
				     <asp:LinkButton ID="PagePrev" OnClick="Page_Click" Text="��һҳ" runat="server" CommandArgument="Prev"/>
				 | 
				 <asp:LinkButton ID="PageNext" OnClick="Page_Click" Text="��һҳ" runat="server" CommandArgument="Next"/> 
				 |  
				 <asp:LinkButton ID="PageLast" OnClick="Page_Click" Text="βҳ" runat="server" CommandArgument="Last"/>
				 <asp:Label ID="CountPage" runat="server" />                  
				 ת��:
				 <asp:TextBox AutoPostBack="true" Columns="2" ID="ispages" runat="server" Visible="false" />   
				                
				 <asp:DropDownList AutoPostBack="true" ID="thispages" runat="server" OnSelectedIndexChanged="Page_DropDownList"></asp:DropDownList>
				 ҳ  �� 
				 <asp:Label ID="Page_nPage" runat="server" ForeColor="Red"></asp:Label> ҳ/�� <asp:Label ID="Page_nRecCount" ForeColor="Red" runat="server"></asp:Label> 
				 ҳ һ�� 
				 <asp:Label ID="Page_nRecCount_1" runat="server" ForeColor="Red"></asp:Label>
��  <asp:Label ID="Page_strSQL" runat="server" Visible="false"></asp:Label>	
</div>

    </div>
    </form>
</body>
</html>

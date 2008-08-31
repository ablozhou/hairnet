<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductEdit2.aspx.cs" Inherits="Web.Admin.ProductEdit2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="2" cellspacing="2">
            <tr>
                <th>
                    产品<b>所属美发厅</b>
                </th>
            </tr>
            <tr>
                <td>
                    美发厅列表&nbsp;&nbsp;<asp:DropDownList ID="ddlHairShopName" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <asp:Button ID="btnAddMain" runat="server" Text="添加美发厅" 
                        OnClick="btnAddMain_Click" />&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="p1" runat="server">
                        <asp:GridView ID="gvHairShopList" runat="server" AutoGenerateColumns="False" CellPadding="2"
                            ShowHeader="False" Caption="美发厅列表" OnRowDeleting="gvZD_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="Name">
                                    <ItemStyle Width="200px" />
                                </asp:BoundField>
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="提交 &lt;&lt;美发厅列表&gt;&gt;" 
            OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

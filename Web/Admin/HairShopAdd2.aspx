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
                    <b>总店，分店信息</b>
                </th>
            </tr>
            <tr>
                <td>
                    美发厅列表&nbsp;&nbsp;<asp:DropDownList ID="ddlHairShopName" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <asp:Button ID="btnAddMain" runat="server" Text="添加为总店" OnClick="btnAddMain_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btnAddPartial" runat="server" Text="添加为分店" OnClick="btnAddPartial_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="p1" runat="server">
                        <asp:GridView ID="gvZD" runat="server" AutoGenerateColumns="False" CellPadding="2"
                            ShowHeader="False" Caption="总店信息" OnRowDeleting="gvZD_RowDeleting">
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
            <tr>
                <td>
                    <asp:Panel ID="p2" runat="server">
                        <asp:GridView ID="gvFD" runat="server" AutoGenerateColumns="False" CellPadding="2"
                            ShowHeader="False" Caption="分店信息" OnRowDeleting="gvFD_RowDeleting">
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
        <asp:Button ID="btnSubmit" runat="server" Text="提交 <<总店，分店信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

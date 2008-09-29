<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairShopAdd3.aspx.cs" Inherits="Web.Admin.HairShopAdd3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发厅添加 -- 图片信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table border="0" cellpadding="2" cellspacing="2" width="98%">
     <tr>
     <th colspan="2"><b>图片信息</b></th>
     </tr>
     <tr>
     <td width="120" align="right">
         类型：
     </td>
     <td>
         <asp:DropDownList ID="ddlPicGroup" runat="server">
         </asp:DropDownList>
         </td>
     </tr>
     <tr>
        <td width="120" align="right">
            名称：         </td>
        <td>
        <asp:TextBox ID="txtPictureStoreName" runat="server" CssClass="TextBox" Width="200"></asp:TextBox>
        </td>
     </tr>
     <tr>
        <td width="120" align="right">
            &nbsp;</td>
        <td>
            &nbsp;</td>
     </tr>
     <tr>
        <td width="120" align="right">
        
            操作：</td>
        <td>
        
            <input id="uploadpic" type="file" runat="server" /><asp:Button ID="btnAddPic" runat="server" 
                Text="添加" onclick="btnAddPic_Click" />
        
        </td>
     </tr>
     <tr>
        <td width="120" align="right">
        
            本次上传图片：</td>
        <td>
            
            <asp:GridView ID="gvPicList" runat="server" BorderStyle="Solid" 
                BorderWidth="1px" CellPadding="2" ShowHeader="False" 
                AutoGenerateColumns="False" onrowdeleting="gvPicList_RowDeleting">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="PictureStoreRawUrl" 
                        DataTextField="PictureStoreName" Target="_blank">
                        <ItemStyle Width="200px" />
                    </asp:HyperLinkField>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            
        </td>
     </tr>
     </table>
    </div>
    <div>
    <asp:Button ID="btnSubmit" runat="server" Text="提交 <<图片信息>>" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>

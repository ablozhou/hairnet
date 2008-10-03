<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerAdd.aspx.cs" Inherits="Web.Admin.HairEngineerAdd" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>美发师添加 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
<script language="javascript" type="text/javascript">
<!--

function Button1_onclick() {
    location.href = "AddCoupon.aspx";
}

// -->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="2">美发师基本信息</th>
        </tr>
          <tr>
            <td width="120px" align="right">所属美发厅：</td>
            <td><asp:DropDownList ID="ddlHairShop" runat="server"></asp:DropDownList></td>
            <td width="40%"></td>
        </tr>
         <tr>
            <td width="120px" align="right">姓名：</td>
            <td><asp:TextBox ID="txtHairEngineerName" runat="server" CssClass="TextBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtHairEngineerName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
        </tr>
        <tr>
            <td width="120px" align="right">年龄：</td>
            <td><asp:TextBox ID="txtHairEngineerAge" runat="server" CssClass="TextBox"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td width="120px" align="right">性别：</td>
            <td width="120px"><asp:RadioButtonList ID="rBtnListHairEngineerSex" runat="server" Height="16px" 
                    onselectedindexchanged="rBtnListHairEngineerSex_SelectedIndexChanged" 
                    Width="307px"><asp:ListItem Value="1" Selected="True">男</asp:ListItem>    <asp:ListItem Value="2">女</asp:ListItem></asp:RadioButtonList></td>
        </tr>
        <tr>
            <td width="120px" align="right">剪发价格：</td>
            <td><asp:TextBox ID="txtHairEngineerRawPrice" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">预约电话：</td>
            <td><asp:TextBox ID="txtHairEngineerPrice" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
          <tr>
            <td width="120px" align="right">星座：</td>
            <td><asp:TextBox ID="tbConstellation" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">头衔：</td>
            <td><asp:DropDownList ID="ddlHairShopClass" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td width="120px" align="right">个人照片：</td>
            <td>
                <input id="fileLogo" type="file" runat="server"/></td>
        </tr>
     
        <tr>
            <td width="120px" align="right">工作年限：</td>
            <td><asp:TextBox ID="txtHairEngineerYear" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">擅长：</td>
            <td><asp:TextBox ID="txtHairEngineerSkill" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">关键字：</td>
            <td><asp:TextBox ID="txtHairEngineerTag" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">所获奖项及描述：</td>
            <td><asp:TextBox runat="server" Width="98%" Rows="15" TextMode="MultiLine" 
                    ID="txtHairEngineerDescription" Height="110px"></asp:TextBox></td></tr>
        <tr>
            <td width="120px" align="right"><asp:Button ID="btnSubmit" runat="server" Text="下一步" OnClick="btnSubmit_OnClick" /></td>
            <td>
                <input id="Button1" type="button" value="添加个人作品" onclick="return Button1_onclick()" /></td>
        </tr>
    </table>
    </div>
    <div>
       
    </div>
    </form>
</body>
</html>

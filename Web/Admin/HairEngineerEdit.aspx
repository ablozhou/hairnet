<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HairEngineerEdit.aspx.cs" Inherits="Web.Admin.HairEngineerEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>美发师编辑 -- 基本信息</title>
    <link type="text/css" rel="Stylesheet" href="Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="2">基本信息</th>
        </tr>
        <tr>
            <td width="120" align="right">名称：</td>
            <td><asp:TextBox ID="txtHairEngineerName" runat="server" CssClass="TextBox"></asp:TextBox>
                *<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtHairEngineerName" ErrorMessage="必填项"></asp:RequiredFieldValidator>
                    </td>
        </tr>
        <tr>
            <td width="120" align="right">所属美发厅：</td>
            <td><asp:DropDownList ID="ddlHairShop" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td width="120px" align="right">领军人物：</td>
            <td><asp:CheckBox ID="chkIsImportant" runat="server" />
                    </td>
        </tr>
        <%--<tr>
            <td width="120" align="right">年龄：</td>
            <td><asp:TextBox ID="txtHairEngineerAge" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>--%>
        <tr>
            <td width="120" align="right">性别：</td>
            <td><asp:RadioButtonList ID="rBtnListHairEngineerSex" runat="server"><asp:ListItem Value="1" Selected="True">男</asp:ListItem><asp:ListItem Value="0">女</asp:ListItem></asp:RadioButtonList></td>
        </tr>
        <tr>
            <td width="120" align="right">剪发价格：</td>
            <td><asp:TextBox ID="txtHairEngineerRawPrice" runat="server" CssClass="TextBox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtHairEngineerRawPrice" ErrorMessage="值不对" 
                    ValidationExpression="\d*"></asp:RegularExpressionValidator>
                    </td>
        </tr>
        <tr>
            <td width="120" align="right">预约电话：</td>
            <td><asp:TextBox ID="txtHairEngineerTel" runat="server" CssClass="TextBox"></asp:TextBox>&nbsp;
                    </td>
        </tr>
        <tr>
            <td width="120px" align="right">星座：</td>
            <td><%--asp:TextBox ID="tbConstellation" runat="server" CssClass="TextBox"></asp:TextBox>--%>
                <asp:DropDownList ID="ddlConstellation" runat="server">
                <asp:ListItem Value="1" Text="白羊座"></asp:ListItem>
                <asp:ListItem Value="2" Text="金牛座"></asp:ListItem>
                <asp:ListItem Value="3" Text="双子座"></asp:ListItem>
                <asp:ListItem Value="4" Text="巨蟹座"></asp:ListItem>
                <asp:ListItem Value="5" Text="狮子座"></asp:ListItem>
                <asp:ListItem Value="6" Text="处女座"></asp:ListItem>
                <asp:ListItem Value="7" Text="天秤座"></asp:ListItem>
                <asp:ListItem Value="8" Text="天蝎座"></asp:ListItem>
                <asp:ListItem Value="9" Text="射手座"></asp:ListItem>
                <asp:ListItem Value="10" Text="摩羯座"></asp:ListItem>
                <asp:ListItem Value="11" Text="水瓶座"></asp:ListItem>
                <asp:ListItem Value="12" Text="双鱼座"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td width="120" align="right">职位：</td>
            <td><asp:TextBox ID="txtHairEngineerClass" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120px" align="right">个人小照片：</td>
            <td>
                <input id="smallLogo" type="file" runat="server"/></td>
        </tr>
        <tr>
            <td width="120px" align="right">个人照片：</td>
            <td>
                <input id="fileLogo" type="file" runat="server"/><asp:Button ID="btnPicSubmit" runat="server" OnClick="btnPicSubmit_OnClick" Text="上传照片" /><asp:Label ID="lblpicSring" runat="server" Visible="false"></asp:Label><asp:Label ID="lblpicsmallString" runat="server" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td width="100%" colspan="2"><asp:Label ID="lblPic" runat="server"></asp:Label></td>
        </tr>
        
        
        <tr>
            <td width="120" align="right">工作年限：</td>
            <td><asp:TextBox ID="txtHairEngineerYear" runat="server" CssClass="TextBox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="txtHairEngineerYear" ErrorMessage="值不对" 
                    ValidationExpression="\d*"></asp:RegularExpressionValidator>
                    </td>
        </tr>
        <tr>
            <td width="120" align="right">擅长：</td>
            <td><asp:TextBox ID="txtHairEngineerSkill" runat="server" CssClass="TextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="120" align="right">关键字：</td>
            <td><asp:TextBox ID="txtHairEngineerTag" runat="server" CssClass="TextBox"></asp:TextBox><asp:Label ID="lblRedInfo" runat="server" ForeColor="red" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td width="120" align="right">所获奖项及描述：</td>
            <td><asp:TextBox runat="server" Width="98%" Rows="15" TextMode="MultiLine" 
                    ID="txtHairEngineerDescription"></asp:TextBox></td></tr>
    </table>
    </div>
    <div>
        <script>
                function enableButton()
                {
	                var o = document.getElementById("a1");
	                var o2 = document.getElementById("a2");
	                o.style.display = "none";
	                o2.style.display = "";
	                o2.innerHTML = "信息提交中，请稍后...";
	                setTimeout("enableButton2()",3000);
                }
                function enableButton2()
                {
	                var o = document.getElementById("a1");
	                var o2 = document.getElementById("a2");
	                o2.style.display = "none";
	                o.style.display = "";
                }
                </script>
        <span id="a2"></span><span id="a1" onclick='enableButton()'><asp:Button ID="btnSubmit" runat="server" Text="提交 <<基本信息>>" OnClick="btnSubmit_OnClick" /></span>
    </div>
    </form>
</body>
</html>

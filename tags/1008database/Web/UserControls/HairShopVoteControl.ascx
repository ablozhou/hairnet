<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopVoteControl.ascx.cs" Inherits="Web.UserControls.HairShopVoteControl" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:UpdatePanel ID="updatePanel1" runat="server">
                <ContentTemplate>
<table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:10px;">
            
            <tr>
              <td width="24%" align="center" class="red14-line"><asp:LinkButton ID="linkBtnGood" runat="server" Text="很好" OnClick="linkBtnGood_OnClick"></asp:LinkButton></td>
              <td width="56%" align="left"><asp:Label ID="lblGood" runat="server"></asp:Label></td>
              <td width="20%" align="center" class="gray12-lp"><asp:Label ID="lblGoodNum" runat="server"></asp:Label> </td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><asp:LinkButton ID="linkBtnNormal" runat="server" Text="普通" OnClick="linkBtnNormal_OnClick"></asp:LinkButton></td>
              <td align="left"><asp:Label ID="lblNormal" runat="server"></asp:Label></td>
              <td align="center" class="gray12-lp"><asp:Label ID="lblNormalNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><asp:LinkButton ID="linkBtnBad" runat="server" Text="较差" OnClick="linkBtnBad_OnClick"></asp:LinkButton></td>
              <td align="left"><asp:Label ID="lblBad" runat="server"></asp:Label> </td>
              <td align="center" class="gray12-lp"><asp:Label ID="lblBadNum" runat="server"></asp:Label></td>
            </tr>
           
</table>
 </ContentTemplate>
    </asp:UpdatePanel>
    
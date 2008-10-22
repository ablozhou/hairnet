<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopDescription.ascx.cs" Inherits="Web.UserControls.HairShopDescription" %>
<div id="mft-area"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="5%" align="center" valign="middle"> 
    <img src="Theme/images/sg-meifa_02.gif" /></td>
    <td width="37%" align="left" valign="middle" class="red14b"><asp:Label ID="lblHairShopName" runat="server"></asp:Label></td>
    <td width="58%" align="right" valign="top"><table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/images/mft-tab-1.gif" id="seatchTab31" >
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>

        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/images/mft-tab-2.gif" id="seatchTab32" style="display:none">
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>

        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>

      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/images/mft-tab-3.gif" id="seatchTab33" style="display:none">
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>

        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>

      </tr>
    </table></td>
    </tr>
</table>
        <table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px" id="serTabC31">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-7"><asp:Label ID="lbllHairShopPic" runat="server"></asp:Label></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblHairShopDescription" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/images/fair-mft25.gif" />&nbsp;<a onClick='window.external.AddFavorite(location.href,document.title);' href='#'><img src="Theme/images/fair-mft26.gif" /></a></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC32">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-7"><asp:Label ID="lblHairEngineerPic" runat="server"></asp:Label></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblHairEngineerDescription" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/images/fair-mft25.gif" />&nbsp;<a onClick='window.external.AddFavorite(location.href,document.title);' href='#'><img src="Theme/images/fair-mft26.gif" /></a></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC33">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-7"></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMemberInfo" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/images/fair-mft25.gif" />&nbsp;<a onClick='window.external.AddFavorite(location.href,document.title);' href='#'><img src="Theme/images/fair-mft26.gif" /></a></td>
              </tr>
            </table></td>
          </tr>
        </table>
      </div>
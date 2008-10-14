<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopDescription.ascx.cs" Inherits="Web.UserControls.HairShopDescription" %>
<script language="javascript">
        function showTab(id) {
        var c=["serTabC1","serTabC2","serTabC3"];
        var x=["seatchTab1","seatchTab2","seatchTab3"];
        for (var i=0;i<c.length;i++){
	        if((i+1)==id){
		        document.getElementById(c[i]).style.display="";
		        document.getElementById(x[i]).style.display="";
	        }
	        else{
		        document.getElementById(c[i]).style.display="none";
		        document.getElementById(x[i]).style.display="none";
	        }
        }
        }
        </script>
        
        <script language="javascript">
        function showTab3(id) {
        var c=["serTabC31","serTabC32","serTabC33"];
        var x=["seatchTab31","seatchTab32","seatchTab33"];
        for (var i=0;i<c.length;i++){
	        if((i+1)==id){
		        document.getElementById(c[i]).style.display="";
		        document.getElementById(x[i]).style.display="";
	        }
	        else{
		        document.getElementById(c[i]).style.display="none";
		        document.getElementById(x[i]).style.display="none";
	        }
        }
        }
        </script>

<div id="mft-area"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="5%" align="center" valign="middle"><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_2.gif" id="Table1" style="display:none;">
      <tr>
        <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>
    
    
    <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_3.gif" id="Table2" style="display:none;">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>    
    <img src="Theme/Images/sg-meifa_02.gif" /></td>
    <td width="15%" align="left" valign="middle" class="red14b"><asp:Label ID="lblHairShopName" runat="server"></asp:Label></td>
    <td width="22%" align="left" valign="middle"><img src="Theme/Images/fair-mft28.gif" width="52" height="24" /></td>
    <td width="58%" align="right" valign="top"><table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-1.gif" id="seatchTab31" >
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>
        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-2.gif" id="seatchTab32" style="display:none">
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>
        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-3.gif" id="seatchTab33" style="display:none">
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
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblHairShopDescription" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC32">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblHairEngineerDescription" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC33">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f" style="height:40"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMemberInfo" runat="server"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
      </div>
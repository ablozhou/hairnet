<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopEntryControl.ascx.cs" Inherits="Web.UserControls.HairShopEntryControl" %>
<script language="javascript">
        function showTab2(id) {
        var c=["serTabC21","serTabC22"];
        var x=["seatchTab21","seatchTab22"];
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
<div id="main-top2">
  <div id="area-1"><img src="Theme/Images/sg-meifa-ad2.jpg" /></div>
  <div id="area-2">
    <table width="378" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td height="15" colspan="2">&nbsp;</td>
      </tr>
      <tr>
        <td width="179" height="25" align="left" class="red14b">&nbsp;&nbsp;<asp:Label ID="lblHairShopName" runat="server"></asp:Label></td>
        <td width="201" align="right" valign="bottom"><table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft-tab1.gif" id="seatchTab21">
            <tr>
              <td width="70" onclick="showTab2(1);" style="cursor:hand;">&nbsp;</td>
              <td width="71" onclick="showTab2(2);" style="cursor:hand;">&nbsp;</td>
            </tr>
          </table>
            <table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft-tab2.gif" id="seatchTab22"  style="display:none;">
              <tr>
                <td width="70" onclick="showTab2(1);" style="cursor:hand;">&nbsp;</td>
                <td width="71" onclick="showTab2(2);" style="cursor:hand;">&nbsp;</td>
              </tr>
          </table></td>
      </tr>
    </table>
    <div class="top-r-div" id="serTabC21">
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[地 址]</span> <asp:Label ID="lblHairShopAddress" runat="server"></asp:Label> <br />
            <span class="red12-c">[交 通]</span> <asp:Label ID="lblLocationMapUrl" runat="server"></asp:Label> </td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="39%" align="left" class="gray12-d"><span class="red12-c">[面 积] </span><asp:Label ID="lblSquare" runat="server"></asp:Label></td>
          <td width="61%" align="left" class="gray12-d"><span class="red12-c">[停车位]</span> <asp:Label ID="lblIsPostStation" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[可否刷卡]</span> <asp:Label ID="lblIsPostMachine" runat="server"></asp:Label></td>
          <td align="left" class="gray12-d"><span class="red12-c">[营业时间]</span>  <asp:Label ID="lblHairShopOpenTime" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[风 格]</span> <asp:Label ID="lblHairShopType" runat="server"></asp:Label> </td>
          <td align="left" class="gray12-d"><span class="red12-c">[主打产品]</span> <asp:Label ID="lblProduct" runat="server"></asp:Label></td>
        </tr>
      </table>
      <asp:Panel ID="p1" runat="server" Visible="false">
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
        <tr>
          <td width="39%" align="left"><asp:Label ID="lblCouponPic" runat="server"></asp:Label></td>
          <td width="61%" align="left" valign="middle" class="gray12-d">已打印：<span class="red12-c"><asp:Label ID="lblPrintNum" runat="server"></asp:Label></span><br />
          <span class="red12-line-c"><asp:Label ID="lblPrintCoupon" runat="server"></asp:Label></span></td>
        </tr>
      </table>
      </asp:Panel>
      <asp:Panel ID="p2" runat="server" Visible="true">
      <table width="360" height="20" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:5px">
        <tr>
          <td align="left" valign="bottom" class="gray12-d">订阅优惠券，请填写您的Email地址</td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="53%" align="left"><input type="text" runat="server" id="txtCouponEmail" /></td>
          <td width="47%" align="left"><asp:ImageButton style="z-index: 1002;" ID="imgBtnCouponSubmit" OnClick="imgBtnCouponSubmit_OnClick" runat="server" Width="38" Height="21"  ImageUrl="../Theme/images/fair-mft24.gif" /></td>
        </tr>
      </table>
      </asp:Panel>
	  <table width="400" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:23px">
  <tr>
    <td width="3%"></td>
    <td width="94%" height="26" style="border:#ddddda 1px solid"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="43%" align="left" class="gray12-d"><span class="red12b">预约电话：</span><asp:Label ID="lblHairShopPhoneNum" runat="server"></asp:Label></td>
        <td width="28%" align="left" class="gray12-d">折扣：<span class="red12-c"><asp:Label ID="lblHairShopDiscount" runat="server"></asp:Label></span></td>
        <td width="29%" align="right" class="gray12-d"><asp:Label ID="lblComment" runat="server"></asp:Label>&nbsp;&nbsp;  <asp:Label ID="lblStore" runat="server"></asp:Label></td>
      </tr>
    </table></td>
    <td width="3%"></td>
  </tr>
</table>
	</div>
	<div class="top-r-div" id="serTabC22" style="display:none">
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td align="left" class="gray12-d">具体内容，等待SG切片</td>
        </tr>
      </table>
	</div>
  </div>
</div>
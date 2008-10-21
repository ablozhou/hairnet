<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopEntryControl.ascx.cs" Inherits="Web.UserControls.HairShopEntryControl" %>
<div id="main-top2">
  <div id="area-1">
  <asp:Label ID="picDisplayPara" runat="server"></asp:Label>

 <SCRIPT>
function $(id){
 return document.getElementById?document.getElementById(id):document.all(id)
}
var timeout1;
var timeout2;
function fnToggle() {
    var next = NowFrame + 1;
    if(next == MaxFrame+1)
    {
        NowFrame = MaxFrame;
        next = 1;
    }
    if(bStart == 0)
    {
        bStart = 1;
        timeout1 = setTimeout('fnToggle()', 5500);
        return;
    }
    else
    {
  if (isie)
  {
   oTransContainer.filters[0].Apply();
  }
   $('oDIV'+next).style.display = "";
   $('oDIV'+NowFrame).style.display = "none";
  if (isie)
  {
     oTransContainer.filters[0].Play(duration=2);
   }
        if(NowFrame == MaxFrame)
            NowFrame = 1;
        else
            NowFrame++;
    }    timeout2 = setTimeout('fnToggle()', 3500);
}
fnToggle();
function GoToPic(id)
{
      clearTimeout(timeout1);
      clearTimeout(timeout2);
      if (isie)
      {
       oTransContainer.filters[0].Apply();
      }
      if(id != NowFrame)
      {
       $('oDIV'+id).style.display = "";
       $('oDIV'+NowFrame).style.display = "none";
      if (isie)
      {
         oTransContainer.filters[0].Play(duration=2);
       }}
       NowFrame = id;           
       
}
</SCRIPT>
<DIV id=oTransContainer style="FILTER: progid:DXImageTransform.Microsoft.Wipe(GradientSize=1.0,wipeStyle=0, motion='forward'); position:relative; WIDTH: 259px; HEIGHT: 130px">
<asp:Label ID="picDisplayContent" runat="server"></asp:Label>
</DIV>
  
  </div>
  <div id="area-2">
    <table width="378" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td height="15" colspan="2">&nbsp;</td>
      </tr>
      <tr>
        <td width="234" height="25" align="left" class="red14b">&nbsp;&nbsp;<asp:Label ID="lblHairShopName" runat="server"></asp:Label></td>
        <td width="144" align="right" valign="bottom"><table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/images/fair-mft-tab1.gif" id="seatchTab21">
          <tr>
            <td width="70" onclick="showTab2(1);" style="cursor:hand;">&nbsp;</td>
            <td width="71" onclick="showTab2(2);" style="cursor:hand;">&nbsp;</td>
          </tr>
        </table><table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/images/fair-mft-tab2.gif" id="seatchTab22"  style="display:none;">
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
          <td align="left" class="gray12-d"><span class="red12-c">[地 址]</span><asp:Label ID="lblHairShopAddress" runat="server"></asp:Label><br />
            <span class="red12-c">[交 通]</span>  <asp:Label ID="lblLocationMapUrl" runat="server"></asp:Label> </td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="37%" align="left" class="gray12-d"><span class="red12-c">[面 积] </span><asp:Label ID="lblSquare" runat="server"></asp:Label></td>
          <td width="63%" align="left" class="gray12-d"><span class="red12-c">[停车位]</span> <asp:Label ID="lblIsPostStation" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[可否刷卡]</span> <asp:Label ID="lblIsPostMachine" runat="server"></asp:Label></td>
          <td align="left" class="gray12-d"><span class="red12-c">[营业时间]</span> <asp:Label ID="lblHairShopOpenTime" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[风 格]</span>  <asp:Label ID="lblHairShopType" runat="server"></asp:Label>  </td>
          <td align="left" class="gray12-d"><span class="red12-c">[主打产品]</span>  <asp:Label ID="lblProduct" runat="server"></asp:Label></td>
        </tr>
      </table>
      <asp:Panel ID="p2" runat="server">
	  <table width="360" height="40" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:5px">
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
      <asp:Panel ID="p1" runat="server">
      <table width="360" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
        <tr>
          <td width="39%" align="left"><asp:Label ID="lblCouponPic" runat="server"></asp:Label></td>
          <td width="61%" align="left" valign="middle" class="gray12-d">已打印：<span class="red12-c"><asp:Label ID="lblPrintNum" runat="server"></asp:Label></span><br />
          <span class="red12-line-c"><asp:Label ID="lblPrintCoupon" runat="server"></asp:Label></span></td>
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
	<div class="top-r-div" id="serTabC22" style="display:none;">
	<div class="hj-gundong"><asp:Label ID="lblHairShopPicList" runat="server"></asp:Label></div>
	<asp:Panel ID="Panel1" runat="server">
	<table width="360" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
        <tr>
          <td width="39%" align="left"><asp:Label ID="lblCouponPic2" runat="server"></asp:Label></td>
          <td width="61%" align="left" valign="middle" class="gray12-d">已打印：<span class="red12-c"><asp:Label ID="lblPrintNum2" runat="server"></asp:Label></span><br />
          <span class="red12-line-c"><asp:Label ID="lblPrintCoupon2" runat="server"></asp:Label></span></td>
        </tr>
      </table>
	</asp:Panel>
	  <asp:Panel ID="Panel2" runat="server">
	  <table width="360" height="30" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:5px">
        <tr>
          <td align="left" valign="bottom" class="gray12-d">订阅优惠券，请填写您的Email地址</td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="53%" align="left"><input type="text" runat="server" id="txtCouponEmail2" /></td>
          <td width="47%" align="left"><asp:ImageButton style="z-index: 1002;" ID="ImageButton1" OnClick="imgBtnCouponSubmit2_OnClick" runat="server" Width="38" Height="21"  ImageUrl="../Theme/images/fair-mft24.gif" /></td>
        </tr>
      </table>
      </asp:Panel>
	  <table width="400" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:23px">
  <tr>
    <td width="3%"></td>
    <td width="94%" height="26" style="border:#ddddda 1px solid"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="43%" align="left" class="gray12-d"><span class="red12b">预约电话：</span><asp:Label ID="lblHairShopPhoneNum2" runat="server"></asp:Label></td>
        <td width="28%" align="left" class="gray12-d">折扣：<span class="red12-c"><asp:Label ID="lblHairShopDiscount2" runat="server"></asp:Label></span></td>
        <td width="29%" align="right" class="gray12-d"><asp:Label ID="lblComment2" runat="server"></asp:Label>&nbsp;&nbsp;  <asp:Label ID="lblStore2" runat="server"></asp:Label></td>
      </tr>
    </table></td>
    <td width="3%"></td>
  </tr>
</table>
	</div>
  </div>
</div>
<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false" MasterPageFile="Home.Master" CodeBehind="CouponList.aspx.cs" Inherits="Web.CouponList" %>
<%@ Register src="UserControls/CouponDetailList.ascx" tagname="CouponDetailList" tagprefix="uc1" %>
<%@ Register src="UserControls/HotCouponList.ascx" tagname="HotCouponList" tagprefix="uc2" %>
<%@ Register src="UserControls/HotCouponList2.ascx" tagname="HotCouponList2" tagprefix="uc3" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" runat="server" ID="BodyContent">
<!-- 主体部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="yhq-logo"><a href="#"><img src="Theme/images/fair-yhq-logo.gif" border="0" /></a></div>
	<table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/images/fair-yhq-01.gif" class="red14b">
            &nbsp;&nbsp;分类&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
      </tr>
      <tr>
        <td background="Theme/images/fair-yhq-02.gif"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="35" align="left" class="gray14-b">按商圈：</td>
          </tr>
          <tr>
            <td align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="66%" class="search-bg" style="border-left:#cbcbcb 1px solid;"><asp:TextBox ID="txtBuziZone" runat="server" CssClass="search-input"></asp:TextBox></td>
                <td width="11%" align="left" class="search-bg"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                <td width="21%" align="center" class="search-bg"><span class="search"><asp:LinkButton ID="linkBtnHotZone" runat="server" OnClick="btnBusiZoneSearch_Click" Text="搜&nbsp;索"></asp:LinkButton></span></td>
                <td width="2%" align="right" class="search-bg"><img src="Theme/images/sg-meifa_14.gif" width="4" height="25" /></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td height="35" align="left" class="gray14-b">按店名：</td>
          </tr>
          <tr>
            <td align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="66%" class="search-bg" style="border-left:#cbcbcb 1px solid;"><asp:TextBox ID="txtHairShopName" runat="server" CssClass="search-input"></asp:TextBox></td>
                  <td width="11%" align="left" class="search-bg"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                  <td width="21%" align="center" class="search-bg"><span class="search"><asp:LinkButton ID="btnKeySearch" runat="server" OnClick="btnKeySearch_Click" Text="搜&nbsp;索"></asp:LinkButton></span></td>
                  <td width="2%" align="right" class="search-bg"><img src="Theme/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
            </table></td>
          </tr>
        </table>
		<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
		        <tr>
                  <td height="35" align="left" class="red14b">&nbsp;&nbsp;关键字</td>
                </tr>
                <tr>
                  <td height="10" align="center" valign="top"><img src="Theme/images/sg-meifa_46.gif" width="240" height="2" /></td>
                </tr>
          </table>
		<!-- #include file="coupontags.htm" --> </td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/images/fair-yhq-01.gif" class="red14b">
            &nbsp;&nbsp;最热优惠券</td>
      </tr>
      <tr>
        <td background="Theme/images/fair-yhq-02.gif"><uc2:HotCouponList ID="HotCouponList1" runat="server" /></td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/images/fair-yhq-01.gif" class="red14b">
            &nbsp;&nbsp;最新优惠券</td>
      </tr>
      <tr>
        <td background="Theme/images/fair-yhq-02.gif">
        
            <uc3:HotCouponList2 ID="HotCouponList21" CouponType="1" runat="server" />
       
         </td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <div class="clear"></div>
  </div>
  
	
	 <!-- 优惠券列表 -->
	<uc1:CouponDetailList ID="CouponDetailList1" runat="server" />
    <!-- 优惠券列表结束 -->
  
  <div class="clear"></div>
</div>
<!-- 主体部分结束 -->
</asp:Content>
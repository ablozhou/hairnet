<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopList.aspx.cs" Inherits="Web.HairShopList" %>
<%@ Register Src="UserControls/HotHairShopList.ascx" TagName="HotHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/RecommandHairShopList.ascx" TagName="RecommandHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotCouponList2.ascx" TagName="HotCouponList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopListControl.ascx" TagName="HairShopListControl" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<div style="text-align:center; height:160px;">
<iframe src="SearchHeadPage.aspx" width="980" height="160" frameborder="no" border="0" marginwidth="0" marginheight="0" scrolling="no" allowtransparency="yes"></iframe>
</div>
<div id="main-top2"></div>
<!--�������ݲ��ֿ�ʼ -->
<div id="main">
  <div id="main-l">
    <div id="mfs-tj">
      <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/images/fair-mft04-a.gif">
        <tr>
          <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;�������Ƽ�</td>
          <td width="12%" align="left" valign="middle"><img src="Theme/images/mft_list_salon.gif" alt="�������Ƽ�" /></td>
          <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
          <td width="10%" align="left" valign="middle">&nbsp;</td>
        </tr>
      </table>
      <!--����������ʼ -->
        <HN:RecommandHairShopList ID="recommandHairShopList" runat="server" />
      <!--������������ -->
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="Theme/images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
      <div class="null-box"></div>
       <!--�������б�ʼ -->
       <HN:HairShopListControl ID="hairShopListControl" runat="server" />
       <!--�������б���� -->
  </div>
  <div id="main-r">
<div class="main-r-box">
	    <table width="100%" border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left"><table width="258" height="33" border="0" cellpadding="0" cellspacing="0" style="margin-left:1px;">
              <tr>
                <td width="108" height="33" style="border-top:#d5d5d5 1px solid;border-left:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box1" onclick="showPage(1)">����������</div></td>
                <td width="107" style="border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box2" onclick="showPage(2)">�����Ż�ȯ</div></td>
                <td width="43" bgcolor="#FAFAFA">&nbsp;</td>
              </tr>
            </table>
            <img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /><br /><br />

</td>
          </tr>
          
      </table>
		<div id="container"></div>
	  <div id="page1">
	  <!--������������ʼ -->
	    <HN:HotHairShopList ID="hotHairShopList" runat="server" />
	    <!--�������������� -->
	  </div>
		<div id="page2">
		<!--�Ż�ȯ��ʼ -->
	    <HN:HotCouponList ID="hotCouponList" runat="server" />
	    <!--�Ż�ȯ���� -->
	  </div>		
    </div> 	
    <div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;���ű�ǩ&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	 <!-- #include file="shophottags.htm" -->
	</div>
	<div class="main-r-box2">
	<!-- #include file="shophotcomment.htm" -->
	 </div>
	<div class="main-r-box">
	
	<!-- #include file="userrecommendshop.htm" -->
	</div>
  </div>
  <div id="main-rr"></div>
    <div class="clear"></div>
	<div><img src="Theme/images/fair-mft15.gif" /></div>
</div>
<!--�������ݲ��ֽ��� -->
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopList.aspx.cs" Inherits="Web.HairShopList" %>
<%@ Register Src="UserControls/SearchHead.ascx" TagName="SearchHead" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotHairShopList.ascx" TagName="HotHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/RecommandHairShopList.ascx" TagName="RecommandHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotCouponList2.ascx" TagName="HotCouponList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopListControl.ascx" TagName="HairShopListControl" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--搜美发厅开始 -->
<HN:SearchHead ID="searchHead" runat="server" />
<!--搜美发厅结束 -->
<div id="main-top2"></div>
<!--主体内容部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="mfs-tj">
      <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/images/fair-mft04-a.gif">
        <tr>
          <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;发型厅推荐</td>
          <td width="12%" align="left" valign="middle"><img src="Theme/images/mft_list_salon.gif" alt="发型师推荐" /></td>
          <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
          <td width="10%" align="left" valign="middle">&nbsp;</td>
        </tr>
      </table>
      <!--搜美发厅开始 -->
        <HN:RecommandHairShopList ID="recommandHairShopList" runat="server" />
      <!--搜美发厅结束 -->
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="Theme/images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
      <div class="null-box"></div>
       <!--美发厅列表开始 -->
       <HN:HairShopListControl ID="hairShopListControl" runat="server" />
       <!--美发厅列表结束 -->
  </div>
  <div id="main-r">
<div class="main-r-box">
	    <table width="100%" border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left"><table width="258" height="33" border="0" cellpadding="0" cellspacing="0" style="margin-left:1px;">
              <tr>
                <td width="108" height="33" style="border-top:#d5d5d5 1px solid;border-left:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box1" onclick="showPage(1)">人气美发厅</div></td>
                <td width="107" style="border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box2" onclick="showPage(2)">最热优惠券</div></td>
                <td width="43" bgcolor="#FAFAFA">&nbsp;</td>
              </tr>
            </table>
            <img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /><br /><br />

</td>
          </tr>
          
      </table>
		<div id="container"></div>
	  <div id="page1">
	  <!--最热美发厅开始 -->
	    <HN:HotHairShopList ID="hotHairShopList" runat="server" />
	    <!--最热美发厅结束 -->
	  </div>
		<div id="page2">
		<!--优惠券开始 -->
	    <HN:HotCouponList ID="hotCouponList" runat="server" />
	    <!--优惠券结束 -->
	  </div>		
    </div> 	
    <div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;热门标签&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="98%" height="240" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:3px;margin-bottom:3px">
        <tr>
          <td width="5%" align="left" valign="top" class="gray14-e">&nbsp;</td>
          <td width="92%" height="240" align="left" valign="top"  style="line-height:30px;" ><span class="tag_1"><a href="#">发型</a></span>  <span class="tag_5"><a href="#">发型设计</a></span>  流行发型  <span class="tag_3"><a href="#">新娘发型</a></span><br />
            <span class="tag_4"><a href="#">非主流发型</a></span>  <span class="tag_2"><a href="#">短发发型</a></span>  卷发发型<br />
            <span class="tag_5"><a href="#">烫发</a></span>  刘海  直发发型  染发  <span class="tag_1"><a href="#">托尼盖</a></span><br />
            如何护发  <span class="tag_3"><a href="#">春季护发</a></span>  沙宣  <span class="tag_5"><a href="#">水母发型</a></span><br />
            洗发水  <span class="tag_1"><a href="#">淑女发型</a></span>  <span class="tag_2"><a href="#">日系发型</a></span>  通勤发型<br />
            减龄发型  <span class="tag_5"><a href="#">瘦脸发型</a></span>  朋克发型  护发<br />
            <span class="tag_3"><a href="#">出游发型</a></span>  <span class="tag_4"><a href="#">韩式发型</a></span>  BOB发型 <br />
          <span class="tag_2"><a href="#">2008年流行发型</a></span>  <span class="tag_1"><a href="#">冬季发型</a></span> </td>
          <td width="3%" align="left" valign="top" class="gray14-e">&nbsp;</td>
        </tr>
      </table>
	</div>
	<div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;最热店评&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="98%" height="202" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:3px;margin-bottom:3px">
        <tr>
          <td height="202" align="left" valign="top" class="gray14-e"><table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;margin-bottom:12px">
            <tr>
              <td width="79%" align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
              <td width="21%" align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
              <td width="21%" align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td width="21%" align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
              <td align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
              <td align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td align="center" class="red14">[审美]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td align="center" class="red14">[审美]</td>
            </tr>
          </table></td>
        </tr>
      </table>
    </div>
	<div class="main-r-box">
	    <table width="100%" height="41" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
          <tr>
            <td height="28" align="left" class="red14b">&nbsp;&nbsp;网友推荐店&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td height="8"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
        </table>
        <table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;margin-bottom:12px">
          <tr>
            <td width="83%" align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
            <td width="17%" align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
            <td width="17%" align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
            <td width="17%" align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
            <td align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
            <td align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
            <td align="center" class="red14">88折</td>
          </tr>
          <tr>
            <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
            <td align="center" class="red14">88折</td>
          </tr>
        </table>
  </div>
  </div>
  <div id="main-rr"></div>
    <div class="clear"></div>
	<div><img src="Theme/images/fair-mft15.gif" /></div>
</div>
<!--主体内容部分结束 -->
</asp:Content>

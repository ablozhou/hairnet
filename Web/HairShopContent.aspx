<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopContent.aspx.cs" Inherits="Web.HairShopContent" %>

<%@ Register Src="UserControls/HairShopEntryControl.ascx" TagName="HairShopEntryControl" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopDescription.ascx" TagName="HairShopEntryDescription" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopEngineerList.ascx" TagName="HairShopEngineerList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopWorkList.ascx" TagName="HairShopWorkList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotHairEngineerList.ascx" TagName="HotHairEngineerList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotCouponList.ascx" TagName="HotCouponList" TagPrefix="HN" %>
<%@ Register Src="UserControls/SameHotZoneHairShopList.ascx" TagName="SameHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/NewWorkList.ascx" TagName="NewWorkList" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<div style="text-align:center; height:160px;">
<iframe src="SearchHeadPage.aspx" width="980" height="160" frameborder="no" border="0" marginwidth="0" marginheight="0" scrolling="no" allowtransparency="yes"></iframe>
</div>
<!-- 美发厅基本信息 -->
<HN:HairShopEntryControl ID="hairShopEntryControl" runat="server" />
<!-- 美发厅基本信息结束 -->

<!--主体内容部分开始 -->
<div id="main">
  <div id="main-l">
    <!-- 美发厅相关信息 -->
    <HN:HairShopEntryDescription ID="hairShopEntryDescription" runat="server" />
    <!-- 美发厅相关信息结束 -->
	  <div class="null-box"></div>
	<!-- 美发师列表 -->
      <HN:HairShopEngineerList ID="hairShopEngineerList" runat="server" />
    <!-- 美发师列表结束 -->
    
      <div class="null-box"></div>
      <!-- 作品列表 -->
      <HN:HairShopWorkList ID="hairShopWorkList" runat="server" />
     <!-- 作品列表结束 -->
	  <div class="null-box"></div>
      <div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="10" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="135" align="left" background="Theme/images/fair-mft08.gif" class="red14b"><a href="#" target="_blank">看看大家的评论</a></td>
            <td width="472" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="84" align="right" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft07.gif" width="3" height="29" /></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="5" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft10.gif" /></td>
            <td width="23" align="center" background="Theme/images/fair-mft12.gif"><img src="Theme/images/sg-meifa_02.gif" /></td>
            <td width="59" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c">我要评论</td>
            <td width="148" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c">用户名:</td>
            <td width="147" align="center" background="Theme/images/fair-mft12.gif"><input name="textfield2" type="text" class="pass" /></td>
            <td width="52" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c">密　码:</td>
            <td width="160" align="center" background="Theme/images/fair-mft12.gif"><input name="textfield22" type="text" class="pass" /></td>
            <td width="97" align="center" background="Theme/images/fair-mft12.gif" class="gray12-c"><a href="#" target="_blank">注册</a>   &nbsp;<a href="#" target="_blank">登陆</a></td>
            <td width="10" align="right" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box"><textarea cols="" rows="" class="pl-box"></textarea></div>
		
		<div class="submit"><a href="#" target="_blank"><img src="Theme/images/fair-submit.gif" border="0" /></a></div>
		<div class="message-1">
		  <div class="touxiang"><div class="touxiang-2"><img src="Theme/images/sg-meifa_ls01.gif" /></div></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">回复：</td>
                <td align="left" class="gray12-c">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-2">
		  <div class="touxiang"><div class="touxiang-2"><img src="Theme/images/sg-meifa_ls01.gif" /></div></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">回复：</td>
                <td align="left" class="gray12-c">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-1">
		  <div class="touxiang"><div class="touxiang-2"><img src="Theme/images/sg-meifa_ls01.gif" /></div></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">回复：</td>
                <td align="left" class="gray12-c">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-2">
		  <div class="touxiang"><div class="touxiang-2"><img src="Theme/images/sg-meifa_ls01.gif" /></div></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">回复：</td>
                <td align="left" class="gray12-c">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>	
		<div class="page-all"><a href="#">第一页</a>  <a href="#">上一页</a>  <a href="#">1</a> <span class="red12">2</span> <a href="#">3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a>  &nbsp;<a href="#">下一页</a>&nbsp;&nbsp;<a href="#">最后一页</a>&nbsp;&nbsp;共8页</div>	
<div class="clear"></div>
      </div>
  </div>
  <div id="main-r"><table width="260" height="32" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/images/fair-09b.gif">
          <tr>
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;地址位置</a></td>
            <td width="46%" align="left" ><img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"></a></td>
          </tr>
        </table>
      <div class="sitemap"><img src="Theme/images/fair-mft19.gif" /></div>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="35" align="left" valign="middle" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">我要投票</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
    </table>
			 <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:10px;">
            <tr>
              <td width="24%" align="center" class="red14-line"><a href="#">很好</a></td>
              <td width="56%" align="left"><img src="Theme/images/fair-mft20.gif" width="129" height="11" /></td>
              <td width="20%" align="center" class="gray12-lp">70%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">普通</a></td>
              <td align="left"><img src="Theme/images/fair-mft21.gif" width="129" height="11" /></td>
              <td align="center" class="gray12-lp">20%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">较差</a></td>
              <td align="left"><img src="Theme/images/fair-mft22.gif" width="129" height="11" /></td>
              <td align="center" class="gray12-lp">10%</td>
            </tr>
    </table>
	<div class="main-r-box">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td align="left"><table width="210" height="27" border="0" cellpadding="0" cellspacing="0" style="margin-left:1px;">
              <tr>
                <td style="border-left:#d5d5d5 1px solid;border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box1" onclick="showPage(1)">发型师关注度榜</div></td>
                <td style="border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box2" onclick="showPage(2)">优惠券下载榜</div></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
        </table>
		<div id="container"></div>
		<div id="page1">
		<!-- 热门美发师列表 -->
	    <HN:HotHairEngineerList ID="hotHairEngineerList" runat="server" />
	    <!-- 热门美发师列表 -->
		</div>
		<div id="page2">
		<!-- 热门优惠券列表 -->
	    <HN:HotCouponList ID="hotCouponList" runat="server" />
	    <!-- 热门优惠券列表 -->
		</div>		
    </div> 	
	<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;周边美发厅&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <!-- 周边美发厅列表 -->
	  <HN:SameHairShopList ID="sameHairShopList" runat="server" />
	  <!-- 周边美发厅列表 -->
	</div>
	<!-- 最新作品列表 -->
	  <HN:NewWorkList ID="newWorkList" runat="server" />
	<!-- 最新作品列表 -->
<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;浏览过此美发店的还有谁&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/images/sg-meifa_ls01.gif" alt="图片说明" /></a></div><div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
            </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
             </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
              </td>
          </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="35%" align="left" class="gray12">&nbsp;<img src="Theme/images/sg-meifa_02.gif" width="5" height="9" />&nbsp;已有56人&nbsp;</td>
          <td width="65%" align="left" class="gray12"><a href="#"><img src="Theme/images/fair-mft23.gif" width="59" height="19" border="0" /></a></td>
        </tr>
      </table>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td height="30" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;来此美发店的网友还浏览过&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
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
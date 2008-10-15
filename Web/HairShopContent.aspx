<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopContent.aspx.cs" Inherits="Web.HairShopContent" %>
<%@ Register Src="UserControls/SearchHead.ascx" TagName="SearchHead" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopEntryControl.ascx" TagName="HairShopEntryControl" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopDescription.ascx" TagName="HairShopEntryDescription" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopEngineerList.ascx" TagName="HairShopEngineerList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopWorkList.ascx" TagName="HairShopWorkList" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--搜美发厅开始 -->
<HN:SearchHead ID="searchHead" runat="server" />
<!--搜美发厅结束 -->

<!--美发厅信息显示 -->
<HN:HairShopEntryControl ID="hairShopEntryControl" runat="server" />
<!-- 美发厅信息显示结束 -->

<!--主体内容部分开始 -->
<div id="main">
  <div id="main-l">
      <!--美发厅其他信息显示 -->
      <HN:HairShopEntryDescription ID="hairShopEntryDescription" runat="server" />
      <!-- 美发厅其他信息显示结束 -->
	  <div class="null-box"></div>
	  <!--美发厅美发师列表 -->
      <HN:HairShopEngineerList ID="hairShopEngineerList" runat="server" />
      <!-- 美发厅美发师列表结束 -->
      
	  <div class="null-box"></div>
	  <!--近期作品列表 -->
      <HN:HairShopWorkList ID="hairShopWorkList" runat="server" />
      <!--近期列表列表就结束 -->
	  <div class="null-box"></div>
      <div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="10" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="135" align="left" background="Theme/Images/fair-mft08.gif" class="red14b">看看大家的评论</td>
            <td width="472" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="84" align="right" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft07.gif" width="3" height="29" /></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="5" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft10.gif" /></td>
            <td width="23" align="center" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/sg-meifa_02.gif" /></td>
            <td width="59" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c">我要评论</td>
            <td width="148" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">用户名:</td>
            <td width="147" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield2" type="text" class="pass" /></td>
            <td width="52" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">密　码:</td>
            <td width="160" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield22" type="text" class="pass" /></td>
            <td width="97" align="center" background="Theme/Images/fair-mft12.gif" class="gray12-c"><a href="#" target="_blank">注册</a>   &nbsp;<a href="#" target="_blank">登陆</a></td>
            <td width="10" align="right" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box"><textarea cols="" rows="" class="pl-box"></textarea></div>
		
		<div class="submit"><a href="#" target="_blank"><img src="Theme/Images/fair-submit.gif" border="0" /></a></div>
		<div class="message-1">
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
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
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
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
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
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
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">留言：</td>
    <td width="69%" align="left" class="black12">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋。</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21：45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
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
<div class="clear"></div>
      </div>
  </div>
  <div id="main-r"><table width="260" height="32" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/Images/fair-09b.gif">
          <tr>
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;地址位置</a></td>
            <td width="46%" align="left" ><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"></a></td>
          </tr>
        </table>
      <div class="sitemap"><img src="Theme/Images/fair-mft19.gif" /></div>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="35" align="left" valign="middle" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">我要投票</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
    </table>
			 <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:10px;">
            <tr>
              <td width="24%" align="center" class="red14-line"><a href="#">很好</a></td>
              <td width="56%" align="left"><img src="Theme/Images/fair-mft20.gif" width="129" height="11" /></td>
              <td width="20%" align="center" class="gray12-lp">70%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">普通</a></td>
              <td align="left"><img src="Theme/Images/fair-mft21.gif" width="129" height="11" /></td>
              <td align="center" class="gray12-lp">20%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">较差</a></td>
              <td align="left"><img src="Theme/Images/fair-mft22.gif" width="129" height="11" /></td>
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
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
        </table>
		<div id="container"></div>
		<div id="page1">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="80" align="center"><img src="Theme/Images/sg-08bbs_1.gif" /></td>
            <td width="85%" align="left"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div></td>
                  <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                      <span class="red12"><a href="#" target="_blank"></a></span></td>
                  <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">审美</a></span><br />
                      <span class="red12">推荐指数：4</span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_4.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_5.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_6.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_7.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">翻的五味瓶用心体吉林向海</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_8.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
        </table>
		</div>
		<div id="page2">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="80" align="center"><img src="Theme/Images/sg-08bbs_1.gif" /></td>
            <td width="85%" align="left"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div></td>
                  <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                      <span class="red12"><a href="#" target="_blank"></a></span></td>
                  <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">审美222</a></span><br />
                      <span class="red12">推荐指数22：4</span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海22：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海22：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_4.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_5.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_6.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_7.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">翻的五味瓶用心体吉林向海</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_8.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
        </table>
		</div>		
    </div> 	
	<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;周边美发厅&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-3"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">审美88折</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-3"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">审美88折</a></div></td>
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
	<div class="main-r-box">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;其他店最新作品&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
        </table>
	    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:10px">
                <tr>
                  <td width="50%" align="center"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
                  <td width="50%" align="center"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls01.gif" width="94" height="94" /></a></div></td>
                </tr>
                <tr>
                  <td align="center"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
                  <td align="center"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
                </tr>
      </table>
    </div>
<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;浏览过此美发店的还有谁&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div><div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
            </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
             </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">超模新男</span></a></div>
              </td>
          </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="35%" align="left" class="gray12">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;已有56人&nbsp;</td>
          <td width="65%" align="left" class="gray12"><a href="#"><img src="Theme/Images/fair-mft23.gif" width="59" height="19" border="0" /></a></td>
        </tr>
      </table>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td height="30" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;来此美发店的网友还浏览过&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
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
	<div><img src="Theme/Images/fair-mft15.gif" /></div>
</div>
<!--主体内容部分结束 -->
</asp:Content>
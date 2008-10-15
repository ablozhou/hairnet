<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="CouponList.aspx.cs" Inherits="Web.CouponList" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" runat="server" ID="BodyContent">
<!-- 主体部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="yhq-logo"><a href="#"><img src="Theme/Images/fair-yhq-logo.gif" border="0" /></a></div>
	<table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/Images/fair-yhq-01.gif" class="red14b">&nbsp;&nbsp;分类&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
      </tr>
      <tr>
        <td background="Theme/Images/fair-yhq-02.gif"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="35" align="left" class="gray14-b">按商圈：</td>
          </tr>
          <tr>
            <td align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
			<form method=post action=# target=_blank>
              <tr>
                <td width="66%" class="search-bg" style="border-left:#cbcbcb 1px solid;"><input name="textfield" type="text" class="search-input" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                <td width="11%" align="left" class="search-bg"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                <td width="21%" align="center" class="search-bg"><span class="search"><a href="#" target="_blank">
                    <asp:Button ID="btnBusiZoneSearch" runat="server" Text="搜&nbsp;索" onclick="btnBusiZoneSearch_Click" 
                         /></a></span></td>
                <td width="2%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
              </tr></form>
            </table></td>
          </tr>
          <tr>
            <td height="35" align="left" class="gray14-b">按店名：</td>
          </tr>
          <tr>
            <td align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <form method="post" action="#" target="_blank">
                <tr>
                  <td width="66%" class="search-bg" style="border-left:#cbcbcb 1px solid;"><input name="textfield2" type="text" class="search-input" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                  <td width="11%" align="left" class="search-bg"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                  <td width="21%" align="center" class="search-bg"><span class="search"><a href="#" target="_blank">
                      <asp:Button ID="btnKeySearch" runat="server" Text="搜&nbsp;索" 
                          onclick="btnKeySearch_Click" /></a></span></td>
                  <td width="2%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </form>
            </table></td>
          </tr>
        </table>
		<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
		        <tr>
                  <td height="35" align="left" class="red14b">&nbsp;&nbsp;关键字</td>
                </tr>
                <tr>
                  <td height="10" align="center" valign="top"><img src="Theme/Images/sg-meifa_46.gif" width="240" height="2" /></td>
                </tr>
          </table>
          <!--#include   file="coupontags.htm"-->
		</td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/Images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/Images/fair-yhq-01.gif" class="red14b">&nbsp;&nbsp;最热优惠券</td>
      </tr>
      <tr>
        <td background="Theme/Images/fair-yhq-02.gif"><table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;">
                <tr>
                  <td width="83%" align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
                  <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
                  <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
                  <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
                  <td align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
                  <td align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
                  <td align="left" class="gray14-line"><span class="red14">88折</span></td>
                </tr>
                <tr>
                  <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
                  <td align="left"><span class="red14">88折</span></td>
                </tr>
              </table></td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/Images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <table width="263" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
      <tr>
        <td height="37" align="left" valign="middle" background="Theme/Images/fair-yhq-01.gif" class="red14b">&nbsp;&nbsp;最新优惠券</td>
      </tr>
      <tr>
        <td background="Theme/Images/fair-yhq-02.gif"><table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;">
            <tr>
              <td width="83%" align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
              <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
              <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td width="17%" align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
              <td align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></td>
              <td align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-line">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td align="left" class="gray14-line"><span class="red14">88折</span></td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></td>
              <td align="left"><span class="red14">88折</span></td>
            </tr>
        </table></td>
      </tr>
      <tr>
        <td valign="top"><img src="Theme/Images/fair-yhq-03.gif" /></td>
      </tr>
    </table>
    <div class="clear"></div>
  </div>
  <div id="main-r">
    <table width="100%" height="34" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/fair-yhq-04.gif">
      <tr>
        <td width="22%" align="center" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-yhq-09.gif" alt="打印优惠券" width="111" height="19" border="0" /></a></td>
        <td width="46%" align="center" valign="middle" class="gray12">优惠名称</td>
        <td width="32%" align="left" valign="middle" class="gray12">商圈</td>
      </tr>
    </table>
    <table width="99%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>	
    <div class="point">&nbsp;</div>
	<table width="99%" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#f7f7f7">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>	
    <div class="point">&nbsp;</div>
	<table width="99%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>	
    <div class="point">&nbsp;</div>
	<table width="99%" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#f7f7f7">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>
	<div class="point">&nbsp;</div>
	<table width="99%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>	
    <div class="point">&nbsp;</div>
	<table width="99%" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#f7f7f7">
      <tr>
        <td width="6%" align="right" valign="middle"><input type="checkbox" name="checkbox" value="checkbox" /></td>
        <td width="30%" align="center" valign="middle"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:25px;">
          <tr>
            <td align="center" class="yhq-pic"><img src="Theme/Images/fair-yhq-temp1.gif" width="160" height="95" /></td>
          </tr>
          <tr>
            <td height="50" align="center" valign="middle"><a href="#"><img src="Theme/Images/fair-yhq-07.gif" width="59" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#"><img src="Theme/Images/fair-yhq-08.gif" width="59" height="19" border="0" /></a></td>
          </tr>
        </table></td>
        <td width="64%" align="left" valign="top"><table width="95%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px;">
          <tr>
            <td height="35" colspan="3" align="left" valign="middle" class="red14b" style="border-bottom:#e8e8e8 1px solid">&nbsp;审美总店8.5折优惠券</td>
            </tr>
			<tr>
            <td height="8" colspan="3" align="left"></td>
            </tr>
          <tr>
            <td width="46%" height="65" valign="top" class="gray12-d"> &nbsp;&nbsp;&nbsp;&nbsp;凭此券可享受烫染8.5折，剪发除外，购买产品除外</td>
            <td width="22%" align="center" valign="top" class="gray14">国贸</td>
            <td width="32%" valign="top" class="gray12-d">有 效 期&nbsp;&nbsp;至2009年<br />
              联系方式   &nbsp;&nbsp;5999999999</td>
          </tr>
          <tr>
            <td align="center" class="gray12-bg"><a href="#" target="_blank">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">更多评论&gt;&gt;</a></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table>
	 <div class="point">&nbsp;</div>
	<div class="page-all"><a href="#">第一页</a>  <a href="#">上一页</a>  <a href="#">1</a> <span class="red12">2</span> <a href="#">3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a>  &nbsp;<a href="#">下一页</a>&nbsp;&nbsp;<a href="#">最后一页</a>&nbsp;&nbsp;共8页</div>
	<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="bottom"><img src="Theme/Images/fair-yhq-06.gif" /></td>
  </tr>
</table>

  </div>
  <div class="clear"></div>
</div>
<!-- 主体部分结束 -->
</asp:Content>
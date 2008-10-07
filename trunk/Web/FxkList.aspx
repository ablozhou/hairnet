<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="FxkList.aspx.cs" Inherits="Web.FxkList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContentPosition" runat="server">
<!-- 主体部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="fxk-logo"><a href="#"><img src="Theme/Images/fxk-logo.gif" border="0" /></a></div>
	<table width="78%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="15%" align="left"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="85%" align="left"><img src="Theme/Images/fxk-12.gif" /></td>
      </tr>
    </table>
	<div class="lanmu-l"></div>
	<table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-15.gif" width="9" height="9" /></td>
        <td width="77%" align="left" class="black12-b"><a href="#">按发型</a></td>
      </tr>
      <tr>
        <td align="center">&nbsp;</td>
        <td align="left" class="lanmu-12">·<a href="#">长发</a><br />
          ·<a href="#">中发</a><br />
          ·<a href="#">短发</a><br />
          ·<a href="#">男发</a><br />
          ·<a href="#">盘发</a><br />
          ·<a href="#">卷发</a><br />
          ·<a href="#">直发</a></td>
      </tr>
    </table>
	<table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="77%" align="left" class="black12-b"><a href="#">按气质</a></td>
      </tr>
      <tr>
        <td align="center">&nbsp;</td>
        <td align="left" class="lanmu-12">·<a href="#">活泼可爱</a><br />
          ·<a href="#">前卫另类</a><br />
          ·<a href="#">高贵淑女</a></td>
      </tr>
    </table>
	<table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="77%" align="left" class="black12-b"><a href="#">按场合</a></td>
      </tr>
      <tr>
        <td align="center">&nbsp;</td>
        <td align="left" class="lanmu-12">·<a href="#">新娘</a><br />
          ·<a href="#">晚宴</a><br />
          ·<a href="#">工作</a><br />
          ·<a href="#">日常</a><br />
          ·<a href="#">运动</a></td>
      </tr>
    </table>
	<table width="78%" height="35" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="15%" align="left"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="85%" align="left"><img src="Theme/Images/fxk-16.gif" /></td>
      </tr>
    </table>
	<div class="lanmu-l"></div>
	<table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center">&nbsp;</td>
        <td width="77%" align="left" class="lanmu-12">·<a href="#">潮流风向标</a><br />
          ·<a href="#">明星发型秀</a><br />
          ·<a href="#">护理秘技</a><br />
          ·<a href="#">打理技巧</a><br />
          ·<a href="#">搭配1+1</a></td>
      </tr>
    </table>
	<table width="78%" height="35" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="15%" align="left"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="85%" align="left"><img src="Theme/Images/fxk-17.gif" /></td>
      </tr>
    </table>
	<div class="lanmu-l"></div>
	<table width="78%" height="35" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="15%" align="left"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="85%" align="left"><img src="Theme/Images/fxk-18.gif" /></td>
      </tr>
    </table>
	<div class="lanmu-l"></div>
  </div>
  <div id="main-r">
    <div id="dangqian">&nbsp;&nbsp;&nbsp;&nbsp;当前位置：<a href="#" target="_blank">精品网</a> > <a href="#">美发</a> > 发型图库</div>
	<div class="fxk-search">
	  <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="2%" align="center"><img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" /></td>
          <td width="4%" align="center"><img src="Theme/Images/fxk-list-01.gif" width="20" height="19" /></td>
          <td width="2%" align="center"><img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" /></td>
          <td width="4%" align="center"><img src="Theme/Images/fxk-list-02.gif" width="18" height="17" /></td>
		  <td width="2%" align="center"><img src="Theme/Images/fxk-list-06.gif" width="2" height="27" /></td>
          <td width="14%" align="center"><select>
            <option selected="selected">&nbsp;&nbsp;选择长度&nbsp;&nbsp;</option>
            <option>长</option>
            <option>中</option>
            <option>短</option>
          </select></td>
          <td width="4%" align="center"><img src="Theme/Images/fxk-list-03.gif" width="20" height="19" /></td>
          <td width="15%" align="center"><select name="select">
            <option selected="selected">&nbsp;&nbsp;选择脸型&nbsp;&nbsp;</option>
            <option>瓜子脸</option>
            <option>蛋型脸</option>
            <option>长脸</option>
            <option>圆脸</option>
            <option>方脸</option>
                              </select></td>
          <td width="3%" align="center"><img src="Theme/Images/fxk-list-03.gif" width="20" height="19" /></td>
          <td width="17%" align="center"><input name="textfield" type="text" size="15" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';"/></td>
          <td width="3%" align="center"><img src="Theme/Images/fxk-list-03.gif" width="20" height="19" /></td>
          <td width="2%" align="center"><img src="Theme/Images/fxk-list-06.gif" width="2" height="27" /></td>
          <td width="10%" align="center" class="gray12-d"><a href="#" target="_blank">按时间排序</a></td>
          <td width="3%" align="center"><img src="Theme/Images/fxk-list-04.gif" width="10" height="18" /></td>
          <td width="2%" align="center"><img src="Theme/Images/fxk-list-06.gif" width="2" height="27" /></td>
          <td width="9%" align="center" class="gray12-d"><a href="#" target="_blank">按人气排序</a></td>
          <td width="4%" align="center"><img src="Theme/Images/fxk-list-05.gif" width="10" height="18" /></td>
        </tr>
      </table>
	</div>
	<div class="clear"></div>
	<table width="95%" border="0" align="center" cellpadding="0" cellspacing="10">
  <tr>
    <td width="20%" valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
&nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
<span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td width="20%" valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
&nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
<span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
  &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
  <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
  &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
  <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls11.gif" alt="图片说明" /></a><br />
  &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
  <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
  </tr>
  <tr>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls11.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
  </tr>
  <tr>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
  </tr>
  <tr>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
  </tr>
  
  <tr>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/fxk-temp01.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
    <td valign="top" class="fxk-list"><a href="#" target="_blank"><img src="Theme/Images/star_temp2.gif" alt="图片说明" /></a><br />
      &nbsp;<span class="black12"><a href="#" target="_blank">性感清纯双面卷发</a></span><br />
      <span class="bianhao"><a href="#" target="_blank">20080930006</a></span></td>
  </tr>
</table>

	<div class="clear"></div>
    <div class="page-all"><a href="#">第一页</a>  <a href="#">上一页</a>  <a href="#">1</a> <span class="red12">2</span> <a href="#">3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a>  &nbsp;<a href="#">下一页</a>&nbsp;&nbsp;<a href="#">最后一页</a>&nbsp;&nbsp;共8页</div>
  </div>
  <div class="clear"></div>
  <div><img src="Theme/Images/fxk-11b.gif" /></div>
</div>
<!-- 主体部分结束 -->

</asp:Content>


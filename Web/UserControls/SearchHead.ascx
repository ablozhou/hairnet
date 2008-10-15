<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHead.ascx.cs" Inherits="Web.UserControls.SearchHead" %>
<!--搜美发厅开始 -->
<div id="main-top"><table width="960" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="84%" height="32" align="left" valign="bottom"><table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/images/tab3_2.gif" id="seatchTab2" style="display:none;">
      <tr>
        <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table><table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/images/tab3_3.gif" id="seatchTab3" style="display:none;">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
    <table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/images/tab3_1.gif" id="seatchTab1">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="133" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table></td>
    <td width="16%" align="left" valign="bottom">&nbsp;</td>
  </tr>
</table>

<table width="930" border="0" align="center" cellpadding="0" cellspacing="0" id="serTabC1">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="Theme/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <form method=post action=# target=_blank>
                      <td width="19%" class="gray-search"><select name="select" style="border:0px 0px 0px 0px;">
                        <option selected="selected">选&nbsp;择&nbsp;城&nbsp;区</option>
                        <option>东城区</option>
                        <option>朝阳区</option>
                        <option>西城区</option>
                      </select></td>
                      <td width="17%" class="gray-search"><select name="select2">
                        <option selected="selected">选&nbsp;择&nbsp;商&nbsp;圈</option>
                        <option>某商圈1</option>
                        <option>某商圈2</option>
                        <option>某商圈3</option>
                        </select></td>
                      <td width="17%" class="gray-search">
					  <select name="select3">
                        <option selected="selected">主&nbsp;打&nbsp;品&nbsp;牌</option>
                        <option>不限</option>
                        <option>欧莱雅</option>
                        <option>威娜</option>
                        <option>施华蔻</option>
                        </select></td>
                      <td width="17%" class="right-line"><select name="select3">
                        <option>营&nbsp;业&nbsp;面&nbsp;积</option>
                        <option>200平米</option>
                        <option>400平米</option>

                                                                                                                                                          </select></td>
					  <td width="17%"><input name="textfield" type="text" class="search-input" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                </td>
  </tr>
</table>
<table width="930" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC2" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="Theme/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <form method=post action=# target=_blank>
                        <td width="20%" class="gray-search"><select name="select4">
                          <option>选择头发长度</option>
                          <option>长</option>
                          <option>中</option>
                          <option>短</option>
                          <option>卷</option>
                          <option>直</option>
                        </select></td>
                        <td width="16%" class="gray-search"><span class="right-line">
                          <select name="select5">
                            <option>选择脸型</option>
                            <option>瓜子脸</option>
                            <option>蛋型脸</option>
                            <option>长脸</option>
                            <option>圆脸</option>
                            <option>方脸</option>
                          </select>
                        </span></td>
                        <td width="17%" class="gray-search"><span class="right-line">
                          <select name="select6">
                            <option selected="selected">按气质搜索</option>
                            <option>某某某气质</option>
                            <option>某某某气质2</option>
                            <option>某某某气质3</option>
                        </select>
                        </span></td>
                        <td width="17%" class="right-line"><select name="select7">
                          <option selected="selected">按场合搜索</option>
                          <option>场合一</option>
                          <option>场合二</option>
                          <option>场合三</option>
                                                                        </select></td>
                        <td width="17%"><input name="textfield" type="text" class="search-input" value="输入关键字" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
      </td>
  </tr>
</table>
<table width="930" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC3" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="Theme/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <form method=post action=# target=_blank>
                        <td width="20%" align="center" class="gray12-c">按剪发价格搜索:</td>
                        <td width="18%" class="gray-search"><select name="select2">
                          <option selected="selected">&nbsp;&nbsp;不&nbsp;&nbsp;限&nbsp;&nbsp;</option>
                          <option>1000元以上</option>
                          <option>800-1000</option>
                          <option>600-800</option>
                          <option>400-600</option>
                          <option>200-400</option>
                          <option>100-200</option>
                          <option>100元以下</option>
                        </select></td>
                      <td width="14%" align="center" class="gray12-c">按星座搜索:</td>
                      <td width="18%" class="right-line"><select name="select3">
                        <option selected="selected">&nbsp;&nbsp;不&nbsp;&nbsp;限&nbsp;&nbsp;</option>
						<option>白 羊 座</option>
                        <option>金 牛 座 </option>
                        <option>双 子 座</option>
                        <option>巨 蟹 座 </option>
                        <option>狮 子 座 </option>
                        <option>处 女 座</option>
                        <option>天 秤 座 </option>
                        <option>天 蝎 座 </option>
                        <option>射 手 座 </option>
                        <option>摩 羯 座</option>
                        <option>水 瓶 座</option>
                        <option>双 鱼 座 </option>

                            </select></td>
					  <td width="17%"><input name="textfield" type="text" class="search-input" value="输入发型师姓名" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
      </td>
  </tr>
</table>
<table width="920" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a>&nbsp;|&nbsp;托尼盖&nbsp;|&nbsp;洗发水&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;</div></td>
                  </tr>
  </table>					
</div>
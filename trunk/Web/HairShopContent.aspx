<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopContent.aspx.cs" Inherits="Web.HairShopContent" %>
<%@ Register Src="UserControls/HairShopEntryControl.ascx" TagName="HairShopEntryControl" TagPrefix="HN" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--搜美发厅开始 -->
<div id="main-top"><table width="960" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="84%" height="32" align="left" valign="bottom"><table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab3_2.gif" id="seatchTab2" style="display:none;">
      <tr>
        <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table><table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab3_3.gif" id="seatchTab3" style="display:none;">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
    <table width="400" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab3_1.gif" id="seatchTab1">
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
                  <td width="1%" align="left" class="search-bg"><img src="Theme/Images/sg-meifa_11.gif" width="5" height="25" /></td>
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
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a>&nbsp;|&nbsp;托尼盖&nbsp;|&nbsp;洗发水&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;</div></td>
                  </tr>
            </table></td>
  </tr>
</table>
<table width="930" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC2" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="Theme/Images/sg-meifa_11.gif" width="5" height="25" /></td>
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
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a>&nbsp;|&nbsp;托尼盖&nbsp;|&nbsp;洗发水&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;</div></td>
                  </tr>
            </table></td>
  </tr>
</table>
<table width="930" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC3" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="Theme/Images/sg-meifa_11.gif" width="5" height="25" /></td>
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
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a>&nbsp;|&nbsp;托尼盖&nbsp;|&nbsp;洗发水&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;</div></td>
                  </tr>
            </table></td>
  </tr>
</table>					
</div>
<!--搜美发厅结束 -->
<HN:HairShopEntryControl ID="hairShopEntryControl" runat="server" />
<script language="javascript">
        function showTab(id) {
        var c=["serTabC1","serTabC2","serTabC3"];
        var x=["seatchTab1","seatchTab2","seatchTab3"];
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
        </script>
        <script language="javascript">
        function showTab3(id) {
        var c=["serTabC31","serTabC32","serTabC33"];
        var x=["seatchTab31","seatchTab32","seatchTab33"];
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
<!--主体内容部分开始 -->
<div id="main">
  <div id="main-l">
      <div id="mft-area"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="5%" align="center" valign="middle"><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_2.gif" id="Table1" style="display:none;">
      <tr>
        <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>
    
    
    <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_3.gif" id="Table2" style="display:none;">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>    
    <img src="Theme/Images/sg-meifa_02.gif" /></td>
    <td width="15%" align="left" valign="middle" class="red14b">影博莎美发厅</td>
    <td width="22%" align="left" valign="middle"><img src="Theme/Images/fair-mft28.gif" width="52" height="24" /></td>
    <td width="58%" align="right" valign="top"><table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-1.gif" id="seatchTab31" >
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>
        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-2.gif" id="seatchTab32" style="display:none">
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>
        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table>
<table width="402" height="26" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/mft-tab-3.gif" id="seatchTab33" style="display:none">
      <tr>
        <td width="153" onclick="showTab3(1);" style="cursor:hand;">&nbsp;</td>
        <td width="124" onclick="showTab3(2);" style="cursor:hand;">&nbsp;</td>
        <td width="125" onclick="showTab3(3);" style="cursor:hand;">&nbsp;</td>
      </tr>
    </table></td>
    </tr>
</table>
        <table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px" id="serTabC31">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水<br />
                  红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香恋恋红尘冲好评元法国香<br />
                  料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精<br />
                品纯正香水恋恋红尘冲好评元/ML法国香</td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC32">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;22222恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水<br />
                  红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香恋恋红尘冲好评元法国香<br />
                  料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精<br />
                品纯正香水恋恋红尘冲好评元/ML法国香</td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
		<table width="98%" border="0" align="center" cellpadding="0" cellspacing="15" style="margin-top:5px;display:none" id="serTabC33">
          <tr>
            <td width="19%" align="left" valign="top"><div class="pic-4"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" /></a></div></td>
            <td width="81%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;3333恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水<br />
                  红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香恋恋红尘冲好评元法国香<br />
                  料精品纯正香水恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评元/ML法国香料精<br />
                品纯正香水恋恋红尘冲好评元/ML法国香</td>
              </tr>
              <tr>
                <td height="30" align="right"><img src="Theme/Images/fair-mft25.gif" />&nbsp;<img src="Theme/Images/fair-mft26.gif" />&nbsp;<img src="Theme/Images/fair-mft27.gif" /></td>
              </tr>
            </table></td>
          </tr>
        </table>
      </div>
	  <div class="null-box"></div>
	  
      <div id="mfs-tj">
        <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft04-a.gif">
          <tr>
            <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;发型师推荐</td>
            <td width="12%" align="left" valign="middle"><img src="Theme/Images/fair-mft16.gif" alt="发型师推荐" /></td>
            <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
            <td width="10%" align="left" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
          </tr>
      </table>
	  <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
              <tr>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">此区块可随意扩充图片行数
                    <br />
                    </a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
        </tr>
              <tr>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                        <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                          剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                        <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                          剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                        <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                          剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                        <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                          剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                        <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                          剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
              </tr>
              
      </table>
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="Theme/Images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
	  <div class="null-box"></div>
      <div id="jczp"><table width="93%" height="30" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td width="93%" align="left" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/fair-mft18.gif" alt="近期精彩作品" /></a></td>
      <td width="7%" align="right"><a href="#" target="_blank"></a></td>
    </tr>
  </table>

  <table width="96%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
          <tr>
            <td width="3%" align="center" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br />
            <br /></td>
            <td width="94%"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">付 军<br />影博沙西直门店</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军<br />影博沙西直门店</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军<br />影博沙西直门店</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军<br />影博沙西直门店</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军<br />影博沙西直门店</a></div></td>
              </tr>
            </table>
</td>
            <td width="3%" align="center" valign="middle"><img src="Theme/Images/sg-meifa_r.gif" width="9" height="33" /><br />
              <br />
</td>
          </tr>
      </table></div>
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
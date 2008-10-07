<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="Index.aspx.cs" Inherits="Web.Index" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!-- 大标福开始 -->
<div id="top-flash"><img src="Theme/Images/flash.jpg" /></div>
<!-- 大标福结束 -->

<div id="main">
  <div class="main-m">
    <div class="clear"></div>	
	<!--主体部分开始 -->
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


    <script type="text/javascript">
    function ChangeBackPic(id,name)
    {
      document.getElementById(id).className=name;
    }
    </script>
	
	<div id="main-3">
	  <div id="main-3-l">
	    <div id="s-mft"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="84%" height="32" align="left" valign="bottom"><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_2.gif" id="seatchTab2" style="display:none;">
      <tr>
        <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_3.gif" id="seatchTab3" style="display:none;">
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>
    <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_1.gif" id="seatchTab1" >
      <tr>
        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="133" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
        <td width="123">&nbsp;</td>
      </tr>
    </table></td>
    <td width="16%" align="left" valign="bottom">&nbsp;</td>
  </tr>
</table>

<table width="670" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC1">
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a><br />
                    &nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> </div></td>
                  </tr>
            </table></td>
  </tr>
</table>
<table width="670" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC2" style="display:none">
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a><br />
                    &nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> </div></td>
                  </tr>
            </table></td>
  </tr>
</table>
<table width="670" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC3" style="display:none">
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a><br />
                    &nbsp;<a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> </div></td>
                  </tr>
            </table></td>
  </tr>
</table>					
 </div>
<div id="rmfx-bg">
  <table width="93%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td width="93%" align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-02.gif" alt="本周热门发型" width="108" height="29" border="0" /></a></td>
      <td width="7%" align="right"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
    </tr>
  </table>

  <table width="96%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
          <tr>
            <td width="3%" align="left" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br /><br /></td>
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
            <td width="3%" align="right" valign="middle"><img src="Theme/Images/sg-meifa_r.gif" width="9" height="33" /><br /><br />
</td>
          </tr>
      </table>
 
  
  
</div>

	    <div id="mxfx-bg">
	      <table width="93%" height="31" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="93%" align="left" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-03.gif" alt="明星发型" width="89" height="27" /></a></td>
              <td width="7%" align="right" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
            </tr>
          </table>
	      <table width="93%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
  <tr>
    <td width="33%">·<a href="#" target="_blank">阿sa蔡卓妍最新发型</a> </td>
    <td width="33%">·<a href="#" target="_blank">阿sa蔡卓妍最新发型</a> </td>
    <td width="33%">·<a href="#" target="_blank">阿sa蔡卓妍最新发型</a> </td>
  </tr>
  <tr>
    <td>·<a href="#" target="_blank">韩国明星发型-柳真短发</a></td>
    <td>·<a href="#" target="_blank">韩国明星发型-柳真短发</a></td>
    <td>·<a href="#" target="_blank">韩国明星发型-柳真短发</a></td>
  </tr>
  <tr>
    <td>·<a href="#" target="_blank">明星发型-谢霆锋短发造型</a> </td>
    <td>·<a href="#" target="_blank">明星发型-谢霆锋短发造型</a> </td>
    <td>·<a href="#" target="_blank">明星发型-谢霆锋短发造型</a> </td>
  </tr>
  <tr>
    <td>·<a href="#" target="_blank">韩国最新新娘发型</a> </td>
    <td>·<a href="#" target="_blank">韩国最新新娘发型</a> </td>
    <td>·<a href="#" target="_blank">韩国最新新娘发型</a> </td>
  </tr>
  <tr>
    <td>·<a href="#" target="_blank">明星发型-桂纶镁最新发型</a> </td>
    <td>·<a href="#" target="_blank">明星发型-桂纶镁最新发型</a> </td>
    <td>·<a href="#" target="_blank">明星发型-桂纶镁最新发型</a> </td>
  </tr>
</table>
</div>
	    <script language="javascript">
            var num=8; //总共有几个小窗口
            var stopTime=100000000; //停留时间
            var curNum=1;
            var ii=0;
            function getObj(objName){return(document.getElementById(objName));}
            function showPage(id){
	            getObj('container').innerHTML=getObj("page"+id).innerHTML;
	            for(var i=1;i<=num;i++){
		            if(i==id) getObj("box"+i).className="overbtn";
		            else getObj("box"+i).className="outbtn";
	            }
	            clearTimeout(timer1);
	            timer1=setTimeout(autoTurn,stopTime);
            }
            function autoTurn(){
            if(ii<4){
	            ii++;
	            showPage(curNum++);
	            if(curNum>num) curNum=1;
            }
            }
            timer1=setTimeout(autoTurn);
            </script>
        <div id="city-ss">
          <table width="701" height="32" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td width="87" align="center"><div id="box1" onclick="showPage(1)">&nbsp;&nbsp;<font color="#cc0000">街头时尚</font></div></td>
              <td width="89" align="center"><div id="box2" onclick="showPage(2)">北京</div></td>
              <td width="89" align="center"><div id="box3" onclick="showPage(3)">上海</div></td>
              <td width="87" align="center"><div id="box4" onclick="showPage(4)">东京</div></td>
              <td width="86" align="center"><div id="box5" onclick="showPage(5)">巴黎</div></td>
              <td width="90" align="center"><div id="box6" onclick="showPage(6)">纽约</div></td>
              <td width="84" align="center"><div id="box7" onclick="showPage(7)">米兰</div></td>
              <td width="89" align="center"><div id="box8" onclick="showPage(8)">伦敦</div></td>
            </tr>
          </table>
<div id="container"></div>		  
	<div id="page1">	    
		  <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table>
</div>
	<div id="page2">	    
		  <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范222</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table>
</div>
<div id="page3"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范333</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>	
<div id="page4"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范444</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>
<div id="page5"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范555</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>
<div id="page6"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范666</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>
<div id="page7"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范777</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>
<div id="page8"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范888</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">范冰冰</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">范冰冰</a></div></td>
            </tr>
          </table></div>	  
		  
		  
        </div>
	  </div>
	  <div id="main-3-m"><img src="Theme/Images/fair-05.gif" width="8" height="32" /></div>
	  <div id="main-3-r">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td align="center"><img src="Theme/Images/fair-04.gif" /></td>
          </tr>
        </table>
	    <table width="260" height="32" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/Images/fair-09.gif">
          <tr>
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;优惠信息</a></td>
            <td width="46%" align="left" ><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
          </tr>
        </table>
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td class="main-3-rbg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td width="36%" height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
                       <td width="64%" align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">超模新男友曝光</a></span><br />
                  两个星期前，两个星期后她恋上了另一个男...<span class="red12"><a href="#" target="_blank">[全文]</a></span></td>
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
              </table>
              <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="30" align="left" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">活动公告</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
              </table>

			  <div class="list">
			  <ul><li>·&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></li><li>·&nbsp;<a href="#" target="_blank">林向海：鹤舞天池艾琳多</a></li><li>·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></li><li>·&nbsp;<a href="#" target="_blank">琳多南：令人惊诧打翻的</a></li></ul></div>
			  
              <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
                <tr>
                  <td align="center" valign="top" bgcolor="#f7f7f7"><img src="Theme/Images/fair-06.gif" /></td>
                </tr>
              </table></td>
          </tr>
        </table>
	    
			 <div class="diy">此处显示  class "diy" 的内容</div>
			 <div class="clear"></div>
	  </div>
	  <div class="clear"></div>
	</div>
	<!--主体部分结束 -->
	<!--广告开始 -->
	<div class="tl-ad"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa-ad.jpg" /></a></div>
	<!--广告结束 -->
	<!--发广场开始 -->
	<div id="fair-gc">
	  <div id="fair-gc-1"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="60" align="left" valign="top"><img src="Theme/Images/fair-14.gif" alt="发广场" width="185" height="50" /></td>
  </tr>
</table>
        <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left"><img src="Theme/Images/fair-11.gif" alt="发型师推荐" width="118" height="25" /></td>
          </tr>
          <tr>
            <td align="center" class="gray12-b"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" />&nbsp;今日十大流行发型</td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
          </tr>
          <tr>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-2">
	    <table width="88%" height="60" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left" valign="top"><img src="Theme/Images/fair-10.gif" alt="本周名剪排行" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="5"></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾琳</a></td>
          </tr>
          <tr>
            <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾琳</a></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-3"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td align="left"><img src="Theme/Images/fair-12.gif" alt="美发厅推荐" width="125" height="22" /></td>
  </tr>
  <tr>
    <td align="center" class="gray12-b"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" />&nbsp;今日十大流行发型</td>
  </tr>
</table>
        <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
          </tr>
          <tr>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-4">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;美发厅关注排行榜&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
		   <tr>
                 <td height="40" colspan="2" align="left" valign="bottom">&nbsp;&nbsp;<span class="red12"><a href="#" target="_blank">[评测]</a></span> <span class="gray12-lp">十款明星最爱眼部护理</span></td>
          </tr>
        </table>
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
	  
	  <div class="clear"></div>
	</div>
	<!--发广场结束 -->
	<!--发圈子开始 -->
	<div id="fair-circle">
	  <div id="circle-l">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="60" align="left" valign="top"><img src="Theme/Images/fair-18.gif" alt="美发圈" width="187" height="49" /></td>
          </tr>
        </table>
	    <table width="88%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-22.gif" alt="论坛热帖" width="128" height="17" border="0" /></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="160" height="16" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="38%" valign="bottom"><table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
              <tr>
                <td width="50%" height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
              </tr>
              <tr>
                <td height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
              </tr>
            </table></td>
            <td width="62%" valign="top"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td height="5"></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">【美发达人】</a><a href="#" target="_blank">令人惊诧艾</a></td>
              </tr>
              
            </table></td>
          </tr>
        </table>
		
	    <table width="88%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-23.gif" alt="专家推荐" width="141" height="21" border="0" /></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="160" height="16" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="5"></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">【黑楠】</a><a href="#" target="_blank">令人惊诧艾令人惊诧艾令人惊诧艾诧艾艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">【黑楠】</a><a href="#" target="_blank">令人惊诧艾令人惊诧艾令人惊诧艾诧艾艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">【黑楠】</a><a href="#" target="_blank">令人惊诧艾令人惊诧艾令人惊诧艾诧艾艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">【黑楠】</a><a href="#" target="_blank">令人惊诧艾令人惊诧艾令人惊诧艾诧艾艾</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">【黑楠】</a><a href="#" target="_blank">令人惊诧艾令人惊诧艾令人惊诧艾诧艾艾</a></td>
          </tr>
        </table>
	    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:20px">
          <tr>
            <td width="54%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="33%" align="center" valign="middle"><img src="Theme/Images/fair-32.gif" width="45" height="45" /></td>
                <td width="67%" align="left" class="red12-c">你找到自己感兴趣
                  的美发圈子了吗?</td>
              </tr>
              <tr>
                <td height="45" colspan="2" align="center" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-33.gif" width="70" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#" target="_blank"><img src="Theme/Images/fair-34.gif" width="70" height="19" border="0" /></a></td>
                </tr>
            </table></td>
            <td width="46%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="20%" align="right"><img src="Theme/Images/sg-meifa_02b.gif" width="5" height="9" /></td>
                <td width="50%" align="center" class="red14b">圈子推荐</td>
                <td width="30%" align="left"><img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" /></td>
              </tr>
              <tr>
                <td colspan="3" align="center" class="gray14"><a href="#" target="_blank">【大人圈】</a><a href="#" target="_blank">【秀发圈】</a><br />
                  <a href="#" target="_blank">【大人圈】</a><a href="#" target="_blank">【秀发圈】</a></td>
              </tr>
            </table></td>
          </tr>
        </table>
	    <div class="clear"></div>
	  </div>
	  <div id="circle-m">
	    <table width="88%" height="35" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-24.gif" alt="产品评测" width="150" height="28" border="0" /></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="150" height="16" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="63%" valign="top"><table width="88%" border="0" align="left" cellpadding="0" cellspacing="0">
              <tr>
                <td height="5"></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
              </tr>
              <tr>
                <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
              </tr>
            </table></td>
            <td width="37%" align="center"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="50%" height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
              </tr>
              <tr>
                <td height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
              </tr>
            </table></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" height="40" align="center" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-25.gif" alt="问吧" width="117" height="24" border="0" /></a></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="180" height="16" /></td>
          </tr>
          <tr>
            <td colspan="2" align="center" valign="middle" background="Theme/Images/fair-27.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="35" colspan="2" align="center" valign="middle"><input name="textfield2" type="text" size="40" style="border:#d3d3d3 1px solid;height:18px;"/></td>
                </tr>
              <tr>
                <td width="50%" height="25" align="center" valign="middle"><img src="Theme/Images/fair-28.gif" width="85" height="19" /></td>
                <td width="50%" align="center" valign="middle"><img src="Theme/Images/fair-29.gif" width="84" height="19" /></td>
              </tr>
              <tr>
                <td height="25" colspan="2" align="center" valign="middle" bgcolor="#FFFFFF"><img src="Theme/Images/fair-30.gif" width="292" height="1" /></td>
                </tr>
            </table></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;最新问题</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">· <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a><br />
            · <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;高分问题</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">· <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a><br />
· <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;最新回答</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">· <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a><br />
· <a href="#" target="_blank">什么颜色适合你什么颜色适合你什么颜色适合你？</a></td>
          </tr>
        </table>
	    <div class="clear"></div>
	  </div>
	  <div id="circle-r">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;最好用产品&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
          <tr>
            <td height="40" colspan="2" align="left" valign="bottom">&nbsp;&nbsp;<span class="red12"><a href="#" target="_blank">[评测]</a></span> <span class="gray12-lp">十款明星最爱眼部护理</span></td>
          </tr>
        </table>
		<table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td align="center"><img src="Theme/Images/fair-21.gif" width="182" height="12" /></td>
          </tr>
        </table>
		<table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;">
        <tr>
          <td width="46%" align="left" valign="middle" class="liangpin-pic"><a href="#"><img src="Theme/Images/meirong-08_20.gif" border="0" /></a></td>
          <td width="54%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">谜尚MISSHA魅惑素</a></td>
            </tr>
            <tr>
              <td width="31%" align="left" class="red12-line"><a href="#">很好</a></td>
              <td width="33%" align="left" class="gray12-lp">238票</td>
              <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
            </tr>
            <tr>
              <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
              <td align="left" class="gray12-lp">156票</td>
              <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
            </tr>
            <tr>
              <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
              <td align="left" class="gray12-lp">50票</td>
              <td align="left"><img src="Theme/Images/meirong-08_ls03.gif" width="10" height="2" /></td>
            </tr>
          </table></td>
        </tr>
      </table>
             <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;">
               <tr>
                 <td width="46%" align="left" valign="middle" class="liangpin-pic"><a href="#"><img src="Theme/Images/meirong-08_20.gif" border="0" /></a></td>
                 <td width="54%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">谜尚MISSHA魅惑素</a></td>
                     </tr>
                     <tr>
                       <td width="31%" align="left" class="red12-line"><a href="#">很好</a></td>
                       <td width="33%" align="left" class="gray12-lp">238票</td>
                       <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
                       <td align="left" class="gray12-lp">156票</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
                       <td align="left" class="gray12-lp">50票</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls03.gif" width="10" height="2" /></td>
                     </tr>
                 </table></td>
               </tr>
             </table>
             <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;">
               <tr>
                 <td width="46%" align="left" valign="middle" class="liangpin-pic"><a href="#"><img src="Theme/Images/meirong-08_20.gif" border="0" /></a></td>
                 <td width="54%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">谜尚MISSHA魅惑素</a></td>
                     </tr>
                     <tr>
                       <td width="31%" align="left" class="red12-line"><a href="#">很好</a></td>
                       <td width="33%" align="left" class="gray12-lp">238票</td>
                       <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
                       <td align="left" class="gray12-lp">156票</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
                       <td align="left" class="gray12-lp">50票</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls03.gif" width="10" height="2" /></td>
                     </tr>
                 </table></td>
               </tr>
             </table>
	         <table width="100%" height="20" border="0" cellpadding="0" cellspacing="0">
               <tr>
                 <td align="center" valign="bottom"><img src="Theme/Images/fair-21b.gif" width="182" height="12" /></td>
               </tr>
             </table>
	         <table width="100%" border="0" cellspacing="0" cellpadding="0">
               <tr>
                 <td align="left" class="red14b">&nbsp;&nbsp;美发教主&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
               </tr>
               <tr>
                 <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
               </tr>
             </table>
			 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td width="36%" height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
                       <td width="64%" align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">超模新男友曝光</a></span><br />
                  两个星期前，两个星期后她恋上了另一个男...<span class="red12"><a href="#" target="_blank">[全文]</a></span></td>
                     </tr>
                     <tr>
                       <td height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
                       <td align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">超模新男友曝光</a></span><br />
                       两个星期前，两个星期后她恋上了另一个男...<span class="red12"><a href="#" target="_blank">[全文]</a></span></td>
                     </tr>
                     <tr>
                       <td height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="图片说明" /></a></div></td>
                       <td align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">超模新男友曝光</a></span><br />
                       两个星期前，两个星期后她恋上了另一个男...<span class="red12"><a href="#" target="_blank">[全文]</a></span></td>
                     </tr>
        </table>
	  </div>
	  <div class="clear"></div>
	</div>	
	<!--发圈子结束 -->
	<div id="showhair">
    <table width="95%" height="30" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="7%" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;我要秀</td>
        <td width="9%" align="left" valign="bottom"><img src="Theme/Images/fair-31.gif" /></td>
        <td width="76%" align="left" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_upload.gif" /></a></td>
        <td width="8%" align="right" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
      </tr>
    </table>
    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="3%" align="left" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br />
</td>
            <td width="94%"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" id="serTabC21">
              <tr>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">标题标题</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">标题标题</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">标题标题</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">标题标题</a></div></td>
              </tr>
            </table>
			</td>
            <td width="3%" align="right" valign="middle"><img src="Theme/Images/sg-meifa_r.gif" width="9" height="33" /><br />
</td>
          </tr>
    </table>
  </div>
  </div>
</div>
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairEngineerContent.aspx.cs" Inherits="Web.HairEngineerContent" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="BodyContentPosition">

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
function mfdtab(id) {
var c=["Tab1","Tab2"];
var x=["txtTab1","txtTab2"];
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
function phbtab(id) {
var c=["ptab1","ptab2"];
var x=["ptxttab1","ptxttab2"];
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
<table width="980" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#F9F9F9">
  <tr>
    <td width="707" align="right" valign="top"><table width="703" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><div id="main-3-l">
          <div id="s-mft">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="84%" height="32" align="left" valign="bottom"><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_2_mfs.gif" id="seatchTab2" style="display:none;">
                    <tr>
                      <td width="133" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
                      <td width="141" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
                      <td width="126" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
                      <td width="123">&nbsp;</td>
                    </tr>
                  </table>
                    <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_3_mfs.gif" id="seatchTab3" style="display:none;">
                      <tr>
                        <td width="141" onclick="showTab(1);" style="cursor:hand;">&nbsp;</td>
                        <td width="115" onclick="showTab(2);" style="cursor:hand;">&nbsp;</td>
                        <td width="144" onclick="showTab(3);" style="cursor:hand;">&nbsp;</td>
                        <td width="123">&nbsp;</td>
                      </tr>
                    </table>
                  <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/tab1_1_mfs.gif" id="seatchTab1" >
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
                            <form method="post" action="#" target="_blank">
                              <td width="10%" class="gray-search"><select name="select" style="border:0px 0px 0px 0px;">
                                  <option selected="selected">沙龙名称</option>
                                  <option>沙龙名称</option>
                                  <option>沙龙名称</option>
                                  <option>沙龙名称</option>
                              </select></td>
                              <td width="10%" class="gray-search"><select name="select2">
                                  <option selected="selected">城区</option>
                                  <option>某商圈1</option>
                                  <option>某商圈2</option>
                                  <option>某商圈3</option>
                              </select></td>
                              <td width="10%" class="gray-search"><select name="select8">
                                  <option selected="selected">地区</option>
                                  <option>某商圈1</option>
                                  <option>某商圈2</option>
                                  <option>某商圈3</option>
                              </select></td>
                              <td width="10%" class="gray-search"><select name="select3">
                                  <option selected="selected">商圈</option>
                                  <option>不限</option>
                                  <option>欧莱雅</option>
                                  <option>威娜</option>
                                  <option>施华蔻</option>
                              </select></td>
                              <td width="10%" class="right-line"><select name="select3">
                                  <option>美发类别</option>
                                  <option>200平米</option>
                                  <option>400平米</option>
                              </select></td>
                              <td width="10%" class="right-line"><span class="gray-search">
                                <select name="select9">
                                  <option selected="selected">价格</option>
                                  <option>不限</option>
                                  <option>欧莱雅</option>
                                  <option>威娜</option>
                                  <option>施华蔻</option>
                                </select>
                              </span></td>
                              <td width="15%"><input name="textfield" type="text" class="search-input" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                            </form>
                            <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                            <td width="10%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
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
                            <form method="post" action="#" target="_blank">
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
                              <td width="17%"><input name="textfield" type="text" class="search-input" value="输入关键字" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                            </form>
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
                            <form method="post" action="#" target="_blank">
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
                              <td width="17%"><input name="textfield" type="text" class="search-input" value="输入发型师姓名" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                            </form>
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
          <div id="mfd-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td colspan="2">&nbsp;</td>
              </tr>
              <tr>
                <td width="58%" align="center"><div class="pic-8"><a href="#" target="_blank"><img src="Theme/Images/fair-mfd_01.gif" width="376" height="246" border="0" /></a></div></td>
                <td width="42%" align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="5%" align="left"><img src="Theme/Images/fair-mfd_02.gif" width="7" height="11" /></td>
                      <td width="60%" align="left" valign="top" class="red14b">沈楠</td>
                      <td width="35%" align="left" valign="top" class="red14b">崇尚美发店</td>
                    </tr>
                  </table>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="227" height="24" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft03_b.gif" id="Tab1">
                            <tr>
                              <td width="50%" align="center"  class="gray12-d" onclick="mfdtab(1);" style="cursor:hand;">简介</td>
                              <td width="50%" align="center"  class="gray12-d" onclick="mfdtab(2);" style="cursor:hand;">详细介绍</td>
                            </tr>
                          </table>
                            <table width="227" height="24" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft03_c.gif" id="Tab2" style="display:none;">
                              <tr>
                                <td width="50%" align="center" class="gray12-d" onclick="mfdtab(1);" style="cursor:hand;">简介</td>
                                <td width="50%" align="center" class="gray12-d" onclick="mfdtab(2);" style="cursor:hand;">详细介绍</td>
                              </tr>
                          </table></td>
                      </tr>
                      <tr>
                        <td><table width="95%" height="200" border="0" cellpadding="0" cellspacing="0" class="table01" id="txttab1">
                            <tr>
                              <td valign="top"><table width="100%" height="10" border="0" cellpadding="0" cellspacing="0">
                                  <tr>
                                    <td></td>
                                  </tr>
                                </table>
                                  <table width="100%" border="0" cellspacing="2" cellpadding="0">
                                    <tr>
                                      <td align="center" class="red12-c">[工作简历]</td>
                                      <td align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td align="center" class="red12-c">[工作简历]</td>
                                      <td align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td align="center" class="red12-c">[工作简历]</td>
                                      <td align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td align="center" class="red12-c">[工作简历]</td>
                                      <td align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td align="center" class="red12-c">[工作简历]</td>
                                      <td align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td width="30%" align="center" class="red12-c">[工作简历]</td>
                                      <td width="70%" align="left" class="gray12-d">总监建立建立</td>
                                    </tr>
                                    <tr>
                                      <td colspan="2"><img src="Theme/Images/fair-mfd_07.gif" width="279" height="5" /></td>
                                    </tr>
                                    <tr>
                                      <td height="5" colspan="2"></td>
                                    </tr>
                                  </table>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                      <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_04.gif" width="69" height="21" border="0" /></a></td>
                                      <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_05.gif" width="69" height="21" border="0" /></a></td>
                                      <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_06.gif" width="69" height="21" border="0" /></a></td>
                                    </tr>
                                </table></td>
                            </tr>
                          </table>
                            <table width="95%" height="200" border="0" cellpadding="0" cellspacing="0" class="table01" id="txttab2" style="display:none;">
                              <tr>
                                <td valign="top"><table width="100%" height="10" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                      <td></td>
                                    </tr>
                                  </table>
                                    <table width="100%" height="160" border="0" cellpadding="0" cellspacing="0">
                                      <tr>
                                        <td colspan="2" align="center" valign="top" class="gray12-d"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                              <td align="left">&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" target="_blank">总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立总监建立建立....</a></td>
                                            </tr>
                                        </table></td>
                                      </tr>
                                      <tr>
                                        <td colspan="2"><img src="Theme/Images/fair-mfd_07.gif" width="279" height="5" /></td>
                                      </tr>
                                      <tr>
                                        <td height="5" colspan="2"></td>
                                      </tr>
                                    </table>
                                  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                      <tr>
                                        <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_04.gif" width="69" height="21" border="0" /></a></td>
                                        <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_05.gif" width="69" height="21" border="0" /></a></td>
                                        <td align="center"><a href="#"><img src="Theme/Images/fair-mfd_06.gif" width="69" height="21" border="0" /></a></td>
                                      </tr>
                                  </table></td>
                              </tr>
                          </table></td>
                      </tr>
                  </table></td>
              </tr>
              <tr>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
          </div>
          <div id="mfspj-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="center" valign="top"><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;">
                    <tr>
                      <td height="30" colspan="3" align="left" valign="middle" class="liangpin-pic"><a href="#"></a></td>
                    </tr>
                    <tr>
                      <td width="34%" align="left" valign="middle" class="liangpin-pic"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="21%" align="left" class="red12-line"><a href="#">很好</a></td>
                            <td width="23%" align="left" class="gray12-lp">238票</td>
                            <td width="56%" align="left"><table width="90%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff0033">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
                            <td align="left" class="gray12-lp">156票</td>
                            <td align="left"><table width="60%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff9900">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
                            <td align="left" class="gray12-lp">50票</td>
                            <td align="left"><table width="30%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#999999">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                      </table></td>
                      <td width="37%" align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="21%" align="left" class="red12-line"><a href="#">很好</a></td>
                            <td width="23%" align="left" class="gray12-lp">238票</td>
                            <td width="56%" align="left"><table width="90%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff0033">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
                            <td align="left" class="gray12-lp">156票</td>
                            <td align="left"><table width="60%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff9900">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
                            <td align="left" class="gray12-lp">50票</td>
                            <td align="left"><table width="30%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#999999">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                      </table></td>
                      <td width="29%" align="left"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="21%" align="left" class="red12-line"><a href="#">很好</a></td>
                            <td width="23%" align="left" class="gray12-lp">238票</td>
                            <td width="56%" align="left"><table width="90%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff0033">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">普通</a></td>
                            <td align="left" class="gray12-lp">156票</td>
                            <td align="left"><table width="60%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff9900">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td align="left" class="red12-line"><a href="#" target="_blank">较差</a></td>
                            <td align="left" class="gray12-lp">50票</td>
                            <td align="left"><table width="30%" height="2" border="0" cellpadding="0" cellspacing="0" bgcolor="#999999">
                                <tr>
                                  <td></td>
                                </tr>
                            </table></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
            </table>
          </div>
          <div id="rmfx-bg">
            <table width="93%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="93%" height="29" align="left" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/fair-mfd_09.gif" alt="近期精彩作品" border="0" /></a></td>
                <td width="7%" align="right" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
              </tr>
            </table>
            <table width="100%" height="5" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td></td>
              </tr>
            </table>
            <table width="96%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
              <tr>
                <td width="3%" align="left" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br />
                    <br /></td>
                <td width="94%"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="20%" align="center" valign="top"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                          <table width="70%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td align="left" class="gray12-d">齐刘海发型</td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发量]</a></span> <span class="gray12-lp">多</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发质]</a></span> <span class="gray12-lp">好</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[脸型]</a></span> <span class="gray12-lp">瓜子</span></td>
                            </tr>
                        </table></td>
                      <td width="20%" align="center" valign="top"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                          <table width="70%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td align="left" class="gray12-d">发型名称</td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发量]</a></span> <span class="gray12-lp">多</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发质]</a></span> <span class="gray12-lp">好</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[脸型]</a></span> <span class="gray12-lp">瓜子</span></td>
                            </tr>
                        </table></td>
                      <td width="20%" align="center" valign="top"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                          <table width="70%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td align="left" class="gray12-d">发型名称</td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发量]</a></span> <span class="gray12-lp">多</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发质]</a></span> <span class="gray12-lp">好</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[脸型]</a></span> <span class="gray12-lp">瓜子</span></td>
                            </tr>
                        </table></td>
                      <td width="20%" align="center" valign="top"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                          <table width="70%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td align="left" class="gray12-d">发型名称</td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发量]</a></span> <span class="gray12-lp">多</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发质]</a></span> <span class="gray12-lp">好</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[脸型]</a></span> <span class="gray12-lp">瓜子</span></td>
                            </tr>
                        </table></td>
                      <td width="20%" align="center" valign="top"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="图片说明" /></a></div>
                          <table width="70%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td align="left" class="gray12-d">发型名称</td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发量]</a></span> <span class="gray12-lp">多</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[发质]</a></span> <span class="gray12-lp">好</span></td>
                            </tr>
                            <tr>
                              <td align="left"><span class="red12"><a href="#" target="_blank">[脸型]</a></span> <span class="gray12-lp">瓜子</span></td>
                            </tr>
                        </table></td>
                    </tr>
                </table></td>
                <td width="3%" align="right" valign="middle"><img src="Theme/Images/sg-meifa_r.gif" width="9" height="33" /><br />
                    <br />
                </td>
              </tr>
            </table>
          </div>
          <div class="pinglun">
            <table width="704" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="3" bgcolor="#F7F7F7" ></td>
                <td width="10" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft06.gif" width="3" height="29" /></td>
                <td width="135" align="left" background="Theme/Images/fair-mft08.gif" class="red14b">看看大家的留言</td>
                <td width="472" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft09.gif" width="23" height="7" /></td>
                <td width="84" align="right" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft07.gif" width="3" height="29" /></td>
              </tr>
            </table>
            <table width="704" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF">
              <tr>
                <td width="3" bgcolor="#F7F7F7" ></td>
                <td width="5" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft10.gif" /></td>
                <td width="23" align="center" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/sg-meifa_02.gif" /></td>
                <td width="59" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c">我要留言</td>
                <td width="148" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">用户名:</td>
                <td width="147" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield2" type="text" class="pass" /></td>
                <td width="52" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">密　码:</td>
                <td width="160" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield22" type="text" class="pass" /></td>
                <td width="97" align="center" background="Theme/Images/fair-mft12.gif" class="gray12-c"><a href="#" target="_blank">注册</a> &nbsp;<a href="#" target="_blank">登陆</a></td>
                <td width="10" align="right" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft11.gif" /></td>
              </tr>
            </table>
            <div class="pinglun-box">
              <textarea name="textarea" cols="" rows="" class="pl-box"></textarea>
            </div>
            <table width="100%" height="30" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF">
              <tr>
                <td align="right"><a href="#" target="_blank"><img src="Theme/Images/fair-submit.gif" border="0" /></a>&nbsp;&nbsp;</td>
              </tr>
            </table>
            <div class="message-1">
              <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
              <div class="mes-content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
              <div class="mes-content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
              <div class="mes-content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
        </div></td>
      </tr>
    </table></td>
    <td width="10">&nbsp;</td>
    <td width="263" align="left" valign="top"><table width="263" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><div id="main-3-r">
          <table width="263" height="402" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/fair-phb_bg.gif">
            <tr>
              <td align="center" valign="top"><table width="100%" height="45" border="0" cellpadding="0" cellspacing="0">
                  <tr>
                    <td width="10">&nbsp;</td>
                    <td width="227"><table width="227" height="25" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/sg-meifa_phb01.gif" id="ptab1">
                        <tr>
                          <td width="50%" align="center" class="gray12-d" onclick="phbtab(1);" style="cursor:hand;">发型师关注度排行</td>
                          <td width="50%" align="center" class="gray12-d" onclick="phbtab(2);" style="cursor:hand;">优惠券下载排行榜</td>
                        </tr>
                      </table>
                        <table width="227" height="25" border="0" cellpadding="0" cellspacing="0" background="Theme/Images/sg-meifa_phb02.gif" id="ptab2" style="display:none;">
                          <tr>
                            <td width="50%" align="center" class="gray12-d" onclick="phbtab(1);" style="cursor:hand;">发型师关注度排行</td>
                            <td width="50%" align="center" class="gray12-d" onclick="phbtab(2);" style="cursor:hand;">优惠券下载排行榜</td>
                          </tr>
                      </table></td>
                    <td width="26">&nbsp;</td>
                  </tr>
                </table>
                  <table width="90%" border="0" cellspacing="0" cellpadding="0" id="ptxttab1">
                    <tr>
                      <td width="12%" align="center" valign="bottom"><img src="Theme/Images/fair-phb_01.gif" width="15" height="11" /></td>
                      <td width="33%" align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td width="55%" align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td align="center" valign="bottom"><img src="Theme/Images/fair-phb_02.gif" width="15" height="11" /></td>
                      <td align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td align="center" valign="bottom"><img src="Theme/Images/fair-phb_03.gif" width="15" height="11" /></td>
                      <td align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="left"><table width="90%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="12%" align="center"><img src="Theme/Images/fair-phb_04.gif" width="15" height="11" /></td>
                            <td width="88%" align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
                          </tr>
                          <tr>
                            <td align="center"><img src="Theme/Images/fair-phb_05.gif" width="15" height="11" /></td>
                            <td align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
                          </tr>
                          <tr>
                            <td align="center"><img src="Theme/Images/fair-phb_06.gif" width="15" height="11" /></td>
                            <td align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向</a></td>
                          </tr>
                      </table></td>
                    </tr>
                  </table>
                <table width="90%" border="0" cellspacing="0" cellpadding="0" id="ptxttab2" style="display:none;">
                    <tr>
                      <td width="12%" align="center" valign="bottom"><img src="Theme/Images/fair-phb_01.gif" width="15" height="11" /></td>
                      <td width="33%" align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td width="55%" align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足i<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td align="center" valign="bottom"><img src="Theme/Images/fair-phb_02.gif" width="15" height="11" /></td>
                      <td align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足i<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td align="center" valign="bottom"><img src="Theme/Images/fair-phb_03.gif" width="15" height="11" /></td>
                      <td align="center" valign="bottom"><div class="pic-10"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a></div></td>
                      <td align="left" valign="bottom" class="gray12-d"><a href="#" target="_blank">玩味十足i<br />
                        变换刘海人人眼前一亮</a></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="center"><img src="Theme/Images/fair-phb_08.gif" width="233" height="4" /></td>
                    </tr>
                    <tr>
                      <td height="20" colspan="3" align="left"><table width="90%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="12%" align="center"><img src="Theme/Images/fair-phb_04.gif" width="15" height="11" /></td>
                            <td width="88%" align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向mmm</a></td>
                          </tr>
                          <tr>
                            <td align="center"><img src="Theme/Images/fair-phb_05.gif" width="15" height="11" /></td>
                            <td align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向bbb</a></td>
                          </tr>
                          <tr>
                            <td align="center"><img src="Theme/Images/fair-phb_06.gif" width="15" height="11" /></td>
                            <td align="left" class="gray14-e">&nbsp;<a href="#" target="_blank">翻的五味瓶用心体吉林向iii</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
            </tr>
          </table>
          <div class="clear"></div>
        </div></td>
      </tr>
    </table>
      <table width="263" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><div id="who-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td><table width="100%" height="35" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="10%">&nbsp;</td>
                      <td width="60%" align="left" class="red14b">谁浏览过这个页面？</td>
                      <td width="30%" align="center"><a href="#" target="_blank"><img src="Theme/Images/fair-who_01.gif" width="66" height="20" border="0" /></a></td>
                    </tr>
                  </table>
                    <table width="95%" border="0" cellspacing="0" cellpadding="0">
                      <tr> </tr>
                      <tr>
                        <td colspan="3" align="right" class="gray12">已有<span class="red12">56</span>人浏览过页面</td>
                      </tr>
                      <tr>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                      </tr>
                  </table></td>
              </tr>
            </table>
            <table width="100%" height="10" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td></td>
              </tr>
            </table>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td><table width="100%" height="35" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="10%">&nbsp;</td>
                      <td width="60%" align="left" class="red14b">谁想让他设计发型？</td>
                      <td width="30%" align="center"><a href="#" target="_blank"><img src="Theme/Images/fair-who_02.gif" width="66" height="20" border="0" /></a></td>
                    </tr>
                  </table>
                    <table width="95%" border="0" cellspacing="0" cellpadding="0">
                      <tr> </tr>
                      <tr>
                        <td colspan="3" align="right" class="gray12">已有<span class="red12">56</span>人想让他做头发</td>
                      </tr>
                      <tr>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/fair-phb_07.gif" width="65" height="64" border="0" /></a><br />
                          </div>
                            <span class="gray12-c"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                      </tr>
                  </table></td>
              </tr>
            </table>
          </div></td>
        </tr>
      </table>
      <table width="263" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><div id="gz-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="center" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="10%" height="50">&nbsp;</td>
                      <td width="90%" align="left" class="red14b">你还可以关注他们</td>
                    </tr>
                  </table>
                    <table width="90%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                  </table></td>
              </tr>
            </table>
          </div></td>
        </tr>
      </table>
      <table width="263" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><div id="ts-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="center" valign="top"><table width="100%" height="48" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="10%">&nbsp;</td>
                      <td width="70%" align="left" class="red14b">他的同事</td>
                      <td width="20%" align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
                    </tr>
                  </table>
                    <table width="90%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td align="center"><div class="pic-6"><a href="#" target="_blank"><img src="Theme/Images/fair-fxtj_02.gif" border="0" /></a></div>
                            <span class="gray12-b"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-6"><a href="#" target="_blank"><img src="Theme/Images/fair-fxtj_02.gif" border="0" /></a></div>
                            <span class="gray12-b"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                      </tr>
                      <tr>
                        <td align="center"><div class="pic-6"><a href="#" target="_blank"><img src="Theme/Images/fair-fxtj_02.gif" border="0" /></a></div>
                            <span class="gray12-b"><a href="#" target="_blank">沈楠沈楠</a></span></td>
                        <td align="center"><div class="pic-6"><a href="#" target="_blank"><img src="Theme/Images/fair-fxtj_02.gif" border="0" /></a></div>
                            <span class="gray12-b"><a href="#" target="_blank">沈楠沈楠</a></span> </td>
                      </tr>
                  </table></td>
              </tr>
            </table>
          </div></td>
        </tr>
      </table>
      <table width="263" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><div id="hkg-bg">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="center"><table width="100%" height="45" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="10%">&nbsp;</td>
                      <td width="70%" align="left" class="red14b">浏览此发型师的网友还看过</td>
                      <td width="20%" align="left"><a href="#" target="_blank"></a></td>
                    </tr>
                  </table>
                    <table width="90%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                      <tr>
                        <td><img src="Theme/Images/fair-gz_01.gif" width="241" height="5" /></td>
                      </tr>
                      <tr>
                        <td align="left">&nbsp;<a href="#" target="_blank" class="gray12-c">张三 发型设计师型设计师</a></td>
                      </tr>
                  </table></td>
              </tr>
            </table>
          </div></td>
        </tr>
      </table></td>
  </tr>
</table>
</asp:Content>

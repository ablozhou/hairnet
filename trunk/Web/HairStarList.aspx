<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairStarList.aspx.cs" Inherits="Web.HairStarList" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!-- 主体部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="fxk-logo"><a href="#"><img src="Theme/Images/fxk-logo.gif" border="0" /></a></div>
	<table width="80%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
    <td width="77%" align="left"><img src="Theme/Images/fxk-12.gif" /></td>
  </tr>
</table>
    <div class="lanmu-l"></div>
    <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="24%" align="center"><img src="Theme/Images/fxk-15.gif" width="9" height="9" /></td>
        <td width="76%" align="left" class="black12-b"><a href="#">按发型</a></td>
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
        <td width="24%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="76%" align="left" class="black12-b"><a href="#">按气质</a></td>
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
        <td width="24%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="76%" align="left" class="black12-b"><a href="#">按场合</a></td>
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
	<table width="80%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="77%" align="left"><img src="Theme/Images/fxk-16.gif" /></td>
      </tr>
    </table>
	<div class="lanmu-l"></div>
    <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="24%" align="center">&nbsp;</td>
        <td width="76%" align="left" class="lanmu-12">·<a href="#">潮流风向标</a><br />
          ·<a href="#">明星发型秀</a><br />
          ·<a href="#">护理秘技</a><br />
          ·<a href="#">打理技巧</a><br />
          ·<a href="#">搭配1+1</a></td>
      </tr>
    </table>
    <table width="80%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="77%" align="left"><img src="Theme/Images/fxk-17.gif" /></td>
      </tr>
    </table>
    <div class="lanmu-l"></div>
    <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="24%" align="center">&nbsp;</td>
        <td width="76%" align="left" class="lanmu-12">·<a href="#">明星新发型</a><br />
          ·<a href="#">百变星搭配</a><br />
          ·<a href="#">生活明星发</a><br />
        ·<a href="#">“发”现偶像剧</a></td>
      </tr>
    </table>
    <table width="80%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="23%" align="center"><img src="Theme/Images/fxk-13.gif" /></td>
        <td width="77%" align="left"><img src="Theme/Images/fxk-18.gif" /></td>
      </tr>
    </table>
    <div class="lanmu-l"></div>
    <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="24%" align="center">&nbsp;</td>
        <td width="76%" align="left" class="lanmu-12">·<a href="#">北京街头</a><br />
          ·<a href="#">上海街头</a><br />
          ·<a href="#">东京街头</a><br />
          ·<a href="#">巴黎街头</a><br />
        ·<a href="#">纽约街头</a><br />
        ·<a href="#">米兰街头</a><br />
        ·<a href="#">伦敦街头</a></td>
      </tr>
    </table>
  </div>
  <div id="main-r">
    <div id="dangqian">&nbsp;&nbsp;&nbsp;&nbsp;当前位置：<a href="#" target="_blank">精品网</a> > <a href="#">美发</a> > 发型图库</div>
    <div class="star_content">
    <table width="800 " height="27" border="0" align="right" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" height="27">&nbsp;</td>
    <td width="168" align="left"><input name="textfield" type="text" class="search-input" value="输入关键词" onclick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
    <td width="47" align="left"><a href="#"><img src="Theme/Images/star_search_button.gif" width="20" height="19" /></a></td>
    <td width="44"><a href="#"><img src="Theme/Images/star_malebutton.gif" width="33" height="19" /></a></td>
    <td width="524"><a href="#"><img src="Theme/Images/star_femalebutton.gif" width="34" height="19" /></a></td>
  </tr>
</table>
    </div> 
	<div class="clear"></div>
	<div class="nullarea"></div>	
    <div class="clear"></div>
    <table width="806" height="400" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="top"><table width="805" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="155" height="50" align="left" valign="bottom" background="Theme/Images/star_02.gif"><img src="Theme/Images/star_01.gif" width="154" height="50" /></td>
        <td width="619" align="right" background="Theme/Images/star_02.gif"><table width="10%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
          </tr>
        </table>          <a href="#" target="_blank"></a></td>
        <td width="32" background="Theme/Images/star_03.gif">&nbsp;</td>
      </tr>
      <tr>
        <td height="388" colspan="3" valign="top" background="Theme/Images/star_04_bg.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3%">&nbsp;</td>
            <td width="97%">&nbsp;</td>
          </tr>
          <tr>
            <td height="259">&nbsp;</td>
            <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="281" height="259" align="left" valign="top"><a href="#"></a>
                  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td><a href="#"><img src="Theme/Images/star_temp1.jpg" width="276" height="332" class="pic_border_glay" /></a></td>
                    </tr>
                    <tr>
                      <td height="20"><div align="center"><a href="#" class="red12">性感清纯双面卷发</a></div></td>
                    </tr>
                  </table></td>
                <td width="280" valign="top"><table width="48%" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                  <tr>
                    <td width="9%" height="154">&nbsp;</td>
                    <td width="91%" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                  </tr>
                  <tr>
                    <td height="22">&nbsp;</td>
                    <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                  </tr>
                </table>
                  <table width="48%" height="176" border="0" cellpadding="0" cellspacing="0">
                  <tr>
                    <td width="9%" height="154">&nbsp;</td>
                    <td width="91%" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                  </tr>
                  <tr>
                    <td height="22">&nbsp;</td>
                    <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                  </tr>
                </table>
                  <table width="48%" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="9%" height="154">&nbsp;</td>
                      <td width="91%" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                    </tr>
                    <tr>
                      <td height="22">&nbsp;</td>
                      <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                    </tr>
                  </table>
                  <table width="48%" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="9%" height="154">&nbsp;</td>
                      <td width="91%" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                    </tr>
                    <tr>
                      <td height="22">&nbsp;</td>
                      <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                    </tr>
                  </table></td>
                <td width="220" align="left" valign="top"><table width="100%" height="355" border="0" align="left" cellpadding="0" cellspacing="0">
                  <tr>
                    <td height="24" align="left"><span class="red14b">&nbsp;&nbsp;最热明星发型&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  </tr>
                  <tr>
                    <td height="12" ></td>
                  </tr>
                  <tr>
                    <td height="217" valign="top"><table width="86%" border="0" align="left" cellpadding="0" cellspacing="0">
                        <tr>
                          <td width="6%">&nbsp;</td>
                          <td width="94%" class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">艾琳多南：令人惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">吉林向海：鹤舞天池艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                        <tr>
                          <td>&nbsp;</td>
                          <td class="gray14-line">· <a href="#" target="_blank">打翻的五味瓶用惊诧艾</a></td>
                        </tr>
                    </table></td>
                  </tr>
                </table></td>
              </tr>

            </table></td>
          </tr>
        </table></td>
        </tr>
    </table>
      <table width="805" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="155" height="50" align="left" valign="bottom" background="Theme/Images/star_02.gif"><img src="Theme/Images/star_05.gif" width="154" height="50" /></td>
          <td width="619" align="right" background="Theme/Images/star_02.gif"><table width="10%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
              </tr>
            </table>
            <a href="#" target="_blank"></a></td>
          <td width="32" background="Theme/Images/star_03.gif">&nbsp;</td>
        </tr>
        <tr>
          <td height="388" colspan="3" valign="top" background="Theme/Images/star_04_bg.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="3%">&nbsp;</td>
                <td width="97%">&nbsp;</td>
              </tr>
              <tr>
                <td height="259">&nbsp;</td>
                <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="485" height="259" align="left" valign="top"><a href="#"></a>
                        <table width="156" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td><a href="#"><img src="Theme/Images/temp-03.jpg" width="154" height="334" class="pic_border_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="20"><div align="center"><a href="#" class="red12">性感清纯双面卷发</a></div></td>
                          </tr>
                        </table>
                        <table width="156" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="3" rowspan="2">&nbsp;</td>
                            <td><a href="#"><img src="Theme/Images/temp-03.jpg" width="154" height="334" class="pic_border_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="20"><div align="center"><a href="#" class="red12">性感清纯双面卷发</a></div></td>
                          </tr>
                        </table>
                        <table width="156" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="3" rowspan="2">&nbsp;</td>
                            <td><a href="#"><img src="Theme/Images/temp-03.jpg" width="154" height="334" class="pic_border_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="20"><div align="center"><a href="#" class="red12">性感清纯双面卷发</a></div></td>
                          </tr>
                        </table>
                        </td>
                      <td width="296" valign="top"><table width="133" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                        <tr>
                          <td width="10" height="154">&nbsp;</td>
                          <td width="123" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                        </tr>
                        <tr>
                          <td height="22">&nbsp;</td>
                          <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                        </tr>
                      </table>
                        <table width="133" height="176" border="0" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="10" height="154">&nbsp;</td>
                            <td width="123" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="22">&nbsp;</td>
                            <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                          </tr>
                        </table>
                        <table width="133" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="10" height="154">&nbsp;</td>
                            <td width="123" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="22">&nbsp;</td>
                            <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                          </tr>
                        </table>
                        <table width="133" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="10" height="154">&nbsp;</td>
                            <td width="123" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                          </tr>
                          <tr>
                            <td height="22">&nbsp;</td>
                            <td align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                          </tr>
                        </table></td>
                      </tr>
                </table></td>
              </tr>
          </table></td>
        </tr>
      </table>
      <table width="805" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="155" height="50" align="left" valign="bottom" background="Theme/Images/star_02.gif"><img src="Theme/Images/star_06.gif" width="154" height="50" /></td>
          <td width="619" align="right" background="Theme/Images/star_02.gif"><table width="10%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
              </tr>
            </table>
            <a href="#" target="_blank"></a></td>
          <td width="32" background="Theme/Images/star_03.gif">&nbsp;</td>
        </tr>
        <tr>
          <td height="388" colspan="3" valign="top" background="Theme/Images/star_04_bg.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="3%">&nbsp;</td>
                <td width="97%">&nbsp;</td>
              </tr>
              <tr>
                <td height="259">&nbsp;</td>
                <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="592" height="317" valign="top"><table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                        <tr>
                          <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                          <td width="31" align="center" valign="top">&nbsp;</td>
                        </tr>
                        <tr>
                          <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                          <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                        </tr>
                      </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                        <tr>
                          <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                          <td width="31" align="center" valign="top">&nbsp;</td>
                        </tr>
                        <tr>
                          <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                          <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                        </tr>
                      </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                        <table width="154" height="176" border="0" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table></td>
                    </tr>
                </table></td>
              </tr>
          </table></td>
        </tr>
      </table>
      <table width="805" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="155" height="50" align="left" valign="bottom" background="Theme/Images/star_02.gif"><img src="Theme/Images/star_07.gif" width="182" height="50" /></td>
          <td width="619" align="right" background="Theme/Images/star_02.gif"><table width="10%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
              </tr>
            </table>
            <a href="#" target="_blank"></a></td>
          <td width="32" background="Theme/Images/star_03.gif">&nbsp;</td>
        </tr>
        <tr>
          <td height="388" colspan="3" valign="top" background="Theme/Images/star_04_bg.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="3%">&nbsp;</td>
                <td width="97%">&nbsp;</td>
              </tr>
              <tr>
                <td height="259">&nbsp;</td>
                <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="592" height="317" valign="top"><table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                          <tr>
                            <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                            <td width="31" align="center" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                            <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                          </tr>
                        </table>
                          <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" align="left" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                          </table>
                        <table width="154" height="176" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="123" height="154" align="center" valign="top"><a href="#"><img src="Theme/Images/star_temp2.gif" width="111" height="142" class="pic_padding_glay" /></a></td>
                              <td width="31" align="center" valign="top">&nbsp;</td>
                            </tr>
                            <tr>
                              <td height="22" align="center" valign="middle" class="gray12-d"><a href="#" class="gray12-c">性感清纯双面卷发</a></td>
                              <td align="center" valign="middle" class="gray12-d">&nbsp;</td>
                            </tr>
                        </table></td>
                    </tr>
                </table></td>
              </tr>
          </table></td>
        </tr>
      </table></td>
  </tr>
</table>
    <div class="clear"></div>
    
  </div>  
  <div class="clear"></div>
  <div><img src="Theme/Images/star_bg_di.gif" width="980" height="27" /></div>
</div>
<!-- 主体部分结束 -->
</asp:Content>

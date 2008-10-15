<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopList.aspx.cs" Inherits="Web.HairShopList" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--搜美发厅开始 -->
<div id="main-top">
 <table width="99%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="7%" align="left" background="images/sg-meifa_04.gif"><img src="images/search-mft.gif" /></td>
              <td width="92%" valign="top" background="images/sg-meifa_04.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:8px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="images/sg-meifa_11.gif" width="5" height="25" /></td>
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
                      <td width="5%" align="left"><img src="images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="98%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l"><a href="#" target="_blank">发型</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">发型设计</a>&nbsp;|&nbsp; <a href="#" target="_blank">流行发型</a>&nbsp;|&nbsp; <a href="#" target="_blank">新娘发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">非主流发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">短发发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">卷发发型</a>&nbsp;|&nbsp;烫发&nbsp;|&nbsp;<a href="#" target="_blank">直发发型</a>&nbsp;|&nbsp;托尼盖&nbsp;|&nbsp;洗发水&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a> <a href="#" target="_blank">染发护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">如何护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">春季护发</a>&nbsp;|&nbsp;<a href="#" target="_blank">沙宣</a>&nbsp;|&nbsp;<a href="#" target="_blank">托尼盖</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;|&nbsp;<a href="#" target="_blank">淑女发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">日系发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">通勤发型</a>&nbsp;|&nbsp;<a href="#" target="_blank">洗发水</a>&nbsp;</div></td>
                  </tr>
                </table></td>
              <td width="1%" align="right" background="images/sg-meifa_04.gif"><img src="images/sg-meifa_06.gif" width="8" height="117" /></td>
            </tr>
  </table>					
</div>
<!--搜美发厅结束 -->
<div id="main-top2"></div>
<!--主体内容部分开始 -->
<div id="main">
  <div id="main-l">
    <div id="mfs-tj">
      <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="images/fair-mft04-a.gif">
        <tr>
          <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;发型厅推荐</td>
          <td width="12%" align="left" valign="middle"><img src="images/mft_list_salon.gif" alt="发型师推荐" /></td>
          <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
          <td width="10%" align="left" valign="middle">&nbsp;</td>
        </tr>
      </table>
      <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
              <tr>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                    <a href="#" target="_blank">此区块可随意扩充图片行数
                    <br />
                    </a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="images/sg-meifa_ls10.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a><br />
                <a href="#" target="_blank">付 军&nbsp;&nbsp;设计总监
                    剪发价格&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
        </tr>
      </table>
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
      <div class="null-box"></div>
      <div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="images/fair-mft08.gif"><img src="images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="138" align="left" background="images/fair-mft08.gif">共找到 <span class="red12">213</span> 家美发厅</td>
            <td width="395" align="left" background="images/fair-mft08.gif"><img src="images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="153" align="left" background="images/fair-mft08.gif"><img src="images/fair-mft07.gif" width="3" height="7" />共 10 页 <a href="#" class="gray12-d">上一页</a> <a href="#" class="gray12-d">下一页</a></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="images/fair-mft12.gif"><img src="images/fair-mft10.gif" /></td>
            <td width="71" align="left" background="images/fair-mft12.gif" class="gray12-c">排序方式：</td>
            <td width="10" align="left" background="images/fair-mft12.gif" class="gray12-c"><img src="images/fair-mft11.gif" /></td>
            <td width="86" align="right" background="images/fair-mft12.gif" class="gray12-c"><div align="center">按时间排序</div></td>
            <td width="28" align="left" background="images/fair-mft12.gif"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
              </tr>
            </table></td>
            <td width="10" align="left" background="images/fair-mft12.gif"><img src="images/fair-mft11.gif" /></td>
            <td width="93" align="right" background="images/fair-mft12.gif" class="gray12-c"><div align="center">按时间排序</div></td>
            <td width="23" align="left" background="images/fair-mft12.gif" class="gray12-c"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
              </tr>
            </table></td>
            <td width="365" align="left" background="images/fair-mft12.gif"><img src="images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box"></div>
		<div class="message-2">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                  </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
        <div class="message-1">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
        <div class="message-2">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
        <div class="message-1">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
        <div class="message-2">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
        <div class="message-1">
		  <div class="clear">
		    <table width="98%" height="129" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td height="13" valign="top">&nbsp;</td>
                <td valign="top">&nbsp;</td>
              </tr>
              <tr>
                <td width="27">&nbsp;</td>
                <td width="100" height="104" valign="top"><a href="#"><img src="images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[姓名]</td>
                      <td width="27%" class="red12"><strong>赛特丹尼</strong></td>
                      <td width="8%">[价格]</td>
                      <td width="21%">2000元</td>
                      <td width="4%"><img src="images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">连锁店</a></td>
                      <td width="14%">折扣：<span class="red12">8折</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[地址]</td>
                      <td>北京市海淀区小西天28号</td>
                      <td>[电话]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[简介]</td>
                      <td colspan="6" valign="top">恋恋红尘冲好评元/ML法国香料精品纯正香水恋恋红尘冲好评恋恋红尘冲好评<br />
                        恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲好评恋恋红尘冲</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[好评]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">查 看</a> | <a href="#" style=" text-decoration:underline">我要评论</a></td>
                          </tr>
                      </table></td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
            </table>
		  </div>
		</div>
		<div class="page-all"><a href="#">第一页</a>  <a href="#">上一页</a>  <a href="#">1</a> <span class="red12">2</span> <a href="#">3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a>  &nbsp;<a href="#">下一页</a>&nbsp;&nbsp;<a href="#">最后一页</a>&nbsp;&nbsp;共8页</div>	
<div class="clear"></div>
      </div>
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
            <img src="images/sg-meifa_46.gif" width="256" height="2" /><br /><br />

</td>
          </tr>
          
      </table>
		<div id="container"></div>
	  <div id="page1">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="68" align="center"><img src="images/sg-08bbs_1.gif" /></td>
            <td width="85%" align="left"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a></div></td>
                  <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                      <span class="red12"><a href="#" target="_blank"></a></span></td>
                  <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">审美</a></span><br />
                      <span class="red12">推荐指数：4</span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td height="68" align="center"><img src="images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a></div></td>
                <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                    <span class="red12"><a href="#" target="_blank"></a></span></td>
                <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">审美</a></span><br />
                    <span class="red12">推荐指数：4</span></td>
              </tr>
            </table>              <a href="#" target="_blank"></a></td>
          </tr>
          <tr>
            <td height="68" align="center"><img src="images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="images/sg-meifa_ls01.gif" alt="图片说明" /></a></div></td>
                <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                    <span class="red12"><a href="#" target="_blank"></a></span></td>
                <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">审美</a></span><br />
                    <span class="red12">推荐指数：4</span></td>
              </tr>
            </table>              <a href="#" target="_blank"></a></td>
          </tr>
          <tr>
            <td align="center"><img src="images/sg-08bbs_4.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="images/sg-08bbs_5.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="images/sg-08bbs_6.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="center"><img src="images/sg-08bbs_7.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">翻的五味瓶用心体吉林向海</a></td>
          </tr>
          <tr>
            <td align="center"><img src="images/sg-08bbs_8.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">林向海：鹤舞天池艾琳多南</a></td>
          </tr>
        </table>
	  </div>
		<div id="page2">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr></tr>
          <tr>
            <td width="85%" align="left" class="gray14-e"><a href="#" target="_blank">·林向海22：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海22：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·翻的五味瓶用心体吉林向海</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">·林向海：鹤舞天池艾琳多南</a></td>
          </tr>
        </table>
	  </div>		
    </div> 	
    <div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;热门标签&nbsp;<img src="images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="images/sg-meifa_46.gif" width="256" height="2" /></td>
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
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;最热店评&nbsp;<img src="images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="images/sg-meifa_46.gif" width="256" height="2" /></td>
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
            <td height="28" align="left" class="red14b">&nbsp;&nbsp;网友推荐店&nbsp;<img src="images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td height="8"><img src="images/sg-meifa_46.gif" width="256" height="2" /></td>
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
	<div><img src="images/fair-mft15.gif" /></div>
</div>
<!--主体内容部分结束 -->
</asp:Content>

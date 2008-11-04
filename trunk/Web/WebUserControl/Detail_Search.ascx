<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Detail_Search.ascx.cs" Inherits="WebUserControl_Detail_Search" %>
<%@ OutputCache Duration="3600" VaryByParam="none" %>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
a:link {text-decoration: none;}
a:visited {text-decoration: none;}
a:hover {text-decoration: underline;}
a:active {text-decoration: none;}
/*搜索开始*/
#s-mft {background-image: url(http://hair.sg.com.cn/images/fair-01.gif);background-repeat: no-repeat;width:703px;height:164px;
margin:0 auto;}
#s-mft div {width:670px;margin:0 auto;clear:both;} 
.gray-search {font-size:14px;font-weight:bold;color:#666666;text-align:center;line-height:25px;}
.gray-search a:link,.gray-search a:visited {color:#666666;}
.gray-search a:hover {color:#cc0033;}

.search-input {font-size:12px;color:#666666;line-height:20px;width:100%;height:15px;text-align:center;}
.search-bg {background-image: url(http://hair.sg.com.cn/images/sg-meifa_12.gif);background-repeat: repeat-x;background-position: top;}
.search {font-size:14px;font-weight:bold;line-height:25px;color:#cc0033;text-align:center;}
.search a:link,.search a:visited,.search a:hover {color:#cc0033;}

.search-txt {border:#e5e5e5 1px solid;background-color:#f9f9f9;font-size:12px;color:#666666;line-height:24px;height:50px;text-align:left;padding:0px 15px 0px 15px;}
.search-txt a:link,.search-txt a:visited {color:#666666;}
.search-txt a:hover {line-height:16px;background-color:#FF0000;color:#FFFFFF;}

.gray12 {font-size:12px;line-height:28px;color:#666666;}
.gray12-c {font-size:12px;line-height:24px;color:#666666;}
.gray12-d {font-size:12px;line-height:22px;color:#666666;}
.gray12b {font-size:12px;line-height:20px;color:#666666;}
.gray14 {font-size:14px;line-height:26px;color:#666666;}
.gray12-d a:link,.gray12-d a:visited,.gray12-line a:link,.gray12-line a:visited,.gray12-c a:link,.gray12-c a:visited,.gray12 a:link,.gray12 a:visited,.gray12 a:link,.gray12 a:visited,.gray14 a:link,.gray14 a:visited,.gray12b a:link,.gray12b a:visited  {color:#666666;}
.gray12-d a:hover,.gray12-line a:hover,.gray12-c a:hover,.gray12 a:hover,.gray a:hover,.gray14 a:hover,.gray12b a:hover {color:#cc0033;text-decoration:underline;}

/*搜索结束*/
-->
</style>
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

function topage(xx)
{
    if(xx==1)
    {
        var DropDownList1 = document.getElementById("<%=area%>");//选 择 城 区                   
        var DropDownList1_Index = DropDownList1.selectedIndex;    
        var DropDownList1_Value = DropDownList1.options[DropDownList1_Index].value;

        var DropDownList2 = document.getElementById("<%=HotZone%>");//选 择 商 圈
        var DropDownList2_Index = DropDownList2.selectedIndex;                        
        var DropDownList2_Value = DropDownList2.options[DropDownList2_Index].value;   

        var DropDownList3 = document.getElementById("<%=Product%>");//主 打 品 牌
        var DropDownList3_Index = DropDownList3.selectedIndex;                        
        var DropDownList3_Value = DropDownList3.options[DropDownList3_Index].value;   

        var DropDownList4 = document.getElementById("<%=Square%>");//营 业 面 积
        var DropDownList4_Index = DropDownList4.selectedIndex;                        
        var DropDownList4_Value = DropDownList4.options[DropDownList4_Index].value;  

        var key = document.getElementById("txtName").value;//关键字
        if(key=="输入关键词")
        {
            key="";
        }

        var url= "/HairShopList.aspx?District="+escape(DropDownList1_Value)+"&buzizone="+escape(DropDownList2_Value)+"&product="+escape(DropDownList3_Value)+"&square"+escape(DropDownList4_Value)+"&keyword="+escape(key);
        window.open(url);
    }
    
        
    if(xx==2)
    {
        var DropDownList7 = document.getElementById("<%=HairStyle%>");//头发长度                    
        var DropDownList7_Index = DropDownList7.selectedIndex;    
        var DropDownList7_Value = DropDownList7.options[DropDownList7_Index].value;

        var DropDownList8 = document.getElementById("<%=FaceStyle%>");//选择脸型
        var DropDownList8_Index = DropDownList8.selectedIndex;                        
        var DropDownList8_Value = DropDownList8.options[DropDownList8_Index].value;   
        
        var DropDownList9 = document.getElementById("<%=Temperament%>");//头发气质                   
        var DropDownList9_Index = DropDownList9.selectedIndex;    
        var DropDownList9_Value = DropDownList9.options[DropDownList9_Index].value;

        var DropDownList0 = document.getElementById("<%=Occasion%>");//选择场合
        var DropDownList0_Index = DropDownList0.selectedIndex;                        
        var DropDownList0_Value = DropDownList0.options[DropDownList0_Index].value;  

        var key2 = document.getElementById("txtName2").value;//关键字
        
         if(key2=="输入关键词")
        {
            key2="";
        }

        var url2= "/List-FXK.aspx?HairStyle="+escape(DropDownList7_Value)+"&Temperament="+escape(DropDownList8_Value)+"&Occasion="+escape(DropDownList9_Value)+"&FaceStyle="+escape(DropDownList0_Value)+"&keyword="+escape(key2);
        window.open(url2);
    }
    
    if(xx==3)
    {
        var DropDownList5 = document.getElementById("<%=price%>");//选择价格                    
        var DropDownList5_Index = DropDownList5.selectedIndex;    
        var DropDownList5_Value = DropDownList5.options[DropDownList5_Index].value;

        //var DropDownList6 = document.getElementById("<%=star%>");//选择星座
        //var DropDownList6_Index = DropDownList6.selectedIndex;                        
        //var DropDownList6_Value = DropDownList6.options[DropDownList6_Index].value;   

        var key3 = document.getElementById("txtName3").value;//关键字
        
        if(key3=="输入发型师姓名")
        {
            key3="";
        }

        //var url3= "/HairEngineer_index.aspx?price="+escape(DropDownList5_Value)+"&area="+escape(DropDownList6_Value)+"&key="+escape(key3);
        var url3= "/HairEngineer_index.aspx?price="+escape(DropDownList5_Value)+"&key="+escape(key3);
        window.open(url3);
    }
}
</script>


<div id="s-mft"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="84%" height="32" align="left" valign="bottom"><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="/hair/images/tab1_2.gif" id="seatchTab2" style="display:none;">
      <tr>
        <td width="133" onClick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="141" onClick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onClick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table><table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="/hair/images/tab1_3.gif" id="seatchTab3" style="display:none;">
      <tr>
        <td width="141" onClick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="115" onClick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="144" onClick="showTab(3);" style="cursor:hand;">&nbsp;</td>
		<td width="123">&nbsp;</td>
      </tr>
    </table>
    <table width="523" height="32" border="0" cellpadding="0" cellspacing="0" background="/hair/images/tab1_1.gif" id="seatchTab1" >
      <tr>
        <td width="141" onClick="showTab(1);" style="cursor:hand;">&nbsp;</td>
        <td width="133" onClick="showTab(2);" style="cursor:hand;">&nbsp;</td>
        <td width="126" onClick="showTab(3);" style="cursor:hand;">&nbsp;</td>
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
                  <td width="1%" align="left" class="search-bg"><img src="/hair/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="19%" class="gray-search"><asp:DropDownList ID="ddlArea" runat="server">
                              <asp:ListItem Value="">选 择 城 区</asp:ListItem>
                          </asp:DropDownList></td>
                      <td width="17%" class="gray-search"><asp:DropDownList ID="ddlHotZone" runat="server">
                              <asp:ListItem Value="">选 择 商 圈</asp:ListItem>
                          </asp:DropDownList></td>
                      <td width="17%" class="gray-search">
					  <asp:DropDownList ID="ddlProduct" runat="server">
                              <asp:ListItem Value="">主 打 品 牌</asp:ListItem>
                              <asp:ListItem Value="0">不限</asp:ListItem>
                          </asp:DropDownList></td>
                      <td class="right-line" style="width: 2%"><asp:DropDownList ID="ddlSquare" Width="0px" runat="server" Visible="false">
                              <asp:ListItem Value="">营 业 面 积</asp:ListItem>
                              <asp:ListItem Value="0-20">0-20平米</asp:ListItem>
                              <asp:ListItem Value="20-50">20-50平米</asp:ListItem>
                              <asp:ListItem Value="50-100">50-100平米</asp:ListItem>
                              <asp:ListItem Value="100-200">100-200平米</asp:ListItem>
                              <asp:ListItem Value="200">200平米以上</asp:ListItem>
                          </asp:DropDownList></td>
					  <td width="17%"><input name="txtName" type="text" class="search-input" value="输入关键词" onClick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                      <td width="5%" align="left"><img src="/hair/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a onclick="topage(1)" style="cursor:hand">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="/hair/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
              <table width="670" height="62" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td valign="middle" class="search-txt">
                    <!--include virtual="/include/key_HairShop.htm" -->
                   </td>
                  </tr>
            </table>	
			  
              </td>
  </tr>
</table>
<table width="670" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC2" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="/hair/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td width="20%" class="gray-search"><asp:DropDownList ID="ddlHairStyle" runat="server">
                                <asp:ListItem Value="">选择头发长度</asp:ListItem>
                            </asp:DropDownList></td>
                        <td width="16%" class="gray-search"><span class="right-line">
                          <asp:DropDownList ID="ddlFaceStyle" runat="server">
                                <asp:ListItem Value="">选择脸型</asp:ListItem>
                            </asp:DropDownList>
                        </span></td>
                        <td width="17%" class="gray-search"><span class="right-line">
                         <asp:DropDownList ID="ddlTemperament" runat="server">
                                <asp:ListItem Value="">按气质搜索</asp:ListItem>
                            </asp:DropDownList>
                        </span></td>
                        <td width="17%" class="right-line"><asp:DropDownList ID="ddlOccasion" runat="server">
                                <asp:ListItem Value="">按场合搜索</asp:ListItem>
                            </asp:DropDownList></td>
                        <td width="17%"><input name="txtName2" type="text" class="search-input" value="输入关键词" onClick="javascript:if(this.value.substring(0,4)=='输入关键') this.value='';" /></td>
                      <td width="5%" align="left"><img src="/hair/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a onclick="topage(2)" style="cursor:hand">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="/hair/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  <table width="670" height="62" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td valign="middle" class="search-txt">
                    <!--include virtual="/include/key_tk.htm" -->
                   </td>
                  </tr>
            </table>	
              </td>
  </tr>
</table>
<table width="670" border="0" align="center" cellspacing="0" cellpadding="0" id="serTabC3" style="display:none">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:15px;margin-bottom:8px">
                <tr>
                  <td width="1%" align="left" class="search-bg"><img src="/hair/images/sg-meifa_11.gif" width="5" height="25" /></td>
                  <td width="98%" class="search-bg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td width="20%" align="center" class="gray12-c">按剪发价格搜索:</td>
                        <td width="18%" class="gray-search">
                            <asp:DropDownList ID="ddlPrice" runat="server">
                                <asp:ListItem Value="">&nbsp;&nbsp;不&nbsp;&nbsp;限&nbsp;&nbsp;</asp:ListItem>
                                <asp:ListItem Value="1000,0">1000元以上</asp:ListItem>
                                <asp:ListItem Value="800,1000">800-1000</asp:ListItem>
                                <asp:ListItem Value="600,800">600-800</asp:ListItem>
                                <asp:ListItem Value="400,600">400-600</asp:ListItem>
                                <asp:ListItem Value="200,400">200-400</asp:ListItem>
                                <asp:ListItem Value="100,200">100-200</asp:ListItem>
                                <asp:ListItem Value="0,100">100元以下</asp:ListItem>
                            </asp:DropDownList></td>
                            <!--
                      <td width="14%" align="center" class="gray12-c">按星座搜索:</td>
                      <td width="18%" class="right-line">
                          <asp:DropDownList ID="ddlStar" runat="server">
                              <asp:ListItem Value="">&nbsp;&nbsp;不&nbsp;&nbsp;限&nbsp;&nbsp;</asp:ListItem>
                              <asp:ListItem Value="白羊座">&nbsp;白 羊 座</asp:ListItem>
                              <asp:ListItem Value="金牛座">&nbsp;金 牛 座</asp:ListItem>
                              <asp:ListItem Value="双子座">&nbsp;双 子 座</asp:ListItem>
                              <asp:ListItem Value="巨蟹座">&nbsp;巨 蟹 座</asp:ListItem>
                              <asp:ListItem Value="狮子座">&nbsp;狮 子 座</asp:ListItem>
                              <asp:ListItem Value="处女座">&nbsp;处 女 座</asp:ListItem>
                              <asp:ListItem Value="天秤座">&nbsp;天 秤 座</asp:ListItem>
                              <asp:ListItem Value="天蝎座">&nbsp;天 蝎 座</asp:ListItem>
                              <asp:ListItem Value="射手座">&nbsp;射 手 座</asp:ListItem>
                              <asp:ListItem Value="摩羯座">&nbsp;摩 羯 座</asp:ListItem>
                              <asp:ListItem Value="水瓶座">&nbsp;水 瓶 座</asp:ListItem>
                              <asp:ListItem Value="双鱼座">&nbsp;双 鱼 座</asp:ListItem>
                          </asp:DropDownList></td>
                          -->
					  <td width="17%"><input name="txtName3" type="text" class="search-input" value="输入发型师姓名" onClick="javascript:if(this.value.substring(0,4)=='输入发型') this.value='';" /></td>
                      <td width="5%" align="left"><img src="/hair/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a onclick="topage(3)" style="cursor:hand">搜&nbsp;索</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="/hair/images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  <table width="670" height="62" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td valign="middle" class="search-txt">
                    <!--include virtual="/include/key_Eng.htm" -->
                   </td>
                  </tr>
            </table>	
              </td>
  </tr>
</table>					
 </div>
<script language="javascript">
var url="<%=pageUrl %>";
if(url == "HairShopList.aspx" || url=="HairShopContent.aspx")//搜美发厅
{
    document.getElementById("serTabC1").style.display="";
    document.getElementById("seatchTab1").style.display="";
    
    document.getElementById("serTabC2").style.display="none";
    document.getElementById("seatchTab2").style.display="none";
    
    document.getElementById("serTabC3").style.display="none";
    document.getElementById("seatchTab3").style.display="none";
}
else if(url=="List-FXK.aspx")
{
    document.getElementById("serTabC1").style.display="none";
    document.getElementById("seatchTab1").style.display="none";
    
    document.getElementById("serTabC2").style.display="";
    document.getElementById("seatchTab2").style.display="";
    
    document.getElementById("serTabC3").style.display="none";
    document.getElementById("seatchTab3").style.display="none";
}
else if(url=="HairEngineer_index.aspx" || url=="HairdresserLastPage.aspx")
{
    document.getElementById("serTabC1").style.display="none";
    document.getElementById("seatchTab1").style.display="none";
    
    document.getElementById("serTabC2").style.display="none";
    document.getElementById("seatchTab2").style.display="none";
    
    document.getElementById("serTabC3").style.display="";
    document.getElementById("seatchTab3").style.display="";
}
</script>
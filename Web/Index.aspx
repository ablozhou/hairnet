<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="Index.aspx.cs" Inherits="Web.Index" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!-- ��긣��ʼ -->
<div id="top-flash"><img src="Theme/Images/flash.jpg" /></div>
<!-- ��긣���� -->

<div id="main">
  <div class="main-m">
    <div class="clear"></div>	
	<!--���岿�ֿ�ʼ -->
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
                        <option selected="selected">ѡ&nbsp;��&nbsp;��&nbsp;��</option>
                        <option>������</option>
                        <option>������</option>
                        <option>������</option>
                      </select></td>
                      <td width="17%" class="gray-search"><select name="select2">
                        <option selected="selected">ѡ&nbsp;��&nbsp;��&nbsp;Ȧ</option>
                        <option>ĳ��Ȧ1</option>
                        <option>ĳ��Ȧ2</option>
                        <option>ĳ��Ȧ3</option>
                        </select></td>
                      <td width="17%" class="gray-search">
					  <select name="select3">
                        <option selected="selected">��&nbsp;��&nbsp;Ʒ&nbsp;��</option>
                        <option>����</option>
                        <option>ŷ����</option>
                        <option>����</option>
                        <option>ʩ��ޢ</option>
                        </select></td>
                      <td width="17%" class="right-line"><select name="select3">
                        <option>Ӫ&nbsp;ҵ&nbsp;��&nbsp;��</option>
                        <option>200ƽ��</option>
                        <option>400ƽ��</option>

                                                                                                                                                          </select></td>
					  <td width="17%"><input name="textfield" type="text" class="search-input" value="����ؼ���" onclick="javascript:if(this.value.substring(0,4)=='����ؼ�') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a><br />
                    &nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> </div></td>
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
                          <option>ѡ��ͷ������</option>
                          <option>��</option>
                          <option>��</option>
                          <option>��</option>
                          <option>��</option>
                          <option>ֱ</option>
                        </select></td>
                        <td width="16%" class="gray-search"><span class="right-line">
                          <select name="select5">
                            <option>ѡ������</option>
                            <option>������</option>
                            <option>������</option>
                            <option>����</option>
                            <option>Բ��</option>
                            <option>����</option>
                          </select>
                        </span></td>
                        <td width="17%" class="gray-search"><span class="right-line">
                          <select name="select6">
                            <option selected="selected">����������</option>
                            <option>ĳĳĳ����</option>
                            <option>ĳĳĳ����2</option>
                            <option>ĳĳĳ����3</option>
                                                                              </select>
                        </span></td>
                        <td width="17%" class="right-line"><select name="select7">
                          <option selected="selected">����������</option>
                          <option>����һ</option>
                          <option>���϶�</option>
                          <option>������</option>
                                                                        </select></td>
                        <td width="17%"><input name="textfield" type="text" class="search-input" value="����ؼ���" onclick="javascript:if(this.value.substring(0,4)=='����ؼ�') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a><br />
                    &nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> </div></td>
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
                        <td width="20%" align="center" class="gray12-c">�������۸�����:</td>
                        <td width="18%" class="gray-search"><select name="select2">
                          <option selected="selected">&nbsp;&nbsp;��&nbsp;&nbsp;��&nbsp;&nbsp;</option>
                          <option>1000Ԫ����</option>
                          <option>800-1000</option>
                          <option>600-800</option>
                          <option>400-600</option>
                          <option>200-400</option>
                          <option>100-200</option>
                          <option>100Ԫ����</option>
                        </select></td>
                      <td width="14%" align="center" class="gray12-c">����������:</td>
                      <td width="18%" class="right-line"><select name="select3">
                        <option selected="selected">&nbsp;&nbsp;��&nbsp;&nbsp;��&nbsp;&nbsp;</option>
						<option>�� �� ��</option>
                        <option>�� ţ �� </option>
                        <option>˫ �� ��</option>
                        <option>�� з �� </option>
                        <option>ʨ �� �� </option>
                        <option>�� Ů ��</option>
                        <option>�� �� �� </option>
                        <option>�� Ы �� </option>
                        <option>�� �� �� </option>
                        <option>Ħ �� ��</option>
                        <option>ˮ ƿ ��</option>
                        <option>˫ �� �� </option>

                            </select></td>
					  <td width="17%"><input name="textfield" type="text" class="search-input" value="���뷢��ʦ����" onclick="javascript:if(this.value.substring(0,4)=='����ؼ�') this.value='';" /></td></form>
                      <td width="5%" align="left"><img src="Theme/Images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
                    </tr>
                  </table></td>
                  <td width="1%" align="right" class="search-bg"><img src="Theme/Images/sg-meifa_14.gif" width="4" height="25" /></td>
                </tr>
              </table>
			  
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a><br />
                    &nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> </div></td>
                  </tr>
            </table></td>
  </tr>
</table>					
 </div>
<div id="rmfx-bg">
  <table width="93%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td width="93%" align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-02.gif" alt="�������ŷ���" width="108" height="29" border="0" /></a></td>
      <td width="7%" align="right"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
    </tr>
  </table>

  <table width="96%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
          <tr>
            <td width="3%" align="left" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br /><br /></td>
            <td width="94%"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">�� ��<br />Ӱ��ɳ��ֱ�ŵ�</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��<br />Ӱ��ɳ��ֱ�ŵ�</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��<br />Ӱ��ɳ��ֱ�ŵ�</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��<br />Ӱ��ɳ��ֱ�ŵ�</a></div></td>
                <td width="20%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��<br />Ӱ��ɳ��ֱ�ŵ�</a></div></td>
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
              <td width="93%" align="left" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-03.gif" alt="���Ƿ���" width="89" height="27" /></a></td>
              <td width="7%" align="right" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
            </tr>
          </table>
	      <table width="93%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
  <tr>
    <td width="33%">��<a href="#" target="_blank">��sa��׿�����·���</a> </td>
    <td width="33%">��<a href="#" target="_blank">��sa��׿�����·���</a> </td>
    <td width="33%">��<a href="#" target="_blank">��sa��׿�����·���</a> </td>
  </tr>
  <tr>
    <td>��<a href="#" target="_blank">�������Ƿ���-����̷�</a></td>
    <td>��<a href="#" target="_blank">�������Ƿ���-����̷�</a></td>
    <td>��<a href="#" target="_blank">�������Ƿ���-����̷�</a></td>
  </tr>
  <tr>
    <td>��<a href="#" target="_blank">���Ƿ���-л����̷�����</a> </td>
    <td>��<a href="#" target="_blank">���Ƿ���-л����̷�����</a> </td>
    <td>��<a href="#" target="_blank">���Ƿ���-л����̷�����</a> </td>
  </tr>
  <tr>
    <td>��<a href="#" target="_blank">�����������﷢��</a> </td>
    <td>��<a href="#" target="_blank">�����������﷢��</a> </td>
    <td>��<a href="#" target="_blank">�����������﷢��</a> </td>
  </tr>
  <tr>
    <td>��<a href="#" target="_blank">���Ƿ���-����þ���·���</a> </td>
    <td>��<a href="#" target="_blank">���Ƿ���-����þ���·���</a> </td>
    <td>��<a href="#" target="_blank">���Ƿ���-����þ���·���</a> </td>
  </tr>
</table>
</div>
	    <script language="javascript">
            var num=8; //�ܹ��м���С����
            var stopTime=100000000; //ͣ��ʱ��
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
              <td width="87" align="center"><div id="box1" onclick="showPage(1)">&nbsp;&nbsp;<font color="#cc0000">��ͷʱ��</font></div></td>
              <td width="89" align="center"><div id="box2" onclick="showPage(2)">����</div></td>
              <td width="89" align="center"><div id="box3" onclick="showPage(3)">�Ϻ�</div></td>
              <td width="87" align="center"><div id="box4" onclick="showPage(4)">����</div></td>
              <td width="86" align="center"><div id="box5" onclick="showPage(5)">����</div></td>
              <td width="90" align="center"><div id="box6" onclick="showPage(6)">ŦԼ</div></td>
              <td width="84" align="center"><div id="box7" onclick="showPage(7)">����</div></td>
              <td width="89" align="center"><div id="box8" onclick="showPage(8)">�׶�</div></td>
            </tr>
          </table>
<div id="container"></div>		  
	<div id="page1">	    
		  <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table>
</div>
	<div id="page2">	    
		  <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��222</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table>
</div>
<div id="page3"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��333</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table></div>	
<div id="page4"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��444</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table></div>
<div id="page5"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��555</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table></div>
<div id="page6"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��666</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table></div>
<div id="page7"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��777</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
            </tr>
          </table></div>
<div id="page8"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:6px">
              <tr>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">��888</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="17%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">������</a></div></td>
                <td width="16%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">������</a></div></td>
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
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;�Ż���Ϣ</a></td>
            <td width="46%" align="left" ><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
          </tr>
        </table>
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td class="main-3-rbg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td width="36%" height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
                       <td width="64%" align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">��ģ�������ع�</a></span><br />
                  ��������ǰ���������ں�����������һ����...<span class="red12"><a href="#" target="_blank">[ȫ��]</a></span></td>
                     </tr>
                     
                   </table>
              <table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;margin-bottom:12px">
                <tr>
                  <td width="83%" align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">������ζƿ�����弪����</a></td>
                  <td width="17%" align="center" class="red14">88��</td>
                </tr>
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">���򺣣�������ذ��ն�</a></td>
                  <td width="17%" align="center" class="red14">88��</td>
                </tr>
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
                  <td width="17%" align="center" class="red14">88��</td>
                </tr>
              </table>
              <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="30" align="left" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">�����</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
              </table>

			  <div class="list">
			  <ul><li>��&nbsp;<a href="#" target="_blank">������ζƿ�����弪����</a></li><li>��&nbsp;<a href="#" target="_blank">���򺣣�������ذ��ն�</a></li><li>��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></li><li>��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></li></ul></div>
			  
              <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
                <tr>
                  <td align="center" valign="top" bgcolor="#f7f7f7"><img src="Theme/Images/fair-06.gif" /></td>
                </tr>
              </table></td>
          </tr>
        </table>
	    
			 <div class="diy">�˴���ʾ  class "diy" ������</div>
			 <div class="clear"></div>
	  </div>
	  <div class="clear"></div>
	</div>
	<!--���岿�ֽ��� -->
	<!--��濪ʼ -->
	<div class="tl-ad"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa-ad.jpg" /></a></div>
	<!--������ -->
	<!--���㳡��ʼ -->
	<div id="fair-gc">
	  <div id="fair-gc-1"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="60" align="left" valign="top"><img src="Theme/Images/fair-14.gif" alt="���㳡" width="185" height="50" /></td>
  </tr>
</table>
        <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left"><img src="Theme/Images/fair-11.gif" alt="����ʦ�Ƽ�" width="118" height="25" /></td>
          </tr>
          <tr>
            <td align="center" class="gray12-b"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" />&nbsp;����ʮ�����з���</td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
          </tr>
          <tr>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-2">
	    <table width="88%" height="60" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left" valign="top"><img src="Theme/Images/fair-10.gif" alt="������������" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="5"></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">���ն��ϣ����˾��ﰬ</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�����򺣣�������ذ�</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">���ն��ϣ����˾��ﰬ</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�����򺣣�������ذ�</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ��</a></td>
          </tr>
          <tr>
            <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ��</a></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-3"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td align="left"><img src="Theme/Images/fair-12.gif" alt="�������Ƽ�" width="125" height="22" /></td>
  </tr>
  <tr>
    <td align="center" class="gray12-b"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" />&nbsp;����ʮ�����з���</td>
  </tr>
</table>
        <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
          </tr>
          <tr>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
            <td align="center" valign="top"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
          </tr>
        </table>
	  </div>
	  <div id="fair-gc-4">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;��������ע���а�&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
		   <tr>
                 <td height="40" colspan="2" align="left" valign="bottom">&nbsp;&nbsp;<span class="red12"><a href="#" target="_blank">[����]</a></span> <span class="gray12-lp">ʮ��������۲�����</span></td>
          </tr>
        </table>
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="80" align="center"><img src="Theme/Images/sg-08bbs_1.gif" /></td>
            <td width="85%" align="left"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div></td>
                  <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                      <span class="red12"><a href="#" target="_blank"></a></span></td>
                  <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">����</a></span><br />
                      <span class="red12">�Ƽ�ָ����4</span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_4.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_5.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_6.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_7.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">������ζƿ�����弪����</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_8.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">���򺣣�������ذ��ն���</a></td>
          </tr>
        </table>
	  </div>
	  
	  <div class="clear"></div>
	</div>
	<!--���㳡���� -->
	<!--��Ȧ�ӿ�ʼ -->
	<div id="fair-circle">
	  <div id="circle-l">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="60" align="left" valign="top"><img src="Theme/Images/fair-18.gif" alt="����Ȧ" width="187" height="49" /></td>
          </tr>
        </table>
	    <table width="88%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-22.gif" alt="��̳����" width="128" height="17" border="0" /></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="160" height="16" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="38%" valign="bottom"><table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
              <tr>
                <td width="50%" height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
              </tr>
              <tr>
                <td height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
              </tr>
            </table></td>
            <td width="62%" valign="top"><table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td height="5"></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line"><a href="#" target="_blank">���������ˡ�</a><a href="#" target="_blank">���˾��ﰬ</a></td>
              </tr>
              
            </table></td>
          </tr>
        </table>
		
	    <table width="88%" height="40" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-23.gif" alt="ר���Ƽ�" width="141" height="21" border="0" /></td>
            <td width="58%" align="center" valign="middle"><img src="Theme/Images/fair-26.gif" width="160" height="16" /></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="5"></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">����骡�</a><a href="#" target="_blank">���˾��ﰬ���˾��ﰬ���˾��ﰬ�ﰬ��</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">����骡�</a><a href="#" target="_blank">���˾��ﰬ���˾��ﰬ���˾��ﰬ�ﰬ��</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">����骡�</a><a href="#" target="_blank">���˾��ﰬ���˾��ﰬ���˾��ﰬ�ﰬ��</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">����骡�</a><a href="#" target="_blank">���˾��ﰬ���˾��ﰬ���˾��ﰬ�ﰬ��</a></td>
          </tr>
          <tr>
            <td class="gray14-line"><a href="#" target="_blank">����骡�</a><a href="#" target="_blank">���˾��ﰬ���˾��ﰬ���˾��ﰬ�ﰬ��</a></td>
          </tr>
        </table>
	    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:20px">
          <tr>
            <td width="54%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="33%" align="center" valign="middle"><img src="Theme/Images/fair-32.gif" width="45" height="45" /></td>
                <td width="67%" align="left" class="red12-c">���ҵ��Լ�����Ȥ
                  ������Ȧ������?</td>
              </tr>
              <tr>
                <td height="45" colspan="2" align="center" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-33.gif" width="70" height="19" border="0" /></a>&nbsp;&nbsp;<a href="#" target="_blank"><img src="Theme/Images/fair-34.gif" width="70" height="19" border="0" /></a></td>
                </tr>
            </table></td>
            <td width="46%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="20%" align="right"><img src="Theme/Images/sg-meifa_02b.gif" width="5" height="9" /></td>
                <td width="50%" align="center" class="red14b">Ȧ���Ƽ�</td>
                <td width="30%" align="left"><img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" /></td>
              </tr>
              <tr>
                <td colspan="3" align="center" class="gray14"><a href="#" target="_blank">������Ȧ��</a><a href="#" target="_blank">���㷢Ȧ��</a><br />
                  <a href="#" target="_blank">������Ȧ��</a><a href="#" target="_blank">���㷢Ȧ��</a></td>
              </tr>
            </table></td>
          </tr>
        </table>
	    <div class="clear"></div>
	  </div>
	  <div id="circle-m">
	    <table width="88%" height="35" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="42%" align="center" valign="middle"><img src="Theme/Images/fair-24.gif" alt="��Ʒ����" width="150" height="28" border="0" /></td>
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
                <td class="gray14-line">�� <a href="#" target="_blank">���ն��ϣ����˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�����򺣣�������ذ�</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">���ն��ϣ����˾��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�����򺣣�������ذ�</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
              </tr>
              <tr>
                <td class="gray14-line">�� <a href="#" target="_blank">�򷭵���ζƿ�þ��ﰬ</a></td>
              </tr>
            </table></td>
            <td width="37%" align="center"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="50%" height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
              </tr>
              <tr>
                <td height="120" align="center" valign="bottom"><div class="pic-2"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
              </tr>
            </table></td>
          </tr>
        </table>
	    <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="42%" height="40" align="center" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-25.gif" alt="�ʰ�" width="117" height="24" border="0" /></a></td>
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
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;��������</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">�� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a><br />
            �� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;�߷�����</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">�� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a><br />
�� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a></td>
          </tr>
        </table>
	    <table width="88%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="27" align="left" class="red12-c">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;���»ش�</td>
          </tr>
          <tr>
            <td align="left" class="gray12-d">�� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a><br />
�� <a href="#" target="_blank">ʲô��ɫ�ʺ���ʲô��ɫ�ʺ���ʲô��ɫ�ʺ��㣿</a></td>
          </tr>
        </table>
	    <div class="clear"></div>
	  </div>
	  <div id="circle-r">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;����ò�Ʒ&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
          <tr>
            <td height="40" colspan="2" align="left" valign="bottom">&nbsp;&nbsp;<span class="red12"><a href="#" target="_blank">[����]</a></span> <span class="gray12-lp">ʮ��������۲�����</span></td>
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
              <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">����MISSHA�Ȼ���</a></td>
            </tr>
            <tr>
              <td width="31%" align="left" class="red12-line"><a href="#">�ܺ�</a></td>
              <td width="33%" align="left" class="gray12-lp">238Ʊ</td>
              <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
            </tr>
            <tr>
              <td align="left" class="red12-line"><a href="#" target="_blank">��ͨ</a></td>
              <td align="left" class="gray12-lp">156Ʊ</td>
              <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
            </tr>
            <tr>
              <td align="left" class="red12-line"><a href="#" target="_blank">�ϲ�</a></td>
              <td align="left" class="gray12-lp">50Ʊ</td>
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
                       <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">����MISSHA�Ȼ���</a></td>
                     </tr>
                     <tr>
                       <td width="31%" align="left" class="red12-line"><a href="#">�ܺ�</a></td>
                       <td width="33%" align="left" class="gray12-lp">238Ʊ</td>
                       <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">��ͨ</a></td>
                       <td align="left" class="gray12-lp">156Ʊ</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">�ϲ�</a></td>
                       <td align="left" class="gray12-lp">50Ʊ</td>
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
                       <td colspan="3" align="left" class="gray12-lp"><a href="#" target="_blank">����MISSHA�Ȼ���</a></td>
                     </tr>
                     <tr>
                       <td width="31%" align="left" class="red12-line"><a href="#">�ܺ�</a></td>
                       <td width="33%" align="left" class="gray12-lp">238Ʊ</td>
                       <td width="36%" align="left"><img src="Theme/Images/meirong-08_ls01.gif" width="30" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">��ͨ</a></td>
                       <td align="left" class="gray12-lp">156Ʊ</td>
                       <td align="left"><img src="Theme/Images/meirong-08_ls02.gif" width="20" height="2" /></td>
                     </tr>
                     <tr>
                       <td align="left" class="red12-line"><a href="#" target="_blank">�ϲ�</a></td>
                       <td align="left" class="gray12-lp">50Ʊ</td>
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
                 <td align="left" class="red14b">&nbsp;&nbsp;��������&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
               </tr>
               <tr>
                 <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
               </tr>
             </table>
			 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                     <tr>
                       <td width="36%" height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
                       <td width="64%" align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">��ģ�������ع�</a></span><br />
                  ��������ǰ���������ں�����������һ����...<span class="red12"><a href="#" target="_blank">[ȫ��]</a></span></td>
                     </tr>
                     <tr>
                       <td height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
                       <td align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">��ģ�������ع�</a></span><br />
                       ��������ǰ���������ں�����������һ����...<span class="red12"><a href="#" target="_blank">[ȫ��]</a></span></td>
                     </tr>
                     <tr>
                       <td height="75" align="center" valign="middle"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a></div></td>
                       <td align="left" class="gray12-d"><span class="gray12-b"><a href="#" target="_blank">��ģ�������ع�</a></span><br />
                       ��������ǰ���������ں�����������һ����...<span class="red12"><a href="#" target="_blank">[ȫ��]</a></span></td>
                     </tr>
        </table>
	  </div>
	  <div class="clear"></div>
	</div>	
	<!--��Ȧ�ӽ��� -->
	<div id="showhair">
    <table width="95%" height="30" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="7%" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;��Ҫ��</td>
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
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">�������</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�������</a></div></td>
                <td width="12%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">�������</a></div></td>
                <td width="13%" align="center"><div class="pic-1"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">�������</a></div></td>
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
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopContent.aspx.cs" Inherits="Web.HairShopContent" %>
<%@ Register Src="UserControls/HairShopEntryControl.ascx" TagName="HairShopEntryControl" TagPrefix="HN" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--����������ʼ -->
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a>&nbsp;|&nbsp;�����&nbsp;|&nbsp;ϴ��ˮ&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;</div></td>
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a>&nbsp;|&nbsp;�����&nbsp;|&nbsp;ϴ��ˮ&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;</div></td>
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a>&nbsp;|&nbsp;�����&nbsp;|&nbsp;ϴ��ˮ&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;</div></td>
                  </tr>
            </table></td>
  </tr>
</table>					
</div>
<!--������������ -->
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
<!--�������ݲ��ֿ�ʼ -->
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
    <td width="15%" align="left" valign="middle" class="red14b">Ӱ��ɯ������</td>
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
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ<br />
                  �쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�����������쳾�����Ԫ������<br />
                  �Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�<br />
                Ʒ������ˮ�����쳾�����Ԫ/ML������</td>
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
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;22222�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ<br />
                  �쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�����������쳾�����Ԫ������<br />
                  �Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�<br />
                Ʒ������ˮ�����쳾�����Ԫ/ML������</td>
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
                <td class="gray12-f"> &nbsp;&nbsp;&nbsp;&nbsp;3333�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ<br />
                  �쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�����������쳾�����Ԫ������<br />
                  �Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�<br />
                Ʒ������ˮ�����쳾�����Ԫ/ML������</td>
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
            <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;����ʦ�Ƽ�</td>
            <td width="12%" align="left" valign="middle"><img src="Theme/Images/fair-mft16.gif" alt="����ʦ�Ƽ�" /></td>
            <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
            <td width="10%" align="left" valign="middle"><a href="#" target="_blank"><img src="Theme/Images/fair-more.gif" width="48" height="14" border="0" /></a></td>
          </tr>
      </table>
	  <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px">
              <tr>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="ͼƬ˵��" /></a><br />
                    <a href="#" target="_blank">���������������ͼƬ����
                    <br />
                    </a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                    �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                    �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                    �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td width="20%" align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                    �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
        </tr>
              <tr>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                        <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                          �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                        <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                          �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="ͼƬ˵��" /></a><br />
                        <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                          �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                        <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                          �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
                <td align="center"><div class="pic-2"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls10.gif" alt="ͼƬ˵��" /></a><br />
                        <a href="#" target="_blank">�� ��&nbsp;&nbsp;����ܼ�
                          �����۸�&nbsp;&nbsp;&nbsp;&nbsp;130</a></div></td>
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
      <td width="93%" align="left" valign="bottom"><a href="#" target="_blank"><img src="Theme/Images/fair-mft18.gif" alt="���ھ�����Ʒ" /></a></td>
      <td width="7%" align="right"><a href="#" target="_blank"></a></td>
    </tr>
  </table>

  <table width="96%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
          <tr>
            <td width="3%" align="center" valign="middle"><img src="Theme/Images/sg-meifa_l.gif" width="9" height="33" /><br />
            <br /></td>
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
            <td width="135" align="left" background="Theme/Images/fair-mft08.gif" class="red14b">������ҵ�����</td>
            <td width="472" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="84" align="right" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft07.gif" width="3" height="29" /></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="5" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft10.gif" /></td>
            <td width="23" align="center" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/sg-meifa_02.gif" /></td>
            <td width="59" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c">��Ҫ����</td>
            <td width="148" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">�û���:</td>
            <td width="147" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield2" type="text" class="pass" /></td>
            <td width="52" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c">�ܡ���:</td>
            <td width="160" align="center" background="Theme/Images/fair-mft12.gif"><input name="textfield22" type="text" class="pass" /></td>
            <td width="97" align="center" background="Theme/Images/fair-mft12.gif" class="gray12-c"><a href="#" target="_blank">ע��</a>   &nbsp;<a href="#" target="_blank">��½</a></td>
            <td width="10" align="right" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box"><textarea cols="" rows="" class="pl-box"></textarea></div>
		
		<div class="submit"><a href="#" target="_blank"><img src="Theme/Images/fair-submit.gif" border="0" /></a></div>
		<div class="message-1">
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">���ԣ�</td>
    <td width="69%" align="left" class="black12">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ������</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21��45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">�ظ���</td>
                <td align="left" class="gray12-c">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML��</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-2">
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">���ԣ�</td>
    <td width="69%" align="left" class="black12">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ������</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21��45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">�ظ���</td>
                <td align="left" class="gray12-c">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML��</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-1">
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">���ԣ�</td>
    <td width="69%" align="left" class="black12">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ������</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21��45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">�ظ���</td>
                <td align="left" class="gray12-c">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML��</td>
              </tr>
            </table>
		  </div>
		  <div class="clear"></div>
		</div>
		<div class="message-2">
		  <div class="touxiang"><img src="Theme/Images/sg-meifa_ls01.gif" /></div>
		  <div class="mes-content"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="9%" align="left" valign="top" class="red12b">���ԣ�</td>
    <td width="69%" align="left" class="black12">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML�������Ͼ�Ʒ�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ������</td>
    <td width="22%" align="right" valign="top" class="gray12">2007-12-06 21��45<br />
      <a href="#" target="_blank"><img src="Theme/Images/fair-mft14.gif" width="59" height="19" border="0" /></a></td>
  </tr>
</table>
<div class="point"></div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="9%" align="left" valign="top" class="red12-c">�ظ���</td>
                <td align="left" class="gray12-c">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾�����Ԫ/ML��</td>
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
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;��ַλ��</a></td>
            <td width="46%" align="left" ><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"></a></td>
          </tr>
        </table>
      <div class="sitemap"><img src="Theme/Images/fair-mft19.gif" /></div>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="35" align="left" valign="middle" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">��ҪͶƱ</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
    </table>
			 <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:10px;">
            <tr>
              <td width="24%" align="center" class="red14-line"><a href="#">�ܺ�</a></td>
              <td width="56%" align="left"><img src="Theme/Images/fair-mft20.gif" width="129" height="11" /></td>
              <td width="20%" align="center" class="gray12-lp">70%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">��ͨ</a></td>
              <td align="left"><img src="Theme/Images/fair-mft21.gif" width="129" height="11" /></td>
              <td align="center" class="gray12-lp">20%</td>
            </tr>
            <tr>
              <td align="center" class="red14-line"><a href="#" target="_blank">�ϲ�</a></td>
              <td align="left"><img src="Theme/Images/fair-mft22.gif" width="129" height="11" /></td>
              <td align="center" class="gray12-lp">10%</td>
            </tr>
    </table>
	<div class="main-r-box">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td align="left"><table width="210" height="27" border="0" cellpadding="0" cellspacing="0" style="margin-left:1px;">
              <tr>
                <td style="border-left:#d5d5d5 1px solid;border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box1" onclick="showPage(1)">����ʦ��ע�Ȱ�</div></td>
                <td style="border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box2" onclick="showPage(2)">�Ż�ȯ���ذ�</div></td>
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
		<div id="page2">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="80" align="center"><img src="Theme/Images/sg-08bbs_1.gif" /></td>
            <td width="85%" align="left"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div></td>
                  <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                      <span class="red12"><a href="#" target="_blank"></a></span></td>
                  <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">����222</a></span><br />
                      <span class="red12">�Ƽ�ָ��22��4</span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">����22��������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="center"><img src="Theme/Images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><a href="#" target="_blank">����22��������ذ��ն���</a></td>
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
    </div> 	
	<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;�ܱ�������&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="88%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-3"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">����88��</a></div></td>
            <td width="50%" align="center" valign="top"><div class="pic-3"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a><br />
                <a href="#" target="_blank">����88��</a></div></td>
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
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">������ζƿ�����弪����</a></td>
                  <td align="center" class="red14">88��</td>
                </tr>
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">���򺣣�������ذ��ն�</a></td>
                  <td align="center" class="red14">88��</td>
                </tr>
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
                  <td align="center" class="red14">88��</td>
                </tr>
                
                <tr>
                  <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
                  <td align="center" class="red14">88��</td>
                </tr>
    </table>
	</div>
	<div class="main-r-box">
	    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
          <tr>
            <td align="left" class="red14b">&nbsp;&nbsp;������������Ʒ&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
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
          <td align="left" class="red14b">&nbsp;&nbsp;�������������Ļ���˭&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:15px">
          <tr>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div><div class="pic-5-title"><a href="#" target="_blank"><span class="gray">��ģ����</span></a></div>
            </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">��ģ����</span></a></div>
             </td>
            <td width="50%" align="center" valign="top"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div>
                <div class="pic-5-title"><a href="#" target="_blank"><span class="gray">��ģ����</span></a></div>
              </td>
          </tr>
      </table>
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="35%" align="left" class="gray12">&nbsp;<img src="Theme/Images/sg-meifa_02.gif" width="5" height="9" />&nbsp;����56��&nbsp;</td>
          <td width="65%" align="left" class="gray12"><a href="#"><img src="Theme/Images/fair-mft23.gif" width="59" height="19" border="0" /></a></td>
        </tr>
      </table>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td height="30" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;��������������ѻ������&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
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
        <tr>
          <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
          <td align="center" class="red14">88��</td>
        </tr>
      </table>
</div>				  
    </div>	
    <div id="main-rr"></div>
    <div class="clear"></div>
	<div><img src="Theme/Images/fair-mft15.gif" /></div>
</div>
<!--�������ݲ��ֽ��� -->
</asp:Content>
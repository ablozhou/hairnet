<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHead.ascx.cs" Inherits="Web.UserControls.SearchHead" %>
<!--����������ʼ -->
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
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
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
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
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
                      <td width="5%" align="left"><img src="Theme/images/sg-meifa_17.gif" width="26" height="23" /></td>
                      <td width="8%" class="search"><a href="#" target="_blank">��&nbsp;��</a></td>
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
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l">&nbsp;&nbsp;<a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a>&nbsp;|&nbsp;�����&nbsp;|&nbsp;ϴ��ˮ&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> <br />
                    &nbsp;&nbsp;<a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;</div></td>
                  </tr>
  </table>					
</div>
<!--������������ -->

<%--

<div id="main-top2">
  <div id="area-1"><img src="Theme/Images/sg-meifa-ad2.jpg" /></div>
  <div id="area-2">
    <table width="378" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td height="15" colspan="2">&nbsp;</td>
      </tr>
      <tr>
        <td width="179" height="25" align="left" class="red14b">&nbsp;&nbsp;<asp:Label ID="lblHairShopName" runat="server"></asp:Label></td>
        <td width="201" align="right" valign="bottom"><table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft-tab1.gif" id="seatchTab21">
            <tr>
              <td width="70" onclick="showTab2(1);" style="cursor:hand;">&nbsp;</td>
              <td width="71" onclick="showTab2(2);" style="cursor:hand;">&nbsp;</td>
            </tr>
          </table>
            <table width="141" height="25" border="0" align="right" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft-tab2.gif" id="seatchTab22"  style="display:none;">
              <tr>
                <td width="70" onclick="showTab2(1);" style="cursor:hand;">&nbsp;</td>
                <td width="71" onclick="showTab2(2);" style="cursor:hand;">&nbsp;</td>
              </tr>
          </table></td>
      </tr>
    </table>
    <div class="top-r-div" id="serTabC21">
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[�� ַ]</span> <asp:Label ID="lblHairShopAddress" runat="server"></asp:Label> <br />
            <span class="red12-c">[�� ͨ]</span> <asp:Label ID="lblLocationMapUrl" runat="server"></asp:Label> </td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="39%" align="left" class="gray12-d"><span class="red12-c">[�� ��] </span><asp:Label ID="lblSquare" runat="server"></asp:Label></td>
          <td width="61%" align="left" class="gray12-d"><span class="red12-c">[ͣ��λ]</span> <asp:Label ID="lblIsPostStation" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[�ɷ�ˢ��]</span> <asp:Label ID="lblIsPostMachine" runat="server"></asp:Label></td>
          <td align="left" class="gray12-d"><span class="red12-c">[Ӫҵʱ��]</span>  <asp:Label ID="lblHairShopOpenTime" runat="server"></asp:Label></td>
        </tr>
        <tr>
          <td align="left" class="gray12-d"><span class="red12-c">[�� ��]</span> <asp:Label ID="lblHairShopType" runat="server"></asp:Label> </td>
          <td align="left" class="gray12-d"><span class="red12-c">[�����Ʒ]</span> <asp:Label ID="lblProduct" runat="server"></asp:Label></td>
        </tr>
      </table>
      <asp:Panel ID="p1" runat="server" Visible="false">
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
        <tr>
          <td width="39%" align="left"><asp:Label ID="lblCouponPic" runat="server"></asp:Label></td>
          <td width="61%" align="left" valign="middle" class="gray12-d">�Ѵ�ӡ��<span class="red12-c"><asp:Label ID="lblPrintNum" runat="server"></asp:Label></span><br />
          <span class="red12-line-c"><asp:Label ID="lblPrintCoupon" runat="server"></asp:Label></span></td>
        </tr>
      </table>
      </asp:Panel>
      <asp:Panel ID="p2" runat="server" Visible="true">
      <table width="360" height="20" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:5px">
        <tr>
          <td align="left" valign="bottom" class="gray12-d">�����Ż�ȯ������д����Email��ַ</td>
        </tr>
      </table>
	  <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="53%" align="left"><input type="text" runat="server" id="txtCouponEmail" /></td>
          <td width="47%" align="left"><asp:ImageButton style="z-index: 1002;" ID="imgBtnCouponSubmit" OnClick="imgBtnCouponSubmit_OnClick" runat="server" Width="38" Height="21"  ImageUrl="../Theme/images/fair-mft24.gif" /></td>
        </tr>
      </table>
      </asp:Panel>
	  <table width="400" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:23px">
  <tr>
    <td width="3%"></td>
    <td width="94%" height="26" style="border:#ddddda 1px solid"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="43%" align="left" class="gray12-d"><span class="red12b">ԤԼ�绰��</span><asp:Label ID="lblHairShopPhoneNum" runat="server"></asp:Label></td>
        <td width="28%" align="left" class="gray12-d">�ۿۣ�<span class="red12-c"><asp:Label ID="lblHairShopDiscount" runat="server"></asp:Label></span></td>
        <td width="29%" align="right" class="gray12-d"><asp:Label ID="lblComment" runat="server"></asp:Label>&nbsp;&nbsp;  <asp:Label ID="lblStore" runat="server"></asp:Label></td>
      </tr>
    </table></td>
    <td width="3%"></td>
  </tr>
</table>
	</div>
	<div class="top-r-div" id="serTabC22">
	<div class="hj-gundong"><asp:Label ID="lblHairShopPicList" runat="server"></asp:Label></div>
	      <asp:Panel ID="Panel1" runat="server" Visible="false">
	      <table width="360" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px">
            <tr>
              <td width="39%" align="left"><asp:Label ID="lblCouponPic2" runat="server"></asp:Label></td>
              <td width="61%" align="left" valign="middle" class="gray12-d">�Ѵ�ӡ��<span class="red12-c"><asp:Label ID="lblPrintNum2" runat="server"></asp:Label></span><br />
              <span class="red12-line-c"><asp:Label ID="lblPrintCoupon2" runat="server"></asp:Label></span></td>
            </tr>
          </table>
          </asp:Panel>
          <asp:Panel ID="Panel2" runat="server" Visible="true">
          <table width="360" height="20" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:10px;margin-bottom:5px">
            <tr>
              <td align="left" valign="bottom" class="gray12-d">�����Ż�ȯ������д����Email��ַ</td>
            </tr>
          </table>
	      <table width="360" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="53%" align="left"><input type="text" runat="server" id="txtCouponEmail2" /></td>
              <td width="47%" align="left"><asp:ImageButton style="z-index: 1002;" ID="ImageButton1" OnClick="imgBtnCouponSubmit2_OnClick" runat="server" Width="38" Height="21"  ImageUrl="../Theme/images/fair-mft24.gif" /></td>
            </tr>
          </table>
          </asp:Panel>
	      <table width="400" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:23px">
      <tr>
        <td width="3%"></td>
        <td width="94%" height="26" style="border:#ddddda 1px solid"><table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="43%" align="left" class="gray12-d"><span class="red12b">ԤԼ�绰��</span><asp:Label ID="lblHairShopPhoneNum2" runat="server"></asp:Label></td>
            <td width="28%" align="left" class="gray12-d">�ۿۣ�<span class="red12-c"><asp:Label ID="lblHairShopDiscount2" runat="server"></asp:Label></span></td>
            <td width="29%" align="right" class="gray12-d"><asp:Label ID="lblComment2" runat="server"></asp:Label>&nbsp;&nbsp;  <asp:Label ID="lblStore2" runat="server"></asp:Label></td>
          </tr>
        </table></td>
        <td width="3%"></td>
      </tr>
    </table>
	</div>
  </div>
  </div>
--%>
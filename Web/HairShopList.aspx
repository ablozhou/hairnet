<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopList.aspx.cs" Inherits="Web.HairShopList" %>
<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--����������ʼ -->
<div id="main-top">
 <table width="99%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="7%" align="left" background="Theme/Images/sg-meifa_04.gif"><img src="Theme/Images/search-mft.gif" /></td>
              <td width="92%" valign="top" background="Theme/Images/sg-meifa_04.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0"  style="margin-top:8px;margin-bottom:8px">
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
			  
                <table width="98%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td valign="middle" class="search-txt"><div class="gundong"><span class="search-txt-l"><a href="#" target="_blank">����</a></span>&nbsp;|&nbsp;<a href="#" target="_blank">�������</a>&nbsp;|&nbsp; <a href="#" target="_blank">���з���</a>&nbsp;|&nbsp; <a href="#" target="_blank">���﷢��</a>&nbsp;|&nbsp;<a href="#" target="_blank">����������</a>&nbsp;|&nbsp;<a href="#" target="_blank">�̷�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;�̷�&nbsp;|&nbsp;<a href="#" target="_blank">ֱ������</a>&nbsp;|&nbsp;�����&nbsp;|&nbsp;ϴ��ˮ&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a> <a href="#" target="_blank">Ⱦ������</a>&nbsp;|&nbsp;<a href="#" target="_blank">��λ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">��������</a>&nbsp;|&nbsp;<a href="#" target="_blank">ɳ��</a>&nbsp;|&nbsp;<a href="#" target="_blank">�����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;|&nbsp;<a href="#" target="_blank">��Ů����</a>&nbsp;|&nbsp;<a href="#" target="_blank">��ϵ����</a>&nbsp;|&nbsp;<a href="#" target="_blank">ͨ�ڷ���</a>&nbsp;|&nbsp;<a href="#" target="_blank">ϴ��ˮ</a>&nbsp;</div></td>
                  </tr>
                </table></td>
              <td width="1%" align="right" background="Theme/Images/sg-meifa_04.gif"><img src="Theme/Images/sg-meifa_06.gif" width="8" height="117" /></td>
            </tr>
  </table>					
</div>
<!--������������ -->
<div id="main-top2"></div>
<!--�������ݲ��ֿ�ʼ -->
<div id="main">
  <div id="main-l">
    <div id="mfs-tj">
      <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/Images/fair-mft04-a.gif">
        <tr>
          <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;�������Ƽ�</td>
          <td width="12%" align="left" valign="middle"><img src="Theme/Images/mft_list_salon.gif" alt="����ʦ�Ƽ�" /></td>
          <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
          <td width="10%" align="left" valign="middle">&nbsp;</td>
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
      </table>
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="Theme/Images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
      <div class="null-box"></div>
      <div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="138" align="left" background="Theme/Images/fair-mft08.gif">���ҵ� <span class="red12">213</span> ��������</td>
            <td width="395" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="153" align="left" background="Theme/Images/fair-mft08.gif"><img src="Theme/Images/fair-mft07.gif" width="3" height="7" />�� 10 ҳ <a href="#" class="gray12-d">��һҳ</a> <a href="#" class="gray12-d">��һҳ</a></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft10.gif" /></td>
            <td width="71" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c">����ʽ��</td>
            <td width="10" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c"><img src="Theme/Images/fair-mft11.gif" /></td>
            <td width="86" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c"><div align="center">��ʱ������</div></td>
            <td width="28" align="left" background="Theme/Images/fair-mft12.gif"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/Images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/Images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
              </tr>
            </table></td>
            <td width="10" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft11.gif" /></td>
            <td width="93" align="right" background="Theme/Images/fair-mft12.gif" class="gray12-c"><div align="center">��ʱ������</div></td>
            <td width="23" align="left" background="Theme/Images/fair-mft12.gif" class="gray12-c"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/Images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/Images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
              </tr>
            </table></td>
            <td width="365" align="left" background="Theme/Images/fair-mft12.gif"><img src="Theme/Images/fair-mft11.gif" /></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                  </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
                <td width="100" height="104" valign="top"><a href="#"><img src="Theme/Images/sg-meifa_ls02.gif" width="96" height="96" class="pic_padding_glay" /></a></td>
                <td width="561" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="gray12-lp">
                    <tr>
                      <td width="4%" height="12">&nbsp;</td>
                      <td width="12%">[����]</td>
                      <td width="27%" class="red12"><strong>���ص���</strong></td>
                      <td width="8%">[�۸�]</td>
                      <td width="21%">2000Ԫ</td>
                      <td width="4%"><img src="Theme/Images/mft_list_arrow.gif" width="9" height="13" /></td>
                      <td width="10%"><a href="#"   style=" text-decoration:underline">������</a></td>
                      <td width="14%">�ۿۣ�<span class="red12">8��</span></td>
                    </tr>
                    <tr>
                      <td height="20">&nbsp;</td>
                      <td>[��ַ]</td>
                      <td>�����к�����С����28��</td>
                      <td>[�绰]</td>
                      <td>010-65498315</td>
                      <td colspan="3" valign="top">&nbsp;</td>
                    </tr>
                    <tr>
                      <td height="42">&nbsp;</td>
                      <td valign="top">[���]</td>
                      <td colspan="6" valign="top">�����쳾�����Ԫ/ML�������Ͼ�Ʒ������ˮ�����쳾����������쳾�����<br />
                        �����쳾����������쳾����������쳾����������쳾����������쳾��</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td colspan="7"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="13%" height="27"><a href="#" target="_blank"><img src="Theme/Images/mfs_list_map.gif" width="59" height="19" border="0" /></a></td>
                            <td width="28%"><a href="#" target="_blank"><img src="Theme/Images/mft_list_collection.gif" width="59" height="19" border="0" /></a></td>
                            <td width="8%">[����]</td>
                            <td width="16%"><span class="red12">50%</span></td>
                            <td width="35%"><a href="#" class="red12" style=" text-decoration:underline">�� ��</a> | <a href="#" style=" text-decoration:underline">��Ҫ����</a></td>
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
		<div class="page-all"><a href="#">��һҳ</a>  <a href="#">��һҳ</a>  <a href="#">1</a> <span class="red12">2</span> <a href="#">3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a>  &nbsp;<a href="#">��һҳ</a>&nbsp;&nbsp;<a href="#">���һҳ</a>&nbsp;&nbsp;��8ҳ</div>	
<div class="clear"></div>
      </div>
  </div>
  <div id="main-r">
<div class="main-r-box">
	    <table width="100%" border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td align="left"><table width="258" height="33" border="0" cellpadding="0" cellspacing="0" style="margin-left:1px;">
              <tr>
                <td width="108" height="33" style="border-top:#d5d5d5 1px solid;border-left:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box1" onclick="showPage(1)">����������</div></td>
                <td width="107" style="border-top:#d5d5d5 1px solid;border-right:#d5d5d5 1px solid;"><div id="box2" onclick="showPage(2)">�����Ż�ȯ</div></td>
                <td width="43" bgcolor="#FAFAFA">&nbsp;</td>
              </tr>
            </table>
            <img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /><br /><br />

</td>
          </tr>
          
      </table>
		<div id="container"></div>
	  <div id="page1">
	    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="15%" height="68" align="center"><img src="Theme/Images/sg-08bbs_1.gif" /></td>
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
            <td height="68" align="center"><img src="Theme/Images/sg-08bbs_2.gif" /></td>
            <td align="left" class="gray14-e"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div></td>
                <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                    <span class="red12"><a href="#" target="_blank"></a></span></td>
                <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">����</a></span><br />
                    <span class="red12">�Ƽ�ָ����4</span></td>
              </tr>
            </table>              <a href="#" target="_blank"></a></td>
          </tr>
          <tr>
            <td height="68" align="center"><img src="Theme/Images/sg-08bbs_3.gif" /></td>
            <td align="left" class="gray14-e"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr>
                <td width="29%"><div class="pic-5"><a href="#" target="_blank"><img src="Theme/Images/sg-meifa_ls01.gif" alt="ͼƬ˵��" /></a></div></td>
                <td width="6%" align="left"><span class="gray12-b"><a href="#" target="_blank"></a></span><br />
                    <span class="red12"><a href="#" target="_blank"></a></span></td>
                <td width="65%" align="left"><span class="gray14-b"><a href="#" target="_blank">����</a></span><br />
                    <span class="red12">�Ƽ�ָ����4</span></td>
              </tr>
            </table>              <a href="#" target="_blank"></a></td>
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
          <tr></tr>
          <tr>
            <td width="85%" align="left" class="gray14-e"><a href="#" target="_blank">������22��������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">������22��������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">��������ζƿ�����弪����</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
          <tr>
            <td align="left" class="gray14-e"><a href="#" target="_blank">�����򺣣�������ذ��ն���</a></td>
          </tr>
        </table>
	  </div>		
    </div> 	
    <div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;���ű�ǩ&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="98%" height="240" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:3px;margin-bottom:3px">
        <tr>
          <td width="5%" align="left" valign="top" class="gray14-e">&nbsp;</td>
          <td width="92%" height="240" align="left" valign="top"  style="line-height:30px;" ><span class="tag_1"><a href="#">����</a></span>  <span class="tag_5"><a href="#">�������</a></span>  ���з���  <span class="tag_3"><a href="#">���﷢��</a></span><br />
            <span class="tag_4"><a href="#">����������</a></span>  <span class="tag_2"><a href="#">�̷�����</a></span>  ��������<br />
            <span class="tag_5"><a href="#">�̷�</a></span>  ����  ֱ������  Ⱦ��  <span class="tag_1"><a href="#">�����</a></span><br />
            ��λ���  <span class="tag_3"><a href="#">��������</a></span>  ɳ��  <span class="tag_5"><a href="#">ˮĸ����</a></span><br />
            ϴ��ˮ  <span class="tag_1"><a href="#">��Ů����</a></span>  <span class="tag_2"><a href="#">��ϵ����</a></span>  ͨ�ڷ���<br />
            ���䷢��  <span class="tag_5"><a href="#">��������</a></span>  ��˷���  ����<br />
            <span class="tag_3"><a href="#">���η���</a></span>  <span class="tag_4"><a href="#">��ʽ����</a></span>  BOB���� <br />
          <span class="tag_2"><a href="#">2008�����з���</a></span>  <span class="tag_1"><a href="#">��������</a></span> </td>
          <td width="3%" align="left" valign="top" class="gray14-e">&nbsp;</td>
        </tr>
      </table>
	</div>
	<div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;���ȵ���&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="98%" height="202" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:3px;margin-bottom:3px">
        <tr>
          <td height="202" align="left" valign="top" class="gray14-e"><table width="92%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:5px;margin-bottom:12px">
            <tr>
              <td width="79%" align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">������ζƿ�����弪����</a></td>
              <td width="21%" align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">���򺣣�������ذ��ն�</a></td>
              <td width="21%" align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
              <td width="21%" align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">������ζƿ�����弪����</a></td>
              <td align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">���򺣣�������ذ��ն�</a></td>
              <td align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
              <td align="center" class="red14">[����]</td>
            </tr>
            <tr>
              <td align="left" class="gray14-e">��&nbsp;<a href="#" target="_blank">�ն��ϣ����˾���򷭵�</a></td>
              <td align="center" class="red14">[����]</td>
            </tr>
          </table></td>
        </tr>
      </table>
    </div>
	<div class="main-r-box">
	    <table width="100%" height="41" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
          <tr>
            <td height="28" align="left" class="red14b">&nbsp;&nbsp;�����Ƽ���&nbsp;<img src="Theme/Images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td height="8"><img src="Theme/Images/sg-meifa_46.gif" width="256" height="2" /></td>
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
  </div>
  <div id="main-rr"></div>
    <div class="clear"></div>
	<div><img src="Theme/Images/fair-mft15.gif" /></div>
</div>
<!--�������ݲ��ֽ��� -->
</asp:Content>
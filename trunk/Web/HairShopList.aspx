<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopList.aspx.cs" Inherits="Web.HairShopList" %>
<%@ Register Src="UserControls/SearchHead.ascx" TagName="SearchHead" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotHairShopList.ascx" TagName="HotHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/RecommandHairShopList.ascx" TagName="RecommandHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotCouponList2.ascx" TagName="HotCouponList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopListControl.ascx" TagName="HairShopListControl" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<!--����������ʼ -->
<HN:SearchHead ID="searchHead" runat="server" />
<!--������������ -->
<div id="main-top2"></div>
<!--�������ݲ��ֿ�ʼ -->
<div id="main">
  <div id="main-l">
    <div id="mfs-tj">
      <table width="706" height="36" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/images/fair-mft04-a.gif">
        <tr>
          <td width="17%" align="left" valign="middle" class="red14b">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;�������Ƽ�</td>
          <td width="12%" align="left" valign="middle"><img src="Theme/images/mft_list_salon.gif" alt="����ʦ�Ƽ�" /></td>
          <td width="61%" align="left" valign="bottom"><a href="#" target="_blank"></a></td>
          <td width="10%" align="left" valign="middle">&nbsp;</td>
        </tr>
      </table>
      <!--����������ʼ -->
        <HN:RecommandHairShopList ID="recommandHairShopList" runat="server" />
      <!--������������ -->
      <table width="706" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><img src="Theme/images/fair-mft04-d.gif" width="706" height="18" /></td>
        </tr>
      </table>
    </div>
      <div class="null-box"></div>
       <!--�������б�ʼ -->
       <HN:HairShopListControl ID="hairShopListControl" runat="server" />
       <!--�������б���� -->
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
            <img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /><br /><br />

</td>
          </tr>
          
      </table>
		<div id="container"></div>
	  <div id="page1">
	  <!--������������ʼ -->
	    <HN:HotHairShopList ID="hotHairShopList" runat="server" />
	    <!--�������������� -->
	  </div>
		<div id="page2">
		<!--�Ż�ȯ��ʼ -->
	    <HN:HotCouponList ID="hotCouponList" runat="server" />
	    <!--�Ż�ȯ���� -->
	  </div>		
    </div> 	
    <div class="main-r-box2">
	  <table width="100%" height="43" border="0" cellpadding="0" cellspacing="0" style="margin-top:20px">
        <tr>
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;���ű�ǩ&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <table width="98%" height="240" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top:3px;margin-bottom:3px">
        <tr>
          <td width="5%" align="left" valign="top" class="gray14-e">&nbsp;</td>
          <td width="92%" height="240" align="left" valign="top"  style="line-height:30px;" ><span class="tag_1"><a href="#">����</a></span>  <span class="tag_5"><a href="#">�������</a></span>  ���з���  <span class="tag_3"><a href="#">���﷢��</a></span><br />
            <span class="tag_4"><a href="#">����������</a></span>  <span class="tag_2"><a href="#">�̷�����</a></span>  ������<br />
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
          <td height="24" align="left" class="red14b">&nbsp;&nbsp;���ȵ���&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td height="19"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
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
            <td height="28" align="left" class="red14b">&nbsp;&nbsp;�����Ƽ���&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
          </tr>
          <tr>
            <td height="8"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
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
	<div><img src="Theme/images/fair-mft15.gif" /></div>
</div>
<!--�������ݲ��ֽ��� -->
</asp:Content>

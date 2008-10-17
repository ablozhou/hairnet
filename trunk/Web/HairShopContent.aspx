<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Home.Master" CodeBehind="HairShopContent.aspx.cs" Inherits="Web.HairShopContent" %>
<%@ Register Src="UserControls/HairShopVoteControl.ascx" TagName="HairShopVoteControl" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopEntryControl.ascx" TagName="HairShopEntryControl" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopDescription.ascx" TagName="HairShopEntryDescription" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopEngineerList.ascx" TagName="HairShopEngineerList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HairShopWorkList.ascx" TagName="HairShopWorkList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotHairEngineerList.ascx" TagName="HotHairEngineerList" TagPrefix="HN" %>
<%@ Register Src="UserControls/HotCouponList.ascx" TagName="HotCouponList" TagPrefix="HN" %>
<%@ Register Src="UserControls/SameHotZoneHairShopList.ascx" TagName="SameHairShopList" TagPrefix="HN" %>
<%@ Register Src="UserControls/NewWorkList.ascx" TagName="NewWorkList" TagPrefix="HN" %>

<asp:Content ContentPlaceHolderID="BodyContentPosition" ID="BodyContent" runat="server">
<div style="text-align:center; height:160px;">
<iframe src="SearchHeadPage.aspx" width="980" height="160" frameborder="no" border="0" marginwidth="0" marginheight="0" scrolling="no" allowtransparency="yes"></iframe>
</div>
<!-- ������������Ϣ -->
<HN:HairShopEntryControl ID="hairShopEntryControl" runat="server" />
<!-- ������������Ϣ���� -->

<!--�������ݲ��ֿ�ʼ -->
<div id="main">
  <div id="main-l">
    <!-- �����������Ϣ -->
    <HN:HairShopEntryDescription ID="hairShopEntryDescription" runat="server" />
    <!-- �����������Ϣ���� -->
	  <div class="null-box"></div>
	<!-- ����ʦ�б� -->
      <HN:HairShopEngineerList ID="hairShopEngineerList" runat="server" />
    <!-- ����ʦ�б���� -->
    
      <div class="null-box"></div>
      <!-- ��Ʒ�б� -->
      <HN:HairShopWorkList ID="hairShopWorkList" runat="server" />
     <!-- ��Ʒ�б���� -->
	  <div class="null-box"></div>
      <div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="10" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="135" align="left" background="Theme/images/fair-mft08.gif" class="red14b">������ҵ�����</td>
            <td width="472" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="84" align="right" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft07.gif" width="3" height="29" /></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="5" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft10.gif" /></td>
            <td width="23" align="center" background="Theme/images/fair-mft12.gif"><img src="Theme/images/sg-meifa_02.gif" /></td>
            <td width="59" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c">��Ҫ����</td>
            <td width="14"</td>
            <td width="148" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c">
                &nbsp;</td>
            <td width="147" align="center" background="Theme/images/fair-mft12.gif">&nbsp;</td>
            <td width="52" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c">
                &nbsp;</td>
            <td width="160" align="center" background="Theme/images/fair-mft12.gif">&nbsp;</td>
            <td width="97" align="center" background="Theme/images/fair-mft12.gif" class="gray12-c">
                &nbsp;</td>
            <td width="10" align="right" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box">
            <asp:TextBox ID="TextBox1" CssClass ="pl-box"  TextMode="MultiLine" runat="server"></asp:TextBox></div>
		
		<div class="submit">
            <asp:ImageButton ID="btnComment" ImageUrl= "Theme/images/fair-submit.gif" 
                runat="server" onclick="btnComment_Click" />
            </div>
            <asp:Literal ID="UserComment" runat="server"></asp:Literal>
		</div>
		 </div>
  <div id="main-r"><table width="260" height="32" border="0" align="center" cellpadding="0" cellspacing="0" background="Theme/images/fair-09b.gif">
          <tr>
            <td width="32%" align="left" class="red14b">&nbsp;<a href="#" target="_blank">&nbsp;��ַλ��</a></td>
            <td width="46%" align="left" ><img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
            <td width="22%" align="left" ><a href="#" target="_blank"></a></td>
          </tr>
        </table>
      <div class="sitemap"><img src="Theme/images/fair-mft19.gif" /></div>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="32%" height="35" align="left" valign="middle" class="red14b">&nbsp;&nbsp;<a href="#" target="_blank">��ҪͶƱ</a></td>
                  <td width="48%" align="left"><span style="border-right:#ffffff 1px solid"><img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></span></td>
                  <td width="20%" align="left"><a href="#" target="_blank"></a></td>
                </tr>
                <tr>
                  <td colspan="3" align="center"><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
                </tr>
    </table>
			 
	    <!-- ͶƱ -->
	    <HN:HairShopVoteControl ID="hairShopVoteControl" runat="server" />
	    <!-- ͶƱ���� -->
			 
			 
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
            <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
          </tr>
        </table>
		<div id="container"></div>
		<div id="page1">
		<!-- ��������ʦ�б� -->
	    <HN:HotHairEngineerList ID="hotHairEngineerList" runat="server" />
	    <!-- ��������ʦ�б� -->
		</div>
		<div id="page2">
		<!-- �����Ż�ȯ�б� -->
	    <HN:HotCouponList ID="hotCouponList" runat="server" />
	    <!-- �����Ż�ȯ�б� -->
		</div>		
    </div> 	
	<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;�ܱ�������&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
	  <!-- �ܱ��������б� -->
	  <HN:SameHairShopList ID="sameHairShopList" runat="server" />
	  <!-- �ܱ��������б� -->
	</div>
	<!-- ������Ʒ�б� -->
	  <HN:NewWorkList ID="newWorkList" runat="server" />
	<!-- ������Ʒ�б� -->
<div class="main-r-box2">
	  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:20px">
        <tr>
          <td align="left" class="red14b">&nbsp;&nbsp;�������������Ļ���˭&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table><asp:Literal ID="UserBrow" runat="server"></asp:Literal>
	  
	  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="35%" align="left" class="gray12">&nbsp;<img src="Theme/images/sg-meifa_02.gif" width="5" height="9" />&nbsp;����<asp:Label
              ID="lblCaiCount" runat="server" Text="0"></asp:Label>��&nbsp;</td>
          <td width="65%" align="left" class="gray12"><asp:ImageButton ID="CaiBottom" 
                  runat="server" ImageUrl="Theme/images/fair-mft23.gif" width="59" height="19" onclick="CaiBottom_Click"
                               /></td>
        </tr>
      </table>
	  <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td height="30" align="left" valign="bottom" class="red14b">&nbsp;&nbsp;��������������ѻ������&nbsp;<img src="Theme/images/sg-meifa_35.gif" width="9" height="13" /></td>
        </tr>
        <tr>
          <td><img src="Theme/images/sg-meifa_46.gif" width="256" height="2" /></td>
        </tr>
      </table>
    <asp:Literal ID="HisBrow" runat="server"></asp:Literal>
</div>				  
    </div>	
    <div id="main-rr"></div>
    <div class="clear"></div>
	<div><img src="Theme/images/fair-mft15.gif" /></div>
</div>
<!--�������ݲ��ֽ��� -->
    </div>
</asp:Content>
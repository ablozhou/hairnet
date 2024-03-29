﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopListControl.ascx.cs" Inherits="Web.UserControls.HairShopListControl" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:UpdatePanel ID="updatePanel2" runat="server">
<ContentTemplate>
<div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#f7f7f7" ></td>
            <td width="15" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="138" align="left" background="Theme/images/fair-mft08.gif">共找到 <span class="red12"><asp:Label ID="lblHairShopCount" runat="server" Text="0"></asp:Label></span> 家美发厅</td>
            <td width="395" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="153" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft07.gif" width="3" height="7" />共 <asp:Label ID="lblPageCount" Text="1" runat="Server" Font-Bold="true"></asp:Label> 页 <asp:Label ID="lblFrontPage" runat="server"></asp:Label> <asp:Label ID="lblNextPage" runat="server"></asp:Label></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#f7f7f7" ></td>
            <td width="15" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft10.gif" /></td>
            <td width="71" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c">排序方式：</td>
            <td width="10" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c"><img src="Theme/images/fair-mft11.gif" /></td>
            <td width="86" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c"><div align="center"><asp:LinkButton ID="lBtnID1" runat="server" OnClick="lBtnID1_OnClick" Text="按时间排序"></asp:LinkButton></div></td>
            <td width="28" align="left" background="Theme/images/fair-mft12.gif"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><asp:ImageButton ID="btnID1" OnClick="btnID1_OnClick" runat="server" ImageUrl="../Theme/images/fxk-list-05.gif" /></div></td>
              </tr>
              
            </table></td>
            <td width="10" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft11.gif" /></td>
            <td width="93" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c"><div align="center"><asp:LinkButton ID="lBtnHit1" runat="server" OnClick="lBtnHit1_OnClick" Text="按热度排序"></asp:LinkButton></div></td>
            <td width="23" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><asp:ImageButton ID="btnHitNum1" OnClick="btnHitNum1_OnClick" runat="server" ImageUrl="../Theme/images/fxk-list-05.gif" /></div></td>
              </tr>
              
            </table></td>
            <td width="365" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft11.gif" /></td>
          </tr>
        </table>
		<div class="pinglun-box"></div>
		<asp:Label ID="lblDisplayText" runat="server"></asp:Label>
        <asp:Label ID="lblPageText" runat="server"></asp:Label>
		
<div class="clear"></div>
      </div>
      </ContentTemplate>
</asp:UpdatePanel>
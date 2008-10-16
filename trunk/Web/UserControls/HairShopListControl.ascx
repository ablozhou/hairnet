<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HairShopListControl.ascx.cs" Inherits="Web.UserControls.HairShopListControl" %>
<div class="pinglun">
        <table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
		  <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft06.gif" width="3" height="29" /></td>
            <td width="138" align="left" background="Theme/images/fair-mft08.gif">共找到 <span class="red12"><asp:Label ID="lblHairShopCount" runat="server"></asp:Label></span> 家美发厅</td>
            <td width="395" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft09.gif" width="23" height="7" /></td>
            <td width="153" align="left" background="Theme/images/fair-mft08.gif"><img src="Theme/images/fair-mft07.gif" width="3" height="7" />共 <asp:Label ID="lblPageCount" runat="Server" Font-Bold="true"></asp:Label> 页 <a href="#" class="gray12-d"><asp:Label ID="lblFrontPage" runat="server"></asp:Label></a> <a href="#" class="gray12-d"><asp:Label ID="lblNextPage" runat="server"></asp:Label></a></td>
          </tr>
        </table>
		<table width="704" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="3" bgcolor="#F7F7F7" ></td>
            <td width="15" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft10.gif" /></td>
            <td width="71" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c">排序方式：</td>
            <td width="10" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c"><img src="Theme/images/fair-mft11.gif" /></td>
            <td width="86" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c"><div align="center">按时间排序</div></td>
            <td width="28" align="left" background="Theme/images/fair-mft12.gif"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
              </tr>
            </table></td>
            <td width="10" align="left" background="Theme/images/fair-mft12.gif"><img src="Theme/images/fair-mft11.gif" /></td>
            <td width="93" align="right" background="Theme/images/fair-mft12.gif" class="gray12-c"><div align="center">按人气排序</div></td>
            <td width="23" align="left" background="Theme/images/fair-mft12.gif" class="gray12-c"><table width="21%" border="0" cellspacing="2" cellpadding="0">
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/images/mfs_list_up.gif" width="8" height="7" /></a></div></td>
              </tr>
              <tr>
                <td><div align="center"><a href="#"><img src="Theme/images/mfs_list_down.gif" width="8" height="7" /></a></div></td>
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
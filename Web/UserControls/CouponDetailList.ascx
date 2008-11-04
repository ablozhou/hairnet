<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CouponDetailList.ascx.cs" Inherits="Web.UserControls.CouponDetailList" %>

<script>
function check() {
var o = document.getElementsByName("list");
var l = "";
var k =0;
for (i = 0; i < o.length; i++) 
{
	if(o[i].checked)
	{
		k++;
		if(k==1)
		{
			l += "PrintCoupon.aspx?id="+o[i].value;
		}
		else
		{	
			l+=","+o[i].value;
		}
	}
}
if(k==0)
{
    alert('请先选择打印的优惠券');
}
else
{   
    window.open(l,"优惠券打印");
}
}
function copyToClipBoard(title,url){
				var clipBoardContent="";//初始清空
				clipBoardContent+=title;//写入Title
				clipBoardContent+=url;//换行，写入URL
				window.clipboardData.setData("Text",clipBoardContent);//写入ClipBoard
				alert("成功复制标题及链接,现在可以粘贴给好朋友了!");//弹出提示，如不需要可删除或屏蔽此行
			}
</script>
<div id="main-r">
   <table width="100%" height="34" border="0" cellpadding="0" cellspacing="0" background="Theme/images/fair-yhq-04.gif">
      <tr>
        <td width="22%" align="center" valign="middle"><input type="image" src="Theme/images/fair-yhq-09.gif" onClick="check()" style="width:111px;height:19px;" /></td>
        <td width="46%" align="center" valign="middle" class="gray12">优惠名称</td>
        <td width="32%" align="left" valign="middle" class="gray12">商圈</td>
      </tr>
    </table>
<div>
    <asp:Label ID="lbPageFirst" runat="server"></asp:Label>
    <asp:Label ID="lblDisplayText" runat="server"></asp:Label>
    <asp:Label ID="lblPageText" runat="server"></asp:Label>
</div>
</div>


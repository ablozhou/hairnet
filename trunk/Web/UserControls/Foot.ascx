<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Foot.ascx.cs" Inherits="Web.UserControls.Foot" %>
<table width="980" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="30" colspan="3" align="center" valign="middle" bgcolor="#c00014" class="end-white12"><a href="http://www.sg.com.cn/other2004/about.shtml" target="_blank">��������</a> | <a href="http://www.sg.com.cn/include/index_hezuo.shtml" target="_blank">�������</a> | <a href="http://www.sg.com.cn/jingpinmenhu/cpyc/index.shtml" target="_blank">��ƸӢ��</a> | <a href="http://www.sg.com.cn/other2004/guanggao.shtml" target="_blank">��濯��</a> | <a href="http://www.sg.com.cn/other2004/xunqiu.shtml" target="_blank">Ѱ�����</a> | <a href="http://www.sg.com.cn/other2004/yinsi.shtml" target="_blank">������˽Ȩ</a> | <a href="http://www.sg.com.cn/other2004/chanquan.shtml" target="_blank">���Ӱ�֪ʶ��Ȩ����</a> | <a href="http://www.sg.com.cn/other2004/xieyi.shtml" target="_blank">����Э��</a> | <a href="http://webmail.sg.com.cn/" target="_blank">��Ʒ����</a></td>
  </tr>
  <tr>
    <td width="209" height="70" bgcolor="#FFFFFF">&nbsp;</td>
    <td width="559" align="center" valign="middle" bgcolor="#FFFFFF" class="end-black12"> Copyright&copy;1996-2008 ������Ʒ׿Խ�Ƽ���չ���޹�˾��Ȩ���� δ����Ȩ��ֹ���ƻ�������<br />
      ��ICP���֤031001�š���澭Ӫ���֤ �������̹��ֵ�190��</td>
    <td width="212" align="left" valign="middle" bgcolor="#FFFFFF"><img src="Theme/images/sg-gongshang-biao.gif" width="34" height="43" /></td>
  </tr>
</table>
</body>
</html>
<script language="javascript">
var num=2; //�ܹ��м���С����
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
if(ii<2){
	ii++;
	showPage(curNum++);
	if(curNum>num) curNum=1;
}
}
timer1=setTimeout(autoTurn);
</script>
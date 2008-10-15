<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Foot.ascx.cs" Inherits="Web.UserControls.Foot" %>
<table width="980" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="30" colspan="3" align="center" valign="middle" bgcolor="#c00014" class="end-white12"><a href="http://www.sg.com.cn/other2004/about.shtml" target="_blank">关于我们</a> | <a href="http://www.sg.com.cn/include/index_hezuo.shtml" target="_blank">合作伙伴</a> | <a href="http://www.sg.com.cn/jingpinmenhu/cpyc/index.shtml" target="_blank">诚聘英才</a> | <a href="http://www.sg.com.cn/other2004/guanggao.shtml" target="_blank">广告刊例</a> | <a href="http://www.sg.com.cn/other2004/xunqiu.shtml" target="_blank">寻求合作</a> | <a href="http://www.sg.com.cn/other2004/yinsi.shtml" target="_blank">保护隐私权</a> | <a href="http://www.sg.com.cn/other2004/chanquan.shtml" target="_blank">电子版知识产权声明</a> | <a href="http://www.sg.com.cn/other2004/xieyi.shtml" target="_blank">服务协议</a> | <a href="http://webmail.sg.com.cn/" target="_blank">精品邮箱</a></td>
  </tr>
  <tr>
    <td width="209" height="70" bgcolor="#FFFFFF">&nbsp;</td>
    <td width="559" align="center" valign="middle" bgcolor="#FFFFFF" class="end-black12"> Copyright&copy;1996-2008 北京精品卓越科技发展有限公司版权所有 未经授权禁止复制或建立镜像<br />
      京ICP许可证031001号　广告经营许可证 京海工商广字第190号</td>
    <td width="212" align="left" valign="middle" bgcolor="#FFFFFF"><img src="Theme/images/sg-gongshang-biao.gif" width="34" height="43" /></td>
  </tr>
</table>
</body>
</html>
<script language="javascript">
var num=2; //总共有几个小窗口
var stopTime=100000000; //停留时间
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
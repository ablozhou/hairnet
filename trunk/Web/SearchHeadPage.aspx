<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHeadPage.aspx.cs" Inherits="Web.SearchHeadPage" %>
<%@ Register Src="UserControls/SearchHead.ascx" TagName="SearchHead" TagPrefix="HN" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="Theme/Style/daohang-end-08.css" rel="stylesheet" type="text/css" />
    <link href="Theme/Style/hair-main.css" rel="stylesheet" type="text/css" />
    <link href="Theme/Style/meifating.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Theme/js/chrome.js"></script>
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
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    <!-- sou head -->
    <HN:SearchHead ID="searchHead" runat="server" />
    <!-- sou head end -->
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeBehind="Store.aspx.vb" Inherits="Pages_Store_Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">







<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>به فروشگاه ایران ذهن خوش آمدید - MBTI</title>
<style type="text/css">


/* PAGE STYLE */
body {
      margin:24px;
      padding:0px;
      background:#00D744;
      color:#000000;
      min-width:748px;
      font-family:'Verdana', sans-serif;
      font-size:9pt;
      font-weight:500;
      line-height:12pt;
      text-decoration: none;	
}
table {
      font-family:'Verdana', sans-serif;
      font-size:9pt;
}
form {
      margin:0px;
}	
a {
      color: #1C543E; 
      text-decoration: underline;
}
a img{ border:none;}
hr {
      border:0;
      width:100%;
      color:#1AD129;
      background-color:#1AD129;
      height:1px;
      width:100%;
      margin:6px 0px 12px 0px;
}
#wrap {
      width:748px;
}
#rule {
      height:1px;
      background-color:#000000;
      width:100%;
      margin:6px 0px 12px 0px;
}
h2 {
      font-size:16px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
h3 {
      font-size:14px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
	
/* MAIN PAGE AREA */	
#mainwrap {
      float:right;
}
#main {
      width:530px;
      margin-bottom:19px;
      overflow:hidden;
}
div#header {
      background:#1AD129;
      padding:6px 24px 4px;
      margin:0;
      vertical-align:middle;
}
a#mainheadertitle {
      padding:0px;
      font-family:'Verdana', sans-serif;
      font-size:18pt;
      font-weight:normal;
      line-height:1.5em;
      color:#FFFFFF; 
      margin:0px;
      text-align:left;
      vertical-align:middle;
      text-decoration:none;
}
a#mainheadertitle:hover {
      text-decoration:underline;
}
td#mainheaderlogo {
      padding:5px;
}
img#mainlogo {
      padding-right:5px;
}
div#mainsubheader {
      background:#E3E3C1;
      padding:10px 24px;
      vertical-align:middle;
}
div#contentsubheader {
      width:482px;
      overflow:hidden;
}
div#subheaderlinks {
      float:right;
      text-align:right;
}
div#subheadertitle {
      font-size:12pt;
      font-weight:bold;
}
div#contenterror {
      background:#EFEFCC;
      padding:14px 24px;      
}
span.currentpage {
      font-weight:bold;
}

span.error {
      font-weight:bold;
}
	
/* SIDEBAR */
#sidebar {
      float:left;
      width:200px;
      overflow:hidden;
}
#sidebar ul {
      margin-bottom:0;
}
#sidebar h3, #sidebar p {
      padding:0 10px;
}

/* GENERAL SIDEBAR WIDGET STYLES */
ul#widget,ul.widget li.widget {
      margin:0;
      padding:0;
      list-style:none;
}
li.widget {
      float:left;
      width:200px;
      margin-bottom:19px;
}
ul#widget div {
      background:#EFEFCC;
}
ul#widget h3 {
      font-family:'Verdana', sans-serif;
      font-size: 10pt;
      font-weight: bold;
      color:#FFFFFF;
      margin:0px;
      padding:6px 15px 4px;
      text-align:left;
      background:#1AD129;
}
ul#widget p {
      font-family:'Verdana', sans-serif;
      font-size: 9pt;
      font-weight: normal;
      color:#000000;
      margin:0px;
      padding: 10px 15px 20px;
}

/* SEARCHBROWSE WIDGET */
div#searchbrowse {
      padding:14px;
}
div#searchbrowse div.indent {
      padding: 5px 0px 5px 15px;
}
select.searchwidget {
      width:173px;
      margin-bottom:6px;
}
input#searchwidgetkeywords {
      width:134px;
}
span#SearchAtAmazon {
      font-size: 8pt;
}
div#browsetitle {
      font-weight:bold;
      padding-bottom:7px;
}
span.selectedcategory {
      font-weight:bold;
}

/* LISTMANIA WIDGET */
div.listwidget {
      padding-bottom:16px;
}
ul.listmania {
      margin:0px;
      padding:0px;
      list-style:none;
}
ul.listmania li {
      margin:0px;
      padding:5px;
      padding-left:10px;
      list-style:none;
      text-align:center;
}
ul.listmania li.clsOdd,li.listimages {
      background-color:#F9F9D5;
}
ul.listmania li.clsEven {
      background-color:#EFEFCC;
}

img.listimage {
    display:block;
    margin-left:auto;
    margin-right:auto;
}

/* PRODUCTS WIDGETS */
div.productwidget {
      padding:0px;
      padding-bottom:16px;
}
div.productwidget .price {
      font-weight:bold;
}
table.sidebarproducts {
      font-family:'Verdana', sans-serif;
      font-size:9pt; 
      width:200px;
}
table.sidebarproducts td {
      padding:5px;
}
table.sidebarproducts td.image {
      vertical-align:top;
      width:75px;
}
table.sidebarproducts td.text {
      vertical-align:middle;
      width:115px;
}
table.sidebarproducts span.listtitle {
      font-weight:bold;
}
div.privacylink {
      padding: 2px 5px;
      font-size:7pt;
      text-align:center;
}

/* FOOTER */
div#footer {
      width:530px;
      margin-bottom:28px;
      color:#1AD129;
      border-top:1px solid #1AD129; 
}
div#footer p {
      padding:5px;
      margin:0;
}
div#leftfoot {
      float:left;
      width:430px;
}
div#rightfoot {
      float:right;
      width:100px;
      text-align:right;
}

/* WISHLIST WIDGET */
div#wishlist_page_link
{
    padding:7px 5px 5px;
}

/*Associate Provided CSS*/
/* PAGE STYLE */
body {
      margin:24px;
      padding:0px;
      background:#00D744;
      color:#000000;
      min-width:748px;
      font-family:'Tahoma', sans-serif;
      font-size:9pt;
      font-weight:500;
      line-height:12pt;
      text-decoration: none;	
}
table {
      font-family:'Tahoma', sans-serif;
      font-size:9pt;
}
form {
      margin:0px;
}	
a {
      color: #1C543E; 
      text-decoration: underline;
}
a img{ border:none;}
hr {
      border:0;
      width:100%;
      color:#1AD129;
      background-color:#1AD129;
      height:1px;
      width:100%;
      margin:6px 0px 12px 0px;
}
#wrap {
      width:748px;
}
#rule {
      height:1px;
      background-color:#000000;
      width:100%;
      margin:6px 0px 12px 0px;
}
h2 {
      font-size:16px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
h3 {
      font-size:14px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
	
/* MAIN PAGE AREA */	
#mainwrap {
      float:right;
}
#main {
      width:530px;
      margin-bottom:19px;
      overflow:hidden;
}
div#header {
      background:#1AD129;
      padding:6px 24px 4px;
      margin:0;
      vertical-align:middle;
}
a#mainheadertitle {
      padding:0px;
      font-family:'Tahoma', sans-serif;
      font-size:18pt;
      font-weight:normal;
      line-height:1.5em;
      color:#FFFFFF; 
      margin:0px;
      text-align:left;
      vertical-align:middle;
      text-decoration:none;
}
a#mainheadertitle:hover {
      text-decoration:underline;
}
td#mainheaderlogo {
      padding:5px;
}
img#mainlogo {
      padding-right:5px;
}
div#mainsubheader {
      background:#E3E3C1;
      padding:10px 24px;
      vertical-align:middle;
}
div#contentsubheader {
      width:482px;
      overflow:hidden;
}
div#subheaderlinks {
      float:right;
      text-align:right;
}
div#subheadertitle {
      font-size:12pt;
      font-weight:bold;
}
div#contenterror {
      background:#EFEFCC;
      padding:14px 24px;      
}
span.currentpage {
      font-weight:bold;
}

span.error {
      font-weight:bold;
}
	
/* SIDEBAR */
#sidebar {
      float:left;
      width:200px;
      overflow:hidden;
}
#sidebar ul {
      margin-bottom:0;
}
#sidebar h3, #sidebar p {
      padding:0 10px;
}

/* GENERAL SIDEBAR WIDGET STYLES */
ul#widget,ul.widget li.widget {
      margin:0;
      padding:0;
      list-style:none;
}
li.widget {
      float:left;
      width:200px;
      margin-bottom:19px;
}
ul#widget div {
      background:#EFEFCC;
}
ul#widget h3 {
      font-family:'Tahoma', sans-serif;
      font-size: 10pt;
      font-weight: bold;
      color:#FFFFFF;
      margin:0px;
      padding:6px 15px 4px;
      text-align:left;
      background:#1AD129;
}
ul#widget p {
      font-family:'Tahoma', sans-serif;
      font-size: 9pt;
      font-weight: normal;
      color:#000000;
      margin:0px;
      padding: 10px 15px 20px;
}

/* SEARCHBROWSE WIDGET */
div#searchbrowse {
      padding:14px;
}
div#searchbrowse div.indent {
      padding: 5px 0px 5px 15px;
}
select.searchwidget {
      width:173px;
      margin-bottom:6px;
}
input#searchwidgetkeywords {
      width:134px;
}
span#SearchAtAmazon {
      font-size: 8pt;
}
div#browsetitle {
      font-weight:bold;
      padding-bottom:7px;
}
span.selectedcategory {
      font-weight:bold;
}

/* LISTMANIA WIDGET */
div.listwidget {
      padding-bottom:16px;
}
ul.listmania {
      margin:0px;
      padding:0px;
      list-style:none;
}
ul.listmania li {
      margin:0px;
      padding:5px;
      padding-left:10px;
      list-style:none;
      text-align:center;
}
ul.listmania li.clsOdd,li.listimages {
      background-color:#F9F9D5;
}
ul.listmania li.clsEven {
      background-color:#EFEFCC;
}

img.listimage {
    display:block;
    margin-left:auto;
    margin-right:auto;
}

/* PRODUCTS WIDGETS */
div.productwidget {
      padding:0px;
      padding-bottom:16px;
}
div.productwidget .price {
      font-weight:bold;
}
table.sidebarproducts {
      font-family:'Tahoma', sans-serif;
      font-size:9pt; 
      width:200px;
}
table.sidebarproducts td {
      padding:5px;
}
table.sidebarproducts td.image {
      vertical-align:top;
      width:75px;
}
table.sidebarproducts td.text {
      vertical-align:middle;
      width:115px;
}
table.sidebarproducts span.listtitle {
      font-weight:bold;
}
div.privacylink {
      padding: 2px 5px;
      font-size:7pt;
      text-align:center;
}

/* FOOTER */
div#footer {
      width:530px;
      margin-bottom:28px;
      color:#1AD129;
      border-top:1px solid #1AD129; 
}
div#footer p {
      padding:5px;
      margin:0;
}
div#leftfoot {
      float:left;
      width:430px;
}
div#rightfoot {
      float:right;
      width:100px;
      text-align:right;
}

/* WISHLIST WIDGET */
div#wishlist_page_link
{
    padding:7px 5px 5px;
}

/*Associate Provided CSS*/
/* PAGE STYLE */
body {
      margin:24px;
      padding:0px;
      background:#00D744;
      color:#000000;
      min-width:748px;
      font-family:'Tahoma', sans-serif;
      font-size:9pt;
      font-weight:500;
      line-height:12pt;
      text-decoration: none;	
}
table {
      font-family:'Tahoma', sans-serif;
      font-size:9pt;
}
form {
      margin:0px;
}	
a {
      color: #1C543E; 
      text-decoration: underline;
}
a img{ border:none;}
hr {
      border:0;
      width:100%;
      color:#1AD129;
      background-color:#1AD129;
      height:1px;
      width:100%;
      margin:6px 0px 12px 0px;
}
#wrap {
      width:748px;
}
#rule {
      height:1px;
      background-color:#000000;
      width:100%;
      margin:6px 0px 12px 0px;
}
h2 {
      font-size:16px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
h3 {
      font-size:14px;
      font-weight:bold;
      margin:0px;
      padding:0px;
}
	
/* MAIN PAGE AREA */	
#mainwrap {
      float:right;
}
#main {
      width:530px;
      margin-bottom:19px;
      overflow:hidden;
}
div#header {
      background:#1AD129;
      padding:6px 24px 4px;
      margin:0;
      vertical-align:middle;
}
a#mainheadertitle {
      padding:0px;
      font-family:'Tahoma', sans-serif;
      font-size:18pt;
      font-weight:normal;
      line-height:1.5em;
      color:#FFFFFF; 
      margin:0px;
      text-align:left;
      vertical-align:middle;
      text-decoration:none;
}
a#mainheadertitle:hover {
      text-decoration:underline;
}
td#mainheaderlogo {
      padding:5px;
}
img#mainlogo {
      padding-right:5px;
}
div#mainsubheader {
      background:#E3E3C1;
      padding:10px 24px;
      vertical-align:middle;
}
div#contentsubheader {
      width:482px;
      overflow:hidden;
}
div#subheaderlinks {
      float:right;
      text-align:right;
}
div#subheadertitle {
      font-size:12pt;
      font-weight:bold;
}
div#contenterror {
      background:#EFEFCC;
      padding:14px 24px;      
}
span.currentpage {
      font-weight:bold;
}

span.error {
      font-weight:bold;
}
	
/* SIDEBAR */
#sidebar {
      float:left;
      width:200px;
      overflow:hidden;
}
#sidebar ul {
      margin-bottom:0;
}
#sidebar h3, #sidebar p {
      padding:0 10px;
}

/* GENERAL SIDEBAR WIDGET STYLES */
ul#widget,ul.widget li.widget {
      margin:0;
      padding:0;
      list-style:none;
}
li.widget {
      float:left;
      width:200px;
      margin-bottom:19px;
}
ul#widget div {
      background:#EFEFCC;
}
ul#widget h3 {
      font-family:'Tahoma', sans-serif;
      font-size: 10pt;
      font-weight: bold;
      color:#FFFFFF;
      margin:0px;
      padding:6px 15px 4px;
      text-align:left;
      background:#1AD129;
}
ul#widget p {
      font-family:'Tahoma', sans-serif;
      font-size: 9pt;
      font-weight: normal;
      color:#000000;
      margin:0px;
      padding: 10px 15px 20px;
}

/* SEARCHBROWSE WIDGET */
div#searchbrowse {
      padding:14px;
}
div#searchbrowse div.indent {
      padding: 5px 0px 5px 15px;
}
select.searchwidget {
      width:173px;
      margin-bottom:6px;
}
input#searchwidgetkeywords {
      width:134px;
}
span#SearchAtAmazon {
      font-size: 8pt;
}
div#browsetitle {
      font-weight:bold;
      padding-bottom:7px;
}
sp



div#featuredProducts {
      background:#EFEFCC;
      padding:14px 24px;
}
div#featuredProducts .price {
      font-weight:bold;
}
table.products {
      width:482px;
      font-family:'Verdana', sans-serif;
      font-size:9pt; 
}
table.products td {
	  width:33%;
      padding:5px;
}
table.products tr.pagination {
	  text-align:center;
}
table.products tr.imagerow td {
	  vertical-align:bottom;
}
table.products tr.textrow td {
	  vertical-align:top;
      padding-bottom:20px;
}

/*Associate Provided CSS*/

</style>
    <link rel="stylesheet" type="text/css" href="http://z-ecx.images-amazon.com/images/G/01/associates/astore/static-content/niftyCorners-1._V46787430_.css"/>

    <link rel="stylesheet" type="text/css" media="print" href="http://z-ecx.images-amazon.com/images/G/01/associates/astore/static-content/niftyPrint-1._V46788512_.css"/>
    <script type="text/javascript" src="http://z-ecx.images-amazon.com/images/G/01/associates/astore/static-content/nifty-1._V46788137_.js"></script>

<script type="text/javascript">
<!--
    function nifty() {
        if (!NiftyCheck()) {
            return;
        }

        Rounded("div#main", "top", "#00D744", "#1AD129");
        Rounded("div#main", "bottom", "#00D744", "#EFEFCC");
        Rounded("li.widget", "top", "#00D744", "#1AD129");
        Rounded("li.widget", "bottom", "#00D744", "#EFEFCC");
        Rounded("div#dynVariationSelector", "all", "#EFEFCC", "#E3E3C1");
    }

    function popUp(ref) {
        var strFeatures = "toolbar=no,status=no,menubar=no,location=no"
        strFeatures = strFeatures + ",scrollbars=yes,resizable=yes,height=500,width=500"
        newWin = window.open(ref, "TellObj", strFeatures);
        if (newWin != null) {
            newWin.opener = top;
        }
    }

    function search(form) {
        var sel = form.elements["node"].selectedIndex;
        if (sel == 0) {
            alert("Please select a search category.");
            return false;
        } else {
            return true;
        }
    }
// -->
</script>
</head>
  <body>

<div id="wrap">
 <div id="mainwrap">

  <div id="main">

    <div id="header">
      
<table>
<tr>
  <td id="mainheadertitle">
  <a href="/relerevi-20"><img src="http://www.iranzehn.com/Images/Iranzehn.png" id="mainlogo"/></a>
  </td>
  <td><a href="/relerevi-20" id="mainheadertitle">به فروشگاه ایران ذهن خوش آمدید</a></td>
</tr>
</table>

    </div>
    <div id="mainsubheader">
      
<div id="contentsubheader">
  <div id="subheaderlinks">
    <a href="/relerevi-20/cart"><img src="http://g-ecx.images-amazon.com/images/G/01/associates/storebuilder/btn_cart2._V46788370_.png" width="25" align="absmiddle" alt="Shopping Cart" name="pngImage" height="20" border="0" /></a>
    <a href="/relerevi-20/cart">Shopping Cart</a>
  </div>
  <div id="subheadertitle">MBTI</div>

</div>

    </div>
    <div id="content">
       


   <div id="featuredProducts">
	  <table class="products" cellspacing="0">
		<tr><td colspan="3">محصولات مربوط به آزمون MBTI</td></tr>
		<tr class="imagerow">
<td><a href="/relerevi-20/detail/014026941X"><img src="http://ecx.images-amazon.com/images/I/51rRT-8glmL._SL125_.jpg" alt="What Type Am I? Discover Who You Really Are"></a></td><td><a href="/relerevi-20/detail/0935652752"><img src="http://ecx.images-amazon.com/images/I/410G8KSHYTL._SL125_.jpg" alt="Ideas and Evidence: Critical Reflections on MBTI Theory and Practice"></a></td><td><a href="/relerevi-20/detail/0470343907"><img src="http://ecx.images-amazon.com/images/I/51nuXBurvOL._SL125_.jpg" alt="Essentials of Myers-Briggs Type Indicator Assessment (Essentials of Psychological Assessment)"></a></td>
</tr>

<tr class="textrow">
<td><a href="/relerevi-20/detail/014026941X">What Type Am I? Discover Who You Really Are</a>
<br> by <span class="by">Renee Baron</span>
<br>
<span class="price">$10.88</span></td><td><a href="/relerevi-20/detail/0935652752">Ideas and Evidence: Critical Reflections on...</a>
<br> by <span class="by">Rowan Bayne</span>
<br>
<span class="price">$18.95</span></td><td><a href="/relerevi-20/detail/0470343907">Essentials of Myers-Briggs Type Indicator A...</a>

<br> by <span class="by">Naomi L. Quenk</span>
<br>
<span class="price">$31.77</span></td>
</tr>
<tr class="imagerow">
<td><a href="/relerevi-20/detail/1935321021"><img src="http://ecx.images-amazon.com/images/I/21PyB7l%2BLPL._SL125_.jpg" alt="MBTI&reg; Introduction"></a></td><td><a href="/relerevi-20/detail/B00318D7CG"><img src="http://ecx.images-amazon.com/images/I/51yD8Qlsz4L._SL125_.jpg" alt="Reclaiming Your Life &quot;living with the long term effects of a concussion&quot;"></a></td><td><a href="/relerevi-20/detail/B003CDEOZ4"><img src="http://ecx.images-amazon.com/images/I/51e8hp5aZ8L._SL125_.jpg" alt="Leadershift : Using Social Styles to Be a Better Leader"></a></td>
</tr>
<tr class="textrow">
<td><a href="/relerevi-20/detail/1935321021">MBTI&reg; Introduction</a>
<br>

<span class="price"></span></td><td><a href="/relerevi-20/detail/B00318D7CG">Reclaiming Your Life "living with the long ...</a>
<br>
<span class="price">$19.99</span></td><td><a href="/relerevi-20/detail/B003CDEOZ4">Leadershift : Using Social Styles to Be a B...</a>
<br>
<span class="price">$99.00</span></td>
</tr>
<tr class="imagerow">
<td><a href="/relerevi-20/detail/1935321080"><img src="http://ecx.images-amazon.com/images/I/51rsdax53mL._SL125_.jpg" alt="Type Training Workshop (Presentation Slides)"></a></td>
</tr>
<tr class="textrow">
<td><a href="/relerevi-20/detail/1935321080">Type Training Workshop (Presentation Slides)</a>
<br>

<span class="price"></span></td>
</tr>
<tr class="pagination">
<td colspan="3"></td>
</tr>

	  </table>
    </div>

    </div>
  </div>

  <div id="footer">

   <p> </p>
     <a href="/relerevi-20">به فروشگاه ایران ذهن خوش آمدید</a>
     | <a href="/relerevi-20/cart">Shopping Cart</a>
     | 
<a href="http://www.iranzehn.com" target="_top" rel="nofollow">ایران ذهن</a>

     <br/>&nbsp;

 
  <p> </p>
 </div>
</div>

  <div id="sidebar">
    <ul id="widget">
      
<li class="widget">

  <h3>Browse by Category</h3>

  <div id="searchbrowse">
  <div id="homelink"><a href="http://www.amazon.com?_encoding=UTF8&tag=relerevi-20&linkCode=sb1&camp=212353&creative=380557" target="_blank"><img src="http://g-ecx.images-amazon.com/images/G/01/associates/network/amazon-logos/powered-by-amazon-b._V31521270_.png" width="87" alt="Powered by Amazon.com" name="pngImage" height="25" border="0" /></a></div>
  <hr>


<span class="selectedcategory"><a href="/relerevi-20?_encoding=UTF8&node=1">MBTI</a></span><br/><a href="/relerevi-20?_encoding=UTF8&node=2">Socionics</a><br/>

<hr/>
<a href="http://www.iranzehn.com" target="_top" rel="nofollow">ایران ذهن</a>


</div>
</li>

<li class="widget">
<h3>Similar Items</h3>
<div class="productwidget">
<table class="sidebarproducts" cellspacing="0">
<tr>
<td class="image"><a href="/relerevi-20/detail/0440509289"><img src="http://ecx.images-amazon.com/images/I/51ioDy2%2BJhL._SL75_.jpg" alt="Type Talk at Work (Revised): How the 16 Personality Types Determine Your Success on the Job" class="sidebarproduct"></a></td><td class="text"><a href="/relerevi-20/detail/0440509289">Type Talk at Work (Revised): How...</a>
<br> by <span class="by">Otto Kroeger</span>
<br>
<span class="price">$11.23</span></td>

</tr>
<tr>
<td class="image"><a href="/relerevi-20/detail/0470248653"><img src="http://ecx.images-amazon.com/images/I/418Hz0sqVKL._SL75_.jpg" alt="Emotional Intelligence Skills Assessment (EISA) Self" class="sidebarproduct"></a></td><td class="text"><a href="/relerevi-20/detail/0470248653">Emotional Intelligence Skills As...</a>
<br> by <span class="by">Steven J. Stein</span>
<br>
<span class="price">$20.00</span></td>
</tr>
<tr>
<td class="image"><a href="/relerevi-20/detail/0787967955"><img src="http://ecx.images-amazon.com/images/I/41T8JXDKP2L._SL75_.jpg" alt="The Leadership Practices Inventory (LPI): Self Instructions" class="sidebarproduct"></a></td><td class="text"><a href="/relerevi-20/detail/0787967955">The Leadership Practices Invento...</a>
<br> by <span class="by">James M. Kouzes</span>

<br>
<span class="price">$11.78</span></td>
</tr>
</table>

</div>
</li>

    </ul>
  </div>
</div>
</body>
<!--[if lt IE 7]>
<script defer type="text/javascript">


var version = parseFloat(navigator.appVersion.split('MSIE')[1])

if ((version >= 5.5) && (document.body.filters)) 
{   
   var pngImages = document.getElementsByName('pngImage')
   for (var i=0; i < pngImages.length; i++)
   {
     var img = pngImages[i];
     if ((img.width) && (img.width > 0) &&
         (img.height) && (img.height > 0)) {
       var imgSrc = img.src;
       img.style.width = img.width + 'px';
       img.style.height = img.height + 'px';
       img.src = 'http://g-ecx.images-amazon.com/images/G/01/associates/transparent-pixel._V192207698_.gif'
       img.style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader("
         + "src='" + imgSrc + "', sizingMethod='scale')"

     }
   }
}

</script>
<![endif]-->
</html>


</asp:Content>


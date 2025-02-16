
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);

function MM_showHideLayers() { //v6.0
  var i,p,v,obj,args=MM_showHideLayers.arguments;
  for (i=0; i<(args.length-2); i+=3) if ((obj=MM_findObj(args[i]))!=null) { v=args[i+2];
    if (obj.style) { obj=obj.style; v=(v=='show')?'visible':(v=='hide')?'hidden':v; }
    obj.visibility=v; }
}

var old='';
function menu(name){

	submenu=eval("submenu_prodeval"+name+".style");

    if(old!=submenu)
    {
        if(old!='')
        {
            old.display='none';
        }
        submenu.display='block';
        old=submenu;
    }
    else
    {
        submenu.display='none';
        old='';
    }
}

function isEmail(str) {
  // regular expression 지원 여부 점검
  var supported = 0;
  if (window.RegExp) {
    var tempStr = "a";
    var tempReg = new RegExp(tempStr);
    if (tempReg.test(tempStr)) supported = 1;
  }
  if (!supported) 
    return (str.indexOf(".") > 2) && (str.indexOf("@") > 0);
  var r1 = new RegExp("(@.*@)|(\\.\\.)|(@\\.)|(^\\.)");
  var r2 = new RegExp("^.+\\@(\\[?)[a-zA-Z0-9\\-\\.]+\\.([a-zA-Z]{2,3}|[0-9]{1,3})(\\]?)$");
  return (!r1.test(str) && r2.test(str));
}

function trim(str) {
	var space = " ";
	var tab = "	";
	var re_space = new RegExp(/ /g);
	var re_tab = new RegExp(/	/g);

	if (str.replace(re_space, "").replace(re_tab, "") == "")
		return "";

	if (str.substr(0, 1) == space || str.substr(0, 1) == tab) {
		while (true) {
			if (str.substr(0, 1) == space || str.substr(0, 1) == tab)
				str = str.substr(1);
			else
				break;
		}
	}

	if (str.substr(str.length - 1, 1) == space || str.substr(str.length - 1, 1) == tab) {
		while (true) {
			if (str.substr(str.length - 1, 1) == space || str.substr(str.length - 1, 1) == tab)
				str = str.substr(0, str.length - 1);
			else
				break;
		}
	}

	return str;
}

function isNumeric(str) {
	var str1 = trim(str);

	if (str1 != "" && str1 != null && str1 != undefined && !isNaN(str1) && str1.indexOf(".") < 0) {
		return true;
	}
	else {
		return false;
	}
}

// 주민등록번호가 올바른지 판별하는 함수
function isJuminNumValid(jumin_num) {
	if (isNaN(jumin_num) || jumin_num.indexOf(".") != -1) {
		return false;
	}
	
	strKeyValue = new String("234567892345");
	strJuminNum = new String(jumin_num);
	
	DigitSum = 0;
	for (i=0; i<=11; i++)
		DigitSum = DigitSum + parseInt(strJuminNum.substring(i, i+1)) * parseInt(strKeyValue.substring(i, i+1));
	
	i = 1;
	
	while((i * 11) <= DigitSum) {
		i = i + 1;
	}
	
	CheckDigit = ((i * 11) - DigitSum) % 10;
	
	if (CheckDigit == strJuminNum.substring(12, 13))
		return true;
	else
		return false;
}

	function winFileUpload(fileLoc, rtnMethod)
	{
		var win = window.open("/pop/pop_file.asp?fileLoc=" + fileLoc + "&rtnMethod=" + rtnMethod, "winFileUpload", "width=352, height=183");
		win.focus();
	}

	function winFileDownload(idx, filepath, filename, boardname)
	{
		location.href = "/pop/filedownload.asp?idx=" + idx + "&boardname=" + boardname + "&filepath=" + filepath + "&filename=\\" + filename;
	}

	function winEdumap()
	{
		var win = window.open("/pop/edu_map.asp", "winEdumap", "width=558, height=647");
	}
	
	
	function goSelectedLink(thisURL) {
	if(thisURL != null && thisURL != "") {
		window.open(thisURL, "", "");
		return;
	}
}

	function downLogincheck()
	{
		alert('로그인후 사용하실수 있습니다.'); 
		location.href = '/member/login.asp?ReturnURL=' + location.href;
	}
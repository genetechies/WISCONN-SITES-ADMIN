/*
 * The author of the following code: Michael Xu
 * Blog://miqi2214.cnblogs.com
 * Date: 2009-4
*/ 

//------------start------------------------------------------------
//Function method : judge className、add className、delete className
//This part of Code from the network
//-----------------------------------------------------------------

function ctrlClass(){}
ctrlClass.hasClass = function(elem, className)
{
    if (!elem) return;
    var elemClassName = elem.className;
    if (elemClassName.length == 0) return false;
    //用正则表达式判断多个class之间是否存在真正的class（前后空格的处理）
    if (elemClassName == className || elemClassName.match(new RegExp("(^|\\s)" + className + "(\\s|$)")))
    	return true;
    return false;
}

ctrlClass.addClass = function(elem, className)
{
    if(!elem) return;
    var elemClassName = elem.className;
    if(elemClassName.length == 0){
        elem.className = elemClassName;
        return;
    }
    if(elemClassName == className || elemClassName.match(new RegExp("(^|\\s)" + className + "(\\s|$)")))
        return;
    elem.className = elemClassName + " " + className;
}

ctrlClass.removeClass = function(elem, className)
{
    if(!elem) return;
    var elemClassName = elem.className;
    if(elemClassName.length == 0) return;
    if(elemClassName == className){
        elem.className = "";
        return;
    }
    if (elemClassName.match(new RegExp("(^|\\s)" + className + "(\\s|$)")))
        elem.className = elemClassName.replace((new RegExp("(^|\\s)" + className + "(\\s|$)"))," ");
}

//-------------------------------------
//判断样式className、增加class、删除class
//----------------end------------------

var getId = function(id){
	return "string" ==typeof id?document.getElementById(id):id;
};
function addEventHandler(oTarget,sEventType,fnHandler){
	if(oTarget.addEventListener){
		oTarget.addEventListener(sEventType,fnHandler,false);
	}else if(oTarget.attachEvent){
		oTarget.attachEvent("on"+sEventType,fnHandler);
	}else{
		oTarget["on"+sEventType] = fnHandler;
	}
};
var Class = {
	create:function(){
		return function(){
			this.initialize.apply(this, arguments);
		}
	}
};
Object.extend = function(destination,source){
	for(var property in source){
		destination[property]=source[property];
	}
	return destination;
};

var tabScroll = Class.create();
tabScroll.prototype = {
	initialize:function(box,scrol,leftBtn,rightBtn,options){
		var oBox = getId(box), oScrol = getId(scrol), oCtrlL = getId(leftBtn), oCtrlR = getId(rightBtn), oThis = this;

		this.moveEvent = null;
		this.scrollDiv = oScrol;
		this.oCtrlL = oCtrlL;
		this.oCtrlR = oCtrlR;
		this.moveLock = false;

		oScrol.style.position = "absolute";
		oScrol.style.left = 0 + "px";
		oScrol.style.width = oScrol.offsetWidth + "px";
		
		//合并配置参数
		this.setOptions(options);
		//实际列表宽度减去外部容器宽度，得到移动偏移量宽度
		this.offset = oScrol.clientWidth - oBox.clientWidth;
		
		this.leftAct = this.options.leftAct;
		this.leftEnd = this.options.leftEnd;
		this.rightAct = this.options.rightAct;
		this.rightEnd = this.options.rightEnd;
		//alert(oBox.offsetWidth + "----"+ oScrol.offsetWidth);
		//初始化按钮样式为灰
		if(oBox.offsetWidth >= oScrol.offsetWidth){
			ctrlClass.addClass(oCtrlL,this.leftEnd);
			ctrlClass.addClass(oCtrlR,this.rightEnd);
			return;
		}else{
			ctrlClass.addClass(oCtrlL,this.leftEnd);
		}
		
		this.step = Math.abs(this.options.step);
		this.speed= Math.abs(this.options.speed);
		addEventHandler(oCtrlL, "mouseover",function(){ctrlClass.addClass(oCtrlL, oThis.leftAct);});
		addEventHandler(oCtrlL, "mousedown", function() {oThis.goLeft(); ctrlClass.addClass(oCtrlL, oThis.leftAct); });
	    addEventHandler(oCtrlL, "mouseout", function() { oThis.stopFun(); ctrlClass.removeClass(oCtrlL, oThis.leftAct); });
	    addEventHandler(oCtrlL, "mouseup", function() { oThis.stopFun(); ctrlClass.removeClass(oCtrlL, oThis.leftAct); });
		
		addEventHandler(oCtrlR, "mouseover", function(){ctrlClass.addClass(oCtrlR, oThis.rightAct)});
		addEventHandler(oCtrlR, "mousedown", function() {oThis.goRight(); ctrlClass.addClass(oCtrlR, oThis.rightAct); });
	    addEventHandler(oCtrlR, "mouseout", function() { oThis.stopFun(); ctrlClass.removeClass(oCtrlR, oThis.rightAct); });
	    addEventHandler(oCtrlR, "mouseup", function() { oThis.stopFun(); ctrlClass.removeClass(oCtrlR, oThis.rightAct); });
	},
	setOptions:function(options){
		this.options={step:5, speed:30, leftAct:"leftAct", leftEnd:"leftEnd", rightAct:"rightAct", rightEnd:"rightEnd"};
		Object.extend(this.options,options||{});
	},
	goLeft:function(){
		this.moveLock = true;
		var oThis = this;
		this.moveEvent = window.setInterval(function(){oThis.goRightScroll();}, oThis.speed);

	},
	goRight:function(){
				this.moveLock = true;
		var oThis = this;
		this.moveEvent = window.setInterval(function(){oThis.goLeftScroll();}, oThis.speed);
	},
	goLeftScroll:function(){
		var iWidth = parseInt(this.scrollDiv.style.left);
		//当菜单的左坐标绝对值小于等于偏移宽度（由菜单总宽度减去外部容器宽度得到，该值则为移动的路程值）
		if(Math.abs(iWidth) <= this.offset){
			//菜单左坐标在当前值基础上减去预设的步长值
			this.scrollDiv.style.left = iWidth - this.step + "px";
			//因为移动已经开始，检测到右侧按钮如果会灰色，则修改样式为激活
			if(ctrlClass.hasClass(this.oCtrlL,this.leftEnd))
				ctrlClass.removeClass(this.oCtrlL,this.leftEnd);
		}else if(Math.abs(iWidth) > this.offset){
			ctrlClass.addClass(this.oCtrlR,this.rightEnd);
			return;
		}
	},
	goRightScroll:function(){
		var iWidth = parseInt(this.scrollDiv.style.left);
		if(iWidth < 0){
			this.scrollDiv.style.left = iWidth + this.step + "px";
			ctrlClass.removeClass(this.oCtrlR,this.rightEnd);
		}else if(iWidth ==0){
			ctrlClass.addClass(this.oCtrlL,this.leftEnd);
			return;
		}
	},
	stopFun:function(){
		if(this.moveLock == false) return;
		clearInterval(this.moveEvent);
	}
};

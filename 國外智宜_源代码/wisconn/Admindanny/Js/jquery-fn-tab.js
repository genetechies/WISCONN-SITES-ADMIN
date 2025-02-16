/* jquery-fn-accordion v1.0
 * Based on jQuery JavaScript Library v1.3
 * http://jquery.com/
 *
 * The author of the following code: Michael Xu
 * Blog://miqi2214.cnblogs.com
 * Date: 2009-4-10
*/ 

var j = jQuery.noConflict();

//参数说明：
//tabList:包裹选项卡的父级层
//tabTxt :包裹内容层的父级层
//options.currentTab:激活选项卡的序列号
//options.defaultClass:当前选项卡激活状态样式名，默认名字为“Current”
j.fn.tabs = function(tabList,tabTxt,options){
	var _tabList = j(this).find(tabList);
	var _tabTxt = j(this).find(tabTxt);
	
	//为了简化操作，强制规定选项卡必须用li标签实现
	var tabListLi = _tabList.find("li");
	var defaults = {currentTab:0,defaultClass:"current"};
	var o = j.extend({},defaults,options);
	_tabList.find("li:eq("+o.currentTab+")").addClass(o.defaultClass);
	
	//强制规定内容层必须以div来实现
	_tabTxt.children("div").each(function(i){
		j(this).attr("id","div"+i);						  
	}).eq(o.currentTab).css({"display":"block"});
	
	tabListLi.each(
		function(i){
			j(tabListLi[i]).click(
				function(){
					if(j(this).className != o.defaultClass)
					{
						j(this).addClass(o.defaultClass).siblings().removeClass(o.defaultClass);
					}
					_tabTxt.children("div").eq(i).css({"display":"block"}).siblings().css({"display":"none"});
				}
			)
		}
	);
	return this;
}
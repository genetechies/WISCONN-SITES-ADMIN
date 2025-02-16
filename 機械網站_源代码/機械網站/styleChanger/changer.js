/* Style Changer */


jQuery(document).ready(function(){

	/* Color Scheme */
	jQuery('#stlChanger .hdrStBgs .hdrCols span').click(function(){
		var hdrCol = jQuery(this).attr('title');
		
		jQuery('#stlChanger .hdrStBgs .hdrCols span').removeClass('current');
		jQuery(this).addClass('current');
		
		jQuery('#stlChanger').find('#cFontWColor1').css({backgroundColor:'#' + hdrCol});
			jQuery('#cFontStyleWColor1').text('a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor2').text('.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor3').text('.cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {background-color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor4').text('input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {border-color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor5').text('.pricingtable .price, .color2 {color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor6').text('span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {background-color:#' + hdrCol + ';}');
			jQuery('#cFontStyleWColor7').text('code {border-top-color:#' + hdrCol + ';}');
		return false;
	});
	
	/* Color Scheme */
	jQuery('#stlChanger #cFontWColor1').parent('a').ColorPicker({
		onChange:function(hsb, hex, rgb){
			jQuery('#stlChanger').find('#cFontWColor1').css({backgroundColor:'#' + hex});
			jQuery('#cFontStyleWColor1').text('a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor2').text('.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor3').text('.cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {background-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor4').text('input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {border-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor5').text('.pricingtable .price, .color2 {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor6').text('span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {background-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor7').text('code {border-top-color:#' + hex + ';}');
		},
		onSubmit:function(hsb, hex, rgb, el){
			jQuery('#stlChanger').find('#cFontWColor1').css({backgroundColor:'#' + hex});
			jQuery('#cFontStyleWColor1').text('a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor2').text('.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor3').text('.cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {background-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor4').text('input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {border-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor5').text('.pricingtable .price, .color2 {color:#' + hex + ';}');
			jQuery('#cFontStyleWColor6').text('span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {background-color:#' + hex + ';}');
			jQuery('#cFontStyleWColor7').text('code {border-top-color:#' + hex + ';}');
			jQuery(el).find('#cFontWColor1').css({backgroundColor:'#' + hex});
			jQuery(el).find('#cFontWColor1').attr({title:hex});
			jQuery(el).ColorPickerHide();
		},
		onBeforeShow:function(){
			jQuery(this).ColorPickerSetColor(jQuery('#stlChanger').find('#cFontWColor1').attr('title'));
		}
	});

	/* Background Color */
	jQuery('#stlChanger #cFontWColor8').parent('a').ColorPicker({
		onChange:function(hsb, hex, rgb){
			jQuery('#stlChanger').find('#cFontWColor8').css({backgroundColor:'#' + hex});
			jQuery('#cFontStyleWColor8').text('body {background:#' + hex + ';}');
		},
		onSubmit:function(hsb, hex, rgb, el){
			jQuery('#cFontStyleWColor8').text('body {background:#' + hex + ';}');
			jQuery(el).find('#cFontWColor8').css({background:'#' + hex});
			jQuery(el).find('#cFontWColor8').attr({title:hex});
			jQuery(el).ColorPickerHide();
		},
		onBeforeShow:function(){
			jQuery(this).ColorPickerSetColor(jQuery('#stlChanger').find('#cFontWColor8').attr('title'));
		}
	});

	
	if (jQuery(window).height() < 750) {
		jQuery('#stlChanger').css( { 
			position : 'absolute' 
		} );
	}
	
	
	/* Style Changer Autohide */
	jQuery('.chBut').parent().delay(1000).animate({left:'-120px'}, 500, function(){
		jQuery(this).find('.chBut').next('.chBody').css({display:'none'});
		jQuery(this).find('.chBut').addClass('closed');
	}); 
	
	
	/* Style Changer Toggle */
	jQuery('.chBut').click(function(){
		if (jQuery(this).hasClass('closed')){
			jQuery(this).next('.chBody').css({display:'block'}).parent().animate({left:0}, 500, function(){
				jQuery(this).find('.chBut').removeClass('closed');
			});
		} else {
			jQuery(this).parent().animate({left:'-120px'}, 500, function(){
				jQuery(this).find('.chBut').next('.chBody').css({display:'none'});
				jQuery(this).find('.chBut').addClass('closed');
			});
		}
		
		return false;
	});
	

	jQuery('#stlChanger .stBgs a').click(function () { 
		var img = new Image(), 
			bgImg = jQuery(this), 
			stCHLoader = jQuery('#stlChanger .stCHLoader'), 
			bgBgCol = jQuery('body').css('background-color'), 
			bgBgImg = bgImg.attr('href');
		
		if (stCHLoader.is(':visible')) {
			return false;
		}
		
		stCHLoader.fadeIn('fast');
		
		jQuery(img).load(function () { 
			jQuery('#stlChanger .stBgs a').removeClass('current');
			bgImg.addClass('current');
			
			jQuery('body').css( { 
				background : 'url(' + bgBgImg + ')' 
			} );
			
			if (bgImg.hasClass('bg_t')) {
				jQuery('body').css( { 
					backgroundColor : bgBgCol, 
					backgroundRepeat : 'repeat', 
					backgroundPosition : '50% 0', 
					backgroundAttachment : 'scroll' 
				} );
			} else {
				jQuery('body').css( { 
					backgroundColor : bgBgCol, 
					backgroundRepeat : 'repeat', 
					backgroundPosition : '50% 0', 
					backgroundAttachment : 'fixed' 
				} );
			}
			
			stCHLoader.fadeOut('fast');
		} ).attr( { 
			src : bgBgImg 
		} );
		
		return false;
	} );
	
	
	/* Style Changer Reset Change */
	jQuery('#styleReset').click(function(){
		jQuery('#cFontStyleWColor1').text('a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:rgba(255, 255, 255, .4);}');
		jQuery('#cFontStyleWColor2').text('.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#fff4c1;}');
		jQuery('#cFontStyleWColor3').text('.cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {background-color:#fff4c1;}');
		jQuery('#cFontStyleWColor4').text('input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {border-color:#fff4c1;}');
		jQuery('#cFontStyleWColor5').text('.pricingtable .price, .color2 {color:#f5a615;}');
		jQuery('#cFontStyleWColor6').text('span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {background-color:#f5a615;}');
		jQuery('#cFontStyleWColor7').text('code {border-top-color:#f5a615;}');
		jQuery('body').removeAttr('style');
		jQuery('#stlChanger .stBgs a').removeClass('current');
		jQuery('#stlChanger .stBgs a:first-child').addClass('current');
		jQuery('#stlChanger .hdrStBgs .hdrCols span').removeClass('current');
		jQuery('#stlChanger .hdrStBgs .hdrCols span:first-child').addClass('current');
		return false;
	});
	
	
	/* Window Resize Function */
	jQuery(window).resize(function(){
		if (jQuery(window).height() < 750){
			jQuery('#stlChanger').css({position:'absolute'});
		} else {
			jQuery('#stlChanger').css({position:'fixed'});
		}
	});
	
});

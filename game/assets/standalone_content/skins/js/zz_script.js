document.onkeydown = checkKey;

function checkKey(e) {
    e = e || window.event;
    if (e.keyCode == '49') {
      $("#qsp-click-action-0").click();
    }
    else if (e.keyCode == '50') {
      $("#qsp-click-action-1").click();
    }
    else if (e.keyCode == '51') {
      $("#qsp-click-action-2").click();
    }
    else if (e.keyCode == '52') {
      $("#qsp-click-action-3").click();
    }
	else if (e.keyCode == '53') {
      $("#qsp-click-action-4").click();
    }
	else if (e.keyCode == '54') {
      $("#qsp-click-action-5").click();
    }
	else if (e.keyCode == '55') {
      $("#qsp-click-action-6").click();
    }
	else if (e.keyCode == '56') {
      $("#qsp-click-action-7").click();
    }
	else if (e.keyCode == '57') {
      $("#qsp-click-action-8").click();
    }
	else if (e.keyCode == '32') {
      $("#qsp-click-action-0").click();
    }
	else if (e.keyCode == '97') {
      $("#qsp-click-action-0").click();
    }
	else if (e.keyCode == '98') {
      $("#qsp-click-action-1").click();
    }
	else if (e.keyCode == '99') {
      $("#qsp-click-action-2").click();
    }
	else if (e.keyCode == '100') {
      $("#qsp-click-action-3").click();
    }
	else if (e.keyCode == '101') {
      $("#qsp-click-action-4").click();
    }
	else if (e.keyCode == '102') {
      $("#qsp-click-action-5").click();
    }
	else if (e.keyCode == '103') {
      $("#qsp-click-action-6").click();
    }
	else if (e.keyCode == '104') {
      $("#qsp-click-action-7").click();
    }
	else if (e.keyCode == '105') {
      $("#qsp-click-action-8").click();
    }
	else if (e.keyCode == '116') {
	  QspLib.saveSlotSelected(19,0);
	  showMessage('<strong>Quicksave!</strong>','');
    }
	else if (e.keyCode == '119') {
	  QspLib.saveSlotSelected(19,1);
	  showMessage('<strong>Quickload!</strong>','');
    }
}

function resizer() {
	if ($("#skin-right-column").css('display') == 'none') {
		$("#skin-left-column").css("width","100%");
	} else {
		var width = $(document).width() - 300;
		$("#skin-left-column").css("width",width+"px");
		// фикс для #qsp-scroller-main
		$("#qsp-scroller-main").css("width",width+"px");
	}
	
	// высота картинок для маленьких экранов
	var height = $(document).height();
	if ( height < 780 ){
		$("#content_image img").css("height",(height-200)+"px");
		// название локации надо скрыть
		$("#content_header").css("display","none");
	}

	$('.tip').bind('mouseover', function(event) {
		var tip = $(this).attr('title');
		
		if (tip == '') return;

		var x = event.clientX + 10;
		var y = event.clientY + 10;
		var maxWidth = $( document ).width();

		$('#tooltip').html(tip);
		
		var width = $('#tooltip').width();
		if (x + width + 20 >= maxWidth) x -= width + 20;
		
		$('#tooltip').css('display', 'block');
		$('#tooltip').css('top', y+'px');
		$('#tooltip').css('left', x+'px');
	});
	
	$('.tip').bind('mouseleave', function() {
		$('#tooltip').html('');
		$('#tooltip').css('display', 'none');
	});
	// переразмеривание блока действий
	//height = 
	var acts = $( "#qsp-acts" );
	var position = acts.position();
	var acts_h = height - position.top;
	$('#qsp-acts').css('height',acts_h+'px');
}

function getHeroImage(tabID, path, key) {
	// формируем id блоков
	var parentID = key + "_container";
	var tabberID = key + "_tabber";
	var placerID = key + "_photo";
	
	// убираем активные табы
	$("#" + parentID + " .tab_header_small_selected").removeClass("tab_header_small_selected").addClass("tab_header_small");
	
	// ставим новый активный таб
	var tabber = $("#"+tabberID).children()[tabID];
	tabber.className = "tab_header_small_selected";
	
	// загружаем новую картинку
	$("#"+placerID).html("<img src='"+path+"'>");
	return false;
}

var messageQueue = []
function showAnimation(text, image) {
   var image_result = (image != '') ? '<img src="' + image + '">' : ''
   var div = $('<div/>', {
           html: '<p>' + text + image_result + '</p>'
       })
       .css({
           position: 'fixed',
           left: '-302px'
       })
       .appendTo($('#message_box'))
       .animate({
           left: '0px'
       }, 500)
       .delay(1000)
       .animate({
           left: '-302px'
       }, 500, function() {
           div.remove()
       });
};

function showMessage(text, image) {
   obj = {
       text: text,
       image: image
   }
   messageQueue.push(obj)
   $.each(messageQueue, function(i, v) {
       setTimeout(function() {
           showAnimation(v.text, v.image);
           messageQueue.pop()
       }, i * 2000);
   });
};

function toggleView(divID) {
	$('#'+divID).slideToggle('slow');
}

function showAltMenu(event) {
	toggleView('system-menu-alternative');
	setTimeout(function(){
		toggleView('system-menu-alternative');
	}, 3000);
}

function setBodyColors(backColor, foreColor) {
	$('body').css('background',backColor);
	if( foreColor != '') {
		$("body").css("color",foreColor);
	}
}

function resizeUIMap() {
	var map = $('#qsp-mapbox');
	if(map.hasClass('selected') == false) {
		map.css('borderRadius','0');
		map.animate({width: '900px'}, 'fast');
		map.animate({height: '600px'}, 'fast');
		map.addClass('selected');
		$('.poi').css('display','block');
		map.attr('title','');
	} else {
		map.removeClass('selected');
		map.animate({height: '40px'}, 'fast');
		map.animate({width: '40px'}, 'fast');
		map.css('borderRadius','20px');
		$('.poi').css('display','none');
	}
}

function showPoi() {
	$('.poi').css('display','block');
}

function clearPoiTip() {
	$('#tooltip').css('display','none');
}

function setLocTab(tabID) {
	// убираем активные табы
	$('#loc_tabber .tab_header_small_selected').removeClass('tab_header_small_selected').addClass('tab_header_small');
	// ставим новый активный таб
	var tabber = $('#loc_tabber').children()[tabID];
	tabber.className = 'tab_header_small_selected';
	// устанавливаем видимый блок
	for (i = 0; i <= 6; i++) {
		if ( $('#loc_desc'+i).css('display') != 'none' ) {
			$('#loc_desc'+i).css('display','none');
		}
	}
	$('#loc_desc'+tabID).css('display','block');
}

function setFontSize(size) {
	$('#qsp-main').css('font-size',size+'px');
}
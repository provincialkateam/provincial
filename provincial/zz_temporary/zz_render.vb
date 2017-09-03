! $args[0] - header text, location name
! $args[1] - image
! $args[2] - text
! $args[3] - procedure/function - 0/1
! usage:
! gs 'zz_render', [header], [path_to_img], [text], [function]
!gs 'zz_funcs', 'colorize_day'
! make table
$ren_img = $args[1]
$ren_str = '<center><div style="font-family:<<$settings[''font_family'']>>">'
! header row
if len($args[0]) > 0: $ren_str = '<div id="content_header"><span>'+$args[0]+'</span></div>'
! image row
if len($ren_img) > 4:
	! костыль для рисунков - автоматически додаем расширение файла
	$_img_ext = lcase(mid($ren_img,len($ren_img)-3))
	if $_img_ext ! '.jpg' and $_img_ext ! '.gif' and $_img_ext ! '.png':
		if $_img_ext ! 'webm': $_img_ext = '.jpg'
	else
		$_img_ext = ''
	end
	! ставим префикс images/, если его нет
	if lcase(mid($ren_img,1,7)) ! 'images/': $ren_img = 'images/' + $ren_img
	!! автозамена \ на /
	$ren_img = replace($ren_img,'\','/')
	! ---
	$ren_str += '<div id="content_image">'
	if $_img_ext = 'webm':
		$ren_str += '<video style="width:900px;height:506px;" preload="metadata" autoplay loop><source src="' + $ren_img + '" type=''video/ogg; codecs="theora, vorbis"''></video>'
	else
		$ren_str += '<img src="' + $ren_img + $_img_ext + '">'
	end
	$ren_str += '</div>'
end
! text row
if len($args[2]) > 0:
	! <do></do> or \\\.../// - npc dialogue
	! <dh></dh> or \\...// - hero dialogue
	! ** - <br> tag
	! <red></red> - replace <font color="red"><b></b></font>
	! <green></green> - replace <font color="green"><b></b></font>
	! --
	! replace for dialogue strings
	$tt = replace($args[2],'<do>','<span class="npc_dialogue">')
	$tt = replace($tt,'\\\','<span class="npc_dialogue">')
	$tt = replace($tt,'</do>','</span>')
	$tt = replace($tt,'///','</span>')
	! replace for hero-dialog strings
	$tt = replace($tt,'<dh>','<span class="hero_dialogue">')
	$tt = replace($tt,'\\','<span class="hero_dialogue">')
	$tt = replace($tt,'</dh>','</span>')
	$tt = replace($tt,'//','</span>')
	! br tag
	$tt = replace($tt,'**','<br>')
	! <red>, <green> tags
	$tt = replace($tt,'<red>','<span class="red_color">')
	$tt = replace($tt,'</red>','</span>')
	$tt = replace($tt,'<green>','<span class="green_color">')
	$tt = replace($tt,'</green>','</span>')
	!--
	$ren_str += '<div class="content_text">' + $tt + '</div>'
end
! close table
$ren_str += '</div></center>'
! output
if args[3] = 0:
	*p $ren_str + '<script type="text/javascript">jQuery(".npc_dialogue").css("color","'+$settings['npc_dialogue_color']+'");</script><script type="text/javascript">jQuery(".hero_dialogue").css("color","'+$settings['hero_dialogue_color']+'");</script>'
else
	$result = $ren_str
end
killvar '$tt'
killvar '$ren_str'
killvar '$ren_img'
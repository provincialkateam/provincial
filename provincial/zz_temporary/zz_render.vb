! $args[0] - header text, location name
! $args[1] - image
! $args[2] - text
! $args[3] - procedure/function - 0/1
! usage:
! gs 'zz_render', [header], [path_to_img], [text], [function]
!gs 'zz_funcs', 'colorize_day'
! make table
$ren_img = $args[1]
$ren_str = '<center><font size=4 face="' + $settings['font_family'] + '"><table cellspacing=0 cellpadding=0 width='+$settings['table_width']+'>'
! header row
if len($args[0]) > 0: $ren_str += '<tr><td align=center><b><font size=5 color='+$settings['header_color']+'>'+$args[0]+'</font></b></td></tr>'
! image row
if len($ren_img) > 4:
	! костыль для рисунков - автоматически додаем расширение файла
	$_img_ext = lcase(mid($ren_img,len($ren_img)-3))
	$_img_ext = iif($_img_ext ! '.jpg' and $_img_ext ! '.gif' and $_img_ext ! '.png','.jpg','')
	! ставим префикс images/, если его нет
	if lcase(mid($ren_img,1,7)) ! 'images/': $ren_img = 'images/' + $ren_img
	!! автозамена \ на /
	!$ren_img = replace($ren_img,'\','/')
	! ---
	$ren_str += '<tr><td align=center><img src="' + $ren_img + $_img_ext + '"' + iif($settings['image_height']>0,' height='+$settings['image_height'],'') + '></td></tr>'+ iif($settings['image_render_debug'] = 1,'<br><tr><td align=center>' + $ren_img + $_img_ext +  '</td></tr>','')
end
! text row
if len($args[2]) > 0:
	! <do></do> or \\\.../// - npc dialogue
	! <dh></dh> or  \\...// - hero dialogue
	! ** - <br> tag
	! <red></red> - replace <font color="red"><b></b></font>
	! <green></green> - replace <font color="green"><b></b></font>
	! --
	! replace for dialogue strings
	$tt = replace($args[2],'<do>','<font color="' + $settings['npc_dialogue_color'] + '"><i>')
	$tt = replace($tt,'\\\','<font color="' + $settings['npc_dialogue_color'] + '"><i>')
	$tt = replace($tt,'</do>','</i></font>')
	$tt = replace($tt,'///','</i></font>')
	! replace for hero-dialog strings
	$tt = replace($tt,'<dh>','<font color="' + $settings['hero_dialogue_color'] + '"><i>')
	$tt = replace($tt,'\\','<font color="' + $settings['hero_dialogue_color'] + '"><i>')
	$tt = replace($tt,'</dh>','</i></font>')
	$tt = replace($tt,'//','</i></font>')
	! br tag
	$tt = replace($tt,'**','<br>')
	! <red>, <green> tags
	$tt = replace($tt,'<red>','<font color="red"><b>')
	$tt = replace($tt,'</red>','</b></font>')
	$tt = replace($tt,'<green>','<font color="green"><b>')
	$tt = replace($tt,'</green>','</b></font>')
	!--
	$ren_str += '<tr><td>' + $tt + '</td></tr>'
end
! close table
$ren_str += '</table></font></center>'
! output
if args[3] = 0:
	*pl $ren_str
else
	$result = $ren_str
end
killvar '$tt'
killvar '$ren_str'
killvar '$ren_img'
! load dynamics
view
gs 'din2'
gs 'din_bag'
gs 'dinSex'
! проверка старых версий
if $settings['autosave'] = '': $settings['autosave'] = 1
if $settings['status_display'] = '': $settings['status_display'] = 0
if version < 112:
	killvar '$mods'
	msg 'Моды отключены - переподключите в настройках!'
end
! устанавливаем текущую версию
version = 114
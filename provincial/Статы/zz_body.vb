! body group:
! 0 - underweight
! 1 - normal
! 2 - overweight
! 3 - obesity 1
! 4 - obesity 2
! ---------------------
! height fix
if body['height'] < 160: body['height'] = 160
if body['height'] > 180: body['height'] = 180
! ---
! calc base (normal) weight
body['base_weight'] = body['height']*body['height']*18/10000
! weight fix
if body['weight'] <= 30: body['weight'] = body['base_weight']
! get body group:
if body['weight'] < body['height']*body['height']*18/10000:
	body['group'] = 0
elseif body['weight'] >= body['height']*body['height']*18/10000 and body['weight'] < body['height']*body['height']*26/10000:
	body['group'] = 1
elseif body['weight'] >= body['height']*body['height']*26/10000 and body['weight'] < body['height']*body['height']*3/1000:
	body['group'] = 2
elseif body['weight'] >= body['height']*body['height']*3/1000 and body['weight'] < body['height']*body['height']*4/1000:
	body['group'] = 3
else
	body['group'] = 4
end
! calc base breast size
body['breast'] = body['height']/2 + (body['weight'] - body['base_weight'])/4 + 6 + silicone
! waist
body['waist'] = (body['height']-100) + (body['weight'] - body['base_weight'])/2 - (6 - body['group']) - 5
! hips
body['hips'] = body['waist'] + 28 - (body['weight'] - body['base_weight'])/4
! tits size
body['tits'] = 2 + (body['weight'] - body['base_weight'])/10 + silicone/10
if body['tits'] < 0: body['tits'] = 0
if body['tits'] > 6: body['tits'] = 6
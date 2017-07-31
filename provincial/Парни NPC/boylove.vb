if $ARGS[0] = 'haer':
	if haerBoyA ! hcol:
		bfA -= 1
		if haerBoyA = 0:'<<$boyA>> говорит, что вы очень красивы, хотя ему и нравятся брюнетки.'
		if haerBoyA = 1:'<<$boyA>> говорит, что вы очень красивы, хотя ему и нравятся шатенки.'
		if haerBoyA = 2:'<<$boyA>> говорит, что вы очень красивы, хотя ему и нравятся рыжие.'
		if haerBoyA = 3:'<<$boyA>> говорит, что вы очень красивы, хотя ему и нравятся блондинки.'
	elseif haerBoyA = hcol:
		bfA += 1
		'<<$boyA>> говорит, что у вас чудесные волосы.'
	end
end
if $ARGS[0] = 'figure':
	if figurBoyA = 0:
		if body['hips'] < 80:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас идеальная фигура.'
		else
			bfA -= 1
			'<<$boyA>> говорит, что вы ему очень нравитесь несмотря на то, что он всегда встречался с худышками.'
		end
	elseif figurBoyA = 1:
		if body['hips'] > 80 and body['hips'] < 100:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас идеальная фигура.'
		elseif body['hips'] <= 80:
			bfA -= 1
			'<<$boyA>> спрашивает, нет ли у вас анорексии.'
		elseif body['hips'] >= 100:
			bfA -= 1
			'<<$boyA>> спрашивает, не собираетесь ли вы сесть на диету.'
		end
	elseif figurBoyA = 2:
		if body['hips'] >= 100:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас идеальная фигура.'
		else
			bfA -= 1
			'<<$boyA>> говорит, что вы красивая, но женщина должна быть в теле.'
		end
	end
end
if $ARGS[0] = 'tits':
	!titBoyA
	if titBoyA = 0:
		if body['tits'] < 3:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас красивая грудь.'
		elseif body['tits'] >= 3:
			bfA -= 1
			'<<$boyA>> говорит, что вы ему очень нравитесь несмотря на то, что он предпочитает маленькую грудь.'
		end
	elseif titBoyA = 1:
		if body['tits'] >= 3 and body['tits'] <= 4:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас идеальная грудь.'
		elseif body['tits'] < 3:
			bfA -= 1
			'<<$boyA>> говорит, что у вас красивая, хотя и маленькая грудь.'
		elseif body['tits'] > 4:
			bfA -= 1
			'<<$boyA>> говорит, что у вас действительно огромная грудь.'
		end
	elseif titBoyA = 2:
		if body['tits'] > 4:
			bfA += 1
			'<<$boyA>> говорит вам, что у вас отличная грудь.'
		elseif body['tits'] <= 4:
			bfA -= 1
			'<<$boyA>> говорит, что у вас красивая, хотя ему нравится грудь побольше.'
		end
	end
end
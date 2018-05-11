! Как добавлять предметы в магазин
! шаблон свойства предмета - $data['НАЗВАНИЕОТДЕЛА_КЛЮЧ_ИДЕНТИФИКАТОР']
! не забудьте в shop в функции отдела добавить новое количество товаров для загрузи в таблицу
! вызов в коде func('shop_list_items', 'НАЗВАНИЕОТДЕЛА', 'КЛЮЧ', ИДЕНТИФИКАТОР)
! пример func('shop_list_items', 'cosmetics', 'price', 4) вернет цену товара с идентификатором 4
! food
$data['food_name_0'] = 'Еда'
$data['food_price_0'] 	= 200
$data['food_img_0'] 	= 'food.png'
$data['food_name_1'] = 'Диетическая еда'
$data['food_price_1'] 	= 300
$data['food_img_1'] 	= 'diet_food.png'
$data['food_name_2'] = 'Хлеб'
$data['food_price_2'] 	= 30
$data['food_img_2'] 	= 'bread.png'
$data['food_name_3'] = 'Бутерброд'
$data['food_price_3'] 	= 100
$data['food_img_3'] 	= 'sandwich.png'
$data['food_name_4'] = 'Бутылочка воды'
$data['food_price_4'] 	= 50
$data['food_img_4'] 	= 'water_bottle.png'
$data['food_name_5'] = 'Вино'
$data['food_price_5'] 	= 500
$data['food_img_5'] 	= 'wine.png'
$data['food_name_6'] = 'Водка'
$data['food_price_6'] 	= 400
$data['food_img_6'] 	= 'vodka.png'
$data['food_name_7'] = 'Сосиски'
$data['food_price_7'] 	= 300
$data['food_img_7'] 	= 'sausage.png'
$data['food_name_8'] = 'Куриные крылышки'
$data['food_price_8'] 	= 250
$data['food_img_8'] 	= 'fried_chicken.png'
$data['food_name_9'] = 'Шоколад'
$data['food_price_9'] 	= 100
$data['food_img_9'] 	= 'chocolate.png'
$data['food_name_10'] = 'Печенье'
$data['food_price_10'] 	= 80
$data['food_img_10'] 	= 'cookie.png'
$data['food_name_11'] = 'TicTac'
$data['food_price_11'] 	= 100
$data['food_img_11'] 	= 'tictac.png'
! cosmetics
$data['cosmetics_name_0'] = 'Косметика'
$data['cosmetics_price_0'] 	= 500
$data['cosmetics_img_0'] 	= 'kosmet_small.png'
$data['cosmetics_name_1'] = 'Косметический набор'
$data['cosmetics_price_1']  = 1000
$data['cosmetics_img_1'] 	= 'kosmet_big.png'
$data['cosmetics_name_2'] = 'Бритвенный станок(5шт)'
$data['cosmetics_price_2']  = 300
$data['cosmetics_img_2'] 	= 'razor.png'
$data['cosmetics_name_3'] = 'Солнцезащитный крем'
$data['cosmetics_price_3']  = 300
$data['cosmetics_img_3'] 	= 'sunscreen.png'
$data['cosmetics_name_4'] = 'Шампунь'
$data['cosmetics_price_4']  = 300
$data['cosmetics_img_4'] 	= 'shampoo.png'
$data['cosmetics_name_5'] = 'Тампоны(20шт)'
$data['cosmetics_price_5']  = 200
$data['cosmetics_img_5'] 	= 'tampons.png'
$data['cosmetics_name_6'] = 'Влажные салфетки'
$data['cosmetics_price_6']  = 100
$data['cosmetics_img_6'] 	= 'wet_wipes.png'
$data['cosmetics_name_7'] = 'Расческа'
$data['cosmetics_price_7']  = 200
$data['cosmetics_img_7'] 	= 'nil.png'
! common
$data['common_name_0'] = 'Средство для мытья посуды'
$data['common_price_0'] 	= 200
$data['common_img_0'] 		= 'dishwash_bottle.png'
$data['common_name_1'] = 'Стиральный порошок'
$data['common_price_1'] 	= 200
$data['common_img_1'] 		= 'washing_powder.png'
$data['common_name_2'] = 'Набор из 3-х тарелок'
$data['common_price_2'] 	= 1000
$data['common_img_2'] 		= 'plates.png'
$data['common_name_3'] = 'Краска для стен'
$data['common_price_3'] 	= 800
$data['common_img_3'] 		= 'brush_wall.png'
$data['common_name_4'] = 'Рулон ткани'
$data['common_price_4'] 	= 500
$data['common_img_4'] 		= 'fabric.png'
! tech
$data['tech_name_0'] = 'Небольшой телевизор с кинескопом'
$data['tech_price_0'] = 10000
$data['tech_img_0'] = 'tv_set.png'
$data['tech_name_1'] = 'Большой плазменный телевизор'
$data['tech_price_1']  = 35000
$data['tech_img_1'] = 'lcd_tv_set.png'
$data['tech_name_2'] = 'Ноутбук'
$data['tech_price_2']  = 25000
$data['tech_img_2'] = 'laptop.png'
$data['tech_name_3'] = 'Посудомоечная машина'
$data['tech_price_3']  = 30000
$data['tech_img_3'] = 'dishwasher.png'
$data['tech_name_4'] = 'Стиральная машина'
$data['tech_price_4']  = 20000
$data['tech_img_4'] = 'washing_machine.png'
! clothing
$data['clothing_name_0'] = 'Белье'
$data['clothing_price_0'] = 150
$data['clothing_img_0'] = 'cowards.png'
$data['clothing_name_1'] = 'Набор белья `Неделька`'
$data['clothing_price_1'] = 1000
$data['clothing_img_1'] = 'cowards.png'
$data['clothing_name_2'] = 'Зимнее пальто'
$data['clothing_price_2'] = 10000
$data['clothing_img_2'] = 'winter_coat.png'
! sport
$data['sport_name_0'] = 'Коньки'
$data['sport_price_0'] = 2000
$data['sport_img_0'] = 'skate.png'
$data['sport_name_1'] = 'Скакалка'
$data['sport_price_1'] = 300
$data['sport_img_1'] = 'jump_rope.png'
$data['sport_name_2'] = 'Обруч'
$data['sport_price_2'] = 500
$data['sport_img_2'] = 'hoop.png'
$result = $data[$args[0]+'_'+$args[1]+'_'+args[2]]
killvar '$data'
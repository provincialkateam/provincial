$_vstr['act1'] = '<b>Leave the room</b>'
$_vstr['act2'] = 'Kitchen'
$_vstr['1'] = 'There are your <a href="exec:gt''zz_father'',''main''">father-in-law</a> and your brother <a href="exec:gt''zz_brother'',''main''">Kolka</a>. <a href="exec:gt''mother''">Mother</a> as always near the owen.' + iif(week <=5,'**<a href="exec:gt''sister''">Anya</a> just sit on the table and drink her tea.','')
$_vstr['2'] = 'In the kitchen, next to the stove, there is a sink. A large refrigerator is in the corner. At the wall there is a kitchen table with chairs.'
$result = $_vstr[$args[0]]
killvar '$_vstr'
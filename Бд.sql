﻿use LiveForLife;
--бары
insert into Places(Place_name,Place_adress,Place_type)
values ('BEERлога','ул. Ольги Соломовой 137','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 1, '  Небольшое уютное заведение. Тематический интерьер. Сосновые столы и лавки, деревянная барная стойка.
Стены отделаны деревянными картинами медвежьих голов — это символ бара. Под потолком — щит с гербами.
Одновременно обслуживаться может до 50 человек. В тёплое время года открыта летняя терраса с шестью столами.
«Берлога» на сегодняшний день является единственным заведением в городе, где можно попробовать вареных раков.
Есть винная и коктейльная карты. Ассортимент пива насчитывает более 30 сортов разных производителей.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\1.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Фарадей','ул. Социалистическая 32','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 2, '  Бар «Фарадей» кардинально отличается от всех остальных заведений своей неповторимой атмосферой.
Удивительный дизайн в стиле стимпанк дополняет вкусная еда и напитки.
Вы можете попробовать настоящие крафтовые бургеры и авторские коктейли. 
У нас постоянно проходят вечеринки , DJ-сеты и розыгрыши!', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\2.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Диско-бар Африка','ул. Врублевского 1/1','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 3, '  Ночное развлекательное заведение, где можно весело провести время на вечеринке или концерте.
Целевая аудитория: девушки от 18 и парни от 21 года.
Проведения банкетов, корпоративов, дней рождения, свадеб, тематических вечеринок, мальчишников, девичников,
встреч выпускников по предварительному заказу.
Периодически в «Африке» проходят хип-хоп вечеринки, не имеющие аналогов в городе.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\3.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Хани Кабани Гриль','бул. Ленинского Комсомола 50','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 4, '  Гастрономический гриль-бар.
Европейская кухня из белорусских продуктов премиум-сегмента и импортного мяса, широкий ассортимент чая, кофе, алкогольных напитков.
Есть коктейльная карта и живое пиво Bierbank.
Для приготовления гриля в «Хани Кабани» используются испанские печи Hosper.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\4.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Клуб Пушкин','ул. Советских пограничников 53','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 5, '  Караоке-бар «Пушкин» в Гродно. Большая барная стойка. Сцена для исполнения песен караоке.
В баре работает арт-группа с бэк-вокалистами и ведущими заведения. Бесплатный Wi-Fi.
По выходным проходят stand up-шоу и спортивные трансляции. В заведении существует дресс-код, работает face-контроль.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\5.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Гастробар Гудини','ул. Ленина 13','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 6, '  «Гудини» — бар и ресторан в одном заведении.
Здесь можно попробовать интересные блюда и разнообразные коктейли по доступным ценам.
Представлены европейская и паназиатская кухни.Оформлен в стиле арт-деко с большими зеркалами и  комфортными диванами.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\6.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('CORSAR','ул. Кирова 3','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 7, '  Интерьер выполнен в пиратском стиле. Мебель сделана из поддонов, а гардероб оформлен в форме лестницы в никуда.
На потолке в баре висит деревянная лодка.
В Corsar представлен широкий выбор алкогольных напитков, коктейлей, закусок.
Проводятся выступления музыкантов.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\7.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Корица','ул. Виленская 6','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 8, '  Заведение находится в подвальчике в центре города. Небольшой бар с интерьером, апеллирующим к истории Гродно.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\8.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Магнолия','ул. Мостовая 31','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 9, '  Бар первой наценочной категории с двумя залами: на 60 и 15 мест. Европейская кухня.
Большая ассортимент вин, разливное пиво, чайная и кофейные карты. Обслуживание свадеб, презентаций и банкетов.
Проведение вечеринок, организация детских праздников.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\9.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Лондон','ул. Виленская 1','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 10, '  Бар Лондон — тематический коктейльный бар на 30–40 человек с английским антуражем. Располагается в центре города Гродно.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\10.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Куба','ул. Калючинскя 12','бар');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 11, '  Интерьер выполнен в кубинском стиле. В меню широкий ассортимент виски, рома и других алкогольных напитков, коктейлей.
Тематические вечеринки. Курение запрещено.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\11.jpg', SINGLE_BLOB) as image


--кафе
insert into Places(Place_name,Place_adress,Place_type)
values ('Веранда','ул. Подольная 37','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 12, '  «Веранда» открыта для всех, кто ищет изысканность в простоте вкуса, кого восхищает магия кулинарного мастерства.
Приятный интерьер, выдержанная музыка, высокие традиции сервиса, разнообразное меню и изысканная подача.
Интерьер в теплых пастельных тонах, заслуживающих одобрение у приверженцев классики. Это идеальный вариант как для романтического свидания,
ужина в кругу семьи, пышного торжества, так и для деловых переговоров с важными партнерами, презентаций различного уровня.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\12.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Эль Густо','ул. Максима Горького 91а','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 13, '  Кафе-ресторан «Эль Густо» – это вкуснейшие европейские и белорусские блюда с оригинальным оформлением,
которые придутся по вкусу абсолютно каждому посетителю.
Меню впечатляет большими и сытными порциями, наличием детского меню, что позволяет посещать кафе всей семьёй.
Живая музыка создаст тёплую и уютную атмосферу и позволит расслабиться во время ужина,
а достойный сервис и заботливое обслуживание не оставят Вас равнодушными.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\13.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Верас','ул. Максима Горького 72','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 14, '  Обновленный банкетный зал рассчитан на мероприятия до 200 человек
В «Верасе» представлен широкий ассортимент блюд белорусской и европейской кухни.
В наличии также десертная, кофейная, чайная и винная карты, соки.
Универсальный формат кафе позволяет не только организовывать многочисленные банкеты, но и устраивать романтические
или дружеские посиделки в вечернее время. По вечерам с четверга по воскресенье тут играет живая музыка.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\14.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Барашка','ул. Калючинская 23','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 15, '  Двери заведения открыты для тех, кто любит и ценит кавказскую кухню, живую музыку и приятную обстановку.
Изюминка кафе – сочная баранина, блюда из тандыра, восточные соусы, а также восточные сладости (пахлава, мутаки, шекербура).
Идеальную гастрономическую пару составит домашнее вино в кувшинах. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\15.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Раскоша','ул. Советская 7','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 16, '  Европейская кухня, салаты и другие закуски. Большой ассортимент тортов, выпечки, десертов. Чай, кофе, напитки, коктейли, вина.
Профессиональные кондитеры и бармены. Изготовление тортов на заказ.
Фоновая музыка. Курение запрещено.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\16.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Паланэз','ул. Будённого 56','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 17, '  Находится в здании XIX века, которое построено в стиле эклектика и является объектом, представляющим историческую ценность.
Кафе оказывает широкий спектр услуг по организации и обслуживанию банкетов, корпоративов, юбилеев, свадеб, мастер-классов.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\17.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Романтика','ул. Максима Горького 71','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 18, '  Это уютное место для проведения различных мероприятий: банкетов, фуршетов, корпоративов, свадеб, дней рождения, конференций,
а также заказных обедов любого формата.
Вкусные блюда, живая музыка, шоу-программа и просторный танцпол сделают праздник ярким и незабываемым.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\18.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Хотей','ул. Элизы Ожешко 1','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 19, '  Кафе «Хотей» — это уютное светлое кафе с приветливым персоналом и доступными ценами в Гродно.
Идеально как для компаний и семей, так и для бизнес-встреч.
В заведении представлен широкий ассортимент блюд восточной кухни — японской и китайской — а также американские,
итальянские, европейские блюда.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\19.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Крыша мира','ул. Советская 18','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 20, '  Крыша мира для Гродно – это не столько кафе, сколько смотровая площадка. Попасть наверх можно через торговый центр «Неман».
На лифте или по лестнице.
Меню кафе Крыша мира только барное.Много спиртных напитков. Есть безалкогольные. Коктейли и смузи. Чай и кофе.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\20.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('H2O','ул. Студенческая 2','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 21, '  H2O — это комплекс, состоящий из двух этажей.
1й этаж отведен под кафе-пиццерию и предназначен для комфортного отдыха за завтраком с чашкой кофе,
сытным обедом по демократичным ценам и изысканным ужином.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\21.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Пицца Смайл','ул. Огинского 2','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 22, '  «Пицца Смайл» в Гродно — сеть классических пиццерий с домашней кухней и приятной атмосферой.
Интерьер заведения выдержан в едином лаконичном и ненавязчивом стиле, который создает ощущение уюта и делает обстановку радушной.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\22.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Пицца & Кофе','ул. Замкавая 11','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 23, '  Кафе «Пицца & кофе» в Гродно позиционирует себя, как место отдыха для детей и молодёжи.
Именно поэтому в зале запрещено курить, а в ассортименте алкоголя нет крепких спиртных напитков (только пиво).
Более двадцати видов пиццы: острые, мясные, вегетарианские. Маленькие — 32 см и большие — 43 см. Соусы.
Широкий ассортимент кофе и кофейных напитков.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\23.jpg', SINGLE_BLOB) as image

insert into Places(Place_name,Place_adress,Place_type)
values ('Пицца Темпо','ул. Дубко 17','кафе');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 24, '  Любимое место встреч с деловыми партнерами, друзьями и любимыми. 27 видов пиццы разных размеров.
Также в заведении можно заказать супы, закуски, вторые блюда и обеды. Для сладкоежек найдутся вкусные десерты, мороженое и молочные коктейли.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\24.jpg', SINGLE_BLOB) as image


insert into Places(Place_name,Place_adress,Place_type)
values ('Ресторан Бакст','ул.Замковая 21','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 25, '  Ресторан назван именем выдающегося гродненца Льва Бакста, в честь 150-летия со дня рождения известного во всём мире художника,
сценографа, иллюстратора и дизайнера.Интерьер ресторана выполнен в бежевых тонах и украшен иллюстрациями Льва Бакста.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\25.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Старый Лямус','ул. Дзержинского 1а','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 26, '  В XVIII веке здание ресторана «Старый лямус» входило в архитектурный ансамбль города Гродно, известный из литературы,
как «застройка Тызенгауза на Городнице».
Сегодня в восстановленном памятнике архитектуры предлагается настоящая славянская, белорусская и европейская кухня.
Живая инструментальная музыка.
В дизайне интерьера применены подлинные уникальные старинные вещи, предметы быта и картины.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\26.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Золотой Телёнок','бул. Ленинского Комсомола 29а','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 27, '  В меню заведения представлены блюда европейской и белорусской кухни в авторском видении шеф-повара заведения.
новый интерьер и экстерьер;
профессиональная команда поваров;
команда профессиональных менеджеров и официантов;
новое банкетное меню и интересная подача блюд;
средние цены на банкет по городу, при этом неизменная ставка на качество кухни и сервиса;
честные размеры порций блюд;
живая музыка.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\27.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Гринвич / Greenwich','ул. Советская 29','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 28, '  Интерьер сочетает в себе граффити на стенах, глубокие кожаные диваны и барную стойку в виде вагончика.
В пабе можно послушать живую музыку — играют профессиональные кавер-бэнды.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\28.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('Королевская охота','ул. Элизы Ожешко 3','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 29, '  Ресторан «Королевская охота» расположен в живописном оживленном уголке центральной части
города Гродно — в здании памятника архитектуры классицизма начала XIX века.
С момента открытия ресторана в середине января 2014 года дворец гродненского вице-губернатора Максимовича обрел новый облик
и стал одним из популярнейших мест встреч среди жителей и гостей города.
Особенностью меню «Королевской охоты» является наличие различных блюд из дичи.
Интерьер ресторана дополняет величественный, но при этом лаконичный, классический экстерьер всего дворца', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\29.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Пивной ресторан Неман','ул. Стефана Батория 8','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 30, '  Пивной ресторан «Неман» — это пивной бар при одноименной гродненской гостинице. Заведение рассчитано на 120 человек.
В меню огромный выбор фирменных пивных закусок и более 10 видов разливного пива. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\30.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Гранат','ул.  Мостовая 31','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 31, '  Заведение предлагает широкий выбор барных напитков, коктейлей. В меню более 50 авторских блюд.
Акцент сделан на европейскую кухню и гриль. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\31.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Замок Зеваны','Гродненский Маентак Коробчицы','ресторан');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 32, '  Назван в честь славянской богини Зеваны, почитаемой охотниками и звероловами.
Национальная и европейская кухня, яства из дичи кабана, оленя, лося, зубра. Медовуха, глинтвейн, сбитень. Камин. Бильярд. Фортепьянная музыка.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\32.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Шекспир','ул. Дзержинского 1','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 33, '  25 посадочных мест для любителей сэндвичей, салатов и конечно же овсянки, сэр!
Блюда и напитки названы в честь произведений Уильяма Шекспира
Внутри есть полка с книгами. Рядом с кофейней работает летняя терраса.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\33.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Наша Кава','ул. Замкавая 11','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 34, '  Кофейня «Наша кава» в Гродно — это место, где можно не только попробовать изысканный кофе,
но и научиться правильно его варить.
Интерьер выполнен в коричневых и кофейных тонах.
Внутри много элементов, привлекающих внимание: оголённый кирпич на стенах, классическая мебель,
большое зеркало, полка с книгами. В заведении играет приятная музыка. На улице расположена уютная терраса.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\34.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Гарадзенская кавярня','ул. Карла Маркса 5','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 35, '  Оформители кофейни старались максимально органично вписать современные детали в историческое здание.
Кофейня расположена на 1-м этаже дома, построенного в XIX веке.
На стенах кофейни висят намеренно остановленные часы, чтобы каждый посетитель смог уловить момент, когда время останавливается,
и отдохнуть от суеты и постоянной спешки. Еще одна интересная деталь помещения — стеклянный пол над старым подвалом.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\35.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Кофейня в Доме Хона Пика','ул. Советская 17','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 36, '  «Кофейня в Доме Хона Пика» — новая современная кофейня в самом центре Гродно. Тут можно перекусить, выпить чай и кофе.
Панорамные окна и аутентичность кирпичных стен сочетается с обилием текстиля, орнамента и «вышивкой».
Вместе с ароматом кофе и свежей выпечки это создаёт атмосферу тепла и спокойствия.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\36.jpg', SINGLE_BLOB) as image






insert into Places(Place_name,Place_adress,Place_type)
values ('КАКАО','ул. Будённого 28','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 37, '  Кофейня «Какао» в Гродно специализируется на приготовлении натурального какао и горячего шоколада.
Без консервантов и красителей — только какао-бобы, какао-масло и тростниковый сахар. Всего 5 видов какао.
Также гостям заведения предлагают кофе: эспрессо, американо, капучино, латте, раф и мокко.
И чаи: зеленый с ромашкой, мятой, мелиссой, липовым цветом и семенами фенхеля.
Из десертов: эклеры, чиз-кейки, торты наполеон и трюфельный, а также французские круассаны (пекут прямо в кофейне).', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\37.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Атмосфера','ул. Элизы Ожешко 33','кофейня');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 38, '  Небольшая кофейня на 16 посадочных мест выгодно отличается от своих конкурентов «антикварной» атмосферой:
старые стулья и диванчики, посуда, люстры и мебель.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\38.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Коложский парк','Гродно','парк');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 39, ' ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\39.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Парк Жилибера','Гродно','парк');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 40, ' ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\40.jpg', SINGLE_BLOB) as image






insert into Places(Place_name,Place_adress,Place_type)
values ('Румлёвский Парк','Гродно','парк');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 41, ' ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\41.jpg', SINGLE_BLOB) as image



insert into Places(Place_name,Place_adress,Place_type)
values ('База отдыха Привал','Гродно','для компаний');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 42, '  Вход на территорию платный (бесплатно для детей до 3 лет). 
Также платно можно воспользоваться следующими услугами и объектами:
Аттракционы (качели, горка для альпинизма, бык родео, Золотая лихорадка, боксерская груша, молотобоец,
              пневматический тир, лучный и арбалетный тир, вероевочный городок и др);
Настольные игры (футбол, хоккей, аэрохоккей);
Прокат инвентаря (веломобиль, электромобиль, роликовые коньки, скейтборд);
Игра в лазертаг;
Аренда беседок.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\42.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Джунгли парк','Пышки, Гродно','семейный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 43, '  Веревочный парк развлечений — особый вид экстремальных аттракционов,
представляющий собой комплекс сооружений для активного отдыха, состоящий из различных препятствий,
размещенных между деревьев на определенной высоте.
Прохождение этапов не требует специальной физической подготовки, навыков или умений.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\43.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Зоопарк','Пышки, Гродно','семейный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 44, '  Гродненский зоопарк расположен в самом центре города в шаговой близости от железнодорожного вокзала.
На территории зоопарка также установлены детские аттракционы и контактная площадка «Бабушкин дворик»,
где каждый желающий может поближе познакомиться с детенышами представленных в зоопарке особей.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\44.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Аквацентр','ул. Максима Горького 82','семейный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 45, ' ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\45.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Гродненский Маентак Коробчицы','Гродно','семейный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 46, '  Агротуристический комплекс «Гарадзенскі маёнтак «Каробчыцы» в 7 километрах от города предлагает широкий спектр услуг
для гостей и жителей Гродно и Гродненской области. Обзорные экскурсии по нетронутому человеком лесу (16 гектаров),
где живут косули, лоси, дикие кабаны, благородные олени. Есть также вольеры с животными.
  На территории парка расположился ресторан «Замак Зеваны», кафе «Аллюр», конный двор, музей под открытым небом.
Комплекс предлагает проведение пикников на одном из пяти искусственных водоёмов.
На берегу одного из водоёмов расположен дом охотника и рыба, и концертная площадка со сценой
и зрительскими местами на 150 человек.
Катание верхом на лошади предлагает спортивный клуб «Амадеус», а также катание на дилижансе, фаэтонах и каретах.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\46.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Собор Святого Франциска Ксаверия','ул. Советская 4','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 47, ' Кафедральный собор Святого Франциска Ксаверия, неофициально называется также Фарный костёл — католический собор в городе Гродно,
кафедральный собор Гродненского диоцеза. Один из трёх храмов Белоруссии, носящих почётный титул малая базилика. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\47.jpg', SINGLE_BLOB) as image






insert into Places(Place_name,Place_adress,Place_type)
values ('Свято-Покровский кафедральный собор','ул. Элизы Ожешко 23','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 48, '   Покровский кафедральный собор; Свято-Покровский кафедральный собор,
или Собор в чеесть Покроваа Пресвятоой Богороодицы — кафедральный собор Гродненской и Волковысской епархии Белорусской православной церкви. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\48.jpg', SINGLE_BLOB) as image








insert into Places(Place_name,Place_adress,Place_type)
values ('Старый замок','ул. Замковая 21','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 49, '   Старый замок в Гродно — один из самых древних памятников архитектуры в Белоруссии,
комплекс оборонительных сооружений, культовых и светских зданий XI—XIX вв. ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\49.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Коложская церковь','Коложский парк','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 50, '   Борисоглебская церковь, Коложская церковь или просто Колоожа — одно из сохранившихся архитектурных
сооружений Белоруссии периода Древней Руси. Единственный сохранившийся памятник чёрнорусского зодчества.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\50.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Большая хоральная синагога','ул. Большая Троицкая 59A','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 51, '   Большая хораальная синагога, Гродно, — действующая синагога в центре города Гродно.
Ведёт свою историю с XVI века.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\51.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Пожарная каланча','ул. Замкавая 19','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 52, '  ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\52.jpg', SINGLE_BLOB) as image




insert into Places(Place_name,Place_adress,Place_type)
values ('Старый мост','ул. Горновых','культурный отдых');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 53, '  Старый мост — автомобильный и пешеходный мост через Неман в Гродно, Белоруссия. Является самым старым мостом в городе.
Расположен в створе улиц Мостовой и Горновых.  ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\53.jpg', SINGLE_BLOB) as image






insert into Places(Place_name,Place_adress,Place_type)
values ('Королевский город Гродно ','','экскурсии');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 54, '  За время экскурсии вы не только откроете старинную историю Гродно, посетив древние замки,
но и обнаружите его архитектурное и конфессиональное разнообразие.
Вас ждёт и костёл с деревянными статуями, и лютеранская кирха, и древняя церковь, и главный православный храм.
А также все местные легенды будут открыты для вас!
Продолжительность: 3 часа.
Цена: 49 евро.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\54.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Обаяние Гродно  ','','экскурсии');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 55, '  В Гродно легко почувствовать себя одновременно на улочках Европы и в Советском Союзе.
Королевский, фестивальный, музейный и кинематографический — это всё о нём.
На прогулке вы обойдете ключевые места города храмов, замков и музеев,
разберетесь в переплетениях его истории и проникнетесь атмосферой культурной столицы Беларуси.
Продолжительность: 3 часа.
Цена: 35 евро.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\55.jpg', SINGLE_BLOB) as image






insert into Places(Place_name,Place_adress,Place_type)
values ('Предания старого Гродно  ','','экскурсии');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 56, '  Роман Нила Геймана «Задверье» повествует о тайном мире, в который можно попасть, открыв обычную дверь.
Главное — чтобы тебя захотели впустить...
Другой Гродно — таинственный и загадочный. Подробности жизни города, известных лишь местным, уголки, где не ступает нога туриста.
Продолжительность: 3 часа.
Цена: 50 евро.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\56.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Вкусы и ароматы Гродно ','','экскурсии');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 57, ' Гродно — это не только красивая архитектура и захватывающая история, но и интересное место для гастрономических открытий.
На прогулке по старинным улицам и площадям вы взглянете на кулинарное прошлое и настоящее города.
Узнаете о средневековом меню королевских дворов, продегустируете особенный кофейный напиток «каву па-паўстанску»
и попробуете необычное мороженое.
А в белорусской корчме вас будет ждать аппетитный обед из традиционных блюд и клюквенной настойки.
Продолжительность: 4 часа.
Цена: 70 евро.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\57.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Гродно — город на стыке цивилизаций ','','экскурсии');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 58, ' Многим путешественникам кажется, что если Гродно находится в Западной Беларуси, то все здесь отмечено польским влиянием.
Но также вы познакомитесь с наследием Древней Руси, с уникальным стилем гродненского зодчества и с летописью города.
А фоном для рассказов станут визитные карточки Гродно: замки, православные церкви, католический собор, синагога и просто атмосферные улочки.
Продолжительность: 3 часа.
Цена: 43 евро.', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\58.jpg', SINGLE_BLOB) as image







insert into Places(Place_name,Place_adress,Place_type)
values ('Постоянная экспозиция в музее М. Богдановича ','музей Максима Богдановича','выставки');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 59, ' В музее функционируют 5 залов:
- Галерея знаменитых людей Беларуси.
- Гродненский период жизни семьи Богдановичей.
- Литературно-общественное движение конца ХIХ — начала ХХ веков.
- Мемориальные комнаты.
- Отдел музея «Гродненщина литературная: прошлое и настоящее».

Цена: 0,50 - 1,00 р.
Время работы: 09:30-17:30', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\59.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Постоянная экспозиция в Новом замке ','Новый замок','выставки');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 60, ' В Новом замке представлены следующие экспозиции:
- «Новый замок: События и судьба»,
- «Спасённые ценности»,
- «Удивительный мир природы»,
- «Старинный интерьер»,
- «Оружие минувших столетий».

Цена: 0,90 - 1,70 р.
Время работы: 10:00-18:00 ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\60.jpg', SINGLE_BLOB) as image





insert into Places(Place_name,Place_adress,Place_type)
values ('Эпоха. Час. Будынак ','Музей истории религии','выставки');
insert into Place_information(Id_place, Place_discriptin,Photo_place)
select 61, ' Гiсторыя будынка — палаца XVIII–XIX ст.; традыцыi сям’i, у фармiраваннi якiх значная роля належала рэлiгii.
Першая экспазіцыя музея гісторыі рэлігіі ў Гродна прысвечана уладальнікам палаца і гарадскому побыту XIX-XX стагоддзяў.
Стацыянарная экспазіцыя «Эпоха. Час. Будынак» размясцілася ў галоўнай часцы палаца, у якім знаходзіцца музей.
Прадметы побыту розных эпох на выставе будуць аб’яднаны ў тэматычныя блокі. Экспазіцыі будуць прысвечаны палацавым інтэр’ерам,
сямейным рэлігійным традыцыям, ладу жыцця і захапленням нашых продкаў.
У адной з залаў анфілады будуць экспанавацца прадметы мэблі XIX — пачатку ХX стагоддзяў,партрэты, гадзіннiкi, патэфон, посуд,
старыя газеты і часопісы, арыгінальныя ўзоры рукадзелля, паштоўкі, вееры, парасоны, малыя скульптуры.

Цена: 1,00 - 2,00 р.
Время работы: 10:00-18:00 ', BulkColumn 
from Openrowset(Bulk N'D:\2k2s\KURS\LiveFullLife\61.jpg', SINGLE_BLOB) as image


insert into Wanted_places(Place_id, [User_id])
values(1,22);

insert into Visited_places(Visited_place_id, [V_User_id])
values(5,22);

insert into Users([Login], [Password])
values('admin', 'df4d6c95c5321330bd1d93c4c14f31006e041ec9dc5ccaadf463a7e586cc661c');


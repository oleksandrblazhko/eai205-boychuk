### Словник атрибутів об’єктів
|Об’єкт|Атрибут|Короткий опис|Тип|Обмеження|
|:-|:-|:-|:-|:-|
|user|user_id|Індетифікаційний номер користувача|число|> 0|
user|nickname|Нікнейм користувача|текст|довжина < 16 символів та довжина > 0 символів|
|user|email|Пошта користувача|текст|довжина < 32 символів|
|sleep_info|info_id|Індетифікаційний номер даних|число|> 0|
|sleep_info|minutes|Кількість хвилин сну|число|>0 та <=900|
|sleep_info|sleep_interval|Час початку та кінця сну|проміжок часу|немає|
|sleep_info|sleep_date|Дата сну|дата| < завтрашня дата|
|library|library_id|Ідентифікаційний номер бібліотеки|число|>0|
|library|name|Назва бібліотеки|текст|довжина < 32 символів та довжина > 0 символів|
|library|books|Кількість книг|число|>=0|
|book|book_id|Індетифікаційний номер книги|число|>0|
|book|name|Назва книги|текст|довжина < 64 символи та довжина > 0 символів|
|book|author|Автор книги|текст|довжина < 64 символи та довжина > 0 символів|
|book|yearof_publictn|Рік видання книги|число|>1900 та <=сьогоднішній рік|
|book|transl_author|Автор перекладу книги|текст|довжина < 64 символів|
|book|pages|Кількість сторінок у книзі|число|>0|

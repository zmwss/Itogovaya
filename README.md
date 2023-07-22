# Описание решения задачи.
1. Создаём функцию с агрументом и возвращаемым значением типа **string[]**. Функция принимает исходный массив строк и преобразовывает его в нужный нам массив строк(длина каждой строки не больше трёх).
2. Создаём целочисленный массив с длиной, равной длине исходного массива(индексный массив). Индексный массив будет содержать в качестве своих элементов позиции тех строк исходного массива, длина которых не больше трёх и. Конец массива может быть заполнен нулями.
3. Создаём новый массив строк с требуемой длиной(этот массив будет на выходе). Проходимся по нему циклом:
```
for(int i = 0; i < new_length; i++)
{
    new_array[i] = old_array[index_array[i]];
}
```
* Другими словами с помощью индексного массива запоминаем позиции нужных элементов исходного массива строк.

**Задача решена**.
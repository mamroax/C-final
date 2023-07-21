# Программа удаления элементов из массива

## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Решение:

В данном примере задаим данные сразу в программе. Создадим переменные:

* _myArray_ - массив строк

* _number_ - максимальная длина строки(включительно)

* _counter_ - счетчик для формирования нового массива строк

* _result_ - новый массив строк

## Сформируем новый массив строк

В цикле от 0 до длины первоначального массива _myArray_(не включительно) с шагом единица будем проверять, превышает ли длина текущего элемента(строки) массива _myArray_ введенное значение _number_(в задаче равное 3). Если превышает - пропускаем и переходим к следующему элементу. Если длина текущего элемента меньше или равно _number_, то добавляем этот элемент(строку) в новый массив, а счетчик _counter_ увеличиваем на единицу.

## Вывод результатов

В цикле от нуля до длины нового массива _result_  с шагом 1 выведем все элементы нового массива в консоль

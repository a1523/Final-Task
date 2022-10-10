# Final-Task
## Задание: 

### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

### Алгоритм выполнения задания:

* Создать репозиторий на GitHub
* Нарисовать блок-схему алгоритма
* Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
* Написать программу, решающую поставленную задачу
* Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

### Блок-схема алгоритма:
Графическое описание решения задачи приложено к папке Scheme.

### Описание алгоритма решения задачи:
Изначально задаем массив значений на старте выполнения алгоритма. 
Далее в цикле проверяем, подходит ли элемент условию "длина символов <= 3". Если элемент подходит под данное условие, то мы добавляем его в новый массив, 
используя при этом дополнительный счетчик, чтобы элементы в новом массиве заполнялись последовательно.

### Решение задачи
Реализация алгоритма решения задачи выполнена на языке С# и находится в папке Task, файл Program.cs.
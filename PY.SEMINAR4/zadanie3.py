# Задана последовательность чисел.
# программа, которая выведет список неповторяющихся
# элементов исходной последовательности

def uniqList(list):
    uniqElemList = [i for i in list if list.count(i) == 1]
    return uniqElemList

list = [1, 1, 2, 3, 4, 5, 5, 15, 22, 22, 27]
result = uniqList(list)
print(result)
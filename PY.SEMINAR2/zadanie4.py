# задайть список из N элементов,
# заполнить числами из промежутка [-N, N]
# найти произведение указанных элементов

def sequence(n):
    list1 = []
    list = [list1.append(i) for i in range(-n, n+1)]
    return list1

def enterPosition():
    position = input('Введите через пробел номера позиций, значения которых нужно перемножить: ').split()
    positionList = [int(i) for i in position]
    return positionList

def multPosition(position):
    multiples = 1
    for i in range(0, len(positionList)):
        multiples *= list1[positionList[i]]
    return multiples

n = (int(input('Задайте количество элементов : ')))
list1 = sequence(n)
print(list1)
positionList = enterPosition()
print(positionList)
mult = multPosition(positionList)
print(mult)
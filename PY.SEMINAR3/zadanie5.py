# Составить список чисел Фибоначчи, в том числе для отрицательных индексов

def fiboPositive(n):
    listFib01 = [0, 1]
    for i in range(2, n + 1):
        listFib01.append(listFib01[i - 2] + listFib01[i - 1])
    return listFib01

def fiboNegative(n):
    listFib02 = [0, 1]
    for i in range(2, n + 1):
        listFib02.append(listFib02[i - 2] - listFib02[i - 1])
        listFib03 = listFib02[1::]
    listFib03.reverse()
    return listFib03

n = int(input('Введите целое число: '))
fiboPos = fiboPositive(n)
fiboNeg = fiboNegative(n)
resFibo = fiboNeg + fiboPos
print(f"Список чисел Фибоначчи c отрицательными и положительными индексами: \n{resFibo}")
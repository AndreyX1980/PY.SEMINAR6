# вычислить число с заданной точностью

import math
def pi():
    pi = math.atan(1) * 4
    accuracy = str(input("Введите точность до 15 знака после запятой (например 0.001): "))
    value = len(accuracy[2::])
    print(round(pi, value))
pi()
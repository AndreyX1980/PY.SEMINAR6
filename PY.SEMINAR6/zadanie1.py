# наибольший общий делитель (НОД)

raw = input('Введите последовательность чисел через пробел: ')
int_array = [int(i) for i in raw.split(' ') if i.isdigit()]

try:
    from math import gcd
except ImportError:
    from fractions import gcd
from functools import reduce
print('Наибольший общий делитель (НОД): ', reduce(gcd, int_array))
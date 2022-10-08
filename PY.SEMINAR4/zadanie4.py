# Задана натур степень k. Сформировать рандомный список коэф
# многочлена и записать в файл

from random import randint
import itertools as it


def ratios_list(k):
    ratios = [randint(0, 10) for i in range(k + 1)]
    if ratios[0] == 0:
        ratios[0] = randint(1, 10)
    return ratios


def NotePad_list(cof, ratios):
    op = ['*x^']*(cof-1) + ['*x']
    NotePad = [[a, b, c] for a, b, c in it.zip_longest(
        ratios, op, range(cof, 1, -1), fillvalue='') if a != 0]
    for x in NotePad:
        x.append(' + ')
    NotePad = list(it.chain(*NotePad))
    NotePad[-1] = ' = 0'
    return "".join(map(str, NotePad)).replace(' 1*x', ' x')


cof = randint(2, 5)
ratios = ratios_list(cof)
NotePad = NotePad_list(cof, ratios)
print(NotePad)

with open('NotePad_01.txt', 'w') as data:
    data.write(NotePad)
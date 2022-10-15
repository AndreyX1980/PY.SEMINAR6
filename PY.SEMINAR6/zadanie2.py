# максимальное количество символов, стоящих подряд 

text = str(input('Введите последовательность символов: \n'))
char_to_find = str(input('Что будем считать? \n'))


max_count = 0
tmp = 0

for c in text:
    if char_to_find == c:
        tmp += 1
    else:
        if tmp > max_count:
            max_count = tmp
        tmp = 0
if tmp > max_count:
    max_count = tmp

print(f'Максимальная последовательность: {max_count}')
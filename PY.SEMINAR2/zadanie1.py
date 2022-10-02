# программа, принимающая на вход вещественное число
# и показывающая сумму его цифр

inp = input("Введите комбинацию цифр: ")
str_inp = str(inp)
str_inp = str_inp.replace(',', '')
lst_str = list(str_inp)
lst_num = map(int, lst_str)
s = sum(lst_num)
print(s)
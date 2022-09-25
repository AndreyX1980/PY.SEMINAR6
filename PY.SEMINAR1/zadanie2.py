# программа для проверки истинности утверждения... для всех значений предикат

x = 0
y = 0
z = 0
if (not(x or y or z)==(not x) and (not y) and (not z)):
	for x in [0,1]:
		for y in [0,1]:
			for z in [0,1]:
				print (x, y, z)

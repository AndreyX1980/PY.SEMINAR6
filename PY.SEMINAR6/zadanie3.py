# решение через лямбду 5 задачи 1 семинара

def dist(x,y):
    return (sum(map(lambda xx,yy : (xx-yy)**2,x,y)))**0.5
    
a=(7,-5)
b=(1,-1)
 
print(dist(a,b))
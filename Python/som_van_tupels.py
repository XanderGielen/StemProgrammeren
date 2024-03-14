def som(n, getallen):
    set2 = set()
    for i in getallen:
        for j in getallen:
            if (i + j) == n:
                set2.add((i, j))
    return set2
 
set1 = {1,2,3,4,5}
x = 6
print(som(x, set1))
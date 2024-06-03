def kanonsballenberekenen(n):
    #n = hoeveel ballen hoog
    if n == 1:
        return 1
    return pow(2, kanonsballenberekenen(n-1))

#hoofdprogramma
print(kanonsballenberekenen(4))
print(kanonsballenberekenen(1))


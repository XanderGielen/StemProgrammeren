def leibnitz(n):
    noemer = -1
    som = 0
    for i in range(n - 1):
        if i == 0:
            pass
        elif i % 2 == 0:
            som -= 1 / noemer
        else:
            som += 1 / noemer
        noemer += 2
    som *= 4
    return som
        
    
    

n = int(input("Geef een getal: "))
print(leibnitz(n))
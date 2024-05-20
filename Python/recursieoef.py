import random
import time
def zeshoeksgetal(n):
    totaal = 0
    if n==1:
        return 1
    else:
        return zeshoeksgetal(n-1) + 6 * (n-1)

def faculteitrecur(n):
    if n <= 1:
        return 1
    else:
        return n* faculteitrecur(n-1)
def faculteitinter(n):
    resultaat = 1
    for i in range(n):
        resultaat = resultaat * (i+1)
    return resultaat
    
def timeSortAlgoX(n):
    start = time.perf_counter()
    resultaat = faculteitrecur(n)
    stop = time.perf_counter()
    print("totaal = ", resultaat, " de tijd in ms  voor recursie was: ", stop - start)
    start = time.perf_counter()
    resultaat = faculteitinter(n)
    stop = time.perf_counter()
    print("totaal =", resultaat, " de tijd in ms voor inter was: ", stop - start)


print(timeSortAlgoX(80))


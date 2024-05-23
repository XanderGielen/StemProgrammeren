import time
def recursiefetje(n):
    if n != 1:
        resultaat = 2 * recursiefetje(n-1)
    else:
        resultaat = 2
    return resultaat

def iteratiefetje(n):
    return pow(2, n)

def timeSortAlgoX(n):
    start = time.perf_counter()
    resultaat = recursiefetje(n)
    stop = time.perf_counter()
    print("totaal = ", resultaat, " de tijd in ms  voor recursie was: ", stop - start)
    start = time.perf_counter()
    resultaat = iteratiefetje(n)
    stop = time.perf_counter()
    print("totaal =", resultaat, " de tijd in ms voor inter was: ", stop - start)
    
timeSortAlgoX(100)
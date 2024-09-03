def iteratiefpalin(woord):
    woordlijst = list(woord)
    checker = True
    for i in range(0, len(woordlijst)):
        if woordlijst[i] == woordlijst[len(woordlijst) - 1 - i]:
            pass
        else:
            checker = False
    return checker
    
def recursiefpalin(woord):
    woordlijst = list(woord)
    if len(woordlijst) == 1 or len(woordlijst) == 0:
        return True
    else:
        if woordlijst[0] == woordlijst[-1]:
            woordlijst[0].remove()
            woordlijst[-1].remove()
            recursiefpalin(woordlijst)
        else: return False
    
woord = input("geef een woord: ")
print(iteratiefpalin(woord))
print(iteratiefpalin(woord))


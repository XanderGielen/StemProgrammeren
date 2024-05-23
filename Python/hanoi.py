import time
#########recursieve versie##################
def hanoi_recursief(schijven, van, naar):
    stap = 0

    def __hanoi_recursief(schijven, van, naar):
        if schijven <= 1:
            nonlocal stap
            stap += 1
            print(f"Stap {stap}: verplaats van {van} naar {naar}".format(stap, van, naar))
            return
        
        hulp = 6 - (van + naar)
        
        __hanoi_recursief(schijven-1, van, hulp)
        __hanoi_recursief(1, van, naar)
        __hanoi_recursief(schijven-1, hulp, naar)

    __hanoi_recursief(schijven, van, naar)

############################################
    
#########iteratieve versie##################
def hanoi_iteratief(schijven, van, naar):
    A = [float('Inf')]
    B = [float('Inf')]
    C = [float('Inf')]
    puzzel = [A, B, C]
    
    for schijf in range(schijven, 0, -1):
        puzzel[van-1].append(schijf)
        
    stappen = 2**schijven - 1

    hulp = 6 - (van + naar)
    if schijf % 2:
        hulp, naar = naar, hulp 
        
    for stap in range(1, stappen+1):
        if stap % 3 == 1:
            print(f"Stap {stap}: Geldige wissel tussen {van} en {hulp}")
            geldige_wissel(puzzel, van, hulp)
        if stap % 3 == 2:
            print(f"Stap {stap}: Geldige wissel tussen {van} en {naar}")
            geldige_wissel(puzzel, van, naar)
        if stap % 3 == 0:
            print(f"Stap {stap}: Geldige wissel tussen {naar} en {hulp}")
            geldige_wissel(puzzel, naar, hulp)

        print(puzzel)

def geldige_wissel(puzzel, stapel_k, stapel_l):
    # Pas het nummer van de stapels aan aan de index van de stapels in de puzzellijst
    stapel_k = stapel_k - 1
    stapel_l = stapel_l - 1
    
    if puzzel[stapel_k][-1] < puzzel[stapel_l][-1]:
        # De schijf op staak_l is groter dan die op staak_k, of staak_l is leeg
        # Verplaats de topschijf van staak_k naar staak_l
        puzzel[stapel_l].append(puzzel[stapel_k].pop())
        
    elif puzzel[stapel_k][-1] > puzzel[stapel_l][-1]:
        # De schijf op staak_k is groter dan die op staak_l, of staak_k is leeg
        # Verplaats de topschijf van staak_l naar staak_k
        puzzel[stapel_k].append(puzzel[stapel_l].pop())

    return puzzel

############################################

def timeSortAlgoX(n):
    start = time.perf_counter()
    resultaat = hanoi_recursief(n,1,3)
    stop = time.perf_counter()
    print("totaal = ", resultaat, " de tijd in ms  voor recursie was: ", stop - start)
    start = time.perf_counter()
    resultaat = hanoi_iteratief(n,1,3)
    stop = time.perf_counter()
    print("totaal =", resultaat, " de tijd in ms voor inter was: ", stop - start)

timeSortAlgoX(4)

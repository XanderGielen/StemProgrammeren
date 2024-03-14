import time
import sys
def totaal(bestellingen, drankkaart):
    totaal = 0

    for drank, aantal in bestellingen:
        if drank in drankkaart:
            prijs = drankkaart[drank]
            totaal += prijs * aantal
        else:
            return "bestelling niet mogelijk"

    return totaal

drankkaart = {'cola': 2.50, 'fanta': 2.50, 'bier': 2.00, 'water': 1.50}

bestellingen = [('bier', 10), ('cola', 3)]
start = time.time()
print(totaal(bestellingen, drankkaart))
stop = time.time()
print(round(stop-start, 10))
print(sys.getsizeof(bestellingen))

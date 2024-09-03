import random

getal = -1
lijst = []
nietNul = True

for i in range(10):
    getal = random.randint(1, 10)
    lijst.append(getal)

print(lijst)

while nietNul == True:
    waarInLijst = int(input("Het hoeveelste getal in de rij moet vervagnen worden? "))
    if waarInLijst == 0:
        nietNul = False
    else:
        waarInLijst = waarInLijst - 1
        nieuwNummer = int(input("Geef het nieuwe getal in: "))
    
        lijst.insert(waarInLijst, nieuwNummer)
        print(lijst)

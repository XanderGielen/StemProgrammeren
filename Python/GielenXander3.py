import random

#Declareer de variabelen.
getal = -1
lijst = []
nietNul = True

#Maak de lijst met willekeurige getallen aan.
for i in range(10):
    getal = random.randint(1, 10)
    lijst.append(getal)

#Toon de lijst met willekeurige getallen.
print(lijst)

#Laat de gebruiker de kiezen welk getal ze willen vervangen en met welk getal ze het willen vervangen.
while nietNul == True:
    waarInLijst = int(input("Het hoeveelste getal in de rij moet vervagnen worden? "))
    if waarInLijst == 0:
        nietNul = False
    else:
        waarInLijst = waarInLijst - 1
        nieuwNummer = int(input("Geef het nieuwe getal in: "))
    
        lijst.insert(waarInLijst, nieuwNummer)
        print(lijst)
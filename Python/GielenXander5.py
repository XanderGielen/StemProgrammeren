#vraag de gebruiker voor de string
invoer = input("Geef een string in van 2 woorden gescheiden door een spatie ")
#split de invoer gebaseerd op waar de spatie is en zet het in een lijst
lijst = invoer.split(" ")
#keer de lijst om en toon hem
lijst.reverse()
print(*lijst)
#zet de elementen van de lijst in een string
lijstString1 = str(lijst[0])
lijstString2 = str(lijst[1])
lijstString = lijstString1 + " " + lijstString2 + "\n"

#schrijf het omgekeerde van de invoer in een bestand en zeg dat je dat gedaan hebt
with open ("omkeren.txt", "a") as bestand:
    bestand.write(lijstString)
    print("string toegevoegd aan bestand")

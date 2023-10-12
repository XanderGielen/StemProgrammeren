# vraag een resultaat en declareer de variabelen
resultaat = int(input("geef een score"))
aantal = 0
som = 0
afwezig = 0

# kijk of het getal 99 is dan stopt het, 88 is dan is een leerling afwezig of het een ander resultaat is en voer de berekeningen uit
while resultaat != 99:
    if resultaat == 88 :
        afwezig += 1
    else :
        som += resultaat
        aantal += 1
    resultaat = int(input("geef een score"))

#toon de resultaten
gem = som / aantal
print("het gemiddelde is ", gem)
print("er waren ", afwezig, "leerlingen afwezig")
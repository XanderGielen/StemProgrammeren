#bereken het oppervlakte en het aantal kg graszoden nodig
#gebaseerd op of dat het een vierkant of driehoek is
def grasZodenDriehoek(basis, hoogte):
    kgGraszoden = (basis * hoogte) / 4
    return kgGraszoden

def grasZodenVierkant(basis, hoogte):
    kgGraszoden = (basis * hoogte) / 2
    return kgGraszoden

#declareer onze variabelen
vorm = ""
breedte = 0
hoogte = 0
totaalKlanten = 0
aantalDriehoek = 0
aantalVierkant = 0
totaalKGgrasZoden = 0
graszoden = 0

#zolang dat de gebruiker geen stop invoert blijven we vragen
#naar de breedte, hoogte en vorm van de tuin en tellen we ook op hoeveel we van elk in totaal hebben
while(True):
    vorm = input("welke vorm heeft jouw tuin? Vierkant of Driehoek? Tijp -stop- om te stoppen ")
    if vorm == "stop":
        break
    breedte = int(input("Geef de breedte van jouw tuin: "))
    hoogte = int(input("Geef de hoogte van jouw tuin: "))

    #kijk ofdat de gebruiker een ongeldige invoer geeft en
    #als het geldig is kijk of dat het een vierkant of driehoek is
    if vorm == "Vierkant":
        aantalVierkant += 1
        graszoden = grasZodenVierkant(breedte, hoogte)
        totaalKGgrasZoden += graszoden
        print("je hebt", graszoden, "KG graszoden nodig voor jouw tuin te zaaien")
        
    elif vorm == "Driehoek":
        aantalDriehoek += 1
        graszoden = grasZodenDriehoek(breedte, hoogte)
        totaalKGgrasZoden += graszoden
        print("je hebt", graszoden, "KG graszoden nodig voor jouw tuin te zaaien")
    else:
        print("ongeldige invoer")
    totaalKlanten += 1

#toon alle data die we verzameld en opgeteld hebben
print("totaal aantal klanten: ", totaalKlanten)
print("aantal tuinen die een driehoek zijn: ", aantalDriehoek)
print("aantal tuinen die een vierkant zijn: ", aantalVierkant)
print("Totaal aantal kg graszoden nodig: ", totaalKGgrasZoden)
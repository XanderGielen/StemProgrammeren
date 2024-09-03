#TIP 1:
#Met de methode .split(teken) kan je een string opsplitsen naar een lijst waarin ieder
#woord een item is.
#Een voorbeeld:
#txt = "welcome to the jungle"
#x = txt.split()
#print(x)
#Geeft als resultaat: ['welcome', 'to', 'the', 'jungle']
#Nog een voorbeeld:
#txt = "welcome, to the jungle"
#x = txt.split(", ")
#print(x)
#Geeft als resultaat: ['welcome', 'to the jungle']

#TIP 2:
#Met de methode "".join(lijst) kan je de elementen van een lijst samenvoegen
#Een voorbeeld:
#lijst = ["John", "Peter", "Vicky"]
#x = " ".join(lijst)
#print(x)
#Geeft als resultaat: John Peter Vicky

def laadwoordenboek():
    with open("dictionary.txt", "r") as boek:
        woordboek = boek.read().splitlines()

        return woordboek
        
def verwijderNietLetters(bericht):
    #de string letters_enzo bevat zowel alle hoofdletters als kleine letters
    #ze bevat ook de spatie en de enter
    HOOFDLETTERS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
    letters_enzo = HOOFDLETTERS + HOOFDLETTERS.lower() + ' \n'
    #maak lijst van bericht en creeer nieuwe lijst om letters in op te slaan
    berichtlst = list(bericht)
    nieuwlst = []
    for letter in berichtlst:
        if letter in letters_enzo:
            #als het een letter spatie of enter is voeg het toe aan de nieuwe lijst
            nieuwlst.append(letter)
        else:
            pass
    nieuwlst = "".join(nieuwlst)
    return nieuwlst

def maakengelseTelling(bericht):
    #zorg dat tekst alleen woorden heeft
    tekst = verwijderNietLetters(bericht)
    septekst = tekst.split(" ")
    
    #laad woorden boek en kijk of woord in woordenboek zit
    woordboek = laadwoordenboek()
    nieuwtekst = []
    for woord in septekst:
        #print(woord)
        if woord in woordboek:
            nieuwtekst.append(woord)
    percentagEngels = len(nieuwtekst) / len(septekst) * 100
    
    return percentagEngels

def isEnglish(bericht, woordPercentage, letterPercentage):
    isEngels = True
    #check of dat het percentage van letters groter is dan 20% en het perc engels woorden groter is dan 85%
    percletters = len(letterPercentage) / len(bericht) * 100
    if percletters > 85.0:
        if woordPercentage > 20.0:
            return isEngels
        else:
            isEngels = False
    else:
        isEngels = False
    return isEngels
    

nedtekst = "hallo, ik ben nederlands"
entekst = "ABATE ABATED ABATEMENT ghjkdjg /*97"
raretekst = "abc48/*/,"
te_checken_zin = entekst
print(isEnglish(te_checken_zin, maakengelseTelling(te_checken_zin), verwijderNietLetters(te_checken_zin)))
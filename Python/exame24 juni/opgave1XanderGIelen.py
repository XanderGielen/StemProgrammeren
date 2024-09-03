

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

    return "".join(nieuwlst)

def maakengelseTelling(bericht):
    #zorg dat tekst alleen woorden heeft
    tekst = verwijderNietLetters(bericht).split(" ")
    
    #laad woorden boek en kijk of woord in woordenboek zit
    woordboek = laadwoordenboek()
    nieuwtekst = []
    for woord in tekst:
        if woord in woordboek:
            nieuwtekst.append(woord)
    return len(nieuwtekst) / len(tekst) * 100

def isEnglish(bericht, woordPercentage, letterPercentage):
    #check of dat het percentage van letters groter is dan 20% en het perc engels woorden groter is dan 85%
    percletters = len(letterPercentage) / len(bericht) * 100
    
    if percletters > 85.0 and woordPercentage > 20.0:
        return True
    else:
        return False
    

#een paar zinnen
nedtekst = "hallo, ik ben nederlands"
entekst = "ABATE ABATED ABATEMENT ghjkdjg /*97"
raretekst = "//??!``````%"


#plaats hier die zin die je wilt checken, is een aparte variabele zo dat je in de functie niet constant alles moet veranderen
te_checken_zin = entekst
engels_checker = isEnglish(te_checken_zin, maakengelseTelling(te_checken_zin), verwijderNietLetters(te_checken_zin))
#zeg mooi of dat de tekst engels is of niet
if engels_checker == True:
    print("de tekst is in het engels geschreven")
else:
    print("de tekst is niet in het engels geschreven")
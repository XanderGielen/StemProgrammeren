namen= []
afstanden = []

while(True):
    naam = input("naam student?")
    if naam == "stop":
        break
    else:
        namen.append(naam)
    afstand = int(input("hoe ver: "))
    afstanden.append(afstand)

if len(namen) > 0:
    print("Overzicht: ")
    for i in range(len(afstanden)):
        print(afstanden[i], "   ", namen[i])
    
    kopie = afstanden
    kopie.sort()
    for i in range(len(kopie)):
        if kopie[-1] == afstanden[i]:
            print(namen[i]," woon het verst namelijk ", afstanden[i])
            
    print("de gemiddelde afstand is", sum(afstanden) / len(afstanden))
    
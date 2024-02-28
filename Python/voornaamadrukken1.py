import os
"""
with open ("voornamen.txt") as bestand:
    bestandLijst = bestand.readlines()
    for i in bestandLijst:
        if i != "\n":
            print(i, end="")
        
    teller = 0
    for i in bestandLijst:
        print(i)
        teller+= 1
    print(teller)

with open ("voornamen.txt", "a") as bestand:
    bestand.write("Rob \n")
    bestand.write("Tim \n")

with open ("achternamen.txt", "w") as bestand:
    bestand.write("Troon \n")
    bestand.write("Brel \n")
"""

antwoord = input("moet voornamen.txt of achternamen.txt verwijderd worden?")

if antwoord == "voornamen.txt":
    if os.path.exists("voornamen.txt"):
        os.remove("voornamen.txt")
    else:
        print("bestaat niet")
elif antwoord == "achternamen.txt":
    if os.path.exists("achternamen.txt"):
        os.remove("achternamen.txt")
    else:
        print("bestaat niet")

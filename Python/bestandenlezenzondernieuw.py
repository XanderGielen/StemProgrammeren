with open ("examenrooster.txt") as bestand:
    bestandLijst = bestand.readlines()
    for i in bestandLijst:
        if i != "\n":
            print(i, end="")


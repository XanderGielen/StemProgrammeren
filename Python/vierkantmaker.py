def vierkantMaker(aantal, karakter):
    for i in range(aantal):
        print()
        print(karakter * aantal)


while True:
    welkKarakter = input("welk karakter wil je? ")
    if welkKarakter == "":
        break
    hoeveelLijnen = int(input("hoeveel lijnen? "))
    vierkantMaker(hoeveelLijnen, welkKarakter)
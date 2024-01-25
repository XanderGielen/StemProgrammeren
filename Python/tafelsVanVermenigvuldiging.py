def tafel_van_vermenigvuldiging(getal):
    for i in range(1, 11):
        som = i * getal
        print(i, "*", getal, "=", som)

getal = int(input("Geef het getal: "))
tafel_van_vermenigvuldiging(getal)
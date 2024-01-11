getal = 0
aantalExceptions = 0
totaal = 0
gem = 0

for i in range(10):
    try:
        getal = int(input("Geef getal"+ str(i + 1) + ": "))
        totaal += getal
    except ValueError:
        print("Geef een nummer in")
        aantalExceptions += 1

deeltal = 10 - aantalExceptions
gem = totaal / deeltal
print("Het gemiddelde van deze" ,  deeltal, "Getallen is ", gem)
naturGetal = int(input("geef het getal in: "))
resultaat = 0
opteller = 1
lijstje = []

while resultaat <= naturGetal:
    resultaat = opteller**2
    lijstje.append(resultaat)
    opteller += 1

print(*lijstje)
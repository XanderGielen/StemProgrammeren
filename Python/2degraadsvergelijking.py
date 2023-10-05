import math

#vraag de coefficienten aan de gebruiker
a = float(input("geef a "))
b = float(input("geef b "))
c = float(input("geef c "))

#bereken de discriminante
D = b ** 2 - 4 * a * c

#geef aan of dat er nulpunten zijn en welke deze zijn
if D < 0 :
    print("discriminante is negatief, geen nulpunten")
elif D == 0 :
    x12 = (-b + math.sqrt(D)) / (2 * a)
    print("Het nulpunt van de vergelijking is ", x12)  
else :
    x1 = (-b - math.sqrt(D)) / (2 * a)
    x2 = (-b + math.sqrt(D)) / (2 * a)
    print("De nulpunten van de vergelijking zijn ", x1, "en", x2)

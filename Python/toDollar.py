def toDollar(wisselkoers, aantalEuro):
    dollar = aantalEuro * wisselkoers
    print(aantalEuro, "aantal euro = ", dollar, "dollar")
    
wisselkoers = float(input("wat is de wisselkoers van vandaag: "))
aantalEuro = float(input("hoeveel euro: "))
toDollar(wisselkoers, aantalEuro)
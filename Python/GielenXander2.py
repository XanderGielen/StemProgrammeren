#vraag een jaar
jaar = int(input("geef een jaar "))

#kijk of het jaar deelbaar is door 4 maar niet honderd of deelbaar is door 400
if jaar %  4 == 0 and jaar % 100 != 0 or jaar % 400 == 0 :
    print("schrikkeljaar")
else :
    print("geen schrikkeljaar")
def dodelijkVirus(tijd):
    aantalMensenOver = 50000 * 0.5**tijd
    return int(aantalMensenOver)


tijd = float(input("Tijd sinds verspreiding?: "))
print(dodelijkVirus(tijd))
def gemeenschapelijk(lijst1, lijst2) :
    gemeen1 = set(lijst1)
    gemeen2 = set(lijst2)
    gemeen = gemeen1 & gemeen2
    return gemeen
    
lijst1 = [1,2,3,4,5,3]
lijst2 = [7,3,23,2,7,3]
print(gemeenschapelijk(lijst1, lijst2))
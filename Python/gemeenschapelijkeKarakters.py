def gemeenschappelijke_karakters(eersteWoord, tweedeWoord):
    uniekeLetters = []
    for i in eersteWoord:
        if i in tweedeWoord and not i in uniekeLetters:
            uniekeLetters.append(i)
    
    return len(uniekeLetters)
        
    
eersteWoord = input("Geef in ")
tweedeWoord = input("geef ook in ")
print(gemeenschappelijke_karakters(eersteWoord, tweedeWoord))
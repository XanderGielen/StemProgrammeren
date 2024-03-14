def converteer(kleur):
    hextorgb = {'0':0,'1':1,'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9,'A':10,'B':11,'C':12,'D':13,'E':14,'F':15}
    teller = 0
    onthoud = 0
    lijst = []
    for i in kleur:
        if teller % 2 == 0:
            onthoud = hextorgb[i] * 16
        else:
            nu = hextorgb[i]
            samen = nu + onthoud
            lijst.append(samen)
            nu = 0
            onthoud = 0
        teller += 1
    return lijst
            
print(converteer('C9143C'))
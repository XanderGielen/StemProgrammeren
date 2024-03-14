def minstens(x, lijst, verz):
    teller = 0
    for i in lijst:
        if i in verz:
            teller+= 1
    return x <= teller

lijst = [1,2,3,4,5,1,4,1,2,5]
verz = {1,3,7}
x = 3
print(minstens(x, lijst, verz))
def product(verz, index):
    #haal de lengte van de lijst op
    lengte = len(verz)
    #als de index hetzelfde is als de lengte van de lijst stop dan
    if index == lengte -1:
        return verz[index]
    else:
        #doe het huidig element * het volgend element
        return  verz[index] * product(verz, index +1)


#declareer verzameling
list1 = [5, 10, 2, 2, 5]
print(product(list1, 0))

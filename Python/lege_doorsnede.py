def leeg(set1, set2):
    return (set1 & set2) == set()


verz1 = {1,2,3}
verz2 = {4,5,6,3}
print(leeg(verz1, verz2))
    

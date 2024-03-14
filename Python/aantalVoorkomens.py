def voorkomens(woord):
    map ={}
    for i in woord:
        if i in map:
            map[i] += 1
        else:
            map[i] = 1
    return map
        
print(voorkomens('groetjes'))

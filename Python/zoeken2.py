def find(lst, elm):
    for i in lst:
        if i == elm:
            return True
    return False



klas1 = ["amrit", "jeremy", "fien"]
klas2 = ["Louis", "Peter"]
klas3 = ["Hannerlore", "Tom"]

alle = []
alle.extend(klas1)
alle.extend(klas2)
alle.extend(klas3)

print(*alle)

print(find(alle, input("welke naam wil je zoeken ")))
def wieIsDeMol(verdachten):
    for i in verdachten:
        if i == verdachten[i]:
            return "De mol is" + i
    return "er is geen mol"

print(wieIsDeMol({'Ann': 'Annie', 'Anne': 'Anne', 'Anna': 'Ann', 'Annie': 'Ann'}))
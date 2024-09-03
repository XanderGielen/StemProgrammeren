zin = "bonjte naar hondje"
lijstzin = list(zin)
verstoptzin = "###### #### ######"
verstoplijst = list(verstoptzin)
nietopgelost = True
while nietopgelost == True:
    print(*verstoplijst)
    gok = input("welk letter denk je?: ")
    for i in range(len(lijstzin)):
        if lijstzin[i] == gok:
            verstoplijst[i] = gok
    if verstoplijst == lijstzin: nietopgelost = False

print("Je bent gewonnen!!!!!! ")
    
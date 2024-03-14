def vertaal(woordenlijst, woordenboek):
    vertaling = []
    for i in woordenlijst:
        if i == woordenboek:
            vertaling.append(woordenboek[i])
    return vertaling
            
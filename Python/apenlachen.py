def apenlachen(aap1, aap2):
    if (aap1 and aap2 == "lachen") or (aap1 and aap2 != "lachen"):
        return True
    return False

eersteAap = input("Lacht de eerste aap?")
tweedeAap = input("Lacht de tweede aap?")
apenlachen(eersteAap, tweedeAap)

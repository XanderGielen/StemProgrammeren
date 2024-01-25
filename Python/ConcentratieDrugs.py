import math

def concentratieDrugs(tijd):
    concentratie = round((math.pi * tijd) / (tijd**2 + 2), 4)
    return concentratie


tijd = float(input("tijd sinds iname? "))
print(str(concentratieDrugs(tijd)))

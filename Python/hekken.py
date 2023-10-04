import math

lengte_verschil = 120**2
breedte_akker = 90**2
lengte = math.sqrt(lengte_verschil + breedte_akker)

poortbij = lengte - 4

aantal_hekken = int(poortbij//2.03)
kort_hek = poortbij%2.03
aantal_palen = aantal_hekken + 3

print(aantal_hekken + 1, "hekken")
print(kort_hek, "meter")
print(aantal_palen, "palen")


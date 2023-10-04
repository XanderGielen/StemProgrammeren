#gegevens
lange_zijde = 210
korte_zijde = 120
breedte = 120

opp_boom = 8 * 8

#oppervlakte akker berekenen
opp_veld = 1/2 * (lange_zijde + korte_zijde) * breedte

#aantal bomen berekeenen
aantal_bomen = opp_veld // opp_boom

#output
print("Gegevens:")
print("Lange zijde:", lange_zijde)
print("korte zijde:", korte_zijde)
print("Breedte:", breedte)
print()
print("Resultaat:")
print("Aantal bomen om te kopen:", aantal_bomen)
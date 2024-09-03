import csv
"""Python Oefening: Bibliotheek Management Systeem

Taken:
1. Schrijf een functie om boekgegevens toe te voegen.
2. Schrijf een *recursieve* functie om alle boeken weer te geven.
3. Schrijf een functie om een boek op titel te zoeken.
4. Schrijf een functie om een boek te verwijderen.
5. Gebruik exception handling.
    bvb: boek niet gevonden, probeer boek te verwijderen dat niet bestaat
6. Maak een functie waar je de namen van de boeken in een list zet en die print
7. Programmeerfunctie om het aantal boeken in de bibliotheek te tellen.
"""

def voegBoekToe():
    with open("C:/Users/xander.gielen/Downloads/boeken.csv", "a", newline='') as boek:
        schrijver = csv.writer(boek)
        naam_boek = input("naam boek: ")
        naam_auteur = input("naam auteur: ")
        datum_publicatie = input("datum publicatie: ")
        schrijver.writerow([naam_boek, naam_auteur, datum_publicatie])

voegBoekToe()
        
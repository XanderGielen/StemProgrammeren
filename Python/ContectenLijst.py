def displayMenu():
    print(
        "Contact Book menu: \n"
        "1. add a contact \n"
        "2. search contact \n"
        "3. update contact \n"
        "4. delete contact \n"
        "5. display all contacts \n"
        "6. exit"
    )
    keuze = input()
    if keuze == "1":
        addContact()
    elif keuze == "2":
        searchContact()
    elif keuze == "3":
        updateContact()
    elif keuze == "4":
        deleteContact()
    elif keuze == "5":
        displayAllContacts()
    elif keuze == "6":
        return 0

def addContact():
    naam = input("geef de naam in: ")
    email = input("geef de email in: ")
    nummer = input("geef het nummer in: ")
    contactDict = {"naam": naam, "email": email, "nummer": nummer}
    contacten.append(contactDict)
    print("contact is toegevoegd")
    
def searchContact():
    naam = input("welke naam wil je zoeken: ")
    for i in contacten:
        if i["naam"].lower() == naam.lower():
            print(*i.values())
            print("press enter to continue")
            input()
def updateContact():
    keuze = input("wat wil je updaten? naam, nummer of email?: ")
    for i in contacten:
        if keuze == "naam":
            naamverander = input("welke naam wil je updaten?: ")
            if naamverander.lower() == i["naam"].lower():
                nieuweNaam = input("wat is de nieuwe naam")
                i["naam"] = nieuweNaam
                break
        elif keuze == "nummer":
            nummerverander = input("welk nummer wil je updaten?: ")
            if nummerverander.lower() == i["nummer"].lower():
                nieuwNummer = input("wat is het nieuwe nummer")
                i["nummer"] = nieuwNummer
                break
        elif keuze == "email":
            emailverander = input("welk email wil je updaten?: ")
            if emailverander.lower() == i["email"].lower():
                nieuwEmail = input("wat is de nieuwe email")
                i["email"] = nieuwEmail
                break
    print("press enter to continue")
    input()
                
def deleteContact():
    naam = input("welke naam wil je verwijderen: ")
    teller = 0
    for i in contacten:
        if i["naam"].lower() == naam.lower():
            contacten.pop(teller)
            print("naam verwijderd")
            teller += 1
            print("press enter to continue")
            input()
def displayAllContacts():
    for i in contacten:
        print(*i.values())

contacten = []
while True:
    if displayMenu() == 0:
        break
    
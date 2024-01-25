import random
lijst = []
def randomLijstVuller(aantal):
    for i in range(aantal):
        lijst.append(random.randint(1, 6))
        
        
def uniekeLijst(lijst):
    uniekeLijst = []
    for i in lijst:
        if not i in uniekeLijst:
            uniekeLijst.append(i)
    uniekeLijst.sort()
    return uniekeLijst

aantal = int(input("met hoeveel dobbelstenen wil je gooien? "))

randomLijstVuller(aantal)
print("je gooide: ", lijst)
print("Je aantal unieke worpen waren", uniekeLijst(lijst))
        
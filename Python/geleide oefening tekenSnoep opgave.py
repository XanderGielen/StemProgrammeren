import turtle

### FUNCTIEDEFINITIES

def tekenSnoep( straal, kleur):
    turtle.fillcolor(kleur)
    turtle.begin_fill()
    turtle.circle(straal)
    turtle.end_fill()
    
def tekenStok( lengteStok):
    turtle.right(90)
    turtle.forward(lengteStok)
    
def tekenLolly(straal, kleur, lengteStok):
    tekenSnoep(straal, kleur)
    tekenStok(lengteStok)

### HOOFDPROGRAMMA
straal = int(input("geef de straal "))
kleur = input("geef de kleur ").lower()
lengteStok = int(input("geef de lengte van de stok "))
tekenLolly(straal, kleur, lengteStok)

turtle.done()


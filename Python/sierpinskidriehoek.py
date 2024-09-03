import turtle

turtle.speed(10000)
def driehoek(zijde):
    turtle.pendown()
    turtle.begin_fill()
    for i in range(3):
        turtle.forward(zijde)
        turtle.left(120)
    turtle.end_fill()
    turtle.penup()
    
def sierpinski(n, zijde):
    if n == 0:
        driehoek(zijde)
    else:
        sierpinski(n-1, zijde/2)#maak kleine dirhoek
        turtle.forward(zijde/2) #ga eig /2 nr voor voor volgende driehoek
        sierpinski(n-1, zijde/2)#maak ng ees kleine driehoek
        turtle.backward(zijde/2)#ga trg r startpositie
        turtle.left(60)
        turtle.forward(zijde/2)
        turtle.right(60)#dees 3 lijnen is vr 3de driehoek te tekene
        sierpinski(n-1, zijde/2)
        turtle.left(60)
        turtle.backward(zijde/2)
        turtle.right(60)#ga trg nr originele positieö
        
n = int(input("voer het aantal niveaus in: "))
zijde = int(input("Voer de lengte van de zijde in: "))

achtergrondkl = input("geef de achtergrondkleuer in: ")
lijnkleur = input("geef de kleur van de lijn in")
turtle.color(lijnkleur)
turtle.fillcolor(achtergrondkl)
sierpinski(n, zijde)
turtle.done()
    

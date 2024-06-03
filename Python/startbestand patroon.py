import turtle

# teken een vierkant
def teken_vierkant(zijde, x, y, kleur):
    turtle.penup()
    turtle.goto(x, y)
    turtle.pendown()
    turtle.color(kleur)
    turtle.begin_fill()
    for _ in range(4):
        turtle.forward(zijde)
        turtle.right(90)
    turtle.end_fill()

def teken_patroon(n, zijde, x, y, kleur1, kleur2):
    if n <= 1:
        teken_vierkant(zijde, x, y, kleur1)
    else:
        teken_patroon(n-1, zijde / 2, x, y, kleur1, kleur2)
        teken_patroon(n-1, zijde / 2, x + (zijde / 2), y, kleur2, kleur1)
        teken_patroon(n-1, zijde / 2, x, y - (zijde / 2), kleur2, kleur1)
        teken_patroon(n-1, zijde / 2, x + (zijde / 2), y - (zijde / 2), kleur1, kleur2)

turtle.speed("fastest")

teken_patroon(4, 200, -128, 128, "red", "black") 

turtle.exitonclick()

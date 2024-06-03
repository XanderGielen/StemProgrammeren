import turtle as pen
pen.speed(100000)
hoeken = [0, 60, -120, 60]

def teken(lengte, orde):
    if(orde == 0):
       pen.forward(lengte)
    else:
        for i in hoeken:
            pen.left(i)
            teken(lengte / 3, orde - 1)

def driehoek(n):
    for i in range(3):
        teken(300, n)
        pen.right(120)

driehoek(1)
driehoek(2)
driehoek(3)
driehoek(4)
driehoek(5)
pen.done()

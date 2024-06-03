import numpy as np
import matplotlib.pyplot as plt
import math

# we gooien een bal met v0 = 20m/s en a = 30graden, we willen de bewging kennen
#we tonen dit door 2 grafieken te maken 1 waar we de y-as in functie van de tijd plotten
#en 1 waar we de x-as in functie van de tijd plotten
#we verwachten dat de x coordinaat een rechte gaat zijn
#we verwachten dat de y coordinaat een parabool gaat zijn die eerst stijgt en dan daalt

dt = 0.00001

t = np.arange(0, 2.03874 + dt, dt)
vx = np.zeros_like(t) #array aanmaken met nullen met de lengte van t
vy = np.zeros_like(t)
x = np.zeros_like(t)
y = np.zeros_like(t)
ay = np.ones_like(t) * -9.81 #array met zelfde lente als t gevuld met ééntjes * -9.81 (gravity)

vx[0] = 20 * math.cos(math.radians(30))
vy[0] = 20 * 0.5 # sin van 30 graden

grond = 0

for idx, tt in np.ndenumerate(t[:-1]): #voor elk element in de lijst t, :-1 zorgt ervoor dat we het laatste punt niet hebben, anders index out of bounds
    i = idx[0]
    vx[i+1] = vx[i]
    x[i+1] = x[i] + vx[i] * dt
    
    vy[i+1] = vy[i] + ay[i] * dt
    y[i+1] = y[i] + vy[i] * dt
    if y[i] > 0:
        grond = i
print("op tijdstip", t[grond], "raakt de bal de grond")
print("de bal heeft", x[grond], "meter afgelegd")
plt.plot(t,x)
plt.xlabel("tijd [s]")
plt.ylabel("x-positie [m]")
plt.show()
plt.plot(t,y)
plt.xlabel("tijd [s]")
plt.ylabel("y-positie [m]")
plt.show()
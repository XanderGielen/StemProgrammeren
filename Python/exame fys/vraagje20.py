import numpy as np
import matplotlib.pyplot as plt
import math


dt = 0.00001

t = np.arange(0, 4 + dt, dt)
vx = np.zeros_like(t)
vy = np.zeros_like(t)
x = np.zeros_like(t)
y = np.zeros_like(t)
ay = np.ones_like(t) * -9.81 

vx[0] = 20 * math.cos(0.348)
vy[0] = 20 * math.sin(0.348)

balInDoel = 0
for idx, tt in np.ndenumerate(t[:-1]): 
    i = idx[0]
    vx[i+1] = vx[i]
    x[i+1] = x[i] + vx[i] * dt
    
    vy[i+1] = vy[i] + ay[i] * dt
    y[i+1] = y[i] + vy[i] * dt
    if y[i] > 2.2:
        hoogstepuntBal = i
    elif y[i] > 2.1:
        laagstepuntBal = i
    elif x[i] < 11:
        balInDoel = y[i]
        
print("de bal raakt de goal op", balInDoel, "m hoog")

plt.plot(t,x)
plt.xlabel("tijd [s]")
plt.ylabel("x-positie [m]")
plt.show()
plt.plot(t,y)
plt.xlabel("tijd [s]")
plt.ylabel("y-positie [m]")
plt.show()
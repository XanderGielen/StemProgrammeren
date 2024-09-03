import numpy as np
import matplotlib.pyplot as plt
import math

dt = 0.00001

t = np.arange(0, 7 + dt, dt)
y = np.ones_like(t)*172
v = np.ones_like(t)
a = np.ones_like(t)*-9.81

grond = 0

for idx, tt in np.ndenumerate(t[:-1]):
    i = idx[0]
    v[i+1] = v[i] + a[i] * dt
    y[i+1] = y[i]+v[i]*dt
    if y[i] > 0:
        grond = i
print("op tijdstip", t[grond], "raakt de bal de grond")

plt.plot(t,y)
#plt.axis([0,120,0,100])
plt.xlabel("tijd [s]")
plt.ylabel("positie [y]")
plt.show()

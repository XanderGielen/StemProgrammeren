import numpy as np
import matplotlib.pyplot as plt
# tijdsstap in seconden en aantal stappen
dt = 0.1
T = 1.4
# arrays met tijd, afstand, snelheid en versnelling
t = np.arange(0,T+dt,dt)
x = np.ones_like(t)*9
v = np.ones_like(t)
a = np.ones_like(t)*-9.81

for idx, tt in np.ndenumerate(t[:-1]):
    i = idx[0]
    v[i+1] = v[i] + a[i] * dt
    x[i+1] = x[i]+v[i]*dt

plt.plot(t,x)
#plt.axis([0,120,0,100])
plt.xlabel("tijd [s]")
plt.ylabel("positie [m]")
plt.show()
print(x[-1])




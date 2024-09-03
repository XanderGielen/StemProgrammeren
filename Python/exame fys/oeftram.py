import matplotlib.pyplot as plt
import numpy as np

dt = 0.1
t1 = np.arange(0, 40+dt, dt)
v1 = np.ones_like(t1)
s1 = np.ones_like(t1)
vv1 = 72/3.6
aa1 = (v1 - 0) / (t1[-1] - 0)

v = 0
s = 0
for i in range(len(t1)):
    v1[i] = v
    s1[i] = s
    v += aa1 * dt
    s += v * dt
    
plt.plot(t1,v1)
plt.xlabel("tijd in s")
plt.ylabel("afstand in m")
plt.title("1ste beweging")
plt.show()
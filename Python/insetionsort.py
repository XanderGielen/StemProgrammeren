import random
import time
import matplotlib.pyplot as plt
def insertion_sort(lst):
    for i in range(len(lst)):
        #niet gesorteerd deel
        key = lst[i]

        j = i - 1 #j is element voor i
        while j >= 0 and key < lst[j]:
            lst[j + 1] = lst[j] #Verplaats het element lst[j] naar rechts
            j -= 1
        lst[j + 1] = key
    return lst

def genereerLijst(n):
    lst = []
    for i in range(n):
        num = random.randint(1, n//2)
        lst.append(num)
    return lst

def timeSortAlgoX(n):
    start = time.perf_counter()
    sorted_lst = insertion_sort(genereerLijst(n))
    print(sorted_lst)
    stop = time.perf_counter()
    print("met n =", n, " de tijd in ms was: ", stop - start)
    y.append(stop - start)

y = []
lstnummers = [10,100,1000]
timeSortAlgoX(lstnummers[0])
timeSortAlgoX(lstnummers[1])
timeSortAlgoX(lstnummers[2])

plt.plot(lstnummers,y)
plt.xlabel("aantal elementen")
plt.ylabel("mili")
plt.title("tijdscomplex insertionsort")
plt.show()
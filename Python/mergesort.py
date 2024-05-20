import random
import time
import matplotlib.pyplot as plt

def merge_sort(lst):
    if len(lst) <= 1:
        return lst

    mid = len(lst) // 2
    left_half = merge_sort(lst[:mid])
    right_half = merge_sort(lst[mid:])

    return merge(left_half, right_half)

def merge(left, right):
    merged = []
    left_index = 0
    right_index = 0

    while left_index < len(left) and right_index < len(right): # Als het huidige element van de linkerlijst kleiner of gelijk is aan het huidige element van de rechterlijst
        if left[left_index] <= right[right_index]:# Voeg het toe aan de samengevoegde lijst en ga naar het volgende element van de linkerlijst
            merged.append(left[left_index])
            left_index += 1
        else:
            merged.append(right[right_index])
            right_index += 1

    # Voeg de resterende elementen van de linker- en rechterlijst toe aan de samengevoegde lijst
    merged.extend(left[left_index:])
    merged.extend(right[right_index:])
    return merged

def timeSortAlgoX(n):
    start = time.perf_counter()
    sorted_lst = merge_sort(genereerLijst(n))
    print(sorted_lst)
    stop = time.perf_counter()
    print("met n =", n, " de tijd in ms was: ", stop - start)
    y.append(stop - start)

def genereerLijst(n):
    lst = []
    for i in range(n):
        num = random.randint(1, n//2)
        lst.append(num)
    return lst

y = []
lstnummers = [10,100,1000]
timeSortAlgoX(lstnummers[0])
timeSortAlgoX(lstnummers[1])
timeSortAlgoX(lstnummers[2])
#timeSortAlgoX(lstnummers[3])


plt.plot(lstnummers,y)
plt.xlabel("aantal elementen")
plt.ylabel("mili")
plt.title("tijdscomplexiteit MergeSort")
plt.show()
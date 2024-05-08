import time
def bin_search(lst, elm):
    left = 0
    right = len(lst) -1
    while left <= right:
        mid = (left + right) // 2
        if lst[mid] == elm:
            return mid
        if lst[mid] < elm:
            left = mid+1
        else:
            right = mid-1

def find(lst, elm):
    for i in lst:
        if i == elm:
            return True
    return False


klas1 = ["Amrit", "Jeremy", "Fien", "Dante"]
klas2 = ["Louis", "Peter", "Cas", "Bartu"]
klas3 = ["Hannerlore", "Tom", "Zoe"]

alle = []
alle.extend(klas1)
alle.extend(klas2)
alle.extend(klas3)
alle.sort()

start = time.perf_counter()
print(bin_search(alle, input("welke naam wil je zoeken ")))
stop = time.perf_counter()
print("de tijd in ms was: ", stop - start)

start1 = time.perf_counter()
print(find(alle, input("welke naam wil je zoeken ")))
stop1 = time.perf_counter()
print("de tijd in ms was: ", stop1 - start1)
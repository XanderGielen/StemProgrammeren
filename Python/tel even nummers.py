x = 1
even = 0

while x != 0:
    if x % 2 == 0:
        even += 1
    x = int(input())

print(even)
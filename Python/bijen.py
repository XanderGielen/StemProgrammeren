def iteratief(n):
    print("het aantal voorouders voor 0 is  1")
    num1 = 0
    num2 = 1
    next_number =1
    teller = 1
    while teller <= n: 
        print("het aantal voorouders voor", teller, " is ", next_number)
        teller += 1
        num1, num2 = num2, next_number
        next_number = num1 + num2

def recursief(n):
    if n == 1 or n ==0:
        return 1
    return recursief(n-1) + recursief(n-2)

#Hoofdprogramma
iteratief(5)

for i in range(5):
    print("het aantal voorouders voor", i, " is ", recursief(i))
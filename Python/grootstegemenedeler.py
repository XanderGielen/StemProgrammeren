def recursief(num1, num2):
    if (num1 % num2) == 0:
        return num2
    return recursief(num2, num1 % num2)

print(recursief(1000000, 100000000))
x = float(input("hoe ver kan je lopen"))
y = int(input("hoe ver is de race"))
D = 1

while x < y:
    D += 1
    x *= 1.1
print(D)
N = int(input())
getal = 2

while N % getal != 0 and getal < N:
    getal += 1

if getal == N:
    print(N, "is een priemgetal")
elif getal != N:
    print(N, "is geen priemgetal")
def faculteit(n):
    totaal = 1
    for i in range(1, n+1):
        totaal = totaal * i
    return totaal
def binomiaal(n, k):
    totaal = 0
    if 0 <= k and k <= n:
        x = n - k
        totaal = faculteit(n) / (faculteit(k) * faculteit(x))
    return int(totaal)

n = int(input("Geef n: "))
k = int(input("geef k: "))

print(binomiaal(n, k))
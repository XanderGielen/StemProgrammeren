numlist = [ 100, 101, 0, "103", 104]

try:
    i1 = int(input( "geef een index: "))

    print( "100 /", numlist[i1], "=", 100 / numlist[i1])
except TypeError:
    print("Geef een nummer in")
except ValueError:
    print("Geef een nummer in")
except IndexError:
    print("Geef een mogelijke index in")
except ZeroDivisionError:
    print("Niet delen door 0")

    

def naarFahrenheit(celcius):
    fahrenheit = celcius * 9/5 + 32
    print(celcius, "graden celcius = ", fahrenheit, "graden fahrenheit")
    
celcius = float(input("hoeveel graden celcius"))
naarFahrenheit(celcius)
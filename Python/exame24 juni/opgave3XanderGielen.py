from tkinter import *

#declareer je root, titel, grootte van applicatie en je volume
root = Tk()
root.title("afstandsbediening")
root.geometry("500x300")

volume = Label(root, text="VOLUME", font="times 20")
volume.place()


def volumeUp():
    #zorg dat er +1 verschijnt voor 1 sec en dan weggaat
    volume.config(text= "+1")
    volume.after(1000, lambda:volume.config(text= "VOLUME"))
    
def volumeDown():
    #zorg dat er -1 verschijnt voor 1 sec en dan weg gaat
    volume.config(text= "-1")
    volume.after(1000, lambda:volume.config(text= "VOLUME"))
    
def turnOnTV():
    window = Toplevel(root)
    window.title("TV")
    image = PhotoImage(file="giphy.gif")

    original_image = Label(window, image=image)
    original_image.image = image
    original_image.pack()

#creer en plaats de knoppen
bUp = Button(root, text="+", command=volumeUp)
bUp.place()
bDown = Button(root, text="-", command=volumeDown)
bDown.place()
bOn = Button(root, text="ON", command=turnOnTV)
bOn.place()
bOff = Button(root, text="OFF", command=quit)
bOff.place()


root.mainloop()

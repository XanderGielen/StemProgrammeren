import random
from tkinter import *

def gooi():
 nummer=["\u2680", "\u2681", "\u2682", "\u2683", "\u2684", "\u2685"]
 l1.config(text=f"{random.choice(nummer)}{random.choice(nummer)}")
 l1.pack()


root = Tk()

root.geometry("700x450")
b1 = Button(root, text="gooi hond", font="times 20 bold", command=gooi)
b1.place(x=320,y=0)
l1=Label(root,text="",font="times 200")
root.mainloop()
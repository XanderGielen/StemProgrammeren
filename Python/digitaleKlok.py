import time, sys
from tkinter import *


def tijd():
    huidigetijd= time.strftime("%H:%M:%S")
    klok.config(text=huidigetijd)
    klok.after(200,tijd)
    
root = Tk()

root.geometry("500x250")

titel=Label(root,text="Digitale klok",font="times 24 bold")
titel.grid(row=0,column=1)

klok = Label( root, text="", font='Times 50 bold', bg='white', fg='black', height=1, width=8)
klok.grid(row=1, column=1)
tijd()

root.mainloop()
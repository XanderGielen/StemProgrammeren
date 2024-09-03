from tkinter import *


def quizstart(i):
    tekst = str(vragen[i])
    if i > 0:
        vraag.config(text = tekst)
        antwoord(i)
    else:
        einde.config(text = "Jouw score is: " + str(score) + " / " + str(max_score))

def antwoord(i):
    global score
    global max_score
    if entry.get() == oplossingen[i]:
        score += 1
    entry.delete(0, END)
    quizstart(i -1)




root = Tk()
root.title("quiz")
root.geometry("500x300")
vragen = ["5 * 5", " 2 + 2", "10 + 5"]
oplossingen = ["25", "4", "15"]
vraag = Label(root, text="", font="times 50")
vraag.place(x=150, y=50)
entry = Entry(root, width = 30)
entry.pack(pady = 10)
score = 0
max_score = len(vragen)
einde = Label(root, text="", font="times50")
einde.place(x=250, y=250)
aantalvragen = 2
b1 = Button(root, text="gooi hond", font="times 20 bold", command=quizstart(aantalvragen))
b1.place(x=25,y=250)
    


quizstart(aantalvragen)

root.mainloop()

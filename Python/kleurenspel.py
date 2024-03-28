from tkinter import *
import random

#This fuction will be called when start button is clicked
def startGame():
 global displayed_word_color
 if(timer == 60):
    startCountDown()
    displayed_word_color = random.choice(colors).lower()
    display_words.config(text=random.choice(colors), fg=displayed_word_color)
    color_entry.bind("<Return>", displayNextWord)
#This function will start count down
def startCountDown():
 global timer
 if(timer >= 0):
    time_left.config(text = "Het spel eindigt over: " + str(timer) + " seconden")
    timer -= 1
    time_left.after(1000,startCountDown)
 if (timer == -1):
    time_left.config(text="Game Over!!!")
#This function to display random words
def displayNextWord(event):
 global displayed_word_color
 global score
 if(timer > 0):
    if(displayed_word_color == color_entry.get().lower()):
        score += 1
        game_score.config(text = "Jouw score is: " + str(score))
    color_entry.delete(0, END)
    displayed_word_color = random.choice(colors).lower()
    display_words.config(text = random.choice(colors), fg = displayed_word_color)

root = Tk()
root.geometry("500x300")
root.title("kleurenspel")

color_entry = Entry(root, width = 30)
color_entry.pack(pady = 10)

colors = ['red', 'blue', 'green', 'pink', 'yellow', 'orange'] 
timer = 60
time_left = Label(root, text="")
game_score = Label(root, text="")
display_words = Label(root, text="", font="times 50")
time_left.place(x=150,y=100)
game_score.place(x=200,y=150)
display_words.place(x=200,y=200)
score = 0 
displayed_word_color = ''

startGame()

root.mainloop()

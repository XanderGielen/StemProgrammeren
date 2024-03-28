#importeren modules
from tkinter import *
import random
#aanmaken venster

#initialisatie
player_score = 0
computer_score = 0
options = ["steen", "blad", "schaar"]

#functie keuze speler
def player_choice(player_input):
    global player_score, computer_score
    computer_input = get_computer_choice()
    player_choice_label.config(text = 'Jij koos: ' + str(player_input))
    computer_choice_label.config(text = 'Computer koos: ' + str(computer_input))
    
    #winnaar bepalen nog toevoegen in deze functie (zorg dat het winner_label met de tekst wie er wint
    #voorzie ook een label met de score voor jou of de pc)
    if (player_input == "steen" and computer_input == "blad") or (player_input == "blad" and computer_input == "schaar") or (player_input == "schaar" and computer_input == "steen"):
        computer_score += 1
        computer_score_label.config(text=str(computer_score))
    elif player_input == computer_input:
        pass
    else:
        player_score += 1
        score_label.config(text=str(player_score))
    

#functie keuze pc
def get_computer_choice():
    return random.choice(options)

#Titel spelvenster
game_window = Tk()
game_window.geometry("1000x600")
game_window.title("bladsteenschaar")

#Label om winnaar telkens te tonen
winner_label = Label(game_window, text = "Het spel kan beginnen...", fg = 'green', pady = 8)
winner_label.grid(row=1, column=2)

#Keuzemogelijkheden speler weergeven (papier en schaar nog toevoegen)
player_options = Label(game_window, text = "Jouw keuzes: ", fg = 'grey')
player_options.grid(row = 2, column = 0, pady = 8)
rock_btn = Button(game_window, text = '1 = Steen', width = 15, bd = 0, bg = 'pink', pady = 5, command = lambda: player_choice(options[0]))
rock_btn.grid(row = 3, column = 1, padx = 8, pady = 5)
paper_btn = Button(game_window, text = '2 = Blad', width = 15, bd = 0, bg = 'pink', pady = 5, command = lambda: player_choice(options[1]))
paper_btn.grid(row = 3, column = 2, padx = 8, pady = 5)
scissors_btn = Button(game_window, text = '3 = Schaar', width = 15, bd = 0, bg = 'pink', pady = 5, command = lambda: player_choice(options[2]))
scissors_btn.grid(row = 3, column = 3, padx = 8, pady = 5)

#Score en keuzes (nog aanvullen) weergeven
score_label = Label(game_window, text = 'Score : ', fg = 'grey')
score_label.grid(row = 4, column = 0)
player_choice_label = Label(game_window, text="")
player_score_label = Label(game_window, text="")
computer_choice_label = Label(game_window, text="")
computer_score_label = Label(game_window, text="")

score_label.place(x=50,y=300)
player_choice_label.place(x=150,y=300)
player_score_label.place(x=400,y=300)
computer_choice_label.place(x=150,y=400)
computer_score_label.place(x=400,y=400)

game_window.mainloop()
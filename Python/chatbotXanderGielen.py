## Een eenvoudige, maar soms toch overtuigende, chatbot.
import random

def zoekAntwoord(gebruikerZegt):
        antwoordZatErin = False
        gebruikerzegtLijst = gebruikerZegt.split(sep= " ")
        for i in gebruikerzegtLijst:
                for j in antwoorden_dict:      
                        if i == j:
                                print(antwoorden_dict[i])
                                return 1
                        elif i == "stop":
                                return 0
        if antwoordZatErin == False:
                willekeurig = random.randint(0, 8)
                print(antwoorden_lijst[willekeurig])

# Dictionary met standaardantwoorden op bepaalde sleutelwoorden
antwoorden_dict ={
    "crasht": "Nou, het crasht nooit op ons systeem. Het moet iets\n" +
            "met uw systeem te maken hebben. Vertel me meer over uw configuratie.",
    
    "traag": "Ik denk dat dit te maken heeft met je hardware. Het\n" +
            "upgraden van je processor zou alle prestatieproblemen moeten\n" +
            "oplossen. Heb je een probleem met je software?",
    
    "prestaties": "De prestaties waren redelijk goed in al onze\n" +
            "tests. Lopen er nog andere processen op de achtergrond?",
    
    "bug": "Nou, weet je, alle software heeft wat bugs. Maar onze\n" +
           "software-ingenieurs werken er hard aan om ze op te lossen. Kunt u\n" +
           "het probleem wat verder beschrijven?",
    
    "windows": "Dit is een bekende bug die te maken heeft met het\n" +
           "Windows besturingssysteem. Meld dit alstublieft bij Microsoft.\n" +
           "Wij kunnen hier niets aan doen.",
    
    "mac": "Dit is een bekende bug die te maken heeft met het\n" +
           "MacOS-besturingssysteem. Meld dit aan Apple. Wij kunnen hier niets\n" +
           "aan doen.",
    
    "duur": "De kosten van ons product zijn vrij concurrentieel. Heb\n" +
            "je goed rondgekeken en onze functies vergeleken?",
    
    "installatie": "De installatie is echt heel eenvoudig. We hebben\n" +
            "een heleboel wizards die al het werk doen.",
    
    "geheugen": "Als je de systeemvereisten goed doorleest, zul je\n" +
            "zien dat we 1,5 GByte verwachten. Je moet echt je geheugen\n" +
            "upgraden. Is er nog iets dat je wilt weten?",
    
    "linux": "We nemen Linux-ondersteuning erg serieus. Maar er zijn\n" +
            "wat problemen. De meeste hebben te maken met incompatibele versies\n" +
            "van glibc. Kun je iets preciezer zijn?",
    
    "chatgpt": "Ahhh, ChatGPT, ja. We hebben lang geleden geprobeerd\n" +
            "die jongens uit te kopen, maar ze wilden gewoon niet\n" +
            "verkopen... Koppige mensen zijn het. We kunnen er niets aan doen,\n"
            "ben ik bang."
            
}

# Lijst met willekeurige standaardantwoorden
antwoorden_lijst = [
  "Dat klinkt vreemd. Kunt u dat probleem gedetailleerder beschrijven?",
  "Geen enkele andere klant heeft hier ooit over geklaagd. Wat is uw systeemconfiguratie?",
  "Dat klinkt interessant. Vertel me meer...",
  "Daar heb ik wat meer informatie over nodig.",
  "Heb je gecontroleerd of je geen dll-conflict hebt?",
  "Dat wordt uitgelegd in de handleiding. Heb je de handleiding gelezen?",
  "Je beschrijving is een beetje vaag. Heb je een expert bij je die dit preciezer kan beschrijven?",
  "Dat is geen bug, dat is een functie!",
  "Kun je daar wat dieper op ingaan?"
]

# Functie die het antwoord teruggeeft op de gestelde vraag
    ## AANVULLEN!


print ("Welkom bij SuperChat, een antwoord op al je vragen.")
print ("(als ze tenminste iets met onze software te maken hebben)")
print ()
print ("Stel je vraag/vragen. Eindig met het woord stop")

# Laat de gebruiker een vraag stellen en geef er antwoord op.
# Stop wanneer hij het woord stop ingeeft
# We maken geen onderscheid tussen hoofd- en kleine letters

while True:
        gebruikerZegt = input("?> ").lower()
        with open("gebruikerInvoer.txt", "a") as bestand:
                bestand.write(gebruikerZegt)
        if zoekAntwoord(gebruikerZegt) == 0:
                break
        
print()
print("Tot ziens. Het deed ons een plezier u goed te kunnen helpen")
## IN TE VULLEN! Gebruik zoek_antwoord

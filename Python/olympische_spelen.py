Tokyo = {"Nafi Thiam", "Red Lions", "Nina Derwaelwonnen", "Wout van Aert", "Bashir Abdi", "jumpingploeg", "Matthias Casse"}
Rio = {"Greg Van Avermaet", "Nafi Thiam", "Pieter Timmers", "Red Lions", "Dirk Van Tichelt", "Jolien Dhoore"}

#print alle winaars van tokyo of rio
print(Tokyo | Rio)
#print alle winnaars van beide
print(Tokyo & Rio)
#print alle winaars van allen rio of alleen tokyo
print(Tokyo ^ Rio)
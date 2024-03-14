studenten = {"Frans": 4, "Boliviaans": 2, "Duits": 1, "Chinees": 2, "Canadees": 3}
print(studenten["Chinees"] > 0)
print(studenten["Boliviaans"])
studenten["Canadees"] += 1
studenten["Nederlanders"] = 1
print(*studenten.keys())
print(*studenten.values())
studenten.pop("Boliviaans")
print(*studenten.keys())
print(len(studenten))
print(sum(studenten.keys()))
using SorterenVanObjecten;

Student student1 = new Student("Thomas", "Gielen", "6IC");
Student student2 = new Student("Bartu", "DeSlaper", "6IW");

Personeel personeel1 = new Personeel("Bart", "Berghmans", 20148);
Personeel personeel2 = new Personeel("Plop", "Kabouter", 14785);
Personeel personeel3 = new Personeel("Lui", "Kabouter", 14785);




List<Personeel> personeel = new List<Personeel> { personeel1, personeel2 };
List<Student> studenten = new List<Student> { student1, student2 };
List<Persoon> personen = new List<Persoon> { student1, student2, personeel1, personeel2, personeel3 };
personen.Sort();
for (int i = 0; i < personen.Count; i++)
{
    Console.WriteLine(personen[i].Achternaam + " " + personen[i].Voornaam);
}
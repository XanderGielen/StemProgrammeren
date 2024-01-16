<?php

//genereer voorbeeld gebruikers
/*
for ($i = 0; $i < 5; $i++) {
    $random = random_int(1, 5);
    
    if ($random == 1) 
    {
        $user =  "3a8rPq9x";
        $tokens = $random;
    }
    else if ($random == 2) 
    {
        $user =  "K2s5GfH7";
        $tokens = $random;
    }
    else if ($random == 3) 
    {
        $user =  "Bp6tRyNl";
        $tokens = $random;
    }
    else if ($random == 4) 
    {
        $user =  "Xv9dLmZo";
        $tokens = $random;
    }
    else if ($random == 5) 
    {
        $user =  "Qc1wFg4u";
        $tokens = $random;
    }
    addUser($user, $tokens);
}
*/



//verhoog of verlaag de tokens van een gebruiker en
//toon alle gebruikers en het verschil
echo increaseTokens("K2s5GfH7", 5);

$allUsers = readUsers();
print_r($allUsers);

echo decreaseTokens("K2s5GfH7", 1);

$allUsers = readUsers();
print_r($allUsers);



//voeg een gebruiker toe, het vraagt een userID en hoeveelheid tokens
//het gaat dan een array maken voor elke token en deze in de file zetten
function addUser($userID, $tokens)
{
    $user = array($userID, $tokens);
    $file = fopen("users.csv", "a");
    fputcsv($file, $user);
    fclose($file);
}

//functie om gebruikersinformatie te lezen
//het gaat lijn per lijn, zet de gebruikers in een array en toont al deze gebruikers
//en als er geen users.csv bestand bestaat maakt hij die aan.
function readUsers()
{
    $row = 1;
    $users = array();
    if (($file = fopen("users.csv", "r")) !== FALSE) {
        while (($data = fgetcsv($file, 1000, ",")) !== FALSE)
        {
            $users[] = $data;
        }

        fclose($file);
    }
    return $users;
}

//verminder het aantal tokens door lijn per lijn te gaan en te zien of
// de userID ingegeven is gelijk is aan degene die op die lijn staat
// en vermindert dan het ingegeven aantal tokens.
function decreaseTokens($userID, $amount)
{
    $users = readUsers();
    foreach ($users as &$user) {
        if ($user[0] == $userID) {
            $user[1] -= $amount;
        }
    }
    writeUsers($users);
}
//hetzelfde maar toevoegen
function increaseTokens($userID, $amount)
{
    $users = readUsers();
    foreach ($users as &$user) {
        if ($user[0] == $userID) {
            $user[1] += $amount;
        }
    }
    writeUsers($users);
}

//dit schrijft alle gebruikers voor de decrease en increase token functies.
function writeUsers($users)
{
    $file = fopen("users.csv", "w");
    foreach ($users as $user) {
        fputcsv($file, $user);
    }
    fclose($file);
}
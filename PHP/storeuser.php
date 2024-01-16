<?php

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

$allUsers = readUsers();
print_r($allUsers);

echo decreaseTokens("K2s5GfH7", 1);

function addUser($userID, $tokens)
{
    $user = array($userID, $tokens);
    $file = fopen("users.csv", "a");
    fputcsv($file, $user);
    fclose($file);
}
// Functie om gebruikersinformatie te lezen
function readUsers()
{
    $users = array();
    if (($file = fopen("users.csv", "r")) !== FALSE) {
        while (($data = fgetcsv($file, 1000, ",")) !== FALSE) {
            $users[] = $data;
        }
        fclose($file);
    }
    return $users;
}

function writeUsers($users)
{
    $file = fopen("users.csv", "w");
    foreach ($users as $user) {
        fputcsv($file, $user);
    }
    fclose($file);
}

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
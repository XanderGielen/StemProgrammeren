<?php
// Increase tokens for user "K2s5GfH7" by 3
echo increaseTokens("K2s5GfH7", 3);

// Read all users from the CSV file and print them
$allUsers = readUsers();
print_r($allUsers);

// Print a paragraph break for better readability
echo "<p>";

// Decrease tokens for user "K2s5GfH7" by 1
echo decreaseTokens("K2s5GfH7", 1);

// Read all users again and print them
$allUsers = readUsers();
print_r($allUsers);

// Function to add a new user with specified userID and tokens
function addUser($userID, $tokens)
{
    $user = array($userID, $tokens);
    $file = fopen("users.csv", "a"); // Open the CSV file in append mode
    fputcsv($file, $user); // Write the user data to the CSV file
    fclose($file); // Close the file
}

// Function to read all users from the CSV file
function readUsers()
{
    $users = array(); // Initialize an empty array to store users
    if (($file = fopen("users.csv", "r")) !== FALSE)
    {
        while (($data = fgetcsv($file, 1000, ",")) !== FALSE)
        {
            $userID = $data[0];
            $users[$userID] = $data[1]; // Store user ID and tokens in the array
        }

        fclose($file); // Close the file
    }
    return $users; // Return the array of users
}

// Function to decrease tokens for a specific user
function decreaseTokens($userID, $amount)
{
    $users = readUsers(); // Read all users
    if (isset($users[$userID])) {
        $users[$userID] -= $amount; // Decrease tokens for the specified user
        writeUsers($users); // Write the updated users array back to the CSV file
    }
}

// Function to increase tokens for a specific user
function increaseTokens($userID, $amount)
{
    $users = readUsers(); // Read all users
    if (isset($users[$userID])) {
        $users[$userID] += $amount; // Increase tokens for the specified user
        writeUsers($users); // Write the updated users array back to the CSV file
    }
}

// Function to write users array to the CSV file
function writeUsers($users)
{
    $file = fopen("users.csv", "w"); // Open the CSV file in write mode
    foreach ($users as $key => $value)
    {
        $data[0]= $key;
        $data[1] = $value;
        fputcsv($file, $data); // Write each user's data to the CSV file
    }
    fclose($file); // Close the file
}


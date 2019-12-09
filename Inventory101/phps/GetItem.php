<?php
ob_start();

    $server_name = "localhost";
    $server_username = "root";
    $server_password = "";
    $database_name = "nsirpg";


    $username = $_POST["username"];


    $conn = new mysqli($server_name, $server_username, $server_password, $database_name);
    if (!$conn)
    {
        die("Connection failed.".mysqli_connect_error());
    }



    
    $getItemsQuery = "SELECT items FROM users WHERE username = '".$username."'";
    $getItemsResult = mysqli_query($conn, $getItemsQuery);

    ob_end_clean();

    $existingInfo = mysqli_fetch_assoc($getItemsResult);
    $returnedItems = $existingInfo["items"];
    echo $returnedItems;

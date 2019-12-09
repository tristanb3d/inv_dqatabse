<?php
ob_start();

    $server_name = "localhost";
    $server_username = "root";
    $server_password = "";
    $database_name = "nsirpg";


    $items = $_POST["items"];
    $username = $_POST["username"];



    $conn = new mysqli($server_name, $server_username, $server_password, $database_name);
    if (!$conn)
    {
        echo "failed to connect to ".$server_name." :".mysqli_connect_error();
    }
    else
    {
        //echo "Connection success - " .$database_name." \n";
    }


    $saveItemQuery = "UPDATE users SET items = '".$items."' WHERE username = '".$username."'";
 
    $saveItemResult = mysqli_query($conn, $saveItemQuery) or die("failed -  ".$username);

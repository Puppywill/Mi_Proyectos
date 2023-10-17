<?php
    //--------------------------------------------- 
     //File: TennisRegistro.html

     // Programmer: William A.Rosado Pérez
     // Estudent Number: Y00599400
     //Descripion: php_delete 




$nombre = $_POST['Nombre'];



// Conexion a la base 
$db_conn = new mysqli('localhost','root','','shoe');

// Verificar si un error

if($db_conn->connect_error)
{
   die('ERROR: base de dato'.$db_conn->connect_error);
}
else
{
    $sql_stmt = "SELECT * FROM tennis WHERE Nombre = '$nombre';";
    
    $query_result = $db_conn->query($sql_stmt);


    if($query_result->num_rows>0)
    {
        $sql = "DELETE FROM tennis WHERE Nombre = '$nombre'";;
        $sql_stmt = $db_conn->prepare($sql);
        $sql_stmt->execute();
        echo true;
    }
    else{
    	echo false;
    }

    $db_conn->close();
}

?>
<?php
  //--------------------------------------------- 
     //File: TennisRegistro.html

     // Programmer: William A.Rosado Pérez
     // Estudent Number: Y00599400
     //Descripion: PHP select


{
	$nombre = $_POST['Nombre'];

	$db_conn = new mysqli('localhost','root','','shoe');



if($db_conn->connect_error)
{
   die('ERROR: base de dato'.$db_conn->connect_error);
}
else
{
   
 $sql_stmt = "SELECT Nombre,Apellido,Email,genero,marca,Tennis,FechaNacimiento,Comentario,acuerdo
 FROM tennis WHERE Nombre ='$nombre'";


 $query_result= $db_conn->query($sql_stmt);

 if($query_result->num_rows >0)
 { 
 	while($row = $query_result->fetch_assoc())
 	{

        $contactRecord = array(

        	"Nombre"=>$row['Nombre'],
        	"Apellidos"=>$row['Apellido'],
        	"Email"=>$row['Email'],
        	"birthdaytime"=>$row['FechaNacimiento'],
        	"Marca Fvorita"=>$row['marca'],
        	"TenisFavorita"=>$row['Tennis'],
        	"Comentario"=>$row['Comentario'],
        	"acuerdo"=>$row['acuerdo'],
         "Genero"=>$row['genero']

        );
        echo json_encode($contactRecord);
      }
   }
       else
       {
          echo(false);      
       }

       $db_conn->close();

 	}

 }

?>
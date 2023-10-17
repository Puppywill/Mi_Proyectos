<?php
    //--------------------------------------------- 
     //File: TennisRegistro.html

     // Programmer: William A.Rosado Pérez
     // Estudent Number: Y00599400
     //Descripion: PHP update




$nombre = $_POST['Nombre'];
$apellido = $_POST['Apellido'];
$email = $_POST['Email'];
$fechanacimiento = $_POST['FechaNacimiento'];
$marca = $_POST['MarcaFvorita'];
$tennis = $_POST['TenisFavorita'];
$comentario = $_POST['Comentario'];
$acuerdo =$_POST['Acuerdo'];
$genero = $_POST['Genero'];


// Conexion a la base 
$db_conn = new mysqli('localhost','root','','shoe');

// Verificar si un error

if($db_conn->connect_error)
{
   die('ERROR: base de dato'.$db_conn->connect_error);
}
else
{  $sql_stmt="UPDATE tennis set

    Nombre ='$nombre',
    Apellido ='$apellido',
    Email ='$email',
    genero ='$genero',
    Marca = '$marca',
    Tennis ='$tennis',
    FechaNacimiento = '$fechanacimiento',
    Comentario ='$comentario',
    acuerdo = '$acuerdo'

    WHERE Nombre ='$nombre'";

if($db_conn->query($sql_stmt)==true)
{
    echo(true);
}
else
{
	echo(false);
}

$db_conn->close();

}



?>
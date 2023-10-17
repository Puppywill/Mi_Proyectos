<?php 
    //--------------------------------------------- 
     //File: TennisRegistro.html

     // Programmer: William A.Rosado Pérez
     // Estudent Number: Y00599400
     //Descripion: Php_insert



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
{

  $sql = "INSERT INTO tennis VALUES (?,?,?,?,?,?,?,?,?);";
  $sql_stmt = $db_conn->prepare($sql);
  $sql_stmt->bind_param('sssssssss',$nombre,$apellido,$email, $genero,$marca,$tennis, $fechanacimiento, $comentario,$acuerdo);
}

if($sql_stmt->execute() === true)
{
  echo (true);
}
else
{
   echo(false);
}


$sql_stmt->close();
$db_conn->close();

?>
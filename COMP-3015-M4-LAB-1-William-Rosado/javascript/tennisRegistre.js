


     
     //--------------------------------------------- 
     //File: TennisRegistro.html

     // Programmer: William A.Rosado Pérez
     // Estudent Number: Y00599400
     //Descripion: Esta pagina son para lo fanatico que le gusta la tennis se utilizo javascript 
      // y con php






var nombre;
var apellidos;
var email;
var fechaNacimiento;
var seleccionarMarca;
var tenisFav;
var acuerdoRegist;

let regNombreCompleto = /^[a-zA-Z]+$/
let regEmail = /^[a-zA-Z0-9]+\@[a-zA-Z]+[\.][a-z]{3,4}$/


function alerta_error(mensaje)
{
	document.getElementById('mensaje').innerHTML= mensaje;
	$('#alertaError').modal('show');
}



function alerta_correcta(mensaje)
{
	document.getElementById('mensajecorrecto').innerHTML= mensaje;
	$('#alertaCorrecta').modal('show');
}


function verificarFormulario() {
	
	var count = 0;
	var message = "";
	var nombre = document.getElementById('fullName').value;
	if(!nombre.match(regNombreCompleto) || nombre == "")
	{
		message = "Nombre";
		count++;
	}

	var apellidos = document.getElementById('lastName').value;
	if(!apellidos.match(regNombreCompleto) || apellidos == "")
	{
		message = "Apellidos"
		count++;
	}

	var email = document.getElementById('email').value;
	if(!email.match(regEmail) || email == "")
	{
		message = "Email"
		count++;
    }
	var fechaNacimiento = document.getElementById('birthdaytime').value;
	if(!fechaNacimiento)
	{
		message = "FechaNacimiento";
		count++;	
	}

	if (count > 0 ) 
	{
		alerta_error("Error tiene que llenar la informacion ");
		console.log(message)
		return false;
	}
	else
	{
       alerta_correcta("ESta correcto la informacion y esta lleno")
		return true;
	}


	guardarInformacion();

	return true;
}

function obtenerGenero()
{
	var generoHombre = document.getElementById('gHombre');
	var generoMujer = document.getElementById('gMujer');
	var generoOtro = document.getElementById('gOtro');

	if(generoHombre.checked)
	{
		localStorage.setItem("Genero",document.getElementById('gHombre').value);
	}
	else if(generoMujer.checked)
	{
		localStorage.setItem("Genero",document.getElementById('gMujer').value);
	}
	else if(generoOtro.checked)
	{
		localStorage.setItem("Genero",document.getElementById('gOtro').value);
	}
}

function verificarAcuerdo()
{
	var acuerdoRegist = document.getElementById('acuerdo');
	if(acuerdoRegist.checked == true)
	{
		localStorage.setItem("Acuerdo","Esta de acuerdo");
	}
	else if(acuerdoRegist.checked != true)
	{
		localStorage.setItem("Acuerdo","No esta de acuerdo");
	}

	return false;
}

function subirImagen() {
	tenisFav = document.getElementById('tennisFavorita');

	var file = tenisFav.files[0];

	document.getElementById('imgTenis').src = "../images/" + file.name;
}

function guardarInformacion() 
{
	if (typeof(Storage) !== "undefined") 
	{
		localStorage.setItem("Nombre",document.getElementById('fullName').value);
		localStorage.setItem("Apellidos",document.getElementById('lastName').value);
		localStorage.setItem("Email",document.getElementById('email').value);
		localStorage.setItem("Fecha de nacimiento",document.getElementById('birthdaytime').value);
		obtenerGenero();
		localStorage.setItem("Marca Fvorita",document.getElementById('elegir').value);
		localStorage.setItem("Tenis Favorita",document.getElementById('tennisFavorita').value);
		verificarAcuerdo();
		localStorage.setItem("Comentario",document.getElementById('comentario').value);
	}	
}

function reiniciarFormulario()
{
	document.getElementById("webForm").reset();

	document.getElementById('imgTenis').src = "../images/space.png";

	return false;
}

function php_insert()

{
	var resultok = verificarFormulario();

	
	if(!resultok){
		return alerta_error("NO se pudo insertar la informacion") ;
	}
	else
	{

		// Transformando datos
		var acuerdoRegist = document.getElementById('acuerdo');

		var generoHombre = document.getElementById('gHombre');
		var generoMujer = document.getElementById('gMujer');
		var generoOtro = document.getElementById('gOtro');
		var generoValor = "";
		var acuerdoreg ="";

		if (generoHombre.checked)
		{
			generoValor = generoHombre.value;
		}
		else if (generoMujer.checked)
		{
           generoValor = generoMujer.value;
		} 
		else if ( generoOtro.checked)
		{
               generoValor = generoOtro.value;
		}

      if (acuerdoRegist.checked)
      {
      	 acuerdoRegist.value = "Si";
         acuerdoreg = acuerdoRegist.value;
      }
      else if(acuerdoRegist.checked != true)
      {
      	acuerdoRegist.value = "No";
         acuerdoreg = acuerdoRegist.value;
      }

	var imagenSelect =$('#imgTenis').attr('src');
		var tennisFav = imagenSelect.slice(10,);
		// Object datos
		var data = new FormData();
		data.append("Nombre", document.getElementById('fullName').value);
        data.append("Apellido", document.getElementById('lastName').value);
        data.append("Email",document.getElementById('email').value);
		data.append("FechaNacimiento",document.getElementById('birthdaytime').value);
        data.append("MarcaFvorita",document.getElementById('elegir').value);
		data.append("TenisFavorita",tennisFav);
        data.append("Comentario",document.getElementById('comentario').value);
        data.append("Genero",generoValor);
        data.append("Acuerdo",acuerdoreg);

      // Conectar respuesta php 
        var xhr = new XMLHttpRequest();

        xhr.open('POST','../php/php_insert.php');

        xhr.onload = function()
        {
            console.log(this.response);

            let resultado = this.response;


            if( resultado == true)
            {
                alerta_correcta("Record insertado");
            }
            else
            {
                  alerta_error("No se inserto");
                  return false;
            }
        }

        xhr.send(data);
    }
}

function php_select()
{
		// Object datos
		var data = new FormData();
		data.append("Nombre", document.getElementById('fullName').value);
        
        

      // Conectar respuesta php 
        var xhr = new XMLHttpRequest();

        xhr.open('POST','../php/php_select.php');

        xhr.onload = function()
        {

            // console.log(this.response);

            let resultado = this.response;
     
            
 

            if (resultado != false) 
            {
                const arrayInputsValues = JSON.parse(resultado);
                console.log(arrayInputsValues['Marca Fvorita']);
               	console.log(arrayInputsValues['Nombre']);
                document.getElementById('fullName').value=arrayInputsValues['Nombre'];
                document.getElementById('lastName').value=arrayInputsValues['Apellidos'];
                document.getElementById('email').value= arrayInputsValues['Email'];
                document.getElementById('imgTenis').src ="../images/" + arrayInputsValues['TenisFavorita']
                // document.getElementById('elegir').value=arrayInputsValues['Marca'];
                // document.getElementById('tennisFavorita').value=arrayInputsValues['TenisFavorita'];
                document.getElementById('comentario').value=arrayInputsValues['Comentario'];
                
                // La fecha de nacimiento que se enseña en la pagina
       			document.getElementById('birthdaytime').value = convertDate(arrayInputsValues['birthdaytime']);
              
       			function convertDate(date){
					var day = date.slice(8);
					var month =date.slice(5,7);
					var year = date.slice(0,4);

					return `${year}-${month}-${day}` ;
				}



              // marca id


            
 
            switch(arrayInputsValues['Marca Fvorita'])
                 {
                     case"Nike":
                     	//document.getElementById('Nike').checked=true;
                    document.getElementById('elegir').value = arrayInputsValues['Marca Fvorita'];
                     	break;
                     case "Jordan":
                     	// document.getElementById('Jordan').checked=true;
                     	document.getElementById('elegir').value = arrayInputsValues['Marca Fvorita'];
                     	break;
                     case"Yeezy":
                     	//document.getElementById('Yeezy').checked=true;
                     	document.getElementById('elegir').value = arrayInputsValues['Marca Fvorita'];
                     	break;
                 }

                 // genero que marca
                 switch(arrayInputsValues['Genero'])
                 {
                     case"Hombre":
                     	// document.getElementById('generoHombre').checked=true;
                     	document.getElementById('gHombre').checked = true;
                     	break;
                     case "Mujer":
                     	// document.getElementById('generoMujer').checked=true;
                     	document.getElementById('gMujer').checked = true;
                     	break;
                     case"Otro":
                     	// document.getElementById('generoOtro').checked=true;
                     	document.getElementById('gOtro').checked = true
                     	break;
                 }

             // acuerdo check
              switch(arrayInputsValues['acuerdo'])
              {
                   case "1":
                   	document.getElementById('acuerdo').checked=true;
                   	break;
                   case "0":
                   	document.getElementById('acuerdo').checked=false;
                   	break;
              }
      


                                
                alerta_correcta("Record se encontro");
                }
           	 else
            	{
                  alerta_error("No se encontro la persona");
                  return false;
            	} 
            }
            

        xhr.send(data);

}

function php_update()
{
    

	var resultok = verificarFormulario();

	
	if(!resultok){
		return alerta_error("NO se pudo editar") ;;
	}
	else
	{

		// Transformando datos
		var acuerdoRegist = document.getElementById('acuerdo');

		var generoHombre = document.getElementById('gHombre');
		var generoMujer = document.getElementById('gMujer');
		var generoOtro = document.getElementById('gOtro');
		var generoValor = "";
		var acuerdoreg ="";

		if (generoHombre.checked)
		{
			generoValor = generoHombre.value;
		}
		else if (generoMujer.checked)
		{
           generoValor = generoMujer.value;
		} 
		else if ( generoOtro.checked)
		{
               generoValor = generoOtro.value;
		}

      if (acuerdoRegist.checked)
      {
      	 acuerdoRegist.value = "Si";
         acuerdoreg = acuerdoRegist.value;
      }
      else if(acuerdoRegist.checked != true)
      {
      	acuerdoRegist.value = "No";
         acuerdoreg = acuerdoRegist.value;
      }

		var imagenSelect =$('#imgTenis').attr('src');
		var tennisFav = imagenSelect.slice(10,);
		// Object datos
		var data = new FormData();
		data.append("Nombre", document.getElementById('fullName').value);
        data.append("Apellido", document.getElementById('lastName').value);
        data.append("Email",document.getElementById('email').value);
		data.append("FechaNacimiento",document.getElementById('birthdaytime').value);
        data.append("MarcaFvorita",document.getElementById('elegir').value);
		data.append("TenisFavorita",tennisFav);
        data.append("Comentario",document.getElementById('comentario').value);
        data.append("Genero",generoValor);
        data.append("Acuerdo",acuerdoreg);

      // Conectar respuesta php 
        var xhr = new XMLHttpRequest();

        xhr.open('POST','../php/php_update.php');

        xhr.onload = function()
        {
            console.log(this.response);

            let resultado = this.response;


            if( resultado == true)
            {
                alerta_correcta("Se guardo el registro el edit");
            }
            else
            {
                 alerta_error("No se puede edit");
                  return false;
            }
        }

        xhr.send(data);
    }
}

function php_delete()
{

	var resultok = verificarFormulario();

	
	if(!resultok){
		return alerta_error('No se puede eliminar');
	}
	else
	{
        var data = new FormData();
		data.append("Nombre", document.getElementById('fullName').value);



		var xhr = new XMLHttpRequest();

        xhr.open('POST','../php/php_delete.php');

        xhr.onload = function()
        {
            console.log(this.response);

            let resultado = this.response;
            if( resultado == true)
            {
                alerta_correcta('SE borro !!!!!!!');
            }
            else
            {
                  alerta_error('No se borro');
                  return false;
            }
        }

        xhr.send(data);
    }

}


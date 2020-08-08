/*remover mensaje de validacion*/
$(document).ready(function () {
    $('.alert').click(function () {
        $(this).remove();
    });
});


/*mostrar pass*/

function mostrarContrasena() {
        var tipo = document.getElementById("pass");
        if (tipo.type == "password") {
    tipo.type = "text";
        } else {
    tipo.type = "password";
        }
    }

/*busqueda rapida*/
$(document).ready(function () {
    function Contains(text_one, text_two) {
        if (text_one.indexOf(text_two) != -1)
            return true;
    }
        $("#Search").keyup(function () {
            var searchText = $("#Search").val().toLowerCase();
            $(".Search").each(function () {
                if (!Contains($(this).text().toLowerCase(), searchText)) {
    $(this).hide();
                }
                else {
    $(this).show();
                }
            });
        });
    });


$(document).ready(function () {
    //obtenemos el valor de los input

    $('#adicionar').click(function () {
        var nombre = document.getElementById("nombre").value;
        var apellido = document.getElementById("apellido").value;
        var cedula = document.getElementById("cedula").value;
        var cantidad = document.getElementById("cantidad").value;
        var i = 1; //contador para asignar id al boton que borrara la fila
        var fila = '<tr id="row' + i + '"><td>' + nombre + '</td><td>' + apellido + '</td><td>' + cedula + '</td><td>' + cantidad + '</td><td><button type="button" name="remove" id="' + i + '" class="btn btn-danger btn_remove">Quitar</button></td></tr>'; //esto seria lo que contendria la fila

        i++;

        $('#mytable tr:first').after(fila);
        $("#adicionados").text(""); //esta instruccion limpia el div adicioandos para que no se vayan acumulando
        var nFilas = $("#mytable tr").length;
        $("#adicionados").append(nFilas - 1);
        //le resto 1 para no contar la fila del header
        document.getElementById("apellido").value = "";
        document.getElementById("cedula").value = "";
        document.getElementById("nombre").value = "";
        document.getElementById("cantidad").value = "";
        document.getElementById("nombre").focus();
    });
    $(document).on('click', '.btn_remove', function () {
        var button_id = $(this).attr("id");
        //cuando da click obtenemos el id del boton
        $('#row' + button_id + '').remove(); //borra la fila
        //limpia el para que vuelva a contar las filas de la tabla
        $("#adicionados").text("");
        var nFilas = $("#mytable tr").length;
        $("#adicionados").append(nFilas - 1);
    });
});
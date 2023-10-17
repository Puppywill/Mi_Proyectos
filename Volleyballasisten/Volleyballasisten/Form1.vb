

'Programa de venta volleyball'
'William A.Rosado'
'Y00599440'
'Comp-3900'


Public Class Form1

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Dim totalIngresos As Integer = 0
        Dim totalnivel As Integer = 0
        Dim totalnivel2 As Integer = 0
        Dim totalnivel3 As Integer = 0
        Dim totalAsistencia As Integer = 0

        Dim dia As Integer = 1

        ' Lista para almacenar los nombres de los días de la semana
        Dim diasSemana As New List(Of String) From {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"}

        ' Variable para almacenar el resultado final
        Dim resultadoTexto As String = ""


        Const cmulti As Integer = 20
        Const cmulti2 As Integer = 15
        Const cmulti3 As Integer = 10

        Do While dia <= 7
            Try


                ' Obtiene la cantidad de asientos vendidos para el día actual
                Dim nivel1 As Integer = CInt(InputBox("Ingrese la cantidad de asientos vendidos para el Nivel 1 del " & diasSemana(dia - 1)))
                Dim nivel2 As Integer = CInt(InputBox("Ingrese la cantidad de asientos vendidos para el Nivel 2 del " & diasSemana(dia - 1)))
                Dim nivel3 As Integer = CInt(InputBox("Ingrese la cantidad de asientos vendidos para el Nivel 3 del " & diasSemana(dia - 1)))

                ' Calcula el ingreso para el día actual y lo agrega al resultadoTexto
                Dim ingresoDia As Integer = nivel1 * cmulti + nivel2 * cmulti2 + nivel3 * cmulti3
                Dim total1 As Integer = nivel1 * cmulti
                Dim total2 As Integer = nivel2 * cmulti2
                Dim total3 As Integer = nivel3 * cmulti3

                Dim ingresoporDia As Integer = nivel1 + nivel2 + nivel3

                Listboxresultado.Items.Add(resultadoTexto)
                Listboxresultado.Items.Add((diasSemana(dia - 1)))
                Listboxresultado.Items.Add("Nivel 1:" & vbCrLf & nivel1.ToString())
                Listboxresultado.Items.Add("Nivel 2:" & vbCrLf & nivel2.ToString())
                Listboxresultado.Items.Add("Nivel 3:" & vbCrLf & nivel3.ToString())


                ' Suma el ingreso del día al total de ingresos
                totalIngresos += ingresoDia
                totalnivel += nivel1
                totalnivel2 += nivel2
                totalnivel3 += nivel3
                totalAsistencia = totalnivel + totalnivel2 + totalnivel3
            Catch ex As Exception
                MessageBox.Show("Por favor, ingrese datos válidos para el día " & diasSemana(dia - 1))
                Exit Sub
            End Try

            ' Incrementa el día para la próxima iteración del bucle
            dia += 1
        Loop

        ' Muestra el ingreso total de la semana y los ingresos por día en Lblresultado1
        Listboxresultado.Items.Add(resultadoTexto)
        Listboxresultado.Items.Add("Ingresos por asistencia:")
        Listboxresultado.Items.Add("Nivel 1:" & vbCrLf & totalnivel.ToString("n0"))
        Listboxresultado.Items.Add("Nivel 2:" & vbCrLf & totalnivel2.ToString("n0"))
        Listboxresultado.Items.Add("Nivel 3:" & vbCrLf & totalnivel3.ToString("n0"))
        Listboxresultado.Items.Add(resultadoTexto)
        Listboxresultado.Items.Add("Total asistencia:" & vbCrLf & totalAsistencia.ToString("n0"))
        Listboxresultado.Items.Add(resultadoTexto)
        Listboxresultado.Items.Add("Ingreso total de la semana: " & totalIngresos.ToString("c2"))
        Listboxresultado.Items.Add("")

    End Sub

    ' Resto del código aquí...




    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ' Limpia los datos en los TextBox y Labels

        Txtnivel1.Clear()
        Txtnivel2.Clear()
        Txtnivel3.Clear()

        Listboxresultado.Items.Clear()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        ' Sale de la aplicación
        Application.Exit()
    End Sub


End Class


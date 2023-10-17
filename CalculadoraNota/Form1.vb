Imports System.Diagnostics.Eventing.Reader
'William A.Rosado Pérez'
'Y00599440'
'COMP3900
Public Class Form1


    Private Sub Btnresultado_Click(sender As Object, e As EventArgs) Handles Btnresultado.Click
        Const Porciento_result As Double = 100.0
        Const Resultado_Numero As Integer = 4




        If String.IsNullOrWhiteSpace(Txtnombre.Text) Then
            MessageBox.Show("Llene su registro completo", "Campo Vacío de nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim nombre As String = Txtnombre.Text



            If String.IsNullOrWhiteSpace(Txtapellido.Text) Then

                MessageBox.Show("Llene su registro completo", "Campo Vacío de apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim apellido As String = Txtapellido.Text








            End If
        End If




        Try


            Dim Aviso As Double

            Aviso = Txtnota1.Text

            Aviso = Txtnota2.Text

            Aviso = Txtnota3.Text

            Aviso = Txtnota4.Text


        Catch
            MessageBox.Show("Por favor llene  lo numero que te vamos inticar")

        End Try

        Try


            Dim Resulatdonota1 As Double

            Resulatdonota1 = Txtnota1.Text


        Catch
            MessageBox.Show("Por favor llene numero de nota 1 ")

        End Try


        Try
            Dim Resulatdonota2 As Double
            Resulatdonota2 = Txtnota2.Text

        Catch
            MessageBox.Show("Por favor llene numero de nota 2")
        End Try



        Try


            Dim Resulatdonota3 As Double

            Resulatdonota3 = Txtnota3.Text


        Catch
            MessageBox.Show("Por favor llene numero de nota 3 ")

        End Try

        Try


            Dim Resulatdonota4 As Double

            Resulatdonota4 = Txtnota4.Text

            Txtnota4.Text = Resulatdonota4.ToString("")
        Catch
            MessageBox.Show("Por favor llene numero de nota 4 ")

        End Try


        Try
            Dim Resultado_promedio As Double

            Resultado_promedio = (CDbl(Txtnota1.Text) + CDbl(Txtnota2.Text) + CDbl(Txtnota3.Text) + CDbl(Txtnota4.Text)) / Porciento_result


            Lblresultadonota.Text = Resultado_promedio.ToString()


        Catch


        End Try





        Try
            Dim Resultado_final As Double


            Resultado_final = (CDbl(Txtnota1.Text) + CDbl(Txtnota2.Text) + CDbl(Txtnota3.Text) + CDbl(Txtnota4.Text)) / Resultado_Numero


            Lblcaculo.Text = Resultado_final.ToString("0.00")

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try






        Try


            Dim Resultado_final As Double


            Resultado_final = (CDbl(Txtnota1.Text) + CDbl(Txtnota2.Text) + CDbl(Txtnota3.Text) + CDbl(Txtnota4.Text)) / Resultado_Numero


            Lblresultado.Text = Resultado_final.ToString()




            If Resultado_final <= 59.99 Then
                Lblresultado.Text = "F"
            ElseIf Resultado_final <= 69.99 Then
                Lblresultado.Text = "D"
            ElseIf Resultado_final <= 79.99 Then
                Lblresultado.Text = "C"  ' Cambiado de "<=" a "<="
            ElseIf Resultado_final <= 89.99 Then
                Lblresultado.Text = "B"
            Else
                Lblresultado.Text = "A"
            End If


            If Resultado_final > 95.0 Then
                MessageBox.Show("¡Felicitaciones, " & Txtnombre.Text & " " & Txtapellido.Text & " " & Txtestudianteid.Text & "! Eres un estudiante de honor wow.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("¡" & Txtnombre.Text & " " & Txtapellido.Text & ", debes tomar un curso de verano!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch

        End Try



        Try
            Dim Resultado_nombre As String
            Dim Resultado_apellido As String
            Dim Resultado_numeroid As Integer
            Resultado_nombre = Txtnombre.Text
            Resultado_apellido = Txtapellido.Text
            Resultado_numeroid = Txtestudianteid.Text

            Lblnombrergresultado.Text = Resultado_nombre.ToString()
            Lblapellidorgresultado.Text = Resultado_apellido.ToString()
            Lblnumeroesturesultado.Text = Resultado_numeroid.ToString()



        Catch



        End Try

    End Sub








    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click

        If String.IsNullOrWhiteSpace(Txtnombre.Text) Then
            MessageBox.Show("Llene su registro completo", "Campo Vacío de nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim nombre As String = Txtnombre.Text
            Txtnombre.Clear()


            If String.IsNullOrWhiteSpace(Txtapellido.Text) Then

                MessageBox.Show("Llene su registro completo", "Campo Vacío de apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim apellido As String = Txtapellido.Text



                Txtapellido.Clear()




            End If
        End If

        Txtestudianteid.Clear()
        Txtnota1.Clear()
        Txtnota2.Clear()
        Txtnota3.Clear()
        Txtnota4.Clear()
        MessageBox.Show("Se borro ", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error)








    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click


        MessageBox.Show("¡Gracias por visitarnos ", "Notas de las clases", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Application.Exit()



    End Sub












    'If String.IsNullOrWhiteSpace(Txtapellido.Text) Then

    ' MessageBox.Show("Por favor, ingrese un Apellido antes de continuar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    ' Else
    ' Aquí puedes realizar alguna acción si el campo no está vacío
    ' Por ejemplo, guardar los datos
    'Dim apelldio As String = Txtapellido.Text
    'Txtapellido.Clear()
    ' End If





End Class

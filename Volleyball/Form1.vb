'Porgrama de venta volleyball'
'William A.Rosado'
'Y00599440'
'Comp-3900'

Public Class Form1

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Try
            Dim Resultado As Integer


            Txtnivel1.Clear()
            Txtnivel2.Clear()
            Txtnivel3.Clear()
            Txtventa1.Clear()
            Textnivel2.Clear()
            Textnivel3.Clear()


            TxtResultado.Text = "" ' Limpiar el resultado en la etiqueta'
            TxtResultado.Text = Resultado.ToString()

        Catch
            MessageBox.Show("No tiene nada")

        End Try
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Try
            Const cmulti As Integer = 20
            Const cmulti2 As Integer = 15
            Const cmulti3 As Integer = 10

            Dim xResulatdo As Integer
            xResulatdo = CInt(Txtnivel1.Text * cmulti) + CInt(Txtnivel2.Text * cmulti2) + CInt(Txtnivel3.Text * cmulti3)


            TxtResultado.Text = xResulatdo.ToString("c2")
        Catch
            MessageBox.Show("Por favor ingresa la taquilla ")

        End Try

        Try
            Dim Result1 As Integer
            Result1 = CInt(Txtnivel1.Text * Lblnivel120.Text)



            Txtventa1.Text = Result1.ToString()

        Catch



        End Try

        Try
            Dim Result2 As Integer
            Result2 = CInt(Txtnivel2.Text * Lblnivel215.Text)



            Textnivel2.Text = Result2.ToString()

        Catch



        End Try



        Try
            Dim Result3 As Integer
            Result3 = CInt(Txtnivel3.Text * Lblnivel310.Text)



            Textnivel3.Text = Result3.ToString()

        Catch



        End Try










    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Try
            MessageBox.Show("¡Gracias por usar nuestra aplicación de venta! ")
            Application.Exit()

        Catch ex As Exception
            MessageBox.Show("Gracias por visitarnos de volleyball")
        End Try
    End Sub

End Class

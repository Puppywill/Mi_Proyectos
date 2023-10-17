Imports System.Windows.Forms


'William A.Rosado Pérez'
'Y00599400'
'COMP3900'


Public Class Form1

    Const IncomeTaxRate As Double = 0.115
    Const OnlineDiscountRate As Double = 0.02

    Private Sub CalcularPrecioBtn_Click(sender As Object, e As EventArgs) Handles CalcularPrecioBtn.Click

        Dim nombreProducto As String = TxtNombreProducto.Text
        Dim numeroProducto As String = TxtNumeroProducto.Text
        Dim tipoVenta As String = CmbTipoVenta.SelectedItem.ToString()

        If String.IsNullOrWhiteSpace(nombreProducto) Then
            MessageBox.Show("Por favor llene nombre de producto con letras", "Nombre del Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            nombreProducto = TxtNombreProducto.Text
        End If




        Dim costoProducto As Double

        If Not Double.TryParse(TxtCostoProducto.Text, costoProducto) Then
            MessageBox.Show("El costo del producto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim porcentajeGanancia As Double

        If costoProducto < 125.0 Then
            porcentajeGanancia = 0.15
        Else
            porcentajeGanancia = 0.2
        End If


        Dim precioVenta As Double = costoProducto * (1 + porcentajeGanancia)


        If tipoVenta = "En línea" Then
            precioVenta = precioVenta * (1 - OnlineDiscountRate)
        End If


        Dim incomeTax As Double = precioVenta * IncomeTaxRate

        ' Calcular el precio fina
        Dim precioFinal As Double = precioVenta + incomeTax


        LblTipoVenta.Text = "Tipo de Venta: " & tipoVenta
        Lblnombretext.Text = "Nombre del Producto: " & nombreProducto
        Lblprecioventas.Text = "Precio de Venta: $" & precioVenta.ToString("0.00")
        Lblincometax.Text = "Income Tax: $" & incomeTax.ToString("0.00")
        Lblfinal.Text = "Precio Final: $" & precioFinal.ToString("0.00")
    End Sub

    ' 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar opciones de tipo de venta
        CmbTipoVenta.Items.Add("Presencial")
        CmbTipoVenta.Items.Add("En línea")
        CmbTipoVenta.SelectedIndex = 0 ' Establecer la selección predetermina
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        MessageBox.Show("¡Gracias por visitarnos ", "Tiendacom")
        Application.Exit()

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        TxtNombreProducto.Clear()
        TxtCostoProducto.Clear()
        TxtNumeroProducto.Clear()

        MessageBox.Show("Se borro ", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub


End Class

Public Class Product

    Public Property ID As Integer
    Public Property Name As String
    Public Property Category As String
    Public Property Quantity As Integer
    Public Property Price As Double


    Public Sub New(id As Integer, name As String, category As String, quantity As Integer, price As Double)

        Me.ID = id
        Me.Name = name
        Me.Category = category
        Me.Quantity = quantity
        Me.Price = price

    End Sub


    Public Sub DisplayProduct()

        Console.WriteLine("-----------------------")
        Console.WriteLine("Product ID: " & ID)
        Console.WriteLine("Name: " & Name)
        Console.WriteLine("Category: " & Category)
        Console.WriteLine("Quantity: " & Quantity)
        Console.WriteLine("Price: $" & Price)

    End Sub

End Class

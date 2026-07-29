Imports System.Collections.Generic


Public Class InventoryManager

    Private Products As New List(Of Product)


    Public Sub AddProduct(product As Product)

        Products.Add(product)

        Console.WriteLine("Product added successfully!")

    End Sub



    Public Sub ViewProducts()

        Console.WriteLine(vbNewLine & "Inventory List")

        For Each product In Products

            product.DisplayProduct()

        Next

    End Sub



    Public Sub SearchProduct(keyword As String)

        For Each product In Products

            If product.Name.ToLower().Contains(keyword.ToLower()) Then

                product.DisplayProduct()

            End If

        Next

    End Sub



    Public Sub ShowLowStock()

        Console.WriteLine(vbNewLine & "Low Stock Items")

        For Each product In Products

            If product.Quantity < 5 Then

                product.DisplayProduct()

            End If

        Next

    End Sub


End Class

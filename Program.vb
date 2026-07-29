Module Program


    Sub Main()


        Dim inventory As New InventoryManager()


        inventory.AddProduct(
            New Product(1, "Laptop", "Electronics", 3, 899.99)
        )


        inventory.AddProduct(
            New Product(2, "Keyboard", "Accessories", 15, 49.99)
        )


        inventory.AddProduct(
            New Product(3, "Monitor", "Electronics", 2, 199.99)
        )



        While True


            Console.WriteLine(""
            
Inventory Management System

1. View Inventory
2. Search Product
3. View Low Stock
4. Exit

Choose option:
            "")


            Dim choice As String = Console.ReadLine()



            Select Case choice


                Case "1"

                    inventory.ViewProducts()


                Case "2"

                    Console.WriteLine("Enter product name:")

                    Dim search As String = Console.ReadLine()

                    inventory.SearchProduct(search)



                Case "3"

                    inventory.ShowLowStock()



                Case "4"

                    Console.WriteLine("Closing system...")
                    Exit While



                Case Else

                    Console.WriteLine("Invalid option.")

            End Select


        End While


    End Sub


End Module

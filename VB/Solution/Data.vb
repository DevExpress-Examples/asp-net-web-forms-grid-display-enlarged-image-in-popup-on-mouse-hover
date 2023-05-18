Imports System.Collections.Generic

Namespace Solution

    Public Class Data

        Public Property ID As Integer

        Public Property Description As String

        Public Property ImageUrl As String
    End Class

    Public Class DataHelper

        Public Shared Function GenerateData() As List(Of Data)
            Return New List(Of Data)() From {New Data() With {.ID = 0, .Description = "Basket", .ImageUrl = "Images/Basket.png"}, New Data() With {.ID = 1, .Description = "Customer", .ImageUrl = "Images/Customer.png"}, New Data() With {.ID = 2, .Description = "Home", .ImageUrl = "Images/Home.png"}, New Data() With {.ID = 3, .Description = "Mail", .ImageUrl = "Images/Mail.png"}, New Data() With {.ID = 4, .Description = "Check", .ImageUrl = "Images/Check.png"}, New Data() With {.ID = 5, .Description = "Folder", .ImageUrl = "Images/Folder.png"}, New Data() With {.ID = 6, .Description = "Key", .ImageUrl = "Images/Key.png"}, New Data() With {.ID = 7, .Description = "Printing", .ImageUrl = "Images/Printing.png"}}
        End Function
    End Class
End Namespace

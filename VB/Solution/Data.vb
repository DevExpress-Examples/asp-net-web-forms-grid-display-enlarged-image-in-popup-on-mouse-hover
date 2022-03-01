Public Class Data
	Private privateID As Integer
	Public Property ID() As Integer
		Get
			Return privateID
		End Get
		Set(ByVal value As Integer)
			privateID = value
		End Set
	End Property
	Private privateDescription As String
	Public Property Description() As String
		Get
			Return privateDescription
		End Get
		Set(ByVal value As String)
			privateDescription = value
		End Set
	End Property
	Private privateImageUrl As String
	Public Property ImageUrl() As String
		Get
			Return privateImageUrl
		End Get
		Set(ByVal value As String)
			privateImageUrl = value
		End Set
	End Property
End Class

Public Class DataHelper
	Public Shared Function GenerateData() As List(Of Data)
		Return New List(Of Data)(
			New Data() {
				New Data() With {.ID = 0, .Description = "Basket", .ImageUrl = "Images/Basket.png"},
				New Data() With {.ID = 1, .Description = "Customer", .ImageUrl = "Images/Customer.png"},
				New Data() With {.ID = 2, .Description = "Home", .ImageUrl = "Images/Home.png"},
				New Data() With {.ID = 3, .Description = "Mail", .ImageUrl = "Images/Mail.png"},
				New Data() With {.ID = 4, .Description = "Check", .ImageUrl = "Images/Check.png"},
				New Data() With {.ID = 5, .Description = "Folder", .ImageUrl = "Images/Folder.png"},
				New Data() With {.ID = 6, .Description = "Key", .ImageUrl = "Images/Key.png"},
				New Data() With {.ID = 7, .Description = "Printing", .ImageUrl = "Images/Printing.png"}
			}
		)
	End Function
End Class

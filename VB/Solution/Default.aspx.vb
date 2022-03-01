Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
		ASPxGridView1.DataSource = DataHelper.GenerateData()
		ASPxGridView1.DataBind()
	End Sub

	Protected Sub ASPxGridView1_HtmlDataCellPrepared(sender As Object, e As DevExpress.Web.ASPxGridViewTableDataCellEventArgs)
		If e.DataColumn.FieldName = "ImageUrl" Then
			e.Cell.Attributes.Add("onmouseover", String.Format("ShowPopup('{0}','{1}','{2}')", e.Cell.ClientID, e.GetValue("ImageUrl"), e.GetValue("Description")))
		End If
	End Sub
End Class
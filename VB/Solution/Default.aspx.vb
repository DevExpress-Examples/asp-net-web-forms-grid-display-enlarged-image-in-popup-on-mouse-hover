Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Solution
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = DataHelper.GenerateData()
			ASPxGridView1.DataBind()
		End Sub

		Protected Sub ASPxGridView1_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableDataCellEventArgs)
			If e.DataColumn.FieldName = "ImageUrl" Then
				e.Cell.Attributes.Add("onmouseover", String.Format("ShowPopup('{0}','{1}','{2}')", e.Cell.ClientID, e.GetValue("ImageUrl"), e.GetValue("Description")))
			End If
		End Sub
	End Class
End Namespace
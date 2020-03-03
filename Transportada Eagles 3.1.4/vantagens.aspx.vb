Imports System.Data
Imports System.Data.SqlClient
Partial Class unidades
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            carregar()
        End If
    End Sub
    Sub carregar()
        Dim meucon As SqlConnection
        Dim meuadapter As SqlDataAdapter
        Dim connStr, sqlStr As String
        Dim meudataset As New DataSet
        connStr = "Data Source=(local)\SQLEXPRESS;Initial Catalog=teste;Persist Security Info=True;User ID=sa;Password=123456"
        sqlStr = "SELECT  [ProductName], [ProductImage] FROM [Products]"
        meucon = New SqlConnection(connStr)
        meucon.Open()
        meuadapter = New SqlDataAdapter(sqlStr, meucon)
        meuadapter.Fill(meudataset, "dtProducts")
        Repeater1.DataSource = meudataset.Tables("dtProducts")
        Repeater1.DataBind()
    End Sub
End Class

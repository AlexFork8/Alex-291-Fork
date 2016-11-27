
Imports System.Data.SqlClient
Public Class UpdateBranchScreen

    'Dim StreetTextBox As Object
    'Dim BranchTextBox As Object
    'Dim AveTextBox As Object
    'Dim CityTextBox As Object
    'Dim CountryTextbox As Object
    'Dim PostalCodeTextBox As Object
    'Dim PhoneNumberTextBox As Object
    'Dim BranchIDTextBox As Object


    'a query for the data to be updated


    Private Sub UpdateBranchScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'returns the string we add as the return value
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"

    End Function

    'handler generated when we create a button. The actual events within the button 
    'handler is defined by us.
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = GetConnectionString()

        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()

            Dim query As String = ""
            query = "update dbo.Branch set Name = '" & BranchTextBox.Text & "',Address_Street = '" & StreetTextBox.Text & "',Address_Ave= '" & AveTextBox.Text & "',City = '" & CityTextBox.Text & "',
            Country = '" & CountryTextbox.Text & "',Postal_Code = '" & PostalCodeTextBox.Text & "',Phone_Number = '" & PhoneNumberTextBox.Text & "' where Branch_ID='" & BranchIDTextBox.Text & "'"


            Try
                connection.Open()
                command.CommandText = query
                command.ExecuteReader()

                'sends our CommandText(query) to the connection at command and executes the query
                Dim resultQuery = "select Name from dbo.branch"
                command.CommandText = resultQuery
                Dim readBranchData As SqlDataReader = command.ExecuteReader

                Do While readBranchData.Read()
                    Result.Text += readBranchData(0).ToString
                Loop

                Result.Refresh()

                readBranchData.Close()
                connection.Close()


                'Catch Exception if data u
            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Sub
    Private Sub UpdateBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BranchButton.Click

    'End Sub
End Class

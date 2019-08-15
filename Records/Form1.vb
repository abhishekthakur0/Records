Imports System.Data.SqlClient
Public Class Form1


    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\source\repos\Records\RDatabase.mdf;Integrated Security=True")

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles insertButton.Click

        Try

            Dim insertQuery As String = "INSERT INTO RTable(accnumber,name,fname,address,dateofdeposit,amtdeposited,amtwithdrawal,dateofamtwithdrawal,amtpending,district) VALUES('" & accNumber.Text & "','" & uname.Text & "','" & fname.Text & "','" & address.Text & "','" & dateofdeposit.Text & "','" & amtDeposit.Text & "','" & amtWithdrawl.Text & "','" & dateofWithdrawal.Text & "','" & amtPending.Text & "','" & district.Text & "')"
            Dim command As New SqlCommand(insertQuery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Data inserted")

        Catch ex As Exception

            MessageBox.Show("Error in inserting Value")

        End Try

        connection.Close()

    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            Dim deleteQuery As String = "DELETE FROM RTable WHERE accnumber ='" & accNumber.Text & "'"
            Dim command As New SqlCommand(deleteQuery, connection)
            connection.Open()
            command.ExecuteNonQuery()

            MessageBox.Show("Data Deleted")
        Catch ex As Exception

            MessageBox.Show("Error in deleting values")
        End Try

        connection.Close()

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Try
            Dim updateQuery As String = "UPDATE RTable SET address = '" & address.Text & "' WHERE accnumber ='" & accNumber.Text & "'"
            Dim command As New SqlCommand(updateQuery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Address Updated")
        Catch ex As Exception

            MessageBox.Show("Error in Updating Address! ")

        End Try

        connection.Close()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\source\repos\Records\RDatabase.mdf;Integrated Security=True")

        FilterData("")

    End Sub
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT accnumber as AccountNumber, name as Name, fname as FatherName, address as Address, dateofdeposit as DateOfDeposit, amtdeposited as AmountDeposited, amtwithdrawal as AmountWithdrawal, dateofamtwithdrawal as DateOfAmountWithdrawal, amtpending as AmountPending, district as District FROM RTable WHERE CONCAT(accnumber, name, address, amtdeposited, district) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        accNumber.Clear()
        uname.Clear()
        fname.Clear()
        address.Clear()
        amtDeposit.Clear()
        amtPending.Clear()
        amtWithdrawl.Clear()
        district.Clear()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        FilterData(SearchInput.Text)
    End Sub

    Private Sub SortByAccount_Click(sender As Object, e As EventArgs) Handles SortByAccount.Click
        Dim sortByAccountQuery As String = "SELECT accnumber as AccountNumber, name as Name, fname as FatherName, address as Address, dateofdeposit as DateOfDeposit, amtdeposited as AmountDeposited, amtwithdrawal as AmountWithdrawal, dateofamtwithdrawal as DateOfAmountWithdrawal, amtpending as AmountPending, district as District FROM RTable ORDER BY accnumber"
        Dim command As New SqlCommand(sortByAccountQuery, connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub SortByName_Click(sender As Object, e As EventArgs) Handles SortByName.Click
        Dim sortBynameQuery As String = "SELECT accnumber as AccountNumber, name as Name, fname as FatherName, address as Address, dateofdeposit as DateOfDeposit, amtdeposited as AmountDeposited, amtwithdrawal as AmountWithdrawal, dateofamtwithdrawal as DateOfAmountWithdrawal, amtpending as AmountPending, district as District FROM RTable ORDER BY name"
        Dim command As New SqlCommand(sortBynameQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub SortByDate_Click(sender As Object, e As EventArgs) Handles SortByDate.Click
        Dim sortBydateQuery As String = "SELECT accnumber as AccountNumber, name as Name, fname as FatherName, address as Address, dateofdeposit as DateOfDeposit, amtdeposited as AmountDeposited, amtwithdrawal as AmountWithdrawal, dateofamtwithdrawal as DateOfAmountWithdrawal, amtpending as AmountPending, district as District FROM RTable ORDER BY dateofdeposit"
        Dim command As New SqlCommand(sortBydateQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class
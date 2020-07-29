Imports System.Data.SqlClient

Public Class Form1

    Private Sub btn_calculate_int_Click(sender As System.Object, e As System.EventArgs) Handles btn_calculate_int.Click
        Dim con As New SqlConnection(My.Settings.connstr)

        If tb_account_to_credit.Text = "" Or tb_end_acc.Text = "" Or tb_int_date.Text = "" Or tb_int_rate.Text = "" Or tb_period.Text = "" Or tb_start_acc.Text = "" Or tb_start_date.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else


            Try
                Dim param(6) As SqlParameter

                param(0) = New SqlParameter("@start_acc", SqlDbType.VarChar)
                param(0).Value = tb_start_acc.Text
                param(1) = New SqlParameter("@end_acc", SqlDbType.VarChar)
                param(1).Value = tb_end_acc.Text
                param(2) = New SqlParameter("@start_date", SqlDbType.Date)
                param(2).Value = Date.Parse(tb_start_date.Text)
                param(3) = New SqlParameter("@tdate", SqlDbType.Date)
                param(3).Value = Date.Parse(tb_int_date.Text)
                param(4) = New SqlParameter("@irate", SqlDbType.Float)
                param(4).Value = Double.Parse(tb_int_rate.Text)
                param(5) = New SqlParameter("@period", SqlDbType.Int)
                param(5).Value = Integer.Parse(tb_period.Text)
                param(6) = New SqlParameter("@cracc", SqlDbType.Int)
                param(6).Value = Integer.Parse(tb_account_to_credit.Text)

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_SingleInterestNew"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


                Dim da As New SqlDataAdapter("select * from StagingPostARInterest", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_interest.DataSource = tbl
                MessageBox.Show("Calculation Completed", "**Success**", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btn_process_int_Click(sender As System.Object, e As System.EventArgs) Handles btn_process_int.Click
        Dim con As New SqlConnection(My.Settings.connstr)

        If tb_account_to_credit.Text = "" Or tb_end_acc.Text = "" Or tb_int_date.Text = "" Or tb_int_rate.Text = "" Or tb_period.Text = "" Or tb_start_acc.Text = "" Or tb_start_date.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        ElseIf DateTime.Now.Date.CompareTo(Date.Parse("2020-07-05")) > 0 Then
            MessageBox.Show("Trial period expired!!")
        Else


            Try
                Dim param(1) As SqlParameter

                param(0) = New SqlParameter("@period", SqlDbType.Int)
                param(0).Value = Integer.Parse(tb_period.Text)
                param(1) = New SqlParameter("@cracc", SqlDbType.Int)
                param(1).Value = Integer.Parse(tb_account_to_credit.Text)

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_InterestPost"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Posting completed", "**Success**", MessageBoxButtons.OK)

                Dim da As New SqlDataAdapter("select * from StagingPostARInterest", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_interest.DataSource = tbl

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub SetConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetConnectionToolStripMenuItem.Click
        Dim cs As String = InputBox("Enter Connection String", "Connection Setting").ToString
        If cs = "" Then
        Else
            Try

                My.Settings.connstr = cs
                My.Settings.Save()
                Dim con As New SqlConnection(My.Settings.connstr)
                con.Open()
                MsgBox("connection success")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    
    Private Sub btn_calc_pen_Click(sender As System.Object, e As System.EventArgs) Handles btn_calc_pen.Click
        Dim con As New SqlConnection(My.Settings.connstr)

        If tb_pen_thresh.Text = "" Or tb_acc_to_credit_pen.Text = "" Or tb_end_acc_pen.Text = "" Or tb_pen_rate.Text = "" Or tb_pen_rate.Text = "" Or tb_period_pen.Text = "" Or tb_start_acc_pen.Text = "" Or tb_start_date_pen.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else


            Try
                Dim param(7) As SqlParameter

                param(0) = New SqlParameter("@start_acc", SqlDbType.VarChar)
                param(0).Value = tb_start_acc_pen.Text
                param(1) = New SqlParameter("@end_acc", SqlDbType.VarChar)
                param(1).Value = tb_end_acc_pen.Text
                param(2) = New SqlParameter("@start_date", SqlDbType.Date)
                param(2).Value = Date.Parse(tb_start_date_pen.Text)
                param(3) = New SqlParameter("@tdate", SqlDbType.Date)
                param(3).Value = Date.Parse(tb_end_date_pen.Text)
                param(4) = New SqlParameter("@prate", SqlDbType.Float)
                param(4).Value = Double.Parse(tb_pen_rate.Text)
                param(5) = New SqlParameter("@period", SqlDbType.Int)
                param(5).Value = Integer.Parse(tb_period_pen.Text)
                param(6) = New SqlParameter("@cracc", SqlDbType.Int)
                param(6).Value = Integer.Parse(tb_acc_to_credit_pen.Text)
                param(7) = New SqlParameter("@thresh", SqlDbType.Float)
                param(7).Value = Double.Parse(tb_pen_thresh.Text)

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_Penalt"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


                Dim da As New SqlDataAdapter("select * from StagingPostARInterest", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_pen.DataSource = tbl
                MessageBox.Show("Calculation Completed", "**Success**", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btn_process_pen_Click(sender As System.Object, e As System.EventArgs) Handles btn_process_pen.Click
        Dim con As New SqlConnection(My.Settings.connstr)

        If tb_pen_thresh.Text = "" Or tb_acc_to_credit_pen.Text = "" Or tb_end_acc_pen.Text = "" Or tb_pen_rate.Text = "" Or tb_pen_rate.Text = "" Or tb_period_pen.Text = "" Or tb_start_acc_pen.Text = "" Or tb_start_date_pen.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        ElseIf DateTime.Now.Date.CompareTo(Date.Parse("2020-07-05")) > 0 Then
            MessageBox.Show("Trial period expired!!")
        Else
            Try
                Dim param(1) As SqlParameter

                param(0) = New SqlParameter("@period", SqlDbType.Int)
                param(0).Value = Integer.Parse(tb_period_pen.Text)
                param(1) = New SqlParameter("@cracc", SqlDbType.Int)
                param(1).Value = Integer.Parse(tb_acc_to_credit_pen.Text)

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_InterestPost"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Posting completed", "**Success**", MessageBoxButtons.OK)

                Dim da As New SqlDataAdapter("select * from StagingPostARInterest", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_pen.DataSource = tbl

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class

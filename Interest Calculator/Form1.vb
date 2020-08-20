Imports System.Data.SqlClient

Public Class Form1

    Private Sub btn_calculate_int_Click(sender As System.Object, e As System.EventArgs) Handles btn_calculate_int.Click
        Dim con As New SqlConnection(My.Settings.connstr)

        If DateTime.Now.Date.CompareTo(Date.Parse("2020-08-28")) > 0 Then
            MessageBox.Show("Trial period expired!!")
        ElseIf tb_start_acc.Text = "" Or tb_end_acc.Text = "" Or tb_int_date.Text = "" Or tb_int_rate.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else


            Try
                Dim param(6) As SqlParameter

                param(0) = New SqlParameter("@start_acc", SqlDbType.VarChar)
                param(0).Value = tb_start_acc.Text
                param(1) = New SqlParameter("@end_acc", SqlDbType.VarChar)
                param(1).Value = tb_end_acc.Text
                param(2) = New SqlParameter("@start_date", SqlDbType.Date)
                If tb_start_date.Text = "" Then
                    param(2).Value = DBNull.Value
                Else
                    param(2).Value = Date.Parse(tb_start_date.Text)
                End If

                param(3) = New SqlParameter("@tdate", SqlDbType.Date)
                param(3).Value = Date.Parse(tb_int_date.Text)
                param(4) = New SqlParameter("@irate", SqlDbType.Float)
                param(4).Value = Double.Parse(tb_int_rate.Text)
                param(5) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period.Text = "" Then
                    param(5).Value = DBNull.Value
                Else
                    param(5).Value = Integer.Parse(tb_period.Text)
                End If

                param(6) = New SqlParameter("@cracc", SqlDbType.Int)
                If tb_account_to_credit.Text = "" Then
                    param(6).Value = DBNull.Value
                Else
                    param(6).Value = Integer.Parse(tb_account_to_credit.Text)
                End If


                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_SingleInterestNew"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
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

        If tb_start_acc.Text = "" Or tb_end_acc.Text = "" Or tb_int_date.Text = "" Or tb_int_rate.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
      Else


            Try
                btn_calculate_int.PerformClick()
                Dim param(1) As SqlParameter

                param(0) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period.Text = "" Then
                    param(0).Value = DBNull.Value
                Else
                    param(0).Value = Integer.Parse(tb_period.Text)
                End If

                param(1) = New SqlParameter("@cracc", SqlDbType.Int)
                If tb_account_to_credit.Text = "" Then
                    param(1).Value = DBNull.Value
                Else
                    param(1).Value = Integer.Parse(tb_account_to_credit.Text)
                End If


                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_InterestPost"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Posting completed", "**Success**", MessageBoxButtons.OK)

                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
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
        If DateTime.Now.Date.CompareTo(Date.Parse("2020-08-28")) > 0 Then
            MessageBox.Show("Trial period expired!!")
        ElseIf tb_pen_thresh.Text = "" Or tb_end_acc_pen.Text = "" Or tb_pen_rate.Text = "" Or tb_start_acc_pen.Text = "" Or tb_start_date_pen.Text = "" Or tb_end_date_pen.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else


            Try
                Dim param(7) As SqlParameter

                param(0) = New SqlParameter("@start_acc", SqlDbType.VarChar)
                param(0).Value = tb_start_acc_pen.Text
                param(1) = New SqlParameter("@end_acc", SqlDbType.VarChar)
                param(1).Value = tb_end_acc_pen.Text
                param(2) = New SqlParameter("@start_date", SqlDbType.Date)
                If tb_start_date_pen.Text = "" Then
                    param(2).Value = DBNull.Value
                Else
                    param(2).Value = Date.Parse(tb_start_date_pen.Text)
                End If

                param(3) = New SqlParameter("@tdate", SqlDbType.Date)
                param(3).Value = Date.Parse(tb_end_date_pen.Text)
                param(4) = New SqlParameter("@prate", SqlDbType.Float)
                param(4).Value = Double.Parse(tb_pen_rate.Text)
                param(5) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period_pen.Text = "" Then
                    param(5).Value = DBNull.Value
                Else
                    param(5).Value = Integer.Parse(tb_period_pen.Text)
                End If

                param(6) = New SqlParameter("@cracc", SqlDbType.Int)
                If tb_acc_to_credit_pen.Text = "" Then
                    param(6).Value = DBNull.Value
                Else
                    param(6).Value = Integer.Parse(tb_acc_to_credit_pen.Text)
                End If

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


                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
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

        If tb_pen_thresh.Text = "" Or tb_end_acc_pen.Text = "" Or tb_pen_rate.Text = "" Or tb_pen_rate.Text = "" Or tb_start_acc_pen.Text = "" Or tb_start_date_pen.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else
            Try
                btn_calc_pen.PerformClick()
                Dim param(1) As SqlParameter

                param(0) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period_pen.Text = "" Then
                    param(0).Value = DBNull.Value
                Else
                    param(0).Value = Integer.Parse(tb_period_pen.Text)
                End If

                param(1) = New SqlParameter("@cracc", SqlDbType.Int)
                If tb_acc_to_credit_pen.Text = "" Then
                    param(1).Value = DBNull.Value
                Else
                    param(1).Value = Integer.Parse(tb_acc_to_credit_pen.Text)
                End If

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_InterestPost"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Posting completed", "**Success**", MessageBoxButtons.OK)

                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
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

    Private Sub btn_split_pay_Click(sender As System.Object, e As System.EventArgs) Handles btn_split_pay.Click
        Dim con As New SqlConnection(My.Settings.connstr)
        If DateTime.Now.Date.CompareTo(Date.Parse("2020-08-28")) > 0 Then
            MessageBox.Show("Trial period expired!!")
        ElseIf tb_start_acc_pay.Text = "" Or tb_end_acc_pay.Text = "" Or tb_pay_amount.Text = "" Then
            MessageBox.Show("Please enter all required fields!!!", "Error", MessageBoxButtons.OK)
        Else
            Try
                Dim param(5) As SqlParameter

                param(0) = New SqlParameter("@start_acc", SqlDbType.VarChar)
                param(0).Value = tb_start_acc_pay.Text
                param(1) = New SqlParameter("@end_acc", SqlDbType.VarChar)
                param(1).Value = tb_end_acc_pay.Text
                param(2) = New SqlParameter("@tdate", SqlDbType.Date)
                If tb_pay_date.Text = "" Then
                    param(2).Value = DBNull.Value
                Else
                    param(2).Value = Date.Parse(tb_pay_date.Text)
                End If

                param(3) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period_pay.Text = "" Then
                    param(3).Value = DBNull.Value
                Else
                    param(3).Value = Integer.Parse(tb_period_pay.Text)
                End If

                param(4) = New SqlParameter("@cracc", SqlDbType.VarChar)
                If tb_acc_to_deb_pay.Text = "" Then
                    param(4).Value = DBNull.Value
                Else
                    param(4).Value = tb_acc_to_deb_pay.Text
                End If

                param(5) = New SqlParameter("@payamount", SqlDbType.Float)
                param(5).Value = Double.Parse(tb_pay_amount.Text)

                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_Payment"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_pay.DataSource = tbl
                MessageBox.Show("Payment Split Completed", "**Success**", MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub btn_process_pay_Click(sender As System.Object, e As System.EventArgs) Handles btn_process_pay.Click
        Dim con As New SqlConnection(My.Settings.connstr)
        
            Try
                btn_split_pay.PerformClick()
                Dim param(1) As SqlParameter

                param(0) = New SqlParameter("@period", SqlDbType.Int)
                If tb_period_pay.Text = "" Then
                    param(0).Value = DBNull.Value
                Else
                    param(0).Value = Integer.Parse(tb_period_pay.Text)
                End If

                param(1) = New SqlParameter("@cracc", SqlDbType.Int)
                If tb_acc_to_deb_pay.Text = "" Then
                    param(1).Value = DBNull.Value
                Else
                    param(1).Value = Integer.Parse(tb_acc_to_deb_pay.Text)
                End If


                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SpInsertStagingPostAR_PaymentPost"
                cmd.Parameters.AddRange(param)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Posting completed", "**Success**", MessageBoxButtons.OK)

                Dim da As New SqlDataAdapter("select cl.Account,cl.Name,si.TxDate,si.Reference,si.Description,round(si.Debit,4) as Debit,round(si.Credit,4) as Credit,round(si.Tax_Amount,4) as TaxAmount from StagingPostARInterest as si join Client as cl on si.AccountLink=cl.DCLink", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                dgv_pay.DataSource = tbl

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListView1.View = View.Details
        ListView2.View = View.Details

        Dim Dte As DateTime = DateTime.Now
        Textdate.Text = FormatDateTime(Dte, DateFormat.LongDate)
    Me.Text = "Ammo List and Loads -" & FormatDateTime(Dte, DateFormat.LongDate)
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item As New ListViewItem(TextBox1.Text$)
        item.SubItems.Add(TextBox2.Text$)
        item.SubItems.Add(TextBox3.Text$)
        item.SubItems.Add(TextBox4.Text$)
        item.SubItems.Add(TextBox5.Text$)
        item.SubItems.Add(TextBox6.Text$)
        ListView1.Items.Add(item)
       


        
      
    End Sub

    Private Sub ListViewItem(ByVal p1 As Object)
        Throw New NotImplementedException
    End Sub



    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim item As New ListViewItem(TextBox1.Text$)
        item.SubItems.Add(Textdate.Text$)
        ListView2.Items.Add(item)
        Dim Dataset As New DataSet
        

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub
End Class

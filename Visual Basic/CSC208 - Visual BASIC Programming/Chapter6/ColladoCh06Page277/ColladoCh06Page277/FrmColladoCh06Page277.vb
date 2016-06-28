Public Class FrmColladoCh06Page277

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub InputSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputSaleToolStripMenuItem.Click
        FrmColladoCh05Page241.Show()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Me.ColorDialog1.ShowDialog()
        Me.Label1.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Me.FontDialog1.ShowDialog()
        Me.Label1.Font = Me.FontDialog1.Font
    End Sub
End Class

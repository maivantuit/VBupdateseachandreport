Imports System

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TácNghiệpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TácNghiệpToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub BáoCáoThốngKêToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoThốngKêToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class

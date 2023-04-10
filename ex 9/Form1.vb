Option Strict Off
Option Infer On
Option Explicit Off
Imports System.ComponentModel
Imports System.Security.AccessControl
'Name: Translator!
'Purpose: To translate the titles of family members to various languages
'Programmer: Will Young on 4/10

Public Class frmMain

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Function FrenchTrans()

        If radMom.Checked Then
            strWord = "Mère"
            Return strWord
        ElseIf radDad.Checked Then
            strWord = "Père"
            Return strWord
        ElseIf radSis.Checked Then
            strWord = "Sœur"
            Return strWord
        ElseIf radBro.Checked Then
            strWord = "Frere"
            Return strWord
        End If
    End Function

    Private Function SpanishTrans()
        If radMom.Checked Then
            strWord = "Mamá"
            Return strWord
        ElseIf radDad.Checked Then
            strWord = "Padre"
            Return strWord
        ElseIf radSis.Checked Then
            strWord = "hermana"
            Return strWord
        ElseIf radBro.Checked Then
            strWord = "hermano"
            Return strWord
        End If

    End Function

    Private Function ItalianTrans()
        Dim strWord As String
        If radMom.Checked Then
            strWord = "Papà"
            Return strWord
        ElseIf radDad.Checked Then
            strWord = "mamma"
            Return strWord
        ElseIf radSis.Checked Then
            strWord = "sorella"
            Return strWord
        ElseIf radBro.Checked Then
            strWord = "fratello"
            Return strWord
        End If
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim X As String

        If cmbLanguages.SelectedItem = "French" Then
            X = FrenchTrans()
            lblTranslation.Text = X.ToString()
        ElseIf cmbLanguages.SelectedItem = "Italian" Then
            X = ItalianTrans()
            lblTranslation.Text = X.ToString()
        ElseIf cmbLanguages.SelectedItem = "Spanish" Then
            X = SpanishTrans()
            lblTranslation.Text = X.ToString()
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dlgbutton As DialogResult
        dlgbutton = MessageBox.Show("Do You want to Exit?", "Translator", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'If the No button is selected, do not close the form'
        If dlgbutton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Clearall(sender As Object, e As EventArgs) Handles radBro.CheckedChanged, radDad.CheckedChanged, radMom.CheckedChanged, radSis.CheckedChanged, cmbLanguages.SelectedIndexChanged
        lblTranslation.Text = ""
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLanguages.SelectedItem = "French"
    End Sub
End Class

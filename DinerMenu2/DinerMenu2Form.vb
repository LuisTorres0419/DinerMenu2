
'Luis Torres
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/LuisTorres0419/DinerMenu2.git

Public Class DinerMenu2Form

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        Dim textBox As Control

        item1Label.Text = ""

        For Each textBox In Me.Controls

            If TypeOf textBox Is TextBox Then

                textBox.Text = ""

            End If

        Next

        item2Label.Text = ""

        For Each textBox In Me.Controls

            If TypeOf textBox Is TextBox Then

                textBox.Text = ""

            End If

        Next

    End Sub

    Private Sub SteakButton_Click(sender As Object, e As EventArgs) Handles SteakButton.Click
        Me.item1Label.Text = "~Steak~"

        Me.item2Label.Text = " -Free range
-Boxing glove 
-Sandal
-Lightly salted 
-Seared
-Medium rare"

        My.Computer.Audio.Play(My.Resources.steakmain, AudioPlayMode.Background)

    End Sub

    Private Sub PizzaButton_Click(sender As Object, e As EventArgs) Handles PizzaButton.Click

        Me.item1Label.Text = "~Pizza~"

        Me.item2Label.Text = "-Home made dough
-Tomato sauce 
-Garlic powder
-Mozzarella 
-Love"

        My.Computer.Audio.Play(My.Resources.pizzamain, AudioPlayMode.Background)

    End Sub

    Private Sub MeatloafButton_Click(sender As Object, e As EventArgs) Handles MeatloafButton.Click
        Me.item1Label.Text = "~Meatloaf~"

        Me.item2Label.Text = "-gorund beef
-egg
-onion
-salt And pepper
-prepared mustard
-katchup"

        My.Computer.Audio.Play(My.Resources.meatloaf2, AudioPlayMode.Background)

    End Sub

End Class

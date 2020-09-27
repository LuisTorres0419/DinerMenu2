<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenu2Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.KronksDinnerLabel = New System.Windows.Forms.Label()
        Me.item2Label = New System.Windows.Forms.Label()
        Me.item1Label = New System.Windows.Forms.Label()
        Me.KronkPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SteakButton = New System.Windows.Forms.Button()
        Me.PizzaButton = New System.Windows.Forms.Button()
        Me.MeatloafButton = New System.Windows.Forms.Button()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.KronkPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = Global.DinerMenu2.My.Resources.Resources.Screenshot_2020_09_26_182954
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.KronksDinnerLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.item2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item1Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KronkPictureBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExitButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SteakButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PizzaButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MeatloafButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(1228, 865)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 0
        '
        'KronksDinnerLabel
        '
        Me.KronksDinnerLabel.AutoSize = True
        Me.KronksDinnerLabel.Font = New System.Drawing.Font("Ravie", 13.875!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KronksDinnerLabel.Image = Global.DinerMenu2.My.Resources.Resources.Screenshot_2020_09_26_184649
        Me.KronksDinnerLabel.Location = New System.Drawing.Point(408, 77)
        Me.KronksDinnerLabel.Name = "KronksDinnerLabel"
        Me.KronksDinnerLabel.Size = New System.Drawing.Size(398, 50)
        Me.KronksDinnerLabel.TabIndex = 0
        Me.KronksDinnerLabel.Text = "Kronk's Dinner"
        '
        'item2Label
        '
        Me.item2Label.BackColor = System.Drawing.Color.Gold
        Me.item2Label.Font = New System.Drawing.Font("Ravie", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item2Label.Location = New System.Drawing.Point(476, 182)
        Me.item2Label.Name = "item2Label"
        Me.item2Label.Size = New System.Drawing.Size(464, 290)
        Me.item2Label.TabIndex = 8
        Me.item2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'item1Label
        '
        Me.item1Label.BackColor = System.Drawing.Color.Gold
        Me.item1Label.Font = New System.Drawing.Font("Ravie", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item1Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.item1Label.Location = New System.Drawing.Point(476, 113)
        Me.item1Label.Name = "item1Label"
        Me.item1Label.Size = New System.Drawing.Size(464, 159)
        Me.item1Label.TabIndex = 7
        Me.item1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'KronkPictureBox
        '
        Me.KronkPictureBox.BackgroundImage = Global.DinerMenu2.My.Resources.Resources.Chef_Kronk_DESI003
        Me.KronkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KronkPictureBox.Location = New System.Drawing.Point(12, 16)
        Me.KronkPictureBox.Name = "KronkPictureBox"
        Me.KronkPictureBox.Size = New System.Drawing.Size(308, 287)
        Me.KronkPictureBox.TabIndex = 6
        Me.KronkPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1041, 524)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(181, 124)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Red
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(854, 524)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(181, 124)
        Me.HomeButton.TabIndex = 4
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'SteakButton
        '
        Me.SteakButton.BackgroundImage = Global.DinerMenu2.My.Resources.Resources.STEAK
        Me.SteakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SteakButton.Font = New System.Drawing.Font("Ravie", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SteakButton.Location = New System.Drawing.Point(494, 525)
        Me.SteakButton.Name = "SteakButton"
        Me.SteakButton.Size = New System.Drawing.Size(181, 124)
        Me.SteakButton.TabIndex = 3
        Me.SteakButton.Text = "Steak"
        Me.SteakButton.UseVisualStyleBackColor = True
        '
        'PizzaButton
        '
        Me.PizzaButton.Font = New System.Drawing.Font("Ravie", 13.875!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PizzaButton.ForeColor = System.Drawing.Color.Black
        Me.PizzaButton.Image = Global.DinerMenu2.My.Resources.Resources.PIZZA
        Me.PizzaButton.Location = New System.Drawing.Point(277, 525)
        Me.PizzaButton.Name = "PizzaButton"
        Me.PizzaButton.Size = New System.Drawing.Size(211, 124)
        Me.PizzaButton.TabIndex = 2
        Me.PizzaButton.Text = "Pizza"
        Me.PizzaButton.UseVisualStyleBackColor = True
        '
        'MeatloafButton
        '
        Me.MeatloafButton.BackgroundImage = Global.DinerMenu2.My.Resources.Resources.meaTLOAF
        Me.MeatloafButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MeatloafButton.Font = New System.Drawing.Font("Ravie", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.MeatloafButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MeatloafButton.Location = New System.Drawing.Point(12, 524)
        Me.MeatloafButton.Name = "MeatloafButton"
        Me.MeatloafButton.Size = New System.Drawing.Size(259, 124)
        Me.MeatloafButton.TabIndex = 1
        Me.MeatloafButton.Text = "Meatloaf"
        Me.MeatloafButton.UseVisualStyleBackColor = True
        '
        'RichTextBox
        '
        Me.RichTextBox.BackColor = System.Drawing.Color.Gold
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(1228, 657)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = ""
        '
        'DinerMenu2Form
        '
        Me.AcceptButton = Me.HomeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1228, 865)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DinerMenu2Form"
        Me.Text = "DinerMenuForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.KronkPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents KronksDinnerLabel As Label
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents item2Label As Label
    Friend WithEvents item1Label As Label
    Friend WithEvents KronkPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents SteakButton As Button
    Friend WithEvents PizzaButton As Button
    Friend WithEvents MeatloafButton As Button
End Class

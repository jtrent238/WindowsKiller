<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CheckBoxConfirm = New System.Windows.Forms.CheckBox()
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBoxConfirm
        '
        Me.CheckBoxConfirm.AutoSize = True
        Me.CheckBoxConfirm.Location = New System.Drawing.Point(12, 51)
        Me.CheckBoxConfirm.Name = "CheckBoxConfirm"
        Me.CheckBoxConfirm.Size = New System.Drawing.Size(554, 17)
        Me.CheckBoxConfirm.TabIndex = 0
        Me.CheckBoxConfirm.Text = "I understand that this program will do damage to my system that is irreversible a" &
    "nd that I am fully responsible for it."
        Me.CheckBoxConfirm.UseVisualStyleBackColor = True
        '
        'ButtonContinue
        '
        Me.ButtonContinue.Location = New System.Drawing.Point(236, 74)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContinue.TabIndex = 1
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "This Program is DANGEROUS!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 111)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonContinue)
        Me.Controls.Add(Me.CheckBoxConfirm)
        Me.Name = "Form1"
        Me.Text = "WindowsKiller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxConfirm As CheckBox
    Friend WithEvents ButtonContinue As Button
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblentermarks = New Label()
        lblgrade = New Label()
        txtEnterMarks = New TextBox()
        txtGrade = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(182, 60)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(419, 38)
        Label1.TabIndex = 0
        Label1.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' lblentermarks
        ' 
        lblentermarks.AutoSize = True
        lblentermarks.Location = New Point(363, 151)
        lblentermarks.Margin = New Padding(4, 0, 4, 0)
        lblentermarks.Name = "lblentermarks"
        lblentermarks.Size = New Size(124, 22)
        lblentermarks.TabIndex = 1
        lblentermarks.Text = "Enter Marks "
        ' 
        ' lblgrade
        ' 
        lblgrade.AutoSize = True
        lblgrade.Location = New Point(409, 244)
        lblgrade.Margin = New Padding(4, 0, 4, 0)
        lblgrade.Name = "lblgrade"
        lblgrade.Size = New Size(64, 22)
        lblgrade.TabIndex = 2
        lblgrade.Text = "Grade"
        ' 
        ' txtEnterMarks
        ' 
        txtEnterMarks.Location = New Point(527, 151)
        txtEnterMarks.Margin = New Padding(4)
        txtEnterMarks.Name = "txtEnterMarks"
        txtEnterMarks.Size = New Size(305, 29)
        txtEnterMarks.TabIndex = 3
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(527, 237)
        txtGrade.Margin = New Padding(4)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(305, 29)
        txtGrade.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.BackColor = SystemColors.MenuHighlight
        btnEvaluate.Font = New Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(692, 293)
        btnEvaluate.Margin = New Padding(4)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(243, 77)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1026, 473)
        Controls.Add(btnEvaluate)
        Controls.Add(txtGrade)
        Controls.Add(txtEnterMarks)
        Controls.Add(lblgrade)
        Controls.Add(lblentermarks)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Ssekajja Victoria Mirembe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblentermarks As Label
    Friend WithEvents lblgrade As Label
    Friend WithEvents txtEnterMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnEvaluate As Button

End Class

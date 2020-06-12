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
        Me.lblUserInput = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.txtDisplayFibs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumFibs = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFibs = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserInput
        '
        Me.lblUserInput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInput.Location = New System.Drawing.Point(-1, 35)
        Me.lblUserInput.Name = "lblUserInput"
        Me.lblUserInput.Size = New System.Drawing.Size(343, 37)
        Me.lblUserInput.TabIndex = 4
        Me.lblUserInput.Text = "How close to the Golden Ratio should we get?"
        Me.lblUserInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(324, 43)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(119, 29)
        Me.txtUserInput.TabIndex = 0
        Me.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDisplayFibs
        '
        Me.txtDisplayFibs.Location = New System.Drawing.Point(30, 95)
        Me.txtDisplayFibs.Multiline = True
        Me.txtDisplayFibs.Name = "txtDisplayFibs"
        Me.txtDisplayFibs.ReadOnly = True
        Me.txtDisplayFibs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplayFibs.Size = New System.Drawing.Size(413, 201)
        Me.txtDisplayFibs.TabIndex = 5
        Me.txtDisplayFibs.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Its required generating"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumFibs
        '
        Me.lblNumFibs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumFibs.Location = New System.Drawing.Point(170, 308)
        Me.lblNumFibs.Name = "lblNumFibs"
        Me.lblNumFibs.Size = New System.Drawing.Size(56, 34)
        Me.lblNumFibs.TabIndex = 7
        Me.lblNumFibs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "fib numbers to get this close to the Golden Ratio."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFibs
        '
        Me.btnFibs.Location = New System.Drawing.Point(84, 360)
        Me.btnFibs.Name = "btnFibs"
        Me.btnFibs.Size = New System.Drawing.Size(133, 51)
        Me.btnFibs.TabIndex = 1
        Me.btnFibs.Text = "Generate Fib Numbers"
        Me.btnFibs.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(237, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 51)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(322, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 51)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(553, 426)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFibs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumFibs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplayFibs)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblUserInput)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Fibonacci numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblUserInput As System.Windows.Forms.Label
   Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
   Friend WithEvents txtDisplayFibs As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblNumFibs As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents btnFibs As System.Windows.Forms.Button
   Friend WithEvents btnClear As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

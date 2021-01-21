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
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.btnGCD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrime
        '
        Me.btnPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrime.Location = New System.Drawing.Point(12, 80)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(260, 36)
        Me.btnPrime.TabIndex = 0
        Me.btnPrime.Text = "Prime"
        Me.btnPrime.UseVisualStyleBackColor = True
        '
        'btnGCD
        '
        Me.btnGCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGCD.Location = New System.Drawing.Point(12, 145)
        Me.btnGCD.Name = "btnGCD"
        Me.btnGCD.Size = New System.Drawing.Size(260, 36)
        Me.btnGCD.TabIndex = 1
        Me.btnGCD.Text = "GCD"
        Me.btnGCD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGCD)
        Me.Controls.Add(Me.btnPrime)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrime As System.Windows.Forms.Button
    Friend WithEvents btnGCD As System.Windows.Forms.Button

End Class

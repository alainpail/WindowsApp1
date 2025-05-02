<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn4AI = New System.Windows.Forms.Button()
        Me.btn4AO = New System.Windows.Forms.Button()
        Me.btn4DO = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'btn4AI
        '
        Me.btn4AI.Location = New System.Drawing.Point(36, 327)
        Me.btn4AI.Name = "btn4AI"
        Me.btn4AI.Size = New System.Drawing.Size(174, 48)
        Me.btn4AI.TabIndex = 0
        Me.btn4AI.Text = "4AI"
        Me.btn4AI.UseVisualStyleBackColor = True
        '
        'btn4AO
        '
        Me.btn4AO.Location = New System.Drawing.Point(260, 327)
        Me.btn4AO.Name = "btn4AO"
        Me.btn4AO.Size = New System.Drawing.Size(186, 48)
        Me.btn4AO.TabIndex = 1
        Me.btn4AO.Text = "4AO"
        Me.btn4AO.UseVisualStyleBackColor = True
        '
        'btn4DO
        '
        Me.btn4DO.Location = New System.Drawing.Point(505, 327)
        Me.btn4DO.Name = "btn4DO"
        Me.btn4DO.Size = New System.Drawing.Size(201, 48)
        Me.btn4DO.TabIndex = 2
        Me.btn4DO.Text = "4DO"
        Me.btn4DO.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 442)
        Me.Controls.Add(Me.btn4DO)
        Me.Controls.Add(Me.btn4AO)
        Me.Controls.Add(Me.btn4AI)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn4AI As Button
    Friend WithEvents btn4AO As Button
    Friend WithEvents btn4DO As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class

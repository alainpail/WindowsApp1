<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resultats
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4ai = New System.Windows.Forms.Label()
        Me.Label4aitension = New System.Windows.Forms.Label()
        Me.Label4aitemp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4doNO = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4doNF = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4aocourant = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4aotension = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.result4aitemp = New System.Windows.Forms.Label()
        Me.result4aitension = New System.Windows.Forms.Label()
        Me.result4aicourant = New System.Windows.Forms.Label()
        Me.result4doNF = New System.Windows.Forms.Label()
        Me.resultadoNO = New System.Windows.Forms.Label()
        Me.result4aotension = New System.Windows.Forms.Label()
        Me.result4aocourant = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.result4aicourant)
        Me.GroupBox1.Controls.Add(Me.result4aitension)
        Me.GroupBox1.Controls.Add(Me.result4aitemp)
        Me.GroupBox1.Controls.Add(Me.Label4ai)
        Me.GroupBox1.Controls.Add(Me.Label4aitension)
        Me.GroupBox1.Controls.Add(Me.Label4aitemp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 382)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "4AI"
        '
        'Label4ai
        '
        Me.Label4ai.AutoSize = True
        Me.Label4ai.Location = New System.Drawing.Point(6, 225)
        Me.Label4ai.Name = "Label4ai"
        Me.Label4ai.Size = New System.Drawing.Size(44, 13)
        Me.Label4ai.TabIndex = 8
        Me.Label4ai.Text = "Courant"
        '
        'Label4aitension
        '
        Me.Label4aitension.AutoSize = True
        Me.Label4aitension.Location = New System.Drawing.Point(6, 159)
        Me.Label4aitension.Name = "Label4aitension"
        Me.Label4aitension.Size = New System.Drawing.Size(45, 13)
        Me.Label4aitension.TabIndex = 7
        Me.Label4aitension.Text = "Tension"
        '
        'Label4aitemp
        '
        Me.Label4aitemp.AutoSize = True
        Me.Label4aitemp.Location = New System.Drawing.Point(6, 91)
        Me.Label4aitemp.Name = "Label4aitemp"
        Me.Label4aitemp.Size = New System.Drawing.Size(67, 13)
        Me.Label4aitemp.TabIndex = 6
        Me.Label4aitemp.Text = "Température"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.GroupBox2.Controls.Add(Me.resultadoNO)
        Me.GroupBox2.Controls.Add(Me.result4doNF)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4doNO)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4doNF)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(260, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 382)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "4DO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Label10"
        '
        'Label4doNO
        '
        Me.Label4doNO.AutoSize = True
        Me.Label4doNO.Location = New System.Drawing.Point(1, 225)
        Me.Label4doNO.Name = "Label4doNO"
        Me.Label4doNO.Size = New System.Drawing.Size(104, 13)
        Me.Label4doNO.TabIndex = 4
        Me.Label4doNO.Text = "Normalement Ouvert"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Label8"
        '
        'Label4doNF
        '
        Me.Label4doNF.AutoSize = True
        Me.Label4doNF.Location = New System.Drawing.Point(1, 91)
        Me.Label4doNF.Name = "Label4doNF"
        Me.Label4doNF.Size = New System.Drawing.Size(101, 13)
        Me.Label4doNF.TabIndex = 2
        Me.Label4doNF.Text = "Normalement Fermé"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.result4aocourant)
        Me.GroupBox3.Controls.Add(Me.result4aotension)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label4aocourant)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label4aotension)
        Me.GroupBox3.Location = New System.Drawing.Point(553, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 381)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "4AO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Label14"
        '
        'Label4aocourant
        '
        Me.Label4aocourant.AutoSize = True
        Me.Label4aocourant.Location = New System.Drawing.Point(6, 225)
        Me.Label4aocourant.Name = "Label4aocourant"
        Me.Label4aocourant.Size = New System.Drawing.Size(44, 13)
        Me.Label4aocourant.TabIndex = 10
        Me.Label4aocourant.Text = "Courant"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Label12"
        '
        'Label4aotension
        '
        Me.Label4aotension.AutoSize = True
        Me.Label4aotension.Location = New System.Drawing.Point(6, 91)
        Me.Label4aotension.Name = "Label4aotension"
        Me.Label4aotension.Size = New System.Drawing.Size(45, 13)
        Me.Label4aotension.TabIndex = 8
        Me.Label4aotension.Text = "Tension"
        '
        'result4aitemp
        '
        Me.result4aitemp.AutoSize = True
        Me.result4aitemp.Location = New System.Drawing.Point(150, 93)
        Me.result4aitemp.Name = "result4aitemp"
        Me.result4aitemp.Size = New System.Drawing.Size(39, 13)
        Me.result4aitemp.TabIndex = 9
        Me.result4aitemp.Text = "Label4"
        '
        'result4aitension
        '
        Me.result4aitension.AutoSize = True
        Me.result4aitension.Location = New System.Drawing.Point(150, 159)
        Me.result4aitension.Name = "result4aitension"
        Me.result4aitension.Size = New System.Drawing.Size(39, 13)
        Me.result4aitension.TabIndex = 10
        Me.result4aitension.Text = "Label5"
        '
        'result4aicourant
        '
        Me.result4aicourant.AutoSize = True
        Me.result4aicourant.Location = New System.Drawing.Point(150, 225)
        Me.result4aicourant.Name = "result4aicourant"
        Me.result4aicourant.Size = New System.Drawing.Size(39, 13)
        Me.result4aicourant.TabIndex = 11
        Me.result4aicourant.Text = "Label6"
        '
        'result4doNF
        '
        Me.result4doNF.AutoSize = True
        Me.result4doNF.Location = New System.Drawing.Point(208, 91)
        Me.result4doNF.Name = "result4doNF"
        Me.result4doNF.Size = New System.Drawing.Size(39, 13)
        Me.result4doNF.TabIndex = 12
        Me.result4doNF.Text = "Label7"
        '
        'resultadoNO
        '
        Me.resultadoNO.AutoSize = True
        Me.resultadoNO.Location = New System.Drawing.Point(208, 225)
        Me.resultadoNO.Name = "resultadoNO"
        Me.resultadoNO.Size = New System.Drawing.Size(39, 13)
        Me.resultadoNO.TabIndex = 13
        Me.resultadoNO.Text = "Label9"
        '
        'result4aotension
        '
        Me.result4aotension.AutoSize = True
        Me.result4aotension.Location = New System.Drawing.Point(157, 91)
        Me.result4aotension.Name = "result4aotension"
        Me.result4aotension.Size = New System.Drawing.Size(45, 13)
        Me.result4aotension.TabIndex = 14
        Me.result4aotension.Text = "Label11"
        '
        'result4aocourant
        '
        Me.result4aocourant.AutoSize = True
        Me.result4aocourant.Location = New System.Drawing.Point(157, 225)
        Me.result4aocourant.Name = "result4aocourant"
        Me.result4aocourant.Size = New System.Drawing.Size(45, 13)
        Me.result4aocourant.TabIndex = 15
        Me.result4aocourant.Text = "Label13"
        '
        'resultats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "resultats"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4ai As Label
    Friend WithEvents Label4aitension As Label
    Friend WithEvents Label4aitemp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4doNO As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4doNF As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4aocourant As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4aotension As Label
    Friend WithEvents result4aicourant As Label
    Friend WithEvents result4aitension As Label
    Friend WithEvents result4aitemp As Label
    Friend WithEvents resultadoNO As Label
    Friend WithEvents result4doNF As Label
    Friend WithEvents result4aocourant As Label
    Friend WithEvents result4aotension As Label
End Class

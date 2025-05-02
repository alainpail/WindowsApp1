<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carte_4AO
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carte_4AO))
        Me.configcourant = New System.Windows.Forms.PictureBox()
        Me.configtension = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCourant = New System.Windows.Forms.Button()
        Me.btnTension = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnretour = New System.Windows.Forms.Button()
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'configcourant
        '
        Me.configcourant.Image = CType(resources.GetObject("configcourant.Image"), System.Drawing.Image)
        Me.configcourant.Location = New System.Drawing.Point(530, 106)
        Me.configcourant.Name = "configcourant"
        Me.configcourant.Size = New System.Drawing.Size(187, 169)
        Me.configcourant.TabIndex = 0
        Me.configcourant.TabStop = False
        '
        'configtension
        '
        Me.configtension.Image = CType(resources.GetObject("configtension.Image"), System.Drawing.Image)
        Me.configtension.Location = New System.Drawing.Point(84, 106)
        Me.configtension.Name = "configtension"
        Me.configtension.Size = New System.Drawing.Size(195, 168)
        Me.configtension.TabIndex = 1
        Me.configtension.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'btnCourant
        '
        Me.btnCourant.Location = New System.Drawing.Point(530, 358)
        Me.btnCourant.Name = "btnCourant"
        Me.btnCourant.Size = New System.Drawing.Size(187, 67)
        Me.btnCourant.TabIndex = 4
        Me.btnCourant.Text = "Courant"
        Me.btnCourant.UseVisualStyleBackColor = True
        '
        'btnTension
        '
        Me.btnTension.Location = New System.Drawing.Point(84, 358)
        Me.btnTension.Name = "btnTension"
        Me.btnTension.Size = New System.Drawing.Size(195, 67)
        Me.btnTension.TabIndex = 5
        Me.btnTension.Text = "Tension"
        Me.btnTension.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.DiscardNull = True
        '
        'btnretour
        '
        Me.btnretour.Location = New System.Drawing.Point(1, 0)
        Me.btnretour.Name = "btnretour"
        Me.btnretour.Size = New System.Drawing.Size(108, 28)
        Me.btnretour.TabIndex = 6
        Me.btnretour.Text = "retour"
        Me.btnretour.UseVisualStyleBackColor = True
        '
        'Carte_4AO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnretour)
        Me.Controls.Add(Me.btnTension)
        Me.Controls.Add(Me.btnCourant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.configtension)
        Me.Controls.Add(Me.configcourant)
        Me.Name = "Carte_4AO"
        Me.Text = "Carte_4AO"
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents configcourant As PictureBox
    Friend WithEvents configtension As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCourant As Button
    Friend WithEvents btnTension As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnretour As Button
End Class

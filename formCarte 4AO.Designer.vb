<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carte_4AO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carte_4AO))
        Me.configcourant = New System.Windows.Forms.PictureBox()
        Me.configtension = New System.Windows.Forms.PictureBox()
        Me.btnCourant = New System.Windows.Forms.Button()
        Me.btnTension = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnretour = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Voie4Tension = New System.Windows.Forms.CheckBox()
        Me.Voie3Tension = New System.Windows.Forms.CheckBox()
        Me.Voie2Tension = New System.Windows.Forms.CheckBox()
        Me.Voie1Tension = New System.Windows.Forms.CheckBox()
        Me.TVTension = New System.Windows.Forms.CheckBox()
        Me.Voie4Courant = New System.Windows.Forms.CheckBox()
        Me.Voie3Courant = New System.Windows.Forms.CheckBox()
        Me.Voie2Courant = New System.Windows.Forms.CheckBox()
        Me.Voie1Courant = New System.Windows.Forms.CheckBox()
        Me.TVCourant = New System.Windows.Forms.CheckBox()
        Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'configcourant
        '
        Me.configcourant.Image = CType(resources.GetObject("configcourant.Image"), System.Drawing.Image)
        Me.configcourant.Location = New System.Drawing.Point(422, 34)
        Me.configcourant.Name = "configcourant"
        Me.configcourant.Size = New System.Drawing.Size(164, 67)
        Me.configcourant.TabIndex = 0
        Me.configcourant.TabStop = False
        '
        'configtension
        '
        Me.configtension.Image = CType(resources.GetObject("configtension.Image"), System.Drawing.Image)
        Me.configtension.Location = New System.Drawing.Point(85, 34)
        Me.configtension.Name = "configtension"
        Me.configtension.Size = New System.Drawing.Size(162, 67)
        Me.configtension.TabIndex = 1
        Me.configtension.TabStop = False
        '
        'btnCourant
        '
        Me.btnCourant.Location = New System.Drawing.Point(402, 172)
        Me.btnCourant.Name = "btnCourant"
        Me.btnCourant.Size = New System.Drawing.Size(195, 67)
        Me.btnCourant.TabIndex = 4
        Me.btnCourant.Text = "Courant"
        Me.btnCourant.UseVisualStyleBackColor = True
        '
        'btnTension
        '
        Me.btnTension.Location = New System.Drawing.Point(58, 172)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Voie4Tension
        '
        Me.Voie4Tension.AutoSize = True
        Me.Voie4Tension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie4Tension.Location = New System.Drawing.Point(111, 334)
        Me.Voie4Tension.Name = "Voie4Tension"
        Me.Voie4Tension.Size = New System.Drawing.Size(56, 17)
        Me.Voie4Tension.TabIndex = 30
        Me.Voie4Tension.Text = "Voie 4"
        Me.Voie4Tension.UseVisualStyleBackColor = True
        '
        'Voie3Tension
        '
        Me.Voie3Tension.AutoSize = True
        Me.Voie3Tension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie3Tension.Location = New System.Drawing.Point(111, 311)
        Me.Voie3Tension.Name = "Voie3Tension"
        Me.Voie3Tension.Size = New System.Drawing.Size(56, 17)
        Me.Voie3Tension.TabIndex = 29
        Me.Voie3Tension.Text = "Voie 3"
        Me.Voie3Tension.UseVisualStyleBackColor = True
        '
        'Voie2Tension
        '
        Me.Voie2Tension.AutoSize = True
        Me.Voie2Tension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie2Tension.Location = New System.Drawing.Point(111, 288)
        Me.Voie2Tension.Name = "Voie2Tension"
        Me.Voie2Tension.Size = New System.Drawing.Size(56, 17)
        Me.Voie2Tension.TabIndex = 28
        Me.Voie2Tension.Text = "Voie 2"
        Me.Voie2Tension.UseVisualStyleBackColor = True
        '
        'Voie1Tension
        '
        Me.Voie1Tension.AutoSize = True
        Me.Voie1Tension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie1Tension.Location = New System.Drawing.Point(111, 265)
        Me.Voie1Tension.Name = "Voie1Tension"
        Me.Voie1Tension.Size = New System.Drawing.Size(56, 17)
        Me.Voie1Tension.TabIndex = 27
        Me.Voie1Tension.Text = "Voie 1"
        Me.Voie1Tension.UseVisualStyleBackColor = True
        '
        'TVTension
        '
        Me.TVTension.AutoSize = True
        Me.TVTension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TVTension.Location = New System.Drawing.Point(94, 242)
        Me.TVTension.Name = "TVTension"
        Me.TVTension.Size = New System.Drawing.Size(103, 17)
        Me.TVTension.TabIndex = 26
        Me.TVTension.Text = "Toutes les voies"
        Me.TVTension.UseVisualStyleBackColor = True
        '
        'Voie4Courant
        '
        Me.Voie4Courant.AutoSize = True
        Me.Voie4Courant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie4Courant.Location = New System.Drawing.Point(464, 334)
        Me.Voie4Courant.Name = "Voie4Courant"
        Me.Voie4Courant.Size = New System.Drawing.Size(56, 17)
        Me.Voie4Courant.TabIndex = 35
        Me.Voie4Courant.Text = "Voie 4"
        Me.Voie4Courant.UseVisualStyleBackColor = True
        '
        'Voie3Courant
        '
        Me.Voie3Courant.AutoSize = True
        Me.Voie3Courant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie3Courant.Location = New System.Drawing.Point(464, 311)
        Me.Voie3Courant.Name = "Voie3Courant"
        Me.Voie3Courant.Size = New System.Drawing.Size(56, 17)
        Me.Voie3Courant.TabIndex = 34
        Me.Voie3Courant.Text = "Voie 3"
        Me.Voie3Courant.UseVisualStyleBackColor = True
        '
        'Voie2Courant
        '
        Me.Voie2Courant.AutoSize = True
        Me.Voie2Courant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie2Courant.Location = New System.Drawing.Point(464, 288)
        Me.Voie2Courant.Name = "Voie2Courant"
        Me.Voie2Courant.Size = New System.Drawing.Size(56, 17)
        Me.Voie2Courant.TabIndex = 33
        Me.Voie2Courant.Text = "Voie 2"
        Me.Voie2Courant.UseVisualStyleBackColor = True
        '
        'Voie1Courant
        '
        Me.Voie1Courant.AutoSize = True
        Me.Voie1Courant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie1Courant.Location = New System.Drawing.Point(464, 265)
        Me.Voie1Courant.Name = "Voie1Courant"
        Me.Voie1Courant.Size = New System.Drawing.Size(56, 17)
        Me.Voie1Courant.TabIndex = 32
        Me.Voie1Courant.Text = "Voie 1"
        Me.Voie1Courant.UseVisualStyleBackColor = True
        '
        'TVCourant
        '
        Me.TVCourant.AutoSize = True
        Me.TVCourant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TVCourant.Location = New System.Drawing.Point(449, 242)
        Me.TVCourant.Name = "TVCourant"
        Me.TVCourant.Size = New System.Drawing.Size(103, 17)
        Me.TVCourant.TabIndex = 31
        Me.TVCourant.Text = "Toutes les voies"
        Me.TVCourant.UseVisualStyleBackColor = True
        '
        'TimerTest
        '
        Me.TimerTest.Interval = 5000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Label2"
        '
        'Carte_4AO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 368)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Voie4Courant)
        Me.Controls.Add(Me.Voie3Courant)
        Me.Controls.Add(Me.Voie2Courant)
        Me.Controls.Add(Me.Voie1Courant)
        Me.Controls.Add(Me.TVCourant)
        Me.Controls.Add(Me.Voie4Tension)
        Me.Controls.Add(Me.Voie3Tension)
        Me.Controls.Add(Me.Voie2Tension)
        Me.Controls.Add(Me.Voie1Tension)
        Me.Controls.Add(Me.TVTension)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnretour)
        Me.Controls.Add(Me.btnTension)
        Me.Controls.Add(Me.btnCourant)
        Me.Controls.Add(Me.configtension)
        Me.Controls.Add(Me.configcourant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carte_4AO"
        Me.Text = "Carte_4AO"
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents configcourant As PictureBox
    Friend WithEvents configtension As PictureBox
    Friend WithEvents btnCourant As Button
    Friend WithEvents btnTension As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnretour As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Voie4Tension As CheckBox
    Friend WithEvents Voie3Tension As CheckBox
    Friend WithEvents Voie2Tension As CheckBox
    Friend WithEvents Voie1Tension As CheckBox
    Friend WithEvents TVTension As CheckBox
    Friend WithEvents Voie4Courant As CheckBox
    Friend WithEvents Voie3Courant As CheckBox
    Friend WithEvents Voie2Courant As CheckBox
    Friend WithEvents Voie1Courant As CheckBox
    Friend WithEvents TVCourant As CheckBox
    Friend WithEvents TimerTest As Timer
    Friend WithEvents Label2 As Label
End Class

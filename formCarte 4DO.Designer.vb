<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carte_4DO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carte_4DO))
        Me.BtnCourant = New System.Windows.Forms.Button()
        Me.BtnTension = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnretour = New System.Windows.Forms.Button()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCourant
        '
        Me.BtnCourant.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnCourant.Location = New System.Drawing.Point(468, 196)
        Me.BtnCourant.Name = "BtnCourant"
        Me.BtnCourant.Size = New System.Drawing.Size(218, 62)
        Me.BtnCourant.TabIndex = 0
        Me.BtnCourant.Text = "Courant"
        Me.BtnCourant.UseVisualStyleBackColor = True
        '
        'BtnTension
        '
        Me.BtnTension.Location = New System.Drawing.Point(84, 196)
        Me.BtnTension.Name = "BtnTension"
        Me.BtnTension.Size = New System.Drawing.Size(194, 62)
        Me.BtnTension.TabIndex = 1
        Me.BtnTension.Text = "Tension"
        Me.BtnTension.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(468, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 119)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(84, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 119)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'btnretour
        '
        Me.btnretour.Location = New System.Drawing.Point(2, 0)
        Me.btnretour.Name = "btnretour"
        Me.btnretour.Size = New System.Drawing.Size(99, 29)
        Me.btnretour.TabIndex = 6
        Me.btnretour.Text = "Retour"
        Me.btnretour.UseVisualStyleBackColor = True
        '
        'Voie4Tension
        '
        Me.Voie4Tension.AutoSize = True
        Me.Voie4Tension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Voie4Tension.Location = New System.Drawing.Point(125, 356)
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
        Me.Voie3Tension.Location = New System.Drawing.Point(125, 333)
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
        Me.Voie2Tension.Location = New System.Drawing.Point(125, 310)
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
        Me.Voie1Tension.Location = New System.Drawing.Point(125, 287)
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
        Me.TVTension.Location = New System.Drawing.Point(125, 264)
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
        Me.Voie4Courant.Location = New System.Drawing.Point(521, 356)
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
        Me.Voie3Courant.Location = New System.Drawing.Point(521, 333)
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
        Me.Voie2Courant.Location = New System.Drawing.Point(521, 310)
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
        Me.Voie1Courant.Location = New System.Drawing.Point(521, 287)
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
        Me.TVCourant.Location = New System.Drawing.Point(521, 264)
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
        Me.Label2.Location = New System.Drawing.Point(700, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Label2"
        '
        'Carte_4DO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 393)
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
        Me.Controls.Add(Me.btnretour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTension)
        Me.Controls.Add(Me.BtnCourant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carte_4DO"
        Me.Text = "Carte_4DO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCourant As Button
    Friend WithEvents BtnTension As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnretour As Button
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

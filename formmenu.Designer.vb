<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formmenu))
        Me.btniden = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
        Me.BtnReconnexion = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.modedemo = New System.Windows.Forms.Panel()
        Me.btndemo = New System.Windows.Forms.Button()
        Me.CB_4DO = New System.Windows.Forms.CheckBox()
        Me.CB_4AO = New System.Windows.Forms.CheckBox()
        Me.CB_4AI = New System.Windows.Forms.CheckBox()
        Me.demo = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.modedemo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btniden
        '
        Me.btniden.Location = New System.Drawing.Point(472, 257)
        Me.btniden.Name = "btniden"
        Me.btniden.Size = New System.Drawing.Size(174, 48)
        Me.btniden.TabIndex = 0
        Me.btniden.Text = "identification de la carte"
        Me.btniden.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "COM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Carte 4AO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(253, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 183)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 120)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Carte 4AI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(627, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Carte 4DO"
        '
        'TimerTest
        '
        Me.TimerTest.Interval = 5000
        '
        'BtnReconnexion
        '
        Me.BtnReconnexion.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnReconnexion.Location = New System.Drawing.Point(112, 257)
        Me.BtnReconnexion.Name = "BtnReconnexion"
        Me.BtnReconnexion.Size = New System.Drawing.Size(171, 47)
        Me.BtnReconnexion.TabIndex = 13
        Me.BtnReconnexion.Text = "connexion avec le PSOC"
        Me.BtnReconnexion.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(578, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(170, 102)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "v"
        '
        'modedemo
        '
        Me.modedemo.Controls.Add(Me.btndemo)
        Me.modedemo.Controls.Add(Me.CB_4DO)
        Me.modedemo.Controls.Add(Me.CB_4AO)
        Me.modedemo.Controls.Add(Me.CB_4AI)
        Me.modedemo.Location = New System.Drawing.Point(800, 77)
        Me.modedemo.Name = "modedemo"
        Me.modedemo.Size = New System.Drawing.Size(206, 314)
        Me.modedemo.TabIndex = 16
        '
        'btndemo
        '
        Me.btndemo.Location = New System.Drawing.Point(50, 109)
        Me.btndemo.Name = "btndemo"
        Me.btndemo.Size = New System.Drawing.Size(112, 37)
        Me.btndemo.TabIndex = 3
        Me.btndemo.Text = "Demo"
        Me.btndemo.UseVisualStyleBackColor = True
        '
        'CB_4DO
        '
        Me.CB_4DO.AutoSize = True
        Me.CB_4DO.Location = New System.Drawing.Point(54, 236)
        Me.CB_4DO.Name = "CB_4DO"
        Me.CB_4DO.Size = New System.Drawing.Size(48, 17)
        Me.CB_4DO.TabIndex = 2
        Me.CB_4DO.Text = "4DO"
        Me.CB_4DO.UseVisualStyleBackColor = True
        '
        'CB_4AO
        '
        Me.CB_4AO.AutoSize = True
        Me.CB_4AO.Location = New System.Drawing.Point(54, 213)
        Me.CB_4AO.Name = "CB_4AO"
        Me.CB_4AO.Size = New System.Drawing.Size(47, 17)
        Me.CB_4AO.TabIndex = 1
        Me.CB_4AO.Text = "4AO"
        Me.CB_4AO.UseVisualStyleBackColor = True
        '
        'CB_4AI
        '
        Me.CB_4AI.AutoSize = True
        Me.CB_4AI.Location = New System.Drawing.Point(54, 190)
        Me.CB_4AI.Name = "CB_4AI"
        Me.CB_4AI.Size = New System.Drawing.Size(42, 17)
        Me.CB_4AI.TabIndex = 0
        Me.CB_4AI.Text = "4AI"
        Me.CB_4AI.UseVisualStyleBackColor = True
        '
        'demo
        '
        Me.demo.AutoSize = True
        Me.demo.Location = New System.Drawing.Point(692, 309)
        Me.demo.Name = "demo"
        Me.demo.Size = New System.Drawing.Size(81, 17)
        Me.demo.TabIndex = 17
        Me.demo.Text = "mode demo"
        Me.demo.UseVisualStyleBackColor = True
        '
        'formmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 418)
        Me.Controls.Add(Me.demo)
        Me.Controls.Add(Me.modedemo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BtnReconnexion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btniden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formmenu"
        Me.Text = "Menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.modedemo.ResumeLayout(False)
        Me.modedemo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btniden As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimerTest As Timer
    Friend WithEvents BtnReconnexion As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents modedemo As Panel
    Friend WithEvents demo As CheckBox
    Friend WithEvents btndemo As Button
    Friend WithEvents CB_4DO As CheckBox
    Friend WithEvents CB_4AO As CheckBox
    Friend WithEvents CB_4AI As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carte4ai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carte4ai))
        Me.btntemperature = New System.Windows.Forms.Button()
        Me.BtnTension = New System.Windows.Forms.Button()
        Me.btncourant = New System.Windows.Forms.Button()
        Me.configtension = New System.Windows.Forms.PictureBox()
        Me.configcourant = New System.Windows.Forms.PictureBox()
        Me.configtemp = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnretour = New System.Windows.Forms.Button()
        Me.BtnResistance = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TVTemp = New System.Windows.Forms.CheckBox()
        Me.Voie1Temp = New System.Windows.Forms.CheckBox()
        Me.Voie2temp = New System.Windows.Forms.CheckBox()
        Me.Voie3Temp = New System.Windows.Forms.CheckBox()
        Me.Voie4Temp = New System.Windows.Forms.CheckBox()
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
        Me.Voie4RES = New System.Windows.Forms.CheckBox()
        Me.Voie3RES = New System.Windows.Forms.CheckBox()
        Me.Voie2RES = New System.Windows.Forms.CheckBox()
        Me.Voie1RES = New System.Windows.Forms.CheckBox()
        Me.TVRES = New System.Windows.Forms.CheckBox()
        Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTension = New System.Windows.Forms.TextBox()
        Me.TextBoxCourant = New System.Windows.Forms.TextBox()
        Me.TextBoxRES = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntemperature
        '
        resources.ApplyResources(Me.btntemperature, "btntemperature")
        Me.btntemperature.Name = "btntemperature"
        Me.btntemperature.UseVisualStyleBackColor = True
        '
        'BtnTension
        '
        resources.ApplyResources(Me.BtnTension, "BtnTension")
        Me.BtnTension.Name = "BtnTension"
        Me.BtnTension.UseVisualStyleBackColor = True
        '
        'btncourant
        '
        resources.ApplyResources(Me.btncourant, "btncourant")
        Me.btncourant.Name = "btncourant"
        Me.btncourant.UseVisualStyleBackColor = True
        '
        'configtension
        '
        resources.ApplyResources(Me.configtension, "configtension")
        Me.configtension.Name = "configtension"
        Me.configtension.TabStop = False
        '
        'configcourant
        '
        resources.ApplyResources(Me.configcourant, "configcourant")
        Me.configcourant.Name = "configcourant"
        Me.configcourant.TabStop = False
        '
        'configtemp
        '
        resources.ApplyResources(Me.configtemp, "configtemp")
        Me.configtemp.Name = "configtemp"
        Me.configtemp.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnretour
        '
        resources.ApplyResources(Me.btnretour, "btnretour")
        Me.btnretour.Name = "btnretour"
        Me.btnretour.UseVisualStyleBackColor = True
        '
        'BtnResistance
        '
        resources.ApplyResources(Me.BtnResistance, "BtnResistance")
        Me.BtnResistance.Name = "BtnResistance"
        Me.BtnResistance.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'TVTemp
        '
        resources.ApplyResources(Me.TVTemp, "TVTemp")
        Me.TVTemp.Name = "TVTemp"
        Me.TVTemp.UseVisualStyleBackColor = True
        '
        'Voie1Temp
        '
        resources.ApplyResources(Me.Voie1Temp, "Voie1Temp")
        Me.Voie1Temp.Name = "Voie1Temp"
        Me.Voie1Temp.UseVisualStyleBackColor = True
        '
        'Voie2temp
        '
        resources.ApplyResources(Me.Voie2temp, "Voie2temp")
        Me.Voie2temp.Name = "Voie2temp"
        Me.Voie2temp.UseVisualStyleBackColor = True
        '
        'Voie3Temp
        '
        resources.ApplyResources(Me.Voie3Temp, "Voie3Temp")
        Me.Voie3Temp.Name = "Voie3Temp"
        Me.Voie3Temp.UseVisualStyleBackColor = True
        '
        'Voie4Temp
        '
        resources.ApplyResources(Me.Voie4Temp, "Voie4Temp")
        Me.Voie4Temp.Name = "Voie4Temp"
        Me.Voie4Temp.UseVisualStyleBackColor = True
        '
        'Voie4Tension
        '
        resources.ApplyResources(Me.Voie4Tension, "Voie4Tension")
        Me.Voie4Tension.Name = "Voie4Tension"
        Me.Voie4Tension.UseVisualStyleBackColor = True
        '
        'Voie3Tension
        '
        resources.ApplyResources(Me.Voie3Tension, "Voie3Tension")
        Me.Voie3Tension.Name = "Voie3Tension"
        Me.Voie3Tension.UseVisualStyleBackColor = True
        '
        'Voie2Tension
        '
        resources.ApplyResources(Me.Voie2Tension, "Voie2Tension")
        Me.Voie2Tension.Name = "Voie2Tension"
        Me.Voie2Tension.UseVisualStyleBackColor = True
        '
        'Voie1Tension
        '
        resources.ApplyResources(Me.Voie1Tension, "Voie1Tension")
        Me.Voie1Tension.Name = "Voie1Tension"
        Me.Voie1Tension.UseVisualStyleBackColor = True
        '
        'TVTension
        '
        resources.ApplyResources(Me.TVTension, "TVTension")
        Me.TVTension.Name = "TVTension"
        Me.TVTension.UseVisualStyleBackColor = True
        '
        'Voie4Courant
        '
        resources.ApplyResources(Me.Voie4Courant, "Voie4Courant")
        Me.Voie4Courant.Name = "Voie4Courant"
        Me.Voie4Courant.UseVisualStyleBackColor = True
        '
        'Voie3Courant
        '
        resources.ApplyResources(Me.Voie3Courant, "Voie3Courant")
        Me.Voie3Courant.Name = "Voie3Courant"
        Me.Voie3Courant.UseVisualStyleBackColor = True
        '
        'Voie2Courant
        '
        resources.ApplyResources(Me.Voie2Courant, "Voie2Courant")
        Me.Voie2Courant.Name = "Voie2Courant"
        Me.Voie2Courant.UseVisualStyleBackColor = True
        '
        'Voie1Courant
        '
        resources.ApplyResources(Me.Voie1Courant, "Voie1Courant")
        Me.Voie1Courant.Name = "Voie1Courant"
        Me.Voie1Courant.UseVisualStyleBackColor = True
        '
        'TVCourant
        '
        resources.ApplyResources(Me.TVCourant, "TVCourant")
        Me.TVCourant.Name = "TVCourant"
        Me.TVCourant.UseVisualStyleBackColor = True
        '
        'Voie4RES
        '
        resources.ApplyResources(Me.Voie4RES, "Voie4RES")
        Me.Voie4RES.Name = "Voie4RES"
        Me.Voie4RES.UseVisualStyleBackColor = True
        '
        'Voie3RES
        '
        resources.ApplyResources(Me.Voie3RES, "Voie3RES")
        Me.Voie3RES.Name = "Voie3RES"
        Me.Voie3RES.UseVisualStyleBackColor = True
        '
        'Voie2RES
        '
        resources.ApplyResources(Me.Voie2RES, "Voie2RES")
        Me.Voie2RES.Name = "Voie2RES"
        Me.Voie2RES.UseVisualStyleBackColor = True
        '
        'Voie1RES
        '
        resources.ApplyResources(Me.Voie1RES, "Voie1RES")
        Me.Voie1RES.Name = "Voie1RES"
        Me.Voie1RES.UseVisualStyleBackColor = True
        '
        'TVRES
        '
        resources.ApplyResources(Me.TVRES, "TVRES")
        Me.TVRES.Name = "TVRES"
        Me.TVRES.UseVisualStyleBackColor = True
        '
        'TimerTest
        '
        Me.TimerTest.Interval = 5000
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TextBoxTension
        '
        resources.ApplyResources(Me.TextBoxTension, "TextBoxTension")
        Me.TextBoxTension.Name = "TextBoxTension"
        '
        'TextBoxCourant
        '
        resources.ApplyResources(Me.TextBoxCourant, "TextBoxCourant")
        Me.TextBoxCourant.Name = "TextBoxCourant"
        '
        'TextBoxRES
        '
        resources.ApplyResources(Me.TextBoxRES, "TextBoxRES")
        Me.TextBoxRES.Name = "TextBoxRES"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Carte4ai
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxRES)
        Me.Controls.Add(Me.TextBoxCourant)
        Me.Controls.Add(Me.TextBoxTension)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Voie4RES)
        Me.Controls.Add(Me.Voie3RES)
        Me.Controls.Add(Me.Voie2RES)
        Me.Controls.Add(Me.Voie1RES)
        Me.Controls.Add(Me.TVRES)
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
        Me.Controls.Add(Me.Voie4Temp)
        Me.Controls.Add(Me.Voie3Temp)
        Me.Controls.Add(Me.Voie2temp)
        Me.Controls.Add(Me.Voie1Temp)
        Me.Controls.Add(Me.TVTemp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnResistance)
        Me.Controls.Add(Me.btnretour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.configtemp)
        Me.Controls.Add(Me.configcourant)
        Me.Controls.Add(Me.configtension)
        Me.Controls.Add(Me.btncourant)
        Me.Controls.Add(Me.BtnTension)
        Me.Controls.Add(Me.btntemperature)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Carte4ai"
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.configtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntemperature As Button
    Friend WithEvents BtnTension As Button
    Friend WithEvents btncourant As Button
    Friend WithEvents configtension As PictureBox
    Friend WithEvents configcourant As PictureBox
    Friend WithEvents configtemp As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents btnretour As Button
    Friend WithEvents BtnResistance As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TVTemp As CheckBox
    Friend WithEvents Voie1Temp As CheckBox
    Friend WithEvents Voie2temp As CheckBox
    Friend WithEvents Voie3Temp As CheckBox
    Friend WithEvents Voie4Temp As CheckBox
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
    Friend WithEvents Voie4RES As CheckBox
    Friend WithEvents Voie3RES As CheckBox
    Friend WithEvents Voie2RES As CheckBox
    Friend WithEvents Voie1RES As CheckBox
    Friend WithEvents TVRES As CheckBox
    Friend WithEvents TimerTest As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTension As TextBox
    Friend WithEvents TextBoxCourant As TextBox
    Friend WithEvents TextBoxRES As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carte4ai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carte4ai))
        Me.btntemperature = New System.Windows.Forms.Button()
        Me.BtnTension = New System.Windows.Forms.Button()
        Me.btncourant = New System.Windows.Forms.Button()
        Me.configtension = New System.Windows.Forms.PictureBox()
        Me.configcourant = New System.Windows.Forms.PictureBox()
        Me.configtemp = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnretour = New System.Windows.Forms.Button()
        CType(Me.configtension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configcourant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.configtemp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnretour
        '
        resources.ApplyResources(Me.btnretour, "btnretour")
        Me.btnretour.Name = "btnretour"
        Me.btnretour.UseVisualStyleBackColor = True
        '
        'Carte4ai
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnretour)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnretour As Button
End Class

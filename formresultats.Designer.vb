<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formresultats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formresultats))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.result4DOCourant4 = New System.Windows.Forms.Label()
        Me.result4DOTension4 = New System.Windows.Forms.Label()
        Me.result4DOCourant3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.result4DOCourant2 = New System.Windows.Forms.Label()
        Me.result4DOTension3 = New System.Windows.Forms.Label()
        Me.result4DOCourant1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.result4DOTension2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.result4DOTension1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4doNO = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4doNF = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.result4AOCourant4 = New System.Windows.Forms.Label()
        Me.result4AOTension4 = New System.Windows.Forms.Label()
        Me.result4AOCourant3 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.result4AOCourant2 = New System.Windows.Forms.Label()
        Me.result4AOTension3 = New System.Windows.Forms.Label()
        Me.result4AOCourant1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.result4AOTension2 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.result4AOTension1 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label4aocourant = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label4aotension = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4aitemp = New System.Windows.Forms.Label()
        Me.Label4aitension = New System.Windows.Forms.Label()
        Me.Label4ai = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.result4AIRES4 = New System.Windows.Forms.Label()
        Me.result4AIRES3 = New System.Windows.Forms.Label()
        Me.result4AIRES2 = New System.Windows.Forms.Label()
        Me.result4AIRES1 = New System.Windows.Forms.Label()
        Me.result4AICourant4 = New System.Windows.Forms.Label()
        Me.result4AICourant3 = New System.Windows.Forms.Label()
        Me.result4AICourant2 = New System.Windows.Forms.Label()
        Me.result4AICourant1 = New System.Windows.Forms.Label()
        Me.result4AITension4 = New System.Windows.Forms.Label()
        Me.result4AITension3 = New System.Windows.Forms.Label()
        Me.result4AITension2 = New System.Windows.Forms.Label()
        Me.result4AITension1 = New System.Windows.Forms.Label()
        Me.resultat4AItemp4 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.resultat4AItemp3 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.resultat4AItemp2 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.resultat4AItemp1 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnresult = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnenregistrer = New System.Windows.Forms.Button()
        Me.BtnRetourTests = New System.Windows.Forms.Button()
        Me.Btnretourmenu = New System.Windows.Forms.Button()
        Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Btnreconnexion = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.GroupBox2.Controls.Add(Me.result4DOCourant4)
        Me.GroupBox2.Controls.Add(Me.result4DOTension4)
        Me.GroupBox2.Controls.Add(Me.result4DOCourant3)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.result4DOCourant2)
        Me.GroupBox2.Controls.Add(Me.result4DOTension3)
        Me.GroupBox2.Controls.Add(Me.result4DOCourant1)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.result4DOTension2)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.result4DOTension1)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label4doNO)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label4doNF)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(324, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 295)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "4DO"
        '
        'result4DOCourant4
        '
        Me.result4DOCourant4.AutoSize = True
        Me.result4DOCourant4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOCourant4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOCourant4.Location = New System.Drawing.Point(108, 251)
        Me.result4DOCourant4.Name = "result4DOCourant4"
        Me.result4DOCourant4.Size = New System.Drawing.Size(29, 15)
        Me.result4DOCourant4.TabIndex = 48
        Me.result4DOCourant4.Text = "     "
        '
        'result4DOTension4
        '
        Me.result4DOTension4.AutoSize = True
        Me.result4DOTension4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOTension4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOTension4.Location = New System.Drawing.Point(108, 126)
        Me.result4DOTension4.Name = "result4DOTension4"
        Me.result4DOTension4.Size = New System.Drawing.Size(29, 15)
        Me.result4DOTension4.TabIndex = 40
        Me.result4DOTension4.Text = "     "
        '
        'result4DOCourant3
        '
        Me.result4DOCourant3.AutoSize = True
        Me.result4DOCourant3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOCourant3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOCourant3.Location = New System.Drawing.Point(108, 229)
        Me.result4DOCourant3.Name = "result4DOCourant3"
        Me.result4DOCourant3.Size = New System.Drawing.Size(25, 15)
        Me.result4DOCourant3.TabIndex = 47
        Me.result4DOCourant3.Text = "    "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 251)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Voie 4"
        '
        'result4DOCourant2
        '
        Me.result4DOCourant2.AutoSize = True
        Me.result4DOCourant2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOCourant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOCourant2.Location = New System.Drawing.Point(108, 206)
        Me.result4DOCourant2.Name = "result4DOCourant2"
        Me.result4DOCourant2.Size = New System.Drawing.Size(21, 15)
        Me.result4DOCourant2.TabIndex = 46
        Me.result4DOCourant2.Text = "   "
        '
        'result4DOTension3
        '
        Me.result4DOTension3.AutoSize = True
        Me.result4DOTension3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOTension3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOTension3.Location = New System.Drawing.Point(108, 95)
        Me.result4DOTension3.Name = "result4DOTension3"
        Me.result4DOTension3.Size = New System.Drawing.Size(25, 15)
        Me.result4DOTension3.TabIndex = 39
        Me.result4DOTension3.Text = "    "
        '
        'result4DOCourant1
        '
        Me.result4DOCourant1.AutoSize = True
        Me.result4DOCourant1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOCourant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOCourant1.Location = New System.Drawing.Point(108, 182)
        Me.result4DOCourant1.Name = "result4DOCourant1"
        Me.result4DOCourant1.Size = New System.Drawing.Size(25, 15)
        Me.result4DOCourant1.TabIndex = 45
        Me.result4DOCourant1.Text = "    "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Voie 3"
        '
        'result4DOTension2
        '
        Me.result4DOTension2.AutoSize = True
        Me.result4DOTension2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOTension2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOTension2.Location = New System.Drawing.Point(108, 72)
        Me.result4DOTension2.Name = "result4DOTension2"
        Me.result4DOTension2.Size = New System.Drawing.Size(29, 15)
        Me.result4DOTension2.TabIndex = 38
        Me.result4DOTension2.Text = "     "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 208)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Voie 2"
        '
        'result4DOTension1
        '
        Me.result4DOTension1.AutoSize = True
        Me.result4DOTension1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4DOTension1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4DOTension1.Location = New System.Drawing.Point(108, 48)
        Me.result4DOTension1.Name = "result4DOTension1"
        Me.result4DOTension1.Size = New System.Drawing.Size(25, 15)
        Me.result4DOTension1.TabIndex = 37
        Me.result4DOTension1.Text = "    "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(28, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Voie 1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Voie 4"
        '
        'Label4doNO
        '
        Me.Label4doNO.AutoSize = True
        Me.Label4doNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4doNO.Location = New System.Drawing.Point(28, 159)
        Me.Label4doNO.Name = "Label4doNO"
        Me.Label4doNO.Size = New System.Drawing.Size(61, 16)
        Me.Label4doNO.TabIndex = 4
        Me.Label4doNO.Text = "Courant"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Voie 3"
        '
        'Label4doNF
        '
        Me.Label4doNF.AutoSize = True
        Me.Label4doNF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4doNF.Location = New System.Drawing.Point(31, 16)
        Me.Label4doNF.Name = "Label4doNF"
        Me.Label4doNF.Size = New System.Drawing.Size(64, 16)
        Me.Label4doNF.TabIndex = 2
        Me.Label4doNF.Text = "Tension"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(31, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Voie 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(31, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Voie 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.result4AOCourant4)
        Me.GroupBox3.Controls.Add(Me.result4AOTension4)
        Me.GroupBox3.Controls.Add(Me.result4AOCourant3)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.result4AOCourant2)
        Me.GroupBox3.Controls.Add(Me.result4AOTension3)
        Me.GroupBox3.Controls.Add(Me.result4AOCourant1)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.result4AOTension2)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.result4AOTension1)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label4aocourant)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label4aotension)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Location = New System.Drawing.Point(579, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 293)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "4AO"
        '
        'result4AOCourant4
        '
        Me.result4AOCourant4.AutoSize = True
        Me.result4AOCourant4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOCourant4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOCourant4.Location = New System.Drawing.Point(82, 247)
        Me.result4AOCourant4.Name = "result4AOCourant4"
        Me.result4AOCourant4.Size = New System.Drawing.Size(33, 15)
        Me.result4AOCourant4.TabIndex = 52
        Me.result4AOCourant4.Text = "      "
        '
        'result4AOTension4
        '
        Me.result4AOTension4.AutoSize = True
        Me.result4AOTension4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOTension4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOTension4.Location = New System.Drawing.Point(79, 123)
        Me.result4AOTension4.Name = "result4AOTension4"
        Me.result4AOTension4.Size = New System.Drawing.Size(29, 15)
        Me.result4AOTension4.TabIndex = 44
        Me.result4AOTension4.Text = "     "
        '
        'result4AOCourant3
        '
        Me.result4AOCourant3.AutoSize = True
        Me.result4AOCourant3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOCourant3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOCourant3.Location = New System.Drawing.Point(82, 227)
        Me.result4AOCourant3.Name = "result4AOCourant3"
        Me.result4AOCourant3.Size = New System.Drawing.Size(29, 15)
        Me.result4AOCourant3.TabIndex = 51
        Me.result4AOCourant3.Text = "     "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(27, 249)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Voie 4"
        '
        'result4AOCourant2
        '
        Me.result4AOCourant2.AutoSize = True
        Me.result4AOCourant2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOCourant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOCourant2.Location = New System.Drawing.Point(82, 204)
        Me.result4AOCourant2.Name = "result4AOCourant2"
        Me.result4AOCourant2.Size = New System.Drawing.Size(25, 15)
        Me.result4AOCourant2.TabIndex = 50
        Me.result4AOCourant2.Text = "    "
        '
        'result4AOTension3
        '
        Me.result4AOTension3.AutoSize = True
        Me.result4AOTension3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOTension3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOTension3.Location = New System.Drawing.Point(79, 92)
        Me.result4AOTension3.Name = "result4AOTension3"
        Me.result4AOTension3.Size = New System.Drawing.Size(29, 15)
        Me.result4AOTension3.TabIndex = 43
        Me.result4AOTension3.Text = "     "
        '
        'result4AOCourant1
        '
        Me.result4AOCourant1.AutoSize = True
        Me.result4AOCourant1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOCourant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOCourant1.Location = New System.Drawing.Point(82, 180)
        Me.result4AOCourant1.Name = "result4AOCourant1"
        Me.result4AOCourant1.Size = New System.Drawing.Size(29, 15)
        Me.result4AOCourant1.TabIndex = 49
        Me.result4AOCourant1.Text = "     "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(27, 227)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "Voie 3"
        '
        'result4AOTension2
        '
        Me.result4AOTension2.AutoSize = True
        Me.result4AOTension2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOTension2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOTension2.Location = New System.Drawing.Point(79, 69)
        Me.result4AOTension2.Name = "result4AOTension2"
        Me.result4AOTension2.Size = New System.Drawing.Size(29, 15)
        Me.result4AOTension2.TabIndex = 42
        Me.result4AOTension2.Text = "     "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(27, 204)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(43, 13)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Voie 2"
        '
        'result4AOTension1
        '
        Me.result4AOTension1.AutoSize = True
        Me.result4AOTension1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AOTension1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AOTension1.Location = New System.Drawing.Point(79, 45)
        Me.result4AOTension1.Name = "result4AOTension1"
        Me.result4AOTension1.Size = New System.Drawing.Size(25, 15)
        Me.result4AOTension1.TabIndex = 41
        Me.result4AOTension1.Text = "    "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(27, 180)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 13)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "Voie 1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Voie 4"
        '
        'Label4aocourant
        '
        Me.Label4aocourant.AutoSize = True
        Me.Label4aocourant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4aocourant.Location = New System.Drawing.Point(15, 157)
        Me.Label4aocourant.Name = "Label4aocourant"
        Me.Label4aocourant.Size = New System.Drawing.Size(61, 16)
        Me.Label4aocourant.TabIndex = 10
        Me.Label4aocourant.Text = "Courant"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Voie 3"
        '
        'Label4aotension
        '
        Me.Label4aotension.AutoSize = True
        Me.Label4aotension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4aotension.Location = New System.Drawing.Point(6, 16)
        Me.Label4aotension.Name = "Label4aotension"
        Me.Label4aotension.Size = New System.Drawing.Size(64, 16)
        Me.Label4aotension.TabIndex = 8
        Me.Label4aotension.Text = "Tension"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Voie 2"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Voie 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COM"
        '
        'Label4aitemp
        '
        Me.Label4aitemp.AutoSize = True
        Me.Label4aitemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4aitemp.Location = New System.Drawing.Point(6, 16)
        Me.Label4aitemp.Name = "Label4aitemp"
        Me.Label4aitemp.Size = New System.Drawing.Size(97, 16)
        Me.Label4aitemp.TabIndex = 6
        Me.Label4aitemp.Text = "Température"
        '
        'Label4aitension
        '
        Me.Label4aitension.AutoSize = True
        Me.Label4aitension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4aitension.Location = New System.Drawing.Point(7, 159)
        Me.Label4aitension.Name = "Label4aitension"
        Me.Label4aitension.Size = New System.Drawing.Size(64, 16)
        Me.Label4aitension.TabIndex = 7
        Me.Label4aitension.Text = "Tension"
        '
        'Label4ai
        '
        Me.Label4ai.AutoSize = True
        Me.Label4ai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4ai.Location = New System.Drawing.Point(24, 279)
        Me.Label4ai.Name = "Label4ai"
        Me.Label4ai.Size = New System.Drawing.Size(61, 16)
        Me.Label4ai.TabIndex = 8
        Me.Label4ai.Text = "Courant"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.result4AIRES4)
        Me.GroupBox1.Controls.Add(Me.result4AIRES3)
        Me.GroupBox1.Controls.Add(Me.result4AIRES2)
        Me.GroupBox1.Controls.Add(Me.result4AIRES1)
        Me.GroupBox1.Controls.Add(Me.result4AICourant4)
        Me.GroupBox1.Controls.Add(Me.result4AICourant3)
        Me.GroupBox1.Controls.Add(Me.result4AICourant2)
        Me.GroupBox1.Controls.Add(Me.result4AICourant1)
        Me.GroupBox1.Controls.Add(Me.result4AITension4)
        Me.GroupBox1.Controls.Add(Me.result4AITension3)
        Me.GroupBox1.Controls.Add(Me.result4AITension2)
        Me.GroupBox1.Controls.Add(Me.result4AITension1)
        Me.GroupBox1.Controls.Add(Me.resultat4AItemp4)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.resultat4AItemp3)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.resultat4AItemp2)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.resultat4AItemp1)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4ai)
        Me.GroupBox1.Controls.Add(Me.Label4aitension)
        Me.GroupBox1.Controls.Add(Me.Label4aitemp)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 565)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "4AI"
        '
        'result4AIRES4
        '
        Me.result4AIRES4.AutoSize = True
        Me.result4AIRES4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AIRES4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AIRES4.Location = New System.Drawing.Point(177, 523)
        Me.result4AIRES4.Name = "result4AIRES4"
        Me.result4AIRES4.Size = New System.Drawing.Size(33, 15)
        Me.result4AIRES4.TabIndex = 40
        Me.result4AIRES4.Text = "      "
        '
        'result4AIRES3
        '
        Me.result4AIRES3.AutoSize = True
        Me.result4AIRES3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AIRES3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AIRES3.Location = New System.Drawing.Point(177, 493)
        Me.result4AIRES3.Name = "result4AIRES3"
        Me.result4AIRES3.Size = New System.Drawing.Size(33, 15)
        Me.result4AIRES3.TabIndex = 39
        Me.result4AIRES3.Text = "      "
        '
        'result4AIRES2
        '
        Me.result4AIRES2.AutoSize = True
        Me.result4AIRES2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AIRES2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AIRES2.Location = New System.Drawing.Point(177, 469)
        Me.result4AIRES2.Name = "result4AIRES2"
        Me.result4AIRES2.Size = New System.Drawing.Size(33, 15)
        Me.result4AIRES2.TabIndex = 38
        Me.result4AIRES2.Text = "      "
        '
        'result4AIRES1
        '
        Me.result4AIRES1.AutoSize = True
        Me.result4AIRES1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AIRES1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AIRES1.Location = New System.Drawing.Point(177, 445)
        Me.result4AIRES1.Name = "result4AIRES1"
        Me.result4AIRES1.Size = New System.Drawing.Size(33, 15)
        Me.result4AIRES1.TabIndex = 37
        Me.result4AIRES1.Text = "      "
        '
        'result4AICourant4
        '
        Me.result4AICourant4.AutoSize = True
        Me.result4AICourant4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AICourant4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AICourant4.Location = New System.Drawing.Point(177, 384)
        Me.result4AICourant4.Name = "result4AICourant4"
        Me.result4AICourant4.Size = New System.Drawing.Size(33, 15)
        Me.result4AICourant4.TabIndex = 36
        Me.result4AICourant4.Text = "      "
        '
        'result4AICourant3
        '
        Me.result4AICourant3.AutoSize = True
        Me.result4AICourant3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AICourant3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AICourant3.Location = New System.Drawing.Point(177, 352)
        Me.result4AICourant3.Name = "result4AICourant3"
        Me.result4AICourant3.Size = New System.Drawing.Size(33, 15)
        Me.result4AICourant3.TabIndex = 35
        Me.result4AICourant3.Text = "      "
        '
        'result4AICourant2
        '
        Me.result4AICourant2.AutoSize = True
        Me.result4AICourant2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AICourant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AICourant2.Location = New System.Drawing.Point(177, 329)
        Me.result4AICourant2.Name = "result4AICourant2"
        Me.result4AICourant2.Size = New System.Drawing.Size(33, 15)
        Me.result4AICourant2.TabIndex = 34
        Me.result4AICourant2.Text = "      "
        '
        'result4AICourant1
        '
        Me.result4AICourant1.AutoSize = True
        Me.result4AICourant1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AICourant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AICourant1.Location = New System.Drawing.Point(177, 300)
        Me.result4AICourant1.Name = "result4AICourant1"
        Me.result4AICourant1.Size = New System.Drawing.Size(33, 15)
        Me.result4AICourant1.TabIndex = 33
        Me.result4AICourant1.Text = "      "
        '
        'result4AITension4
        '
        Me.result4AITension4.AutoSize = True
        Me.result4AITension4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AITension4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AITension4.Location = New System.Drawing.Point(177, 251)
        Me.result4AITension4.Name = "result4AITension4"
        Me.result4AITension4.Size = New System.Drawing.Size(29, 15)
        Me.result4AITension4.TabIndex = 32
        Me.result4AITension4.Text = "     "
        '
        'result4AITension3
        '
        Me.result4AITension3.AutoSize = True
        Me.result4AITension3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AITension3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AITension3.Location = New System.Drawing.Point(177, 229)
        Me.result4AITension3.Name = "result4AITension3"
        Me.result4AITension3.Size = New System.Drawing.Size(29, 15)
        Me.result4AITension3.TabIndex = 31
        Me.result4AITension3.Text = "     "
        '
        'result4AITension2
        '
        Me.result4AITension2.AutoSize = True
        Me.result4AITension2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AITension2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AITension2.Location = New System.Drawing.Point(177, 206)
        Me.result4AITension2.Name = "result4AITension2"
        Me.result4AITension2.Size = New System.Drawing.Size(33, 15)
        Me.result4AITension2.TabIndex = 30
        Me.result4AITension2.Text = "      "
        '
        'result4AITension1
        '
        Me.result4AITension1.AutoSize = True
        Me.result4AITension1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.result4AITension1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result4AITension1.Location = New System.Drawing.Point(177, 182)
        Me.result4AITension1.Name = "result4AITension1"
        Me.result4AITension1.Size = New System.Drawing.Size(29, 15)
        Me.result4AITension1.TabIndex = 29
        Me.result4AITension1.Text = "     "
        '
        'resultat4AItemp4
        '
        Me.resultat4AItemp4.AutoSize = True
        Me.resultat4AItemp4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.resultat4AItemp4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultat4AItemp4.Location = New System.Drawing.Point(177, 122)
        Me.resultat4AItemp4.Name = "resultat4AItemp4"
        Me.resultat4AItemp4.Size = New System.Drawing.Size(25, 15)
        Me.resultat4AItemp4.TabIndex = 28
        Me.resultat4AItemp4.Text = "    "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(28, 523)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 13)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Voie 4"
        '
        'resultat4AItemp3
        '
        Me.resultat4AItemp3.AutoSize = True
        Me.resultat4AItemp3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.resultat4AItemp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultat4AItemp3.Location = New System.Drawing.Point(177, 91)
        Me.resultat4AItemp3.Name = "resultat4AItemp3"
        Me.resultat4AItemp3.Size = New System.Drawing.Size(25, 15)
        Me.resultat4AItemp3.TabIndex = 27
        Me.resultat4AItemp3.Text = "    "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(28, 493)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 13)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "Voie 3"
        '
        'resultat4AItemp2
        '
        Me.resultat4AItemp2.AutoSize = True
        Me.resultat4AItemp2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.resultat4AItemp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultat4AItemp2.Location = New System.Drawing.Point(177, 68)
        Me.resultat4AItemp2.Name = "resultat4AItemp2"
        Me.resultat4AItemp2.Size = New System.Drawing.Size(33, 15)
        Me.resultat4AItemp2.TabIndex = 26
        Me.resultat4AItemp2.Text = "      "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(28, 469)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(43, 13)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "Voie 2"
        '
        'resultat4AItemp1
        '
        Me.resultat4AItemp1.AutoSize = True
        Me.resultat4AItemp1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.resultat4AItemp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultat4AItemp1.Location = New System.Drawing.Point(177, 44)
        Me.resultat4AItemp1.Name = "resultat4AItemp1"
        Me.resultat4AItemp1.Size = New System.Drawing.Size(33, 15)
        Me.resultat4AItemp1.TabIndex = 25
        Me.resultat4AItemp1.Text = "      "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(28, 447)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 13)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Voie 1"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(7, 419)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 16)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "Resistance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Voie 4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 354)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Voie 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Voie 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Voie 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Voie 4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Voie 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Voie 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Voie 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Voie 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Voie 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Voie 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Voie 1"
        '
        'Btnresult
        '
        Me.Btnresult.Location = New System.Drawing.Point(342, 336)
        Me.Btnresult.Name = "Btnresult"
        Me.Btnresult.Size = New System.Drawing.Size(194, 28)
        Me.Btnresult.TabIndex = 4
        Me.Btnresult.Text = "Reccupération des résultats"
        Me.Btnresult.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Carte"
        '
        'Btnenregistrer
        '
        Me.Btnenregistrer.Location = New System.Drawing.Point(579, 336)
        Me.Btnenregistrer.Name = "Btnenregistrer"
        Me.Btnenregistrer.Size = New System.Drawing.Size(186, 28)
        Me.Btnenregistrer.TabIndex = 6
        Me.Btnenregistrer.Text = "Enregistrer les résultats"
        Me.Btnenregistrer.UseVisualStyleBackColor = True
        '
        'BtnRetourTests
        '
        Me.BtnRetourTests.Location = New System.Drawing.Point(342, 460)
        Me.BtnRetourTests.Name = "BtnRetourTests"
        Me.BtnRetourTests.Size = New System.Drawing.Size(193, 33)
        Me.BtnRetourTests.TabIndex = 7
        Me.BtnRetourTests.Text = "Retour au tests"
        Me.BtnRetourTests.UseVisualStyleBackColor = True
        '
        'Btnretourmenu
        '
        Me.Btnretourmenu.Location = New System.Drawing.Point(579, 460)
        Me.Btnretourmenu.Name = "Btnretourmenu"
        Me.Btnretourmenu.Size = New System.Drawing.Size(185, 32)
        Me.Btnretourmenu.TabIndex = 8
        Me.Btnretourmenu.Text = "Retour au menu"
        Me.Btnretourmenu.UseVisualStyleBackColor = True
        '
        'TimerTest
        '
        Me.TimerTest.Interval = 5000
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(662, 552)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(14, 13)
        Me.Label36.TabIndex = 9
        Me.Label36.Text = "v"
        '
        'Btnreconnexion
        '
        Me.Btnreconnexion.Location = New System.Drawing.Point(452, 398)
        Me.Btnreconnexion.Name = "Btnreconnexion"
        Me.Btnreconnexion.Size = New System.Drawing.Size(215, 29)
        Me.Btnreconnexion.TabIndex = 10
        Me.Btnreconnexion.Text = "Reconnexion avec le PSOC"
        Me.Btnreconnexion.UseVisualStyleBackColor = True
        '
        'formresultats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 574)
        Me.Controls.Add(Me.Btnreconnexion)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Btnretourmenu)
        Me.Controls.Add(Me.BtnRetourTests)
        Me.Controls.Add(Me.Btnenregistrer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btnresult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formresultats"
        Me.Text = "Résultats"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label4doNO As Label
    Friend WithEvents Label4doNF As Label
    Friend WithEvents Label4aocourant As Label
    Friend WithEvents Label4aotension As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label4aitemp As Label
    Friend WithEvents Label4aitension As Label
    Friend WithEvents Label4ai As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents resultat4AItemp4 As Label
    Friend WithEvents resultat4AItemp3 As Label
    Friend WithEvents resultat4AItemp2 As Label
    Friend WithEvents resultat4AItemp1 As Label
    Friend WithEvents result4AITension4 As Label
    Friend WithEvents result4AITension3 As Label
    Friend WithEvents result4AITension2 As Label
    Friend WithEvents result4AITension1 As Label
    Friend WithEvents result4AICourant4 As Label
    Friend WithEvents result4AICourant3 As Label
    Friend WithEvents result4AICourant2 As Label
    Friend WithEvents result4AICourant1 As Label
    Friend WithEvents result4DOCourant4 As Label
    Friend WithEvents result4DOTension4 As Label
    Friend WithEvents result4DOCourant3 As Label
    Friend WithEvents result4DOCourant2 As Label
    Friend WithEvents result4DOTension3 As Label
    Friend WithEvents result4DOCourant1 As Label
    Friend WithEvents result4DOTension2 As Label
    Friend WithEvents result4DOTension1 As Label
    Friend WithEvents result4AOCourant4 As Label
    Friend WithEvents result4AOTension4 As Label
    Friend WithEvents result4AOCourant3 As Label
    Friend WithEvents result4AOCourant2 As Label
    Friend WithEvents result4AOTension3 As Label
    Friend WithEvents result4AOCourant1 As Label
    Friend WithEvents result4AOTension2 As Label
    Friend WithEvents result4AOTension1 As Label
    Friend WithEvents result4AIRES4 As Label
    Friend WithEvents result4AIRES3 As Label
    Friend WithEvents result4AIRES2 As Label
    Friend WithEvents result4AIRES1 As Label
    Friend WithEvents Btnresult As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnenregistrer As Button
    Friend WithEvents BtnRetourTests As Button
    Friend WithEvents Btnretourmenu As Button
    Friend WithEvents TimerTest As Timer
    Friend WithEvents Label36 As Label
    Friend WithEvents Btnreconnexion As Button
End Class

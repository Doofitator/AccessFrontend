﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.grp_connect = New System.Windows.Forms.GroupBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.lbl_hint1 = New System.Windows.Forms.Label()
        Me.txt_filename = New System.Windows.Forms.TextBox()
        Me.btn_openOFD = New System.Windows.Forms.Button()
        Me.grp_control = New System.Windows.Forms.GroupBox()
        Me.tab_controls = New System.Windows.Forms.TabControl()
        Me.tpg_read = New System.Windows.Forms.TabPage()
        Me.cbx_osType = New System.Windows.Forms.ComboBox()
        Me.lbl_osType = New System.Windows.Forms.Label()
        Me.cbx_osFormat = New System.Windows.Forms.ComboBox()
        Me.lbl_osFormat = New System.Windows.Forms.Label()
        Me.lbl_resultsHint = New System.Windows.Forms.Label()
        Me.tab_results = New System.Windows.Forms.TabControl()
        Me.tpg_Features = New System.Windows.Forms.TabPage()
        Me.txt_Features = New System.Windows.Forms.TextBox()
        Me.tpg_Notes = New System.Windows.Forms.TabPage()
        Me.txt_Notes = New System.Windows.Forms.TextBox()
        Me.cbx_osSize = New System.Windows.Forms.ComboBox()
        Me.lbl_osSize = New System.Windows.Forms.Label()
        Me.cbx_osName = New System.Windows.Forms.ComboBox()
        Me.lbl_osName = New System.Windows.Forms.Label()
        Me.cbx_osBuild = New System.Windows.Forms.ComboBox()
        Me.lbl_osBuild = New System.Windows.Forms.Label()
        Me.cbx_osVersion = New System.Windows.Forms.ComboBox()
        Me.lbl_osVersion = New System.Windows.Forms.Label()
        Me.cbx_osBoot = New System.Windows.Forms.ComboBox()
        Me.lbl_osBoot = New System.Windows.Forms.Label()
        Me.cbx_osRAM = New System.Windows.Forms.ComboBox()
        Me.lbl_osRAM = New System.Windows.Forms.Label()
        Me.cbx_osPlatform = New System.Windows.Forms.ComboBox()
        Me.lbl_osPlatform = New System.Windows.Forms.Label()
        Me.cbx_osEdition = New System.Windows.Forms.ComboBox()
        Me.lbl_osEdition = New System.Windows.Forms.Label()
        Me.cbx_osVariant = New System.Windows.Forms.ComboBox()
        Me.lbl_osVariant = New System.Windows.Forms.Label()
        Me.cbx_osParent = New System.Windows.Forms.ComboBox()
        Me.lbl_osParent = New System.Windows.Forms.Label()
        Me.lbl_searchHint = New System.Windows.Forms.Label()
        Me.tpg_edit = New System.Windows.Forms.TabPage()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ofd_database = New System.Windows.Forms.OpenFileDialog()
        Me.tbg_specs = New System.Windows.Forms.TabPage()
        Me.grp_connect.SuspendLayout()
        Me.grp_control.SuspendLayout()
        Me.tab_controls.SuspendLayout()
        Me.tpg_read.SuspendLayout()
        Me.tab_results.SuspendLayout()
        Me.tpg_Features.SuspendLayout()
        Me.tpg_Notes.SuspendLayout()
        Me.tpg_edit.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_connect
        '
        Me.grp_connect.BackColor = System.Drawing.SystemColors.Control
        Me.grp_connect.Controls.Add(Me.btn_connect)
        Me.grp_connect.Controls.Add(Me.lbl_hint1)
        Me.grp_connect.Controls.Add(Me.txt_filename)
        Me.grp_connect.Controls.Add(Me.btn_openOFD)
        Me.grp_connect.Location = New System.Drawing.Point(13, 13)
        Me.grp_connect.Name = "grp_connect"
        Me.grp_connect.Size = New System.Drawing.Size(826, 81)
        Me.grp_connect.TabIndex = 0
        Me.grp_connect.TabStop = False
        Me.grp_connect.Text = "Connection"
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(745, 51)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(75, 23)
        Me.btn_connect.TabIndex = 3
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'lbl_hint1
        '
        Me.lbl_hint1.AutoSize = True
        Me.lbl_hint1.Location = New System.Drawing.Point(7, 26)
        Me.lbl_hint1.Name = "lbl_hint1"
        Me.lbl_hint1.Size = New System.Drawing.Size(75, 13)
        Me.lbl_hint1.TabIndex = 2
        Me.lbl_hint1.Text = "Database File:"
        '
        'txt_filename
        '
        Me.txt_filename.Location = New System.Drawing.Point(85, 23)
        Me.txt_filename.Name = "txt_filename"
        Me.txt_filename.Size = New System.Drawing.Size(654, 20)
        Me.txt_filename.TabIndex = 1
        '
        'btn_openOFD
        '
        Me.btn_openOFD.Location = New System.Drawing.Point(745, 21)
        Me.btn_openOFD.Name = "btn_openOFD"
        Me.btn_openOFD.Size = New System.Drawing.Size(75, 23)
        Me.btn_openOFD.TabIndex = 0
        Me.btn_openOFD.Text = "Browse"
        Me.btn_openOFD.UseVisualStyleBackColor = True
        '
        'grp_control
        '
        Me.grp_control.BackColor = System.Drawing.SystemColors.Control
        Me.grp_control.Controls.Add(Me.tab_controls)
        Me.grp_control.Enabled = False
        Me.grp_control.Location = New System.Drawing.Point(13, 101)
        Me.grp_control.Name = "grp_control"
        Me.grp_control.Size = New System.Drawing.Size(826, 242)
        Me.grp_control.TabIndex = 1
        Me.grp_control.TabStop = False
        Me.grp_control.Text = "Database Controls"
        '
        'tab_controls
        '
        Me.tab_controls.Controls.Add(Me.tpg_read)
        Me.tab_controls.Controls.Add(Me.tpg_edit)
        Me.tab_controls.Enabled = False
        Me.tab_controls.Location = New System.Drawing.Point(10, 19)
        Me.tab_controls.Name = "tab_controls"
        Me.tab_controls.SelectedIndex = 0
        Me.tab_controls.Size = New System.Drawing.Size(810, 217)
        Me.tab_controls.TabIndex = 0
        '
        'tpg_read
        '
        Me.tpg_read.Controls.Add(Me.cbx_osType)
        Me.tpg_read.Controls.Add(Me.lbl_osType)
        Me.tpg_read.Controls.Add(Me.cbx_osFormat)
        Me.tpg_read.Controls.Add(Me.lbl_osFormat)
        Me.tpg_read.Controls.Add(Me.lbl_resultsHint)
        Me.tpg_read.Controls.Add(Me.tab_results)
        Me.tpg_read.Controls.Add(Me.cbx_osSize)
        Me.tpg_read.Controls.Add(Me.lbl_osSize)
        Me.tpg_read.Controls.Add(Me.cbx_osName)
        Me.tpg_read.Controls.Add(Me.lbl_osName)
        Me.tpg_read.Controls.Add(Me.cbx_osBuild)
        Me.tpg_read.Controls.Add(Me.lbl_osBuild)
        Me.tpg_read.Controls.Add(Me.cbx_osVersion)
        Me.tpg_read.Controls.Add(Me.lbl_osVersion)
        Me.tpg_read.Controls.Add(Me.cbx_osBoot)
        Me.tpg_read.Controls.Add(Me.lbl_osBoot)
        Me.tpg_read.Controls.Add(Me.cbx_osRAM)
        Me.tpg_read.Controls.Add(Me.lbl_osRAM)
        Me.tpg_read.Controls.Add(Me.cbx_osPlatform)
        Me.tpg_read.Controls.Add(Me.lbl_osPlatform)
        Me.tpg_read.Controls.Add(Me.cbx_osEdition)
        Me.tpg_read.Controls.Add(Me.lbl_osEdition)
        Me.tpg_read.Controls.Add(Me.cbx_osVariant)
        Me.tpg_read.Controls.Add(Me.lbl_osVariant)
        Me.tpg_read.Controls.Add(Me.cbx_osParent)
        Me.tpg_read.Controls.Add(Me.lbl_osParent)
        Me.tpg_read.Controls.Add(Me.lbl_searchHint)
        Me.tpg_read.Location = New System.Drawing.Point(4, 22)
        Me.tpg_read.Name = "tpg_read"
        Me.tpg_read.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_read.Size = New System.Drawing.Size(802, 191)
        Me.tpg_read.TabIndex = 0
        Me.tpg_read.Text = "Read"
        Me.tpg_read.UseVisualStyleBackColor = True
        '
        'cbx_osType
        '
        Me.cbx_osType.FormattingEnabled = True
        Me.cbx_osType.Location = New System.Drawing.Point(422, 38)
        Me.cbx_osType.Name = "cbx_osType"
        Me.cbx_osType.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osType.TabIndex = 26
        '
        'lbl_osType
        '
        Me.lbl_osType.AutoSize = True
        Me.lbl_osType.Location = New System.Drawing.Point(375, 41)
        Me.lbl_osType.Name = "lbl_osType"
        Me.lbl_osType.Size = New System.Drawing.Size(34, 13)
        Me.lbl_osType.TabIndex = 25
        Me.lbl_osType.Text = "Type:"
        '
        'cbx_osFormat
        '
        Me.cbx_osFormat.FormattingEnabled = True
        Me.cbx_osFormat.Location = New System.Drawing.Point(240, 154)
        Me.cbx_osFormat.Name = "cbx_osFormat"
        Me.cbx_osFormat.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osFormat.TabIndex = 24
        '
        'lbl_osFormat
        '
        Me.lbl_osFormat.AutoSize = True
        Me.lbl_osFormat.Location = New System.Drawing.Point(193, 157)
        Me.lbl_osFormat.Name = "lbl_osFormat"
        Me.lbl_osFormat.Size = New System.Drawing.Size(42, 13)
        Me.lbl_osFormat.TabIndex = 23
        Me.lbl_osFormat.Text = "Format:"
        '
        'lbl_resultsHint
        '
        Me.lbl_resultsHint.AutoSize = True
        Me.lbl_resultsHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultsHint.Location = New System.Drawing.Point(551, 7)
        Me.lbl_resultsHint.Name = "lbl_resultsHint"
        Me.lbl_resultsHint.Size = New System.Drawing.Size(53, 13)
        Me.lbl_resultsHint.TabIndex = 22
        Me.lbl_resultsHint.Text = "Results:"
        '
        'tab_results
        '
        Me.tab_results.Controls.Add(Me.tbg_specs)
        Me.tab_results.Controls.Add(Me.tpg_Features)
        Me.tab_results.Controls.Add(Me.tpg_Notes)
        Me.tab_results.Enabled = False
        Me.tab_results.Location = New System.Drawing.Point(551, 38)
        Me.tab_results.Name = "tab_results"
        Me.tab_results.SelectedIndex = 0
        Me.tab_results.Size = New System.Drawing.Size(241, 137)
        Me.tab_results.TabIndex = 21
        '
        'tpg_Features
        '
        Me.tpg_Features.Controls.Add(Me.txt_Features)
        Me.tpg_Features.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Features.Name = "tpg_Features"
        Me.tpg_Features.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_Features.Size = New System.Drawing.Size(233, 111)
        Me.tpg_Features.TabIndex = 0
        Me.tpg_Features.Text = "Features"
        Me.tpg_Features.UseVisualStyleBackColor = True
        '
        'txt_Features
        '
        Me.txt_Features.Location = New System.Drawing.Point(7, 7)
        Me.txt_Features.Multiline = True
        Me.txt_Features.Name = "txt_Features"
        Me.txt_Features.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Features.Size = New System.Drawing.Size(220, 98)
        Me.txt_Features.TabIndex = 0
        '
        'tpg_Notes
        '
        Me.tpg_Notes.Controls.Add(Me.txt_Notes)
        Me.tpg_Notes.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Notes.Name = "tpg_Notes"
        Me.tpg_Notes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_Notes.Size = New System.Drawing.Size(233, 111)
        Me.tpg_Notes.TabIndex = 1
        Me.tpg_Notes.Text = "Install Notes"
        Me.tpg_Notes.UseVisualStyleBackColor = True
        '
        'txt_Notes
        '
        Me.txt_Notes.Location = New System.Drawing.Point(7, 7)
        Me.txt_Notes.Multiline = True
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Notes.Size = New System.Drawing.Size(220, 98)
        Me.txt_Notes.TabIndex = 1
        '
        'cbx_osSize
        '
        Me.cbx_osSize.FormattingEnabled = True
        Me.cbx_osSize.Location = New System.Drawing.Point(240, 125)
        Me.cbx_osSize.Name = "cbx_osSize"
        Me.cbx_osSize.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osSize.TabIndex = 20
        '
        'lbl_osSize
        '
        Me.lbl_osSize.AutoSize = True
        Me.lbl_osSize.Location = New System.Drawing.Point(193, 128)
        Me.lbl_osSize.Name = "lbl_osSize"
        Me.lbl_osSize.Size = New System.Drawing.Size(30, 13)
        Me.lbl_osSize.TabIndex = 19
        Me.lbl_osSize.Text = "Size:"
        '
        'cbx_osName
        '
        Me.cbx_osName.FormattingEnabled = True
        Me.cbx_osName.Location = New System.Drawing.Point(422, 154)
        Me.cbx_osName.Name = "cbx_osName"
        Me.cbx_osName.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osName.TabIndex = 18
        '
        'lbl_osName
        '
        Me.lbl_osName.AutoSize = True
        Me.lbl_osName.Location = New System.Drawing.Point(375, 157)
        Me.lbl_osName.Name = "lbl_osName"
        Me.lbl_osName.Size = New System.Drawing.Size(38, 13)
        Me.lbl_osName.TabIndex = 17
        Me.lbl_osName.Text = "Name:"
        '
        'cbx_osBuild
        '
        Me.cbx_osBuild.FormattingEnabled = True
        Me.cbx_osBuild.Location = New System.Drawing.Point(240, 96)
        Me.cbx_osBuild.Name = "cbx_osBuild"
        Me.cbx_osBuild.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osBuild.TabIndex = 16
        '
        'lbl_osBuild
        '
        Me.lbl_osBuild.AutoSize = True
        Me.lbl_osBuild.Location = New System.Drawing.Point(193, 99)
        Me.lbl_osBuild.Name = "lbl_osBuild"
        Me.lbl_osBuild.Size = New System.Drawing.Size(33, 13)
        Me.lbl_osBuild.TabIndex = 15
        Me.lbl_osBuild.Text = "Build:"
        '
        'cbx_osVersion
        '
        Me.cbx_osVersion.FormattingEnabled = True
        Me.cbx_osVersion.Location = New System.Drawing.Point(240, 67)
        Me.cbx_osVersion.Name = "cbx_osVersion"
        Me.cbx_osVersion.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osVersion.TabIndex = 14
        '
        'lbl_osVersion
        '
        Me.lbl_osVersion.AutoSize = True
        Me.lbl_osVersion.Location = New System.Drawing.Point(193, 70)
        Me.lbl_osVersion.Name = "lbl_osVersion"
        Me.lbl_osVersion.Size = New System.Drawing.Size(45, 13)
        Me.lbl_osVersion.TabIndex = 13
        Me.lbl_osVersion.Text = "Version:"
        '
        'cbx_osBoot
        '
        Me.cbx_osBoot.FormattingEnabled = True
        Me.cbx_osBoot.Location = New System.Drawing.Point(240, 38)
        Me.cbx_osBoot.Name = "cbx_osBoot"
        Me.cbx_osBoot.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osBoot.TabIndex = 12
        '
        'lbl_osBoot
        '
        Me.lbl_osBoot.AutoSize = True
        Me.lbl_osBoot.Location = New System.Drawing.Point(193, 41)
        Me.lbl_osBoot.Name = "lbl_osBoot"
        Me.lbl_osBoot.Size = New System.Drawing.Size(32, 13)
        Me.lbl_osBoot.TabIndex = 11
        Me.lbl_osBoot.Text = "Boot:"
        '
        'cbx_osRAM
        '
        Me.cbx_osRAM.FormattingEnabled = True
        Me.cbx_osRAM.Location = New System.Drawing.Point(58, 154)
        Me.cbx_osRAM.Name = "cbx_osRAM"
        Me.cbx_osRAM.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osRAM.TabIndex = 10
        '
        'lbl_osRAM
        '
        Me.lbl_osRAM.AutoSize = True
        Me.lbl_osRAM.Location = New System.Drawing.Point(11, 157)
        Me.lbl_osRAM.Name = "lbl_osRAM"
        Me.lbl_osRAM.Size = New System.Drawing.Size(47, 13)
        Me.lbl_osRAM.TabIndex = 9
        Me.lbl_osRAM.Text = "Memory:"
        '
        'cbx_osPlatform
        '
        Me.cbx_osPlatform.FormattingEnabled = True
        Me.cbx_osPlatform.Location = New System.Drawing.Point(58, 125)
        Me.cbx_osPlatform.Name = "cbx_osPlatform"
        Me.cbx_osPlatform.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osPlatform.TabIndex = 8
        '
        'lbl_osPlatform
        '
        Me.lbl_osPlatform.AutoSize = True
        Me.lbl_osPlatform.Location = New System.Drawing.Point(11, 128)
        Me.lbl_osPlatform.Name = "lbl_osPlatform"
        Me.lbl_osPlatform.Size = New System.Drawing.Size(48, 13)
        Me.lbl_osPlatform.TabIndex = 7
        Me.lbl_osPlatform.Text = "Platform:"
        '
        'cbx_osEdition
        '
        Me.cbx_osEdition.FormattingEnabled = True
        Me.cbx_osEdition.Location = New System.Drawing.Point(58, 96)
        Me.cbx_osEdition.Name = "cbx_osEdition"
        Me.cbx_osEdition.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osEdition.TabIndex = 6
        '
        'lbl_osEdition
        '
        Me.lbl_osEdition.AutoSize = True
        Me.lbl_osEdition.Location = New System.Drawing.Point(11, 99)
        Me.lbl_osEdition.Name = "lbl_osEdition"
        Me.lbl_osEdition.Size = New System.Drawing.Size(42, 13)
        Me.lbl_osEdition.TabIndex = 5
        Me.lbl_osEdition.Text = "Edition:"
        '
        'cbx_osVariant
        '
        Me.cbx_osVariant.FormattingEnabled = True
        Me.cbx_osVariant.Location = New System.Drawing.Point(58, 67)
        Me.cbx_osVariant.Name = "cbx_osVariant"
        Me.cbx_osVariant.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osVariant.TabIndex = 4
        '
        'lbl_osVariant
        '
        Me.lbl_osVariant.AutoSize = True
        Me.lbl_osVariant.Location = New System.Drawing.Point(11, 70)
        Me.lbl_osVariant.Name = "lbl_osVariant"
        Me.lbl_osVariant.Size = New System.Drawing.Size(43, 13)
        Me.lbl_osVariant.TabIndex = 3
        Me.lbl_osVariant.Text = "Variant:"
        '
        'cbx_osParent
        '
        Me.cbx_osParent.FormattingEnabled = True
        Me.cbx_osParent.Location = New System.Drawing.Point(58, 38)
        Me.cbx_osParent.Name = "cbx_osParent"
        Me.cbx_osParent.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osParent.TabIndex = 2
        '
        'lbl_osParent
        '
        Me.lbl_osParent.AutoSize = True
        Me.lbl_osParent.Location = New System.Drawing.Point(11, 41)
        Me.lbl_osParent.Name = "lbl_osParent"
        Me.lbl_osParent.Size = New System.Drawing.Size(41, 13)
        Me.lbl_osParent.TabIndex = 1
        Me.lbl_osParent.Text = "Parent:"
        '
        'lbl_searchHint
        '
        Me.lbl_searchHint.AutoSize = True
        Me.lbl_searchHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchHint.Location = New System.Drawing.Point(7, 7)
        Me.lbl_searchHint.Name = "lbl_searchHint"
        Me.lbl_searchHint.Size = New System.Drawing.Size(89, 13)
        Me.lbl_searchHint.TabIndex = 0
        Me.lbl_searchHint.Text = "Search Terms:"
        '
        'tpg_edit
        '
        Me.tpg_edit.Controls.Add(Me.btn_Save)
        Me.tpg_edit.Controls.Add(Me.ComboBox1)
        Me.tpg_edit.Controls.Add(Me.Label1)
        Me.tpg_edit.Controls.Add(Me.ComboBox2)
        Me.tpg_edit.Controls.Add(Me.Label2)
        Me.tpg_edit.Controls.Add(Me.TabControl1)
        Me.tpg_edit.Controls.Add(Me.ComboBox3)
        Me.tpg_edit.Controls.Add(Me.Label3)
        Me.tpg_edit.Controls.Add(Me.ComboBox4)
        Me.tpg_edit.Controls.Add(Me.Label4)
        Me.tpg_edit.Controls.Add(Me.ComboBox5)
        Me.tpg_edit.Controls.Add(Me.Label5)
        Me.tpg_edit.Controls.Add(Me.ComboBox6)
        Me.tpg_edit.Controls.Add(Me.Label6)
        Me.tpg_edit.Controls.Add(Me.ComboBox7)
        Me.tpg_edit.Controls.Add(Me.Label7)
        Me.tpg_edit.Controls.Add(Me.ComboBox8)
        Me.tpg_edit.Controls.Add(Me.Label8)
        Me.tpg_edit.Controls.Add(Me.ComboBox9)
        Me.tpg_edit.Controls.Add(Me.Label9)
        Me.tpg_edit.Controls.Add(Me.ComboBox10)
        Me.tpg_edit.Controls.Add(Me.Label11)
        Me.tpg_edit.Controls.Add(Me.ComboBox11)
        Me.tpg_edit.Controls.Add(Me.Label12)
        Me.tpg_edit.Controls.Add(Me.ComboBox12)
        Me.tpg_edit.Controls.Add(Me.Label13)
        Me.tpg_edit.Location = New System.Drawing.Point(4, 22)
        Me.tpg_edit.Name = "tpg_edit"
        Me.tpg_edit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_edit.Size = New System.Drawing.Size(802, 191)
        Me.tpg_edit.TabIndex = 1
        Me.tpg_edit.Text = "Edit"
        Me.tpg_edit.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(722, 160)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 52
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(247, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Type:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(247, 128)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Format:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(374, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(423, 137)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(415, 111)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Features"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 7)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(402, 98)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(415, 111)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Install Notes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 7)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(402, 98)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(247, 99)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Size:"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(58, 99)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Name:"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(247, 70)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Build:"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(247, 41)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Version:"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(247, 12)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox7.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Boot:"
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(58, 154)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox8.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Memory:"
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(58, 125)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox9.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Platform:"
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(58, 70)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox10.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Edition:"
        '
        'ComboBox11
        '
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Location = New System.Drawing.Point(58, 41)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox11.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Variant:"
        '
        'ComboBox12
        '
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(58, 12)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox12.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Parent:"
        '
        'ofd_database
        '
        Me.ofd_database.Filter = "Access Database file|*.accdb"
        '
        'tbg_specs
        '
        Me.tbg_specs.Location = New System.Drawing.Point(4, 22)
        Me.tbg_specs.Name = "tbg_specs"
        Me.tbg_specs.Size = New System.Drawing.Size(233, 111)
        Me.tbg_specs.TabIndex = 2
        Me.tbg_specs.Text = "Specifications"
        Me.tbg_specs.UseVisualStyleBackColor = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 355)
        Me.Controls.Add(Me.grp_control)
        Me.Controls.Add(Me.grp_connect)
        Me.Name = "frm_main"
        Me.Text = "Operating System Database Frontend"
        Me.grp_connect.ResumeLayout(False)
        Me.grp_connect.PerformLayout()
        Me.grp_control.ResumeLayout(False)
        Me.tab_controls.ResumeLayout(False)
        Me.tpg_read.ResumeLayout(False)
        Me.tpg_read.PerformLayout()
        Me.tab_results.ResumeLayout(False)
        Me.tpg_Features.ResumeLayout(False)
        Me.tpg_Features.PerformLayout()
        Me.tpg_Notes.ResumeLayout(False)
        Me.tpg_Notes.PerformLayout()
        Me.tpg_edit.ResumeLayout(False)
        Me.tpg_edit.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_connect As GroupBox
    Friend WithEvents grp_control As GroupBox
    Friend WithEvents ofd_database As OpenFileDialog
    Friend WithEvents btn_connect As Button
    Friend WithEvents lbl_hint1 As Label
    Friend WithEvents txt_filename As TextBox
    Friend WithEvents btn_openOFD As Button
    Friend WithEvents tab_controls As TabControl
    Friend WithEvents tpg_read As TabPage
    Friend WithEvents tpg_edit As TabPage
    Friend WithEvents cbx_osParent As ComboBox
    Friend WithEvents lbl_osParent As Label
    Friend WithEvents lbl_searchHint As Label
    Friend WithEvents cbx_osType As ComboBox
    Friend WithEvents lbl_osType As Label
    Friend WithEvents cbx_osFormat As ComboBox
    Friend WithEvents lbl_osFormat As Label
    Friend WithEvents lbl_resultsHint As Label
    Friend WithEvents tab_results As TabControl
    Friend WithEvents tpg_Features As TabPage
    Friend WithEvents txt_Features As TextBox
    Friend WithEvents tpg_Notes As TabPage
    Friend WithEvents txt_Notes As TextBox
    Friend WithEvents cbx_osSize As ComboBox
    Friend WithEvents lbl_osSize As Label
    Friend WithEvents cbx_osName As ComboBox
    Friend WithEvents lbl_osName As Label
    Friend WithEvents cbx_osBuild As ComboBox
    Friend WithEvents lbl_osBuild As Label
    Friend WithEvents cbx_osVersion As ComboBox
    Friend WithEvents lbl_osVersion As Label
    Friend WithEvents cbx_osBoot As ComboBox
    Friend WithEvents lbl_osBoot As Label
    Friend WithEvents cbx_osRAM As ComboBox
    Friend WithEvents lbl_osRAM As Label
    Friend WithEvents cbx_osPlatform As ComboBox
    Friend WithEvents lbl_osPlatform As Label
    Friend WithEvents cbx_osEdition As ComboBox
    Friend WithEvents lbl_osEdition As Label
    Friend WithEvents cbx_osVariant As ComboBox
    Friend WithEvents lbl_osVariant As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents tbg_specs As TabPage
End Class

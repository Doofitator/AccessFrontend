<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grp_connect = New System.Windows.Forms.GroupBox()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.lbl_hint1 = New System.Windows.Forms.Label()
        Me.txt_filename = New System.Windows.Forms.TextBox()
        Me.btn_openOFD = New System.Windows.Forms.Button()
        Me.grp_control = New System.Windows.Forms.GroupBox()
        Me.tab_controls = New System.Windows.Forms.TabControl()
        Me.tpg_read = New System.Windows.Forms.TabPage()
        Me.cbx_osFileName = New System.Windows.Forms.ComboBox()
        Me.lbl_osfilename = New System.Windows.Forms.Label()
        Me.cbx_osType = New System.Windows.Forms.ComboBox()
        Me.lbl_osType = New System.Windows.Forms.Label()
        Me.cbx_osFormat = New System.Windows.Forms.ComboBox()
        Me.lbl_osFormat = New System.Windows.Forms.Label()
        Me.lbl_resultsHint = New System.Windows.Forms.Label()
        Me.tab_results = New System.Windows.Forms.TabControl()
        Me.tpg_specs = New System.Windows.Forms.TabPage()
        Me.txt_specs = New System.Windows.Forms.TextBox()
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
        Me.cbx_osTypeEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osTypeEdit = New System.Windows.Forms.Label()
        Me.cbx_osFormatEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osFormatEdit = New System.Windows.Forms.Label()
        Me.tab_ExtrasEdit = New System.Windows.Forms.TabControl()
        Me.tpg_instructionsEdit = New System.Windows.Forms.TabPage()
        Me.lbl_dragDrop = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_instruct1 = New System.Windows.Forms.Label()
        Me.tpg_FeaturesEdit = New System.Windows.Forms.TabPage()
        Me.txt_FeaturesEdit = New System.Windows.Forms.TextBox()
        Me.tpg_notesEdit = New System.Windows.Forms.TabPage()
        Me.txt_NotesEdit = New System.Windows.Forms.TextBox()
        Me.cbx_osSizeEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osSizeEdit = New System.Windows.Forms.Label()
        Me.cbx_osNameEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osNameEdit = New System.Windows.Forms.Label()
        Me.cbx_osBuildEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osBuildEdit = New System.Windows.Forms.Label()
        Me.cbx_osVersionEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osVersionEdit = New System.Windows.Forms.Label()
        Me.cbx_osBootEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osBootEdit = New System.Windows.Forms.Label()
        Me.cbx_osRamEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osRamEdit = New System.Windows.Forms.Label()
        Me.cbx_osPlatformEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osPlatformEdit = New System.Windows.Forms.Label()
        Me.cbx_osEditionEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osEditionEdit = New System.Windows.Forms.Label()
        Me.cbx_osVariantEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osVariantEdit = New System.Windows.Forms.Label()
        Me.cbx_osParentEdit = New System.Windows.Forms.ComboBox()
        Me.lbl_osParentEdit = New System.Windows.Forms.Label()
        Me.ofd_database = New System.Windows.Forms.OpenFileDialog()
        Me.strp_connectionStatus = New System.Windows.Forms.StatusStrip()
        Me.tssl_databaseStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grp_connect.SuspendLayout()
        Me.grp_control.SuspendLayout()
        Me.tab_controls.SuspendLayout()
        Me.tpg_read.SuspendLayout()
        Me.tab_results.SuspendLayout()
        Me.tpg_specs.SuspendLayout()
        Me.tpg_Features.SuspendLayout()
        Me.tpg_Notes.SuspendLayout()
        Me.tpg_edit.SuspendLayout()
        Me.tab_ExtrasEdit.SuspendLayout()
        Me.tpg_instructionsEdit.SuspendLayout()
        Me.tpg_FeaturesEdit.SuspendLayout()
        Me.tpg_notesEdit.SuspendLayout()
        Me.strp_connectionStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_connect
        '
        Me.grp_connect.BackColor = System.Drawing.SystemColors.Control
        Me.grp_connect.Controls.Add(Me.btn_disconnect)
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
        'btn_disconnect
        '
        Me.btn_disconnect.Enabled = False
        Me.btn_disconnect.Location = New System.Drawing.Point(664, 51)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(75, 23)
        Me.btn_disconnect.TabIndex = 4
        Me.btn_disconnect.Text = "Disconnect"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'btn_connect
        '
        Me.btn_connect.Enabled = False
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
        Me.tpg_read.Controls.Add(Me.cbx_osFileName)
        Me.tpg_read.Controls.Add(Me.lbl_osfilename)
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
        'cbx_osFileName
        '
        Me.cbx_osFileName.FormattingEnabled = True
        Me.cbx_osFileName.Location = New System.Drawing.Point(422, 67)
        Me.cbx_osFileName.Name = "cbx_osFileName"
        Me.cbx_osFileName.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osFileName.TabIndex = 28
        '
        'lbl_osfilename
        '
        Me.lbl_osfilename.AutoSize = True
        Me.lbl_osfilename.Location = New System.Drawing.Point(373, 70)
        Me.lbl_osfilename.Name = "lbl_osfilename"
        Me.lbl_osfilename.Size = New System.Drawing.Size(52, 13)
        Me.lbl_osfilename.TabIndex = 27
        Me.lbl_osfilename.Text = "Filename:"
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
        Me.lbl_osType.Location = New System.Drawing.Point(373, 41)
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
        Me.tab_results.Controls.Add(Me.tpg_specs)
        Me.tab_results.Controls.Add(Me.tpg_Features)
        Me.tab_results.Controls.Add(Me.tpg_Notes)
        Me.tab_results.Enabled = False
        Me.tab_results.Location = New System.Drawing.Point(551, 38)
        Me.tab_results.Name = "tab_results"
        Me.tab_results.SelectedIndex = 0
        Me.tab_results.Size = New System.Drawing.Size(241, 137)
        Me.tab_results.TabIndex = 21
        '
        'tpg_specs
        '
        Me.tpg_specs.Controls.Add(Me.txt_specs)
        Me.tpg_specs.Location = New System.Drawing.Point(4, 22)
        Me.tpg_specs.Name = "tpg_specs"
        Me.tpg_specs.Size = New System.Drawing.Size(233, 111)
        Me.tpg_specs.TabIndex = 2
        Me.tpg_specs.Text = "Specifications"
        Me.tpg_specs.UseVisualStyleBackColor = True
        '
        'txt_specs
        '
        Me.txt_specs.Location = New System.Drawing.Point(7, 7)
        Me.txt_specs.Multiline = True
        Me.txt_specs.Name = "txt_specs"
        Me.txt_specs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_specs.Size = New System.Drawing.Size(220, 98)
        Me.txt_specs.TabIndex = 1
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
        Me.tpg_edit.AllowDrop = True
        Me.tpg_edit.Controls.Add(Me.btn_Save)
        Me.tpg_edit.Controls.Add(Me.cbx_osTypeEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osTypeEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osFormatEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osFormatEdit)
        Me.tpg_edit.Controls.Add(Me.tab_ExtrasEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osSizeEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osSizeEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osNameEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osNameEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osBuildEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osBuildEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osVersionEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osVersionEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osBootEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osBootEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osRamEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osRamEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osPlatformEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osPlatformEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osEditionEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osEditionEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osVariantEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osVariantEdit)
        Me.tpg_edit.Controls.Add(Me.cbx_osParentEdit)
        Me.tpg_edit.Controls.Add(Me.lbl_osParentEdit)
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
        'cbx_osTypeEdit
        '
        Me.cbx_osTypeEdit.FormattingEnabled = True
        Me.cbx_osTypeEdit.Location = New System.Drawing.Point(247, 157)
        Me.cbx_osTypeEdit.Name = "cbx_osTypeEdit"
        Me.cbx_osTypeEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osTypeEdit.TabIndex = 51
        '
        'lbl_osTypeEdit
        '
        Me.lbl_osTypeEdit.AutoSize = True
        Me.lbl_osTypeEdit.Location = New System.Drawing.Point(200, 160)
        Me.lbl_osTypeEdit.Name = "lbl_osTypeEdit"
        Me.lbl_osTypeEdit.Size = New System.Drawing.Size(34, 13)
        Me.lbl_osTypeEdit.TabIndex = 50
        Me.lbl_osTypeEdit.Text = "Type:"
        '
        'cbx_osFormatEdit
        '
        Me.cbx_osFormatEdit.FormattingEnabled = True
        Me.cbx_osFormatEdit.Location = New System.Drawing.Point(247, 128)
        Me.cbx_osFormatEdit.Name = "cbx_osFormatEdit"
        Me.cbx_osFormatEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osFormatEdit.TabIndex = 49
        '
        'lbl_osFormatEdit
        '
        Me.lbl_osFormatEdit.AutoSize = True
        Me.lbl_osFormatEdit.Location = New System.Drawing.Point(200, 131)
        Me.lbl_osFormatEdit.Name = "lbl_osFormatEdit"
        Me.lbl_osFormatEdit.Size = New System.Drawing.Size(42, 13)
        Me.lbl_osFormatEdit.TabIndex = 48
        Me.lbl_osFormatEdit.Text = "Format:"
        '
        'tab_ExtrasEdit
        '
        Me.tab_ExtrasEdit.Controls.Add(Me.tpg_instructionsEdit)
        Me.tab_ExtrasEdit.Controls.Add(Me.tpg_FeaturesEdit)
        Me.tab_ExtrasEdit.Controls.Add(Me.tpg_notesEdit)
        Me.tab_ExtrasEdit.Location = New System.Drawing.Point(374, 12)
        Me.tab_ExtrasEdit.Name = "tab_ExtrasEdit"
        Me.tab_ExtrasEdit.SelectedIndex = 0
        Me.tab_ExtrasEdit.Size = New System.Drawing.Size(423, 137)
        Me.tab_ExtrasEdit.TabIndex = 47
        '
        'tpg_instructionsEdit
        '
        Me.tpg_instructionsEdit.AllowDrop = True
        Me.tpg_instructionsEdit.Controls.Add(Me.lbl_dragDrop)
        Me.tpg_instructionsEdit.Controls.Add(Me.Label1)
        Me.tpg_instructionsEdit.Controls.Add(Me.lbl_instruct1)
        Me.tpg_instructionsEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpg_instructionsEdit.Name = "tpg_instructionsEdit"
        Me.tpg_instructionsEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_instructionsEdit.Size = New System.Drawing.Size(415, 111)
        Me.tpg_instructionsEdit.TabIndex = 2
        Me.tpg_instructionsEdit.Text = "Instructions"
        Me.tpg_instructionsEdit.UseVisualStyleBackColor = True
        '
        'lbl_dragDrop
        '
        Me.lbl_dragDrop.AllowDrop = True
        Me.lbl_dragDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dragDrop.Location = New System.Drawing.Point(6, 74)
        Me.lbl_dragDrop.Name = "lbl_dragDrop"
        Me.lbl_dragDrop.Size = New System.Drawing.Size(403, 30)
        Me.lbl_dragDrop.TabIndex = 2
        Me.lbl_dragDrop.Text = "Drag new media here"
        Me.lbl_dragDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To add a new entry, drag the media into the box below, then populate the fields b" &
    "efore clicking save."
        '
        'lbl_instruct1
        '
        Me.lbl_instruct1.Location = New System.Drawing.Point(6, 10)
        Me.lbl_instruct1.Name = "lbl_instruct1"
        Me.lbl_instruct1.Size = New System.Drawing.Size(403, 30)
        Me.lbl_instruct1.TabIndex = 0
        Me.lbl_instruct1.Text = "To edit an existing entry, narrow down the search terms to a single entity, then " &
    "modify the required fields before clicking save."
        '
        'tpg_FeaturesEdit
        '
        Me.tpg_FeaturesEdit.Controls.Add(Me.txt_FeaturesEdit)
        Me.tpg_FeaturesEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpg_FeaturesEdit.Name = "tpg_FeaturesEdit"
        Me.tpg_FeaturesEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_FeaturesEdit.Size = New System.Drawing.Size(415, 111)
        Me.tpg_FeaturesEdit.TabIndex = 0
        Me.tpg_FeaturesEdit.Text = "Features"
        Me.tpg_FeaturesEdit.UseVisualStyleBackColor = True
        '
        'txt_FeaturesEdit
        '
        Me.txt_FeaturesEdit.Location = New System.Drawing.Point(7, 7)
        Me.txt_FeaturesEdit.Multiline = True
        Me.txt_FeaturesEdit.Name = "txt_FeaturesEdit"
        Me.txt_FeaturesEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FeaturesEdit.Size = New System.Drawing.Size(402, 98)
        Me.txt_FeaturesEdit.TabIndex = 0
        '
        'tpg_notesEdit
        '
        Me.tpg_notesEdit.Controls.Add(Me.txt_NotesEdit)
        Me.tpg_notesEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpg_notesEdit.Name = "tpg_notesEdit"
        Me.tpg_notesEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_notesEdit.Size = New System.Drawing.Size(415, 111)
        Me.tpg_notesEdit.TabIndex = 1
        Me.tpg_notesEdit.Text = "Install Notes"
        Me.tpg_notesEdit.UseVisualStyleBackColor = True
        '
        'txt_NotesEdit
        '
        Me.txt_NotesEdit.Location = New System.Drawing.Point(7, 7)
        Me.txt_NotesEdit.Multiline = True
        Me.txt_NotesEdit.Name = "txt_NotesEdit"
        Me.txt_NotesEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_NotesEdit.Size = New System.Drawing.Size(402, 98)
        Me.txt_NotesEdit.TabIndex = 1
        '
        'cbx_osSizeEdit
        '
        Me.cbx_osSizeEdit.FormattingEnabled = True
        Me.cbx_osSizeEdit.Location = New System.Drawing.Point(247, 99)
        Me.cbx_osSizeEdit.Name = "cbx_osSizeEdit"
        Me.cbx_osSizeEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osSizeEdit.TabIndex = 46
        '
        'lbl_osSizeEdit
        '
        Me.lbl_osSizeEdit.AutoSize = True
        Me.lbl_osSizeEdit.Location = New System.Drawing.Point(200, 102)
        Me.lbl_osSizeEdit.Name = "lbl_osSizeEdit"
        Me.lbl_osSizeEdit.Size = New System.Drawing.Size(30, 13)
        Me.lbl_osSizeEdit.TabIndex = 45
        Me.lbl_osSizeEdit.Text = "Size:"
        '
        'cbx_osNameEdit
        '
        Me.cbx_osNameEdit.FormattingEnabled = True
        Me.cbx_osNameEdit.Location = New System.Drawing.Point(58, 99)
        Me.cbx_osNameEdit.Name = "cbx_osNameEdit"
        Me.cbx_osNameEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osNameEdit.TabIndex = 44
        '
        'lbl_osNameEdit
        '
        Me.lbl_osNameEdit.AutoSize = True
        Me.lbl_osNameEdit.Location = New System.Drawing.Point(11, 102)
        Me.lbl_osNameEdit.Name = "lbl_osNameEdit"
        Me.lbl_osNameEdit.Size = New System.Drawing.Size(38, 13)
        Me.lbl_osNameEdit.TabIndex = 43
        Me.lbl_osNameEdit.Text = "Name:"
        '
        'cbx_osBuildEdit
        '
        Me.cbx_osBuildEdit.FormattingEnabled = True
        Me.cbx_osBuildEdit.Location = New System.Drawing.Point(247, 70)
        Me.cbx_osBuildEdit.Name = "cbx_osBuildEdit"
        Me.cbx_osBuildEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osBuildEdit.TabIndex = 42
        '
        'lbl_osBuildEdit
        '
        Me.lbl_osBuildEdit.AutoSize = True
        Me.lbl_osBuildEdit.Location = New System.Drawing.Point(200, 73)
        Me.lbl_osBuildEdit.Name = "lbl_osBuildEdit"
        Me.lbl_osBuildEdit.Size = New System.Drawing.Size(33, 13)
        Me.lbl_osBuildEdit.TabIndex = 41
        Me.lbl_osBuildEdit.Text = "Build:"
        '
        'cbx_osVersionEdit
        '
        Me.cbx_osVersionEdit.FormattingEnabled = True
        Me.cbx_osVersionEdit.Location = New System.Drawing.Point(247, 41)
        Me.cbx_osVersionEdit.Name = "cbx_osVersionEdit"
        Me.cbx_osVersionEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osVersionEdit.TabIndex = 40
        '
        'lbl_osVersionEdit
        '
        Me.lbl_osVersionEdit.AutoSize = True
        Me.lbl_osVersionEdit.Location = New System.Drawing.Point(200, 44)
        Me.lbl_osVersionEdit.Name = "lbl_osVersionEdit"
        Me.lbl_osVersionEdit.Size = New System.Drawing.Size(45, 13)
        Me.lbl_osVersionEdit.TabIndex = 39
        Me.lbl_osVersionEdit.Text = "Version:"
        '
        'cbx_osBootEdit
        '
        Me.cbx_osBootEdit.FormattingEnabled = True
        Me.cbx_osBootEdit.Location = New System.Drawing.Point(247, 12)
        Me.cbx_osBootEdit.Name = "cbx_osBootEdit"
        Me.cbx_osBootEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osBootEdit.TabIndex = 38
        '
        'lbl_osBootEdit
        '
        Me.lbl_osBootEdit.AutoSize = True
        Me.lbl_osBootEdit.Location = New System.Drawing.Point(200, 15)
        Me.lbl_osBootEdit.Name = "lbl_osBootEdit"
        Me.lbl_osBootEdit.Size = New System.Drawing.Size(32, 13)
        Me.lbl_osBootEdit.TabIndex = 37
        Me.lbl_osBootEdit.Text = "Boot:"
        '
        'cbx_osRamEdit
        '
        Me.cbx_osRamEdit.FormattingEnabled = True
        Me.cbx_osRamEdit.Location = New System.Drawing.Point(58, 154)
        Me.cbx_osRamEdit.Name = "cbx_osRamEdit"
        Me.cbx_osRamEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osRamEdit.TabIndex = 36
        '
        'lbl_osRamEdit
        '
        Me.lbl_osRamEdit.AutoSize = True
        Me.lbl_osRamEdit.Location = New System.Drawing.Point(11, 157)
        Me.lbl_osRamEdit.Name = "lbl_osRamEdit"
        Me.lbl_osRamEdit.Size = New System.Drawing.Size(47, 13)
        Me.lbl_osRamEdit.TabIndex = 35
        Me.lbl_osRamEdit.Text = "Memory:"
        '
        'cbx_osPlatformEdit
        '
        Me.cbx_osPlatformEdit.FormattingEnabled = True
        Me.cbx_osPlatformEdit.Location = New System.Drawing.Point(58, 125)
        Me.cbx_osPlatformEdit.Name = "cbx_osPlatformEdit"
        Me.cbx_osPlatformEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osPlatformEdit.TabIndex = 34
        '
        'lbl_osPlatformEdit
        '
        Me.lbl_osPlatformEdit.AutoSize = True
        Me.lbl_osPlatformEdit.Location = New System.Drawing.Point(11, 128)
        Me.lbl_osPlatformEdit.Name = "lbl_osPlatformEdit"
        Me.lbl_osPlatformEdit.Size = New System.Drawing.Size(48, 13)
        Me.lbl_osPlatformEdit.TabIndex = 33
        Me.lbl_osPlatformEdit.Text = "Platform:"
        '
        'cbx_osEditionEdit
        '
        Me.cbx_osEditionEdit.FormattingEnabled = True
        Me.cbx_osEditionEdit.Location = New System.Drawing.Point(58, 70)
        Me.cbx_osEditionEdit.Name = "cbx_osEditionEdit"
        Me.cbx_osEditionEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osEditionEdit.TabIndex = 32
        '
        'lbl_osEditionEdit
        '
        Me.lbl_osEditionEdit.AutoSize = True
        Me.lbl_osEditionEdit.Location = New System.Drawing.Point(11, 73)
        Me.lbl_osEditionEdit.Name = "lbl_osEditionEdit"
        Me.lbl_osEditionEdit.Size = New System.Drawing.Size(42, 13)
        Me.lbl_osEditionEdit.TabIndex = 31
        Me.lbl_osEditionEdit.Text = "Edition:"
        '
        'cbx_osVariantEdit
        '
        Me.cbx_osVariantEdit.FormattingEnabled = True
        Me.cbx_osVariantEdit.Location = New System.Drawing.Point(58, 41)
        Me.cbx_osVariantEdit.Name = "cbx_osVariantEdit"
        Me.cbx_osVariantEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osVariantEdit.TabIndex = 30
        '
        'lbl_osVariantEdit
        '
        Me.lbl_osVariantEdit.AutoSize = True
        Me.lbl_osVariantEdit.Location = New System.Drawing.Point(11, 44)
        Me.lbl_osVariantEdit.Name = "lbl_osVariantEdit"
        Me.lbl_osVariantEdit.Size = New System.Drawing.Size(43, 13)
        Me.lbl_osVariantEdit.TabIndex = 29
        Me.lbl_osVariantEdit.Text = "Variant:"
        '
        'cbx_osParentEdit
        '
        Me.cbx_osParentEdit.FormattingEnabled = True
        Me.cbx_osParentEdit.Location = New System.Drawing.Point(58, 12)
        Me.cbx_osParentEdit.Name = "cbx_osParentEdit"
        Me.cbx_osParentEdit.Size = New System.Drawing.Size(121, 21)
        Me.cbx_osParentEdit.TabIndex = 28
        '
        'lbl_osParentEdit
        '
        Me.lbl_osParentEdit.AutoSize = True
        Me.lbl_osParentEdit.Location = New System.Drawing.Point(11, 15)
        Me.lbl_osParentEdit.Name = "lbl_osParentEdit"
        Me.lbl_osParentEdit.Size = New System.Drawing.Size(41, 13)
        Me.lbl_osParentEdit.TabIndex = 27
        Me.lbl_osParentEdit.Text = "Parent:"
        '
        'ofd_database
        '
        Me.ofd_database.Filter = "Access Database file|*.accdb"
        '
        'strp_connectionStatus
        '
        Me.strp_connectionStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_databaseStatus})
        Me.strp_connectionStatus.Location = New System.Drawing.Point(0, 352)
        Me.strp_connectionStatus.Name = "strp_connectionStatus"
        Me.strp_connectionStatus.Size = New System.Drawing.Size(848, 22)
        Me.strp_connectionStatus.TabIndex = 2
        Me.strp_connectionStatus.Text = "StatusStrip1"
        '
        'tssl_databaseStatus
        '
        Me.tssl_databaseStatus.Name = "tssl_databaseStatus"
        Me.tssl_databaseStatus.Size = New System.Drawing.Size(79, 17)
        Me.tssl_databaseStatus.Text = "Disconnected"
        '
        'frm_main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 374)
        Me.Controls.Add(Me.strp_connectionStatus)
        Me.Controls.Add(Me.grp_control)
        Me.Controls.Add(Me.grp_connect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.Text = "Operating System Database Frontend"
        Me.grp_connect.ResumeLayout(False)
        Me.grp_connect.PerformLayout()
        Me.grp_control.ResumeLayout(False)
        Me.tab_controls.ResumeLayout(False)
        Me.tpg_read.ResumeLayout(False)
        Me.tpg_read.PerformLayout()
        Me.tab_results.ResumeLayout(False)
        Me.tpg_specs.ResumeLayout(False)
        Me.tpg_specs.PerformLayout()
        Me.tpg_Features.ResumeLayout(False)
        Me.tpg_Features.PerformLayout()
        Me.tpg_Notes.ResumeLayout(False)
        Me.tpg_Notes.PerformLayout()
        Me.tpg_edit.ResumeLayout(False)
        Me.tpg_edit.PerformLayout()
        Me.tab_ExtrasEdit.ResumeLayout(False)
        Me.tpg_instructionsEdit.ResumeLayout(False)
        Me.tpg_FeaturesEdit.ResumeLayout(False)
        Me.tpg_FeaturesEdit.PerformLayout()
        Me.tpg_notesEdit.ResumeLayout(False)
        Me.tpg_notesEdit.PerformLayout()
        Me.strp_connectionStatus.ResumeLayout(False)
        Me.strp_connectionStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cbx_osTypeEdit As ComboBox
    Friend WithEvents lbl_osTypeEdit As Label
    Friend WithEvents cbx_osFormatEdit As ComboBox
    Friend WithEvents lbl_osFormatEdit As Label
    Friend WithEvents tab_ExtrasEdit As TabControl
    Friend WithEvents tpg_FeaturesEdit As TabPage
    Friend WithEvents txt_FeaturesEdit As TextBox
    Friend WithEvents tpg_notesEdit As TabPage
    Friend WithEvents txt_NotesEdit As TextBox
    Friend WithEvents cbx_osSizeEdit As ComboBox
    Friend WithEvents lbl_osSizeEdit As Label
    Friend WithEvents cbx_osNameEdit As ComboBox
    Friend WithEvents lbl_osNameEdit As Label
    Friend WithEvents cbx_osBuildEdit As ComboBox
    Friend WithEvents lbl_osBuildEdit As Label
    Friend WithEvents cbx_osVersionEdit As ComboBox
    Friend WithEvents lbl_osVersionEdit As Label
    Friend WithEvents cbx_osBootEdit As ComboBox
    Friend WithEvents lbl_osBootEdit As Label
    Friend WithEvents cbx_osRamEdit As ComboBox
    Friend WithEvents lbl_osRamEdit As Label
    Friend WithEvents cbx_osPlatformEdit As ComboBox
    Friend WithEvents lbl_osPlatformEdit As Label
    Friend WithEvents cbx_osEditionEdit As ComboBox
    Friend WithEvents lbl_osEditionEdit As Label
    Friend WithEvents cbx_osVariantEdit As ComboBox
    Friend WithEvents lbl_osVariantEdit As Label
    Friend WithEvents cbx_osParentEdit As ComboBox
    Friend WithEvents lbl_osParentEdit As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents tpg_specs As TabPage
    Friend WithEvents txt_specs As TextBox
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents strp_connectionStatus As StatusStrip
    Friend WithEvents tssl_databaseStatus As ToolStripStatusLabel
    Friend WithEvents cbx_osFileName As ComboBox
    Friend WithEvents lbl_osfilename As Label
    Friend WithEvents tpg_instructionsEdit As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_instruct1 As Label
    Friend WithEvents lbl_dragDrop As Label
End Class

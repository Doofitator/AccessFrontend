Imports System.Drawing.Printing
Imports System.IO

Public Class frm_main

    Private Sub lbl_dragDrop_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lbl_dragDrop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub lbl_dragDrop_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles lbl_dragDrop.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim paths As Integer = 0
        Dim file As String = Nothing
        For Each path In files
            paths = paths + 1
            file = path
        Next
        If paths > 1 Then
            MsgBox("More than one file was imported. Please try again.", vbOKOnly + vbCritical, "Error")
        Else
            Database_Controls.newMedia = New System.IO.FileInfo(file)

        End If

        If Not cbx_osFormatEdit.Items.Contains(newMedia.Extension.Replace(".", "")) Then
            cbx_osFormatEdit.Items.Add(newMedia.Extension.Replace(".", ""))
            cbx_osFormatEdit.SelectedItem = newMedia.Extension.Replace(".", "")
        Else
            cbx_osFormatEdit.SelectedItem = newMedia.Extension
        End If
        If Not cbx_osSizeEdit.Items.Contains(GetFileSizeInMBs(newMedia.FullName)) Then
            cbx_osSizeEdit.Items.Add(GetFileSizeInMBs(newMedia.FullName))
            cbx_osSizeEdit.SelectedItem = GetFileSizeInMBs(newMedia.FullName)
        Else
            cbx_osSizeEdit.SelectedItem = GetFileSizeInMBs(newMedia.FullName)
        End If


    End Sub

    Private Sub frm_main_resize() Handles MyBase.Resize
        grp_connect.Width = Me.Width - 40
        grp_control.Top = grp_connect.Top + grp_connect.Height
        grp_control.Height = Me.Height - 20 - grp_connect.Height - 40 - 22
        grp_control.Width = Me.Width - 40

        btn_connect.Left = grp_connect.Width - btn_connect.Width - 5
        btn_disconnect.Left = btn_connect.Left - btn_disconnect.Width - 1
        btn_openOFD.Left = grp_connect.Width - btn_openOFD.Width - 5
        txt_filename.Width = grp_connect.Width - btn_openOFD.Width - 5 - lbl_hint1.Width - 7 - 5

        tab_controls.Width = grp_control.Width - 20
        tab_controls.Left = 10
        tab_controls.Height = grp_control.Height - 30
        tab_controls.Top = 20

        changeTab_Click()
    End Sub

    Private Sub ofd_database_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_database.FileOk
        txt_filename.Text = ofd_database.FileName
        btn_connect.Enabled = True
    End Sub

    Private Sub btn_openOFD_Click(sender As Object, e As EventArgs) Handles btn_openOFD.Click
        ofd_database.ShowDialog()
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        With Me
            .Cursor = Cursors.WaitCursor
            .Refresh()
        End With

        grp_control.Enabled = True
        tab_controls.Enabled = True
        tab_results.Enabled = True
        Me.MaximizeBox = True
        Me.FormBorderStyle = FormBorderStyle.Sizable
        btn_disconnect.Enabled = True
        btn_connect.Enabled = False
        txt_filename.Enabled = False


        populateComboBoxes()

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
        resizeControlsGroupboxContent(True)
        resizeControlsGroupboxContent(False)
    End Sub

    Private Sub changeTab_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles tpg_read.Click, tpg_edit.Click, tab_controls.Click, tab_ExtrasEdit.Click, tab_results.Click, tpg_edit.Click, tpg_read.Click, tpg_specs.Click
        resizeControlsGroupboxContent(True)
        resizeControlsGroupboxContent(False)
    End Sub



    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        For Each cbx As ComboBox In tpg_edit.Controls.OfType(Of ComboBox)
            cbx.Items.Clear()
            cbx.SelectedText = ""
        Next
        For Each cbx As ComboBox In tpg_read.Controls.OfType(Of ComboBox)
            cbx.Items.Clear()
            cbx.SelectedText = ""
        Next
        txt_specs.Text = ""
        txt_filename.Enabled = True
        btn_connect.Enabled = True
        btn_disconnect.Enabled = False
        grp_control.Enabled = False
        tssl_databaseStatus.Text = "Database closed."
    End Sub

    Dim stringToPrint As String 'this is what gets printed when u hit the button

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_printSearch.Click
        stringToPrint = getStringOfAllAvails()
        If pdg_Report.ShowDialog = DialogResult.OK Then
            pdc_Report.PrinterSettings = pdg_Report.PrinterSettings
            pdc_Report.Print()
        End If
    End Sub

    Private Sub pdc_report_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles pdc_report.PrintPage
        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0
        e.Graphics.MeasureString(stringToPrint, Me.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)
        e.Graphics.DrawString(stringToPrint, Me.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
        stringToPrint = stringToPrint.Substring(charactersOnPage)
        e.HasMorePages = (stringToPrint.Length > 0)
    End Sub

    Dim DatabaseWhiteList As String

    Private Sub SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_osBoot.SelectedIndexChanged, cbx_osBuild.SelectedIndexChanged, cbx_osEdition.SelectedIndexChanged, cbx_osFileName.SelectedIndexChanged, cbx_osFormat.SelectedIndexChanged, cbx_osName.SelectedIndexChanged, cbx_osParent.SelectedIndexChanged, cbx_osPlatform.SelectedIndexChanged, cbx_osRAM.SelectedIndexChanged, cbx_osSize.SelectedIndexChanged, cbx_osType.SelectedIndexChanged, cbx_osVariant.SelectedIndexChanged, cbx_osVersion.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim control As ComboBox = CType(sender, ComboBox) 'Get combobox
        Dim x As String = control.SelectedItem
        Console.WriteLine("Control: " & control.Name & " modified.")
        If Not x = "" Then DatabaseWhiteList += x & "," 'add it's name to the whitelist
        Dim whitelistArray As String() = DatabaseWhiteList.Split(",") 'make the whitelist an array
        populateComboBoxes(whitelistArray, control) 'run function with whitelistarray (everything whitelisted thus far) and name (the current modified combobox)
        'WasOnceATODO: What if you set a combobox to a different value from the initial? Also, what if you set it to blank again? Will it un-whitelist?
        '^ maybe once a combobox Is changed, disable it? add another button that says to reset And we will start over?
        '^ Whitelist really doesn't matter anyway. It's not used because I never worked out the function :(
        CheckIfOneRecord()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EditSelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_osBootEdit.SelectedIndexChanged, cbx_osBuildEdit.SelectedIndexChanged, cbx_osEditionEdit.SelectedIndexChanged, cbx_osFormatEdit.SelectedIndexChanged, cbx_osNameEdit.SelectedIndexChanged, cbx_osParentEdit.SelectedIndexChanged, cbx_osPlatformEdit.SelectedIndexChanged, cbx_osRamEdit.SelectedIndexChanged, cbx_osSizeEdit.SelectedIndexChanged, cbx_osTypeEdit.SelectedIndexChanged, cbx_osVariantEdit.SelectedIndexChanged, cbx_osVersionEdit.SelectedIndexChanged
        Dim control As ComboBox = CType(sender, ComboBox) 'Get combobox
        Dim item As String = control.SelectedItem
        If control Is cbx_osNameEdit Then
            If Not cbx_osNameEdit.SelectedItem = "Add new..." Then
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "variant"), cbx_osVariantEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "version"), cbx_osVersionEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "edition"), cbx_osEditionEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "ram"), cbx_osRamEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "mediaSize"), cbx_osSizeEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "mediaFormat"), cbx_osFormatEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "buildType"), cbx_osBuildEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "parent"), cbx_osParentEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "platform"), cbx_osPlatformEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "boot"), cbx_osBootEdit)
                populateComboBoxWithManualData(getRecordByFieldAsField("friendlyName", item, "tbl_os", "mediaType"), cbx_osTypeEdit)
            End If
        End If

        If control.SelectedItem = "Add new..." Then
whoopsies:
            Dim input As String = InputBox("Please enter new value:")
            If control Is cbx_osRamEdit Or control Is cbx_osVersionEdit Or control Is cbx_osSizeEdit Then
                If Not System.Text.RegularExpressions.Regex.IsMatch(input, "^\d+(\.\d+)*$") Then
                    MsgBox("The value had to be numeric with only full-stops (points) and numbers allowed.")
                    GoTo whoopsies
                End If
            End If
            If control.Items.Contains(input) Then
                MsgBox("The value entered already exists")
                GoTo whoopsies
            End If
            control.Items.Add(input)
            control.SelectedIndex = control.Items.IndexOf(input)
        End If
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If newMedia Is Nothing Then
            updateData()
            MsgBox("Please close and open the connection again to see your changes.")
            Exit Sub
        End If
        insertData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_printSpecs.Click
        stringToPrint = txt_specs.Text
        If pdg_Report.ShowDialog = DialogResult.OK Then
            pdc_Report.PrinterSettings = pdg_Report.PrinterSettings
            pdc_Report.Print()
        End If
    End Sub
End Class

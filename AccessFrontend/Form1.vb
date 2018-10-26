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


    'TODO: Make the instructions tab controls resize
    'TODO: Make the FeaturesEdit, NotesEdit tabs greyed until the search fields have been narrowed down to one result._
    '      Also, add a "Add new" option to all comboboxes on the edit page after there is only one result also.

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

    Function populateComboBoxes(Optional whitelist As Array = Nothing, Optional exclude As ComboBox = Nothing, Optional isconnected As Boolean = False)
        With Me
            .Cursor = Cursors.WaitCursor
            .Refresh()
        End With

        If Not exclude Is cbx_osVariant Then populateCombobox(1, cbx_osVariant, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osVersion Then populateCombobox(2, cbx_osVersion, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osEdition Then populateCombobox(3, cbx_osEdition, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osName Then populateCombobox(4, cbx_osName, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osRAM Then populateCombobox(5, cbx_osRAM, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osSize Then populateCombobox(6, cbx_osSize, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osFormat Then populateCombobox(7, cbx_osFormat, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osBuild Then populateCombobox(8, cbx_osBuild, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osParent Then populateCombobox(9, cbx_osParent, whitelist, exclude, isconnected)     'No idea why the order is like this. Not like
        If Not exclude Is cbx_osPlatform Then populateCombobox(10, cbx_osPlatform, whitelist, exclude, isconnected)  'it's alphabetical or anything. Just is this way :/
        If Not exclude Is cbx_osFileName Then populateCombobox(11, cbx_osFileName, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osBoot Then populateCombobox(12, cbx_osBoot, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osType Then populateCombobox(13, cbx_osType, whitelist, exclude, isconnected)

        'Now we'll populate the comboboxes on the edit page, too.

        If Not exclude Is cbx_osVariantEdit Then populateCombobox(1, cbx_osVariantEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osVersionEdit Then populateCombobox(2, cbx_osVersionEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osEditionEdit Then populateCombobox(3, cbx_osEditionEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osNameEdit Then populateCombobox(4, cbx_osNameEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osRamEdit Then populateCombobox(5, cbx_osRamEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osSizeEdit Then populateCombobox(6, cbx_osSizeEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osFormatEdit Then populateCombobox(7, cbx_osFormatEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osBuildEdit Then populateCombobox(8, cbx_osBuildEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osParentEdit Then populateCombobox(9, cbx_osParentEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osPlatformEdit Then populateCombobox(10, cbx_osPlatformEdit, whitelist, exclude, isconnected)
        'If Not exclude Is cbx_osFileNameEdit Then populateCombobox(11, cbx_osFileNameEdit) 'This one doesn't exist
        If Not exclude Is cbx_osBootEdit Then populateCombobox(12, cbx_osBootEdit, whitelist, exclude, isconnected)
        If Not exclude Is cbx_osTypeEdit Then populateCombobox(13, cbx_osTypeEdit, whitelist, exclude, isconnected)

        With Me
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Data populated. Disconnected."
            .Refresh()
        End With
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
        resizeControlsGroupboxContent(True)
        resizeControlsGroupboxContent(False)
    End Sub

    Private Sub changeTab_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles tpg_read.Click, tpg_edit.Click, tpg_Features.Click, tpg_FeaturesEdit.Click, tpg_Notes.Click, tpg_notesEdit.Click, tab_controls.Click, tab_ExtrasEdit.Click, tab_results.Click, tpg_edit.Click, tpg_Features.Click, tpg_FeaturesEdit.Click, tpg_Notes.Click, tpg_notesEdit.Click, tpg_read.Click, tpg_specs.Click
        resizeControlsGroupboxContent(True)
        resizeControlsGroupboxContent(False)
    End Sub



    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        txt_filename.Enabled = True
        btn_connect.Enabled = True
        btn_disconnect.Enabled = False
        grp_control.Enabled = False
        tssl_databaseStatus.Text = "Database closed."
    End Sub

    Dim stringToPrint As String 'this is what gets printed when u hit the button

    'TODO: Rename pdc_report to something hungarian

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        pdc_report.Print()
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
        Dim name As ComboBox = CType(sender, ComboBox)
        Dim x As String = name.SelectedItem
        DatabaseWhiteList += x & ","
        Dim whitelistArray As String() = DatabaseWhiteList.Split(",")
        populateComboBoxes(whitelistArray, name)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        insertData()
    End Sub
End Class

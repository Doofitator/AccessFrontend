Public Class frm_main
    Dim DatabaseConnection = New OleDb.OleDbConnection
    Dim Connected As Boolean = False
    Dim newMedia As System.IO.FileInfo = Nothing

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
            newMedia = New System.IO.FileInfo(file)

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

    Public Function GetFileSizeInMBs(ByVal TheFile As String) As String
        'Modified from https://stackoverflow.com/questions/27367190/how-to-return-kb-mb-and-gb-from-bytes-using-a-public-function
        Dim DoubleBytes As Double = Nothing
        If TheFile.Length = 0 Then Return "Null"
        If Not System.IO.File.Exists(TheFile) Then Return "Null"
        Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(TheFile).Length
        Try
            DoubleBytes = CDbl(TheSize / 1048576) 'MB
            Return FormatNumber(DoubleBytes, 2)
        Catch
            Return "Null"
        End Try
    End Function

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

    Private Function resizeControlsGroupboxContent(ByVal isReadPage As Boolean)
        If isReadPage Then
            If tab_controls.Height > 370 Then
                tab_results.Width = tab_controls.Width - 30
                tab_results.Left = 10
                tab_results.Top = 231
                tab_results.Height = tab_controls.Height - 276
                lbl_resultsHint.Top = 210
                lbl_resultsHint.Left = 10
            Else
                tab_results.Left = 551
                tab_results.Width = tab_controls.Width - lbl_osParent.Width - lbl_osBoot.Width - cbx_osBoot.Width - cbx_osParent.Width - 250
                tab_results.Top = 38
                tab_results.Height = 137
                lbl_resultsHint.Left = 551
                lbl_resultsHint.Top = 7
            End If

            txt_Features.Height = tpg_Features.Height - 14
            txt_Notes.Height = tpg_Notes.Height - 14
            txt_Features.Width = tpg_Features.Width - 14
            txt_Notes.Width = tpg_Features.Width - 14
            txt_specs.Width = tpg_Features.Width - 14
            txt_specs.Height = tpg_Features.Height - 14
        Else
            If tab_controls.Height > 370 Then
                tab_ExtrasEdit.Width = tab_controls.Width - 30
                tab_ExtrasEdit.Left = 10
                tab_ExtrasEdit.Top = 201
                tab_ExtrasEdit.Height = tpg_edit.Height - 249
            Else
                tab_ExtrasEdit.Left = 374
                tab_ExtrasEdit.Width = tab_controls.Width - lbl_osParentEdit.Width - lbl_osBootEdit.Width - cbx_osBootEdit.Width - cbx_osParentEdit.Width - 70
                tab_ExtrasEdit.Top = 12
                tab_ExtrasEdit.Height = 137
            End If

            txt_FeaturesEdit.Height = tpg_FeaturesEdit.Height - 14
            txt_NotesEdit.Height = tpg_notesEdit.Height - 14
            txt_FeaturesEdit.Width = tpg_FeaturesEdit.Width - 14
            txt_NotesEdit.Width = tpg_FeaturesEdit.Width - 14
            btn_Save.Left = tpg_edit.Width - btn_Save.Width - 10
            btn_Save.Top = tab_ExtrasEdit.Height + tab_ExtrasEdit.Top + 10
        End If

        Return True
    End Function

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
        tssl_databaseStatus.Text = "Connecting... Please wait."
        DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & txt_filename.Text
        DatabaseConnection.Open()
        Connected = True
        tssl_databaseStatus.Text = "Connected to Access Database " & txt_filename.Text
        btn_disconnect.Enabled = True
        btn_connect.Enabled = False

        'We're connected now. Let's do stuff.

        populateCombobox(1, cbx_osVariant)
        populateCombobox(2, cbx_osVersion)
        populateCombobox(3, cbx_osEdition)
        populateCombobox(4, cbx_osName)
        populateCombobox(5, cbx_osRAM)
        populateCombobox(6, cbx_osSize)
        populateCombobox(7, cbx_osFormat)
        populateCombobox(8, cbx_osBuild)
        populateCombobox(9, cbx_osParent)     'No idea why the order is like this. Not like
        populateCombobox(10, cbx_osPlatform)  'it's alphabetical or anything. Just is this way :/
        populateCombobox(11, cbx_osFileName)
        populateCombobox(12, cbx_osBoot)
        populateCombobox(13, cbx_osType)

        'Now we'll populate the comboboxes on the edit page, too.

        populateCombobox(1, cbx_osVariantEdit)
        populateCombobox(2, cbx_osVersionEdit)
        populateCombobox(3, cbx_osEditionEdit)
        populateCombobox(4, cbx_osNameEdit)
        populateCombobox(5, cbx_osRamEdit)
        populateCombobox(6, cbx_osSizeEdit)
        populateCombobox(7, cbx_osFormatEdit)
        populateCombobox(8, cbx_osBuildEdit)
        populateCombobox(9, cbx_osParentEdit)
        populateCombobox(10, cbx_osPlatformEdit)
        'populateCombobox(11, cbx_osFileNameEdit) 'This one doesn't exist on the edit page.
        populateCombobox(12, cbx_osBootEdit)
        populateCombobox(13, cbx_osTypeEdit)

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

    Private Sub frm_main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Connected Then
            e.Cancel = True
            MsgBox("You are still connected to the database. Please disconnect before closing.", vbOKOnly + vbCritical, "Still Connected!")
        End If
    End Sub

    Private Sub changeTab_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles tpg_read.Click, tpg_edit.Click, tpg_Features.Click, tpg_FeaturesEdit.Click, tpg_Notes.Click, tpg_notesEdit.Click, tab_controls.Click, tab_ExtrasEdit.Click, tab_results.Click, tpg_edit.Click, tpg_Features.Click, tpg_FeaturesEdit.Click, tpg_Notes.Click, tpg_notesEdit.Click, tpg_read.Click, tpg_specs.Click
        resizeControlsGroupboxContent(True)
        resizeControlsGroupboxContent(False)
    End Sub

    Private Function populateCombobox(ByVal rowNumber As Integer, ByVal theCombobox As ComboBox)
        Dim Table_ As String = "tbl_os"
        Dim query As String = "SELECT * FROM " & Table_
        Dim MDBConnString_ As String = DatabaseConnection.connectionstring
        Dim DataSet As New DataSet
        Dim Command As New OleDb.OleDbCommand(query, DatabaseConnection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter(Command)
        DataAdapter.Fill(DataSet, Table_)
        Dim t1 As DataTable = DataSet.Tables(Table_)
        Dim row As DataRow
        Dim Item(2) As String

        For Each row In t1.Rows
            Try
                Item(0) = row(rowNumber)
            Catch
                Item(0) = "Undefined"
            End Try
            Dim NextListItem As New ListViewItem(Item)
            If Not theCombobox.Items.Contains(NextListItem.Text) Then
                theCombobox.Items.Add(NextListItem.Text)
            End If
        Next
    End Function

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        tssl_databaseStatus.Text = "Disconnecting... Please wait"
        With Me
            .Cursor = Cursors.WaitCursor
            .Refresh()
        End With
        DatabaseConnection.close()
        tssl_databaseStatus.Text = "Disconnected"
        Connected = False
        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With
        btn_connect.Enabled = True
        btn_disconnect.Enabled = False
        grp_control.Enabled = False
    End Sub
End Class

Imports System.Drawing.Printing
Imports System.IO

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
        populateComboBoxes()

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With
    End Sub

    Private Function populateComboBoxes(Optional whitelist As Array = Nothing, Optional exclude As ComboBox = Nothing)
        With Me
            .Cursor = Cursors.WaitCursor
            .Refresh()
        End With

        If Not exclude Is cbx_osVariant Then populateCombobox(1, cbx_osVariant, whitelist, exclude)
        If Not exclude Is cbx_osVersion Then populateCombobox(2, cbx_osVersion, whitelist, exclude)
        If Not exclude Is cbx_osEdition Then populateCombobox(3, cbx_osEdition, whitelist, exclude)
        If Not exclude Is cbx_osName Then populateCombobox(4, cbx_osName, whitelist, exclude)
        If Not exclude Is cbx_osRAM Then populateCombobox(5, cbx_osRAM, whitelist, exclude)
        If Not exclude Is cbx_osSize Then populateCombobox(6, cbx_osSize, whitelist, exclude)
        If Not exclude Is cbx_osFormat Then populateCombobox(7, cbx_osFormat, whitelist, exclude)
        If Not exclude Is cbx_osBuild Then populateCombobox(8, cbx_osBuild, whitelist, exclude)
        If Not exclude Is cbx_osParent Then populateCombobox(9, cbx_osParent, whitelist, exclude)     'No idea why the order is like this. Not like
        If Not exclude Is cbx_osPlatform Then populateCombobox(10, cbx_osPlatform, whitelist, exclude)  'it's alphabetical or anything. Just is this way :/
        If Not exclude Is cbx_osFileName Then populateCombobox(11, cbx_osFileName, whitelist, exclude)
        If Not exclude Is cbx_osBoot Then populateCombobox(12, cbx_osBoot, whitelist, exclude)
        If Not exclude Is cbx_osType Then populateCombobox(13, cbx_osType, whitelist, exclude)

        'Now we'll populate the comboboxes on the edit page, too.

        If Not exclude Is cbx_osVariantEdit Then populateCombobox(1, cbx_osVariantEdit, whitelist, exclude)
        If Not exclude Is cbx_osVersionEdit Then populateCombobox(2, cbx_osVersionEdit, whitelist, exclude)
        If Not exclude Is cbx_osEditionEdit Then populateCombobox(3, cbx_osEditionEdit, whitelist, exclude)
        If Not exclude Is cbx_osNameEdit Then populateCombobox(4, cbx_osNameEdit, whitelist, exclude)
        If Not exclude Is cbx_osRamEdit Then populateCombobox(5, cbx_osRamEdit, whitelist, exclude)
        If Not exclude Is cbx_osSizeEdit Then populateCombobox(6, cbx_osSizeEdit, whitelist, exclude)
        If Not exclude Is cbx_osFormatEdit Then populateCombobox(7, cbx_osFormatEdit, whitelist, exclude)
        If Not exclude Is cbx_osBuildEdit Then populateCombobox(8, cbx_osBuildEdit, whitelist, exclude)
        If Not exclude Is cbx_osParentEdit Then populateCombobox(9, cbx_osParentEdit, whitelist, exclude)
        If Not exclude Is cbx_osPlatformEdit Then populateCombobox(10, cbx_osPlatformEdit, whitelist, exclude)
        'If Not exclude Is cbx_osFileNameEdit Then populateCombobox(11, cbx_osFileNameEdit) 'This one doesn't exist
        If Not exclude Is cbx_osBootEdit Then populateCombobox(12, cbx_osBootEdit, whitelist, exclude)
        If Not exclude Is cbx_osTypeEdit Then populateCombobox(13, cbx_osTypeEdit, whitelist, exclude)

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With
    End Function

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

    Private Function populateCombobox(ByVal rowNumber As Integer, ByVal theCombobox As ComboBox, Optional whitelist As Array = Nothing, Optional excluded As ComboBox = Nothing)
        If whitelist Is Nothing Then
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
        Else
            If Not excluded Is cbx_osBoot Then cbx_osBoot.Items.Clear()
            If Not excluded Is cbx_osBootEdit Then cbx_osBootEdit.Items.Clear()
            If Not excluded Is cbx_osBuild Then cbx_osBuild.Items.Clear()
            If Not excluded Is cbx_osBuildEdit Then cbx_osBuildEdit.Items.Clear()
            If Not excluded Is cbx_osEdition Then cbx_osEdition.Items.Clear()
            If Not excluded Is cbx_osEditionEdit Then cbx_osEditionEdit.Items.Clear()
            If Not excluded Is cbx_osFileName Then cbx_osFileName.Items.Clear()
            If Not excluded Is cbx_osFormat Then cbx_osFormat.Items.Clear()
            If Not excluded Is cbx_osFormatEdit Then cbx_osFormatEdit.Items.Clear()
            If Not excluded Is cbx_osName Then cbx_osName.Items.Clear()
            If Not excluded Is cbx_osNameEdit Then cbx_osNameEdit.Items.Clear()
            If Not excluded Is cbx_osParent Then cbx_osParent.Items.Clear()
            If Not excluded Is cbx_osParentEdit Then cbx_osParentEdit.Items.Clear()
            If Not excluded Is cbx_osPlatform Then cbx_osPlatform.Items.Clear()
            If Not excluded Is cbx_osPlatformEdit Then cbx_osPlatformEdit.Items.Clear()
            If Not excluded Is cbx_osRAM Then cbx_osRAM.Items.Clear()
            If Not excluded Is cbx_osRamEdit Then cbx_osRamEdit.Items.Clear()
            If Not excluded Is cbx_osSize Then cbx_osSize.Items.Clear()
            If Not excluded Is cbx_osSizeEdit Then cbx_osSizeEdit.Items.Clear()
            If Not excluded Is cbx_osType Then cbx_osType.Items.Clear()
            If Not excluded Is cbx_osTypeEdit Then cbx_osTypeEdit.Items.Clear()
            If Not excluded Is cbx_osVariant Then cbx_osVariant.Items.Clear()
            If Not excluded Is cbx_osVariantEdit Then cbx_osVariantEdit.Items.Clear()
            If Not excluded Is cbx_osVersion Then cbx_osVersion.Items.Clear()
            If Not excluded Is cbx_osVersionEdit Then cbx_osVersionEdit.Items.Clear()

            Dim field As String

            If excluded Is cbx_osBoot Then field = "boot"
            If excluded Is cbx_osBuild Then field = "buildType"
            If excluded Is cbx_osBuildEdit Then field = "buildType"
            If excluded Is cbx_osEdition Then field = "edition"
            If excluded Is cbx_osEditionEdit Then field = "edition"
            If excluded Is cbx_osFileName Then field = "filename"
            If excluded Is cbx_osFormat Then field = "mediaFormat"
            If excluded Is cbx_osFormatEdit Then field = "mediaFormat"
            If excluded Is cbx_osName Then field = "friendlyName"
            If excluded Is cbx_osNameEdit Then field = "friendlyName"
            If excluded Is cbx_osParent Then field = "parent"
            If excluded Is cbx_osParentEdit Then field = "parent"
            If excluded Is cbx_osPlatform Then field = "platform"
            If excluded Is cbx_osPlatformEdit Then field = "platform"
            If excluded Is cbx_osRAM Then field = "ram"
            If excluded Is cbx_osRamEdit Then field = "ram"
            If excluded Is cbx_osSize Then field = "mediaSize"
            If excluded Is cbx_osSizeEdit Then field = "mediaSize"
            If excluded Is cbx_osType Then field = "mediaType"
            If excluded Is cbx_osTypeEdit Then field = "mediaType"
            If excluded Is cbx_osVariant Then field = "variant"
            If excluded Is cbx_osVariantEdit Then field = "variant"
            If excluded Is cbx_osVersion Then field = "version"
            If excluded Is cbx_osVersionEdit Then field = "version"



            Dim Table_ As String = "tbl_os"

            Dim query As String = "SELECT " & field & " FROM " & Table_

            'MsgBox(query)
        End If
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

    Dim stringToPrint As String 'this is what gets printed when u hit the button

    'TODO: Rename printDocument1 to something hungarian

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintDocument1.Print()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
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

    Private Function insertData()
        Dim x
        If newMedia Is Nothing Then
            x = ""
        Else
            x = newMedia.Name
        End If
        Dim Sqlstr = "INSERT INTO [tbl_os] ([parent], [variant], [edition], [platform]" &
                ", [ram], [boot], [version], [buildType], [friendlyName], " &
                "[mediaSize], [mediaFormat], [mediaType], [filename]) VALUES (@a, @b, @c, @d, @e, @f, @g, @h, @i, @k, @j @l, @m)"
        Dim Command = New OleDb.OleDbCommand(Sqlstr, DatabaseConnection)
        Command.CommandText = Sqlstr
        Command.Parameters.AddWithValue("@a", cbx_osParentEdit.SelectedValue)
        Command.Parameters.AddWithValue("@b", cbx_osVariantEdit.SelectedValue)
        Command.Parameters.AddWithValue("@c", cbx_osEditionEdit.SelectedValue)
        Command.Parameters.AddWithValue("@d", cbx_osPlatformEdit.SelectedValue)
        Command.Parameters.AddWithValue("@e", cbx_osRamEdit.SelectedValue)
        Command.Parameters.AddWithValue("@f", cbx_osBootEdit.SelectedValue)
        Command.Parameters.AddWithValue("@g", cbx_osVersionEdit.SelectedValue)
        Command.Parameters.AddWithValue("@h", cbx_osBuildEdit.SelectedValue)
        Command.Parameters.AddWithValue("@i", cbx_osNameEdit.SelectedValue)
        Command.Parameters.AddWithValue("@j", cbx_osSizeEdit.SelectedValue)
        Command.Parameters.AddWithValue("@k", cbx_osFormatEdit.SelectedValue)
        Command.Parameters.AddWithValue("@l", cbx_osTypeEdit.SelectedValue)
        Command.Parameters.AddWithValue("@m", x)
        Command.ExecuteNonQuery()
    End Function

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        insertData()
    End Sub
End Class

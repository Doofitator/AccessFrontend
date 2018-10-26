Module Database_Controls
    Dim DatabaseConnection = New OleDb.OleDbConnection
    Public newMedia As System.IO.FileInfo = Nothing



    Public Function populateCombobox(ByVal rowNumber As Integer, ByVal theCombobox As ComboBox, Optional whitelist As Array = Nothing, Optional excluded As ComboBox = Nothing, Optional isConnected As Boolean = False)

        If Not isConnected Then
            DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text

            With frm_main
                .Cursor = Cursors.WaitCursor
                .Refresh()
            End With
            DatabaseConnection.Open()
        End If
        frm_main.tssl_databaseStatus.Text = "Connected to database. Please wait for data to populate..."
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
            If Not excluded Is frm_main.cbx_osBoot Then frm_main.cbx_osBoot.Items.Clear()
            If Not excluded Is frm_main.cbx_osBootEdit Then frm_main.cbx_osBootEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osBuild Then frm_main.cbx_osBuild.Items.Clear()
            If Not excluded Is frm_main.cbx_osBuildEdit Then frm_main.cbx_osBuildEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osEdition Then frm_main.cbx_osEdition.Items.Clear()
            If Not excluded Is frm_main.cbx_osEditionEdit Then frm_main.cbx_osEditionEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osFileName Then frm_main.cbx_osFileName.Items.Clear()
            If Not excluded Is frm_main.cbx_osFormat Then frm_main.cbx_osFormat.Items.Clear()
            If Not excluded Is frm_main.cbx_osFormatEdit Then frm_main.cbx_osFormatEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osName Then frm_main.cbx_osName.Items.Clear()
            If Not excluded Is frm_main.cbx_osNameEdit Then frm_main.cbx_osNameEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osParent Then frm_main.cbx_osParent.Items.Clear()
            If Not excluded Is frm_main.cbx_osParentEdit Then frm_main.cbx_osParentEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osPlatform Then frm_main.cbx_osPlatform.Items.Clear()
            If Not excluded Is frm_main.cbx_osPlatformEdit Then frm_main.cbx_osPlatformEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osRAM Then frm_main.cbx_osRAM.Items.Clear()
            If Not excluded Is frm_main.cbx_osRamEdit Then frm_main.cbx_osRamEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osSize Then frm_main.cbx_osSize.Items.Clear()
            If Not excluded Is frm_main.cbx_osSizeEdit Then frm_main.cbx_osSizeEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osType Then frm_main.cbx_osType.Items.Clear()
            If Not excluded Is frm_main.cbx_osTypeEdit Then frm_main.cbx_osTypeEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osVariant Then frm_main.cbx_osVariant.Items.Clear()
            If Not excluded Is frm_main.cbx_osVariantEdit Then frm_main.cbx_osVariantEdit.Items.Clear()
            If Not excluded Is frm_main.cbx_osVersion Then frm_main.cbx_osVersion.Items.Clear()
            If Not excluded Is frm_main.cbx_osVersionEdit Then frm_main.cbx_osVersionEdit.Items.Clear()

            Dim field As String

            If excluded Is frm_main.cbx_osBoot Then field = "boot"
            If excluded Is frm_main.cbx_osBuild Then field = "buildType"
            If excluded Is frm_main.cbx_osBuildEdit Then field = "buildType"
            If excluded Is frm_main.cbx_osEdition Then field = "edition"
            If excluded Is frm_main.cbx_osEditionEdit Then field = "edition"
            If excluded Is frm_main.cbx_osFileName Then field = "filename"
            If excluded Is frm_main.cbx_osFormat Then field = "mediaFormat"
            If excluded Is frm_main.cbx_osFormatEdit Then field = "mediaFormat"
            If excluded Is frm_main.cbx_osName Then field = "friendlyName"
            If excluded Is frm_main.cbx_osNameEdit Then field = "friendlyName"
            If excluded Is frm_main.cbx_osParent Then field = "parent"
            If excluded Is frm_main.cbx_osParentEdit Then field = "parent"
            If excluded Is frm_main.cbx_osPlatform Then field = "platform"
            If excluded Is frm_main.cbx_osPlatformEdit Then field = "platform"
            If excluded Is frm_main.cbx_osRAM Then field = "ram"
            If excluded Is frm_main.cbx_osRamEdit Then field = "ram"
            If excluded Is frm_main.cbx_osSize Then field = "mediaSize"
            If excluded Is frm_main.cbx_osSizeEdit Then field = "mediaSize"
            If excluded Is frm_main.cbx_osType Then field = "mediaType"
            If excluded Is frm_main.cbx_osTypeEdit Then field = "mediaType"
            If excluded Is frm_main.cbx_osVariant Then field = "variant"
            If excluded Is frm_main.cbx_osVariantEdit Then field = "variant"
            If excluded Is frm_main.cbx_osVersion Then field = "version"
            If excluded Is frm_main.cbx_osVersionEdit Then field = "version"



            Dim Table_ As String = "tbl_os"

            Dim query As String = "SELECT " & field & " FROM " & Table_

            'MsgBox(query)
        End If
        DatabaseConnection.Close()
        With frm_main
            .Cursor = Cursors.Default
            .Refresh()
        End With
    End Function

    Public Function insertData()
        DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text
        With frm_main
            .Cursor = Cursors.WaitCursor
            .tssl_databaseStatus.Text = "Please wait...Connecting to database"
            .Refresh()
        End With
        DatabaseConnection.Open()
        frm_main.tssl_databaseStatus.Text = "Connected to database. Please wait for data to be uploaded..."
        Dim x
        If newMedia Is Nothing Then
            x = ""
        Else
            x = newMedia.Name
        End If
        Dim Sqlstr = "INSERT INTO [tbl_os] ([parent], [variant], [edition], [platform], [ram], [boot], [version], [buildType], [friendlyName], [mediaSize], [mediaFormat], [mediaType], [filename]) VALUES (@a, @b, @c, @d, @e, @f, @g, @h, @i, @k, @j, @l, @m)"

        Dim Command = New OleDb.OleDbCommand(Sqlstr, DatabaseConnection)
        Command.CommandText = Sqlstr
        Command.Parameters.AddWithValue("@a", frm_main.cbx_osParentEdit.SelectedItem)
        Command.Parameters.AddWithValue("@b", frm_main.cbx_osVariantEdit.SelectedItem)
        Command.Parameters.AddWithValue("@c", frm_main.cbx_osEditionEdit.SelectedItem)
        Command.Parameters.AddWithValue("@d", frm_main.cbx_osPlatformEdit.SelectedItem)
        Command.Parameters.AddWithValue("@e", frm_main.cbx_osRamEdit.SelectedItem)
        Command.Parameters.AddWithValue("@f", frm_main.cbx_osBootEdit.SelectedItem)
        Command.Parameters.AddWithValue("@g", frm_main.cbx_osVersionEdit.SelectedItem)
        Command.Parameters.AddWithValue("@h", frm_main.cbx_osBuildEdit.SelectedItem)
        Command.Parameters.AddWithValue("@i", frm_main.cbx_osNameEdit.SelectedItem)
        Command.Parameters.AddWithValue("@j", frm_main.cbx_osSizeEdit.SelectedItem)
        Command.Parameters.AddWithValue("@k", frm_main.cbx_osFormatEdit.SelectedItem)
        Command.Parameters.AddWithValue("@l", frm_main.cbx_osTypeEdit.SelectedItem)
        Command.Parameters.AddWithValue("@m", x)
        Command.ExecuteNonQuery()
        frm_main.populateComboBoxes(, , True)
        frm_main.tssl_databaseStatus.Text = "Disconnecting..."
        DatabaseConnection.close()
        With frm_main
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Completed upload and repopulation. Disconnected."
            .Refresh()
        End With
    End Function
End Module

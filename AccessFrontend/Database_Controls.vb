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

            Dim field As String = "*"

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
            DatabaseConnection.close()

            'TODO: Somehow get all the arr_mediaType, arr_etc. from getRecordByField and for each string in each array, add it to it's respective combobox.


        End If
        Try
            DatabaseConnection.Close()
        Catch
            Console.WriteLine("already closed")
        End Try
        With frm_main
            .Cursor = Cursors.Default
            .Refresh()
        End With
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

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
        populateComboBoxes(, , True)
        frm_main.tssl_databaseStatus.Text = "Disconnecting..."
        DatabaseConnection.close()
        With frm_main
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Completed upload and repopulation. Disconnected."
            .Refresh()
        End With
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getRecordByField(ByVal field As String, ByVal value As String, ByVal Table As String) 'returns array of all records that match criteria
        'SELECT * FROM tbl_os WHERE tbl_os.parent = "Unix";
        DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text
        DatabaseConnection.Open()
        Dim t As New DataTable
        Dim adapter As OleDb.OleDbDataAdapter()
        Dim cmd As OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader

        Dim sql = "SELECT * FROM " & Table & " WHERE " & Table & "." & field & " = '" & value & "'"
        Dim lst_ID As List(Of Integer) = New List(Of Integer)()
        Dim lst_variant As List(Of String) = New List(Of String)()
        Dim lst_version As List(Of String) = New List(Of String)()
        Dim lst_edition As List(Of String) = New List(Of String)()
        Dim lst_friendlyName As List(Of String) = New List(Of String)()
        Dim lst_ram As List(Of String) = New List(Of String)()
        Dim lst_mediaSize As List(Of String) = New List(Of String)()
        Dim lst_mediaFormat As List(Of String) = New List(Of String)()
        Dim lst_buildType As List(Of String) = New List(Of String)()
        Dim lst_parent As List(Of String) = New List(Of String)()
        Dim lst_platform As List(Of String) = New List(Of String)()
        Dim lst_filename As List(Of String) = New List(Of String)()
        Dim lst_boot As List(Of String) = New List(Of String)()
        Dim lst_mediaType As List(Of String) = New List(Of String)()
        Try
            cmd = New OleDb.OleDbCommand(sql, DatabaseConnection)
            reader = cmd.ExecuteReader()
            While (reader.Read())
                lst_ID.Add(reader.GetInt32(0))
                lst_variant.Add(reader.GetString(1))
                lst_version.Add(reader.GetString(2))
                lst_edition.Add(reader.GetString(3))
                lst_friendlyName.Add(reader.GetString(4))
                lst_ram.Add(reader.GetString(5))
                lst_mediaSize.Add(reader.GetString(6))
                lst_mediaFormat.Add(reader.GetString(7))
                lst_buildType.Add(reader.GetString(8))
                lst_parent.Add(reader.GetString(9))
                lst_platform.Add(reader.GetString(10))
                lst_filename.Add(reader.GetString(11))
                lst_boot.Add(reader.GetString(12))
                lst_mediaType.Add(reader.GetString(13))
            End While
            reader.Close()
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        DatabaseConnection.close()
        Dim arr_ID As Array = lst_ID.ToArray()
        Dim arr_variant As Array = lst_variant.ToArray()
        Dim arr_version As Array = lst_version.ToArray()
        Dim arr_edition As Array = lst_edition.ToArray()
        Dim arr_friendlyName As Array = lst_friendlyName.ToArray()
        Dim arr_ram As Array = lst_ram.ToArray()
        Dim arr_mediaSize As Array = lst_mediaSize.ToArray()
        Dim arr_mediaFormat As Array = lst_mediaFormat.ToArray()
        Dim arr_buildType As Array = lst_buildType.ToArray()
        Dim arr_parent As Array = lst_parent.ToArray()
        Dim arr_platform As Array = lst_platform.ToArray()
        Dim arr_filename As Array = lst_filename.ToArray()
        Dim arr_boot As Array = lst_boot.ToArray()
        Dim arr_mediatype As Array = lst_mediaType.ToArray()

        Dim records(arr_ID.Length) As String 'Each value is a csv - "ID,variant,version,edition,friendlyname,ram,mediasize,mediaformat,buildtype,parent,platform,filename,boot,mediatype"

        Dim i = arr_ID.Length - 1
        While i >= 0
            records(i) = arr_ID(i) & "," & arr_variant(i) & "," & arr_version(i) & "," & arr_edition(i) & "," & arr_friendlyName(i) & "," & arr_ram(i) & "," & arr_mediaSize(i) & "," & arr_mediaFormat(i) & "," & arr_buildType(i) & "," & arr_parent(i) & "," & arr_platform(i) & "," & arr_filename(i) & "," & arr_boot(i) & "," & arr_mediatype(i)
            i -= 1
        End While

        Return records
    End Function
End Module

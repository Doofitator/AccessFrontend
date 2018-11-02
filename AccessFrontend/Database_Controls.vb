Module Database_Controls
    Public DatabaseConnection = New OleDb.OleDbConnection
    Public newMedia As System.IO.FileInfo = Nothing



    Public Function populateCombobox(ByVal rowNumber As Integer, ByVal theCombobox As ComboBox, Optional isConnected As Boolean = False)

        If Not isConnected Then
            DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text

            With frm_main
                .Cursor = Cursors.WaitCursor
                .Refresh()
            End With
            DatabaseConnection.Open()
            Console.WriteLine("Opened Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If
        frm_main.tssl_databaseStatus.Text = "Connected to database. Please wait for data to populate..."

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
            Item(0) = row(rowNumber)
            Dim NextListItem As New ListViewItem(Item)
            If Not theCombobox.Items.Contains(NextListItem.Text) Then
                theCombobox.Items.Add(NextListItem.Text)
            End If
        Next

        If Not isConnected Then

            DatabaseConnection.Close()
            Console.WriteLine("Closed Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If



        With frm_main
            .Cursor = Cursors.Default
            .Refresh()
        End With
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function populateComboBoxesWithNoWhitelist(ByVal excluded As ComboBox)

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

        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "variant", True)
            If Not frm_main.cbx_osVariant.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osVariant.Items.Add(record)
        Next
        'Console.WriteLine(1)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "version", True)
            If Not frm_main.cbx_osVersion.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osVersion.Items.Add(record)
        Next
        'Console.WriteLine(2)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "edition", True)
            If Not frm_main.cbx_osEdition.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osEdition.Items.Add(record)
        Next
        'Console.WriteLine(3)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "friendlyName", True)
            If Not frm_main.cbx_osName.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osName.Items.Add(record)
        Next
        'Console.WriteLine(4)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "ram", True)
            If Not frm_main.cbx_osRAM.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osRAM.Items.Add(record)
        Next
        'Console.WriteLine(5)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "mediaSize", True)
            If Not frm_main.cbx_osSize.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osSize.Items.Add(record)
        Next
        'Console.WriteLine(6)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "mediaFormat", True)
            If Not frm_main.cbx_osFormat.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osFormat.Items.Add(record)
        Next
        'Console.WriteLine(7)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "buildType", True)
            If Not frm_main.cbx_osBuild.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osBuild.Items.Add(record)
        Next
        'Console.WriteLine(8)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "parent", True)
            If Not frm_main.cbx_osParent.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osParent.Items.Add(record)
        Next
        'Console.WriteLine(9)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "platform", True)
            If Not frm_main.cbx_osPlatform.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osPlatform.Items.Add(record)
        Next
        'Console.WriteLine(10)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "filename", True)
            If Not frm_main.cbx_osFileName.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osFileName.Items.Add(record)
        Next
        '  Console.WriteLine(11)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "boot", True)
            If Not frm_main.cbx_osBoot.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osBoot.Items.Add(record)
        Next
        '  Console.WriteLine(12)
        For Each record As String In getRecordByFieldAsField(field, excluded.Text, "tbl_os", "mediaType", True)
            If Not frm_main.cbx_osType.Items.Contains(record) Then If passesWhiteList(record) Then frm_main.cbx_osType.Items.Add(record)
        Next
        '   Console.WriteLine(13)

        'TODO: Make this for edit page
        'TODO: With the test data unix, rhapsody, version 4.3, I was getting android 4.3 results. Why? <-- put that in testing table, too.
        'TODO: In regards to the above line, it's because I'm not using the whitelist var I made. Gotta do something about that.

    End Function

    Public Function insertData()
        DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text
        With frm_main
            .Cursor = Cursors.WaitCursor
            .tssl_databaseStatus.Text = "Please wait...Connecting to database"
            .Refresh()
        End With
        DatabaseConnection.Open()
        Console.WriteLine("Opened Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())

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
        DatabaseConnection.Close()
        Console.WriteLine("Closed Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())

        With frm_main
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Completed upload and repopulation. Disconnected."
            .Refresh()
        End With
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getRecordByField(ByVal field As String, ByVal value As String, ByVal Table As String, Optional isconnected As Boolean = False) 'returns array of all records that match criteria
        'SELECT * FROM tbl_os WHERE tbl_os.parent = "Unix";
        If Not isconnected Then
            DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text
            DatabaseConnection.Open()
            Console.WriteLine("Opened Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If
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

        If Not isconnected Then
            DatabaseConnection.Close()
            Console.WriteLine("Closed Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If
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

    Public Function getRecordByFieldAsField(ByVal field As String, ByVal value As String, ByVal Table As String, ByVal fieldToReturn As String, Optional isconnected As Boolean = False) 'returns array of all records that match criteria
        'SELECT * FROM tbl_os WHERE tbl_os.parent = "Unix";
        If Not isconnected Then
            DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text
            DatabaseConnection.Open()
            Console.WriteLine("Opened Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If
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
        If Not isconnected Then
            DatabaseConnection.Close()
            Console.WriteLine("Closed Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())
        End If
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

        If fieldToReturn = "ID" Then Return arr_ID
        If fieldToReturn = "variant" Then Return arr_variant
        If fieldToReturn = "version" Then Return arr_version
        If fieldToReturn = "edition" Then Return arr_edition
        If fieldToReturn = "friendlyName" Then Return arr_friendlyName
        If fieldToReturn = "ram" Then Return arr_ram
        If fieldToReturn = "mediaSize" Then Return arr_mediaSize
        If fieldToReturn = "mediaFormat" Then Return arr_mediaFormat
        If fieldToReturn = "buildType" Then Return arr_buildType
        If fieldToReturn = "parent" Then Return arr_parent
        If fieldToReturn = "platform" Then Return arr_platform
        If fieldToReturn = "filename" Then Return arr_filename
        If fieldToReturn = "boot" Then Return arr_boot
        If fieldToReturn = "mediaType" Then Return arr_mediatype

    End Function
    Dim selections As String = ""
    Function passesWhiteList(ByVal whatTheProgramWantsToPutInToTheCombobox As String) As Boolean

        'for every possible record
        'for every selected value
        'dim x
        'if we split the record by ","
        'for every split bit
        'if it equals the selected value
        'x += 1
        'next
        'next
        'if x = selectedvalues.len
        'pass
        'else fail
        'next
        Dim ToReturn = False


        For Each cbx As ComboBox In frm_main.tpg_read.Controls.OfType(Of ComboBox)
            If Not cbx.SelectedItem = "" Or Nothing Then

                If Not selections.Contains(cbx.SelectedItem) Then selections += cbx.SelectedItem & " "
            End If
        Next

        Dim allCurrentSelectedItems As Array = selections.Split(" ")

        Dim fields As String = "Variant,Version,edition,friendlyName,ram,mediaSize,mediaFormat,buildType,parent,platform,filename,boot,mediaType"
        Dim arr_fields As Array = fields.Split(",")
        For Each field As String In arr_fields
            'Console.WriteLine(field)
            For Each record As String In getRecordByField(field, whatTheProgramWantsToPutInToTheCombobox, "tbl_os", True)
                Dim i As Integer = 0
                If Not record Is Nothing Then
                    Dim arr_recordFields As Array = record.Split(",")
                    For Each selection As String In allCurrentSelectedItems
                        For Each recordField As String In arr_recordFields
                            If recordField = selection Then
                                Console.WriteLine(recordField & " = " & selection)
                                Console.WriteLine(record)
                                i += 1
                            End If
                        Next
                    Next
                Else
                    'Console.WriteLine("Record is nothing.")
                    ToReturn = True
                End If
                If i = allCurrentSelectedItems.Length Then
                    ToReturn = True
                End If
            Next
        Next
        Return ToReturn
    End Function
End Module

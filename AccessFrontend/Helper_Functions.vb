﻿Module Helper_Functions
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

    Function CheckIfOneRecord()
        Dim specString As String = ""
        If frm_main.cbx_osFileName.Items.Count = 1 Then
            Dim y = getRecordByField("filename", frm_main.cbx_osFileName.Items(0).ToString, "tbl_os")
            Dim x = y(0).split(",")
            'specString = variant & " - " & friendlyname & vbcrlf & "Parent: " & Parent & vbcrlf & "Edition: " & Edition & vbcrlf & "Version: " & Version & vbcrlf & so on & so forth
            specString = x(1) & "   -   " & x(4) & vbCrLf & "Parent: " & x(9) & vbCrLf & "Edition: " & x(3) & vbCrLf & "Version: " & x(2) & vbCrLf & "Minimum RAM (megabytes): " & x(5) & vbCrLf & "Media format: " & x(7) & vbCrLf & "Media type: " & x(13) & vbCrLf & "Media size: " & x(6) & vbCrLf & "Build type: " & x(8) & vbCrLf & "Boot / BIOS type: " & x(12) & vbCrLf & "Platform: " & x(10) & vbCrLf & vbCrLf & "Filename: " & x(11) & "." & x(7)



        ElseIf Not frm_main.cbx_osFileName.SelectedItem = "" Then
            Dim y = getRecordByField("filename", frm_main.cbx_osFileName.SelectedItem, "tbl_os")
            Dim x = y(0).split(",")
            'specString = variant & " - " & friendlyname & vbcrlf & "Parent: " & Parent & vbcrlf & "Edition: " & Edition & vbcrlf & "Version: " & Version & vbcrlf & so on & so forth
            specString = x(1) & "   -   " & x(4) & vbCrLf & "Parent: " & x(9) & vbCrLf & "Edition: " & x(3) & vbCrLf & "Version: " & x(2) & vbCrLf & "Minimum RAM (megabytes): " & x(5) & vbCrLf & "Media format: " & x(7) & vbCrLf & "Media type: " & x(13) & vbCrLf & "Media size: " & x(6) & vbCrLf & "Build type: " & x(8) & vbCrLf & "Boot / BIOS type: " & x(12) & vbCrLf & "Platform: " & x(10) & vbCrLf & vbCrLf & "Filename: " & x(11) & "." & x(7)
        End If

        frm_main.txt_specs.Text = specString
    End Function

    Function getStringOfAllAvails() As String
        Dim specString

        For Each filename In frm_main.cbx_osFileName.Items
            Dim y = getRecordByField("filename", filename, "tbl_os")
            For Each z As String In y
                If z = Nothing Then GoTo future
                Dim x = z.Split(",")
                specString += x(1) & "   -   " & x(4) & vbCrLf & "Parent: " & x(9) & vbCrLf & "Edition: " & x(3) & vbCrLf & "Version: " & x(2) & vbCrLf & "Minimum RAM (megabytes): " & x(5) & vbCrLf & "Media format: " & x(7) & vbCrLf & "Media type: " & x(13) & vbCrLf & "Media size: " & x(6) & vbCrLf & "Build type: " & x(8) & vbCrLf & "Boot / BIOS type: " & x(12) & vbCrLf & "Platform: " & x(10) & vbCrLf & "Filename: " & x(11) & "." & x(7) & vbCrLf & vbCrLf & "-------------" & vbCrLf & vbCrLf
future:
            Next
        Next
        Return specString
    End Function

    Function populateComboBoxes(Optional whitelist As Array = Nothing, Optional exclude As ComboBox = Nothing, Optional isconnected As Boolean = False, Optional isItReallyThough As Boolean = False)

        If Not isconnected Then
            DatabaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & frm_main.txt_filename.Text

            With frm_main
                .Cursor = Cursors.WaitCursor
                .Refresh()
            End With

            DatabaseConnection.Open()
            Console.WriteLine("Opened Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())

        End If

        If whitelist Is Nothing Then
            'If the combobox that was just edited is not x, then repopulate x with new whitelists and stuff
            If Not exclude Is frm_main.cbx_osVariant Then populateCombobox(1, frm_main.cbx_osVariant, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osVersion Then populateCombobox(2, frm_main.cbx_osVersion, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osEdition Then populateCombobox(3, frm_main.cbx_osEdition, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osName Then populateCombobox(4, frm_main.cbx_osName, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osRAM Then populateCombobox(5, frm_main.cbx_osRAM, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osSize Then populateCombobox(6, frm_main.cbx_osSize, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osFormat Then populateCombobox(7, frm_main.cbx_osFormat, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osBuild Then populateCombobox(8, frm_main.cbx_osBuild, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osParent Then populateCombobox(9, frm_main.cbx_osParent, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osPlatform Then populateCombobox(10, frm_main.cbx_osPlatform, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osFileName Then populateCombobox(11, frm_main.cbx_osFileName, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osBoot Then populateCombobox(12, frm_main.cbx_osBoot, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osType Then populateCombobox(13, frm_main.cbx_osType, Not (isconnected), isItReallyThough)

            'Now we'll populate the comboboxes on the edit page, too.

            If Not exclude Is frm_main.cbx_osVariantEdit Then populateCombobox(1, frm_main.cbx_osVariantEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osVersionEdit Then populateCombobox(2, frm_main.cbx_osVersionEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osEditionEdit Then populateCombobox(3, frm_main.cbx_osEditionEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osNameEdit Then populateCombobox(4, frm_main.cbx_osNameEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osRamEdit Then populateCombobox(5, frm_main.cbx_osRamEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osSizeEdit Then populateCombobox(6, frm_main.cbx_osSizeEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osFormatEdit Then populateCombobox(7, frm_main.cbx_osFormatEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osBuildEdit Then populateCombobox(8, frm_main.cbx_osBuildEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osParentEdit Then populateCombobox(9, frm_main.cbx_osParentEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osPlatformEdit Then populateCombobox(10, frm_main.cbx_osPlatformEdit, Not (isconnected), isItReallyThough)
            'If Not exclude Is frm_main.cbx_osFileNameEdit Then populateCombobox(11, frm_main.cbx_osFileNameEdit) 'This one doesn't exist
            If Not exclude Is frm_main.cbx_osBootEdit Then populateCombobox(12, frm_main.cbx_osBootEdit, Not (isconnected), isItReallyThough)
            If Not exclude Is frm_main.cbx_osTypeEdit Then populateCombobox(13, frm_main.cbx_osTypeEdit, Not (isconnected), isItReallyThough)
        Else
            populateComboBoxesWithNoWhitelist(exclude)
        End If
        With frm_main
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Data populated. Disconnected."
            .Refresh()
        End With
        Try
            If Not isconnected Then DatabaseConnection.Close()
            Console.WriteLine("Closed Connection {0}", (New StackTrace(New StackFrame(True))).GetFrame(0).GetFileLineNumber())

        Catch
            Console.WriteLine("already closed")
        End Try

        For Each cbx As ComboBox In frm_main.tpg_edit.Controls.OfType(Of ComboBox)
            cbx.Items.Add("Add new...")
        Next
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Public Function resizeControlsGroupboxContent(ByVal isReadPage As Boolean)
        Try
            If isReadPage Then
                If frm_main.tab_controls.Height > 370 Then
                    frm_main.tab_results.Width = frm_main.tab_controls.Width - 30
                    frm_main.tab_results.Left = 10
                    frm_main.tab_results.Top = 231
                    frm_main.tab_results.Height = frm_main.tab_controls.Height - 276
                    frm_main.lbl_resultsHint.Top = 210
                    frm_main.lbl_resultsHint.Left = 10
                Else
                    frm_main.tab_results.Left = 551
                    frm_main.tab_results.Width = frm_main.tab_controls.Width - frm_main.lbl_osParent.Width - frm_main.lbl_osBoot.Width - frm_main.cbx_osBoot.Width - frm_main.cbx_osParent.Width - 250
                    frm_main.tab_results.Top = 38
                    frm_main.tab_results.Height = 137
                    frm_main.lbl_resultsHint.Left = 551
                    frm_main.lbl_resultsHint.Top = 7
                End If


                frm_main.txt_specs.Width = frm_main.tpg_specs.Width - 14
                frm_main.txt_specs.Height = frm_main.tpg_specs.Height - 14
            Else
                If frm_main.tab_controls.Height > 370 Then
                    frm_main.tab_ExtrasEdit.Width = frm_main.tab_controls.Width - 30
                    frm_main.tab_ExtrasEdit.Left = 10
                    frm_main.tab_ExtrasEdit.Top = 201
                    frm_main.tab_ExtrasEdit.Height = frm_main.tpg_edit.Height - 249
                Else
                    frm_main.tab_ExtrasEdit.Left = 374
                    frm_main.tab_ExtrasEdit.Width = frm_main.tab_controls.Width - frm_main.lbl_osParentEdit.Width - frm_main.lbl_osBootEdit.Width - frm_main.cbx_osBootEdit.Width - frm_main.cbx_osParentEdit.Width - 70
                    frm_main.tab_ExtrasEdit.Top = 12
                    frm_main.tab_ExtrasEdit.Height = 137
                End If


                frm_main.btn_Save.Left = frm_main.tpg_edit.Width - frm_main.btn_Save.Width - 10
                frm_main.btn_Save.Top = frm_main.tab_ExtrasEdit.Height + frm_main.tab_ExtrasEdit.Top + 10
            End If

            Return True
        Catch
            Return False
            MsgBox("Resize error. Please try again.", vbInformation + vbOKOnly, "Whoops")
        End Try
    End Function

    Public Function populateComboBoxWithManualData(ByVal data As Array, ByVal cbx As ComboBox)
        For Each dataPoint In data
            cbx.SelectedIndex = cbx.Items.IndexOf(dataPoint)
        Next
    End Function
End Module

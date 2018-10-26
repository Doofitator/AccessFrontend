Module Helper_Functions
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

    Public Function NarrowResultsAndRePopulate(ByVal field As String)
        Select Case field
            Case "parent"

            Case "variant"

            Case "edition"

            Case "platform"

            Case "ram"

            Case "boot"

            Case "version"

            Case "build"

            Case "name"

            Case "size"

            Case "format"

            Case "type"

            Case "filename"

            Case Else
                MsgBox("Fatal Error: Cannot narrow down fields", vbAbort + vbOKOnly, "Error")
                End
        End Select

    End Function

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

                frm_main.txt_Features.Height = frm_main.tpg_Features.Height - 14
                frm_main.txt_Notes.Height = frm_main.tpg_Notes.Height - 14
                frm_main.txt_Features.Width = frm_main.tpg_Features.Width - 14
                frm_main.txt_Notes.Width = frm_main.tpg_Features.Width - 14
                frm_main.txt_specs.Width = frm_main.tpg_Features.Width - 14
                frm_main.txt_specs.Height = frm_main.tpg_Features.Height - 14
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

                frm_main.txt_FeaturesEdit.Height = frm_main.tpg_FeaturesEdit.Height - 14
                frm_main.txt_NotesEdit.Height = frm_main.tpg_notesEdit.Height - 14
                frm_main.txt_FeaturesEdit.Width = frm_main.tpg_FeaturesEdit.Width - 14
                frm_main.txt_NotesEdit.Width = frm_main.tpg_FeaturesEdit.Width - 14
                frm_main.btn_Save.Left = frm_main.tpg_edit.Width - frm_main.btn_Save.Width - 10
                frm_main.btn_Save.Top = frm_main.tab_ExtrasEdit.Height + frm_main.tab_ExtrasEdit.Top + 10
            End If

            Return True
        Catch
            Return False
            MsgBox("Resize error. Please try again.", vbInformation + vbOKOnly, "Whoops")
        End Try
    End Function
End Module

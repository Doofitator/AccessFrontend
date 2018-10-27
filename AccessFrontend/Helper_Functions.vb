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

    Function populateComboBoxes(Optional whitelist As Array = Nothing, Optional exclude As ComboBox = Nothing, Optional isconnected As Boolean = False)
        With frm_main
            .Cursor = Cursors.WaitCursor
            .Refresh()
        End With


        'If the combobox that was just edited is not x, then repopulate x with new whitelists and stuff
        If Not exclude Is frm_main.cbx_osVariant Then populateCombobox(1, frm_main.cbx_osVariant, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osVersion Then populateCombobox(2, frm_main.cbx_osVersion, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osEdition Then populateCombobox(3, frm_main.cbx_osEdition, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osName Then populateCombobox(4, frm_main.cbx_osName, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osRAM Then populateCombobox(5, frm_main.cbx_osRAM, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osSize Then populateCombobox(6, frm_main.cbx_osSize, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osFormat Then populateCombobox(7, frm_main.cbx_osFormat, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osBuild Then populateCombobox(8, frm_main.cbx_osBuild, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osParent Then populateCombobox(9, frm_main.cbx_osParent, whitelist, exclude, isconnected)     'No idea why the order is like this. Not like
        If Not exclude Is frm_main.cbx_osPlatform Then populateCombobox(10, frm_main.cbx_osPlatform, whitelist, exclude, isconnected)  'it's alphabetical or anything. Just is this way :/
        If Not exclude Is frm_main.cbx_osFileName Then populateCombobox(11, frm_main.cbx_osFileName, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osBoot Then populateCombobox(12, frm_main.cbx_osBoot, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osType Then populateCombobox(13, frm_main.cbx_osType, whitelist, exclude, isconnected)

        'Now we'll populate the comboboxes on the edit page, too.

        If Not exclude Is frm_main.cbx_osVariantEdit Then populateCombobox(1, frm_main.cbx_osVariantEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osVersionEdit Then populateCombobox(2, frm_main.cbx_osVersionEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osEditionEdit Then populateCombobox(3, frm_main.cbx_osEditionEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osNameEdit Then populateCombobox(4, frm_main.cbx_osNameEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osRamEdit Then populateCombobox(5, frm_main.cbx_osRamEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osSizeEdit Then populateCombobox(6, frm_main.cbx_osSizeEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osFormatEdit Then populateCombobox(7, frm_main.cbx_osFormatEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osBuildEdit Then populateCombobox(8, frm_main.cbx_osBuildEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osParentEdit Then populateCombobox(9, frm_main.cbx_osParentEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osPlatformEdit Then populateCombobox(10, frm_main.cbx_osPlatformEdit, whitelist, exclude, isconnected)
        'If Not exclude Is frm_main.cbx_osFileNameEdit Then populateCombobox(11, frm_main.cbx_osFileNameEdit) 'This one doesn't exist
        If Not exclude Is frm_main.cbx_osBootEdit Then populateCombobox(12, frm_main.cbx_osBootEdit, whitelist, exclude, isconnected)
        If Not exclude Is frm_main.cbx_osTypeEdit Then populateCombobox(13, frm_main.cbx_osTypeEdit, whitelist, exclude, isconnected)

        With frm_main
            .Cursor = Cursors.Default
            .tssl_databaseStatus.Text = "Data populated. Disconnected."
            .Refresh()
        End With
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

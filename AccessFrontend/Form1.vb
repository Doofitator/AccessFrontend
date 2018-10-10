Public Class frm_main
    Private Sub frm_main_resize() Handles MyBase.Resize
        'grp_connect.Height = (0.2056 * Me.Height)
        grp_connect.Width = Me.Width - 40
        grp_control.Top = grp_connect.Top + grp_connect.Height
        grp_control.Height = Me.Height - 20 - grp_connect.Height - 40
        grp_control.Width = Me.Width - 40

        btn_connect.Left = grp_connect.Width - btn_connect.Width - 5
        btn_openOFD.Left = grp_connect.Width - btn_openOFD.Width - 5
        txt_filename.Width = grp_connect.Width - btn_openOFD.Width - 5 - lbl_hint1.Width - 7 - 5

        tab_controls.Width = grp_control.Width - 20
        tab_controls.Left = 10
        tab_controls.Height = grp_control.Height - 30
        tab_controls.Top = 20


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

    End Sub

    Private Sub ofd_database_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_database.FileOk
        txt_filename.Text = ofd_database.FileName
    End Sub

    Private Sub btn_openOFD_Click(sender As Object, e As EventArgs) Handles btn_openOFD.Click
        ofd_database.ShowDialog()
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        grp_control.Enabled = True
        tab_controls.Enabled = True
        tab_results.Enabled = True
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
    End Sub
End Class

Imports xDoof.System.Hooking

Public Class Form1

    Private WithEvents kbHook As New xDoof.System.Hooking.KeyboardHook
    Private Protected WithEvents MyMouseHook As xDoof.System.Hooking.MouseHook
    Dim ColorToSet As Color = Color.Green
    Dim ColorReset As Color = Color.White

    Dim XXX, YYY As Integer
    Dim NewPoint As New Point
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() : MyMouseHook = New xDoof.System.Hooking.MouseHook
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If Key.ToString() = "Escape" Then
            Escape.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F1" Then
            F1.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F2" Then
            F2.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F3" Then
            F3.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F4" Then
            F4.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F5" Then
            F5.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F6" Then
            F6.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F7" Then
            F7.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F8" Then
            F8.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F9" Then
            F9.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F10" Then
            F10.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F11" Then
            F11.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F12" Then
            F12.ForeColor = ColorToSet
        ElseIf Key.ToString() = "PrintScreen" Then
            PrintScreen.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Scroll" Then
            Scroll.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Pause" Then
            Pause.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oem7" Then
            Oem7.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D0" Then
            D0.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D1" Then
            D1.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D2" Then
            D2.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D3" Then
            D3.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D4" Then
            D4.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D5" Then
            D5.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D6" Then
            D6.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D7" Then
            D7.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D8" Then
            D8.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D9" Then
            D9.ForeColor = ColorToSet
        ElseIf Key.ToString() = "OemOpenBrackets" Then
            OemOpenBrackets.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oemplus" Then
            Oemplus.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Back" Then
            Back.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Insert" Then
            Insert.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Home" Then
            Home.ForeColor = ColorToSet
        ElseIf Key.ToString() = "PageUp" Then
            PageUp.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumLock" Then
            NumLock.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Divide" Then
            Divide.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Multiply" Then
            Multiply.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Subtract" Then
            Subtract.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Tab" Then
            Tab.ForeColor = ColorToSet
        ElseIf Key.ToString() = "A" Then
            A.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Z" Then
            Z.ForeColor = ColorToSet
        ElseIf Key.ToString() = "E" Then
            E.ForeColor = ColorToSet
        ElseIf Key.ToString() = "R" Then
            R.ForeColor = ColorToSet
        ElseIf Key.ToString() = "T" Then
            T.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Y" Then
            Y.ForeColor = ColorToSet
        ElseIf Key.ToString() = "U" Then
            U.ForeColor = ColorToSet
        ElseIf Key.ToString() = "I" Then
            I.ForeColor = ColorToSet
        ElseIf Key.ToString() = "O" Then
            O.ForeColor = ColorToSet
        ElseIf Key.ToString() = "P" Then
            P.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oem6" Then
            Oem6.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oem1" Then
            Oem1.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Return" Then
            ReturnBig.ForeColor = ColorToSet
            Returnn.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Delete" Then
            Delete.ForeColor = ColorToSet
        ElseIf Key.ToString() = "End" Then
            Endd.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Next" Then
            Nextt.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad7" Then
            NumPad7.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad8" Then
            NumPad8.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad9" Then
            NumPad9.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Add" Then
            Add.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Capital" Then
            Capital.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Q" Then
            Q.ForeColor = ColorToSet
        ElseIf Key.ToString() = "S" Then
            S.ForeColor = ColorToSet
        ElseIf Key.ToString() = "D" Then
            D.ForeColor = ColorToSet
        ElseIf Key.ToString() = "F" Then
            F.ForeColor = ColorToSet
        ElseIf Key.ToString() = "G" Then
            G.ForeColor = ColorToSet
        ElseIf Key.ToString() = "H" Then
            H.ForeColor = ColorToSet
        ElseIf Key.ToString() = "J" Then
            J.ForeColor = ColorToSet
        ElseIf Key.ToString() = "K" Then
            K.ForeColor = ColorToSet
        ElseIf Key.ToString() = "L" Then
            L.ForeColor = ColorToSet
        ElseIf Key.ToString() = "M" Then
            M.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oemtilde" Then
            Oemtilde.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oem5" Then
            Oem5.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad4" Then
            NumPad4.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad5" Then
            NumPad5.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad6" Then
            NumPad6.ForeColor = ColorToSet
        ElseIf Key.ToString() = "LShiftKey" Then
            LShiftKey.ForeColor = ColorToSet
        ElseIf Key.ToString() = "OemBackslash" Then
            OemBackslash.ForeColor = ColorToSet
        ElseIf Key.ToString() = "W" Then
            W.ForeColor = ColorToSet
        ElseIf Key.ToString() = "X" Then
            X.ForeColor = ColorToSet
        ElseIf Key.ToString() = "C" Then
            C.ForeColor = ColorToSet
        ElseIf Key.ToString() = "V" Then
            V.ForeColor = ColorToSet
        ElseIf Key.ToString() = "B" Then
            B.ForeColor = ColorToSet
        ElseIf Key.ToString() = "N" Then
            N.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oemcomma" Then
            Oemcomma.ForeColor = ColorToSet
        ElseIf Key.ToString() = "OemPeriod" Then
            OemPeriod.ForeColor = ColorToSet
        ElseIf Key.ToString() = "OemQuestion" Then
            OemQuestion.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Oem8" Then
            Oem8.ForeColor = ColorToSet
        ElseIf Key.ToString() = "RShiftKey" Then
            RShiftKey.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Up" Then
            Up.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad1" Then
            NumPad1.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad2" Then
            NumPad2.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad3" Then
            NumPad3.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Return" Then
            Returnn.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Space" Then
            Space.ForeColor = ColorToSet
        ElseIf Key.ToString() = "LMenu" Then
            LMenu.ForeColor = ColorToSet
        ElseIf Key.ToString() = "LWin" Then
            LWin.ForeColor = ColorToSet
        ElseIf Key.ToString() = "LControlKey" Then
            LControlKey.ForeColor = ColorToSet
        ElseIf Key.ToString() = "RMenu" Then
            RMenu.ForeColor = ColorToSet
        ElseIf Key.ToString() = "RWin" Then
            RWin.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Apps" Then
            Apps.ForeColor = ColorToSet
        ElseIf Key.ToString() = "RControlKey" Then
            RControlKey.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Left" Then
            Left.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Down" Then
            Down.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Right" Then
            Right.ForeColor = ColorToSet
        ElseIf Key.ToString() = "NumPad0" Then
            NumPad0.ForeColor = ColorToSet
        ElseIf Key.ToString() = "Decimal" Then
            Decimall.ForeColor = ColorToSet
        End If
    End Sub

    Private Sub kbHook_KeyUp(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyUp
        If Key.ToString() = "Escape" Then
            Escape.ForeColor = ColorReset
        ElseIf Key.ToString() = "F1" Then
            F1.ForeColor = ColorReset
        ElseIf Key.ToString() = "F2" Then
            F2.ForeColor = ColorReset
        ElseIf Key.ToString() = "F3" Then
            F3.ForeColor = ColorReset
        ElseIf Key.ToString() = "F4" Then
            F4.ForeColor = ColorReset
        ElseIf Key.ToString() = "F5" Then
            F5.ForeColor = ColorReset
        ElseIf Key.ToString() = "F6" Then
            F6.ForeColor = ColorReset
        ElseIf Key.ToString() = "F7" Then
            F7.ForeColor = ColorReset
        ElseIf Key.ToString() = "F8" Then
            F8.ForeColor = ColorReset
        ElseIf Key.ToString() = "F9" Then
            F9.ForeColor = ColorReset
        ElseIf Key.ToString() = "F10" Then
            F10.ForeColor = ColorReset
        ElseIf Key.ToString() = "F11" Then
            F11.ForeColor = ColorReset
        ElseIf Key.ToString() = "F12" Then
            F12.ForeColor = ColorReset
        ElseIf Key.ToString() = "PrintScreen" Then
            PrintScreen.ForeColor = ColorReset
        ElseIf Key.ToString() = "Scroll" Then
            Scroll.ForeColor = ColorReset
        ElseIf Key.ToString() = "Pause" Then
            Pause.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oem7" Then
            Oem7.ForeColor = ColorReset
        ElseIf Key.ToString() = "D0" Then
            D0.ForeColor = ColorReset
        ElseIf Key.ToString() = "D1" Then
            D1.ForeColor = ColorReset
        ElseIf Key.ToString() = "D2" Then
            D2.ForeColor = ColorReset
        ElseIf Key.ToString() = "D3" Then
            D3.ForeColor = ColorReset
        ElseIf Key.ToString() = "D4" Then
            D4.ForeColor = ColorReset
        ElseIf Key.ToString() = "D5" Then
            D5.ForeColor = ColorReset
        ElseIf Key.ToString() = "D6" Then
            D6.ForeColor = ColorReset
        ElseIf Key.ToString() = "D7" Then
            D7.ForeColor = ColorReset
        ElseIf Key.ToString() = "D8" Then
            D8.ForeColor = ColorReset
        ElseIf Key.ToString() = "D9" Then
            D9.ForeColor = ColorReset
        ElseIf Key.ToString() = "OemOpenBrackets" Then
            OemOpenBrackets.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oemplus" Then
            Oemplus.ForeColor = ColorReset
        ElseIf Key.ToString() = "Back" Then
            Back.ForeColor = ColorReset
        ElseIf Key.ToString() = "Insert" Then
            Insert.ForeColor = ColorReset
        ElseIf Key.ToString() = "Home" Then
            Home.ForeColor = ColorReset
        ElseIf Key.ToString() = "PageUp" Then
            PageUp.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumLock" Then
            NumLock.ForeColor = ColorReset
        ElseIf Key.ToString() = "Divide" Then
            Divide.ForeColor = ColorReset
        ElseIf Key.ToString() = "Multiply" Then
            Multiply.ForeColor = ColorReset
        ElseIf Key.ToString() = "Subtract" Then
            Subtract.ForeColor = ColorReset
        ElseIf Key.ToString() = "Tab" Then
            Tab.ForeColor = ColorReset
        ElseIf Key.ToString() = "A" Then
            A.ForeColor = ColorReset
        ElseIf Key.ToString() = "Z" Then
            E.ForeColor = ColorReset
        ElseIf Key.ToString() = "E" Then
            E.ForeColor = ColorReset
        ElseIf Key.ToString() = "R" Then
            R.ForeColor = ColorReset
        ElseIf Key.ToString() = "T" Then
            T.ForeColor = ColorReset
        ElseIf Key.ToString() = "Y" Then
            Y.ForeColor = ColorReset
        ElseIf Key.ToString() = "U" Then
            U.ForeColor = ColorReset
        ElseIf Key.ToString() = "I" Then
            I.ForeColor = ColorReset
        ElseIf Key.ToString() = "O" Then
            O.ForeColor = ColorReset
        ElseIf Key.ToString() = "P" Then
            P.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oem6" Then
            Oem6.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oem1" Then
            Oem1.ForeColor = ColorReset
        ElseIf Key.ToString() = "Return" Then
            ReturnBig.ForeColor = ColorReset
            Returnn.ForeColor = ColorReset
        ElseIf Key.ToString() = "Delete" Then
            Delete.ForeColor = ColorReset
        ElseIf Key.ToString() = "End" Then
            Endd.ForeColor = ColorReset
        ElseIf Key.ToString() = "Next" Then
            Nextt.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad7" Then
            NumPad7.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad8" Then
            NumPad8.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad9" Then
            NumPad9.ForeColor = ColorReset
        ElseIf Key.ToString() = "Add" Then
            Add.ForeColor = ColorReset
        ElseIf Key.ToString() = "Capital" Then
            Capital.ForeColor = ColorReset
        ElseIf Key.ToString() = "Q" Then
            Q.ForeColor = ColorReset
        ElseIf Key.ToString() = "S" Then
            S.ForeColor = ColorReset
        ElseIf Key.ToString() = "D" Then
            D.ForeColor = ColorReset
        ElseIf Key.ToString() = "F" Then
            F.ForeColor = ColorReset
        ElseIf Key.ToString() = "G" Then
            G.ForeColor = ColorReset
        ElseIf Key.ToString() = "H" Then
            H.ForeColor = ColorReset
        ElseIf Key.ToString() = "J" Then
            J.ForeColor = ColorReset
        ElseIf Key.ToString() = "K" Then
            K.ForeColor = ColorReset
        ElseIf Key.ToString() = "L" Then
            L.ForeColor = ColorReset
        ElseIf Key.ToString() = "M" Then
            M.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oemtilde" Then
            Oemtilde.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oem5" Then
            Oem5.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad4" Then
            NumPad4.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad5" Then
            NumPad5.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad6" Then
            NumPad6.ForeColor = ColorReset
        ElseIf Key.ToString() = "LShiftKey" Then
            LShiftKey.ForeColor = ColorReset
        ElseIf Key.ToString() = "OemBackslash" Then
            OemBackslash.ForeColor = ColorReset
        ElseIf Key.ToString() = "W" Then
            W.ForeColor = ColorReset
        ElseIf Key.ToString() = "X" Then
            X.ForeColor = ColorReset
        ElseIf Key.ToString() = "C" Then
            C.ForeColor = ColorReset
        ElseIf Key.ToString() = "V" Then
            V.ForeColor = ColorReset
        ElseIf Key.ToString() = "B" Then
            B.ForeColor = ColorReset
        ElseIf Key.ToString() = "N" Then
            N.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oemcomma" Then
            Oemcomma.ForeColor = ColorReset
        ElseIf Key.ToString() = "OemPeriod" Then
            OemPeriod.ForeColor = ColorReset
        ElseIf Key.ToString() = "OemQuestion" Then
            OemQuestion.ForeColor = ColorReset
        ElseIf Key.ToString() = "Oem8" Then
            Oem8.ForeColor = ColorReset
        ElseIf Key.ToString() = "RShiftKey" Then
            RShiftKey.ForeColor = ColorReset
        ElseIf Key.ToString() = "Up" Then
            Up.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad1" Then
            NumPad1.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad2" Then
            NumPad2.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad3" Then
            NumPad3.ForeColor = ColorReset
        ElseIf Key.ToString() = "Return" Then
            Returnn.ForeColor = ColorReset
        ElseIf Key.ToString() = "Space" Then
            Space.ForeColor = ColorReset
        ElseIf Key.ToString() = "LMenu" Then
            LMenu.ForeColor = ColorReset
        ElseIf Key.ToString() = "LWin" Then
            LWin.ForeColor = ColorReset
        ElseIf Key.ToString() = "LControlKey" Then
            LControlKey.ForeColor = ColorReset
        ElseIf Key.ToString() = "RMenu" Then
            RMenu.ForeColor = ColorReset
        ElseIf Key.ToString() = "RWin" Then
            RWin.ForeColor = ColorReset
        ElseIf Key.ToString() = "Apps" Then
            Apps.ForeColor = ColorReset
        ElseIf Key.ToString() = "RControlKey" Then
            RControlKey.ForeColor = ColorReset
        ElseIf Key.ToString() = "Left" Then
            Left.ForeColor = ColorReset
        ElseIf Key.ToString() = "Down" Then
            Down.ForeColor = ColorReset
        ElseIf Key.ToString() = "Right" Then
            Right.ForeColor = ColorReset
        ElseIf Key.ToString() = "NumPad0" Then
            NumPad0.ForeColor = ColorReset
        ElseIf Key.ToString() = "Decimal" Then
            Decimall.ForeColor = ColorReset
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.NumLock Then
            Button1.ForeColor = Color.Aqua
        Else
            Button1.ForeColor = Color.White
        End If
        If My.Computer.Keyboard.CapsLock Then
            Button2.ForeColor = Color.Aqua
        Else
            Button2.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MyMouseHook.UnMouseHook()
    End Sub

    Private Sub M_MouseRightClickDown(ByVal pt As Point) Handles MyMouseHook.MouseRightClickDown
        RightMouseButton.ForeColor = ColorToSet
    End Sub

    Private Sub M_MouseRightClickUp(ByVal pt As Point) Handles MyMouseHook.MouseRightClickUp
        RightMouseButton.ForeColor = ColorReset
    End Sub

    Private Sub M_MouseLeftClickDown(ByVal pt As Point) Handles MyMouseHook.MouseLeftClickDown
        LeftMouseButton.ForeColor = ColorToSet
    End Sub

    Private Sub M_MouseLeftClickUp(ByVal pt As Point) Handles MyMouseHook.MouseLeftClickUp
        LeftMouseButton.ForeColor = ColorReset
    End Sub

    Private Async Sub M_MouseLeftWheel(ByVal pt As Point, ByVal direction As MouseHook.MouseWheelType) Handles MyMouseHook.MouseWheel
        If direction = MouseHook.MouseWheelType.HAUT Then
            WheelButtonUp.ForeColor = ColorToSet
            WheelButtonDown.ForeColor = ColorReset
            Await Task.Delay(150) : WheelButtonUp.ForeColor = ColorReset
        ElseIf direction = MouseHook.MouseWheelType.BAS Then
            WheelButtonDown.ForeColor = ColorToSet
            WheelButtonUp.ForeColor = ColorReset
            Await Task.Delay(150) : WheelButtonDown.ForeColor = ColorReset
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.Size = New Size(1716, 330)
        Else
            Me.Size = New Size(1448, 330)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        XXX = Control.MousePosition.X - Me.Location.X
        YYY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (YYY)
            NewPoint.X -= (XXX)
            Me.Location = NewPoint
        End If
    End Sub
End Class

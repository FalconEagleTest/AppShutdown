Imports System.Runtime.InteropServices
Imports System.ComponentModel



Public Class Form1
    Public shutdownTimer As Integer = 0

    Declare Function SetSuspendState Lib "PowrProf" (ByVal Hibernate As Integer, ByVal ForceCritical As Integer, ByVal DisableWakeEvent As Integer) As Integer

    Private WithEvents kbHook As New KeyboardHook
    ' This declares what Type the variable joystick1 will be for. The Type is Joystick.
    ' WithEvents allows you to easily add events using the IDE.
    Private WithEvents joystick1 As Joystick




    Private loc As Point, idle As Date, hidden As Boolean

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        Static press_tick As Boolean


        If (press_tick = True) Then
            LblMouse.ForeColor = Color.Blue
            press_tick = False
        Else
            LblMouse.ForeColor = Color.Black
            press_tick = True
        End If
        LblKeybaord.Text = "Keyboard: " + Key.ToString()
        shutdownTimer = 0
    End Sub

    ' This is an event that belongs to the Form. It is raised when the form loads.


    ' And now we have the four events that belong to joystick1.

    Private Sub joystick1_Down() Handles joystick1.Down
        ' TODO: Replace this so that it plays a sound instead.
        LblController.Text = "Controller: " + "Down"
        shutdownTimer = 0
    End Sub

    Private Sub joystick1_Left() Handles joystick1.Left
        ' TODO: Replace this so that it plays a sound instead.
        LblController.Text = "Controller: " + "Left"
        shutdownTimer = 0
    End Sub

    Private Sub joystick1_Right() Handles joystick1.Right
        ' TODO: Replace this so that it plays a sound instead.
        LblController.Text = "Controller: " + "Right"
        shutdownTimer = 0
    End Sub

    Private Sub joystick1_Up() Handles joystick1.Up
        ' TODO: Replace this so that it plays a sound instead.
        LblController.Text = "Controller: " + "Up"
        shutdownTimer = 0
    End Sub
    Public Sub sleep_now()
        Dim cmdProcess As Process = New Process
        Dim fileArgs As String
        Dim path As String = Environment.SystemDirectory

        fileArgs = "powrprof.dll,SetSuspendState Sleep"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sleep_now()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    '    Private Sub joystick1_buttonPressed() Handles joystick1.buttonPressed
    'TODO:   Replace this so that it plays a sound instead.
    '        Me.Text = joystick1.b1
    'End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        joystick1 = New Joystick(Me, 0)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GC.Collect()
        GC.WaitForPendingFinalizers()
        If loc <> Cursor.Position Then
            If hidden Then
                Cursor.Show()
                hidden = False
            End If
            loc = Cursor.Position
            idle = Date.Now
            LblMouse.Text = "Mouse: " + loc.ToString()
            shutdownTimer = 0
        ElseIf Not hidden AndAlso (Date.Now - idle).TotalSeconds > 3 Then

            Cursor.Hide()
            hidden = True

        End If
        shutdownTimer += 1
        If (shutdownTimer > (TextBox1.Text * 60)) Then
            sleep_now()

        End If
        LblEnterSleep.Text = "Enter Sleep In:" + Convert.ToString((TextBox1.Text * 60) - shutdownTimer) + " Sec"
        LblController.Text = "Controller: " + joystick1.btnValue.ToString()


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = Me.Icon
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info


            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick

    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
End Class
Public Class KeyboardHook

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As UInt32
        Public scanCode As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()>
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105

    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
    Private HHookID As IntPtr = IntPtr.Zero

    Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = HC_ACTION) Then
            Dim struct As KBDLLHOOKSTRUCT
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
            End Select
        End If
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    Public Sub New()
        HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)), 0)
        If HHookID = IntPtr.Zero Then
            Throw New Exception("Could not set keyboard hook")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not HHookID = IntPtr.Zero Then
            UnhookWindowsHookEx(HHookID)
        End If
        MyBase.Finalize()
    End Sub

End Class
Public Class Joystick
    Inherits NativeWindow

    Private parent As Form
    Private Const MM_JOY1MOVE As Integer = &H3A0

    ' Public Event Move(ByVal joystickPosition As Point)
    Public btnValue As String
    Public Event Up()
    Public Event Down()
    Public Event Left()
    Public Event Right()

    <StructLayout(LayoutKind.Explicit)>
    Private Structure JoyPosition
        <FieldOffset(0)>
        Public Raw As IntPtr
        <FieldOffset(0)>
        Public XPos As UShort
        <FieldOffset(2)>
        Public YPos As UShort
    End Structure

    Private Class NativeMethods

        Private Sub New()
        End Sub

        ' This is a "Stub" function - it has no code in its body.
        ' There is a similarly named function inside a dll that comes with windows called
        ' winmm.dll.
        ' The .Net framework will route calls to this function, through to the dll file.
        <DllImport("winmm", CallingConvention:=CallingConvention.Winapi, EntryPoint:="joySetCapture", SetLastError:=True)>
        Public Shared Function JoySetCapture(ByVal hwnd As IntPtr, ByVal uJoyID As Integer, ByVal uPeriod As Integer, <MarshalAs(UnmanagedType.Bool)> ByVal changed As Boolean) As Integer
        End Function

    End Class

    Public Sub New(ByVal parent As Form, ByVal joyId As Integer)
        AddHandler parent.HandleCreated, AddressOf Me.OnHandleCreated
        AddHandler parent.HandleDestroyed, AddressOf Me.OnHandleDestroyed
        AssignHandle(parent.Handle)
        Me.parent = parent
        Dim result As Integer = NativeMethods.JoySetCapture(Me.Handle, joyId, 100, True)
    End Sub

    Private Sub OnHandleCreated(ByVal sender As Object, ByVal e As EventArgs)
        AssignHandle(DirectCast(sender, Form).Handle)
    End Sub

    Private Sub OnHandleDestroyed(ByVal sender As Object, ByVal e As EventArgs)
        ReleaseHandle()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = MM_JOY1MOVE Then
            ' Joystick co-ords.
            ' (0,0) (32768,0) (65535, 0)
            '
            '
            '
            ' (0, 32768) (32768, 32768) (65535, 32768)
            '
            '
            '
            '
            ' (0, 65535) (32768, 65535) (65535, 65535)
            '
            Dim p As JoyPosition
            p.Raw = m.LParam
            ' RaiseEvent Move(New Point(p.XPos, p.YPos))
            If p.XPos > 16384 AndAlso p.XPos < 49152 Then
                ' X is near the centre line.
                If p.YPos < 6000 Then
                    ' Y is near the top.
                    RaiseEvent Up()
                ElseIf p.YPos > 59536 Then
                    ' Y is near the bottom.
                    RaiseEvent Down()
                End If
            Else
                If p.YPos > 16384 AndAlso p.YPos < 49152 Then
                    ' Y is near the centre line
                    If p.XPos < 6000 Then
                        ' X is near the left.
                        RaiseEvent Left()
                    ElseIf p.XPos > 59536 Then
                        ' X is near the right
                        RaiseEvent Right()
                    End If
                End If
            End If
        End If
        If btnValue <> m.WParam.ToString Then
            btnValue = m.WParam.ToString
        End If
        MyBase.WndProc(m)
    End Sub

End Class
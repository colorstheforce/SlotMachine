Imports System.IO
Imports Microsoft.DirectX
Imports Microsoft.DirectX.DirectSound
Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.Media.SoundPlayer

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents SpinButton As System.Windows.Forms.Button
    Friend WithEvents CoinLabel As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowTosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToWinCoinsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlotChangeLabel As System.Windows.Forms.Label
    Friend WithEvents VolumePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BetMaxButton As System.Windows.Forms.Button
    Friend WithEvents VolumeOffPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.SpinButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoinLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.StopButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowTosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToWinCoinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlotChangeLabel = New System.Windows.Forms.Label()
        Me.VolumePictureBox = New System.Windows.Forms.PictureBox()
        Me.BetMaxButton = New System.Windows.Forms.Button()
        Me.VolumeOffPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.VolumePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeOffPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCard3
        '
        Me.picCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard3.Location = New System.Drawing.Point(467, 139)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(112, 189)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard3.TabIndex = 2
        Me.picCard3.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard2.Location = New System.Drawing.Point(336, 139)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(113, 189)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard2.TabIndex = 1
        Me.picCard2.TabStop = False
        '
        'picCard1
        '
        Me.picCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard1.Location = New System.Drawing.Point(206, 139)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(110, 189)
        Me.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        '
        'SpinButton
        '
        Me.SpinButton.BackColor = System.Drawing.Color.Transparent
        Me.SpinButton.BackgroundImage = Global.SlotMachine.My.Resources.Resources.spin
        Me.SpinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpinButton.Location = New System.Drawing.Point(687, 94)
        Me.SpinButton.Name = "SpinButton"
        Me.SpinButton.Size = New System.Drawing.Size(85, 52)
        Me.SpinButton.TabIndex = 2
        Me.SpinButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(272, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "COINS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoinLabel
        '
        Me.CoinLabel.BackColor = System.Drawing.Color.Transparent
        Me.CoinLabel.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoinLabel.ForeColor = System.Drawing.Color.Yellow
        Me.CoinLabel.Location = New System.Drawing.Point(426, 37)
        Me.CoinLabel.Name = "CoinLabel"
        Me.CoinLabel.Size = New System.Drawing.Size(88, 32)
        Me.CoinLabel.TabIndex = 4
        Me.CoinLabel.Text = "0"
        Me.CoinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Transparent
        Me.StopButton.BackgroundImage = Global.SlotMachine.My.Resources.Resources._stop
        Me.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(687, 153)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StopButton.Size = New System.Drawing.Size(85, 56)
        Me.StopButton.TabIndex = 5
        Me.StopButton.Text = "STOP"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowTosToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HowTosToolStripMenuItem
        '
        Me.HowTosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToPlayToolStripMenuItem, Me.HowToWinCoinsToolStripMenuItem})
        Me.HowTosToolStripMenuItem.Name = "HowTosToolStripMenuItem"
        Me.HowTosToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HowTosToolStripMenuItem.Text = "How To's"
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.HowToPlayToolStripMenuItem.Text = "How To Play?"
        '
        'HowToWinCoinsToolStripMenuItem
        '
        Me.HowToWinCoinsToolStripMenuItem.Name = "HowToWinCoinsToolStripMenuItem"
        Me.HowToWinCoinsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.HowToWinCoinsToolStripMenuItem.Text = "How To Win Coins?"
        '
        'SlotChangeLabel
        '
        Me.SlotChangeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SlotChangeLabel.BackColor = System.Drawing.Color.Transparent
        Me.SlotChangeLabel.Image = Global.SlotMachine.My.Resources.Resources.slot_change_down_0
        Me.SlotChangeLabel.Location = New System.Drawing.Point(203, 325)
        Me.SlotChangeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SlotChangeLabel.Name = "SlotChangeLabel"
        Me.SlotChangeLabel.Size = New System.Drawing.Size(373, 85)
        Me.SlotChangeLabel.TabIndex = 7
        '
        'VolumePictureBox
        '
        Me.VolumePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.VolumePictureBox.BackgroundImage = Global.SlotMachine.My.Resources.Resources.vol_on
        Me.VolumePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumePictureBox.Location = New System.Drawing.Point(687, 27)
        Me.VolumePictureBox.Name = "VolumePictureBox"
        Me.VolumePictureBox.Size = New System.Drawing.Size(54, 42)
        Me.VolumePictureBox.TabIndex = 8
        Me.VolumePictureBox.TabStop = False
        '
        'BetMaxButton
        '
        Me.BetMaxButton.BackgroundImage = Global.SlotMachine.My.Resources.Resources.bet_max
        Me.BetMaxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BetMaxButton.Location = New System.Drawing.Point(12, 94)
        Me.BetMaxButton.Name = "BetMaxButton"
        Me.BetMaxButton.Size = New System.Drawing.Size(85, 52)
        Me.BetMaxButton.TabIndex = 9
        Me.BetMaxButton.UseVisualStyleBackColor = True
        '
        'VolumeOffPictureBox
        '
        Me.VolumeOffPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.VolumeOffPictureBox.BackgroundImage = Global.SlotMachine.My.Resources.Resources.vol_off
        Me.VolumeOffPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeOffPictureBox.Location = New System.Drawing.Point(687, 27)
        Me.VolumeOffPictureBox.Name = "VolumeOffPictureBox"
        Me.VolumeOffPictureBox.Size = New System.Drawing.Size(54, 42)
        Me.VolumeOffPictureBox.TabIndex = 10
        Me.VolumeOffPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.SlotMachine.My.Resources.Resources.game_corner_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 406)
        Me.Controls.Add(Me.VolumePictureBox)
        Me.Controls.Add(Me.VolumeOffPictureBox)
        Me.Controls.Add(Me.BetMaxButton)
        Me.Controls.Add(Me.SlotChangeLabel)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Controls.Add(Me.CoinLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpinButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Rathod's Visual Programming Slot Machine"
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.VolumePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeOffPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Const strPrefix As String = "\images\"
    Const strSuffix As String = ".PNG"
    Dim objRandom As Random = New Random
    Dim timer As Integer
    Dim compPic1, compPic2, compPic3 As Integer
    Dim wage As Integer
    Dim leverSound As New System.Media.SoundPlayer
    Dim game_corner_sound As New System.Media.SoundPlayer
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim audioAlias0 As String = "myAudio0"
    Dim audioAlias1 As String = "myAudio1"
    Dim audioAlias2 As String = "myAudio2"
    Dim audioAlias3 As String = "myAudio3"
    Dim audioAlias4 As String = "myAudio4"
    Dim leverAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\lever_click.wav"
    Dim twoPicWinAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\gc_sm_two_pic_win.wav"
    Dim allPicWinAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\gc_sm_all_pic_win.wav"
    Dim spinStartAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\gc_sm_spin_start.wav"
    Dim stopAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\gc_stop.wav"
    Dim volAudioPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\gc_vol_audio.wav"


    Private Sub Spin(ByVal die As PictureBox, ByRef intPic As Integer)

        Dim intFace As Integer = objRandom.Next(1, 10)
        die.Image = Image.FromFile(Directory.GetCurrentDirectory & _
               strPrefix & intFace & strSuffix)
        intPic = intFace
    End Sub

    '  Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    '(ByVal lpstrCommand As String, ByVal lpstrReturnString As String, _
    'ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer


    'Private Sub SpinButton_Click_Sound(ByVal sender As System.Object, _
    'ByVal e As System.EventArgs) Handles SpinButton.Click
    '    mciSendString("close FirstSound", String.Empty, 0, 0)
    '    Dim fileName As String

    '    fileName = My.Resources.lever_click.ToString.StartsWith("lever_click")
    '    mciSendString("open " & fileName & " type mpegvideo alias FirstSound", String.Empty, 0, 0)
    '    mciSendString("play FirstSound", String.Empty, 0, 0)

    'End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Spin(picCard1, compPic1)
        'timer += 1
    End Sub

    Private Sub SpinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinButton.Click
        'Try
        SlotChangeLabel.Image = My.Resources.slot_change_down_0
        'Catch ex As Exception
        '    MsgBox(ex.StackTrace, MsgBoxStyle.OkOnly, "Audio Play Error!")
        'End Try
        'Try
        'Dim leverAudio As Audio = New Audio("images/lever_click.wav")
        'leverAudio.Play()
        'Catch ex As Exception
        '    MsgBox(ex.StackTrace, MsgBoxStyle.OkOnly, "Audio Play Error!")
        'End Try
        SpinButton.Enabled = False
        NewGameToolStripMenuItem.Enabled = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        StopButton.Enabled = True
        timer = 0
        'leverSound.SoundLocation = My.Computer.FileSystem.CurrentDirectory & "/images/lever_click.wav"
        'leverSound.LoadAsync()
        'leverSound.Play()
        mciSendString("Open " & Chr(34) & spinStartAudioPath & Chr(34) & " alias " & audioAlias2, CStr(0), 0, 0)
        mciSendString("Play " & audioAlias2, CStr(0), 0, 0)
        If Val(CoinLabel.Text) >= 4 Then
            CoinLabel.Text = CoinLabel.Text - 4
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
        Else
            MsgBox("You Have No Coins!" & Environment.NewLine &
                               "Go get some from the counter." & Environment.NewLine &
                               "Or, to make it easier for you, I've put a New Game Option in GAME -> NEW GAME." & Environment.NewLine &
                               "Have Fun!", MsgBoxStyle.OkOnly, "Not Enough Coins")
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getCoins As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr")
        If Val(getCoins) > 9999 Then
            CoinLabel.Text = 9999
            MsgBox("There are too many coins for the Coin Case! You Cannot have more than 9999 Coins!", MsgBoxStyle.OkOnly, "Too many Coins!")
        ElseIf Val(getCoins) <= 0 Then
            CoinLabel.Text = 250
            MsgBox("You've run out of coins! I'll start a new game for you.", MsgBoxStyle.OkOnly, "No Coins!")
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
        Else
            CoinLabel.Text = Val(getCoins)
        End If
        'My.Computer.Audio.Play(My.Resources.game_corner, AudioPlayMode.BackgroundLoop)
        'game_corner_sound.Stream.(My.Computer.FileSystem.CurrentDirectory & "/images/game_corner.wav")

        'game_corner_sound.LoadAsync()
        'game_corner_sound.PlayLooping()
        'Load Pictures
        Spin(picCard1, compPic1)
        Spin(picCard2, compPic2)
        Spin(picCard3, compPic3)

        My.Computer.Audio.Play(My.Resources.game_corner, AudioPlayMode.BackgroundLoop)
        'audioAlias = "myAudio"
        'leverAudioPath = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\images\lever_click.wav"
        mciSendString("Open " & Chr(34) & twoPicWinAudioPath & Chr(34) & " alias " & audioAlias0, CStr(0), 0, 0)
        mciSendString("Open " & Chr(34) & allPicWinAudioPath & Chr(34) & " alias " & audioAlias1, CStr(0), 0, 0)
        mciSendString("Open " & Chr(34) & spinStartAudioPath & Chr(34) & " alias " & audioAlias2, CStr(0), 0, 0)
        mciSendString("Open " & Chr(34) & stopAudioPath & Chr(34) & " alias " & audioAlias3, CStr(0), 0, 0)
        mciSendString("Open " & Chr(34) & volAudioPath & Chr(34) & " alias " & audioAlias4, CStr(0), 0, 0)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Spin(picCard2, compPic2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Spin(picCard3, compPic3)
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        ' If timer >= 45 Then
        'Timer1.Enabled = False
        '   If (compPic1 = compPic2) And (compPic2 = compPic3) Then

        'lblCash.Text = CInt(lblCash.Text) + 200

        '  ElseIf (compPic1 = compPic2) Or (compPic1 = compPic3) Or (compPic2 = compPic3) Then

        ' lblCash.Text = CInt(lblCash.Text) + 50
        '  Else
        ' lblCash.Text = CInt(lblCash.Text) - 50
        ' End If
        ' End If
        If Timer1.Enabled Then
            Call mciSendString("close all", 0, 0, 0)
            mciSendString("Open " & Chr(34) & stopAudioPath & Chr(34) & " alias " & audioAlias3, CStr(0), 0, 0)
            mciSendString("Play " & audioAlias3, CStr(0), 0, 0)
            SlotChangeLabel.Image = My.Resources.slot_change_down_1
            Timer1.Enabled = False
        ElseIf Timer2.Enabled Then
            Call mciSendString("close all", 0, 0, 0)
            mciSendString("Open " & Chr(34) & stopAudioPath & Chr(34) & " alias " & audioAlias3, CStr(0), 0, 0)
            mciSendString("Play " & audioAlias3, CStr(0), 0, 0)
            SlotChangeLabel.Image = My.Resources.slot_change_down_2
            Timer2.Enabled = False
        ElseIf Timer3.Enabled Then
            SlotChangeLabel.Image = My.Resources.slot_change_down_3
            Timer3.Enabled = False
            Call mciSendString("close all", 0, 0, 0)
            mciSendString("Open " & Chr(34) & stopAudioPath & Chr(34) & " alias " & audioAlias3, CStr(0), 0, 0)
            mciSendString("Play " & audioAlias3, CStr(0), 0, 0)
            SpinButton.Enabled = True
            StopButton.Enabled = False
            NewGameToolStripMenuItem.Enabled = True
            If Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False Then
                If (compPic1 = compPic2) And (compPic2 = compPic3) Then

                    CoinLabel.Text = CInt(CoinLabel.Text) + 200
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
                    mciSendString("Open " & Chr(34) & allPicWinAudioPath & Chr(34) & " alias " & audioAlias1, CStr(0), 0, 0)
                    mciSendString("Play " & audioAlias1, CStr(0), 0, 0)
                ElseIf (compPic1 = compPic2) Or (compPic1 = compPic3) Or (compPic2 = compPic3) Then

                    CoinLabel.Text = CInt(CoinLabel.Text) + 50
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
                    mciSendString("Open " & Chr(34) & twoPicWinAudioPath & Chr(34) & " alias " & audioAlias0, CStr(0), 0, 0)
                    mciSendString("Play " & audioAlias0, CStr(0), 0, 0)
                Else
                    If Val(CoinLabel.Text) <= 0 Then
                        CoinLabel.Text = 0
                        SpinButton.Enabled = False
                        StopButton.Enabled = False
                        MsgBox("You Have No Coins!" & Environment.NewLine &
                               "Go get some from the counter." & Environment.NewLine &
                               "Or, to make it easier for you, I've put a New Game Option in GAME -> NEW GAME." & Environment.NewLine &
                               "Have Fun!", MsgBoxStyle.OkOnly, "Not Enough Coins")
                    Else
                        'CoinLabel.Text = CInt(CoinLabel.Text) - 50
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPlayToolStripMenuItem.Click
        MsgBox("To play the game, you must have at least 50 coins for one round." & Environment.NewLine &
                               "Each time you get TWO of the same pictures, you earn 50 coins." & Environment.NewLine &
                               "Each time you get all THREE of the same pictures, you will earn 200 coins." & Environment.NewLine &
                               "If you have no coins left, you will have to start a new game from GAME -> NEW GAME." & Environment.NewLine &
                                Environment.NewLine &
                                "Enjoy the game!", MsgBoxStyle.OkOnly, "How To Play?")
    End Sub

    Private Sub HowToWinCoinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToWinCoinsToolStripMenuItem.Click
        MsgBox("To win 200 coins, wait till you see the same pictures and quickly click STOP 3 times.", MsgBoxStyle.OkOnly, "How To Win Coins?")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This POKEMON SLOT MACHINE game has brought to you by SAURABH RATHOD." & Environment.NewLine &
               "The concept was derived from Pokemon FIRE-RED/LEAF-GREEN. Known to players as GAME CORNER." & Environment.NewLine &
                Environment.NewLine &
                "Enjoy the game!", MsgBoxStyle.OkOnly, "About This Game")
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        CoinLabel.Text = 250
        SpinButton.Enabled = True
        SlotChangeLabel.Image = My.Resources.slot_change_down_0
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolumePictureBox_Click(sender As Object, e As EventArgs) Handles VolumePictureBox.Click
        My.Computer.Audio.Stop()
        VolumeOffPictureBox.BringToFront()
        VolumePictureBox.SendToBack()
    End Sub

    Private Sub BetMaxButton_Click(sender As Object, e As EventArgs) Handles BetMaxButton.Click
        CoinLabel.Text = 0
        SpinButton.Enabled = False
        BetMaxButton.Enabled = False
        NewGameToolStripMenuItem.Enabled = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        StopButton.Enabled = True
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/savedata.vpr", Val(CoinLabel.Text), False)
    End Sub

    Private Sub VolumeOffPictureBox_Click(sender As Object, e As EventArgs) Handles VolumeOffPictureBox.Click
        My.Computer.Audio.Play(My.Resources.game_corner, AudioPlayMode.BackgroundLoop)
        VolumePictureBox.BringToFront()
        VolumeOffPictureBox.SendToBack()
    End Sub
End Class

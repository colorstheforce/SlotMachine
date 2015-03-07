Imports System.IO
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picCard3 = New System.Windows.Forms.PictureBox
        Me.picCard2 = New System.Windows.Forms.PictureBox
        Me.picCard1 = New System.Windows.Forms.PictureBox
        Me.btnSpin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picCard3)
        Me.Panel1.Controls.Add(Me.picCard2)
        Me.Panel1.Controls.Add(Me.picCard1)
        Me.Panel1.Location = New System.Drawing.Point(88, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 168)
        Me.Panel1.TabIndex = 0
        '
        'picCard3
        '
        Me.picCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard3.Location = New System.Drawing.Point(264, 24)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(80, 112)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard3.TabIndex = 2
        Me.picCard3.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard2.Location = New System.Drawing.Point(144, 24)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(80, 112)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard2.TabIndex = 1
        Me.picCard2.TabStop = False
        '
        'picCard1
        '
        Me.picCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard1.Location = New System.Drawing.Point(24, 24)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(80, 112)
        Me.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(232, 360)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(120, 32)
        Me.btnSpin.TabIndex = 2
        Me.btnSpin.Text = "Spin"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cash $"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(184, 304)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(88, 32)
        Me.lblCash.TabIndex = 4
        Me.lblCash.Text = "0"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(512, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 208)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(184, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(72, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ANY TWO =  $50"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(72, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ANY THREE = $200"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(72, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NONE =-$50"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(368, 40)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Very Simple Slot Machine"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 406)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Visual Programming- Online - Game Programming Spring 04"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Const strPrefix As String = "\images\"
    Const strSuffix As String = ".jpg"
    Dim objRandom As Random = New Random
    Dim counter As Integer
    Dim intPic1, intPic2, intPic3 As Integer
    Dim wage As Integer
    Private Sub Roll(ByVal die As PictureBox, ByRef intPic As Integer)

        Dim intFace As Integer = objRandom.Next(1, 4)
        die.Image = Image.FromFile(Directory.GetCurrentDirectory & _
               strPrefix & intFace & strSuffix)
        intPic = intFace
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If counter < 15 Then
            Roll(picCard1, intPic1)

        End If
        If counter < 30 Then
            Roll(picCard2, intPic2)
        End If
        If counter < 45 Then
            Roll(picCard3, intPic3)

        End If
        counter += 1

        If counter >= 45 Then
            Timer1.Enabled = False
            If (intPic1 = intPic2) And (intPic2 = intPic3) Then

                lblCash.Text = CInt(lblCash.Text) + 200

            ElseIf (intPic1 = intPic2) Or (intPic1 = intPic3) Or (intPic2 = intPic3) Then

                lblCash.Text = CInt(lblCash.Text) + 50
            Else
                lblCash.Text = CInt(lblCash.Text) - 50
            End If
        End If


    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True
        counter = 0


    End Sub

    
   
End Class

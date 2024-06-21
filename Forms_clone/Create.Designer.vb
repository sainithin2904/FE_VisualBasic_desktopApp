<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        BindingSource1 = New BindingSource(components)
        Button2 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Timer1 = New Timer(components)
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(290, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(217, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(220, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(290, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(290, 234)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(227, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(146, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 20)
        Label3.TabIndex = 5
        Label3.Text = "Contact_Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(181, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 6
        Label4.Text = "Github_Link"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(290, 291)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(227, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button1.Location = New Point(301, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 29)
        Button1.TabIndex = 8
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(261, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(287, 20)
        Label5.TabIndex = 9
        Label5.Text = "Sai Nithin,Slidely Task2-Create Submission"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PeachPuff
        Button2.Location = New Point(89, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 29)
        Button2.TabIndex = 10
        Button2.Text = "ToggleTimer ( CTRL + T )"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Simplex_IV25", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(289, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 25)
        Label6.TabIndex = 11
        Label6.Text = "00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Simplex_IV25", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(320, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(19, 23)
        Label7.TabIndex = 12
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Simplex_IV25", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(338, 341)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 25)
        Label8.TabIndex = 13
        Label8.Text = "00"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(369, 341)
        Label9.Name = "Label9"
        Label9.Size = New Size(12, 20)
        Label9.TabIndex = 14
        Label9.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Simplex_IV25", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(387, 341)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 25)
        Label10.TabIndex = 15
        Label10.Text = "00"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Create
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 495)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        KeyPreview = True
        Name = "Create"
        Text = "Create"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
End Class

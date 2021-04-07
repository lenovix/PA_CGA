<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFill = New System.Windows.Forms.RadioButton()
        Me.rbHollow = New System.Windows.Forms.RadioButton()
        Me.Canvas = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_Blue = New System.Windows.Forms.RadioButton()
        Me.rb_Red = New System.Windows.Forms.RadioButton()
        Me.rb_Green = New System.Windows.Forms.RadioButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Canvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 431)
        Me.SplitContainer1.SplitterDistance = 205
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFill)
        Me.GroupBox1.Controls.Add(Me.rbHollow)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'rbFill
        '
        Me.rbFill.AutoSize = True
        Me.rbFill.Checked = True
        Me.rbFill.Location = New System.Drawing.Point(13, 47)
        Me.rbFill.Name = "rbFill"
        Me.rbFill.Size = New System.Drawing.Size(49, 17)
        Me.rbFill.TabIndex = 2
        Me.rbFill.TabStop = True
        Me.rbFill.Text = "Filled"
        Me.rbFill.UseVisualStyleBackColor = True
        '
        'rbHollow
        '
        Me.rbHollow.AutoSize = True
        Me.rbHollow.Location = New System.Drawing.Point(13, 21)
        Me.rbHollow.Name = "rbHollow"
        Me.rbHollow.Size = New System.Drawing.Size(57, 17)
        Me.rbHollow.TabIndex = 1
        Me.rbHollow.Text = "Hollow"
        Me.rbHollow.UseVisualStyleBackColor = True
        '
        'Canvas
        '
        Me.Canvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Canvas.Location = New System.Drawing.Point(0, 0)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(669, 431)
        Me.Canvas.TabIndex = 0
        Me.Canvas.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_Green)
        Me.GroupBox2.Controls.Add(Me.rb_Blue)
        Me.GroupBox2.Controls.Add(Me.rb_Red)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 78)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'rb_Blue
        '
        Me.rb_Blue.AutoSize = True
        Me.rb_Blue.BackColor = System.Drawing.Color.Blue
        Me.rb_Blue.Location = New System.Drawing.Point(13, 47)
        Me.rb_Blue.Name = "rb_Blue"
        Me.rb_Blue.Size = New System.Drawing.Size(46, 17)
        Me.rb_Blue.TabIndex = 2
        Me.rb_Blue.Text = "Blue"
        Me.rb_Blue.UseVisualStyleBackColor = False
        '
        'rb_Red
        '
        Me.rb_Red.AutoSize = True
        Me.rb_Red.BackColor = System.Drawing.Color.Red
        Me.rb_Red.Checked = True
        Me.rb_Red.Location = New System.Drawing.Point(13, 21)
        Me.rb_Red.Name = "rb_Red"
        Me.rb_Red.Size = New System.Drawing.Size(45, 17)
        Me.rb_Red.TabIndex = 1
        Me.rb_Red.TabStop = True
        Me.rb_Red.Text = "Red"
        Me.rb_Red.UseVisualStyleBackColor = False
        '
        'rb_Green
        '
        Me.rb_Green.AutoSize = True
        Me.rb_Green.BackColor = System.Drawing.Color.Lime
        Me.rb_Green.Location = New System.Drawing.Point(105, 21)
        Me.rb_Green.Name = "rb_Green"
        Me.rb_Green.Size = New System.Drawing.Size(54, 17)
        Me.rb_Green.TabIndex = 3
        Me.rb_Green.Text = "Green"
        Me.rb_Green.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 431)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Programming Assignment 10 CL3"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbFill As RadioButton
    Friend WithEvents rbHollow As RadioButton
    Friend WithEvents Canvas As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_Green As RadioButton
    Friend WithEvents rb_Blue As RadioButton
    Friend WithEvents rb_Red As RadioButton
    Friend WithEvents ColorDialog2 As ColorDialog
End Class

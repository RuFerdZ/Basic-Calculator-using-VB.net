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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num1txt = New System.Windows.Forms.TextBox()
        Me.num2txt = New System.Windows.Forms.TextBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.outputtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.square = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Output                :"
        '
        'num1txt
        '
        Me.num1txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1txt.Location = New System.Drawing.Point(253, 59)
        Me.num1txt.Name = "num1txt"
        Me.num1txt.Size = New System.Drawing.Size(190, 31)
        Me.num1txt.TabIndex = 2
        Me.num1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num2txt
        '
        Me.num2txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2txt.Location = New System.Drawing.Point(253, 97)
        Me.num2txt.Name = "num2txt"
        Me.num2txt.Size = New System.Drawing.Size(190, 31)
        Me.num2txt.TabIndex = 2
        Me.num2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(305, 205)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(80, 50)
        Me.cancelbtn.TabIndex = 0
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'outputtxt
        '
        Me.outputtxt.Enabled = False
        Me.outputtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputtxt.Location = New System.Drawing.Point(253, 139)
        Me.outputtxt.Name = "outputtxt"
        Me.outputtxt.Size = New System.Drawing.Size(190, 31)
        Me.outputtxt.TabIndex = 2
        Me.outputtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Number 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Input Number 1 :"
        '
        'square
        '
        Me.square.Location = New System.Drawing.Point(237, 205)
        Me.square.Name = "square"
        Me.square.Size = New System.Drawing.Size(50, 50)
        Me.square.TabIndex = 0
        Me.square.Text = "X^2"
        Me.square.UseVisualStyleBackColor = True
        '
        'divide
        '
        Me.divide.Location = New System.Drawing.Point(181, 205)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(50, 50)
        Me.divide.TabIndex = 0
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = True
        '
        'multiply
        '
        Me.multiply.Location = New System.Drawing.Point(125, 205)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(50, 50)
        Me.multiply.TabIndex = 0
        Me.multiply.Text = "x"
        Me.multiply.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(70, 205)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(50, 50)
        Me.minus.TabIndex = 0
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(14, 205)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(50, 50)
        Me.add.TabIndex = 0
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(401, 205)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(80, 50)
        Me.exitbtn.TabIndex = 0
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 305)
        Me.Controls.Add(Me.outputtxt)
        Me.Controls.Add(Me.num2txt)
        Me.Controls.Add(Me.num1txt)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.square)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents num1txt As TextBox
    Friend WithEvents num2txt As TextBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents outputtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents square As Button
    Friend WithEvents divide As Button
    Friend WithEvents multiply As Button
    Friend WithEvents minus As Button
    Friend WithEvents add As Button
    Friend WithEvents exitbtn As Button
End Class

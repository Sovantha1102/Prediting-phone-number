<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formgame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formgame))
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(336, 105)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(248, 41)
        Me.txtNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខទូរស័ព្ធ"
        '
        'TxtResult
        '
        Me.TxtResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtResult.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(106, 286)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(478, 259)
        Me.TxtResult.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "លទ្ធផល"
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Khmer OS Battambang", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(442, 166)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(142, 47)
        Me.btnCal.TabIndex = 4
        Me.btnCal.Text = "គណនា"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Font = New System.Drawing.Font("Khmer OS Battambang", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.Location = New System.Drawing.Point(442, 219)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(142, 47)
        Me.btnClean.TabIndex = 5
        Me.btnClean.Text = "សំអាត"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'Formgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 622)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Formgame"
        Me.Text = "Prediting phone number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClean As Button
End Class

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
        Me.inputName = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.inputAddress = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.Label()
        Me.inputAge = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.Button()
        Me.xml = New System.Windows.Forms.Button()
        Me.json = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputName
        '
        Me.inputName.Location = New System.Drawing.Point(39, 47)
        Me.inputName.Name = "inputName"
        Me.inputName.Size = New System.Drawing.Size(235, 20)
        Me.inputName.TabIndex = 1
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(36, 83)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(45, 13)
        Me.address.TabIndex = 0
        Me.address.Text = "Address"
        '
        'inputAddress
        '
        Me.inputAddress.Location = New System.Drawing.Point(39, 99)
        Me.inputAddress.Multiline = True
        Me.inputAddress.Name = "inputAddress"
        Me.inputAddress.Size = New System.Drawing.Size(333, 51)
        Me.inputAddress.TabIndex = 1
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Location = New System.Drawing.Point(291, 31)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(26, 13)
        Me.age.TabIndex = 0
        Me.age.Text = "Age"
        '
        'inputAge
        '
        Me.inputAge.Location = New System.Drawing.Point(294, 47)
        Me.inputAge.Name = "inputAge"
        Me.inputAge.Size = New System.Drawing.Size(78, 20)
        Me.inputAge.TabIndex = 1
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(212, 166)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(160, 23)
        Me.txt.TabIndex = 2
        Me.txt.Text = "Save as Text Documents (.txt)"
        Me.txt.UseVisualStyleBackColor = True
        '
        'xml
        '
        Me.xml.Location = New System.Drawing.Point(212, 195)
        Me.xml.Name = "xml"
        Me.xml.Size = New System.Drawing.Size(160, 23)
        Me.xml.TabIndex = 2
        Me.xml.Text = "Save as XML Data (.xml)"
        Me.xml.UseVisualStyleBackColor = True
        '
        'json
        '
        Me.json.Location = New System.Drawing.Point(212, 224)
        Me.json.Name = "json"
        Me.json.Size = New System.Drawing.Size(160, 23)
        Me.json.TabIndex = 2
        Me.json.Text = "Save as JSON File (.json)"
        Me.json.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(39, 31)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 4
        Me.nameLabel.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 270)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.json)
        Me.Controls.Add(Me.xml)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.inputAge)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.inputAddress)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.inputName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputName As TextBox
    Friend WithEvents address As Label
    Friend WithEvents inputAddress As TextBox
    Friend WithEvents age As Label
    Friend WithEvents inputAge As TextBox
    Friend WithEvents txt As Button
    Friend WithEvents xml As Button
    Friend WithEvents json As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nameLabel As Label
End Class

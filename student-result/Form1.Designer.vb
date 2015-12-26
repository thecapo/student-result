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
        Me.btnDel = New System.Windows.Forms.Button()
        Me.lstbxResults = New System.Windows.Forms.ListBox()
        Me.lblStudentResult = New System.Windows.Forms.Label()
        Me.txtbxUserInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblMaxResult = New System.Windows.Forms.Label()
        Me.lblMinResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAveResult = New System.Windows.Forms.Label()
        Me.lblItemsResult = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(108, 165)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'lstbxResults
        '
        Me.lstbxResults.FormattingEnabled = True
        Me.lstbxResults.Location = New System.Drawing.Point(257, 42)
        Me.lstbxResults.Name = "lstbxResults"
        Me.lstbxResults.Size = New System.Drawing.Size(120, 199)
        Me.lstbxResults.TabIndex = 1
        '
        'lblStudentResult
        '
        Me.lblStudentResult.AutoSize = True
        Me.lblStudentResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentResult.Location = New System.Drawing.Point(30, 44)
        Me.lblStudentResult.Name = "lblStudentResult"
        Me.lblStudentResult.Size = New System.Drawing.Size(214, 18)
        Me.lblStudentResult.TabIndex = 2
        Me.lblStudentResult.Text = "Enter Student Results: (0 - 100)"
        '
        'txtbxUserInput
        '
        Me.txtbxUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUserInput.Location = New System.Drawing.Point(97, 80)
        Me.txtbxUserInput.Name = "txtbxUserInput"
        Me.txtbxUserInput.Size = New System.Drawing.Size(100, 29)
        Me.txtbxUserInput.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(108, 117)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblMaxResult
        '
        Me.lblMaxResult.AutoSize = True
        Me.lblMaxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxResult.Location = New System.Drawing.Point(508, 44)
        Me.lblMaxResult.Name = "lblMaxResult"
        Me.lblMaxResult.Size = New System.Drawing.Size(36, 39)
        Me.lblMaxResult.TabIndex = 7
        Me.lblMaxResult.Text = "0"
        '
        'lblMinResult
        '
        Me.lblMinResult.AutoSize = True
        Me.lblMinResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinResult.Location = New System.Drawing.Point(508, 108)
        Me.lblMinResult.Name = "lblMinResult"
        Me.lblMinResult.Size = New System.Drawing.Size(36, 39)
        Me.lblMinResult.TabIndex = 8
        Me.lblMinResult.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Maximum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Minimum"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(416, 175)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(81, 24)
        Me.lblAverage.TabIndex = 11
        Me.lblAverage.Text = "Average"
        '
        'lblAveResult
        '
        Me.lblAveResult.AutoSize = True
        Me.lblAveResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveResult.Location = New System.Drawing.Point(508, 175)
        Me.lblAveResult.Name = "lblAveResult"
        Me.lblAveResult.Size = New System.Drawing.Size(36, 39)
        Me.lblAveResult.TabIndex = 12
        Me.lblAveResult.Text = "0"
        '
        'lblItemsResult
        '
        Me.lblItemsResult.AutoSize = True
        Me.lblItemsResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsResult.Location = New System.Drawing.Point(297, 268)
        Me.lblItemsResult.Name = "lblItemsResult"
        Me.lblItemsResult.Size = New System.Drawing.Size(36, 39)
        Me.lblItemsResult.TabIndex = 6
        Me.lblItemsResult.Text = "0"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(253, 244)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(131, 24)
        Me.lblItems.TabIndex = 5
        Me.lblItems.Text = "Items Entered:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 310)
        Me.Controls.Add(Me.lblAveResult)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMinResult)
        Me.Controls.Add(Me.lblMaxResult)
        Me.Controls.Add(Me.lblItemsResult)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtbxUserInput)
        Me.Controls.Add(Me.lblStudentResult)
        Me.Controls.Add(Me.lstbxResults)
        Me.Controls.Add(Me.btnDel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents lstbxResults As System.Windows.Forms.ListBox
    Friend WithEvents lblStudentResult As System.Windows.Forms.Label
    Friend WithEvents txtbxUserInput As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblMaxResult As System.Windows.Forms.Label
    Friend WithEvents lblMinResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblAveResult As System.Windows.Forms.Label
    Friend WithEvents lblItemsResult As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label

End Class

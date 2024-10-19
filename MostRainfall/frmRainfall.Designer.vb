<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRainfall
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
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lblTitle = New Label()
        lblRain = New Label()
        btnEnterRainfall = New Button()
        lblAverageRainfall = New Label()
        lstRainfall = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Verdana", 9F)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(675, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuExit})
        mnuFile.Font = New Font("Verdana", 9F)
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(40, 20)
        mnuFile.Text = "File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Font = New Font("Verdana", 9F)
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(107, 22)
        mnuClear.Text = "Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Font = New Font("Verdana", 9F)
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(107, 22)
        mnuExit.Text = "Exit"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(0, 43)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(443, 32)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Most Rainfall in USA - Kauai "
        ' 
        ' lblRain
        ' 
        lblRain.AutoSize = True
        lblRain.Font = New Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRain.ForeColor = Color.Blue
        lblRain.Location = New Point(127, 93)
        lblRain.Name = "lblRain"
        lblRain.Size = New Size(112, 16)
        lblRain.TabIndex = 2
        lblRain.Text = "Rainfall Average"
        ' 
        ' btnEnterRainfall
        ' 
        btnEnterRainfall.BackColor = Color.DodgerBlue
        btnEnterRainfall.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnterRainfall.Location = New Point(99, 134)
        btnEnterRainfall.Name = "btnEnterRainfall"
        btnEnterRainfall.Size = New Size(171, 33)
        btnEnterRainfall.TabIndex = 3
        btnEnterRainfall.Text = "Enter Rainfall"
        btnEnterRainfall.UseVisualStyleBackColor = False
        ' 
        ' lblAverageRainfall
        ' 
        lblAverageRainfall.AutoSize = True
        lblAverageRainfall.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAverageRainfall.ForeColor = Color.DarkSlateGray
        lblAverageRainfall.Location = New Point(0, 188)
        lblAverageRainfall.Name = "lblAverageRainfall"
        lblAverageRainfall.Size = New Size(73, 23)
        lblAverageRainfall.TabIndex = 4
        lblAverageRainfall.Text = "Label1"
        lblAverageRainfall.Visible = False
        ' 
        ' lstRainfall
        ' 
        lstRainfall.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstRainfall.ForeColor = Color.DarkSlateGray
        lstRainfall.FormattingEnabled = True
        lstRainfall.ItemHeight = 23
        lstRainfall.Location = New Point(513, 27)
        lstRainfall.Name = "lstRainfall"
        lstRainfall.Size = New Size(56, 280)
        lstRainfall.TabIndex = 5
        ' 
        ' frmRainfall
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Hawaii
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(675, 450)
        Controls.Add(lstRainfall)
        Controls.Add(lblAverageRainfall)
        Controls.Add(btnEnterRainfall)
        Controls.Add(lblRain)
        Controls.Add(lblTitle)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmRainfall"
        Text = "Most Rainfall in US"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents btnEnterRainfall As Button
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents lstRainfall As ListBox

End Class

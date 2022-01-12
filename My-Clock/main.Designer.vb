<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.lblRlg = New System.Windows.Forms.Label()
        Me.tmCnt = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblRlg
        '
        Me.lblRlg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRlg.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRlg.ForeColor = System.Drawing.Color.White
        Me.lblRlg.Location = New System.Drawing.Point(0, 0)
        Me.lblRlg.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblRlg.Name = "lblRlg"
        Me.lblRlg.Size = New System.Drawing.Size(610, 317)
        Me.lblRlg.TabIndex = 0
        Me.lblRlg.Text = "00:00:00"
        Me.lblRlg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRlg.UseCompatibleTextRendering = True
        '
        'tmCnt
        '
        Me.tmCnt.Enabled = True
        Me.tmCnt.Interval = 1000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(610, 317)
        Me.Controls.Add(Me.lblRlg)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.Opacity = 0.5R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblRlg As System.Windows.Forms.Label
    Friend WithEvents tmCnt As System.Windows.Forms.Timer

End Class

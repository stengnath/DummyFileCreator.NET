Imports System.Reflection
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout

  Inherits System.Windows.Forms.Form
  Private Shared instanceAbout As frmAbout

  Public Shared Function GetFrmAbout() As frmAbout

    If instanceAbout Is Nothing Then
      instanceAbout = New frmAbout
    End If
    Return instanceAbout
  End Function

  'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.cmdOK = New System.Windows.Forms.Button
    Me.lblVersion = New System.Windows.Forms.Label
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.lblCompany = New System.Windows.Forms.Label
    Me.lblCopyright = New System.Windows.Forms.Label
    Me.PictureBox2 = New System.Windows.Forms.PictureBox
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.Panel1.SuspendLayout()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdOK
    '
    Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
    Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
    Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdOK.Location = New System.Drawing.Point(313, 11)
    Me.cmdOK.Name = "cmdOK"
    Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cmdOK.Size = New System.Drawing.Size(84, 23)
    Me.cmdOK.TabIndex = 4
    Me.cmdOK.Text = "OK"
    Me.cmdOK.UseVisualStyleBackColor = False
    '
    'lblVersion
    '
    Me.lblVersion.BackColor = System.Drawing.Color.White
    Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVersion.Location = New System.Drawing.Point(12, 133)
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVersion.Size = New System.Drawing.Size(169, 15)
    Me.lblVersion.TabIndex = 8
    Me.lblVersion.Text = "Assembly_Version"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.Control
    Me.Panel1.Controls.Add(Me.cmdOK)
    Me.Panel1.Location = New System.Drawing.Point(-1, 173)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(407, 44)
    Me.Panel1.TabIndex = 12
    '
    'lblCompany
    '
    Me.lblCompany.AutoSize = True
    Me.lblCompany.Location = New System.Drawing.Point(12, 118)
    Me.lblCompany.Name = "lblCompany"
    Me.lblCompany.Size = New System.Drawing.Size(101, 13)
    Me.lblCompany.TabIndex = 13
    Me.lblCompany.Text = "Assembly_Company"
    '
    'lblCopyright
    '
    Me.lblCopyright.AutoSize = True
    Me.lblCopyright.Location = New System.Drawing.Point(12, 148)
    Me.lblCopyright.Name = "lblCopyright"
    Me.lblCopyright.Size = New System.Drawing.Size(101, 13)
    Me.lblCopyright.TabIndex = 15
    Me.lblCopyright.Text = "Assembly_Copyright"
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = Global.DummyFileCreator.NET.My.Resources.Resources.DFC
    Me.PictureBox2.Location = New System.Drawing.Point(0, 81)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(404, 31)
    Me.PictureBox2.TabIndex = 17
    Me.PictureBox2.TabStop = False
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.DummyFileCreator.NET.My.Resources.Resources.about
    Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(405, 77)
    Me.PictureBox1.TabIndex = 16
    Me.PictureBox1.TabStop = False
    '
    'frmAbout
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(404, 215)
    Me.Controls.Add(Me.PictureBox2)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.lblCopyright)
    Me.Controls.Add(Me.lblCompany)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.lblVersion)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmAbout"
    Me.Text = "DFC - powered by www.steffen-blogging.de"
    Me.Panel1.ResumeLayout(False)
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents cmdOK As System.Windows.Forms.Button
  Public WithEvents lblVersion As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblCompany As System.Windows.Forms.Label
  Friend WithEvents lblCopyright As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

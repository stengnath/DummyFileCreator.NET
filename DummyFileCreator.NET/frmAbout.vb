Imports System.Reflection

Public Class frmAbout

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAssembly As System.Reflection.AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName

        lblCompany.Text = ObjectHandler.CurrentLanguage.lblCompany & Application.CompanyName
        lblVersion.Text = ObjectHandler.CurrentLanguage.lblVersion & oAssembly.Version.ToString()

        Dim assembType As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        Dim attype As Type = GetType(AssemblyCopyrightAttribute)
        Dim atr() As Object = assembType.GetCustomAttributes(attype, False)
        Dim ct As AssemblyCopyrightAttribute = CType(atr(0), AssemblyCopyrightAttribute)
        lblCopyright.Text = ct.Copyright.ToString
        Me.Location = New Point((SystemInformation.WorkingArea.Right - Me.Width) / 2, (SystemInformation.WorkingArea.Bottom - Me.Height) / 2)
    End Sub
End Class
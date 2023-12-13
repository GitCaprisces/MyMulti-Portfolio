Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class intro
    Private Sub intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ruta de la carpeta donde se encuentran los archivos .vb
        Dim folderPath As String = "C:\Users\Caprindows\Documents\MEGAsync\Caprindows\UANL\PROGVIS_1912527\UPV_1912527"

        'Obtener una lista de los nombres de los archivos .vb en la carpeta especificada
        Dim excludedFormNames As New List(Of String)
        excludedFormNames.Add("Lobby")
        excludedFormNames.Add("intro")
        excludedFormNames.Add("0_LogIn")

        Dim fileNames As String() = IO.Directory.GetFiles(folderPath, "*.vb", IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            If Not fileName.EndsWith(".Designer.vb") Then
                Dim formName As String = IO.Path.GetFileNameWithoutExtension(fileName)
                If Not excludedFormNames.Contains(formName) Then
                    comboForms.Items.Add(formName)
                End If
            End If
        Next
        comboForms.Sorted = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedFormName As String = comboForms.SelectedItem.ToString()
        Dim formNamespace As String = "UPV_1912527"
        'Dim selectedForm As Form = DirectCast(Activator.CreateInstance(Type.GetType(Me.[GetType]().Namespace & "." & selectedFormName)), Form)
        Dim selectedForm As Form = DirectCast(Activator.CreateInstance(Type.GetType(formNamespace & "." & selectedFormName)), Form)
        selectedForm.Show()
    End Sub
End Class
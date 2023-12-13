Imports System.IO

Public Class List


    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the parent directory of the executable's location
        Dim projectDirectory As String = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName

        ' Specify the relative path to the forms directory within the project directory
        Dim formsDirectory As String = Path.Combine(projectDirectory, "PPV_EQUIPO5")

        ' Check if the forms directory exists
        If Directory.Exists(formsDirectory) Then
            ' Get all the form files (assuming .vb or .vbnet extension) in the forms directory
            Dim formFiles As String() = Directory.GetFiles(formsDirectory, "*.vb")

            ' Exclude specific form names
            Dim excludedFormNames As New List(Of String)
            excludedFormNames.Add("intro")
            excludedFormNames.Add("List")
            excludedFormNames.Add("logIn")
            excludedFormNames.Add("Promedio.Designer")
            excludedFormNames.Add("Cilindro.Designer")
            excludedFormNames.Add("Azar.Designer")

            ' Iterate through the form files and add their names to the ComboBox
            For Each formFile As String In formFiles
                If Not formFile.EndsWith(".Designer.vb") Then
                    Dim formName As String = Path.GetFileNameWithoutExtension(formFile)
                    If Not excludedFormNames.Contains(formName) Then
                        ComboVent.Items.Add(formName)
                    End If
                End If
            Next

            ' Sort the ComboBox items
            ComboVent.Sorted = True
        Else
            MessageBox.Show("Forms directory not found!")
            Close()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedFormName As String = ComboVent.SelectedItem()

        Dim selectedForm As Form = DirectCast(Activator.CreateInstance(Type.GetType(Me.[GetType]().Namespace & "." & selectedFormName)), Form)
        'Dim selectedForm As Form = DirectCast(Activator.CreateInstance(Type.GetType(formNamespace & "." & selectedFormName)), Form)
        selectedForm.Show()
    End Sub
End Class
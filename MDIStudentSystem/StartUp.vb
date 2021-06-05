Imports MDIStudentSystem.UI

Module StartUp

    Public MyServer,MyDatabase as String

    Public Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New XFrmHomePage)

    End Sub

End Module

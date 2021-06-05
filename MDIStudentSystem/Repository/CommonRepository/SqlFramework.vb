
Imports System.Data.SqlClient

Namespace Repository.CommonRepository
    Public Class SqlFramework

        Private ReadOnly _defaultConnectionString As String = $"Data Source=DESKTOP-366EVI3;Initial Catalog=Students;Integrated Security=True"
        Private ReadOnly _dbCon As SqlConnection
        Private _dbCmd As SqlCommand


        Public Dbda As SqlDataAdapter
        Public Dbds As DataSet
        Public Dbdt As DataTable


        Public Params As New List(Of SqlParameter)

        Public RecordCount As Integer
        Public Exception As String

        'Default Constractor
        Public Sub New()
            _dbCon = New SqlConnection(_defaultConnectionString)
        End Sub

        'Establish Connection
        Public Sub New(connectString As String)
            _dbCon = New SqlConnection(connectString)
        End Sub

        Public Function CustomConnection(serverName As String, databaseName As String, integratedSecurity As Boolean, Optional userId As String = Nothing, Optional password As String = Nothing) As SqlConnection
            Return New SqlConnection($"Data Source={serverName};Initial Catalog={databaseName};Integrated Security={integratedSecurity}")
        End Function

        'Fire a Sql Query version 1
        Public Sub RunQuery(query As String)

            RecordCount = 0
            Exception = ""

            Try
                _dbCon.Open()

                _dbCmd = New SqlCommand(query, _dbCon)

                Params.ForEach(Sub(p) _dbCmd.Parameters.Add(p))

                Params.Clear()

                Dbds = New DataSet()
                Dbda = New SqlDataAdapter(_dbCmd)
                RecordCount = Dbda.Fill(Dbds)

            Catch ex As Exception
                Exception = "ExecQuery Error: " + vbNewLine + ex.Message
            Finally

                If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
            End Try
        End Sub

        'Fire a Sql Query version 2
        Public Function RunQueryV2(query As String) As DataTable
            RecordCount = 0
            Exception = ""

            Try
                _dbCon.Open()

                _dbCmd = New SqlCommand(query, _dbCon)

                Params.ForEach(Sub(p) _dbCmd.Parameters.Add(p))

                Params.Clear()

                Dbdt = New DataTable()


                Dbda = New SqlDataAdapter(_dbCmd)
                Dbda.Fill(Dbdt)
                RecordCount = Dbdt.Rows.Count

            Catch ex As Exception
                Exception = "ExecQuery Error: " + vbNewLine + ex.Message
            Finally

                If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
            End Try

            Return Dbdt
        End Function

        ' there is an error here
        Public Sub AddParameters(name As String, value As Object)
            Dim newParam As New SqlParameter(name, value)
            Params.Add(newParam)
        End Sub

        Public Function HasException(Optional report As Boolean = False) As Boolean
            If String.IsNullOrEmpty(Exception) Then Return False
            If report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
            Return True
        End Function


    End Class
End Namespace
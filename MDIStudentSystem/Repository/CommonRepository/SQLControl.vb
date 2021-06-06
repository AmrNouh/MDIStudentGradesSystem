Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Threading.Tasks
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql

​
Public Class SqlControl
​
​
​
​
    Private _dbCon As New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
​
​
    Private _dbCmd As SqlCommand
​
    ' DB DATA
    Public Dbda As SqlDataAdapter
    Public Dbdt As DataTable
​
    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)
​
​
    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String
    Public RuningQuery As String
​
    Public Sub New()
    End Sub
​
    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(dbName As String)
        If MyServer Is Nothing Then Return
​
        If dbName Is Nothing Then dbName = MyDataBase & "_Files"
        If dbName = "" Then dbName = MyDataBase & "_Files"
​
        _dbCon = New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
    End Sub
    Public Sub New(serverName As String, dbName As String)
​
​
        _dbCon = New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
    End Sub
    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(query As String, Optional returnIdentity As Boolean = False)
        
        
        'If IsRemoteUser = False Then
        '    If MyServer Is Nothing Then DBDT = New DataTable : Return
        'End If
​
        RuningQuery = query
​
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
​
            _dbCon.Open()
​
            ' CREATE DB COMMAND
​
            _dbCmd = New SqlCommand(query, _dbCon)
​
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) _dbCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            _dbCmd.CommandTimeout = 0
            Dbdt = New DataTable
​
            Dbda = New SqlDataAdapter(_dbCmd)
            Dbda.SelectCommand.CommandTimeout = 700000
            RecordCount = Dbda.Fill(Dbdt)
            Dbdt.CaseSensitive = False
​
            If returnIdentity = True Then
                Dim returnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                _dbCmd = New SqlCommand(returnQuery, _dbCon)
                Dbdt = New DataTable
                Dbda = New SqlDataAdapter(_dbCmd)
                RecordCount = Dbda.Fill(Dbdt)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
​
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
        End Try
    End Sub
'    Public Async Function ExecQueryAsyc(Query As String, Optional ReturnIdentity As Boolean = False) As Task(Of SqlDataSource)

'        If MyServer Is Nothing Then DBDT = New DataTable : Return Nothing
'​
'        DBDT = New DataTable
'        RuningQuery = Query
'​
'        ' RESET QUERY STATS
'        RecordCount = 0
'        Exception = ""
'​
'        Try
'​
'            ' Create and configure an SQL data source.
'            Dim connectionParameters As New MsSqlConnectionParameters(MyServer, MyDataBase, "SA", "Admin123", MsSqlAuthorizationType.SqlServer)
'​
'            Dim dataSource As New DevExpress.DataAccess.Sql.SqlDataSource(connectionParameters)
'            ' Create the "queryInvoices" query that serves as a data member.
'            Dim Q As New CustomSqlQuery()
'            Q.Name = "queryInvoices"
'            Q.Sql = Query
'            Q.Sql = Q.Sql.Replace("ARName", Lang)
'            dataSource.Queries.Add(Q)
'​
'            ' LOAD PARAMS INTO DB COMMAND
'            Params.ForEach(Sub(p) Q.Parameters.Add(New QueryParameter(p.ParameterName.Replace("@", ""), p.GetType, p.Value)))
'​
'            ' CLEAR PARAM LIST
'            Params.Clear()
'​
'            '        Source.DataSource = dataSource
'            ' Populate the data source.
'            Await dataSource.FillAsync()
'​
'​
'​
'            Return dataSource
'​
'        Catch ex As Exception
'            ' CAPTURE ERROR
'​
'            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
'        Finally
'            ' CLOSE CONNECTION
'            If DBCon.State = ConnectionState.Open Then DBCon.Close()
'        End Try
'    End Function
    Public Sub ExecStored(query As String, Optional returnIdentity As Boolean = False)
        If MyServer Is Nothing Then Dbdt = New DataTable : Return
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            _dbCon.Open()
​
            ' CREATE DB COMMAND
            Dim dbCmdStored As New SqlCommand(query, _dbCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) dbCmdStored.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            dbCmdStored.CommandTimeout = 0
            Dbdt = New DataTable
​
            Dbda = New SqlDataAdapter(dbCmdStored)
            Dbda.SelectCommand.CommandTimeout = 0
            RecordCount = Dbda.Fill(Dbdt)
​
            If returnIdentity = True Then
                Dim returnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                dbCmdStored = New SqlCommand(returnQuery, _dbCon)
                Dbdt = New DataTable
                Dbda = New SqlDataAdapter(dbCmdStored)
                RecordCount = Dbda.Fill(Dbdt)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
        End Try
    End Sub
​
    Public Function ExecInteger(query As String) As Object
        If MyServer Is Nothing Then Return Nothing
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            _dbCon.Open()
​
            ' CREATE DB COMMAND
            _dbCmd = New SqlCommand(query, _dbCon)
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) _dbCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            Dbdt = New DataTable
            Dbda = New SqlDataAdapter(_dbCmd)
            RecordCount = Dbda.Fill(Dbdt)
​
            Dim I
            For Each r As DataRow In Dbdt.Rows
                I = Val(r(0).ToString)
            Next
​
            Return I
        Catch ex As Exception
            ' CAPTURE ERROR
​
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            Return 0
        Finally
            ' CLOSE CONNECTION
            If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
​
        End Try
​
    End Function


    Public Function ExecString(query As String) As String
        If MyServer Is Nothing Then Return ""
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            _dbCon.Open()
​
            ' CREATE DB COMMAND
            _dbCmd = New SqlCommand(query, _dbCon)
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) _dbCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            Dbdt = New DataTable
            Dbda = New SqlDataAdapter(_dbCmd)
            RecordCount = Dbda.Fill(Dbdt)
​
            Dim I As String
            For Each r As DataRow In Dbdt.Rows
                I = r(0).ToString
            Next
​
            Return I
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            Return 0
        Finally
            ' CLOSE CONNECTION
            If _dbCon.State = ConnectionState.Open Then _dbCon.Close()
​
        End Try
​
    End Function

​
    ' ADD PARAMS
    Public Sub AddParam(name As String, value As Object)
        Dim newParam As New SqlParameter(name, value)
        Params.Add(newParam)
    End Sub

​
    Public Sub AddParmStructured(name As String, value As Object, structTypeName As String)
        Dim newParam As New SqlParameter(name, value) With {
            .SqlDbType = SqlDbType.Structured,
            .TypeName = structTypeName
        }
        Params.Add(newParam)
    End Sub



    Public Sub AddParmImage(name As String, value As Image)
        If value IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte
            Dim myimage As Image = value
            myimage.Save(mstr, Imaging.ImageFormat.Png)
            arrImage = mstr.GetBuffer
​
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(newParam)
        Else
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(newParam)
        End If
​​
    End Sub


    Public Sub AddParmFile(name As String, filePath As String)
        If filePath IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte = System.IO.File.ReadAllBytes(filePath)
​
​
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(newParam)
        Else
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(newParam)
        End If
​​
    End Sub


    Public Sub AddParmFile(name As String, arr() As Byte)
        If arr IsNot Nothing Then
​
​
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary, arr.Length) With {
                .Value = arr, .Direction = ParameterDirection.Input
            }
            Params.Add(newParam)
        Else
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(newParam)
        End If
​​
    End Sub


    Public Sub AddParmFileStream(name As String, stream As IO.MemoryStream)
​
        Dim arr() As Byte = stream.ToArray
        If arr IsNot Nothing Then
​
​
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary, arr.Length) With {
                .Value = arr, .Direction = ParameterDirection.Input
            }
            Params.Add(newParam)
        Else
            Dim newParam As New SqlParameter(name, SqlDbType.VarBinary) With {
            .Value = DBNull.Value
        }
            Params.Add(newParam)
        End If
​​
    End Sub


    Public Function StreamToByteArray(inputStream As Stream) As Byte()
        Dim bytes = New Byte() {}
        Using memoryStream = New MemoryStream()
            Dim count As Integer
            While ((count = inputStream.Read(bytes, 0, bytes.Length)) > 0)
                memoryStream.Write(bytes, 0, count)
            End While
            Return memoryStream.ToArray()
        End Using
    End Function

End Class
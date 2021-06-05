Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Threading.Tasks
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql

​
Public Class SQLControl
​
​
​
​
    Private DBCon As New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
​
​
    Private DBCmd As SqlCommand
​
    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
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
    Public Sub New(DBName As String)
        If MyServer Is Nothing Then Return
​
        If DBName Is Nothing Then DBName = MyDataBase & "_Files"
        If DBName = "" Then DBName = MyDataBase & "_Files"
​
        DBCon = New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
    End Sub
    Public Sub New(ServerName As String, DBName As String)
​
​
        DBCon = New SqlConnection($"Server={MyServer};Database={MyDataBase};User Id=sa;Password=Admin123;")
    End Sub
    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        
        
        'If IsRemoteUser = False Then
        '    If MyServer Is Nothing Then DBDT = New DataTable : Return
        'End If
​
        RuningQuery = Query
​
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
​
            DBCon.Open()
​
            ' CREATE DB COMMAND
​
            DBCmd = New SqlCommand(Query, DBCon)
​
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            DBCmd.CommandTimeout = 0
            DBDT = New DataTable
​
            DBDA = New SqlDataAdapter(DBCmd)
            DBDA.SelectCommand.CommandTimeout = 700000
            RecordCount = DBDA.Fill(DBDT)
            DBDT.CaseSensitive = False
​
            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                DBCmd = New SqlCommand(ReturnQuery, DBCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmd)
                RecordCount = DBDA.Fill(DBDT)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
​
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub
    Public Async Function ExecQueryAsyc(Query As String, Optional ReturnIdentity As Boolean = False) As Task(Of SqlDataSource)

        If MyServer Is Nothing Then DBDT = New DataTable : Return Nothing
​
        DBDT = New DataTable
        RuningQuery = Query
​
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
​
            ' Create and configure an SQL data source.
            Dim connectionParameters As New MsSqlConnectionParameters(MyServer, MyDataBase, "SA", "Admin123", MsSqlAuthorizationType.SqlServer)
​
            Dim dataSource As New DevExpress.DataAccess.Sql.SqlDataSource(connectionParameters)
            ' Create the "queryInvoices" query that serves as a data member.
            Dim Q As New CustomSqlQuery()
            Q.Name = "queryInvoices"
            Q.Sql = Query
            Q.Sql = Q.Sql.Replace("ARName", Lang)
            dataSource.Queries.Add(Q)
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) Q.Parameters.Add(New QueryParameter(p.ParameterName.Replace("@", ""), p.GetType, p.Value)))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            '        Source.DataSource = dataSource
            ' Populate the data source.
            Await dataSource.FillAsync()
​
​
​
            Return dataSource
​
        Catch ex As Exception
            ' CAPTURE ERROR
​
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Function
    Public Sub ExecStored(Query As String, Optional ReturnIdentity As Boolean = False)
        If MyServer Is Nothing Then DBDT = New DataTable : Return
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            DBCon.Open()
​
            ' CREATE DB COMMAND
            Dim DBCmdStored As New SqlCommand(Query, DBCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmdStored.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            DBCmdStored.CommandTimeout = 0
            DBDT = New DataTable
​
            DBDA = New SqlDataAdapter(DBCmdStored)
            DBDA.SelectCommand.CommandTimeout = 0
            RecordCount = DBDA.Fill(DBDT)
​
            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                DBCmdStored = New SqlCommand(ReturnQuery, DBCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmdStored)
                RecordCount = DBDA.Fill(DBDT)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub
​
    Public Function ExecInteger(Query As String) As Object
        If MyServer Is Nothing Then Return Nothing
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            DBCon.Open()
​
            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
​
            Dim I
            For Each R As DataRow In DBDT.Rows
                I = Val(R(0).ToString)
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
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
​
        End Try
​
    End Function
    Public Function ExecString(Query As String) As String
        If MyServer Is Nothing Then Return ""
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
​
        Try
            DBCon.Open()
​
            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)
​
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
​
            ' CLEAR PARAM LIST
            Params.Clear()
​
            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
​
            Dim I As String
            For Each R As DataRow In DBDT.Rows
                I = R(0).ToString
            Next
​
            Return I
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            Return 0
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
​
        End Try
​
    End Function
​
    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
​
    Public Sub AddParmStructured(Name As String, Value As Object, StructTypeName As String)
        Dim NewParam As New SqlParameter(Name, Value) With {
            .SqlDbType = SqlDbType.Structured,
            .TypeName = StructTypeName
        }
        Params.Add(NewParam)
    End Sub
    Public Sub AddParmImage(Name As String, Value As Image)
        If Value IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte
            Dim myimage As Image = Value
            myimage.Save(mstr, Imaging.ImageFormat.Png)
            arrImage = mstr.GetBuffer
​
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If
​
​
​
    End Sub
    Public Sub AddParmFile(Name As String, filePath As String)
        If filePath IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte = System.IO.File.ReadAllBytes(filePath)
​
​
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If
​
​
​
    End Sub
    Public Sub AddParmFile(Name As String, Arr() As Byte)
        If Arr IsNot Nothing Then
​
​
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, Arr.Length) With {
                .Value = Arr, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If
​
​
​
    End Sub
    Public Sub AddParmFileStream(Name As String, Stream As IO.MemoryStream)
​
        Dim Arr() As Byte = Stream.ToArray
        If Arr IsNot Nothing Then
​
​
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, Arr.Length) With {
                .Value = Arr, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
            .Value = DBNull.Value
        }
            Params.Add(NewParam)
        End If
​
​
​
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
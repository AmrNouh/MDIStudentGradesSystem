
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Dts.Runtime

Namespace Repository.CommonRepository

    <DtsConnection(ConnectionType:="SQLVB", _  
                   DisplayName:="SqlConnectionManager (VB)", _  
                   Description:="Connection manager for Sql Server", _  
                   UITypeName:="SqlConnMgrUIVB.SqlConnMgrUIVB,SqlConnMgrUIVB,Version=1.0.0.0,Culture=neutral,PublicKeyToken=<insert public key token here>")>
    Public Class ConnectionManger
        Inherits ConnectionManagerBase

        ' Default values.  
        Private _serverName As String = "(local)"  
        Private _databaseName As String = "AdventureWorks"  
        Private _connectionString As String = String.Empty  
  
        Private Const CONNECTIONSTRING_TEMPLATE As String = _  
            "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI"  
  
        Public Property ServerName() As String  
            Get  
                Return _serverName  
            End Get  
            Set(ByVal value As String)  
                _serverName = value  
            End Set  
        End Property  
  
        Public Property DatabaseName() As String  
            Get  
                Return _databaseName  
            End Get  
            Set(ByVal value As String)  
                _databaseName = value  
            End Set  
        End Property  
  
        Public Overrides Property ConnectionString() As String  
            Get  
                UpdateConnectionString()  
                Return _connectionString  
            End Get  
            Set(ByVal value As String)  
                _connectionString = value  
            End Set  
        End Property  
  
        Private Sub UpdateConnectionString()  
  
            Dim temporaryString As String = CONNECTIONSTRING_TEMPLATE  
  
            If Not String.IsNullOrEmpty(_serverName) Then  
                temporaryString = temporaryString.Replace("<servername>", _serverName)  
            End If  
            If Not String.IsNullOrEmpty(_databaseName) Then  
                temporaryString = temporaryString.Replace("<databasename>", _databaseName)  
            End If  
  
            _connectionString = temporaryString  
  
        End Sub  

        Public Overrides Function Validate(ByVal infoEvents As Microsoft.SqlServer.Dts.Runtime.IDTSInfoEvents) As Microsoft.SqlServer.Dts.Runtime.DTSExecResult  
  
            If String.IsNullOrEmpty(_serverName) Then  
                infoEvents.FireError(0, "SqlConnectionManager", "No server name specified", String.Empty, 0)  
                Return DTSExecResult.Failure  
            Else  
                Return DTSExecResult.Success  
            End If  
  
        End Function

        Public Overrides Function AcquireConnection(ByVal txn As Object) As Object  
  
            Dim sqlConnection As New SqlConnection  
  
            UpdateConnectionString()  
  
            With sqlConnection  
                .ConnectionString = _connectionString  
                .Open()  
            End With  
  
            Return sqlConnection  
  
        End Function

        Public Overrides Sub ReleaseConnection(ByVal connection As Object)  
  
            Dim sqlConnection As SqlConnection  
  
            sqlConnection = DirectCast(connection, SqlConnection)  
  
            If sqlConnection.State <> ConnectionState.Closed Then  
                sqlConnection.Close()  
            End If  
  
        End Sub

    End Class
End NameSpace
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace CommonValidation
    Public Class EntityValidator
        Implements IDataErrorInfo

        <Browsable(False)>
        Default Public ReadOnly Property Item(ByVal [property] As String) As String Implements IDataErrorInfo.Item
            Get
                Dim propertyDescriptor = TypeDescriptor.GetProperties(Me)([property])
                If propertyDescriptor Is Nothing Then Return String.Empty
                Dim results = New List(Of ValidationResult)()
                Dim result = Validator.TryValidateProperty(propertyDescriptor.GetValue(Me), New ValidationContext(Me, Nothing, Nothing) With {
                                                              .MemberName = [property]
                                                              }, results)
                If Not result Then Return results.First().ErrorMessage
                Return String.Empty
            End Get
        End Property

        <Browsable(False)>
        Public ReadOnly Property [Error] As String Implements IDataErrorInfo.[Error]
            Get
                Dim results = New List(Of ValidationResult)()
                Dim result = Validator.TryValidateObject(Me, New ValidationContext(Me, Nothing, Nothing), results, True)

                If Not result Then
                    Return String.Join(vbLf, results.[Select](Function(x) x.ErrorMessage))
                Else
                    Return Nothing
                End If
            End Get
        End Property

        <Browsable(False)>
        Public ReadOnly Property IsValid As Boolean
            Get
                Return String.IsNullOrEmpty([Error])
            End Get
        End Property

    End Class
End NameSpace
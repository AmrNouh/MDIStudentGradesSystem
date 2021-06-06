Imports System.ComponentModel.DataAnnotations
Imports System.Text

Namespace CommonValidation
    Public Class ModelDataAnnotationCheck
        Implements IModelDataAnnotationCheck

        Public Sb  As New StringBuilder
        Public Sub ValidateModel(Of T)(validate As T) Implements IModelDataAnnotationCheck.ValidateModel
            Dim validateResultList As ICollection(Of ValidationResult) = new List(Of ValidationResult)()
            Dim validateContext As New ValidationContext(validate,Nothing,Nothing)

            if (Not Validator.TryValidateObject(validate,validateContext,validateResultList,validateAllProperties := True)) Then
                For Each validateResult As ValidationResult In validateResultList
                    Sb.Append(validateResult.ErrorMessage).AppendLine()
                Next
            End If
            if (validateResultList.Count > 0 ) Then
                Throw new ArgumentException(Sb.ToString())
            End If
        End Sub
    End Class
End NameSpace
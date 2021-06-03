Imports System.ComponentModel.DataAnnotations
Imports MDIStudentSystem.My.Resources

Namespace Models
    Public Class GradesModel

        <Required(AllowEmptyStrings:=False, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_StudentId_Please_Enter_Student_ID")>
        <Range(1,50000, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_StudentId_Value_of_Id_Can_Not_be_Zero")>
        Public Property StudentId() As Integer

        Public Property SubjectName() As String

        <Required(AllowEmptyStrings := False, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_SubjectGrade_Please_Enter_Subject_Grade")>
        <Range(1,100, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_SubjectGrade_The_Value_of_Subject_Grade_Can_Not_be_Zero")>
        Public Property SubjectGrade() As Single

        <Required(AllowEmptyStrings := False, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_StudentGrade_Please_Enter_Student_Grade")>
        <Range(0,100, ErrorMessageResourceType := GetType(Resources), ErrorMessageResourceName := "GradesModel_StudentGrade_The_Value_of_Student_Grade_Can_Not_be_Greater_The_Subject_Grade")>
        Public Property StudentGrade() As Single

        Public Property Percent() As Single
    End Class
End Namespace
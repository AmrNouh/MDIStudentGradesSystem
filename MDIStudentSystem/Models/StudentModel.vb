Imports DevExpress.XtraEditors
Imports System.ComponentModel.DataAnnotations
Imports MDIStudentSystem.CommonValidation

Namespace Models
    Public Class StudentModel
        Inherits EntityValidator
        Implements IStudentModel

        Public Property Id As Integer Implements IStudentModel.Id

        <Required(AllowEmptyStrings:=False, ErrorMessage:="FirstName Can Not be Empty")>
        <DataType(DataType.Text, ErrorMessage:="FirstName Must be only letter From A-Z Or a-z")>
        <StringLength(40, MinimumLength:=3, ErrorMessage:="First Name Must be between 3 to 40 Characters")>
        <RegularExpression("^[a-zA-Z''-'\s]{1,40}$", ErrorMessage:= "Characters are not allowed.")>
        Public Property FstName As String Implements IStudentModel.FstName

        <Required(AllowEmptyStrings:=False, ErrorMessage:="LastName Can Not be Empty")>
        <DataType(DataType.Text, ErrorMessage:="LastName Must be only letter From A-Z or a-z")>
        <StringLength(40, MinimumLength:=3, ErrorMessage:="LastName Must be between 3 to 40 Characters")>
        <RegularExpression("^[a-zA-Z''-'\s]{1,40}$", ErrorMessage:= "Characters are not allowed.")>
        Public Property LstName As String Implements IStudentModel.LstName

        <Required(AllowEmptyStrings:=False, ErrorMessage:="Email Can Not be Empty")>
        <DataType(DataType.EmailAddress, ErrorMessage:="Invalid Email Address")>
        Public Property EmailAddress As String Implements IStudentModel.EmailAddress
        
        <Required(AllowEmptyStrings:=False, ErrorMessage:="City Name Can Not be Empty")>
        <DataType(DataType.Text, ErrorMessage:="City Name can be Only letter From A-Z or a-z")>
        <StringLength(50, MinimumLength:=3, ErrorMessage:="City Name Must be between 6 to 50 Characters")>
        <RegularExpression("^[a-zA-Z''-'\s]{1,40}$", ErrorMessage:= "Characters are not allowed.")>
        Public Property CityName As String Implements IStudentModel.CityName

        <Required(AllowEmptyStrings:=False, ErrorMessage:="Birthdate Can Not be Empty")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")>
        Public Property Birthdate() As Date Implements IStudentModel.Birthdate

        <Required(AllowEmptyStrings:=False, ErrorMessage:="Image Can Not be Empty, Please Select One")>
        Public Property AvatarPic As Byte() Implements IStudentModel.AvatarPic

        Public Property ValidateString As String Implements IStudentModel.ValidateString
    End Class
End Namespace
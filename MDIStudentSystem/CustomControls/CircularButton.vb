Imports System.Drawing.Drawing2D

Namespace CustomControls
    Public Class CircularButton
        Inherits Button

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)

            Dim graphicsPath As New GraphicsPath
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
            Me.Region = New Region(graphicsPath)
            MyBase.OnPaint(pe)

        End Sub

    End Class
End Namespace
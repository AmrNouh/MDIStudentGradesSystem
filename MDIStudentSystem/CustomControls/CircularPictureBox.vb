﻿Imports System.Drawing.Drawing2D

Public Class CircularPictureBox
    Inherits PictureBox

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)

        Dim graphicsPath As New GraphicsPath
        graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(graphicsPath)
        MyBase.OnPaint(pe)

    End Sub

End Class

Imports System.Drawing.Drawing2D
Public Class Form1
    Private polygons As New List(Of List(Of Point))
    Private newpolygon As List(Of Point) = Nothing
    Private newpoint As Point

    Private Sub Canvas_MouseDown(sender As Object, e As MouseEventArgs) Handles Canvas.MouseDown
        If (newpolygon IsNot Nothing) Then
            If (e.Button = Windows.Forms.MouseButtons.Right) Then
                If (newpolygon.Count > 2) Then polygons.Add(newpolygon)
                newpolygon = Nothing
            Else
                If (newpolygon(newpolygon.Count - 1) <> e.Location) Then
                    newpolygon.Add(e.Location)
                End If
            End If
        Else
            newpolygon = New List(Of Point)()
            newpoint = e.Location
            newpolygon.Add(e.Location)
        End If
        Canvas.Invalidate()
    End Sub
    Private Sub Canvas_MouseMove(sender As Object, e As MouseEventArgs) Handles Canvas.MouseMove
        If (newpolygon Is Nothing) Then Exit Sub
        newpoint = e.Location
        Canvas.Invalidate()
    End Sub

    Dim brush_color As Brush
    Private Sub rb_Red_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Red.CheckedChanged
        If rb_Red.Checked = True Then
            rb_Blue.Checked = False
            rb_Green.Checked = False
            brush_color = Brushes.Red
        End If
    End Sub

    Private Sub rb_Green_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Green.CheckedChanged
        If rb_Green.Checked = True Then
            rb_Blue.Checked = False
            rb_Red.Checked = False
            brush_color = Brushes.Green
        End If
    End Sub

    Private Sub rb_Blue_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Blue.CheckedChanged
        If rb_Blue.Checked = True Then
            rb_Red.Checked = False
            rb_Green.Checked = False
            brush_color = Brushes.Blue
        End If
    End Sub
    Private Sub Canvas_Paint(sender As Object, e As PaintEventArgs) Handles Canvas.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.Clear(Canvas.BackColor)
        For Each polygon As List(Of Point) In polygons
            If rbFill.Checked = True Then
                e.Graphics.FillPolygon(brush_color, polygon.ToArray)
            End If
            e.Graphics.DrawPolygon(Pens.Transparent, polygon.ToArray)
        Next polygon

        If newpolygon IsNot Nothing Then
            If (newpolygon.Count > 1) Then
                e.Graphics.DrawLines(Pens.Green, newpolygon.ToArray)

            End If
            If newpolygon.Count > 0 Then
                Using dashed_pen As New Pen(Color.Green)
                    dashed_pen.DashPattern = New Single() {3, 3}
                    e.Graphics.DrawLine(dashed_pen, newpolygon(newpolygon.Count - 1), newpoint)
                End Using

            End If
        End If
    End Sub


    Private Sub rbHollow_CheckedChanged(sender As Object, e As EventArgs) Handles rbHollow.CheckedChanged
        If rbHollow.Checked = True Then
            rbFill.Checked = False
        End If
    End Sub

    Private Sub rbFill_CheckedChanged(sender As Object, e As EventArgs) Handles rbFill.CheckedChanged
        If rbFill.Checked = True Then
            rbHollow.Checked = False
        End If
    End Sub
End Class

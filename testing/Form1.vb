Imports System.Drawing.Drawing2D
Public Class Form1
    Private polygons As New List(Of List(Of Point))
    Private newpolygon As List(Of Point) = Nothing
    Private newpoint As Point

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
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
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If (newpolygon Is Nothing) Then Exit Sub
        newpoint = e.Location
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.Clear(PictureBox1.BackColor)

        For Each polygon As List(Of Point) In polygons
            e.Graphics.FillPolygon(Brushes.White, polygon.ToArray)
            e.Graphics.DrawPolygon(Pens.Black, polygon.ToArray)
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
End Class

Module Module1
    Sub slideLeft(el As Panel)
        Dim w = el.Left - 260
        Do Until el.Left = w
            el.Left = el.Left - 20
        Loop
        'el.Left = el.Left - 260
    End Sub
End Module

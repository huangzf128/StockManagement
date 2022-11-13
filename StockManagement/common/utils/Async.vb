Imports System.Runtime.CompilerServices

Public Class Async

    Public Shared Sub Process(doWork As Func(Of AsyncVoidMethodBuilder), callback As Action(Of Task))
        Dim task As Task = (New TaskFactory).StartNew(doWork)
        task.ContinueWith(callback)
    End Sub

End Class

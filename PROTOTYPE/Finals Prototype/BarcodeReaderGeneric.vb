Imports ZXing.Common

Friend Class BarcodeReaderGeneric(Of T)
    Private bitmapLuminanceSource As ZXing.Windows.Compatibility.BitmapLuminanceSource

    Public Sub New(bitmapLuminanceSource As ZXing.Windows.Compatibility.BitmapLuminanceSource)
        Me.bitmapLuminanceSource = bitmapLuminanceSource
    End Sub

    Public Property Options As DecodingOptions

    Friend Function Decode(source As ZXing.Windows.Compatibility.BitmapLuminanceSource) As Object
        Throw New NotImplementedException()
    End Function
End Class

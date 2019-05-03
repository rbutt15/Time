Class MainWindow
	Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
		DateAndTimeHost.Text = System.DateTime.Now.ToShortTimeString
	End Sub
End Class

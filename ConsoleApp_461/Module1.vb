Imports OneSignalApi.Api
Imports OneSignalApi.Client
Imports OneSignalApi.Model

Module Module1

    Sub Main()
        Dim appConfig = New Configuration()
        appConfig.BasePath = "https://onesignal.com/api/v1"
        appConfig.AccessToken = "YOUR_ACCESS_TOKEN"
        Dim appInstance = New DefaultApi(appConfig)

        Dim notification = New Notification(appId:="YOUR_APP_ID") With {
            .Contents = New StringMap(en:="Hello World"),
            .IncludedSegments = New List(Of String) From {
                "Subscribed Users"
            }}

        Dim response = appInstance.CreateNotification(notification)

        Console.WriteLine(response.ToJson())
    End Sub

End Module

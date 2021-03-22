Imports Microsoft.AspNet.Membership.OpenAuth

Public Module AuthConfig
    Sub RegisterOpenAuth()
        ' Einzelheiten zur Einrichtung von ASP.NET finden Sie unter https://go.microsoft.com/fwlink/?LinkId=252803
        '-Anwendung für die Unterstützung der Anmeldung über externe Dienste zu erhalten.

        'OpenAuth.AuthenticationClients.AddTwitter(
        '    consumerKey:= "Ihr Twitter-Consumerschlüssel",
        '    consumerSecret:= "Ihr geheimer Twitter-Consumerschlüssel")

        'OpenAuth.AuthenticationClients.AddFacebook(
        '    appId:= "Ihre Facebook-Anwendungs-ID",
        '    appSecret:= "Ihr geheimer Facebook-Anwendungsschlüssel")

        'OpenAuth.AuthenticationClients.AddMicrosoft(
        '    clientId:= "Client-ID Ihres Microsoft-Kontos",
        '    clientSecret:= "Geheimer Schlüssel Ihres Microsoft-Kontos")

        'OpenAuth.AuthenticationClients.AddGoogle()
    End Sub
End Module


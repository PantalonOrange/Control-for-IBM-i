Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json

Public Class DoRestStuffGet
    'Class to GET response from target host

    Private ResponseFromServer As New ResponseFromServer_T

    Private AcceptAllCertifications As New IgnoreSSLErrors

    Public Sub GetJSONData(ByVal RequestURL As String, ByVal User As String, ByVal Password As String)
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications.AcceptAllCertifications
        Dim Auth As String
        Auth = Convert.ToBase64String(Encoding.Default.GetBytes(User.Trim() + ":" + Password.Trim()))
        Try
            Dim Request As HttpWebRequest = CType(WebRequest.Create(RequestURL), HttpWebRequest)
            Request.UserAgent = "IBMi-Control r1 beta"
            Request.Headers("Authorization") = "Basic " + Auth
            Dim Response As HttpWebResponse = CType(Request.GetResponse(), HttpWebResponse)
            Dim DataStream As Stream = Response.GetResponseStream()
            Dim Reader As New StreamReader(DataStream)
            ResponseFromServer.Response = Reader.ReadToEnd()
            Reader.Close()
            ResponseFromServer.Code = Response.StatusCode
            ResponseFromServer.ContentType = Response.ContentType
        Catch ex As WebException
            Dim WebErrorResponse As HttpWebResponse = DirectCast(ex.Response, HttpWebResponse)
            ResponseFromServer.Response = WebErrorResponse.StatusDescription.ToString.Trim()
            ResponseFromServer.Code = WebErrorResponse.StatusCode
            ResponseFromServer.ContentType = WebErrorResponse.ContentType
        End Try
    End Sub

    Public Function _returnJSONStream()
        Return ResponseFromServer
    End Function

End Class

Public Class IgnoreSSLErrors
    Public Function AcceptAllCertifications(ByVal sender As Object,
                                            ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate,
                                            ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain,
                                            ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
End Class

Public Class ResponseFromServer_T
    Public Code As String
    Public ContentType As String
    Public Response As String
End Class

Public Class Credentials_T
    Public User As String
    Public Password As String
End Class
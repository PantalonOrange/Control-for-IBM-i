'DoRestStuff.vb
'Communication classes and functions to get and post data from and to webservice
'Copyright (C)2021 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json

Public Class DoRestStuffGet
    'Class to GET response from target host

    Private ResponseFromServer As New ResponseFromServer_T

    Private AcceptAllCertifications As New IgnoreSSLErrors

    Public Sub GetJSONData(ByVal pRequestURL As String, ByVal pUser As String, ByVal pPassword As String)
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications.AcceptAllCertifications
        Dim Auth As String = Convert.ToBase64String(Encoding.Default.GetBytes(pUser.Trim() + ":" + pPassword.Trim()))
        Try
            Dim Request As HttpWebRequest = CType(WebRequest.Create(pRequestURL), HttpWebRequest)
            Request.Method = "GET"
            Request.UserAgent = "IBMi-Control Activejobs"
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

Public Class DoRestStuffPost
    'Class to post data to the target webservice

    Private ResponseFromServer As New ResponseFromServer_T

    Private AcceptAllCertifications As New IgnoreSSLErrors

    Public Sub PostJSONData(ByVal pRequestURL As String, ByVal pJSONString As String, ByVal pUser As String, ByVal pPassword As String)
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications.AcceptAllCertifications
        Dim Auth As String = Convert.ToBase64String(Encoding.Default.GetBytes(pUser.Trim() + ":" + pPassword.Trim()))
        Try
            'Write streambuffer to socket
            Dim ByteArray() As Byte = Encoding.UTF8.GetBytes(pJSONString)
            Dim Request As HttpWebRequest = CType(WebRequest.Create(pRequestURL), HttpWebRequest)
            Request.Method = "POST"
            Request.UserAgent = "IBMi-Control Activejobs"
            Request.Headers("Authorization") = "Basic " + Auth
            Request.ContentType = "application/json"
            Request.ContentLength = ByteArray.Length
            Dim DataPostStream As Stream = Request.GetRequestStream()
            DataPostStream.Write(ByteArray, 0, ByteArray.Length)
            DataPostStream.Close()

            'Get response from request
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
    'Response template
    Public Code As String
    Public ContentType As String
    Public Response As String
End Class

Public Class Credentials_T
    'Credentials and host info template
    Public User As String
    Public Password As String
End Class
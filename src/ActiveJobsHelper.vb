'ActiveJobsHelper.vb
'Some helping hands and templates
'Copyright (C)2021, 2022 by Christian Brunner


Public Class ActiveJobInfo_T
    Public OrdinalPosition As String
    Public SubSystem As String
    Public JobName As String
    Public JobNameShort As String
    Public JobType As String
    Public JobStatus As String
    Public JobMessage As String
    Public MessageKey As String
    Public AuthorizationName As String
    Public AuthorizationDescription As String
    Public FunctionType As String
    Public FunctionName As String
    Public StorageUsed As Integer
    Public ClientIPAddress As String
    Public JobActiveTime As String
End Class

Public Class EndJob_T
    Public endJobList(0) As endJobList_T
End Class

Public Structure endJobList_T
    Public jobName As String
End Structure

Public Class ReplyMessage_T
    Public replyList(0) As replyList_T
End Class

Public Structure replyList_T
    Public replyMessage As String
    Public messageKey As String
End Structure

Public Class ExecuteCommand_T
    Public executeCommandList(0) As executeCommandList_T
End Class

Public Structure executeCommandList_T
    Public command As String
End Structure
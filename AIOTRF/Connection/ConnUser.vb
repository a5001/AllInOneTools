﻿Imports System.Data.SqlClient
Module ConnUser
    'Module Created By O2PSoftlabs
    Public Function connusers() As SqlConnection
        Dim dcmduser As New SqlCommand
        Dim conuser As SqlConnection

        conuser = New SqlConnection("server=127.0.0.1;uid=MMODB;pwd=Test;database=RF_User;")
        Return conuser
        conuser = Nothing
    End Function
    Public dauser As SqlDataAdapter
    Public dtuser As New DataTable
    Public conuserc = ConnUser.connusers
    Public cmduser As SqlCommand
    Public riuser As SqlCommand
    Public rouser As SqlDataAdapter
    Public sdbuser As Data.SqlClient.SqlDataAdapter
    Public perintahuser As SqlClient.SqlCommand
End Module

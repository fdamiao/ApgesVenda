﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class sistemaintegradovdEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=sistemaintegradovdEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property categoria_tb() As DbSet(Of categoria_tb)
    Public Property detalhes_entradaprodu() As DbSet(Of detalhes_entradaprodu)
    Public Property detalhes_produto() As DbSet(Of detalhes_produto)
    Public Property empresa_tb() As DbSet(Of empresa_tb)
    Public Property entradaproduto_tb() As DbSet(Of entradaproduto_tb)
    Public Property fonecedor_tb() As DbSet(Of fonecedor_tb)
    Public Property produtos_tb() As DbSet(Of produtos_tb)
    Public Property tipousuario_tb() As DbSet(Of tipousuario_tb)
    Public Property usuario_tb() As DbSet(Of usuario_tb)
    Public Property venda_tb() As DbSet(Of venda_tb)

End Class
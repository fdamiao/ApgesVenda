'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class venda_tb
    Public Property idVenda As Integer
    Public Property Data_Venda As Nullable(Of Date)
    Public Property Subtotal_Venda As Nullable(Of Decimal)
    Public Property Iva_Venda As Nullable(Of Decimal)
    Public Property Comentario As String
    Public Property idUsuario As Nullable(Of Integer)
    Public Property Total_Venda As Nullable(Of Decimal)
    Public Property NPedido As Nullable(Of Integer)
    Public Property FormaPagamento As String
    Public Property Data As Nullable(Of Date)

    Public Overridable Property detalhes_produto As ICollection(Of detalhes_produto) = New HashSet(Of detalhes_produto)
    Public Overridable Property usuario_tb As usuario_tb

End Class

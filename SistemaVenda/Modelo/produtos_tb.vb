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

Partial Public Class produtos_tb
    Public Property idProdutos As Integer
    Public Property Produto_Nome As String
    Public Property Produto_Cod_Barra As String
    Public Property Produto_Val_Comp As Nullable(Of Decimal)
    Public Property Produto_Val_Venda As Nullable(Of Decimal)
    Public Property Produto_Stoque As Nullable(Of Integer)
    Public Property Produto_Unidade As String
    Public Property Produto_Referencia As String
    Public Property idCategoria As Nullable(Of Integer)

    Public Overridable Property categoria_tb As categoria_tb
    Public Overridable Property detalhes_entradaprodu As ICollection(Of detalhes_entradaprodu) = New HashSet(Of detalhes_entradaprodu)
    Public Overridable Property detalhes_produto As ICollection(Of detalhes_produto) = New HashSet(Of detalhes_produto)

End Class

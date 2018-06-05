Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Web
Imports System.Net
Imports System.Xml

Public Class frmMain

#Region "Variable Definitions"
    Private connStr As String = "Data Source=PETER-NEW-HOME\SQLEXPRESS;Initial Catalog=EveStaticData;Integrated Security=True;"
    Private tpsURL As String = "http://api.eve-central.com/api/marketstat"
    Private dbEve As New DataSet
#End Region

#Region "Form - functions"

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Load internal tables
        LoadData()

    End Sub

    Private Sub LoadData()

        Dim sqlStr As String
        Dim sqlComm As New SqlCommand
        Dim tempDataAdapter = New SqlDataAdapter()
        Dim sqlConn As New SqlConnection(connStr)

        If Not dbEve.Tables("Groups") Is Nothing Then
            dbEve.Tables("Groups").Constraints.Clear()
            dbEve.Tables("Groups").Clear()
        End If

        If Not dbEve.Tables("Types") Is Nothing Then
            dbEve.Tables("Types").Constraints.Clear()
            dbEve.Tables("Types").Clear()
        End If

        If Not dbEve.Tables("Mats") Is Nothing Then
            dbEve.Tables("Mats").Constraints.Clear()
            dbEve.Tables("Mats").Clear()
        End If

        sqlStr = "SELECT * FROM invMarketGroups"
        sqlConn.Open()
        sqlComm.CommandText = sqlStr
        sqlComm.Connection = sqlConn
        tempDataAdapter.SelectCommand = sqlComm
        tempDataAdapter.Fill(dbEve, "Groups")
        sqlConn.Close()

        sqlStr = "SELECT * FROM invTypes"
        sqlConn.Open()
        sqlComm.CommandText = sqlStr
        sqlComm.Connection = sqlConn
        tempDataAdapter.SelectCommand = sqlComm
        tempDataAdapter.Fill(dbEve, "Types")
        sqlConn.Close()

        sqlStr = "SELECT * FROM invTypeMaterials"
        sqlConn.Open()
        sqlComm.CommandText = sqlStr
        sqlComm.Connection = sqlConn
        tempDataAdapter.SelectCommand = sqlComm
        tempDataAdapter.Fill(dbEve, "Mats")
        sqlConn.Close()

        Me.tcMain.SelectedIndex = 1
        Me.tcMain.SelectedIndex = 0

    End Sub

    Private Sub tcMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcMain.SelectedIndexChanged

        Select Case tcMain.SelectedIndex
            Case Is = 0 'Item details page
                PopulateGroupRootNodes()

        End Select

    End Sub

    Private Sub LoadCurrentPricesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadCurrentPricesToolStripMenuItem.Click

        Dim pricesToGet As DataRow()
        Dim post As StringBuilder
        Dim webReq As HttpWebRequest
        Dim webReader As StreamReader
        Dim xmlDoc As XmlDocument
        Dim xmlBuy, xmlSell As XmlNode

        Dim webResult As String

        pricesToGet = dbEve.Tables("Types").Select("getPrices = 1")

        For Each priceToGet As DataRow In pricesToGet

            Try
                post = New StringBuilder

                With post
                    .AppendFormat("?cachebuster={0}", HttpUtility.UrlEncode("1"))
                    .AppendFormat("&regionlimit={0}", HttpUtility.UrlEncode("10000068"))
                    .AppendFormat("&typeid={0}", HttpUtility.UrlEncode(priceToGet("typeID")))
                End With

                webReq = CType(WebRequest.Create(tpsURL & post.ToString), HttpWebRequest)
                webReq.Method = "GET"

                webReader = New StreamReader(webReq.GetResponse().GetResponseStream())
                webResult = webReader.ReadToEnd
                webReader.Close()

                xmlDoc = New XmlDocument
                xmlDoc.LoadXml(webResult)

                xmlBuy = xmlDoc.SelectSingleNode("/evec_api/marketstat/type/buy")
                xmlSell = xmlDoc.SelectSingleNode("/evec_api/marketstat/type/sell")

                priceToGet("buy") = CDbl(xmlBuy.Item("max").InnerText)
                priceToGet("sell") = CDbl(xmlSell.Item("min").InnerText)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        Next

    End Sub

#End Region

#Region "Item details page - functions"

    Private Sub PopulateGroupRootNodes()

        Me.tvGroups.Nodes.Clear()
        Dim rowList As DataRow()
        Dim tvNode As TreeNode

        rowList = GetGroups("IS NULL")

        For Each row As DataRow In rowList
            tvNode = New TreeNode
            tvNode.Text = row("marketGroupName")
            tvNode.Tag = row("marketGroupID")

            If Not IsDBNull(row("description")) Then
                tvNode.ToolTipText = row("description")
            End If

            PopulateGroupChildNodes("= " & row("marketGroupID"), tvNode)
            Me.tvGroups.Nodes.Add(tvNode)
        Next

    End Sub

    Private Sub PopulateGroupChildNodes(ByVal parent As String, ByVal parentNode As TreeNode)

        Dim rowList As DataRow()
        Dim tvNode As TreeNode

        rowList = GetGroups(parent)

        For Each row As DataRow In rowList
            tvNode = New TreeNode
            tvNode.Text = row("marketGroupName")
            tvNode.Tag = row("marketGroupID")

            If Not IsDBNull(row("description")) Then
                tvNode.ToolTipText = row("description")
            End If

            PopulateGroupChildNodes("= " & row("marketGroupID"), tvNode)
            parentNode.Nodes.Add(tvNode)
        Next

    End Sub

    Private Function GetGroups(ByVal Parent As String) As DataRow()

        GetGroups = dbEve.Tables("Groups").Select("parentGroupID " & Parent, "marketGroupName")

    End Function

    Private Sub tvGroups_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvGroups.NodeMouseClick

        Dim tempNode As TreeNode = DirectCast(e.Node, TreeNode)
        Dim typeList As DataRow()
        Dim typeItem As ListViewItem

        Me.txtGroupDescription.Text = tempNode.ToolTipText
        typeList = dbEve.Tables("Types").Select("marketGroupID = " & tempNode.Tag, "typeName")
        Me.lvTypes.Items.Clear()

        For Each typeListItem As DataRow In typeList
            typeItem = New ListViewItem
            typeItem.Text = typeListItem("typeID")
            typeItem.SubItems.Add(typeListItem("typeName"))

            If Not IsDBNull(typeListItem("description")) Then
                typeItem.Tag = typeListItem("description")
            End If

            Me.lvTypes.Items.Add(typeItem)
        Next

    End Sub

    Private Sub lvTypes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTypes.SelectedIndexChanged

        If lvTypes.FocusedItem Is Nothing Then Exit Sub
        Me.txtTypeDescription.Text = lvTypes.Items(lvTypes.FocusedItem.Index).Tag
        PopulateMats(lvTypes.Items(lvTypes.FocusedItem.Index).SubItems(0).Text)

    End Sub

    Private Sub PopulateMats(ByVal typeID As String)

        Me.lvMats.Items.Clear()

        Dim matsList, matDetails As DataRow()
        Dim matsItem As ListViewItem
        Dim matVal, totVal As Single
        Dim matQty As Integer

        totVal = 0
        matsList = dbEve.Tables("Mats").Select("typeID = " & typeID, "materialTypeID")

        For Each mat As DataRow In matsList
            matDetails = dbEve.Tables("Types").Select("typeID = " & mat("materialTypeID"))
            matsItem = New ListViewItem
            matsItem.Text = matDetails(0)("typeID")
            matsItem.SubItems.Add(matDetails(0)("typeName"))
            matsItem.SubItems.Add(Format(mat("quantity"), "#,##0"))

            If IsDBNull(matDetails(0)("buy")) Then
                matsItem.SubItems.Add("0.00")
                matsItem.SubItems.Add("0.00")
            Else
                matVal = CSng(matDetails(0)("buy"))
                matQty = CInt(mat("quantity"))
                matsItem.SubItems.Add(Format(matVal, "#,##0.00"))
                matsItem.SubItems.Add(Format(matVal * matQty, "#,##0.00"))
                totVal += (matVal * matQty)
            End If

            Me.lvMats.Items.Add(matsItem)
        Next

        Me.lblTotalVal.Text = Format(totVal, "#,##0.00")
    End Sub

#End Region

End Class

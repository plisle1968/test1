<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0")
        Me.tcMain = New System.Windows.Forms.TabControl
        Me.tpItemDetails = New System.Windows.Forms.TabPage
        Me.lblTotalVal = New System.Windows.Forms.Label
        Me.lblTotalValLabel = New System.Windows.Forms.Label
        Me.lvMats = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvTypes = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtTypeDescription = New System.Windows.Forms.TextBox
        Me.txtGroupDescription = New System.Windows.Forms.TextBox
        Me.tvGroups = New System.Windows.Forms.TreeView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.msMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadCurrentPricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tcMain.SuspendLayout()
        Me.tpItemDetails.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpItemDetails)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Location = New System.Drawing.Point(12, 52)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1015, 623)
        Me.tcMain.TabIndex = 0
        '
        'tpItemDetails
        '
        Me.tpItemDetails.Controls.Add(Me.lblTotalVal)
        Me.tpItemDetails.Controls.Add(Me.lblTotalValLabel)
        Me.tpItemDetails.Controls.Add(Me.lvMats)
        Me.tpItemDetails.Controls.Add(Me.lvTypes)
        Me.tpItemDetails.Controls.Add(Me.txtTypeDescription)
        Me.tpItemDetails.Controls.Add(Me.txtGroupDescription)
        Me.tpItemDetails.Controls.Add(Me.tvGroups)
        Me.tpItemDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpItemDetails.Name = "tpItemDetails"
        Me.tpItemDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItemDetails.Size = New System.Drawing.Size(1007, 597)
        Me.tpItemDetails.TabIndex = 0
        Me.tpItemDetails.Text = "Item Details"
        Me.tpItemDetails.UseVisualStyleBackColor = True
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVal.Location = New System.Drawing.Point(760, 484)
        Me.lblTotalVal.MinimumSize = New System.Drawing.Size(200, 0)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(200, 18)
        Me.lblTotalVal.TabIndex = 29
        Me.lblTotalVal.Text = "0.00"
        Me.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalValLabel
        '
        Me.lblTotalValLabel.AutoSize = True
        Me.lblTotalValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValLabel.Location = New System.Drawing.Point(569, 484)
        Me.lblTotalValLabel.Name = "lblTotalValLabel"
        Me.lblTotalValLabel.Size = New System.Drawing.Size(97, 18)
        Me.lblTotalValLabel.TabIndex = 28
        Me.lblTotalValLabel.Text = "Total Value:"
        '
        'lvMats
        '
        Me.lvMats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvMats.FullRowSelect = True
        Me.lvMats.Location = New System.Drawing.Point(558, 6)
        Me.lvMats.MultiSelect = False
        Me.lvMats.Name = "lvMats"
        Me.lvMats.Size = New System.Drawing.Size(443, 457)
        Me.lvMats.TabIndex = 27
        Me.lvMats.UseCompatibleStateImageBehavior = False
        Me.lvMats.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type (Item)"
        Me.ColumnHeader4.Width = 125
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cost ea(ISK)"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total (ISK)"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'lvTypes
        '
        Me.lvTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvTypes.FullRowSelect = True
        Me.lvTypes.Location = New System.Drawing.Point(282, 6)
        Me.lvTypes.MultiSelect = False
        Me.lvTypes.Name = "lvTypes"
        Me.lvTypes.Size = New System.Drawing.Size(270, 496)
        Me.lvTypes.TabIndex = 26
        Me.lvTypes.UseCompatibleStateImageBehavior = False
        Me.lvTypes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type (Item)"
        Me.ColumnHeader2.Width = 245
        '
        'txtTypeDescription
        '
        Me.txtTypeDescription.Enabled = False
        Me.txtTypeDescription.Location = New System.Drawing.Point(282, 508)
        Me.txtTypeDescription.Multiline = True
        Me.txtTypeDescription.Name = "txtTypeDescription"
        Me.txtTypeDescription.Size = New System.Drawing.Size(270, 123)
        Me.txtTypeDescription.TabIndex = 3
        '
        'txtGroupDescription
        '
        Me.txtGroupDescription.Enabled = False
        Me.txtGroupDescription.Location = New System.Drawing.Point(6, 508)
        Me.txtGroupDescription.Multiline = True
        Me.txtGroupDescription.Name = "txtGroupDescription"
        Me.txtGroupDescription.Size = New System.Drawing.Size(270, 123)
        Me.txtGroupDescription.TabIndex = 1
        '
        'tvGroups
        '
        Me.tvGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvGroups.Location = New System.Drawing.Point(6, 6)
        Me.tvGroups.Name = "tvGroups"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Node0"
        Me.tvGroups.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.tvGroups.Size = New System.Drawing.Size(270, 496)
        Me.tvGroups.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1007, 637)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1039, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadCurrentPricesToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'LoadCurrentPricesToolStripMenuItem
        '
        Me.LoadCurrentPricesToolStripMenuItem.Name = "LoadCurrentPricesToolStripMenuItem"
        Me.LoadCurrentPricesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LoadCurrentPricesToolStripMenuItem.Text = "Load Current Prices"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 687)
        Me.Controls.Add(Me.tcMain)
        Me.Controls.Add(Me.msMain)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tcMain.ResumeLayout(False)
        Me.tpItemDetails.ResumeLayout(False)
        Me.tpItemDetails.PerformLayout()
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents tpItemDetails As System.Windows.Forms.TabPage
    Friend WithEvents tvGroups As System.Windows.Forms.TreeView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtGroupDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeDescription As System.Windows.Forms.TextBox
    Friend WithEvents lvTypes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvMats As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalValLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotalVal As System.Windows.Forms.Label
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadCurrentPricesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

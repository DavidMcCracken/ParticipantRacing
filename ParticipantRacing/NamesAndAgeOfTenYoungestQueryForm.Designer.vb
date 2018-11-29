<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NamesAndAgeOfTenYoungestQueryForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NamesAndAgeOfTenYoungestQueryForm))
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSet()
        Me.Query6_NamesAndAgesOfTenYoungestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query6_NamesAndAgesOfTenYoungestTableAdapter = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query6_NamesAndAgesOfTenYoungestTableAdapter()
        Me.TableAdapterManager = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query6_NamesAndAgesOfTenYoungestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.SuspendLayout()
        CType(Me.Query6_NamesAndAgesOfTenYoungestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.DataSetName = "_HW3_PROJ_13_BOULDER_2003_versionDataSet"
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query6_NamesAndAgesOfTenYoungestBindingSource
        '
        Me.Query6_NamesAndAgesOfTenYoungestBindingSource.DataMember = "Query6-NamesAndAgesOfTenYoungest"
        Me.Query6_NamesAndAgesOfTenYoungestBindingSource.DataSource = Me._HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        'Query6_NamesAndAgesOfTenYoungestTableAdapter
        '
        Me.Query6_NamesAndAgesOfTenYoungestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblParticipantTableAdapter = Nothing
        Me.TableAdapterManager.tblRaceTableAdapter = Nothing
        Me.TableAdapterManager.tblRunTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Query6_NamesAndAgesOfTenYoungestBindingNavigator
        '
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.BindingSource = Me.Query6_NamesAndAgesOfTenYoungestBindingSource
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem})
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.Name = "Query6_NamesAndAgesOfTenYoungestBindingNavigator"
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.TabIndex = 0
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem
        '
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Enabled = False
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Image = CType(resources.GetObject("Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Name = "Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem"
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Query6_NamesAndAgesOfTenYoungestDataGridView
        '
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.AutoGenerateColumns = False
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.DataSource = Me.Query6_NamesAndAgesOfTenYoungestBindingSource
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.Name = "Query6_NamesAndAgesOfTenYoungestDataGridView"
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.Size = New System.Drawing.Size(560, 391)
        Me.Query6_NamesAndAgesOfTenYoungestDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ParticipantName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ParticipantName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 425)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(142, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NamesAndAgeOfTenYoungestQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Query6_NamesAndAgesOfTenYoungestDataGridView)
        Me.Controls.Add(Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator)
        Me.Name = "NamesAndAgeOfTenYoungestQueryForm"
        Me.Text = "NamesAndAgeOfTenYoungestQueryForm"
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query6_NamesAndAgesOfTenYoungestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.ResumeLayout(False)
        Me.Query6_NamesAndAgesOfTenYoungestBindingNavigator.PerformLayout()
        CType(Me.Query6_NamesAndAgesOfTenYoungestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HW3_PROJ_13_BOULDER_2003_versionDataSet As _HW3_PROJ_13_BOULDER_2003_versionDataSet
    Friend WithEvents Query6_NamesAndAgesOfTenYoungestBindingSource As BindingSource
    Friend WithEvents Query6_NamesAndAgesOfTenYoungestTableAdapter As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query6_NamesAndAgesOfTenYoungestTableAdapter
    Friend WithEvents TableAdapterManager As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Query6_NamesAndAgesOfTenYoungestBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Query6_NamesAndAgesOfTenYoungestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Query6_NamesAndAgesOfTenYoungestDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageAgeOfTopOnePercentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AverageAgeOfTopOnePercentForm))
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSet()
        Me.Query5_AverageTopOnePercentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query5_AverageTopOnePercentTableAdapter = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query5_AverageTopOnePercentTableAdapter()
        Me.TableAdapterManager = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.Query5_AverageTopOnePercentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Query5_AverageTopOnePercentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query5_AverageTopOnePercentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query5_AverageTopOnePercentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Query5_AverageTopOnePercentBindingNavigator.SuspendLayout()
        CType(Me.Query5_AverageTopOnePercentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.DataSetName = "_HW3_PROJ_13_BOULDER_2003_versionDataSet"
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query5_AverageTopOnePercentBindingSource
        '
        Me.Query5_AverageTopOnePercentBindingSource.DataMember = "Query5-AverageTopOnePercent"
        Me.Query5_AverageTopOnePercentBindingSource.DataSource = Me._HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        'Query5_AverageTopOnePercentTableAdapter
        '
        Me.Query5_AverageTopOnePercentTableAdapter.ClearBeforeFill = True
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
        'Query5_AverageTopOnePercentBindingNavigator
        '
        Me.Query5_AverageTopOnePercentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Query5_AverageTopOnePercentBindingNavigator.BindingSource = Me.Query5_AverageTopOnePercentBindingSource
        Me.Query5_AverageTopOnePercentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Query5_AverageTopOnePercentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Query5_AverageTopOnePercentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem})
        Me.Query5_AverageTopOnePercentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Query5_AverageTopOnePercentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Query5_AverageTopOnePercentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Query5_AverageTopOnePercentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Query5_AverageTopOnePercentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Query5_AverageTopOnePercentBindingNavigator.Name = "Query5_AverageTopOnePercentBindingNavigator"
        Me.Query5_AverageTopOnePercentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Query5_AverageTopOnePercentBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Query5_AverageTopOnePercentBindingNavigator.TabIndex = 0
        Me.Query5_AverageTopOnePercentBindingNavigator.Text = "BindingNavigator1"
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
        'Query5_AverageTopOnePercentBindingNavigatorSaveItem
        '
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.Enabled = False
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.Image = CType(resources.GetObject("Query5_AverageTopOnePercentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.Name = "Query5_AverageTopOnePercentBindingNavigatorSaveItem"
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Query5_AverageTopOnePercentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Query5_AverageTopOnePercentDataGridView
        '
        Me.Query5_AverageTopOnePercentDataGridView.AutoGenerateColumns = False
        Me.Query5_AverageTopOnePercentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query5_AverageTopOnePercentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Query5_AverageTopOnePercentDataGridView.DataSource = Me.Query5_AverageTopOnePercentBindingSource
        Me.Query5_AverageTopOnePercentDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Query5_AverageTopOnePercentDataGridView.Name = "Query5_AverageTopOnePercentDataGridView"
        Me.Query5_AverageTopOnePercentDataGridView.Size = New System.Drawing.Size(503, 376)
        Me.Query5_AverageTopOnePercentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ParticipantName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ParticipantName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SSN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SSN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FinishTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FinishTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 411)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AverageAgeOfTopOnePercentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Query5_AverageTopOnePercentDataGridView)
        Me.Controls.Add(Me.Query5_AverageTopOnePercentBindingNavigator)
        Me.Name = "AverageAgeOfTopOnePercentForm"
        Me.Text = "AverageAgeOfTopOnePercentForm"
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query5_AverageTopOnePercentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query5_AverageTopOnePercentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Query5_AverageTopOnePercentBindingNavigator.ResumeLayout(False)
        Me.Query5_AverageTopOnePercentBindingNavigator.PerformLayout()
        CType(Me.Query5_AverageTopOnePercentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HW3_PROJ_13_BOULDER_2003_versionDataSet As _HW3_PROJ_13_BOULDER_2003_versionDataSet
    Friend WithEvents Query5_AverageTopOnePercentBindingSource As BindingSource
    Friend WithEvents Query5_AverageTopOnePercentTableAdapter As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query5_AverageTopOnePercentTableAdapter
    Friend WithEvents TableAdapterManager As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Query5_AverageTopOnePercentBindingNavigator As BindingNavigator
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
    Friend WithEvents Query5_AverageTopOnePercentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Query5_AverageTopOnePercentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class

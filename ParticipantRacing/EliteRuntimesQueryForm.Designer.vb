<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliteRuntimesQueryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliteRuntimesQueryForm))
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSet()
        Me.Query1_ByEliteTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query1_ByEliteTimeTableAdapter = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query1_ByEliteTimeTableAdapter()
        Me.TableAdapterManager = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.Query1_ByEliteTimeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Query1_ByEliteTimeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query1_ByEliteTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query1_ByEliteTimeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Query1_ByEliteTimeBindingNavigator.SuspendLayout()
        CType(Me.Query1_ByEliteTimeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.DataSetName = "_HW3_PROJ_13_BOULDER_2003_versionDataSet"
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query1_ByEliteTimeBindingSource
        '
        Me.Query1_ByEliteTimeBindingSource.DataMember = "Query1-ByEliteTime"
        Me.Query1_ByEliteTimeBindingSource.DataSource = Me._HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        'Query1_ByEliteTimeTableAdapter
        '
        Me.Query1_ByEliteTimeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PromptForDateShowFinishOrderTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginInformationTableAdapter = Nothing
        Me.TableAdapterManager.tblParticipantTableAdapter = Nothing
        Me.TableAdapterManager.tblRaceTableAdapter = Nothing
        Me.TableAdapterManager.tblRunTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Query1_ByEliteTimeBindingNavigator
        '
        Me.Query1_ByEliteTimeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Query1_ByEliteTimeBindingNavigator.BindingSource = Me.Query1_ByEliteTimeBindingSource
        Me.Query1_ByEliteTimeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Query1_ByEliteTimeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Query1_ByEliteTimeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Query1_ByEliteTimeBindingNavigatorSaveItem})
        Me.Query1_ByEliteTimeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Query1_ByEliteTimeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Query1_ByEliteTimeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Query1_ByEliteTimeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Query1_ByEliteTimeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Query1_ByEliteTimeBindingNavigator.Name = "Query1_ByEliteTimeBindingNavigator"
        Me.Query1_ByEliteTimeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Query1_ByEliteTimeBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Query1_ByEliteTimeBindingNavigator.TabIndex = 0
        Me.Query1_ByEliteTimeBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Query1_ByEliteTimeBindingNavigatorSaveItem
        '
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.Enabled = False
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Query1_ByEliteTimeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.Name = "Query1_ByEliteTimeBindingNavigatorSaveItem"
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Query1_ByEliteTimeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Query1_ByEliteTimeDataGridView
        '
        Me.Query1_ByEliteTimeDataGridView.AutoGenerateColumns = False
        Me.Query1_ByEliteTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query1_ByEliteTimeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Query1_ByEliteTimeDataGridView.DataSource = Me.Query1_ByEliteTimeBindingSource
        Me.Query1_ByEliteTimeDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.Query1_ByEliteTimeDataGridView.Name = "Query1_ByEliteTimeDataGridView"
        Me.Query1_ByEliteTimeDataGridView.Size = New System.Drawing.Size(543, 308)
        Me.Query1_ByEliteTimeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SSN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SSN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ParticipantName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ParticipantName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(13, 416)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elite Run Times"
        '
        'EliteRuntimesQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Query1_ByEliteTimeDataGridView)
        Me.Controls.Add(Me.Query1_ByEliteTimeBindingNavigator)
        Me.Name = "EliteRuntimesQueryForm"
        Me.Text = "EliteRuntimesQueryForm"
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query1_ByEliteTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query1_ByEliteTimeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Query1_ByEliteTimeBindingNavigator.ResumeLayout(False)
        Me.Query1_ByEliteTimeBindingNavigator.PerformLayout()
        CType(Me.Query1_ByEliteTimeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HW3_PROJ_13_BOULDER_2003_versionDataSet As _HW3_PROJ_13_BOULDER_2003_versionDataSet
    Friend WithEvents Query1_ByEliteTimeBindingSource As BindingSource
    Friend WithEvents Query1_ByEliteTimeTableAdapter As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query1_ByEliteTimeTableAdapter
    Friend WithEvents TableAdapterManager As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Query1_ByEliteTimeBindingNavigator As BindingNavigator
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
    Friend WithEvents Query1_ByEliteTimeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Query1_ByEliteTimeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
End Class

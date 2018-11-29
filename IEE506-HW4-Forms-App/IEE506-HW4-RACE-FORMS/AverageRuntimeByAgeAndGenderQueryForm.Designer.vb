<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageRuntimeByAgeAndGenderQueryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AverageRuntimeByAgeAndGenderQueryForm))
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSet()
        Me.Query4_average_running_times_by_age_and_genderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query4_average_running_times_by_age_and_genderTableAdapter = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query4_average_running_times_by_age_and_genderTableAdapter()
        Me.TableAdapterManager = New IEE506_HW4_RACE_FORMS._HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Query4_average_running_times_by_age_and_genderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query4_average_running_times_by_age_and_genderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query4_average_running_times_by_age_and_genderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.SuspendLayout()
        CType(Me.Query4_average_running_times_by_age_and_genderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.DataSetName = "_HW3_PROJ_13_BOULDER_2003_versionDataSet"
        Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query4_average_running_times_by_age_and_genderBindingSource
        '
        Me.Query4_average_running_times_by_age_and_genderBindingSource.DataMember = "Query4-average-running-times-by-age-and-gender"
        Me.Query4_average_running_times_by_age_and_genderBindingSource.DataSource = Me._HW3_PROJ_13_BOULDER_2003_versionDataSet
        '
        'Query4_average_running_times_by_age_and_genderTableAdapter
        '
        Me.Query4_average_running_times_by_age_and_genderTableAdapter.ClearBeforeFill = True
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
        'Query4_average_running_times_by_age_and_genderBindingNavigator
        '
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.BindingSource = Me.Query4_average_running_times_by_age_and_genderBindingSource
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem})
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.Name = "Query4_average_running_times_by_age_and_genderBindingNavigator"
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.TabIndex = 0
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.Text = "BindingNavigator1"
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
        'Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem
        '
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Enabled = False
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Image = CType(resources.GetObject("Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Name = "Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem"
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Query4_average_running_times_by_age_and_genderDataGridView
        '
        Me.Query4_average_running_times_by_age_and_genderDataGridView.AutoGenerateColumns = False
        Me.Query4_average_running_times_by_age_and_genderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query4_average_running_times_by_age_and_genderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Query4_average_running_times_by_age_and_genderDataGridView.DataSource = Me.Query4_average_running_times_by_age_and_genderBindingSource
        Me.Query4_average_running_times_by_age_and_genderDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Query4_average_running_times_by_age_and_genderDataGridView.Name = "Query4_average_running_times_by_age_and_genderDataGridView"
        Me.Query4_average_running_times_by_age_and_genderDataGridView.Size = New System.Drawing.Size(397, 377)
        Me.Query4_average_running_times_by_age_and_genderDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn2.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AverageTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AverageTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 412)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(125, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AverageRuntimeByAgeAndGenderQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Query4_average_running_times_by_age_and_genderDataGridView)
        Me.Controls.Add(Me.Query4_average_running_times_by_age_and_genderBindingNavigator)
        Me.Name = "AverageRuntimeByAgeAndGenderQueryForm"
        Me.Text = "AverageRuntimeByAgeAndGenderQueryForm"
        CType(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query4_average_running_times_by_age_and_genderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query4_average_running_times_by_age_and_genderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.ResumeLayout(False)
        Me.Query4_average_running_times_by_age_and_genderBindingNavigator.PerformLayout()
        CType(Me.Query4_average_running_times_by_age_and_genderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HW3_PROJ_13_BOULDER_2003_versionDataSet As _HW3_PROJ_13_BOULDER_2003_versionDataSet
    Friend WithEvents Query4_average_running_times_by_age_and_genderBindingSource As BindingSource
    Friend WithEvents Query4_average_running_times_by_age_and_genderTableAdapter As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.Query4_average_running_times_by_age_and_genderTableAdapter
    Friend WithEvents TableAdapterManager As _HW3_PROJ_13_BOULDER_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Query4_average_running_times_by_age_and_genderBindingNavigator As BindingNavigator
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
    Friend WithEvents Query4_average_running_times_by_age_and_genderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Query4_average_running_times_by_age_and_genderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class

Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
        Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
        Dim ClockTransition1 As DevExpress.Utils.Animation.ClockTransition = New DevExpress.Utils.Animation.ClockTransition()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colCentro = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colNivel = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.EjemploPivotGridDataSet1 = New Workspaces.EjemploPivotGridDataSet()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.EjemploPivotGridDataSet11 = New Workspaces.EjemploPivotGridDataSet1()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCartera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImputacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCentro1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ExcelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdMapa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLongitud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosicion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCampo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreColumna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreTabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.CentrosTableAdapter1 = New Workspaces.EjemploPivotGridDataSetTableAdapters.CentrosTableAdapter()
        Me.GeneralTableAdapter1 = New Workspaces.EjemploPivotGridDataSet1TableAdapters.GeneralTableAdapter()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjemploPivotGridDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjemploPivotGridDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.GridControl4)
        Me.LayoutControl1.Controls.Add(Me.ComboBox1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.GridControl3)
        Me.LayoutControl1.Controls.Add(Me.TreeList1)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1079, 305, 450, 400)
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(841, 760)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl4
        '
        Me.GridControl4.Location = New System.Drawing.Point(627, 422)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(202, 324)
        Me.GridControl4.TabIndex = 13
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(342, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(578, 42)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(77, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 11
        Me.SimpleButton2.Text = "Grabar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(659, 42)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(77, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Eliminar"
        '
        'GridControl3
        '
        Me.GridControl3.Location = New System.Drawing.Point(422, 422)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(201, 324)
        Me.GridControl3.TabIndex = 9
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCentro, Me.colNivel})
        Me.TreeList1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeList1.DataMember = "Centros"
        Me.TreeList1.DataSource = Me.EjemploPivotGridDataSet1
        Me.TreeList1.KeyFieldName = "Id"
        Me.TreeList1.Location = New System.Drawing.Point(12, 112)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "IdPadre"
        Me.TreeList1.Size = New System.Drawing.Size(329, 306)
        Me.TreeList1.TabIndex = 8
        '
        'colCentro
        '
        Me.colCentro.FieldName = "Centro"
        Me.colCentro.Name = "colCentro"
        Me.colCentro.Visible = True
        Me.colCentro.VisibleIndex = 0
        Me.colCentro.Width = 156
        '
        'colNivel
        '
        Me.colNivel.FieldName = "Nivel"
        Me.colNivel.Name = "colNivel"
        Me.colNivel.Visible = True
        Me.colNivel.VisibleIndex = 1
        Me.colNivel.Width = 155
        '
        'EjemploPivotGridDataSet1
        '
        Me.EjemploPivotGridDataSet1.DataSetName = "EjemploPivotGridDataSet"
        Me.EjemploPivotGridDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "General"
        Me.GridControl2.DataSource = Me.EjemploPivotGridDataSet11
        Me.GridControl2.Location = New System.Drawing.Point(350, 112)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(479, 306)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'EjemploPivotGridDataSet11
        '
        Me.EjemploPivotGridDataSet11.DataSetName = "EjemploPivotGridDataSet1"
        Me.EjemploPivotGridDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colFecha, Me.colGrupo, Me.colTitular, Me.colCartera, Me.colImputacion, Me.colCentro1, Me.colConcepto, Me.colTipo, Me.colMoneda, Me.colCantidad, Me.colPrecio, Me.colSubtotal})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        '
        'colGrupo
        '
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 2
        '
        'colTitular
        '
        Me.colTitular.FieldName = "Titular"
        Me.colTitular.Name = "colTitular"
        Me.colTitular.Visible = True
        Me.colTitular.VisibleIndex = 3
        '
        'colCartera
        '
        Me.colCartera.FieldName = "Cartera"
        Me.colCartera.Name = "colCartera"
        Me.colCartera.Visible = True
        Me.colCartera.VisibleIndex = 4
        '
        'colImputacion
        '
        Me.colImputacion.FieldName = "Imputacion"
        Me.colImputacion.Name = "colImputacion"
        Me.colImputacion.Visible = True
        Me.colImputacion.VisibleIndex = 5
        '
        'colCentro1
        '
        Me.colCentro1.FieldName = "Centro"
        Me.colCentro1.Name = "colCentro1"
        Me.colCentro1.Visible = True
        Me.colCentro1.VisibleIndex = 6
        '
        'colConcepto
        '
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 7
        '
        'colTipo
        '
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 8
        '
        'colMoneda
        '
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 9
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 10
        '
        'colPrecio
        '
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 11
        '
        'colSubtotal
        '
        Me.colSubtotal.FieldName = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 12
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ExcelDataSource1
        Me.GridControl1.Location = New System.Drawing.Point(83, 422)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(335, 324)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ExcelDataSource1
        '
        Me.ExcelDataSource1.FileName = "C:\Users\mterzolo\Documents\MapasVisa.xlsx"
        Me.ExcelDataSource1.Name = "ExcelDataSource1"
        Me.ExcelDataSource1.ResultSchemaSerializable = resources.GetString("ExcelDataSource1.ResultSchemaSerializable")
        FieldInfo1.Name = "IdMapa"
        FieldInfo1.Type = GetType(Double)
        FieldInfo2.Name = "Longitud"
        FieldInfo2.Type = GetType(Double)
        FieldInfo3.Name = "Posicion"
        FieldInfo3.Type = GetType(Double)
        FieldInfo4.Name = "NombreCampo"
        FieldInfo4.Type = GetType(String)
        FieldInfo5.Name = "Observaciones"
        FieldInfo5.Type = GetType(String)
        FieldInfo6.Name = "NombreColumna"
        FieldInfo6.Type = GetType(String)
        FieldInfo7.Name = "NombreTabla"
        FieldInfo7.Type = GetType(String)
        FieldInfo8.Name = "EsFecha"
        FieldInfo8.Type = GetType(Boolean)
        FieldInfo9.Name = "EsImporte"
        FieldInfo9.Type = GetType(Boolean)
        FieldInfo10.Name = "EsTipo"
        FieldInfo10.Type = GetType(Boolean)
        Me.ExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10})
        ExcelWorksheetSettings1.CellRange = Nothing
        ExcelWorksheetSettings1.WorksheetName = "Hoja1"
        ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
        Me.ExcelDataSource1.SourceOptions = ExcelSourceOptions1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdMapa, Me.colLongitud, Me.colPosicion, Me.colNombreCampo, Me.colObservaciones, Me.colNombreColumna, Me.colNombreTabla, Me.colEsFecha, Me.colEsImporte, Me.colEsTipo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colIdMapa
        '
        Me.colIdMapa.FieldName = "IdMapa"
        Me.colIdMapa.Name = "colIdMapa"
        Me.colIdMapa.Visible = True
        Me.colIdMapa.VisibleIndex = 0
        '
        'colLongitud
        '
        Me.colLongitud.FieldName = "Longitud"
        Me.colLongitud.Name = "colLongitud"
        Me.colLongitud.Visible = True
        Me.colLongitud.VisibleIndex = 1
        '
        'colPosicion
        '
        Me.colPosicion.FieldName = "Posicion"
        Me.colPosicion.Name = "colPosicion"
        Me.colPosicion.Visible = True
        Me.colPosicion.VisibleIndex = 2
        '
        'colNombreCampo
        '
        Me.colNombreCampo.FieldName = "NombreCampo"
        Me.colNombreCampo.Name = "colNombreCampo"
        Me.colNombreCampo.Visible = True
        Me.colNombreCampo.VisibleIndex = 3
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 4
        '
        'colNombreColumna
        '
        Me.colNombreColumna.FieldName = "NombreColumna"
        Me.colNombreColumna.Name = "colNombreColumna"
        Me.colNombreColumna.Visible = True
        Me.colNombreColumna.VisibleIndex = 5
        '
        'colNombreTabla
        '
        Me.colNombreTabla.FieldName = "NombreTabla"
        Me.colNombreTabla.Name = "colNombreTabla"
        Me.colNombreTabla.Visible = True
        Me.colNombreTabla.VisibleIndex = 6
        '
        'colEsFecha
        '
        Me.colEsFecha.FieldName = "EsFecha"
        Me.colEsFecha.Name = "colEsFecha"
        Me.colEsFecha.Visible = True
        Me.colEsFecha.VisibleIndex = 7
        '
        'colEsImporte
        '
        Me.colEsImporte.FieldName = "EsImporte"
        Me.colEsImporte.Name = "colEsImporte"
        Me.colEsImporte.Visible = True
        Me.colEsImporte.VisibleIndex = 8
        '
        'colEsTipo
        '
        Me.colEsTipo.FieldName = "EsTipo"
        Me.colEsTipo.Name = "colEsTipo"
        Me.colEsTipo.Visible = True
        Me.colEsTipo.VisibleIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SplitterItem1, Me.SimpleSeparator1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlGroup2, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(841, 760)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(333, 84)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 326)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 738)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(821, 2)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 410)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(410, 328)
        Me.LayoutControlItem3.Text = "Segunda Grilla"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GridControl2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(338, 84)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(483, 326)
        Me.LayoutControlItem4.Text = "Grilla"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TreeList1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(333, 326)
        Me.LayoutControlItem1.Text = "Jerarquia"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl3
        Me.LayoutControlItem5.Location = New System.Drawing.Point(410, 410)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(205, 328)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(821, 84)
        Me.LayoutControlGroup2.Text = "Controles"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(635, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(81, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.Location = New System.Drawing.Point(554, 0)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(81, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(318, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ComboBox1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(318, 0)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(24, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(236, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl4
        Me.LayoutControlItem8.Location = New System.Drawing.Point(615, 410)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(206, 328)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = ClockTransition1
        '
        'CentrosTableAdapter1
        '
        Me.CentrosTableAdapter1.ClearBeforeFill = True
        '
        'GeneralTableAdapter1
        '
        Me.GeneralTableAdapter1.ClearBeforeFill = True
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel1.FloatLocation = New System.Drawing.Point(1169, 122)
        Me.DockPanel1.ID = New System.Guid("8397970e-cb55-4a16-9840-d04af739f332")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Text = "DockPanel1"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(192, 172)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel2.FloatLocation = New System.Drawing.Point(1169, 322)
        Me.DockPanel2.ID = New System.Guid("70d4021b-5adf-42d8-8490-a6845ca1ebe6")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Text = "DockPanel2"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(192, 172)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel3.FloatLocation = New System.Drawing.Point(1169, 522)
        Me.DockPanel3.ID = New System.Guid("e2c4f084-a4ab-4f4e-a0d8-86bcd79d2024")
        Me.DockPanel3.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Size = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Text = "DockPanel3"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(192, 172)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.Location = New System.Drawing.Point(740, 42)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(77, 38)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 14
        Me.SimpleButton3.Text = "Mostrar Ocultos"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton3
        Me.LayoutControlItem9.Location = New System.Drawing.Point(716, 0)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(81, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(841, 760)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjemploPivotGridDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjemploPivotGridDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCentro As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colNivel As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents EjemploPivotGridDataSet1 As Workspaces.EjemploPivotGridDataSet
    Friend WithEvents CentrosTableAdapter1 As Workspaces.EjemploPivotGridDataSetTableAdapters.CentrosTableAdapter
    Friend WithEvents ExcelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
    Friend WithEvents colIdMapa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLongitud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosicion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCampo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreColumna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreTabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EjemploPivotGridDataSet11 As Workspaces.EjemploPivotGridDataSet1
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImputacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCentro1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GeneralTableAdapter1 As Workspaces.EjemploPivotGridDataSet1TableAdapters.GeneralTableAdapter
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

#End Region

End Class

namespace CareFusion.ITSystemSimulator
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStorageSystemStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupConnection = new System.Windows.Forms.GroupBox();
            this.checkAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblTenantId = new System.Windows.Forms.Label();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.checkAutomaticStateObservation = new System.Windows.Forms.CheckBox();
            this.tabControlStorageSystem = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.btnReloadStock = new System.Windows.Forms.Button();
            this.splitArticles = new System.Windows.Forms.SplitContainer();
            this.dataGridArticles = new System.Windows.Forms.DataGridView();
            this.dataGridPacks = new System.Windows.Forms.DataGridView();
            this.txtArticleFilter = new System.Windows.Forms.TextBox();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.groupInputLog = new System.Windows.Forms.GroupBox();
            this.btnClearInputLog = new System.Windows.Forms.Button();
            this.listInputLog = new System.Windows.Forms.ListBox();
            this.groupInputOptions = new System.Windows.Forms.GroupBox();
            this.checkEnforceSerialNumberNewDelivery = new System.Windows.Forms.CheckBox();
            this.checkEnforceSerialNumberStockReturn = new System.Windows.Forms.CheckBox();
            this.checkBoxSetVirtualArticle = new System.Windows.Forms.CheckBox();
            this.checkOnlyArticlesFromList = new System.Windows.Forms.CheckBox();
            this.txtOverwriteStockLocation = new System.Windows.Forms.TextBox();
            this.checkOverwriteStockLocation = new System.Windows.Forms.CheckBox();
            this.lblDefExpiryDate = new System.Windows.Forms.Label();
            this.numExpiryDateMonth = new System.Windows.Forms.NumericUpDown();
            this.checkEnforceLocationNewDelivery = new System.Windows.Forms.CheckBox();
            this.checkEnforceLocationStockReturn = new System.Windows.Forms.CheckBox();
            this.checkSetSubItemQuantity = new System.Windows.Forms.CheckBox();
            this.checkEnforcePickingIndicator = new System.Windows.Forms.CheckBox();
            this.checkOnlyFridgeInput = new System.Windows.Forms.CheckBox();
            this.checkAllowStockReturnInput = new System.Windows.Forms.CheckBox();
            this.checkEnforceExpiryDateDelivery = new System.Windows.Forms.CheckBox();
            this.checkEnforceExpiryDateStockReturn = new System.Windows.Forms.CheckBox();
            this.checkEnforceBatchDelivery = new System.Windows.Forms.CheckBox();
            this.checkEnforceBatchStockReturn = new System.Windows.Forms.CheckBox();
            this.checkAllowDeliveryInput = new System.Windows.Forms.CheckBox();
            this.tabInitiateInput = new System.Windows.Forms.TabPage();
            this.groupInitInputActivities = new System.Windows.Forms.GroupBox();
            this.btnGetConfig = new System.Windows.Forms.Button();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.txtConfiguration = new System.Windows.Forms.TextBox();
            this.btnClearInitInputLog = new System.Windows.Forms.Button();
            this.listInitInputLog = new System.Windows.Forms.ListBox();
            this.groupInitiatedInputOptions = new System.Windows.Forms.GroupBox();
            this.lblStockLocation = new System.Windows.Forms.Label();
            this.txtPackStockLocation = new System.Windows.Forms.TextBox();
            this.numDestination = new System.Windows.Forms.NumericUpDown();
            this.lblDestination = new System.Windows.Forms.Label();
            this.numInputPoint = new System.Windows.Forms.NumericUpDown();
            this.lblInputPoint = new System.Windows.Forms.Label();
            this.btnSendInitInputRequest = new System.Windows.Forms.Button();
            this.cmbPackShape = new System.Windows.Forms.ComboBox();
            this.lblPackShape = new System.Windows.Forms.Label();
            this.numPackHeight = new System.Windows.Forms.NumericUpDown();
            this.lblPackHeight = new System.Windows.Forms.Label();
            this.numPackWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPackWidth = new System.Windows.Forms.Label();
            this.numPackDepth = new System.Windows.Forms.NumericUpDown();
            this.lblPackDepth = new System.Windows.Forms.Label();
            this.numPackSubItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPackSubItemQuantity = new System.Windows.Forms.Label();
            this.lblPackExpiryDate = new System.Windows.Forms.Label();
            this.txtPackExpiryDate = new System.Windows.Forms.TextBox();
            this.lblPackBatchNumber = new System.Windows.Forms.Label();
            this.txtPackBatchNumber = new System.Windows.Forms.TextBox();
            this.lblPackScanCode = new System.Windows.Forms.Label();
            this.txtPackScanCode = new System.Windows.Forms.TextBox();
            this.numInputSource = new System.Windows.Forms.NumericUpDown();
            this.lblInputSource = new System.Windows.Forms.Label();
            this.lblDeliveryNumber = new System.Windows.Forms.Label();
            this.numInitInputID = new System.Windows.Forms.NumericUpDown();
            this.txtDeliveryNumber = new System.Windows.Forms.TextBox();
            this.lblInitInputID = new System.Windows.Forms.Label();
            this.chkSetPickingIndicator = new System.Windows.Forms.CheckBox();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.groupOrderBoxes = new System.Windows.Forms.GroupBox();
            this.dataGridOrderBoxes = new System.Windows.Forms.DataGridView();
            this.groupOrders = new System.Windows.Forms.GroupBox();
            this.btnBulkOrder = new System.Windows.Forms.Button();
            this.btnClearOrders = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.groupDispensedPacks = new System.Windows.Forms.GroupBox();
            this.dataGridDispensedPacks = new System.Windows.Forms.DataGridView();
            this.groupOrderLabels = new System.Windows.Forms.GroupBox();
            this.dataGridItemLabels = new System.Windows.Forms.DataGridView();
            this.groupOrderItems = new System.Windows.Forms.GroupBox();
            this.dataGridOrderItems = new System.Windows.Forms.DataGridView();
            this.tabMasterArticles = new System.Windows.Forms.TabPage();
            this.groupBoxMasterArticles = new System.Windows.Forms.GroupBox();
            this.dataGridMasterArticles = new System.Windows.Forms.DataGridView();
            this.btnImportSelectArticles = new System.Windows.Forms.Button();
            this.btnGenerateArticles = new System.Windows.Forms.Button();
            this.btnSendMasterArticles = new System.Windows.Forms.Button();
            this.tabStockDeliveries = new System.Windows.Forms.TabPage();
            this.dataGridDeliveryItems = new System.Windows.Forms.DataGridView();
            this.btnSendStockDeliveries = new System.Windows.Forms.Button();
            this.tabTaskInfo = new System.Windows.Forms.TabPage();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.btnGetTaskInfo = new System.Windows.Forms.Button();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.lblTaskStateDesc = new System.Windows.Forms.Label();
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.groupPacks = new System.Windows.Forms.GroupBox();
            this.dataGridPackInfo = new System.Windows.Forms.DataGridView();
            this.groupArticles = new System.Windows.Forms.GroupBox();
            this.dataGridArticleInfo = new System.Windows.Forms.DataGridView();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.groupComponents = new System.Windows.Forms.GroupBox();
            this.dataGridComponents = new System.Windows.Forms.DataGridView();
            this.btnReloadComponents = new System.Windows.Forms.Button();
            this.tabLocations = new System.Windows.Forms.TabPage();
            this.groupStockLocations = new System.Windows.Forms.GroupBox();
            this.dataGridStockLocations = new System.Windows.Forms.DataGridView();
            this.btnReloadStockLocations = new System.Windows.Forms.Button();
            this.tabRawXml = new System.Windows.Forms.TabPage();
            this.groupRawXml = new System.Windows.Forms.GroupBox();
            this.txtRawXml = new System.Windows.Forms.RichTextBox();
            this.btnClearRawXml = new System.Windows.Forms.Button();
            this.btnSendRawXml = new System.Windows.Forms.Button();
            this.openArticleFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgInitInput = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDigitalShelf = new System.Windows.Forms.GroupBox();
            this.buttonDigitalShelfDisconnect = new System.Windows.Forms.Button();
            this.buttonDigitalShelfConnect = new System.Windows.Forms.Button();
            this.numericUpDownDigitalShelfPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxDigitalShelfAddress = new System.Windows.Forms.TextBox();
            this.backgroundWorkerConnectDigitalShelf = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStorageSystem = new System.Windows.Forms.TabPage();
            this.tabPageDigitalShelf = new System.Windows.Forms.TabPage();
            this.tabControlDigitalShelf = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonClearDigitalShelfLog = new System.Windows.Forms.Button();
            this.listBoxDigitalShelfLog = new System.Windows.Forms.ListBox();
            this.tabPageArticleInfo = new System.Windows.Forms.TabPage();
            this.groupBoxArticleInformation = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxSubItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSubItemQuantity = new System.Windows.Forms.Label();
            this.textBoxPackagingUnit = new System.Windows.Forms.TextBox();
            this.labelPackagingUnit = new System.Windows.Forms.Label();
            this.textBoxDosageForm = new System.Windows.Forms.TextBox();
            this.labelDosageForm = new System.Windows.Forms.Label();
            this.labelArticleName = new System.Windows.Forms.Label();
            this.textBoxArticleName = new System.Windows.Forms.TextBox();
            this.checkBoxArticleInformationAutoGenerate = new System.Windows.Forms.CheckBox();
            this.groupBoxTag = new System.Windows.Forms.GroupBox();
            this.checkBoxTagAutoGenerate = new System.Windows.Forms.CheckBox();
            this.buttonRemoveTag = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.listBoxTag = new System.Windows.Forms.ListBox();
            this.groupBoxAlternativePackSizeArticle = new System.Windows.Forms.GroupBox();
            this.checkBoxAlternativePackSizeAutoGenerated = new System.Windows.Forms.CheckBox();
            this.buttonRemoveAlternativePackSizeArticle = new System.Windows.Forms.Button();
            this.buttonAddAlternativePackSizeArticle = new System.Windows.Forms.Button();
            this.listBoxAlternativePackSizeArticle = new System.Windows.Forms.ListBox();
            this.groupBoxAlternativeArticle = new System.Windows.Forms.GroupBox();
            this.checkBoxAlternativeArticlesAutoGenerate = new System.Windows.Forms.CheckBox();
            this.buttonRemoveAlternativeArticle = new System.Windows.Forms.Button();
            this.buttonAddAlternativeArticle = new System.Windows.Forms.Button();
            this.listBoxAlternativeArticle = new System.Windows.Forms.ListBox();
            this.groupBoxCrossSellingArticle = new System.Windows.Forms.GroupBox();
            this.checkBoxCrossSellingArticleAutoGenerate = new System.Windows.Forms.CheckBox();
            this.buttonRemoveCrossSellingArticle = new System.Windows.Forms.Button();
            this.buttonAddCrossSellingArticle = new System.Windows.Forms.Button();
            this.listBoxCrossSellingArticle = new System.Windows.Forms.ListBox();
            this.tabPagePriceInformation = new System.Windows.Forms.TabPage();
            this.groupBoxPriceInformation = new System.Windows.Forms.GroupBox();
            this.checkBoxPriceInformationAutoGenerate = new System.Windows.Forms.CheckBox();
            this.buttonRemovePriceInformation = new System.Windows.Forms.Button();
            this.buttonAddPriceInformation = new System.Windows.Forms.Button();
            this.listBoxPriceInformation = new System.Windows.Forms.ListBox();
            this.tabPageShoppingCartRequested = new System.Windows.Forms.TabPage();
            this.tabControlShoppingCart = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.groupBoxShoppingCartItemsForRequest = new System.Windows.Forms.GroupBox();
            this.buttonRemoveShoppingCartItem = new System.Windows.Forms.Button();
            this.buttonAddShoppingCartItem = new System.Windows.Forms.Button();
            this.listViewShoppingCartItemsForRequest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxShoppingCartRequest = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShoppingCartCustomerID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxShoppingCartSalesPersonId = new System.Windows.Forms.TextBox();
            this.radioButtonShoppingCartReject = new System.Windows.Forms.RadioButton();
            this.textBoxShoppingCartSalesPointID = new System.Windows.Forms.TextBox();
            this.radioButtonShoppingCartAccept = new System.Windows.Forms.RadioButton();
            this.textBoxShoppingCartViewPointID = new System.Windows.Forms.TextBox();
            this.labelViewPointId = new System.Windows.Forms.Label();
            this.comboBoxShoppingCartStatus = new System.Windows.Forms.ComboBox();
            this.labelSalesPointId = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelSalesPersonId = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.groupBoxShoppingCartItemsForUpdate = new System.Windows.Forms.GroupBox();
            this.listViewShoppingCartItemsForUpdate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxShoppingCartUpdateHandling = new System.Windows.Forms.GroupBox();
            this.radioButtonShoppingCartUpdateAutoManual = new System.Windows.Forms.RadioButton();
            this.radioButtonShoppingCartUpdateAutoReject = new System.Windows.Forms.RadioButton();
            this.radioButtonShoppingCartUpdateAutoAccept = new System.Windows.Forms.RadioButton();
            this.labelShoppingCartUpdateHandlingDescription = new System.Windows.Forms.Label();
            this.textBoxShoppingCartUpdateHandlingDescription = new System.Windows.Forms.TextBox();
            this.buttonShoppingCartUpdateAutoReject = new System.Windows.Forms.Button();
            this.buttonShoppingCartUpdateAutoAccept = new System.Windows.Forms.Button();
            this.labelShoppingCartUpdateHandlingAuto = new System.Windows.Forms.Label();
            this.labelShoppingCartUpdateHandlingManuel = new System.Windows.Forms.Label();
            this.groupBoxShoppingCartInfo = new System.Windows.Forms.GroupBox();
            this.textBoxShoppingCartInfoID = new System.Windows.Forms.TextBox();
            this.textBoxShoppingCartInfoCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxShoppingCartInfoSalesPersonID = new System.Windows.Forms.TextBox();
            this.textBoxShoppingCartInfoSalesPointID = new System.Windows.Forms.TextBox();
            this.textBoxShoppingCartInfoViewPointID = new System.Windows.Forms.TextBox();
            this.comboBoxShoppingCartInfoStatus = new System.Windows.Forms.ComboBox();
            this.labelShoppingCartInfoID = new System.Windows.Forms.Label();
            this.labelShoppingCartInfoViewPointID = new System.Windows.Forms.Label();
            this.labelShoppingCartInfoSalesPointID = new System.Windows.Forms.Label();
            this.labelShoppingCartInfoCustomerID = new System.Windows.Forms.Label();
            this.labelShoppingCartInfoSalesPersonID = new System.Windows.Forms.Label();
            this.labelShoppingCartInfoStatus = new System.Windows.Forms.Label();
            this.tabRawXmlDigitalShelf = new System.Windows.Forms.TabPage();
            this.groupRawXmlDigitalShelf = new System.Windows.Forms.GroupBox();
            this.btnClearRawXmlDigitalShelf = new System.Windows.Forms.Button();
            this.btnSendRawXmlDigitalShelf = new System.Windows.Forms.Button();
            this.txtRawXmlDigitalShelf = new System.Windows.Forms.RichTextBox();
            this.bgConnect = new System.ComponentModel.BackgroundWorker();
            this.bgStock = new System.ComponentModel.BackgroundWorker();
            this.btnImportFromSelect = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupConnection.SuspendLayout();
            this.tabControlStorageSystem.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitArticles)).BeginInit();
            this.splitArticles.Panel1.SuspendLayout();
            this.splitArticles.Panel2.SuspendLayout();
            this.splitArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacks)).BeginInit();
            this.tabInput.SuspendLayout();
            this.groupInputLog.SuspendLayout();
            this.groupInputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiryDateMonth)).BeginInit();
            this.tabInitiateInput.SuspendLayout();
            this.groupInitInputActivities.SuspendLayout();
            this.groupInitiatedInputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackSubItemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitInputID)).BeginInit();
            this.tabOutput.SuspendLayout();
            this.groupOrderBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderBoxes)).BeginInit();
            this.groupOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.groupDispensedPacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDispensedPacks)).BeginInit();
            this.groupOrderLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemLabels)).BeginInit();
            this.groupOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItems)).BeginInit();
            this.tabMasterArticles.SuspendLayout();
            this.groupBoxMasterArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasterArticles)).BeginInit();
            this.tabStockDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeliveryItems)).BeginInit();
            this.tabTaskInfo.SuspendLayout();
            this.groupTask.SuspendLayout();
            this.groupPacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPackInfo)).BeginInit();
            this.groupArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticleInfo)).BeginInit();
            this.tabStatus.SuspendLayout();
            this.groupComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComponents)).BeginInit();
            this.tabLocations.SuspendLayout();
            this.groupStockLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockLocations)).BeginInit();
            this.tabRawXml.SuspendLayout();
            this.groupRawXml.SuspendLayout();
            this.groupBoxDigitalShelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigitalShelfPort)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageStorageSystem.SuspendLayout();
            this.tabPageDigitalShelf.SuspendLayout();
            this.tabControlDigitalShelf.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPageArticleInfo.SuspendLayout();
            this.groupBoxArticleInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSubItemQuantity)).BeginInit();
            this.groupBoxTag.SuspendLayout();
            this.groupBoxAlternativePackSizeArticle.SuspendLayout();
            this.groupBoxAlternativeArticle.SuspendLayout();
            this.groupBoxCrossSellingArticle.SuspendLayout();
            this.tabPagePriceInformation.SuspendLayout();
            this.groupBoxPriceInformation.SuspendLayout();
            this.tabPageShoppingCartRequested.SuspendLayout();
            this.tabControlShoppingCart.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.groupBoxShoppingCartItemsForRequest.SuspendLayout();
            this.groupBoxShoppingCartRequest.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.groupBoxShoppingCartItemsForUpdate.SuspendLayout();
            this.groupBoxShoppingCartUpdateHandling.SuspendLayout();
            this.groupBoxShoppingCartInfo.SuspendLayout();
            this.tabRawXmlDigitalShelf.SuspendLayout();
            this.groupRawXmlDigitalShelf.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStorageSystemStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(996, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStorageSystemStatus
            // 
            this.lblStorageSystemStatus.Name = "lblStorageSystemStatus";
            this.lblStorageSystemStatus.Size = new System.Drawing.Size(131, 17);
            this.lblStorageSystemStatus.Text = "Robot Status: Unknown";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(13, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "localhost";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(120, 20);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(72, 20);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            6050,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(810, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupConnection
            // 
            this.groupConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConnection.Controls.Add(this.checkAutoConnect);
            this.groupConnection.Controls.Add(this.btnDisconnect);
            this.groupConnection.Controls.Add(this.lblTenantId);
            this.groupConnection.Controls.Add(this.txtTenantId);
            this.groupConnection.Controls.Add(this.checkAutomaticStateObservation);
            this.groupConnection.Controls.Add(this.btnConnect);
            this.groupConnection.Controls.Add(this.numPort);
            this.groupConnection.Controls.Add(this.txtAddress);
            this.groupConnection.Location = new System.Drawing.Point(6, 6);
            this.groupConnection.Name = "groupConnection";
            this.groupConnection.Size = new System.Drawing.Size(976, 54);
            this.groupConnection.TabIndex = 0;
            this.groupConnection.TabStop = false;
            this.groupConnection.Text = "Storage System";
            // 
            // checkAutoConnect
            // 
            this.checkAutoConnect.AutoSize = true;
            this.checkAutoConnect.Location = new System.Drawing.Point(343, 24);
            this.checkAutoConnect.Name = "checkAutoConnect";
            this.checkAutoConnect.Size = new System.Drawing.Size(91, 17);
            this.checkAutoConnect.TabIndex = 8;
            this.checkAutoConnect.Text = "Auto Connect";
            this.checkAutoConnect.UseVisualStyleBackColor = true;
            this.checkAutoConnect.CheckedChanged += new System.EventHandler(this.checkAutoConnect_CheckedChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(891, 17);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "&Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.Location = new System.Drawing.Point(197, 23);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(56, 13);
            this.lblTenantId.TabIndex = 3;
            this.lblTenantId.Text = "Tenant Id:";
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(259, 19);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(66, 20);
            this.txtTenantId.TabIndex = 4;
            // 
            // checkAutomaticStateObservation
            // 
            this.checkAutomaticStateObservation.AutoSize = true;
            this.checkAutomaticStateObservation.Checked = true;
            this.checkAutomaticStateObservation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutomaticStateObservation.Location = new System.Drawing.Point(472, 24);
            this.checkAutomaticStateObservation.Name = "checkAutomaticStateObservation";
            this.checkAutomaticStateObservation.Size = new System.Drawing.Size(161, 17);
            this.checkAutomaticStateObservation.TabIndex = 5;
            this.checkAutomaticStateObservation.Text = "Automatic State Observation";
            this.checkAutomaticStateObservation.UseVisualStyleBackColor = true;
            this.checkAutomaticStateObservation.CheckedChanged += new System.EventHandler(this.checkAutomaticStateObservation_CheckedChanged);
            // 
            // tabControlStorageSystem
            // 
            this.tabControlStorageSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlStorageSystem.Controls.Add(this.tabStock);
            this.tabControlStorageSystem.Controls.Add(this.tabInput);
            this.tabControlStorageSystem.Controls.Add(this.tabInitiateInput);
            this.tabControlStorageSystem.Controls.Add(this.tabOutput);
            this.tabControlStorageSystem.Controls.Add(this.tabMasterArticles);
            this.tabControlStorageSystem.Controls.Add(this.tabStockDeliveries);
            this.tabControlStorageSystem.Controls.Add(this.tabTaskInfo);
            this.tabControlStorageSystem.Controls.Add(this.tabStatus);
            this.tabControlStorageSystem.Controls.Add(this.tabLocations);
            this.tabControlStorageSystem.Controls.Add(this.tabRawXml);
            this.tabControlStorageSystem.Location = new System.Drawing.Point(0, 66);
            this.tabControlStorageSystem.Name = "tabControlStorageSystem";
            this.tabControlStorageSystem.SelectedIndex = 0;
            this.tabControlStorageSystem.Size = new System.Drawing.Size(990, 547);
            this.tabControlStorageSystem.TabIndex = 8;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.btnReloadStock);
            this.tabStock.Controls.Add(this.splitArticles);
            this.tabStock.Controls.Add(this.txtArticleFilter);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(982, 521);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // btnReloadStock
            // 
            this.btnReloadStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadStock.Enabled = false;
            this.btnReloadStock.Location = new System.Drawing.Point(901, 4);
            this.btnReloadStock.Name = "btnReloadStock";
            this.btnReloadStock.Size = new System.Drawing.Size(75, 23);
            this.btnReloadStock.TabIndex = 6;
            this.btnReloadStock.Text = "&Reload";
            this.btnReloadStock.UseVisualStyleBackColor = true;
            this.btnReloadStock.Click += new System.EventHandler(this.btnReloadStock_Click);
            // 
            // splitArticles
            // 
            this.splitArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitArticles.Location = new System.Drawing.Point(3, 33);
            this.splitArticles.Name = "splitArticles";
            this.splitArticles.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitArticles.Panel1
            // 
            this.splitArticles.Panel1.Controls.Add(this.dataGridArticles);
            // 
            // splitArticles.Panel2
            // 
            this.splitArticles.Panel2.Controls.Add(this.dataGridPacks);
            this.splitArticles.Size = new System.Drawing.Size(976, 482);
            this.splitArticles.SplitterDistance = 221;
            this.splitArticles.TabIndex = 9;
            // 
            // dataGridArticles
            // 
            this.dataGridArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArticles.Location = new System.Drawing.Point(0, 0);
            this.dataGridArticles.Name = "dataGridArticles";
            this.dataGridArticles.Size = new System.Drawing.Size(976, 221);
            this.dataGridArticles.TabIndex = 10;
            this.dataGridArticles.SelectionChanged += new System.EventHandler(this.dataGridArticles_SelectionChanged);
            this.dataGridArticles.SizeChanged += new System.EventHandler(this.dataGridArticles_SizeChanged);
            // 
            // dataGridPacks
            // 
            this.dataGridPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPacks.Location = new System.Drawing.Point(0, 0);
            this.dataGridPacks.Name = "dataGridPacks";
            this.dataGridPacks.Size = new System.Drawing.Size(976, 257);
            this.dataGridPacks.TabIndex = 11;
            this.dataGridPacks.SizeChanged += new System.EventHandler(this.dataGridPacks_SizeChanged);
            // 
            // txtArticleFilter
            // 
            this.txtArticleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticleFilter.Location = new System.Drawing.Point(6, 6);
            this.txtArticleFilter.Name = "txtArticleFilter";
            this.txtArticleFilter.Size = new System.Drawing.Size(882, 20);
            this.txtArticleFilter.TabIndex = 9;
            this.txtArticleFilter.TextChanged += new System.EventHandler(this.txtArticleFilter_TextChanged);
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.groupInputLog);
            this.tabInput.Controls.Add(this.groupInputOptions);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(982, 521);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // groupInputLog
            // 
            this.groupInputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInputLog.Controls.Add(this.btnClearInputLog);
            this.groupInputLog.Controls.Add(this.listInputLog);
            this.groupInputLog.Location = new System.Drawing.Point(268, 4);
            this.groupInputLog.Name = "groupInputLog";
            this.groupInputLog.Size = new System.Drawing.Size(710, 510);
            this.groupInputLog.TabIndex = 26;
            this.groupInputLog.TabStop = false;
            this.groupInputLog.Text = "Input Activities";
            // 
            // btnClearInputLog
            // 
            this.btnClearInputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInputLog.Location = new System.Drawing.Point(629, 482);
            this.btnClearInputLog.Name = "btnClearInputLog";
            this.btnClearInputLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearInputLog.TabIndex = 28;
            this.btnClearInputLog.Text = "Clear";
            this.btnClearInputLog.UseVisualStyleBackColor = true;
            this.btnClearInputLog.Click += new System.EventHandler(this.btnClearInputLog_Click);
            // 
            // listInputLog
            // 
            this.listInputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInputLog.FormattingEnabled = true;
            this.listInputLog.Location = new System.Drawing.Point(7, 20);
            this.listInputLog.Name = "listInputLog";
            this.listInputLog.Size = new System.Drawing.Size(697, 420);
            this.listInputLog.TabIndex = 27;
            // 
            // groupInputOptions
            // 
            this.groupInputOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInputOptions.Controls.Add(this.checkEnforceSerialNumberNewDelivery);
            this.groupInputOptions.Controls.Add(this.checkEnforceSerialNumberStockReturn);
            this.groupInputOptions.Controls.Add(this.checkBoxSetVirtualArticle);
            this.groupInputOptions.Controls.Add(this.checkOnlyArticlesFromList);
            this.groupInputOptions.Controls.Add(this.txtOverwriteStockLocation);
            this.groupInputOptions.Controls.Add(this.checkOverwriteStockLocation);
            this.groupInputOptions.Controls.Add(this.lblDefExpiryDate);
            this.groupInputOptions.Controls.Add(this.numExpiryDateMonth);
            this.groupInputOptions.Controls.Add(this.checkEnforceLocationNewDelivery);
            this.groupInputOptions.Controls.Add(this.checkEnforceLocationStockReturn);
            this.groupInputOptions.Controls.Add(this.checkSetSubItemQuantity);
            this.groupInputOptions.Controls.Add(this.checkEnforcePickingIndicator);
            this.groupInputOptions.Controls.Add(this.checkOnlyFridgeInput);
            this.groupInputOptions.Controls.Add(this.checkAllowStockReturnInput);
            this.groupInputOptions.Controls.Add(this.checkEnforceExpiryDateDelivery);
            this.groupInputOptions.Controls.Add(this.checkEnforceExpiryDateStockReturn);
            this.groupInputOptions.Controls.Add(this.checkEnforceBatchDelivery);
            this.groupInputOptions.Controls.Add(this.checkEnforceBatchStockReturn);
            this.groupInputOptions.Controls.Add(this.checkAllowDeliveryInput);
            this.groupInputOptions.Location = new System.Drawing.Point(4, 4);
            this.groupInputOptions.Name = "groupInputOptions";
            this.groupInputOptions.Size = new System.Drawing.Size(258, 510);
            this.groupInputOptions.TabIndex = 9;
            this.groupInputOptions.TabStop = false;
            this.groupInputOptions.Text = "Input Options";
            // 
            // checkEnforceSerialNumberNewDelivery
            // 
            this.checkEnforceSerialNumberNewDelivery.AutoSize = true;
            this.checkEnforceSerialNumberNewDelivery.Location = new System.Drawing.Point(17, 304);
            this.checkEnforceSerialNumberNewDelivery.Name = "checkEnforceSerialNumberNewDelivery";
            this.checkEnforceSerialNumberNewDelivery.Size = new System.Drawing.Size(210, 17);
            this.checkEnforceSerialNumberNewDelivery.TabIndex = 28;
            this.checkEnforceSerialNumberNewDelivery.Text = "Enforce SerialNumber for New Delivery";
            this.checkEnforceSerialNumberNewDelivery.UseVisualStyleBackColor = true;
            // 
            // checkEnforceSerialNumberStockReturn
            // 
            this.checkEnforceSerialNumberStockReturn.AutoSize = true;
            this.checkEnforceSerialNumberStockReturn.Location = new System.Drawing.Point(17, 281);
            this.checkEnforceSerialNumberStockReturn.Name = "checkEnforceSerialNumberStockReturn";
            this.checkEnforceSerialNumberStockReturn.Size = new System.Drawing.Size(210, 17);
            this.checkEnforceSerialNumberStockReturn.TabIndex = 27;
            this.checkEnforceSerialNumberStockReturn.Text = "Enforce SerialNumber for Stock Return";
            this.checkEnforceSerialNumberStockReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetVirtualArticle
            // 
            this.checkBoxSetVirtualArticle.AutoSize = true;
            this.checkBoxSetVirtualArticle.Location = new System.Drawing.Point(17, 349);
            this.checkBoxSetVirtualArticle.Name = "checkBoxSetVirtualArticle";
            this.checkBoxSetVirtualArticle.Size = new System.Drawing.Size(106, 17);
            this.checkBoxSetVirtualArticle.TabIndex = 26;
            this.checkBoxSetVirtualArticle.Text = "Set Virtual Article";
            this.checkBoxSetVirtualArticle.UseVisualStyleBackColor = true;
            // 
            // checkOnlyArticlesFromList
            // 
            this.checkOnlyArticlesFromList.AutoSize = true;
            this.checkOnlyArticlesFromList.Location = new System.Drawing.Point(17, 98);
            this.checkOnlyArticlesFromList.Name = "checkOnlyArticlesFromList";
            this.checkOnlyArticlesFromList.Size = new System.Drawing.Size(195, 17);
            this.checkOnlyArticlesFromList.TabIndex = 13;
            this.checkOnlyArticlesFromList.Text = "Allow Only Articles From Articles.csv";
            this.checkOnlyArticlesFromList.UseVisualStyleBackColor = true;
            // 
            // txtOverwriteStockLocation
            // 
            this.txtOverwriteStockLocation.Enabled = false;
            this.txtOverwriteStockLocation.Location = new System.Drawing.Point(35, 396);
            this.txtOverwriteStockLocation.Name = "txtOverwriteStockLocation";
            this.txtOverwriteStockLocation.Size = new System.Drawing.Size(194, 20);
            this.txtOverwriteStockLocation.TabIndex = 23;
            // 
            // checkOverwriteStockLocation
            // 
            this.checkOverwriteStockLocation.AutoSize = true;
            this.checkOverwriteStockLocation.Location = new System.Drawing.Point(17, 372);
            this.checkOverwriteStockLocation.Name = "checkOverwriteStockLocation";
            this.checkOverwriteStockLocation.Size = new System.Drawing.Size(146, 17);
            this.checkOverwriteStockLocation.TabIndex = 22;
            this.checkOverwriteStockLocation.Text = "Overwrite Stock Location";
            this.checkOverwriteStockLocation.UseVisualStyleBackColor = true;
            this.checkOverwriteStockLocation.CheckedChanged += new System.EventHandler(this.checkOverwriteStockLocation_CheckedChanged);
            // 
            // lblDefExpiryDate
            // 
            this.lblDefExpiryDate.AutoSize = true;
            this.lblDefExpiryDate.Location = new System.Drawing.Point(14, 445);
            this.lblDefExpiryDate.Name = "lblDefExpiryDate";
            this.lblDefExpiryDate.Size = new System.Drawing.Size(142, 13);
            this.lblDefExpiryDate.TabIndex = 24;
            this.lblDefExpiryDate.Text = "Expiry Date month from now:";
            // 
            // numExpiryDateMonth
            // 
            this.numExpiryDateMonth.Location = new System.Drawing.Point(165, 443);
            this.numExpiryDateMonth.Name = "numExpiryDateMonth";
            this.numExpiryDateMonth.Size = new System.Drawing.Size(66, 20);
            this.numExpiryDateMonth.TabIndex = 25;
            this.numExpiryDateMonth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // checkEnforceLocationNewDelivery
            // 
            this.checkEnforceLocationNewDelivery.AutoSize = true;
            this.checkEnforceLocationNewDelivery.Location = new System.Drawing.Point(17, 259);
            this.checkEnforceLocationNewDelivery.Name = "checkEnforceLocationNewDelivery";
            this.checkEnforceLocationNewDelivery.Size = new System.Drawing.Size(216, 17);
            this.checkEnforceLocationNewDelivery.TabIndex = 20;
            this.checkEnforceLocationNewDelivery.Text = "Enforce StockLocation for New Delivery";
            this.checkEnforceLocationNewDelivery.UseVisualStyleBackColor = true;
            // 
            // checkEnforceLocationStockReturn
            // 
            this.checkEnforceLocationStockReturn.AutoSize = true;
            this.checkEnforceLocationStockReturn.Location = new System.Drawing.Point(17, 236);
            this.checkEnforceLocationStockReturn.Name = "checkEnforceLocationStockReturn";
            this.checkEnforceLocationStockReturn.Size = new System.Drawing.Size(216, 17);
            this.checkEnforceLocationStockReturn.TabIndex = 19;
            this.checkEnforceLocationStockReturn.Text = "Enforce StockLocation for Stock Return";
            this.checkEnforceLocationStockReturn.UseVisualStyleBackColor = true;
            // 
            // checkSetSubItemQuantity
            // 
            this.checkSetSubItemQuantity.AutoSize = true;
            this.checkSetSubItemQuantity.Location = new System.Drawing.Point(17, 326);
            this.checkSetSubItemQuantity.Name = "checkSetSubItemQuantity";
            this.checkSetSubItemQuantity.Size = new System.Drawing.Size(143, 17);
            this.checkSetSubItemQuantity.TabIndex = 21;
            this.checkSetSubItemQuantity.Text = "Set MaxSubItemQuantity";
            this.checkSetSubItemQuantity.UseVisualStyleBackColor = true;
            // 
            // checkEnforcePickingIndicator
            // 
            this.checkEnforcePickingIndicator.AutoSize = true;
            this.checkEnforcePickingIndicator.Location = new System.Drawing.Point(17, 121);
            this.checkEnforcePickingIndicator.Name = "checkEnforcePickingIndicator";
            this.checkEnforcePickingIndicator.Size = new System.Drawing.Size(145, 17);
            this.checkEnforcePickingIndicator.TabIndex = 14;
            this.checkEnforcePickingIndicator.Text = "Enforce Picking Indicator";
            this.checkEnforcePickingIndicator.UseVisualStyleBackColor = true;
            // 
            // checkOnlyFridgeInput
            // 
            this.checkOnlyFridgeInput.AutoSize = true;
            this.checkOnlyFridgeInput.Location = new System.Drawing.Point(17, 75);
            this.checkOnlyFridgeInput.Name = "checkOnlyFridgeInput";
            this.checkOnlyFridgeInput.Size = new System.Drawing.Size(149, 17);
            this.checkOnlyFridgeInput.TabIndex = 12;
            this.checkOnlyFridgeInput.Text = "Allow Input Only for Fridge";
            this.checkOnlyFridgeInput.UseVisualStyleBackColor = true;
            // 
            // checkAllowStockReturnInput
            // 
            this.checkAllowStockReturnInput.AutoSize = true;
            this.checkAllowStockReturnInput.Checked = true;
            this.checkAllowStockReturnInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllowStockReturnInput.Location = new System.Drawing.Point(17, 52);
            this.checkAllowStockReturnInput.Name = "checkAllowStockReturnInput";
            this.checkAllowStockReturnInput.Size = new System.Drawing.Size(144, 17);
            this.checkAllowStockReturnInput.TabIndex = 11;
            this.checkAllowStockReturnInput.Text = "Allow Stock Return Input";
            this.checkAllowStockReturnInput.UseVisualStyleBackColor = true;
            // 
            // checkEnforceExpiryDateDelivery
            // 
            this.checkEnforceExpiryDateDelivery.AutoSize = true;
            this.checkEnforceExpiryDateDelivery.Location = new System.Drawing.Point(17, 167);
            this.checkEnforceExpiryDateDelivery.Name = "checkEnforceExpiryDateDelivery";
            this.checkEnforceExpiryDateDelivery.Size = new System.Drawing.Size(201, 17);
            this.checkEnforceExpiryDateDelivery.TabIndex = 16;
            this.checkEnforceExpiryDateDelivery.Text = "Enforce Expiry Date for New Delivery";
            this.checkEnforceExpiryDateDelivery.UseVisualStyleBackColor = true;
            // 
            // checkEnforceExpiryDateStockReturn
            // 
            this.checkEnforceExpiryDateStockReturn.AutoSize = true;
            this.checkEnforceExpiryDateStockReturn.Location = new System.Drawing.Point(17, 144);
            this.checkEnforceExpiryDateStockReturn.Name = "checkEnforceExpiryDateStockReturn";
            this.checkEnforceExpiryDateStockReturn.Size = new System.Drawing.Size(201, 17);
            this.checkEnforceExpiryDateStockReturn.TabIndex = 15;
            this.checkEnforceExpiryDateStockReturn.Text = "Enforce Expiry Date for Stock Return";
            this.checkEnforceExpiryDateStockReturn.UseVisualStyleBackColor = true;
            // 
            // checkEnforceBatchDelivery
            // 
            this.checkEnforceBatchDelivery.AutoSize = true;
            this.checkEnforceBatchDelivery.Location = new System.Drawing.Point(17, 213);
            this.checkEnforceBatchDelivery.Name = "checkEnforceBatchDelivery";
            this.checkEnforceBatchDelivery.Size = new System.Drawing.Size(212, 17);
            this.checkEnforceBatchDelivery.TabIndex = 18;
            this.checkEnforceBatchDelivery.Text = "Enforce BatchNumber for New Delivery";
            this.checkEnforceBatchDelivery.UseVisualStyleBackColor = true;
            // 
            // checkEnforceBatchStockReturn
            // 
            this.checkEnforceBatchStockReturn.AutoSize = true;
            this.checkEnforceBatchStockReturn.Location = new System.Drawing.Point(17, 190);
            this.checkEnforceBatchStockReturn.Name = "checkEnforceBatchStockReturn";
            this.checkEnforceBatchStockReturn.Size = new System.Drawing.Size(212, 17);
            this.checkEnforceBatchStockReturn.TabIndex = 17;
            this.checkEnforceBatchStockReturn.Text = "Enforce BatchNumber for Stock Return";
            this.checkEnforceBatchStockReturn.UseVisualStyleBackColor = true;
            // 
            // checkAllowDeliveryInput
            // 
            this.checkAllowDeliveryInput.AutoSize = true;
            this.checkAllowDeliveryInput.Checked = true;
            this.checkAllowDeliveryInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllowDeliveryInput.Location = new System.Drawing.Point(17, 29);
            this.checkAllowDeliveryInput.Name = "checkAllowDeliveryInput";
            this.checkAllowDeliveryInput.Size = new System.Drawing.Size(141, 17);
            this.checkAllowDeliveryInput.TabIndex = 10;
            this.checkAllowDeliveryInput.Text = "Allow NewDelivery Input";
            this.checkAllowDeliveryInput.UseVisualStyleBackColor = true;
            // 
            // tabInitiateInput
            // 
            this.tabInitiateInput.Controls.Add(this.groupInitInputActivities);
            this.tabInitiateInput.Controls.Add(this.groupInitiatedInputOptions);
            this.tabInitiateInput.Location = new System.Drawing.Point(4, 22);
            this.tabInitiateInput.Name = "tabInitiateInput";
            this.tabInitiateInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInitiateInput.Size = new System.Drawing.Size(982, 521);
            this.tabInitiateInput.TabIndex = 5;
            this.tabInitiateInput.Text = "Initiate Input";
            this.tabInitiateInput.UseVisualStyleBackColor = true;
            // 
            // groupInitInputActivities
            // 
            this.groupInitInputActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInitInputActivities.Controls.Add(this.btnGetConfig);
            this.groupInitInputActivities.Controls.Add(this.lblConfiguration);
            this.groupInitInputActivities.Controls.Add(this.txtConfiguration);
            this.groupInitInputActivities.Controls.Add(this.btnClearInitInputLog);
            this.groupInitInputActivities.Controls.Add(this.listInitInputLog);
            this.groupInitInputActivities.Location = new System.Drawing.Point(418, 4);
            this.groupInitInputActivities.Name = "groupInitInputActivities";
            this.groupInitInputActivities.Size = new System.Drawing.Size(560, 510);
            this.groupInitInputActivities.TabIndex = 40;
            this.groupInitInputActivities.TabStop = false;
            this.groupInitInputActivities.Text = "Initiated Input Activities";
            // 
            // btnGetConfig
            // 
            this.btnGetConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetConfig.Location = new System.Drawing.Point(479, 210);
            this.btnGetConfig.Name = "btnGetConfig";
            this.btnGetConfig.Size = new System.Drawing.Size(75, 23);
            this.btnGetConfig.TabIndex = 43;
            this.btnGetConfig.Text = "Get";
            this.btnGetConfig.UseVisualStyleBackColor = true;
            this.btnGetConfig.Click += new System.EventHandler(this.btnGetConfig_Click);
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Location = new System.Drawing.Point(3, 27);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(149, 13);
            this.lblConfiguration.TabIndex = 41;
            this.lblConfiguration.Text = "Storage System Configuration:";
            // 
            // txtConfiguration
            // 
            this.txtConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfiguration.Location = new System.Drawing.Point(6, 47);
            this.txtConfiguration.Multiline = true;
            this.txtConfiguration.Name = "txtConfiguration";
            this.txtConfiguration.ReadOnly = true;
            this.txtConfiguration.Size = new System.Drawing.Size(547, 158);
            this.txtConfiguration.TabIndex = 42;
            // 
            // btnClearInitInputLog
            // 
            this.btnClearInitInputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInitInputLog.Location = new System.Drawing.Point(479, 482);
            this.btnClearInitInputLog.Name = "btnClearInitInputLog";
            this.btnClearInitInputLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearInitInputLog.TabIndex = 45;
            this.btnClearInitInputLog.Text = "Clear";
            this.btnClearInitInputLog.UseVisualStyleBackColor = true;
            this.btnClearInitInputLog.Click += new System.EventHandler(this.btnClearInitInputLog_Click);
            // 
            // listInitInputLog
            // 
            this.listInitInputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInitInputLog.FormattingEnabled = true;
            this.listInitInputLog.Location = new System.Drawing.Point(7, 234);
            this.listInitInputLog.Name = "listInitInputLog";
            this.listInitInputLog.Size = new System.Drawing.Size(547, 212);
            this.listInitInputLog.TabIndex = 44;
            // 
            // groupInitiatedInputOptions
            // 
            this.groupInitiatedInputOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInitiatedInputOptions.Controls.Add(this.lblStockLocation);
            this.groupInitiatedInputOptions.Controls.Add(this.txtPackStockLocation);
            this.groupInitiatedInputOptions.Controls.Add(this.numDestination);
            this.groupInitiatedInputOptions.Controls.Add(this.lblDestination);
            this.groupInitiatedInputOptions.Controls.Add(this.numInputPoint);
            this.groupInitiatedInputOptions.Controls.Add(this.lblInputPoint);
            this.groupInitiatedInputOptions.Controls.Add(this.btnSendInitInputRequest);
            this.groupInitiatedInputOptions.Controls.Add(this.cmbPackShape);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackShape);
            this.groupInitiatedInputOptions.Controls.Add(this.numPackHeight);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackHeight);
            this.groupInitiatedInputOptions.Controls.Add(this.numPackWidth);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackWidth);
            this.groupInitiatedInputOptions.Controls.Add(this.numPackDepth);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackDepth);
            this.groupInitiatedInputOptions.Controls.Add(this.numPackSubItemQuantity);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackSubItemQuantity);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackExpiryDate);
            this.groupInitiatedInputOptions.Controls.Add(this.txtPackExpiryDate);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackBatchNumber);
            this.groupInitiatedInputOptions.Controls.Add(this.txtPackBatchNumber);
            this.groupInitiatedInputOptions.Controls.Add(this.lblPackScanCode);
            this.groupInitiatedInputOptions.Controls.Add(this.txtPackScanCode);
            this.groupInitiatedInputOptions.Controls.Add(this.numInputSource);
            this.groupInitiatedInputOptions.Controls.Add(this.lblInputSource);
            this.groupInitiatedInputOptions.Controls.Add(this.lblDeliveryNumber);
            this.groupInitiatedInputOptions.Controls.Add(this.numInitInputID);
            this.groupInitiatedInputOptions.Controls.Add(this.txtDeliveryNumber);
            this.groupInitiatedInputOptions.Controls.Add(this.lblInitInputID);
            this.groupInitiatedInputOptions.Controls.Add(this.chkSetPickingIndicator);
            this.groupInitiatedInputOptions.Location = new System.Drawing.Point(4, 4);
            this.groupInitiatedInputOptions.Name = "groupInitiatedInputOptions";
            this.groupInitiatedInputOptions.Size = new System.Drawing.Size(403, 510);
            this.groupInitiatedInputOptions.TabIndex = 9;
            this.groupInitiatedInputOptions.TabStop = false;
            this.groupInitiatedInputOptions.Text = "Initiated Input Options";
            // 
            // lblStockLocation
            // 
            this.lblStockLocation.AutoSize = true;
            this.lblStockLocation.Location = new System.Drawing.Point(17, 365);
            this.lblStockLocation.Name = "lblStockLocation";
            this.lblStockLocation.Size = new System.Drawing.Size(82, 13);
            this.lblStockLocation.TabIndex = 36;
            this.lblStockLocation.Text = "Stock Location:";
            // 
            // txtPackStockLocation
            // 
            this.txtPackStockLocation.Location = new System.Drawing.Point(160, 362);
            this.txtPackStockLocation.Name = "txtPackStockLocation";
            this.txtPackStockLocation.Size = new System.Drawing.Size(227, 20);
            this.txtPackStockLocation.TabIndex = 37;
            // 
            // numDestination
            // 
            this.numDestination.Location = new System.Drawing.Point(160, 51);
            this.numDestination.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDestination.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDestination.Name = "numDestination";
            this.numDestination.Size = new System.Drawing.Size(228, 20);
            this.numDestination.TabIndex = 13;
            this.numDestination.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(17, 53);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 12;
            this.lblDestination.Text = "Destination:";
            // 
            // numInputPoint
            // 
            this.numInputPoint.Location = new System.Drawing.Point(160, 128);
            this.numInputPoint.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numInputPoint.Name = "numInputPoint";
            this.numInputPoint.Size = new System.Drawing.Size(228, 20);
            this.numInputPoint.TabIndex = 19;
            // 
            // lblInputPoint
            // 
            this.lblInputPoint.AutoSize = true;
            this.lblInputPoint.Location = new System.Drawing.Point(17, 130);
            this.lblInputPoint.Name = "lblInputPoint";
            this.lblInputPoint.Size = new System.Drawing.Size(61, 13);
            this.lblInputPoint.TabIndex = 18;
            this.lblInputPoint.Text = "Input Point:";
            // 
            // btnSendInitInputRequest
            // 
            this.btnSendInitInputRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendInitInputRequest.Enabled = false;
            this.btnSendInitInputRequest.Location = new System.Drawing.Point(312, 482);
            this.btnSendInitInputRequest.Name = "btnSendInitInputRequest";
            this.btnSendInitInputRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSendInitInputRequest.TabIndex = 39;
            this.btnSendInitInputRequest.Text = "Send";
            this.btnSendInitInputRequest.UseVisualStyleBackColor = true;
            this.btnSendInitInputRequest.Click += new System.EventHandler(this.btnSendInitInputRequest_Click);
            // 
            // cmbPackShape
            // 
            this.cmbPackShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackShape.FormattingEnabled = true;
            this.cmbPackShape.Items.AddRange(new object[] {
            "Cuboid",
            "Cylinder"});
            this.cmbPackShape.Location = new System.Drawing.Point(160, 335);
            this.cmbPackShape.Name = "cmbPackShape";
            this.cmbPackShape.Size = new System.Drawing.Size(227, 21);
            this.cmbPackShape.TabIndex = 35;
            // 
            // lblPackShape
            // 
            this.lblPackShape.AutoSize = true;
            this.lblPackShape.Location = new System.Drawing.Point(17, 338);
            this.lblPackShape.Name = "lblPackShape";
            this.lblPackShape.Size = new System.Drawing.Size(69, 13);
            this.lblPackShape.TabIndex = 34;
            this.lblPackShape.Text = "Pack Shape:";
            // 
            // numPackHeight
            // 
            this.numPackHeight.Location = new System.Drawing.Point(160, 310);
            this.numPackHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPackHeight.Name = "numPackHeight";
            this.numPackHeight.Size = new System.Drawing.Size(228, 20);
            this.numPackHeight.TabIndex = 33;
            // 
            // lblPackHeight
            // 
            this.lblPackHeight.AutoSize = true;
            this.lblPackHeight.Location = new System.Drawing.Point(17, 312);
            this.lblPackHeight.Name = "lblPackHeight";
            this.lblPackHeight.Size = new System.Drawing.Size(69, 13);
            this.lblPackHeight.TabIndex = 32;
            this.lblPackHeight.Text = "Pack Height:";
            // 
            // numPackWidth
            // 
            this.numPackWidth.Location = new System.Drawing.Point(160, 284);
            this.numPackWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPackWidth.Name = "numPackWidth";
            this.numPackWidth.Size = new System.Drawing.Size(228, 20);
            this.numPackWidth.TabIndex = 31;
            // 
            // lblPackWidth
            // 
            this.lblPackWidth.AutoSize = true;
            this.lblPackWidth.Location = new System.Drawing.Point(17, 286);
            this.lblPackWidth.Name = "lblPackWidth";
            this.lblPackWidth.Size = new System.Drawing.Size(66, 13);
            this.lblPackWidth.TabIndex = 30;
            this.lblPackWidth.Text = "Pack Width:";
            // 
            // numPackDepth
            // 
            this.numPackDepth.Location = new System.Drawing.Point(160, 258);
            this.numPackDepth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPackDepth.Name = "numPackDepth";
            this.numPackDepth.Size = new System.Drawing.Size(228, 20);
            this.numPackDepth.TabIndex = 29;
            // 
            // lblPackDepth
            // 
            this.lblPackDepth.AutoSize = true;
            this.lblPackDepth.Location = new System.Drawing.Point(17, 260);
            this.lblPackDepth.Name = "lblPackDepth";
            this.lblPackDepth.Size = new System.Drawing.Size(67, 13);
            this.lblPackDepth.TabIndex = 28;
            this.lblPackDepth.Text = "Pack Depth:";
            // 
            // numPackSubItemQuantity
            // 
            this.numPackSubItemQuantity.Location = new System.Drawing.Point(160, 232);
            this.numPackSubItemQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPackSubItemQuantity.Name = "numPackSubItemQuantity";
            this.numPackSubItemQuantity.Size = new System.Drawing.Size(228, 20);
            this.numPackSubItemQuantity.TabIndex = 27;
            // 
            // lblPackSubItemQuantity
            // 
            this.lblPackSubItemQuantity.AutoSize = true;
            this.lblPackSubItemQuantity.Location = new System.Drawing.Point(17, 234);
            this.lblPackSubItemQuantity.Name = "lblPackSubItemQuantity";
            this.lblPackSubItemQuantity.Size = new System.Drawing.Size(116, 13);
            this.lblPackSubItemQuantity.TabIndex = 26;
            this.lblPackSubItemQuantity.Text = "Pack SubItemQuantity:";
            // 
            // lblPackExpiryDate
            // 
            this.lblPackExpiryDate.AutoSize = true;
            this.lblPackExpiryDate.Location = new System.Drawing.Point(17, 209);
            this.lblPackExpiryDate.Name = "lblPackExpiryDate";
            this.lblPackExpiryDate.Size = new System.Drawing.Size(92, 13);
            this.lblPackExpiryDate.TabIndex = 24;
            this.lblPackExpiryDate.Text = "Pack Expiry Date:";
            // 
            // txtPackExpiryDate
            // 
            this.txtPackExpiryDate.Location = new System.Drawing.Point(160, 206);
            this.txtPackExpiryDate.Name = "txtPackExpiryDate";
            this.txtPackExpiryDate.Size = new System.Drawing.Size(227, 20);
            this.txtPackExpiryDate.TabIndex = 25;
            // 
            // lblPackBatchNumber
            // 
            this.lblPackBatchNumber.AutoSize = true;
            this.lblPackBatchNumber.Location = new System.Drawing.Point(17, 183);
            this.lblPackBatchNumber.Name = "lblPackBatchNumber";
            this.lblPackBatchNumber.Size = new System.Drawing.Size(106, 13);
            this.lblPackBatchNumber.TabIndex = 22;
            this.lblPackBatchNumber.Text = "Pack Batch Number:";
            // 
            // txtPackBatchNumber
            // 
            this.txtPackBatchNumber.Location = new System.Drawing.Point(160, 180);
            this.txtPackBatchNumber.Name = "txtPackBatchNumber";
            this.txtPackBatchNumber.Size = new System.Drawing.Size(227, 20);
            this.txtPackBatchNumber.TabIndex = 23;
            // 
            // lblPackScanCode
            // 
            this.lblPackScanCode.AutoSize = true;
            this.lblPackScanCode.Location = new System.Drawing.Point(17, 157);
            this.lblPackScanCode.Name = "lblPackScanCode";
            this.lblPackScanCode.Size = new System.Drawing.Size(91, 13);
            this.lblPackScanCode.TabIndex = 20;
            this.lblPackScanCode.Text = "Pack Scan Code:";
            // 
            // txtPackScanCode
            // 
            this.txtPackScanCode.Location = new System.Drawing.Point(160, 154);
            this.txtPackScanCode.Name = "txtPackScanCode";
            this.txtPackScanCode.Size = new System.Drawing.Size(227, 20);
            this.txtPackScanCode.TabIndex = 21;
            // 
            // numInputSource
            // 
            this.numInputSource.Location = new System.Drawing.Point(160, 102);
            this.numInputSource.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numInputSource.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInputSource.Name = "numInputSource";
            this.numInputSource.Size = new System.Drawing.Size(228, 20);
            this.numInputSource.TabIndex = 17;
            this.numInputSource.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInputSource
            // 
            this.lblInputSource.AutoSize = true;
            this.lblInputSource.Location = new System.Drawing.Point(17, 104);
            this.lblInputSource.Name = "lblInputSource";
            this.lblInputSource.Size = new System.Drawing.Size(71, 13);
            this.lblInputSource.TabIndex = 16;
            this.lblInputSource.Text = "Input Source:";
            // 
            // lblDeliveryNumber
            // 
            this.lblDeliveryNumber.AutoSize = true;
            this.lblDeliveryNumber.Location = new System.Drawing.Point(17, 80);
            this.lblDeliveryNumber.Name = "lblDeliveryNumber";
            this.lblDeliveryNumber.Size = new System.Drawing.Size(88, 13);
            this.lblDeliveryNumber.TabIndex = 14;
            this.lblDeliveryNumber.Text = "Delivery Number:";
            // 
            // numInitInputID
            // 
            this.numInitInputID.Location = new System.Drawing.Point(160, 25);
            this.numInitInputID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numInitInputID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInitInputID.Name = "numInitInputID";
            this.numInitInputID.Size = new System.Drawing.Size(228, 20);
            this.numInitInputID.TabIndex = 11;
            this.numInitInputID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDeliveryNumber
            // 
            this.txtDeliveryNumber.Location = new System.Drawing.Point(160, 77);
            this.txtDeliveryNumber.Name = "txtDeliveryNumber";
            this.txtDeliveryNumber.Size = new System.Drawing.Size(227, 20);
            this.txtDeliveryNumber.TabIndex = 15;
            // 
            // lblInitInputID
            // 
            this.lblInitInputID.AutoSize = true;
            this.lblInitInputID.Location = new System.Drawing.Point(17, 27);
            this.lblInitInputID.Name = "lblInitInputID";
            this.lblInitInputID.Size = new System.Drawing.Size(122, 13);
            this.lblInitInputID.TabIndex = 10;
            this.lblInitInputID.Text = "InitiateInput Request ID:";
            // 
            // chkSetPickingIndicator
            // 
            this.chkSetPickingIndicator.AutoSize = true;
            this.chkSetPickingIndicator.Location = new System.Drawing.Point(160, 388);
            this.chkSetPickingIndicator.Name = "chkSetPickingIndicator";
            this.chkSetPickingIndicator.Size = new System.Drawing.Size(124, 17);
            this.chkSetPickingIndicator.TabIndex = 38;
            this.chkSetPickingIndicator.Text = "Set Picking Indicator";
            this.chkSetPickingIndicator.UseVisualStyleBackColor = true;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.groupOrderBoxes);
            this.tabOutput.Controls.Add(this.groupOrders);
            this.tabOutput.Controls.Add(this.groupDispensedPacks);
            this.tabOutput.Controls.Add(this.groupOrderLabels);
            this.tabOutput.Controls.Add(this.groupOrderItems);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutput.Size = new System.Drawing.Size(982, 521);
            this.tabOutput.TabIndex = 2;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // groupOrderBoxes
            // 
            this.groupOrderBoxes.Controls.Add(this.dataGridOrderBoxes);
            this.groupOrderBoxes.Location = new System.Drawing.Point(460, 6);
            this.groupOrderBoxes.MaximumSize = new System.Drawing.Size(245, 186);
            this.groupOrderBoxes.Name = "groupOrderBoxes";
            this.groupOrderBoxes.Size = new System.Drawing.Size(245, 186);
            this.groupOrderBoxes.TabIndex = 21;
            this.groupOrderBoxes.TabStop = false;
            this.groupOrderBoxes.Text = "Order Boxes";
            // 
            // dataGridOrderBoxes
            // 
            this.dataGridOrderBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrderBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderBoxes.Location = new System.Drawing.Point(6, 18);
            this.dataGridOrderBoxes.Name = "dataGridOrderBoxes";
            this.dataGridOrderBoxes.Size = new System.Drawing.Size(233, 162);
            this.dataGridOrderBoxes.TabIndex = 17;
            this.dataGridOrderBoxes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridOrderBoxes_DataError);
            // 
            // groupOrders
            // 
            this.groupOrders.Controls.Add(this.btnBulkOrder);
            this.groupOrders.Controls.Add(this.btnClearOrders);
            this.groupOrders.Controls.Add(this.btnCancelOrder);
            this.groupOrders.Controls.Add(this.btnSendOrder);
            this.groupOrders.Controls.Add(this.btnNewOrder);
            this.groupOrders.Controls.Add(this.dataGridOrders);
            this.groupOrders.Location = new System.Drawing.Point(4, 4);
            this.groupOrders.Name = "groupOrders";
            this.groupOrders.Size = new System.Drawing.Size(451, 186);
            this.groupOrders.TabIndex = 9;
            this.groupOrders.TabStop = false;
            this.groupOrders.Text = "Orders";
            // 
            // btnBulkOrder
            // 
            this.btnBulkOrder.Enabled = false;
            this.btnBulkOrder.Location = new System.Drawing.Point(88, 157);
            this.btnBulkOrder.Name = "btnBulkOrder";
            this.btnBulkOrder.Size = new System.Drawing.Size(75, 23);
            this.btnBulkOrder.TabIndex = 12;
            this.btnBulkOrder.Text = "&Bulk ...";
            this.btnBulkOrder.UseVisualStyleBackColor = true;
            this.btnBulkOrder.Click += new System.EventHandler(this.btnBulkOrder_Click);
            // 
            // btnClearOrders
            // 
            this.btnClearOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOrders.Location = new System.Drawing.Point(370, 156);
            this.btnClearOrders.Name = "btnClearOrders";
            this.btnClearOrders.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrders.TabIndex = 15;
            this.btnClearOrders.Text = "Clear";
            this.btnClearOrders.UseVisualStyleBackColor = true;
            this.btnClearOrders.Click += new System.EventHandler(this.btnClearOrders_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.Location = new System.Drawing.Point(289, 156);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOrder.TabIndex = 14;
            this.btnCancelOrder.Text = "&Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Enabled = false;
            this.btnSendOrder.Location = new System.Drawing.Point(169, 157);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSendOrder.TabIndex = 13;
            this.btnSendOrder.Text = "&Send";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Enabled = false;
            this.btnNewOrder.Location = new System.Drawing.Point(7, 157);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 11;
            this.btnNewOrder.Text = "&New ...";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(6, 19);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(439, 131);
            this.dataGridOrders.TabIndex = 10;
            this.dataGridOrders.SelectionChanged += new System.EventHandler(this.dataGridOrders_SelectionChanged);
            this.dataGridOrders.SizeChanged += new System.EventHandler(this.dataGridOrders_SizeChanged);
            // 
            // groupDispensedPacks
            // 
            this.groupDispensedPacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDispensedPacks.Controls.Add(this.dataGridDispensedPacks);
            this.groupDispensedPacks.Location = new System.Drawing.Point(3, 322);
            this.groupDispensedPacks.Name = "groupDispensedPacks";
            this.groupDispensedPacks.Size = new System.Drawing.Size(975, 192);
            this.groupDispensedPacks.TabIndex = 20;
            this.groupDispensedPacks.TabStop = false;
            this.groupDispensedPacks.Text = "Dispensed Packs";
            // 
            // dataGridDispensedPacks
            // 
            this.dataGridDispensedPacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDispensedPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDispensedPacks.Location = new System.Drawing.Point(6, 19);
            this.dataGridDispensedPacks.Name = "dataGridDispensedPacks";
            this.dataGridDispensedPacks.Size = new System.Drawing.Size(963, 167);
            this.dataGridDispensedPacks.TabIndex = 21;
            this.dataGridDispensedPacks.SizeChanged += new System.EventHandler(this.dataGridDispensedPacks_SizeChanged);
            // 
            // groupOrderLabels
            // 
            this.groupOrderLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOrderLabels.Controls.Add(this.dataGridItemLabels);
            this.groupOrderLabels.Location = new System.Drawing.Point(4, 190);
            this.groupOrderLabels.Name = "groupOrderLabels";
            this.groupOrderLabels.Size = new System.Drawing.Size(974, 126);
            this.groupOrderLabels.TabIndex = 18;
            this.groupOrderLabels.TabStop = false;
            this.groupOrderLabels.Text = "Order Item Labels";
            // 
            // dataGridItemLabels
            // 
            this.dataGridItemLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridItemLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemLabels.Location = new System.Drawing.Point(6, 19);
            this.dataGridItemLabels.Name = "dataGridItemLabels";
            this.dataGridItemLabels.Size = new System.Drawing.Size(962, 101);
            this.dataGridItemLabels.TabIndex = 19;
            this.dataGridItemLabels.SizeChanged += new System.EventHandler(this.dataGridItemLabels_SizeChanged);
            // 
            // groupOrderItems
            // 
            this.groupOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOrderItems.Controls.Add(this.dataGridOrderItems);
            this.groupOrderItems.Location = new System.Drawing.Point(712, 4);
            this.groupOrderItems.Name = "groupOrderItems";
            this.groupOrderItems.Size = new System.Drawing.Size(266, 186);
            this.groupOrderItems.TabIndex = 16;
            this.groupOrderItems.TabStop = false;
            this.groupOrderItems.Text = "Order Items";
            // 
            // dataGridOrderItems
            // 
            this.dataGridOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderItems.Location = new System.Drawing.Point(6, 18);
            this.dataGridOrderItems.Name = "dataGridOrderItems";
            this.dataGridOrderItems.Size = new System.Drawing.Size(254, 162);
            this.dataGridOrderItems.TabIndex = 17;
            this.dataGridOrderItems.SelectionChanged += new System.EventHandler(this.dataGridOrderItems_SelectionChanged);
            this.dataGridOrderItems.SizeChanged += new System.EventHandler(this.dataGridOrderItems_SizeChanged);
            // 
            // tabMasterArticles
            // 
            this.tabMasterArticles.Controls.Add(this.groupBoxMasterArticles);
            this.tabMasterArticles.Controls.Add(this.btnImportSelectArticles);
            this.tabMasterArticles.Controls.Add(this.btnGenerateArticles);
            this.tabMasterArticles.Controls.Add(this.btnSendMasterArticles);
            this.tabMasterArticles.Location = new System.Drawing.Point(4, 22);
            this.tabMasterArticles.Name = "tabMasterArticles";
            this.tabMasterArticles.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasterArticles.Size = new System.Drawing.Size(982, 521);
            this.tabMasterArticles.TabIndex = 3;
            this.tabMasterArticles.Text = "Master Articles";
            this.tabMasterArticles.UseVisualStyleBackColor = true;
            // 
            // groupBoxMasterArticles
            // 
            this.groupBoxMasterArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMasterArticles.Controls.Add(this.dataGridMasterArticles);
            this.groupBoxMasterArticles.Location = new System.Drawing.Point(4, 4);
            this.groupBoxMasterArticles.Name = "groupBoxMasterArticles";
            this.groupBoxMasterArticles.Size = new System.Drawing.Size(974, 482);
            this.groupBoxMasterArticles.TabIndex = 14;
            this.groupBoxMasterArticles.TabStop = false;
            this.groupBoxMasterArticles.Text = "Master Articles";
            // 
            // dataGridMasterArticles
            // 
            this.dataGridMasterArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMasterArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMasterArticles.Location = new System.Drawing.Point(6, 19);
            this.dataGridMasterArticles.Name = "dataGridMasterArticles";
            this.dataGridMasterArticles.Size = new System.Drawing.Size(962, 458);
            this.dataGridMasterArticles.TabIndex = 10;
            this.dataGridMasterArticles.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMasterArticles_CellEnter);
            this.dataGridMasterArticles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMasterArticles_RowEnter);
            this.dataGridMasterArticles.SelectionChanged += new System.EventHandler(this.dataGridMasterArticles_SelectionChanged);
            this.dataGridMasterArticles.Resize += new System.EventHandler(this.dataGridMasterArticles_SizeChanged);
            // 
            // btnImportSelectArticles
            // 
            this.btnImportSelectArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportSelectArticles.Location = new System.Drawing.Point(159, 492);
            this.btnImportSelectArticles.Name = "btnImportSelectArticles";
            this.btnImportSelectArticles.Size = new System.Drawing.Size(145, 23);
            this.btnImportSelectArticles.TabIndex = 11;
            this.btnImportSelectArticles.Text = "Import From Select ...";
            this.btnImportSelectArticles.UseVisualStyleBackColor = true;
            this.btnImportSelectArticles.Click += new System.EventHandler(this.btnImportSelectArticles_Click);
            // 
            // btnGenerateArticles
            // 
            this.btnGenerateArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateArticles.Location = new System.Drawing.Point(8, 492);
            this.btnGenerateArticles.Name = "btnGenerateArticles";
            this.btnGenerateArticles.Size = new System.Drawing.Size(145, 23);
            this.btnGenerateArticles.TabIndex = 10;
            this.btnGenerateArticles.Text = "Generate Dummy Articles";
            this.btnGenerateArticles.UseVisualStyleBackColor = true;
            this.btnGenerateArticles.Click += new System.EventHandler(this.btnGenerateArticles_Click);
            // 
            // btnSendMasterArticles
            // 
            this.btnSendMasterArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMasterArticles.Enabled = false;
            this.btnSendMasterArticles.Location = new System.Drawing.Point(899, 492);
            this.btnSendMasterArticles.Name = "btnSendMasterArticles";
            this.btnSendMasterArticles.Size = new System.Drawing.Size(75, 23);
            this.btnSendMasterArticles.TabIndex = 12;
            this.btnSendMasterArticles.Text = "Send";
            this.btnSendMasterArticles.UseVisualStyleBackColor = true;
            this.btnSendMasterArticles.Click += new System.EventHandler(this.btnSendMasterArticles_Click);
            // 
            // tabStockDeliveries
            // 
            this.tabStockDeliveries.Controls.Add(this.btnImportFromSelect);
            this.tabStockDeliveries.Controls.Add(this.dataGridDeliveryItems);
            this.tabStockDeliveries.Controls.Add(this.btnSendStockDeliveries);
            this.tabStockDeliveries.Location = new System.Drawing.Point(4, 22);
            this.tabStockDeliveries.Name = "tabStockDeliveries";
            this.tabStockDeliveries.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockDeliveries.Size = new System.Drawing.Size(982, 521);
            this.tabStockDeliveries.TabIndex = 4;
            this.tabStockDeliveries.Text = "Stock Deliveries";
            this.tabStockDeliveries.UseVisualStyleBackColor = true;
            // 
            // dataGridDeliveryItems
            // 
            this.dataGridDeliveryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDeliveryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeliveryItems.Location = new System.Drawing.Point(8, 6);
            this.dataGridDeliveryItems.Name = "dataGridDeliveryItems";
            this.dataGridDeliveryItems.Size = new System.Drawing.Size(968, 480);
            this.dataGridDeliveryItems.TabIndex = 9;
            this.dataGridDeliveryItems.SizeChanged += new System.EventHandler(this.dataGridDeliveryItems_SizeChanged);
            // 
            // btnSendStockDeliveries
            // 
            this.btnSendStockDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendStockDeliveries.Enabled = false;
            this.btnSendStockDeliveries.Location = new System.Drawing.Point(899, 492);
            this.btnSendStockDeliveries.Name = "btnSendStockDeliveries";
            this.btnSendStockDeliveries.Size = new System.Drawing.Size(75, 23);
            this.btnSendStockDeliveries.TabIndex = 10;
            this.btnSendStockDeliveries.Text = "Send";
            this.btnSendStockDeliveries.UseVisualStyleBackColor = true;
            this.btnSendStockDeliveries.Click += new System.EventHandler(this.btnSendStockDeliveries_Click);
            // 
            // tabTaskInfo
            // 
            this.tabTaskInfo.Controls.Add(this.groupTask);
            this.tabTaskInfo.Controls.Add(this.groupPacks);
            this.tabTaskInfo.Controls.Add(this.groupArticles);
            this.tabTaskInfo.Location = new System.Drawing.Point(4, 22);
            this.tabTaskInfo.Name = "tabTaskInfo";
            this.tabTaskInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaskInfo.Size = new System.Drawing.Size(982, 521);
            this.tabTaskInfo.TabIndex = 6;
            this.tabTaskInfo.Text = "Task Info";
            this.tabTaskInfo.UseVisualStyleBackColor = true;
            // 
            // groupTask
            // 
            this.groupTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTask.Controls.Add(this.btnGetTaskInfo);
            this.groupTask.Controls.Add(this.lblTaskState);
            this.groupTask.Controls.Add(this.lblTaskStateDesc);
            this.groupTask.Controls.Add(this.cmbTaskType);
            this.groupTask.Controls.Add(this.lblTaskType);
            this.groupTask.Controls.Add(this.txtTaskID);
            this.groupTask.Controls.Add(this.lblTaskID);
            this.groupTask.Location = new System.Drawing.Point(4, 4);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(974, 65);
            this.groupTask.TabIndex = 9;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Task";
            // 
            // btnGetTaskInfo
            // 
            this.btnGetTaskInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetTaskInfo.Enabled = false;
            this.btnGetTaskInfo.Location = new System.Drawing.Point(893, 20);
            this.btnGetTaskInfo.Name = "btnGetTaskInfo";
            this.btnGetTaskInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetTaskInfo.TabIndex = 16;
            this.btnGetTaskInfo.Text = "Get Info";
            this.btnGetTaskInfo.UseVisualStyleBackColor = true;
            this.btnGetTaskInfo.Click += new System.EventHandler(this.btnGetTaskInfo_Click);
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.Location = new System.Drawing.Point(485, 26);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(60, 13);
            this.lblTaskState.TabIndex = 15;
            this.lblTaskState.Text = "Unknown";
            // 
            // lblTaskStateDesc
            // 
            this.lblTaskStateDesc.AutoSize = true;
            this.lblTaskStateDesc.Location = new System.Drawing.Point(412, 26);
            this.lblTaskStateDesc.Name = "lblTaskStateDesc";
            this.lblTaskStateDesc.Size = new System.Drawing.Size(67, 13);
            this.lblTaskStateDesc.TabIndex = 14;
            this.lblTaskStateDesc.Text = "Task Status:";
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Items.AddRange(new object[] {
            "Output",
            "StockDelivery"});
            this.cmbTaskType.Location = new System.Drawing.Point(253, 22);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(121, 21);
            this.cmbTaskType.TabIndex = 13;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(186, 26);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(61, 13);
            this.lblTaskType.TabIndex = 12;
            this.lblTaskType.Text = "Task Type:";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(60, 23);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(100, 20);
            this.txtTaskID.TabIndex = 11;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(6, 26);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(48, 13);
            this.lblTaskID.TabIndex = 10;
            this.lblTaskID.Text = "Task ID:";
            // 
            // groupPacks
            // 
            this.groupPacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPacks.Controls.Add(this.dataGridPackInfo);
            this.groupPacks.Location = new System.Drawing.Point(270, 75);
            this.groupPacks.Name = "groupPacks";
            this.groupPacks.Size = new System.Drawing.Size(708, 443);
            this.groupPacks.TabIndex = 19;
            this.groupPacks.TabStop = false;
            this.groupPacks.Text = "Packs";
            // 
            // dataGridPackInfo
            // 
            this.dataGridPackInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPackInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPackInfo.Location = new System.Drawing.Point(7, 19);
            this.dataGridPackInfo.Name = "dataGridPackInfo";
            this.dataGridPackInfo.Size = new System.Drawing.Size(696, 418);
            this.dataGridPackInfo.TabIndex = 20;
            this.dataGridPackInfo.SizeChanged += new System.EventHandler(this.dataGridPackInfo_SizeChanged);
            // 
            // groupArticles
            // 
            this.groupArticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupArticles.Controls.Add(this.dataGridArticleInfo);
            this.groupArticles.Location = new System.Drawing.Point(4, 75);
            this.groupArticles.Name = "groupArticles";
            this.groupArticles.Size = new System.Drawing.Size(260, 443);
            this.groupArticles.TabIndex = 17;
            this.groupArticles.TabStop = false;
            this.groupArticles.Text = "Articles";
            // 
            // dataGridArticleInfo
            // 
            this.dataGridArticleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArticleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticleInfo.Location = new System.Drawing.Point(6, 19);
            this.dataGridArticleInfo.Name = "dataGridArticleInfo";
            this.dataGridArticleInfo.Size = new System.Drawing.Size(248, 418);
            this.dataGridArticleInfo.TabIndex = 18;
            this.dataGridArticleInfo.SelectionChanged += new System.EventHandler(this.dataGridArticleInfo_SelectionChanged);
            this.dataGridArticleInfo.SizeChanged += new System.EventHandler(this.dataGridArticleInfo_SizeChanged);
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.groupComponents);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(982, 521);
            this.tabStatus.TabIndex = 7;
            this.tabStatus.Text = "Status Info";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // groupComponents
            // 
            this.groupComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComponents.Controls.Add(this.dataGridComponents);
            this.groupComponents.Controls.Add(this.btnReloadComponents);
            this.groupComponents.Location = new System.Drawing.Point(4, 4);
            this.groupComponents.Name = "groupComponents";
            this.groupComponents.Size = new System.Drawing.Size(974, 510);
            this.groupComponents.TabIndex = 9;
            this.groupComponents.TabStop = false;
            this.groupComponents.Text = "Components";
            // 
            // dataGridComponents
            // 
            this.dataGridComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComponents.Location = new System.Drawing.Point(6, 19);
            this.dataGridComponents.Name = "dataGridComponents";
            this.dataGridComponents.Size = new System.Drawing.Size(962, 457);
            this.dataGridComponents.TabIndex = 10;
            this.dataGridComponents.SizeChanged += new System.EventHandler(this.dataGridComponents_SizeChanged);
            // 
            // btnReloadComponents
            // 
            this.btnReloadComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadComponents.Enabled = false;
            this.btnReloadComponents.Location = new System.Drawing.Point(893, 482);
            this.btnReloadComponents.Name = "btnReloadComponents";
            this.btnReloadComponents.Size = new System.Drawing.Size(75, 23);
            this.btnReloadComponents.TabIndex = 11;
            this.btnReloadComponents.Text = "Reload";
            this.btnReloadComponents.UseVisualStyleBackColor = true;
            this.btnReloadComponents.Click += new System.EventHandler(this.btnReloadComponents_Click);
            // 
            // tabLocations
            // 
            this.tabLocations.Controls.Add(this.groupStockLocations);
            this.tabLocations.Location = new System.Drawing.Point(4, 22);
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocations.Size = new System.Drawing.Size(982, 521);
            this.tabLocations.TabIndex = 8;
            this.tabLocations.Text = "Stock Locations";
            this.tabLocations.UseVisualStyleBackColor = true;
            // 
            // groupStockLocations
            // 
            this.groupStockLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStockLocations.Controls.Add(this.dataGridStockLocations);
            this.groupStockLocations.Controls.Add(this.btnReloadStockLocations);
            this.groupStockLocations.Location = new System.Drawing.Point(4, 4);
            this.groupStockLocations.Name = "groupStockLocations";
            this.groupStockLocations.Size = new System.Drawing.Size(974, 510);
            this.groupStockLocations.TabIndex = 9;
            this.groupStockLocations.TabStop = false;
            this.groupStockLocations.Text = "Stock Locations";
            // 
            // dataGridStockLocations
            // 
            this.dataGridStockLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStockLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStockLocations.Location = new System.Drawing.Point(6, 19);
            this.dataGridStockLocations.Name = "dataGridStockLocations";
            this.dataGridStockLocations.Size = new System.Drawing.Size(962, 457);
            this.dataGridStockLocations.TabIndex = 10;
            this.dataGridStockLocations.SizeChanged += new System.EventHandler(this.dataGridStockLocations_SizeChanged);
            // 
            // btnReloadStockLocations
            // 
            this.btnReloadStockLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadStockLocations.Enabled = false;
            this.btnReloadStockLocations.Location = new System.Drawing.Point(893, 482);
            this.btnReloadStockLocations.Name = "btnReloadStockLocations";
            this.btnReloadStockLocations.Size = new System.Drawing.Size(75, 23);
            this.btnReloadStockLocations.TabIndex = 11;
            this.btnReloadStockLocations.Text = "Reload";
            this.btnReloadStockLocations.UseVisualStyleBackColor = true;
            this.btnReloadStockLocations.Click += new System.EventHandler(this.btnReloadStockLocations_Click);
            // 
            // tabRawXml
            // 
            this.tabRawXml.Controls.Add(this.groupRawXml);
            this.tabRawXml.Location = new System.Drawing.Point(4, 22);
            this.tabRawXml.Name = "tabRawXml";
            this.tabRawXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawXml.Size = new System.Drawing.Size(982, 521);
            this.tabRawXml.TabIndex = 9;
            this.tabRawXml.Text = "Raw XML";
            this.tabRawXml.UseVisualStyleBackColor = true;
            // 
            // groupRawXml
            // 
            this.groupRawXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRawXml.Controls.Add(this.txtRawXml);
            this.groupRawXml.Controls.Add(this.btnClearRawXml);
            this.groupRawXml.Controls.Add(this.btnSendRawXml);
            this.groupRawXml.Location = new System.Drawing.Point(7, 7);
            this.groupRawXml.Name = "groupRawXml";
            this.groupRawXml.Size = new System.Drawing.Size(975, 510);
            this.groupRawXml.TabIndex = 0;
            this.groupRawXml.TabStop = false;
            this.groupRawXml.Text = "Raw XML";
            // 
            // txtRawXml
            // 
            this.txtRawXml.AutoWordSelection = true;
            this.txtRawXml.Location = new System.Drawing.Point(8, 32);
            this.txtRawXml.Name = "txtRawXml";
            this.txtRawXml.Size = new System.Drawing.Size(583, 258);
            this.txtRawXml.TabIndex = 3;
            this.txtRawXml.Text = "";
            this.txtRawXml.TextChanged += new System.EventHandler(this.txtRawXml_TextChanged);
            // 
            // btnClearRawXml
            // 
            this.btnClearRawXml.Location = new System.Drawing.Point(435, 296);
            this.btnClearRawXml.Name = "btnClearRawXml";
            this.btnClearRawXml.Size = new System.Drawing.Size(75, 23);
            this.btnClearRawXml.TabIndex = 2;
            this.btnClearRawXml.Text = "Clear";
            this.btnClearRawXml.UseVisualStyleBackColor = true;
            this.btnClearRawXml.Click += new System.EventHandler(this.btnClearRawXml_Click);
            // 
            // btnSendRawXml
            // 
            this.btnSendRawXml.Enabled = false;
            this.btnSendRawXml.Location = new System.Drawing.Point(516, 296);
            this.btnSendRawXml.Name = "btnSendRawXml";
            this.btnSendRawXml.Size = new System.Drawing.Size(75, 23);
            this.btnSendRawXml.TabIndex = 1;
            this.btnSendRawXml.Text = "Send";
            this.btnSendRawXml.UseVisualStyleBackColor = true;
            this.btnSendRawXml.Click += new System.EventHandler(this.btnSendRawXml_Click);
            // 
            // openArticleFileDialog
            // 
            this.openArticleFileDialog.DefaultExt = "txt";
            this.openArticleFileDialog.FileName = "ArtikelNamen.txt";
            this.openArticleFileDialog.Filter = "Article Files|*.txt|All files|*.*";
            this.openArticleFileDialog.Title = "Select the Article Export File";
            // 
            // bgInitInput
            // 
            this.bgInitInput.WorkerReportsProgress = true;
            this.bgInitInput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgInitInput_DoWork);
            this.bgInitInput.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgInitInput_ProgressChanged);
            this.bgInitInput.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgInitInput_RunWorkerCompleted);
            // 
            // groupBoxDigitalShelf
            // 
            this.groupBoxDigitalShelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDigitalShelf.Controls.Add(this.buttonDigitalShelfDisconnect);
            this.groupBoxDigitalShelf.Controls.Add(this.buttonDigitalShelfConnect);
            this.groupBoxDigitalShelf.Controls.Add(this.numericUpDownDigitalShelfPort);
            this.groupBoxDigitalShelf.Controls.Add(this.textBoxDigitalShelfAddress);
            this.groupBoxDigitalShelf.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDigitalShelf.Name = "groupBoxDigitalShelf";
            this.groupBoxDigitalShelf.Size = new System.Drawing.Size(976, 54);
            this.groupBoxDigitalShelf.TabIndex = 9;
            this.groupBoxDigitalShelf.TabStop = false;
            this.groupBoxDigitalShelf.Text = "Digital Shelf";
            // 
            // buttonDigitalShelfDisconnect
            // 
            this.buttonDigitalShelfDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDigitalShelfDisconnect.Enabled = false;
            this.buttonDigitalShelfDisconnect.Location = new System.Drawing.Point(891, 17);
            this.buttonDigitalShelfDisconnect.Name = "buttonDigitalShelfDisconnect";
            this.buttonDigitalShelfDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDigitalShelfDisconnect.TabIndex = 7;
            this.buttonDigitalShelfDisconnect.Text = "&Disconnect";
            this.buttonDigitalShelfDisconnect.UseVisualStyleBackColor = true;
            this.buttonDigitalShelfDisconnect.Click += new System.EventHandler(this.buttonDigitalShelfDisconnect_Click);
            // 
            // buttonDigitalShelfConnect
            // 
            this.buttonDigitalShelfConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDigitalShelfConnect.Location = new System.Drawing.Point(810, 18);
            this.buttonDigitalShelfConnect.Name = "buttonDigitalShelfConnect";
            this.buttonDigitalShelfConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDigitalShelfConnect.TabIndex = 6;
            this.buttonDigitalShelfConnect.Text = "&Connect";
            this.buttonDigitalShelfConnect.UseVisualStyleBackColor = true;
            this.buttonDigitalShelfConnect.Click += new System.EventHandler(this.buttonDigitalShelfConnect_Click);
            // 
            // numericUpDownDigitalShelfPort
            // 
            this.numericUpDownDigitalShelfPort.Location = new System.Drawing.Point(120, 20);
            this.numericUpDownDigitalShelfPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownDigitalShelfPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDigitalShelfPort.Name = "numericUpDownDigitalShelfPort";
            this.numericUpDownDigitalShelfPort.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownDigitalShelfPort.TabIndex = 2;
            this.numericUpDownDigitalShelfPort.Value = new decimal(new int[] {
            6050,
            0,
            0,
            0});
            // 
            // textBoxDigitalShelfAddress
            // 
            this.textBoxDigitalShelfAddress.Location = new System.Drawing.Point(13, 20);
            this.textBoxDigitalShelfAddress.Name = "textBoxDigitalShelfAddress";
            this.textBoxDigitalShelfAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDigitalShelfAddress.TabIndex = 1;
            this.textBoxDigitalShelfAddress.Text = "localhost";
            // 
            // backgroundWorkerConnectDigitalShelf
            // 
            this.backgroundWorkerConnectDigitalShelf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConnectDigitalShelf_DoWork);
            this.backgroundWorkerConnectDigitalShelf.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConnectDigitalShelf_RunWorkerCompleted);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStorageSystem);
            this.tabControlMain.Controls.Add(this.tabPageDigitalShelf);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(996, 640);
            this.tabControlMain.TabIndex = 10;
            // 
            // tabPageStorageSystem
            // 
            this.tabPageStorageSystem.Controls.Add(this.groupConnection);
            this.tabPageStorageSystem.Controls.Add(this.tabControlStorageSystem);
            this.tabPageStorageSystem.Location = new System.Drawing.Point(4, 22);
            this.tabPageStorageSystem.Name = "tabPageStorageSystem";
            this.tabPageStorageSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStorageSystem.Size = new System.Drawing.Size(988, 614);
            this.tabPageStorageSystem.TabIndex = 0;
            this.tabPageStorageSystem.Text = "Storage System";
            this.tabPageStorageSystem.UseVisualStyleBackColor = true;
            // 
            // tabPageDigitalShelf
            // 
            this.tabPageDigitalShelf.Controls.Add(this.tabControlDigitalShelf);
            this.tabPageDigitalShelf.Controls.Add(this.groupBoxDigitalShelf);
            this.tabPageDigitalShelf.Location = new System.Drawing.Point(4, 22);
            this.tabPageDigitalShelf.Name = "tabPageDigitalShelf";
            this.tabPageDigitalShelf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDigitalShelf.Size = new System.Drawing.Size(988, 614);
            this.tabPageDigitalShelf.TabIndex = 1;
            this.tabPageDigitalShelf.Text = "Digital Shelf";
            this.tabPageDigitalShelf.UseVisualStyleBackColor = true;
            // 
            // tabControlDigitalShelf
            // 
            this.tabControlDigitalShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDigitalShelf.Controls.Add(this.tabPageLog);
            this.tabControlDigitalShelf.Controls.Add(this.tabPageArticleInfo);
            this.tabControlDigitalShelf.Controls.Add(this.tabPagePriceInformation);
            this.tabControlDigitalShelf.Controls.Add(this.tabPageShoppingCartRequested);
            this.tabControlDigitalShelf.Controls.Add(this.tabRawXmlDigitalShelf);
            this.tabControlDigitalShelf.Location = new System.Drawing.Point(0, 66);
            this.tabControlDigitalShelf.Name = "tabControlDigitalShelf";
            this.tabControlDigitalShelf.SelectedIndex = 0;
            this.tabControlDigitalShelf.Size = new System.Drawing.Size(988, 542);
            this.tabControlDigitalShelf.TabIndex = 33;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonClearDigitalShelfLog);
            this.tabPageLog.Controls.Add(this.listBoxDigitalShelfLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(980, 516);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonClearDigitalShelfLog
            // 
            this.buttonClearDigitalShelfLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearDigitalShelfLog.Location = new System.Drawing.Point(899, 487);
            this.buttonClearDigitalShelfLog.Name = "buttonClearDigitalShelfLog";
            this.buttonClearDigitalShelfLog.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDigitalShelfLog.TabIndex = 29;
            this.buttonClearDigitalShelfLog.Text = "Clear";
            this.buttonClearDigitalShelfLog.UseVisualStyleBackColor = true;
            this.buttonClearDigitalShelfLog.Click += new System.EventHandler(this.buttonClearDigitalShelfLog_Click);
            // 
            // listBoxDigitalShelfLog
            // 
            this.listBoxDigitalShelfLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDigitalShelfLog.FormattingEnabled = true;
            this.listBoxDigitalShelfLog.Location = new System.Drawing.Point(6, 6);
            this.listBoxDigitalShelfLog.Name = "listBoxDigitalShelfLog";
            this.listBoxDigitalShelfLog.Size = new System.Drawing.Size(968, 446);
            this.listBoxDigitalShelfLog.TabIndex = 28;
            // 
            // tabPageArticleInfo
            // 
            this.tabPageArticleInfo.Controls.Add(this.groupBoxArticleInformation);
            this.tabPageArticleInfo.Controls.Add(this.groupBoxTag);
            this.tabPageArticleInfo.Controls.Add(this.groupBoxAlternativePackSizeArticle);
            this.tabPageArticleInfo.Controls.Add(this.groupBoxAlternativeArticle);
            this.tabPageArticleInfo.Controls.Add(this.groupBoxCrossSellingArticle);
            this.tabPageArticleInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageArticleInfo.Name = "tabPageArticleInfo";
            this.tabPageArticleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArticleInfo.Size = new System.Drawing.Size(980, 516);
            this.tabPageArticleInfo.TabIndex = 1;
            this.tabPageArticleInfo.Text = "Article Information";
            this.tabPageArticleInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxArticleInformation
            // 
            this.groupBoxArticleInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArticleInformation.Controls.Add(this.numericUpDownMaxSubItemQuantity);
            this.groupBoxArticleInformation.Controls.Add(this.labelMaxSubItemQuantity);
            this.groupBoxArticleInformation.Controls.Add(this.textBoxPackagingUnit);
            this.groupBoxArticleInformation.Controls.Add(this.labelPackagingUnit);
            this.groupBoxArticleInformation.Controls.Add(this.textBoxDosageForm);
            this.groupBoxArticleInformation.Controls.Add(this.labelDosageForm);
            this.groupBoxArticleInformation.Controls.Add(this.labelArticleName);
            this.groupBoxArticleInformation.Controls.Add(this.textBoxArticleName);
            this.groupBoxArticleInformation.Controls.Add(this.checkBoxArticleInformationAutoGenerate);
            this.groupBoxArticleInformation.Location = new System.Drawing.Point(4, 4);
            this.groupBoxArticleInformation.Name = "groupBoxArticleInformation";
            this.groupBoxArticleInformation.Size = new System.Drawing.Size(974, 72);
            this.groupBoxArticleInformation.TabIndex = 10;
            this.groupBoxArticleInformation.TabStop = false;
            this.groupBoxArticleInformation.Text = "Article Information";
            // 
            // numericUpDownMaxSubItemQuantity
            // 
            this.numericUpDownMaxSubItemQuantity.Location = new System.Drawing.Point(870, 43);
            this.numericUpDownMaxSubItemQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMaxSubItemQuantity.Name = "numericUpDownMaxSubItemQuantity";
            this.numericUpDownMaxSubItemQuantity.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownMaxSubItemQuantity.TabIndex = 42;
            // 
            // labelMaxSubItemQuantity
            // 
            this.labelMaxSubItemQuantity.AutoSize = true;
            this.labelMaxSubItemQuantity.Location = new System.Drawing.Point(747, 46);
            this.labelMaxSubItemQuantity.Name = "labelMaxSubItemQuantity";
            this.labelMaxSubItemQuantity.Size = new System.Drawing.Size(117, 13);
            this.labelMaxSubItemQuantity.TabIndex = 40;
            this.labelMaxSubItemQuantity.Text = "Max Sub Item Quantity:";
            // 
            // textBoxPackagingUnit
            // 
            this.textBoxPackagingUnit.Location = new System.Drawing.Point(600, 43);
            this.textBoxPackagingUnit.Name = "textBoxPackagingUnit";
            this.textBoxPackagingUnit.Size = new System.Drawing.Size(138, 20);
            this.textBoxPackagingUnit.TabIndex = 39;
            // 
            // labelPackagingUnit
            // 
            this.labelPackagingUnit.AutoSize = true;
            this.labelPackagingUnit.Location = new System.Drawing.Point(511, 46);
            this.labelPackagingUnit.Name = "labelPackagingUnit";
            this.labelPackagingUnit.Size = new System.Drawing.Size(83, 13);
            this.labelPackagingUnit.TabIndex = 38;
            this.labelPackagingUnit.Text = "Packaging Unit:";
            // 
            // textBoxDosageForm
            // 
            this.textBoxDosageForm.Location = new System.Drawing.Point(354, 43);
            this.textBoxDosageForm.Name = "textBoxDosageForm";
            this.textBoxDosageForm.Size = new System.Drawing.Size(148, 20);
            this.textBoxDosageForm.TabIndex = 37;
            // 
            // labelDosageForm
            // 
            this.labelDosageForm.AutoSize = true;
            this.labelDosageForm.Location = new System.Drawing.Point(275, 46);
            this.labelDosageForm.Name = "labelDosageForm";
            this.labelDosageForm.Size = new System.Drawing.Size(73, 13);
            this.labelDosageForm.TabIndex = 36;
            this.labelDosageForm.Text = "Dosage Form:";
            // 
            // labelArticleName
            // 
            this.labelArticleName.AutoSize = true;
            this.labelArticleName.Location = new System.Drawing.Point(3, 46);
            this.labelArticleName.Name = "labelArticleName";
            this.labelArticleName.Size = new System.Drawing.Size(70, 13);
            this.labelArticleName.TabIndex = 35;
            this.labelArticleName.Text = "Article Name:";
            // 
            // textBoxArticleName
            // 
            this.textBoxArticleName.Location = new System.Drawing.Point(79, 43);
            this.textBoxArticleName.Name = "textBoxArticleName";
            this.textBoxArticleName.Size = new System.Drawing.Size(181, 20);
            this.textBoxArticleName.TabIndex = 34;
            // 
            // checkBoxArticleInformationAutoGenerate
            // 
            this.checkBoxArticleInformationAutoGenerate.AutoSize = true;
            this.checkBoxArticleInformationAutoGenerate.Checked = true;
            this.checkBoxArticleInformationAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxArticleInformationAutoGenerate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxArticleInformationAutoGenerate.Name = "checkBoxArticleInformationAutoGenerate";
            this.checkBoxArticleInformationAutoGenerate.Size = new System.Drawing.Size(182, 17);
            this.checkBoxArticleInformationAutoGenerate.TabIndex = 33;
            this.checkBoxArticleInformationAutoGenerate.Text = "Auto Generate Article Information";
            this.checkBoxArticleInformationAutoGenerate.UseVisualStyleBackColor = true;
            this.checkBoxArticleInformationAutoGenerate.Click += new System.EventHandler(this.checkBoxArticleInformationAutoGenerate_Click);
            // 
            // groupBoxTag
            // 
            this.groupBoxTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTag.Controls.Add(this.checkBoxTagAutoGenerate);
            this.groupBoxTag.Controls.Add(this.buttonRemoveTag);
            this.groupBoxTag.Controls.Add(this.buttonAddTag);
            this.groupBoxTag.Controls.Add(this.listBoxTag);
            this.groupBoxTag.Location = new System.Drawing.Point(4, 82);
            this.groupBoxTag.Name = "groupBoxTag";
            this.groupBoxTag.Size = new System.Drawing.Size(266, 427);
            this.groupBoxTag.TabIndex = 9;
            this.groupBoxTag.TabStop = false;
            this.groupBoxTag.Text = "Tags";
            // 
            // checkBoxTagAutoGenerate
            // 
            this.checkBoxTagAutoGenerate.AutoSize = true;
            this.checkBoxTagAutoGenerate.Checked = true;
            this.checkBoxTagAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTagAutoGenerate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxTagAutoGenerate.Name = "checkBoxTagAutoGenerate";
            this.checkBoxTagAutoGenerate.Size = new System.Drawing.Size(122, 17);
            this.checkBoxTagAutoGenerate.TabIndex = 32;
            this.checkBoxTagAutoGenerate.Text = "Auto Generate Tags";
            this.checkBoxTagAutoGenerate.UseVisualStyleBackColor = true;
            this.checkBoxTagAutoGenerate.Click += new System.EventHandler(this.checkBoxTagAutoGenerate_Click);
            // 
            // buttonRemoveTag
            // 
            this.buttonRemoveTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveTag.Location = new System.Drawing.Point(185, 397);
            this.buttonRemoveTag.Name = "buttonRemoveTag";
            this.buttonRemoveTag.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTag.TabIndex = 31;
            this.buttonRemoveTag.Text = "Remove";
            this.buttonRemoveTag.UseVisualStyleBackColor = true;
            this.buttonRemoveTag.Click += new System.EventHandler(this.buttonRemoveTag_Click);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTag.Location = new System.Drawing.Point(104, 397);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTag.TabIndex = 30;
            this.buttonAddTag.Text = "Add...";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // listBoxTag
            // 
            this.listBoxTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTag.FormattingEnabled = true;
            this.listBoxTag.Location = new System.Drawing.Point(6, 39);
            this.listBoxTag.Name = "listBoxTag";
            this.listBoxTag.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTag.Size = new System.Drawing.Size(254, 329);
            this.listBoxTag.TabIndex = 29;
            // 
            // groupBoxAlternativePackSizeArticle
            // 
            this.groupBoxAlternativePackSizeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlternativePackSizeArticle.Controls.Add(this.checkBoxAlternativePackSizeAutoGenerated);
            this.groupBoxAlternativePackSizeArticle.Controls.Add(this.buttonRemoveAlternativePackSizeArticle);
            this.groupBoxAlternativePackSizeArticle.Controls.Add(this.buttonAddAlternativePackSizeArticle);
            this.groupBoxAlternativePackSizeArticle.Controls.Add(this.listBoxAlternativePackSizeArticle);
            this.groupBoxAlternativePackSizeArticle.Location = new System.Drawing.Point(748, 82);
            this.groupBoxAlternativePackSizeArticle.Name = "groupBoxAlternativePackSizeArticle";
            this.groupBoxAlternativePackSizeArticle.Size = new System.Drawing.Size(230, 427);
            this.groupBoxAlternativePackSizeArticle.TabIndex = 8;
            this.groupBoxAlternativePackSizeArticle.TabStop = false;
            this.groupBoxAlternativePackSizeArticle.Text = "Alternative Pack Size Articles";
            // 
            // checkBoxAlternativePackSizeAutoGenerated
            // 
            this.checkBoxAlternativePackSizeAutoGenerated.AutoSize = true;
            this.checkBoxAlternativePackSizeAutoGenerated.Checked = true;
            this.checkBoxAlternativePackSizeAutoGenerated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlternativePackSizeAutoGenerated.Location = new System.Drawing.Point(7, 20);
            this.checkBoxAlternativePackSizeAutoGenerated.Name = "checkBoxAlternativePackSizeAutoGenerated";
            this.checkBoxAlternativePackSizeAutoGenerated.Size = new System.Drawing.Size(204, 17);
            this.checkBoxAlternativePackSizeAutoGenerated.TabIndex = 36;
            this.checkBoxAlternativePackSizeAutoGenerated.Text = "Auto Generates Alternative Pack Size";
            this.checkBoxAlternativePackSizeAutoGenerated.UseVisualStyleBackColor = true;
            this.checkBoxAlternativePackSizeAutoGenerated.Click += new System.EventHandler(this.checkBoxAlternativePackSizeAutoGenerated_Click);
            // 
            // buttonRemoveAlternativePackSizeArticle
            // 
            this.buttonRemoveAlternativePackSizeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAlternativePackSizeArticle.Location = new System.Drawing.Point(149, 397);
            this.buttonRemoveAlternativePackSizeArticle.Name = "buttonRemoveAlternativePackSizeArticle";
            this.buttonRemoveAlternativePackSizeArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAlternativePackSizeArticle.TabIndex = 34;
            this.buttonRemoveAlternativePackSizeArticle.Text = "Remove";
            this.buttonRemoveAlternativePackSizeArticle.UseVisualStyleBackColor = true;
            this.buttonRemoveAlternativePackSizeArticle.Click += new System.EventHandler(this.buttonRemoveAlternativePackSizeArticle_Click);
            // 
            // buttonAddAlternativePackSizeArticle
            // 
            this.buttonAddAlternativePackSizeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAlternativePackSizeArticle.Location = new System.Drawing.Point(68, 397);
            this.buttonAddAlternativePackSizeArticle.Name = "buttonAddAlternativePackSizeArticle";
            this.buttonAddAlternativePackSizeArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlternativePackSizeArticle.TabIndex = 33;
            this.buttonAddAlternativePackSizeArticle.Text = "Add...";
            this.buttonAddAlternativePackSizeArticle.UseVisualStyleBackColor = true;
            this.buttonAddAlternativePackSizeArticle.Click += new System.EventHandler(this.buttonAddAlternativePackSizeArticle_Click);
            // 
            // listBoxAlternativePackSizeArticle
            // 
            this.listBoxAlternativePackSizeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlternativePackSizeArticle.FormattingEnabled = true;
            this.listBoxAlternativePackSizeArticle.Location = new System.Drawing.Point(6, 39);
            this.listBoxAlternativePackSizeArticle.Name = "listBoxAlternativePackSizeArticle";
            this.listBoxAlternativePackSizeArticle.Size = new System.Drawing.Size(218, 329);
            this.listBoxAlternativePackSizeArticle.TabIndex = 32;
            // 
            // groupBoxAlternativeArticle
            // 
            this.groupBoxAlternativeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlternativeArticle.Controls.Add(this.checkBoxAlternativeArticlesAutoGenerate);
            this.groupBoxAlternativeArticle.Controls.Add(this.buttonRemoveAlternativeArticle);
            this.groupBoxAlternativeArticle.Controls.Add(this.buttonAddAlternativeArticle);
            this.groupBoxAlternativeArticle.Controls.Add(this.listBoxAlternativeArticle);
            this.groupBoxAlternativeArticle.Location = new System.Drawing.Point(512, 82);
            this.groupBoxAlternativeArticle.Name = "groupBoxAlternativeArticle";
            this.groupBoxAlternativeArticle.Size = new System.Drawing.Size(230, 427);
            this.groupBoxAlternativeArticle.TabIndex = 7;
            this.groupBoxAlternativeArticle.TabStop = false;
            this.groupBoxAlternativeArticle.Text = "Alternative Articles";
            // 
            // checkBoxAlternativeArticlesAutoGenerate
            // 
            this.checkBoxAlternativeArticlesAutoGenerate.AutoSize = true;
            this.checkBoxAlternativeArticlesAutoGenerate.Checked = true;
            this.checkBoxAlternativeArticlesAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlternativeArticlesAutoGenerate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxAlternativeArticlesAutoGenerate.Name = "checkBoxAlternativeArticlesAutoGenerate";
            this.checkBoxAlternativeArticlesAutoGenerate.Size = new System.Drawing.Size(190, 17);
            this.checkBoxAlternativeArticlesAutoGenerate.TabIndex = 35;
            this.checkBoxAlternativeArticlesAutoGenerate.Text = "Auto Generates Alternative Articles";
            this.checkBoxAlternativeArticlesAutoGenerate.UseVisualStyleBackColor = true;
            this.checkBoxAlternativeArticlesAutoGenerate.Click += new System.EventHandler(this.checkBoxAlternativeArticlesAutoGenerate_Click);
            // 
            // buttonRemoveAlternativeArticle
            // 
            this.buttonRemoveAlternativeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAlternativeArticle.Location = new System.Drawing.Point(149, 397);
            this.buttonRemoveAlternativeArticle.Name = "buttonRemoveAlternativeArticle";
            this.buttonRemoveAlternativeArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAlternativeArticle.TabIndex = 34;
            this.buttonRemoveAlternativeArticle.Text = "Remove";
            this.buttonRemoveAlternativeArticle.UseVisualStyleBackColor = true;
            this.buttonRemoveAlternativeArticle.Click += new System.EventHandler(this.buttonRemoveAlternativeArticle_Click);
            // 
            // buttonAddAlternativeArticle
            // 
            this.buttonAddAlternativeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAlternativeArticle.Location = new System.Drawing.Point(68, 397);
            this.buttonAddAlternativeArticle.Name = "buttonAddAlternativeArticle";
            this.buttonAddAlternativeArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlternativeArticle.TabIndex = 33;
            this.buttonAddAlternativeArticle.Text = "Add...";
            this.buttonAddAlternativeArticle.UseVisualStyleBackColor = true;
            this.buttonAddAlternativeArticle.Click += new System.EventHandler(this.buttonAddAlternativeArticle_Click);
            // 
            // listBoxAlternativeArticle
            // 
            this.listBoxAlternativeArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlternativeArticle.FormattingEnabled = true;
            this.listBoxAlternativeArticle.Location = new System.Drawing.Point(6, 39);
            this.listBoxAlternativeArticle.Name = "listBoxAlternativeArticle";
            this.listBoxAlternativeArticle.Size = new System.Drawing.Size(218, 329);
            this.listBoxAlternativeArticle.TabIndex = 32;
            // 
            // groupBoxCrossSellingArticle
            // 
            this.groupBoxCrossSellingArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCrossSellingArticle.Controls.Add(this.checkBoxCrossSellingArticleAutoGenerate);
            this.groupBoxCrossSellingArticle.Controls.Add(this.buttonRemoveCrossSellingArticle);
            this.groupBoxCrossSellingArticle.Controls.Add(this.buttonAddCrossSellingArticle);
            this.groupBoxCrossSellingArticle.Controls.Add(this.listBoxCrossSellingArticle);
            this.groupBoxCrossSellingArticle.Location = new System.Drawing.Point(276, 82);
            this.groupBoxCrossSellingArticle.Name = "groupBoxCrossSellingArticle";
            this.groupBoxCrossSellingArticle.Size = new System.Drawing.Size(230, 427);
            this.groupBoxCrossSellingArticle.TabIndex = 6;
            this.groupBoxCrossSellingArticle.TabStop = false;
            this.groupBoxCrossSellingArticle.Text = "Cross Selling Articles";
            // 
            // checkBoxCrossSellingArticleAutoGenerate
            // 
            this.checkBoxCrossSellingArticleAutoGenerate.AutoSize = true;
            this.checkBoxCrossSellingArticleAutoGenerate.Checked = true;
            this.checkBoxCrossSellingArticleAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCrossSellingArticleAutoGenerate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCrossSellingArticleAutoGenerate.Name = "checkBoxCrossSellingArticleAutoGenerate";
            this.checkBoxCrossSellingArticleAutoGenerate.Size = new System.Drawing.Size(195, 17);
            this.checkBoxCrossSellingArticleAutoGenerate.TabIndex = 33;
            this.checkBoxCrossSellingArticleAutoGenerate.Text = "Auto Generate Cross Selling Articles";
            this.checkBoxCrossSellingArticleAutoGenerate.UseVisualStyleBackColor = true;
            this.checkBoxCrossSellingArticleAutoGenerate.Click += new System.EventHandler(this.checkBoxCrossSellingArticleAutoGenerate_Click);
            // 
            // buttonRemoveCrossSellingArticle
            // 
            this.buttonRemoveCrossSellingArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveCrossSellingArticle.Location = new System.Drawing.Point(149, 397);
            this.buttonRemoveCrossSellingArticle.Name = "buttonRemoveCrossSellingArticle";
            this.buttonRemoveCrossSellingArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCrossSellingArticle.TabIndex = 31;
            this.buttonRemoveCrossSellingArticle.Text = "Remove";
            this.buttonRemoveCrossSellingArticle.UseVisualStyleBackColor = true;
            this.buttonRemoveCrossSellingArticle.Click += new System.EventHandler(this.buttonRemoveCrossSellingArticle_Click);
            // 
            // buttonAddCrossSellingArticle
            // 
            this.buttonAddCrossSellingArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCrossSellingArticle.Location = new System.Drawing.Point(68, 397);
            this.buttonAddCrossSellingArticle.Name = "buttonAddCrossSellingArticle";
            this.buttonAddCrossSellingArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCrossSellingArticle.TabIndex = 30;
            this.buttonAddCrossSellingArticle.Text = "Add...";
            this.buttonAddCrossSellingArticle.UseVisualStyleBackColor = true;
            this.buttonAddCrossSellingArticle.Click += new System.EventHandler(this.buttonAddCrossSellingArticle_Click);
            // 
            // listBoxCrossSellingArticle
            // 
            this.listBoxCrossSellingArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCrossSellingArticle.FormattingEnabled = true;
            this.listBoxCrossSellingArticle.Location = new System.Drawing.Point(6, 39);
            this.listBoxCrossSellingArticle.Name = "listBoxCrossSellingArticle";
            this.listBoxCrossSellingArticle.Size = new System.Drawing.Size(218, 329);
            this.listBoxCrossSellingArticle.TabIndex = 29;
            // 
            // tabPagePriceInformation
            // 
            this.tabPagePriceInformation.Controls.Add(this.groupBoxPriceInformation);
            this.tabPagePriceInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPagePriceInformation.Name = "tabPagePriceInformation";
            this.tabPagePriceInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePriceInformation.Size = new System.Drawing.Size(980, 516);
            this.tabPagePriceInformation.TabIndex = 2;
            this.tabPagePriceInformation.Text = "Price Information";
            this.tabPagePriceInformation.UseVisualStyleBackColor = true;
            // 
            // groupBoxPriceInformation
            // 
            this.groupBoxPriceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPriceInformation.Controls.Add(this.checkBoxPriceInformationAutoGenerate);
            this.groupBoxPriceInformation.Controls.Add(this.buttonRemovePriceInformation);
            this.groupBoxPriceInformation.Controls.Add(this.buttonAddPriceInformation);
            this.groupBoxPriceInformation.Controls.Add(this.listBoxPriceInformation);
            this.groupBoxPriceInformation.Location = new System.Drawing.Point(4, 4);
            this.groupBoxPriceInformation.Name = "groupBoxPriceInformation";
            this.groupBoxPriceInformation.Size = new System.Drawing.Size(974, 505);
            this.groupBoxPriceInformation.TabIndex = 10;
            this.groupBoxPriceInformation.TabStop = false;
            this.groupBoxPriceInformation.Text = "Price Information";
            // 
            // checkBoxPriceInformationAutoGenerate
            // 
            this.checkBoxPriceInformationAutoGenerate.AutoSize = true;
            this.checkBoxPriceInformationAutoGenerate.Checked = true;
            this.checkBoxPriceInformationAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPriceInformationAutoGenerate.Location = new System.Drawing.Point(7, 19);
            this.checkBoxPriceInformationAutoGenerate.Name = "checkBoxPriceInformationAutoGenerate";
            this.checkBoxPriceInformationAutoGenerate.Size = new System.Drawing.Size(177, 17);
            this.checkBoxPriceInformationAutoGenerate.TabIndex = 33;
            this.checkBoxPriceInformationAutoGenerate.Text = "Auto Generate Price Information";
            this.checkBoxPriceInformationAutoGenerate.UseVisualStyleBackColor = true;
            this.checkBoxPriceInformationAutoGenerate.Click += new System.EventHandler(this.checkBoxPriceInformationAutoGenerate_Click);
            // 
            // buttonRemovePriceInformation
            // 
            this.buttonRemovePriceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemovePriceInformation.Location = new System.Drawing.Point(893, 475);
            this.buttonRemovePriceInformation.Name = "buttonRemovePriceInformation";
            this.buttonRemovePriceInformation.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePriceInformation.TabIndex = 31;
            this.buttonRemovePriceInformation.Text = "Remove";
            this.buttonRemovePriceInformation.UseVisualStyleBackColor = true;
            this.buttonRemovePriceInformation.Click += new System.EventHandler(this.buttonRemovePriceInformation_Click);
            // 
            // buttonAddPriceInformation
            // 
            this.buttonAddPriceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPriceInformation.Location = new System.Drawing.Point(812, 475);
            this.buttonAddPriceInformation.Name = "buttonAddPriceInformation";
            this.buttonAddPriceInformation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPriceInformation.TabIndex = 30;
            this.buttonAddPriceInformation.Text = "Add...";
            this.buttonAddPriceInformation.UseVisualStyleBackColor = true;
            this.buttonAddPriceInformation.Click += new System.EventHandler(this.buttonAddPriceInformation_Click);
            // 
            // listBoxPriceInformation
            // 
            this.listBoxPriceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPriceInformation.FormattingEnabled = true;
            this.listBoxPriceInformation.Location = new System.Drawing.Point(6, 39);
            this.listBoxPriceInformation.Name = "listBoxPriceInformation";
            this.listBoxPriceInformation.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPriceInformation.Size = new System.Drawing.Size(962, 407);
            this.listBoxPriceInformation.TabIndex = 29;
            // 
            // tabPageShoppingCartRequested
            // 
            this.tabPageShoppingCartRequested.Controls.Add(this.tabControlShoppingCart);
            this.tabPageShoppingCartRequested.Location = new System.Drawing.Point(4, 22);
            this.tabPageShoppingCartRequested.Name = "tabPageShoppingCartRequested";
            this.tabPageShoppingCartRequested.Size = new System.Drawing.Size(980, 516);
            this.tabPageShoppingCartRequested.TabIndex = 3;
            this.tabPageShoppingCartRequested.Text = "Shopping Cart";
            this.tabPageShoppingCartRequested.UseVisualStyleBackColor = true;
            // 
            // tabControlShoppingCart
            // 
            this.tabControlShoppingCart.Controls.Add(this.tabPageRequest);
            this.tabControlShoppingCart.Controls.Add(this.tabPageUpdate);
            this.tabControlShoppingCart.Location = new System.Drawing.Point(2, 3);
            this.tabControlShoppingCart.Name = "tabControlShoppingCart";
            this.tabControlShoppingCart.SelectedIndex = 0;
            this.tabControlShoppingCart.Size = new System.Drawing.Size(974, 501);
            this.tabControlShoppingCart.TabIndex = 16;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.groupBoxShoppingCartItemsForRequest);
            this.tabPageRequest.Controls.Add(this.groupBoxShoppingCartRequest);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(966, 475);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // groupBoxShoppingCartItemsForRequest
            // 
            this.groupBoxShoppingCartItemsForRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShoppingCartItemsForRequest.Controls.Add(this.buttonRemoveShoppingCartItem);
            this.groupBoxShoppingCartItemsForRequest.Controls.Add(this.buttonAddShoppingCartItem);
            this.groupBoxShoppingCartItemsForRequest.Controls.Add(this.listViewShoppingCartItemsForRequest);
            this.groupBoxShoppingCartItemsForRequest.Location = new System.Drawing.Point(245, 6);
            this.groupBoxShoppingCartItemsForRequest.Name = "groupBoxShoppingCartItemsForRequest";
            this.groupBoxShoppingCartItemsForRequest.Size = new System.Drawing.Size(715, 462);
            this.groupBoxShoppingCartItemsForRequest.TabIndex = 18;
            this.groupBoxShoppingCartItemsForRequest.TabStop = false;
            this.groupBoxShoppingCartItemsForRequest.Text = "Shopping Cart Items";
            // 
            // buttonRemoveShoppingCartItem
            // 
            this.buttonRemoveShoppingCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveShoppingCartItem.Location = new System.Drawing.Point(634, 432);
            this.buttonRemoveShoppingCartItem.Name = "buttonRemoveShoppingCartItem";
            this.buttonRemoveShoppingCartItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveShoppingCartItem.TabIndex = 22;
            this.buttonRemoveShoppingCartItem.Text = "Remove";
            this.buttonRemoveShoppingCartItem.UseVisualStyleBackColor = true;
            this.buttonRemoveShoppingCartItem.Click += new System.EventHandler(this.buttonRemoveShoppingCartItem_Click);
            // 
            // buttonAddShoppingCartItem
            // 
            this.buttonAddShoppingCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddShoppingCartItem.Location = new System.Drawing.Point(553, 432);
            this.buttonAddShoppingCartItem.Name = "buttonAddShoppingCartItem";
            this.buttonAddShoppingCartItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddShoppingCartItem.TabIndex = 21;
            this.buttonAddShoppingCartItem.Text = "Add...";
            this.buttonAddShoppingCartItem.UseVisualStyleBackColor = true;
            this.buttonAddShoppingCartItem.Click += new System.EventHandler(this.buttonAddShoppingCartItem_Click);
            // 
            // listViewShoppingCartItemsForRequest
            // 
            this.listViewShoppingCartItemsForRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewShoppingCartItemsForRequest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewShoppingCartItemsForRequest.FullRowSelect = true;
            this.listViewShoppingCartItemsForRequest.HideSelection = false;
            this.listViewShoppingCartItemsForRequest.Location = new System.Drawing.Point(3, 16);
            this.listViewShoppingCartItemsForRequest.Name = "listViewShoppingCartItemsForRequest";
            this.listViewShoppingCartItemsForRequest.Size = new System.Drawing.Size(706, 410);
            this.listViewShoppingCartItemsForRequest.TabIndex = 0;
            this.listViewShoppingCartItemsForRequest.UseCompatibleStateImageBehavior = false;
            this.listViewShoppingCartItemsForRequest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Article Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Currency";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "DispensedQuantity";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "OrderedQuantity";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "PaidQuantity";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Price";
            // 
            // groupBoxShoppingCartRequest
            // 
            this.groupBoxShoppingCartRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShoppingCartRequest.Controls.Add(this.label1);
            this.groupBoxShoppingCartRequest.Controls.Add(this.textBoxShoppingCartCustomerID);
            this.groupBoxShoppingCartRequest.Controls.Add(this.textBox1);
            this.groupBoxShoppingCartRequest.Controls.Add(this.textBoxShoppingCartSalesPersonId);
            this.groupBoxShoppingCartRequest.Controls.Add(this.radioButtonShoppingCartReject);
            this.groupBoxShoppingCartRequest.Controls.Add(this.textBoxShoppingCartSalesPointID);
            this.groupBoxShoppingCartRequest.Controls.Add(this.radioButtonShoppingCartAccept);
            this.groupBoxShoppingCartRequest.Controls.Add(this.textBoxShoppingCartViewPointID);
            this.groupBoxShoppingCartRequest.Controls.Add(this.labelViewPointId);
            this.groupBoxShoppingCartRequest.Controls.Add(this.comboBoxShoppingCartStatus);
            this.groupBoxShoppingCartRequest.Controls.Add(this.labelSalesPointId);
            this.groupBoxShoppingCartRequest.Controls.Add(this.labelCustomerId);
            this.groupBoxShoppingCartRequest.Controls.Add(this.labelSalesPersonId);
            this.groupBoxShoppingCartRequest.Controls.Add(this.labelStatus);
            this.groupBoxShoppingCartRequest.Location = new System.Drawing.Point(6, 6);
            this.groupBoxShoppingCartRequest.Name = "groupBoxShoppingCartRequest";
            this.groupBoxShoppingCartRequest.Size = new System.Drawing.Size(233, 462);
            this.groupBoxShoppingCartRequest.TabIndex = 17;
            this.groupBoxShoppingCartRequest.TabStop = false;
            this.groupBoxShoppingCartRequest.Text = "Shopping Cart Request";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reject Description :";
            // 
            // textBoxShoppingCartCustomerID
            // 
            this.textBoxShoppingCartCustomerID.Location = new System.Drawing.Point(118, 46);
            this.textBoxShoppingCartCustomerID.Name = "textBoxShoppingCartCustomerID";
            this.textBoxShoppingCartCustomerID.Size = new System.Drawing.Size(109, 20);
            this.textBoxShoppingCartCustomerID.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBoxShoppingCartSalesPersonId
            // 
            this.textBoxShoppingCartSalesPersonId.Location = new System.Drawing.Point(118, 72);
            this.textBoxShoppingCartSalesPersonId.Name = "textBoxShoppingCartSalesPersonId";
            this.textBoxShoppingCartSalesPersonId.Size = new System.Drawing.Size(109, 20);
            this.textBoxShoppingCartSalesPersonId.TabIndex = 2;
            // 
            // radioButtonShoppingCartReject
            // 
            this.radioButtonShoppingCartReject.AutoSize = true;
            this.radioButtonShoppingCartReject.Location = new System.Drawing.Point(15, 173);
            this.radioButtonShoppingCartReject.Name = "radioButtonShoppingCartReject";
            this.radioButtonShoppingCartReject.Size = new System.Drawing.Size(56, 17);
            this.radioButtonShoppingCartReject.TabIndex = 13;
            this.radioButtonShoppingCartReject.Text = "Reject";
            this.radioButtonShoppingCartReject.UseVisualStyleBackColor = true;
            // 
            // textBoxShoppingCartSalesPointID
            // 
            this.textBoxShoppingCartSalesPointID.Location = new System.Drawing.Point(112, 98);
            this.textBoxShoppingCartSalesPointID.Name = "textBoxShoppingCartSalesPointID";
            this.textBoxShoppingCartSalesPointID.Size = new System.Drawing.Size(115, 20);
            this.textBoxShoppingCartSalesPointID.TabIndex = 3;
            // 
            // radioButtonShoppingCartAccept
            // 
            this.radioButtonShoppingCartAccept.AutoSize = true;
            this.radioButtonShoppingCartAccept.Checked = true;
            this.radioButtonShoppingCartAccept.Location = new System.Drawing.Point(15, 150);
            this.radioButtonShoppingCartAccept.Name = "radioButtonShoppingCartAccept";
            this.radioButtonShoppingCartAccept.Size = new System.Drawing.Size(59, 17);
            this.radioButtonShoppingCartAccept.TabIndex = 12;
            this.radioButtonShoppingCartAccept.TabStop = true;
            this.radioButtonShoppingCartAccept.Text = "Accept";
            this.radioButtonShoppingCartAccept.UseVisualStyleBackColor = true;
            // 
            // textBoxShoppingCartViewPointID
            // 
            this.textBoxShoppingCartViewPointID.Location = new System.Drawing.Point(112, 124);
            this.textBoxShoppingCartViewPointID.Name = "textBoxShoppingCartViewPointID";
            this.textBoxShoppingCartViewPointID.Size = new System.Drawing.Size(115, 20);
            this.textBoxShoppingCartViewPointID.TabIndex = 4;
            // 
            // labelViewPointId
            // 
            this.labelViewPointId.AutoSize = true;
            this.labelViewPointId.Location = new System.Drawing.Point(6, 127);
            this.labelViewPointId.Name = "labelViewPointId";
            this.labelViewPointId.Size = new System.Drawing.Size(75, 13);
            this.labelViewPointId.TabIndex = 11;
            this.labelViewPointId.Text = "View Point Id :";
            // 
            // comboBoxShoppingCartStatus
            // 
            this.comboBoxShoppingCartStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShoppingCartStatus.FormattingEnabled = true;
            this.comboBoxShoppingCartStatus.Location = new System.Drawing.Point(118, 19);
            this.comboBoxShoppingCartStatus.Name = "comboBoxShoppingCartStatus";
            this.comboBoxShoppingCartStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxShoppingCartStatus.TabIndex = 5;
            // 
            // labelSalesPointId
            // 
            this.labelSalesPointId.AutoSize = true;
            this.labelSalesPointId.Location = new System.Drawing.Point(6, 101);
            this.labelSalesPointId.Name = "labelSalesPointId";
            this.labelSalesPointId.Size = new System.Drawing.Size(78, 13);
            this.labelSalesPointId.TabIndex = 10;
            this.labelSalesPointId.Text = "Sales Point Id :";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(6, 49);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(69, 13);
            this.labelCustomerId.TabIndex = 7;
            this.labelCustomerId.Text = "Customer Id :";
            // 
            // labelSalesPersonId
            // 
            this.labelSalesPersonId.AutoSize = true;
            this.labelSalesPersonId.Location = new System.Drawing.Point(6, 75);
            this.labelSalesPersonId.Name = "labelSalesPersonId";
            this.labelSalesPersonId.Size = new System.Drawing.Size(87, 13);
            this.labelSalesPersonId.TabIndex = 9;
            this.labelSalesPersonId.Text = "Sales Person Id :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 22);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status :";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.groupBoxShoppingCartItemsForUpdate);
            this.tabPageUpdate.Controls.Add(this.groupBoxShoppingCartUpdateHandling);
            this.tabPageUpdate.Controls.Add(this.groupBoxShoppingCartInfo);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(966, 475);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBoxShoppingCartItemsForUpdate
            // 
            this.groupBoxShoppingCartItemsForUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShoppingCartItemsForUpdate.Controls.Add(this.listViewShoppingCartItemsForUpdate);
            this.groupBoxShoppingCartItemsForUpdate.Location = new System.Drawing.Point(245, 6);
            this.groupBoxShoppingCartItemsForUpdate.Name = "groupBoxShoppingCartItemsForUpdate";
            this.groupBoxShoppingCartItemsForUpdate.Size = new System.Drawing.Size(715, 462);
            this.groupBoxShoppingCartItemsForUpdate.TabIndex = 12;
            this.groupBoxShoppingCartItemsForUpdate.TabStop = false;
            this.groupBoxShoppingCartItemsForUpdate.Text = "Shopping Cart Items";
            // 
            // listViewShoppingCartItemsForUpdate
            // 
            this.listViewShoppingCartItemsForUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewShoppingCartItemsForUpdate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewShoppingCartItemsForUpdate.FullRowSelect = true;
            this.listViewShoppingCartItemsForUpdate.HideSelection = false;
            this.listViewShoppingCartItemsForUpdate.Location = new System.Drawing.Point(0, 19);
            this.listViewShoppingCartItemsForUpdate.Name = "listViewShoppingCartItemsForUpdate";
            this.listViewShoppingCartItemsForUpdate.Size = new System.Drawing.Size(706, 436);
            this.listViewShoppingCartItemsForUpdate.TabIndex = 0;
            this.listViewShoppingCartItemsForUpdate.UseCompatibleStateImageBehavior = false;
            this.listViewShoppingCartItemsForUpdate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Article Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Currency";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DispensedQuantity";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OrderedQuantity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PaidQuantity";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // groupBoxShoppingCartUpdateHandling
            // 
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.radioButtonShoppingCartUpdateAutoManual);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.radioButtonShoppingCartUpdateAutoReject);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.radioButtonShoppingCartUpdateAutoAccept);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.labelShoppingCartUpdateHandlingDescription);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.textBoxShoppingCartUpdateHandlingDescription);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.buttonShoppingCartUpdateAutoReject);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.buttonShoppingCartUpdateAutoAccept);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.labelShoppingCartUpdateHandlingAuto);
            this.groupBoxShoppingCartUpdateHandling.Controls.Add(this.labelShoppingCartUpdateHandlingManuel);
            this.groupBoxShoppingCartUpdateHandling.Location = new System.Drawing.Point(6, 196);
            this.groupBoxShoppingCartUpdateHandling.Name = "groupBoxShoppingCartUpdateHandling";
            this.groupBoxShoppingCartUpdateHandling.Size = new System.Drawing.Size(233, 156);
            this.groupBoxShoppingCartUpdateHandling.TabIndex = 13;
            this.groupBoxShoppingCartUpdateHandling.TabStop = false;
            this.groupBoxShoppingCartUpdateHandling.Text = "Shopping Cart Handling";
            // 
            // radioButtonShoppingCartUpdateAutoManual
            // 
            this.radioButtonShoppingCartUpdateAutoManual.AutoSize = true;
            this.radioButtonShoppingCartUpdateAutoManual.Location = new System.Drawing.Point(44, 69);
            this.radioButtonShoppingCartUpdateAutoManual.Name = "radioButtonShoppingCartUpdateAutoManual";
            this.radioButtonShoppingCartUpdateAutoManual.Size = new System.Drawing.Size(60, 17);
            this.radioButtonShoppingCartUpdateAutoManual.TabIndex = 26;
            this.radioButtonShoppingCartUpdateAutoManual.Text = "Manual";
            this.radioButtonShoppingCartUpdateAutoManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonShoppingCartUpdateAutoReject
            // 
            this.radioButtonShoppingCartUpdateAutoReject.AutoSize = true;
            this.radioButtonShoppingCartUpdateAutoReject.Location = new System.Drawing.Point(44, 46);
            this.radioButtonShoppingCartUpdateAutoReject.Name = "radioButtonShoppingCartUpdateAutoReject";
            this.radioButtonShoppingCartUpdateAutoReject.Size = new System.Drawing.Size(56, 17);
            this.radioButtonShoppingCartUpdateAutoReject.TabIndex = 25;
            this.radioButtonShoppingCartUpdateAutoReject.Text = "Reject";
            this.radioButtonShoppingCartUpdateAutoReject.UseVisualStyleBackColor = true;
            // 
            // radioButtonShoppingCartUpdateAutoAccept
            // 
            this.radioButtonShoppingCartUpdateAutoAccept.AutoSize = true;
            this.radioButtonShoppingCartUpdateAutoAccept.Checked = true;
            this.radioButtonShoppingCartUpdateAutoAccept.Location = new System.Drawing.Point(44, 23);
            this.radioButtonShoppingCartUpdateAutoAccept.Name = "radioButtonShoppingCartUpdateAutoAccept";
            this.radioButtonShoppingCartUpdateAutoAccept.Size = new System.Drawing.Size(59, 17);
            this.radioButtonShoppingCartUpdateAutoAccept.TabIndex = 24;
            this.radioButtonShoppingCartUpdateAutoAccept.TabStop = true;
            this.radioButtonShoppingCartUpdateAutoAccept.Text = "Accept";
            this.radioButtonShoppingCartUpdateAutoAccept.UseVisualStyleBackColor = true;
            // 
            // labelShoppingCartUpdateHandlingDescription
            // 
            this.labelShoppingCartUpdateHandlingDescription.AutoSize = true;
            this.labelShoppingCartUpdateHandlingDescription.Location = new System.Drawing.Point(4, 129);
            this.labelShoppingCartUpdateHandlingDescription.Name = "labelShoppingCartUpdateHandlingDescription";
            this.labelShoppingCartUpdateHandlingDescription.Size = new System.Drawing.Size(66, 13);
            this.labelShoppingCartUpdateHandlingDescription.TabIndex = 23;
            this.labelShoppingCartUpdateHandlingDescription.Text = "Description :";
            // 
            // textBoxShoppingCartUpdateHandlingDescription
            // 
            this.textBoxShoppingCartUpdateHandlingDescription.Location = new System.Drawing.Point(99, 126);
            this.textBoxShoppingCartUpdateHandlingDescription.Name = "textBoxShoppingCartUpdateHandlingDescription";
            this.textBoxShoppingCartUpdateHandlingDescription.Size = new System.Drawing.Size(115, 20);
            this.textBoxShoppingCartUpdateHandlingDescription.TabIndex = 22;
            // 
            // buttonShoppingCartUpdateAutoReject
            // 
            this.buttonShoppingCartUpdateAutoReject.Enabled = false;
            this.buttonShoppingCartUpdateAutoReject.Location = new System.Drawing.Point(139, 92);
            this.buttonShoppingCartUpdateAutoReject.Name = "buttonShoppingCartUpdateAutoReject";
            this.buttonShoppingCartUpdateAutoReject.Size = new System.Drawing.Size(75, 23);
            this.buttonShoppingCartUpdateAutoReject.TabIndex = 19;
            this.buttonShoppingCartUpdateAutoReject.Text = "Reject";
            this.buttonShoppingCartUpdateAutoReject.UseVisualStyleBackColor = true;
            this.buttonShoppingCartUpdateAutoReject.Click += new System.EventHandler(this.buttonShoppingCartUpdateAutoReject_Click);
            // 
            // buttonShoppingCartUpdateAutoAccept
            // 
            this.buttonShoppingCartUpdateAutoAccept.Enabled = false;
            this.buttonShoppingCartUpdateAutoAccept.Location = new System.Drawing.Point(58, 92);
            this.buttonShoppingCartUpdateAutoAccept.Name = "buttonShoppingCartUpdateAutoAccept";
            this.buttonShoppingCartUpdateAutoAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonShoppingCartUpdateAutoAccept.TabIndex = 18;
            this.buttonShoppingCartUpdateAutoAccept.Text = "Accept";
            this.buttonShoppingCartUpdateAutoAccept.UseVisualStyleBackColor = true;
            this.buttonShoppingCartUpdateAutoAccept.Click += new System.EventHandler(this.buttonShoppingCartUpdateAutoAccept_Click);
            // 
            // labelShoppingCartUpdateHandlingAuto
            // 
            this.labelShoppingCartUpdateHandlingAuto.AutoSize = true;
            this.labelShoppingCartUpdateHandlingAuto.Location = new System.Drawing.Point(6, 25);
            this.labelShoppingCartUpdateHandlingAuto.Name = "labelShoppingCartUpdateHandlingAuto";
            this.labelShoppingCartUpdateHandlingAuto.Size = new System.Drawing.Size(32, 13);
            this.labelShoppingCartUpdateHandlingAuto.TabIndex = 17;
            this.labelShoppingCartUpdateHandlingAuto.Text = "Auto:";
            // 
            // labelShoppingCartUpdateHandlingManuel
            // 
            this.labelShoppingCartUpdateHandlingManuel.AutoSize = true;
            this.labelShoppingCartUpdateHandlingManuel.Location = new System.Drawing.Point(6, 97);
            this.labelShoppingCartUpdateHandlingManuel.Name = "labelShoppingCartUpdateHandlingManuel";
            this.labelShoppingCartUpdateHandlingManuel.Size = new System.Drawing.Size(45, 13);
            this.labelShoppingCartUpdateHandlingManuel.TabIndex = 16;
            this.labelShoppingCartUpdateHandlingManuel.Text = "Manuel:";
            // 
            // groupBoxShoppingCartInfo
            // 
            this.groupBoxShoppingCartInfo.Controls.Add(this.textBoxShoppingCartInfoID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.textBoxShoppingCartInfoCustomerID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.textBoxShoppingCartInfoSalesPersonID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.textBoxShoppingCartInfoSalesPointID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.textBoxShoppingCartInfoViewPointID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.comboBoxShoppingCartInfoStatus);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoViewPointID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoSalesPointID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoCustomerID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoSalesPersonID);
            this.groupBoxShoppingCartInfo.Controls.Add(this.labelShoppingCartInfoStatus);
            this.groupBoxShoppingCartInfo.Location = new System.Drawing.Point(6, 6);
            this.groupBoxShoppingCartInfo.Name = "groupBoxShoppingCartInfo";
            this.groupBoxShoppingCartInfo.Size = new System.Drawing.Size(233, 184);
            this.groupBoxShoppingCartInfo.TabIndex = 11;
            this.groupBoxShoppingCartInfo.TabStop = false;
            this.groupBoxShoppingCartInfo.Text = "Shopping Cart Information";
            // 
            // textBoxShoppingCartInfoID
            // 
            this.textBoxShoppingCartInfoID.Enabled = false;
            this.textBoxShoppingCartInfoID.Location = new System.Drawing.Point(98, 20);
            this.textBoxShoppingCartInfoID.Name = "textBoxShoppingCartInfoID";
            this.textBoxShoppingCartInfoID.Size = new System.Drawing.Size(121, 20);
            this.textBoxShoppingCartInfoID.TabIndex = 18;
            // 
            // textBoxShoppingCartInfoCustomerID
            // 
            this.textBoxShoppingCartInfoCustomerID.Enabled = false;
            this.textBoxShoppingCartInfoCustomerID.Location = new System.Drawing.Point(98, 73);
            this.textBoxShoppingCartInfoCustomerID.Name = "textBoxShoppingCartInfoCustomerID";
            this.textBoxShoppingCartInfoCustomerID.Size = new System.Drawing.Size(121, 20);
            this.textBoxShoppingCartInfoCustomerID.TabIndex = 19;
            // 
            // textBoxShoppingCartInfoSalesPersonID
            // 
            this.textBoxShoppingCartInfoSalesPersonID.Enabled = false;
            this.textBoxShoppingCartInfoSalesPersonID.Location = new System.Drawing.Point(98, 99);
            this.textBoxShoppingCartInfoSalesPersonID.Name = "textBoxShoppingCartInfoSalesPersonID";
            this.textBoxShoppingCartInfoSalesPersonID.Size = new System.Drawing.Size(121, 20);
            this.textBoxShoppingCartInfoSalesPersonID.TabIndex = 20;
            // 
            // textBoxShoppingCartInfoSalesPointID
            // 
            this.textBoxShoppingCartInfoSalesPointID.Enabled = false;
            this.textBoxShoppingCartInfoSalesPointID.Location = new System.Drawing.Point(98, 125);
            this.textBoxShoppingCartInfoSalesPointID.Name = "textBoxShoppingCartInfoSalesPointID";
            this.textBoxShoppingCartInfoSalesPointID.Size = new System.Drawing.Size(121, 20);
            this.textBoxShoppingCartInfoSalesPointID.TabIndex = 21;
            // 
            // textBoxShoppingCartInfoViewPointID
            // 
            this.textBoxShoppingCartInfoViewPointID.Enabled = false;
            this.textBoxShoppingCartInfoViewPointID.Location = new System.Drawing.Point(98, 151);
            this.textBoxShoppingCartInfoViewPointID.Name = "textBoxShoppingCartInfoViewPointID";
            this.textBoxShoppingCartInfoViewPointID.Size = new System.Drawing.Size(121, 20);
            this.textBoxShoppingCartInfoViewPointID.TabIndex = 22;
            // 
            // comboBoxShoppingCartInfoStatus
            // 
            this.comboBoxShoppingCartInfoStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShoppingCartInfoStatus.Enabled = false;
            this.comboBoxShoppingCartInfoStatus.FormattingEnabled = true;
            this.comboBoxShoppingCartInfoStatus.Location = new System.Drawing.Point(98, 46);
            this.comboBoxShoppingCartInfoStatus.Name = "comboBoxShoppingCartInfoStatus";
            this.comboBoxShoppingCartInfoStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShoppingCartInfoStatus.TabIndex = 23;
            // 
            // labelShoppingCartInfoID
            // 
            this.labelShoppingCartInfoID.AutoSize = true;
            this.labelShoppingCartInfoID.Location = new System.Drawing.Point(6, 23);
            this.labelShoppingCartInfoID.Name = "labelShoppingCartInfoID";
            this.labelShoppingCartInfoID.Size = new System.Drawing.Size(24, 13);
            this.labelShoppingCartInfoID.TabIndex = 12;
            this.labelShoppingCartInfoID.Text = "ID :";
            // 
            // labelShoppingCartInfoViewPointID
            // 
            this.labelShoppingCartInfoViewPointID.AutoSize = true;
            this.labelShoppingCartInfoViewPointID.Location = new System.Drawing.Point(6, 154);
            this.labelShoppingCartInfoViewPointID.Name = "labelShoppingCartInfoViewPointID";
            this.labelShoppingCartInfoViewPointID.Size = new System.Drawing.Size(75, 13);
            this.labelShoppingCartInfoViewPointID.TabIndex = 17;
            this.labelShoppingCartInfoViewPointID.Text = "View Point Id :";
            // 
            // labelShoppingCartInfoSalesPointID
            // 
            this.labelShoppingCartInfoSalesPointID.AutoSize = true;
            this.labelShoppingCartInfoSalesPointID.Location = new System.Drawing.Point(6, 128);
            this.labelShoppingCartInfoSalesPointID.Name = "labelShoppingCartInfoSalesPointID";
            this.labelShoppingCartInfoSalesPointID.Size = new System.Drawing.Size(78, 13);
            this.labelShoppingCartInfoSalesPointID.TabIndex = 16;
            this.labelShoppingCartInfoSalesPointID.Text = "Sales Point Id :";
            // 
            // labelShoppingCartInfoCustomerID
            // 
            this.labelShoppingCartInfoCustomerID.AutoSize = true;
            this.labelShoppingCartInfoCustomerID.Location = new System.Drawing.Point(6, 76);
            this.labelShoppingCartInfoCustomerID.Name = "labelShoppingCartInfoCustomerID";
            this.labelShoppingCartInfoCustomerID.Size = new System.Drawing.Size(69, 13);
            this.labelShoppingCartInfoCustomerID.TabIndex = 13;
            this.labelShoppingCartInfoCustomerID.Text = "Customer Id :";
            // 
            // labelShoppingCartInfoSalesPersonID
            // 
            this.labelShoppingCartInfoSalesPersonID.AutoSize = true;
            this.labelShoppingCartInfoSalesPersonID.Location = new System.Drawing.Point(5, 102);
            this.labelShoppingCartInfoSalesPersonID.Name = "labelShoppingCartInfoSalesPersonID";
            this.labelShoppingCartInfoSalesPersonID.Size = new System.Drawing.Size(87, 13);
            this.labelShoppingCartInfoSalesPersonID.TabIndex = 15;
            this.labelShoppingCartInfoSalesPersonID.Text = "Sales Person Id :";
            // 
            // labelShoppingCartInfoStatus
            // 
            this.labelShoppingCartInfoStatus.AutoSize = true;
            this.labelShoppingCartInfoStatus.Location = new System.Drawing.Point(6, 49);
            this.labelShoppingCartInfoStatus.Name = "labelShoppingCartInfoStatus";
            this.labelShoppingCartInfoStatus.Size = new System.Drawing.Size(43, 13);
            this.labelShoppingCartInfoStatus.TabIndex = 14;
            this.labelShoppingCartInfoStatus.Text = "Status :";
            // 
            // tabRawXmlDigitalShelf
            // 
            this.tabRawXmlDigitalShelf.Controls.Add(this.groupRawXmlDigitalShelf);
            this.tabRawXmlDigitalShelf.Location = new System.Drawing.Point(4, 22);
            this.tabRawXmlDigitalShelf.Name = "tabRawXmlDigitalShelf";
            this.tabRawXmlDigitalShelf.Size = new System.Drawing.Size(980, 516);
            this.tabRawXmlDigitalShelf.TabIndex = 4;
            this.tabRawXmlDigitalShelf.Text = "Raw XML";
            this.tabRawXmlDigitalShelf.UseVisualStyleBackColor = true;
            // 
            // groupRawXmlDigitalShelf
            // 
            this.groupRawXmlDigitalShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRawXmlDigitalShelf.Controls.Add(this.btnClearRawXmlDigitalShelf);
            this.groupRawXmlDigitalShelf.Controls.Add(this.btnSendRawXmlDigitalShelf);
            this.groupRawXmlDigitalShelf.Controls.Add(this.txtRawXmlDigitalShelf);
            this.groupRawXmlDigitalShelf.Location = new System.Drawing.Point(4, 3);
            this.groupRawXmlDigitalShelf.Name = "groupRawXmlDigitalShelf";
            this.groupRawXmlDigitalShelf.Size = new System.Drawing.Size(975, 510);
            this.groupRawXmlDigitalShelf.TabIndex = 0;
            this.groupRawXmlDigitalShelf.TabStop = false;
            this.groupRawXmlDigitalShelf.Text = "Raw XML";
            // 
            // btnClearRawXmlDigitalShelf
            // 
            this.btnClearRawXmlDigitalShelf.Location = new System.Drawing.Point(435, 296);
            this.btnClearRawXmlDigitalShelf.Name = "btnClearRawXmlDigitalShelf";
            this.btnClearRawXmlDigitalShelf.Size = new System.Drawing.Size(75, 23);
            this.btnClearRawXmlDigitalShelf.TabIndex = 6;
            this.btnClearRawXmlDigitalShelf.Text = "Clear";
            this.btnClearRawXmlDigitalShelf.UseVisualStyleBackColor = true;
            this.btnClearRawXmlDigitalShelf.Click += new System.EventHandler(this.btnClearRawXmlDigitalShelf_Click);
            // 
            // btnSendRawXmlDigitalShelf
            // 
            this.btnSendRawXmlDigitalShelf.Enabled = false;
            this.btnSendRawXmlDigitalShelf.Location = new System.Drawing.Point(516, 296);
            this.btnSendRawXmlDigitalShelf.Name = "btnSendRawXmlDigitalShelf";
            this.btnSendRawXmlDigitalShelf.Size = new System.Drawing.Size(75, 23);
            this.btnSendRawXmlDigitalShelf.TabIndex = 5;
            this.btnSendRawXmlDigitalShelf.Text = "Send";
            this.btnSendRawXmlDigitalShelf.UseVisualStyleBackColor = true;
            this.btnSendRawXmlDigitalShelf.Click += new System.EventHandler(this.btnSendRawXmlDigitalShelf_Click);
            // 
            // txtRawXmlDigitalShelf
            // 
            this.txtRawXmlDigitalShelf.AutoWordSelection = true;
            this.txtRawXmlDigitalShelf.Location = new System.Drawing.Point(8, 32);
            this.txtRawXmlDigitalShelf.Name = "txtRawXmlDigitalShelf";
            this.txtRawXmlDigitalShelf.Size = new System.Drawing.Size(583, 258);
            this.txtRawXmlDigitalShelf.TabIndex = 4;
            this.txtRawXmlDigitalShelf.Text = "";
            // 
            // bgConnect
            // 
            this.bgConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgConnect_DoWork);
            this.bgConnect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgConnect_RunWorkerCompleted);
            // 
            // bgStock
            // 
            this.bgStock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgStock_DoWork);
            this.bgStock.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgStock_RunWorkerCompleted);
            // 
            // btnImportFromSelect
            // 
            this.btnImportFromSelect.Location = new System.Drawing.Point(15, 492);
            this.btnImportFromSelect.Name = "btnImportFromSelect";
            this.btnImportFromSelect.Size = new System.Drawing.Size(110, 23);
            this.btnImportFromSelect.TabIndex = 11;
            this.btnImportFromSelect.Text = "Import From Select";
            this.btnImportFromSelect.UseVisualStyleBackColor = true;
            this.btnImportFromSelect.Click += new System.EventHandler(this.btnImportFromSelect_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 662);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = "IT-System Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupConnection.ResumeLayout(false);
            this.groupConnection.PerformLayout();
            this.tabControlStorageSystem.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            this.splitArticles.Panel1.ResumeLayout(false);
            this.splitArticles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitArticles)).EndInit();
            this.splitArticles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacks)).EndInit();
            this.tabInput.ResumeLayout(false);
            this.groupInputLog.ResumeLayout(false);
            this.groupInputOptions.ResumeLayout(false);
            this.groupInputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiryDateMonth)).EndInit();
            this.tabInitiateInput.ResumeLayout(false);
            this.groupInitInputActivities.ResumeLayout(false);
            this.groupInitInputActivities.PerformLayout();
            this.groupInitiatedInputOptions.ResumeLayout(false);
            this.groupInitiatedInputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackSubItemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitInputID)).EndInit();
            this.tabOutput.ResumeLayout(false);
            this.groupOrderBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderBoxes)).EndInit();
            this.groupOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.groupDispensedPacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDispensedPacks)).EndInit();
            this.groupOrderLabels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemLabels)).EndInit();
            this.groupOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItems)).EndInit();
            this.tabMasterArticles.ResumeLayout(false);
            this.groupBoxMasterArticles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasterArticles)).EndInit();
            this.tabStockDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeliveryItems)).EndInit();
            this.tabTaskInfo.ResumeLayout(false);
            this.groupTask.ResumeLayout(false);
            this.groupTask.PerformLayout();
            this.groupPacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPackInfo)).EndInit();
            this.groupArticles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticleInfo)).EndInit();
            this.tabStatus.ResumeLayout(false);
            this.groupComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComponents)).EndInit();
            this.tabLocations.ResumeLayout(false);
            this.groupStockLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockLocations)).EndInit();
            this.tabRawXml.ResumeLayout(false);
            this.groupRawXml.ResumeLayout(false);
            this.groupBoxDigitalShelf.ResumeLayout(false);
            this.groupBoxDigitalShelf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigitalShelfPort)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStorageSystem.ResumeLayout(false);
            this.tabPageDigitalShelf.ResumeLayout(false);
            this.tabControlDigitalShelf.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageArticleInfo.ResumeLayout(false);
            this.groupBoxArticleInformation.ResumeLayout(false);
            this.groupBoxArticleInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSubItemQuantity)).EndInit();
            this.groupBoxTag.ResumeLayout(false);
            this.groupBoxTag.PerformLayout();
            this.groupBoxAlternativePackSizeArticle.ResumeLayout(false);
            this.groupBoxAlternativePackSizeArticle.PerformLayout();
            this.groupBoxAlternativeArticle.ResumeLayout(false);
            this.groupBoxAlternativeArticle.PerformLayout();
            this.groupBoxCrossSellingArticle.ResumeLayout(false);
            this.groupBoxCrossSellingArticle.PerformLayout();
            this.tabPagePriceInformation.ResumeLayout(false);
            this.groupBoxPriceInformation.ResumeLayout(false);
            this.groupBoxPriceInformation.PerformLayout();
            this.tabPageShoppingCartRequested.ResumeLayout(false);
            this.tabControlShoppingCart.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.groupBoxShoppingCartItemsForRequest.ResumeLayout(false);
            this.groupBoxShoppingCartRequest.ResumeLayout(false);
            this.groupBoxShoppingCartRequest.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.groupBoxShoppingCartItemsForUpdate.ResumeLayout(false);
            this.groupBoxShoppingCartUpdateHandling.ResumeLayout(false);
            this.groupBoxShoppingCartUpdateHandling.PerformLayout();
            this.groupBoxShoppingCartInfo.ResumeLayout(false);
            this.groupBoxShoppingCartInfo.PerformLayout();
            this.tabRawXmlDigitalShelf.ResumeLayout(false);
            this.groupRawXmlDigitalShelf.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupConnection;
        private System.Windows.Forms.TabControl tabControlStorageSystem;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.TabPage tabMasterArticles;
        private System.Windows.Forms.TabPage tabStockDeliveries;
        private System.Windows.Forms.SplitContainer splitArticles;
        private System.Windows.Forms.TextBox txtArticleFilter;
        private System.Windows.Forms.DataGridView dataGridArticles;
        private System.Windows.Forms.DataGridView dataGridPacks;
        private System.Windows.Forms.GroupBox groupInputLog;
        private System.Windows.Forms.Button btnClearInputLog;
        private System.Windows.Forms.ListBox listInputLog;
        private System.Windows.Forms.GroupBox groupInputOptions;
        private System.Windows.Forms.CheckBox checkEnforcePickingIndicator;
        private System.Windows.Forms.CheckBox checkOnlyFridgeInput;
        private System.Windows.Forms.CheckBox checkAllowStockReturnInput;
        private System.Windows.Forms.CheckBox checkEnforceExpiryDateDelivery;
        private System.Windows.Forms.CheckBox checkEnforceExpiryDateStockReturn;
        private System.Windows.Forms.CheckBox checkEnforceBatchDelivery;
        private System.Windows.Forms.CheckBox checkEnforceBatchStockReturn;
        private System.Windows.Forms.CheckBox checkAllowDeliveryInput;
        private System.Windows.Forms.Button btnReloadStock;
        private System.Windows.Forms.Button btnSendMasterArticles;
        private System.Windows.Forms.Button btnSendStockDeliveries;
        private System.Windows.Forms.ToolStripStatusLabel lblStorageSystemStatus;     
        private System.Windows.Forms.GroupBox groupOrderLabels;
        private System.Windows.Forms.GroupBox groupOrderItems;
        private System.Windows.Forms.GroupBox groupDispensedPacks;
        private System.Windows.Forms.DataGridView dataGridDispensedPacks;
        private System.Windows.Forms.DataGridView dataGridItemLabels;
        private System.Windows.Forms.DataGridView dataGridOrderItems;
        private System.Windows.Forms.GroupBox groupOrders;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btnClearOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.DataGridView dataGridDeliveryItems;
        private System.Windows.Forms.TabPage tabInitiateInput;
        private System.Windows.Forms.GroupBox groupInitiatedInputOptions;
        private System.Windows.Forms.Label lblDeliveryNumber;
        private System.Windows.Forms.NumericUpDown numInitInputID;
        private System.Windows.Forms.TextBox txtDeliveryNumber;
        private System.Windows.Forms.Label lblInitInputID;
        private System.Windows.Forms.CheckBox chkSetPickingIndicator;
        private System.Windows.Forms.NumericUpDown numInputSource;
        private System.Windows.Forms.Label lblInputSource;
        private System.Windows.Forms.Label lblPackScanCode;
        private System.Windows.Forms.TextBox txtPackScanCode;
        private System.Windows.Forms.Label lblPackExpiryDate;
        private System.Windows.Forms.TextBox txtPackExpiryDate;
        private System.Windows.Forms.Label lblPackBatchNumber;
        private System.Windows.Forms.TextBox txtPackBatchNumber;
        private System.Windows.Forms.ComboBox cmbPackShape;
        private System.Windows.Forms.Label lblPackShape;
        private System.Windows.Forms.NumericUpDown numPackHeight;
        private System.Windows.Forms.Label lblPackHeight;
        private System.Windows.Forms.NumericUpDown numPackWidth;
        private System.Windows.Forms.Label lblPackWidth;
        private System.Windows.Forms.NumericUpDown numPackDepth;
        private System.Windows.Forms.Label lblPackDepth;
        private System.Windows.Forms.NumericUpDown numPackSubItemQuantity;
        private System.Windows.Forms.Label lblPackSubItemQuantity;
        private System.Windows.Forms.Button btnSendInitInputRequest;
        private System.Windows.Forms.GroupBox groupInitInputActivities;
        private System.Windows.Forms.Button btnClearInitInputLog;
        private System.Windows.Forms.ListBox listInitInputLog;
        private System.Windows.Forms.Button btnBulkOrder;
        private System.Windows.Forms.NumericUpDown numInputPoint;
        private System.Windows.Forms.Label lblInputPoint;
        private System.Windows.Forms.Button btnGetConfig;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.TextBox txtConfiguration;
        private System.Windows.Forms.NumericUpDown numDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TabPage tabTaskInfo;
        private System.Windows.Forms.GroupBox groupPacks;
        private System.Windows.Forms.DataGridView dataGridPackInfo;
        private System.Windows.Forms.GroupBox groupArticles;
        private System.Windows.Forms.DataGridView dataGridArticleInfo;
        private System.Windows.Forms.GroupBox groupTask;
        private System.Windows.Forms.Button btnGetTaskInfo;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.Label lblTaskStateDesc;
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.CheckBox checkAutomaticStateObservation;
        private System.Windows.Forms.CheckBox checkSetSubItemQuantity;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label lblTenantId;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.GroupBox groupComponents;
        private System.Windows.Forms.Button btnReloadComponents;
        private System.Windows.Forms.CheckBox checkEnforceLocationNewDelivery;
        private System.Windows.Forms.CheckBox checkEnforceLocationStockReturn;
        private System.Windows.Forms.Label lblStockLocation;
        private System.Windows.Forms.TextBox txtPackStockLocation;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.DataGridView dataGridComponents;
        private System.Windows.Forms.GroupBox groupStockLocations;
        private System.Windows.Forms.DataGridView dataGridStockLocations;
        private System.Windows.Forms.Button btnReloadStockLocations;
        private System.Windows.Forms.Label lblDefExpiryDate;
        private System.Windows.Forms.NumericUpDown numExpiryDateMonth;
        private System.Windows.Forms.TextBox txtOverwriteStockLocation;
        private System.Windows.Forms.CheckBox checkOverwriteStockLocation;
        private System.Windows.Forms.Button btnGenerateArticles;
        private System.Windows.Forms.Button btnImportSelectArticles;
        private System.Windows.Forms.OpenFileDialog openArticleFileDialog;
        private System.Windows.Forms.Button btnDisconnect;
        private System.ComponentModel.BackgroundWorker bgInitInput;
        private System.Windows.Forms.CheckBox checkOnlyArticlesFromList;
        private System.Windows.Forms.CheckBox checkBoxSetVirtualArticle;
        private System.Windows.Forms.GroupBox groupBoxMasterArticles;
        private System.Windows.Forms.DataGridView dataGridMasterArticles;
        private System.Windows.Forms.GroupBox groupBoxDigitalShelf;
        private System.Windows.Forms.Button buttonDigitalShelfDisconnect;
        private System.Windows.Forms.Button buttonDigitalShelfConnect;
        private System.Windows.Forms.NumericUpDown numericUpDownDigitalShelfPort;
        private System.Windows.Forms.TextBox textBoxDigitalShelfAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConnectDigitalShelf;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStorageSystem;
        private System.Windows.Forms.TabPage tabPageDigitalShelf;
        private System.Windows.Forms.TabControl tabControlDigitalShelf;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Button buttonClearDigitalShelfLog;
        private System.Windows.Forms.ListBox listBoxDigitalShelfLog;
        private System.Windows.Forms.TabPage tabPageArticleInfo;
        private System.Windows.Forms.GroupBox groupBoxAlternativePackSizeArticle;
        private System.Windows.Forms.Button buttonRemoveAlternativePackSizeArticle;
        private System.Windows.Forms.Button buttonAddAlternativePackSizeArticle;
        private System.Windows.Forms.ListBox listBoxAlternativePackSizeArticle;
        private System.Windows.Forms.GroupBox groupBoxAlternativeArticle;
        private System.Windows.Forms.Button buttonRemoveAlternativeArticle;
        private System.Windows.Forms.Button buttonAddAlternativeArticle;
        private System.Windows.Forms.ListBox listBoxAlternativeArticle;
        private System.Windows.Forms.GroupBox groupBoxCrossSellingArticle;
        private System.Windows.Forms.Button buttonRemoveCrossSellingArticle;
        private System.Windows.Forms.Button buttonAddCrossSellingArticle;
        private System.Windows.Forms.ListBox listBoxCrossSellingArticle;
        private System.Windows.Forms.GroupBox groupBoxTag;
        private System.Windows.Forms.Button buttonRemoveTag;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.ListBox listBoxTag;
        private System.Windows.Forms.TabPage tabPagePriceInformation;
        private System.Windows.Forms.GroupBox groupBoxPriceInformation;
        private System.Windows.Forms.Button buttonRemovePriceInformation;
        private System.Windows.Forms.Button buttonAddPriceInformation;
        private System.Windows.Forms.ListBox listBoxPriceInformation;
        private System.Windows.Forms.TabPage tabPageShoppingCartRequested;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartItemsForUpdate;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartInfo;
        private System.Windows.Forms.Label labelShoppingCartInfoID;
        private System.Windows.Forms.Label labelShoppingCartInfoViewPointID;
        private System.Windows.Forms.Label labelShoppingCartInfoSalesPointID;
        private System.Windows.Forms.Label labelShoppingCartInfoCustomerID;
        private System.Windows.Forms.Label labelShoppingCartInfoSalesPersonID;
        private System.Windows.Forms.Label labelShoppingCartInfoStatus;
        private System.Windows.Forms.TextBox textBoxShoppingCartInfoID;
        private System.Windows.Forms.TextBox textBoxShoppingCartInfoCustomerID;
        private System.Windows.Forms.TextBox textBoxShoppingCartInfoSalesPersonID;
        private System.Windows.Forms.TextBox textBoxShoppingCartInfoSalesPointID;
        private System.Windows.Forms.TextBox textBoxShoppingCartInfoViewPointID;
        private System.Windows.Forms.ComboBox comboBoxShoppingCartInfoStatus;
        private System.Windows.Forms.ListView listViewShoppingCartItemsForUpdate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartUpdateHandling;
        private System.Windows.Forms.Button buttonShoppingCartUpdateAutoReject;
        private System.Windows.Forms.Button buttonShoppingCartUpdateAutoAccept;
        private System.Windows.Forms.Label labelShoppingCartUpdateHandlingAuto;
        private System.Windows.Forms.Label labelShoppingCartUpdateHandlingManuel;
        private System.Windows.Forms.Label labelShoppingCartUpdateHandlingDescription;
        private System.Windows.Forms.TextBox textBoxShoppingCartUpdateHandlingDescription;
        private System.Windows.Forms.RadioButton radioButtonShoppingCartUpdateAutoManual;
        private System.Windows.Forms.RadioButton radioButtonShoppingCartUpdateAutoReject;
        private System.Windows.Forms.RadioButton radioButtonShoppingCartUpdateAutoAccept;
        private System.Windows.Forms.CheckBox checkBoxTagAutoGenerate;
        private System.Windows.Forms.CheckBox checkBoxAlternativePackSizeAutoGenerated;
        private System.Windows.Forms.CheckBox checkBoxAlternativeArticlesAutoGenerate;
        private System.Windows.Forms.CheckBox checkBoxCrossSellingArticleAutoGenerate;
        private System.Windows.Forms.CheckBox checkBoxPriceInformationAutoGenerate;
        private System.Windows.Forms.GroupBox groupBoxArticleInformation;
        private System.Windows.Forms.Label labelMaxSubItemQuantity;
        private System.Windows.Forms.TextBox textBoxPackagingUnit;
        private System.Windows.Forms.Label labelPackagingUnit;
        private System.Windows.Forms.TextBox textBoxDosageForm;
        private System.Windows.Forms.Label labelDosageForm;
        private System.Windows.Forms.Label labelArticleName;
        private System.Windows.Forms.TextBox textBoxArticleName;
        private System.Windows.Forms.CheckBox checkBoxArticleInformationAutoGenerate;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSubItemQuantity;
        private System.Windows.Forms.CheckBox checkAutoConnect;
        private System.Windows.Forms.TabControl tabControlShoppingCart;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartItemsForRequest;
        private System.Windows.Forms.ListView listViewShoppingCartItemsForRequest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShoppingCartCustomerID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxShoppingCartSalesPersonId;
        private System.Windows.Forms.RadioButton radioButtonShoppingCartReject;
        private System.Windows.Forms.TextBox textBoxShoppingCartSalesPointID;
        private System.Windows.Forms.RadioButton radioButtonShoppingCartAccept;
        private System.Windows.Forms.TextBox textBoxShoppingCartViewPointID;
        private System.Windows.Forms.Label labelViewPointId;
        private System.Windows.Forms.ComboBox comboBoxShoppingCartStatus;
        private System.Windows.Forms.Label labelSalesPointId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelSalesPersonId;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonRemoveShoppingCartItem;
        private System.Windows.Forms.Button buttonAddShoppingCartItem;
        private System.Windows.Forms.GroupBox groupOrderBoxes;
        private System.Windows.Forms.DataGridView dataGridOrderBoxes;
        private System.Windows.Forms.TabPage tabRawXml;
        private System.Windows.Forms.GroupBox groupRawXml;
        private System.Windows.Forms.Button btnSendRawXml;
        private System.Windows.Forms.Button btnClearRawXml;
        private System.Windows.Forms.RichTextBox txtRawXml;
        private System.Windows.Forms.TabPage tabRawXmlDigitalShelf;
        private System.Windows.Forms.GroupBox groupRawXmlDigitalShelf;
        private System.Windows.Forms.RichTextBox txtRawXmlDigitalShelf;
        private System.Windows.Forms.Button btnClearRawXmlDigitalShelf;
        private System.Windows.Forms.Button btnSendRawXmlDigitalShelf;
        private System.ComponentModel.BackgroundWorker bgConnect;
        private System.ComponentModel.BackgroundWorker bgStock;
        private System.Windows.Forms.CheckBox checkEnforceSerialNumberNewDelivery;
        private System.Windows.Forms.CheckBox checkEnforceSerialNumberStockReturn;
        private System.Windows.Forms.Button btnImportFromSelect;
    }
}


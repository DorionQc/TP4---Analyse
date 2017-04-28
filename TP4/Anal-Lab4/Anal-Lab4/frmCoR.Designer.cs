namespace Anal_Lab4
{
    partial class frmCoR
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.propGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAjouter = new System.Windows.Forms.GroupBox();
            this.numAddPriority = new System.Windows.Forms.NumericUpDown();
            this.lblAddPos = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.numAddPos = new System.Windows.Forms.NumericUpDown();
            this.lblAddPriority = new System.Windows.Forms.Label();
            this.lblAddNom = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtAddNom = new System.Windows.Forms.TextBox();
            this.gbExecuter = new System.Windows.Forms.GroupBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.btnShowWithConditions = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPriority = new System.Windows.Forms.Label();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.cbPriorityMode = new System.Windows.Forms.ComboBox();
            this.gbPresentation = new System.Windows.Forms.GroupBox();
            this.btnPresentation = new System.Windows.Forms.Button();
            this.mainPanel = new Anal_Lab4.dbPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanelControls.SuspendLayout();
            this.gbAjouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPos)).BeginInit();
            this.gbExecuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.gbPresentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtConsole);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnTimer);
            this.splitContainer2.Panel2.Controls.Add(this.lblTime);
            this.splitContainer2.Panel2.Controls.Add(this.btnClearConsole);
            this.splitContainer2.Panel2.Controls.Add(this.propGrid);
            this.splitContainer2.Size = new System.Drawing.Size(359, 531);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(359, 220);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.TabStop = false;
            // 
            // btnTimer
            // 
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.Black;
            this.btnTimer.Location = new System.Drawing.Point(193, 0);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(42, 23);
            this.btnTimer.TabIndex = 3;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(241, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "99-99";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearConsole.ForeColor = System.Drawing.Color.Black;
            this.btnClearConsole.Location = new System.Drawing.Point(281, 0);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(75, 23);
            this.btnClearConsole.TabIndex = 1;
            this.btnClearConsole.TabStop = false;
            this.btnClearConsole.Text = "Clear";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // propGrid
            // 
            this.propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid.Location = new System.Drawing.Point(0, 0);
            this.propGrid.Name = "propGrid";
            this.propGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propGrid.SelectedObject = this.propGrid;
            this.propGrid.Size = new System.Drawing.Size(359, 307);
            this.propGrid.TabIndex = 0;
            this.propGrid.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(1182, 531);
            this.splitContainer1.SplitterDistance = 819;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutPanelControls);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.mainPanel);
            this.splitContainer3.Size = new System.Drawing.Size(819, 531);
            this.splitContainer3.SplitterDistance = 206;
            this.splitContainer3.TabIndex = 1;
            // 
            // flowLayoutPanelControls
            // 
            this.flowLayoutPanelControls.Controls.Add(this.gbAjouter);
            this.flowLayoutPanelControls.Controls.Add(this.gbExecuter);
            this.flowLayoutPanelControls.Controls.Add(this.gbSettings);
            this.flowLayoutPanelControls.Controls.Add(this.gbPresentation);
            this.flowLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelControls.Name = "flowLayoutPanelControls";
            this.flowLayoutPanelControls.Size = new System.Drawing.Size(819, 206);
            this.flowLayoutPanelControls.TabIndex = 0;
            // 
            // gbAjouter
            // 
            this.gbAjouter.Controls.Add(this.numAddPriority);
            this.gbAjouter.Controls.Add(this.lblAddPos);
            this.gbAjouter.Controls.Add(this.btnRandom);
            this.gbAjouter.Controls.Add(this.numAddPos);
            this.gbAjouter.Controls.Add(this.lblAddPriority);
            this.gbAjouter.Controls.Add(this.lblAddNom);
            this.gbAjouter.Controls.Add(this.btnAjouter);
            this.gbAjouter.Controls.Add(this.txtAddNom);
            this.gbAjouter.Location = new System.Drawing.Point(3, 3);
            this.gbAjouter.Name = "gbAjouter";
            this.gbAjouter.Size = new System.Drawing.Size(200, 152);
            this.gbAjouter.TabIndex = 5;
            this.gbAjouter.TabStop = false;
            this.gbAjouter.Text = "Ajouter";
            // 
            // numAddPriority
            // 
            this.numAddPriority.Location = new System.Drawing.Point(6, 45);
            this.numAddPriority.Name = "numAddPriority";
            this.numAddPriority.Size = new System.Drawing.Size(100, 20);
            this.numAddPriority.TabIndex = 2;
            // 
            // lblAddPos
            // 
            this.lblAddPos.AutoSize = true;
            this.lblAddPos.Location = new System.Drawing.Point(112, 73);
            this.lblAddPos.Name = "lblAddPos";
            this.lblAddPos.Size = new System.Drawing.Size(44, 13);
            this.lblAddPos.TabIndex = 6;
            this.lblAddPos.Text = "Position";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(6, 123);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(101, 20);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Ajouter Aléatoire";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // numAddPos
            // 
            this.numAddPos.Location = new System.Drawing.Point(6, 71);
            this.numAddPos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numAddPos.Name = "numAddPos";
            this.numAddPos.Size = new System.Drawing.Size(101, 20);
            this.numAddPos.TabIndex = 3;
            this.numAddPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblAddPriority
            // 
            this.lblAddPriority.AutoSize = true;
            this.lblAddPriority.Location = new System.Drawing.Point(112, 48);
            this.lblAddPriority.Name = "lblAddPriority";
            this.lblAddPriority.Size = new System.Drawing.Size(39, 13);
            this.lblAddPriority.TabIndex = 4;
            this.lblAddPriority.Text = "Priorité";
            // 
            // lblAddNom
            // 
            this.lblAddNom.AutoSize = true;
            this.lblAddNom.Location = new System.Drawing.Point(112, 22);
            this.lblAddNom.Name = "lblAddNom";
            this.lblAddNom.Size = new System.Drawing.Size(29, 13);
            this.lblAddNom.TabIndex = 3;
            this.lblAddNom.Text = "Nom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 97);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 20);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtAddNom
            // 
            this.txtAddNom.Location = new System.Drawing.Point(6, 19);
            this.txtAddNom.Name = "txtAddNom";
            this.txtAddNom.Size = new System.Drawing.Size(100, 20);
            this.txtAddNom.TabIndex = 1;
            // 
            // gbExecuter
            // 
            this.gbExecuter.Controls.Add(this.numFontSize);
            this.gbExecuter.Controls.Add(this.btnVider);
            this.gbExecuter.Controls.Add(this.btnReturnValue);
            this.gbExecuter.Controls.Add(this.btnShowWithConditions);
            this.gbExecuter.Controls.Add(this.btnShowAll);
            this.gbExecuter.Location = new System.Drawing.Point(209, 3);
            this.gbExecuter.Name = "gbExecuter";
            this.gbExecuter.Size = new System.Drawing.Size(200, 152);
            this.gbExecuter.TabIndex = 6;
            this.gbExecuter.TabStop = false;
            this.gbExecuter.Text = "Executer";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(9, 19);
            this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(134, 20);
            this.numFontSize.TabIndex = 8;
            this.numFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.numFontSize_ValueChanged);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(9, 123);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(134, 20);
            this.btnVider.TabIndex = 9;
            this.btnVider.TabStop = false;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.Location = new System.Drawing.Point(9, 97);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(134, 20);
            this.btnReturnValue.TabIndex = 8;
            this.btnReturnValue.Text = "Executer Avec Retour";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
            // 
            // btnShowWithConditions
            // 
            this.btnShowWithConditions.Location = new System.Drawing.Point(9, 71);
            this.btnShowWithConditions.Name = "btnShowWithConditions";
            this.btnShowWithConditions.Size = new System.Drawing.Size(134, 20);
            this.btnShowWithConditions.TabIndex = 7;
            this.btnShowWithConditions.Text = "Executer";
            this.btnShowWithConditions.UseVisualStyleBackColor = true;
            this.btnShowWithConditions.Click += new System.EventHandler(this.btnShowWithConditions_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(9, 45);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(134, 20);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Afficher Tout";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.lblNom);
            this.gbSettings.Controls.Add(this.txtNom);
            this.gbSettings.Controls.Add(this.lblQuantite);
            this.gbSettings.Controls.Add(this.numQuantity);
            this.gbSettings.Controls.Add(this.lblPriority);
            this.gbSettings.Controls.Add(this.numPriority);
            this.gbSettings.Controls.Add(this.cbPriorityMode);
            this.gbSettings.Location = new System.Drawing.Point(415, 3);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(200, 101);
            this.gbSettings.TabIndex = 7;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Options";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(6, 49);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 5;
            this.lblQuantite.Text = "Quantité";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(59, 47);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(121, 20);
            this.numQuantity.TabIndex = 11;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(6, 22);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(39, 13);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priorité";
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(99, 20);
            this.numPriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(81, 20);
            this.numPriority.TabIndex = 10;
            this.numPriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbPriorityMode
            // 
            this.cbPriorityMode.FormattingEnabled = true;
            this.cbPriorityMode.Items.AddRange(new object[] {
            "<",
            "=",
            ">"});
            this.cbPriorityMode.Location = new System.Drawing.Point(59, 19);
            this.cbPriorityMode.Name = "cbPriorityMode";
            this.cbPriorityMode.Size = new System.Drawing.Size(34, 21);
            this.cbPriorityMode.TabIndex = 9;
            // 
            // gbPresentation
            // 
            this.gbPresentation.Controls.Add(this.btnPresentation);
            this.gbPresentation.Location = new System.Drawing.Point(621, 3);
            this.gbPresentation.Name = "gbPresentation";
            this.gbPresentation.Size = new System.Drawing.Size(98, 59);
            this.gbPresentation.TabIndex = 8;
            this.gbPresentation.TabStop = false;
            this.gbPresentation.Text = "Présentation";
            // 
            // btnPresentation
            // 
            this.btnPresentation.Location = new System.Drawing.Point(10, 20);
            this.btnPresentation.Name = "btnPresentation";
            this.btnPresentation.Size = new System.Drawing.Size(75, 23);
            this.btnPresentation.TabIndex = 0;
            this.btnPresentation.TabStop = false;
            this.btnPresentation.Text = "Présentation";
            this.btnPresentation.UseVisualStyleBackColor = true;
            this.btnPresentation.Click += new System.EventHandler(this.btnPresentation_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(819, 321);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.Resize += new System.EventHandler(this.mainPanel_Resize);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(59, 73);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 76);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom";
            // 
            // frmCoR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 531);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCoR";
            this.Text = "Chaîne de Responsabilités";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCoR_Paint);
            this.Resize += new System.EventHandler(this.frmCoR_Resize);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanelControls.ResumeLayout(false);
            this.gbAjouter.ResumeLayout(false);
            this.gbAjouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPos)).EndInit();
            this.gbExecuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.gbPresentation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.PropertyGrid propGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControls;
        private System.Windows.Forms.GroupBox gbAjouter;
        private System.Windows.Forms.NumericUpDown numAddPriority;
        private System.Windows.Forms.Label lblAddPos;
        private System.Windows.Forms.NumericUpDown numAddPos;
        private System.Windows.Forms.Label lblAddPriority;
        private System.Windows.Forms.Label lblAddNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtAddNom;
        private System.Windows.Forms.GroupBox gbExecuter;
        private System.Windows.Forms.Button btnReturnValue;
        private System.Windows.Forms.Button btnShowWithConditions;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.ComboBox cbPriorityMode;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private dbPanel mainPanel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox gbPresentation;
        private System.Windows.Forms.Button btnPresentation;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
    }
}


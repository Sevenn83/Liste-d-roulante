namespace ListeDeroulante
{
    partial class FrmListSimple
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
            this.grpBoxType = new System.Windows.Forms.GroupBox();
            this.rdBtnEtendue = new System.Windows.Forms.RadioButton();
            this.rdBtnMultiple = new System.Windows.Forms.RadioButton();
            this.rdBtnSimple = new System.Windows.Forms.RadioButton();
            this.chkBoxVerrouiller = new System.Windows.Forms.CheckBox();
            this.btnAfficheSelection = new System.Windows.Forms.Button();
            this.btnSuppSelection = new System.Windows.Forms.Button();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.TxtSaisie = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxType
            // 
            this.grpBoxType.Controls.Add(this.rdBtnEtendue);
            this.grpBoxType.Controls.Add(this.rdBtnMultiple);
            this.grpBoxType.Controls.Add(this.rdBtnSimple);
            this.grpBoxType.Location = new System.Drawing.Point(27, 12);
            this.grpBoxType.Name = "grpBoxType";
            this.grpBoxType.Size = new System.Drawing.Size(200, 100);
            this.grpBoxType.TabIndex = 0;
            this.grpBoxType.TabStop = false;
            this.grpBoxType.Text = "Type de sélection";
            // 
            // rdBtnEtendue
            // 
            this.rdBtnEtendue.AutoSize = true;
            this.rdBtnEtendue.Location = new System.Drawing.Point(22, 65);
            this.rdBtnEtendue.Name = "rdBtnEtendue";
            this.rdBtnEtendue.Size = new System.Drawing.Size(65, 17);
            this.rdBtnEtendue.TabIndex = 2;
            this.rdBtnEtendue.TabStop = true;
            this.rdBtnEtendue.Text = "Etendue";
            this.rdBtnEtendue.UseVisualStyleBackColor = true;
            // 
            // rdBtnMultiple
            // 
            this.rdBtnMultiple.AutoSize = true;
            this.rdBtnMultiple.Location = new System.Drawing.Point(22, 42);
            this.rdBtnMultiple.Name = "rdBtnMultiple";
            this.rdBtnMultiple.Size = new System.Drawing.Size(61, 17);
            this.rdBtnMultiple.TabIndex = 1;
            this.rdBtnMultiple.TabStop = true;
            this.rdBtnMultiple.Text = "Multiple";
            this.rdBtnMultiple.UseVisualStyleBackColor = true;
            // 
            // rdBtnSimple
            // 
            this.rdBtnSimple.AutoSize = true;
            this.rdBtnSimple.Location = new System.Drawing.Point(22, 20);
            this.rdBtnSimple.Name = "rdBtnSimple";
            this.rdBtnSimple.Size = new System.Drawing.Size(56, 17);
            this.rdBtnSimple.TabIndex = 0;
            this.rdBtnSimple.TabStop = true;
            this.rdBtnSimple.Text = "Simple";
            this.rdBtnSimple.UseVisualStyleBackColor = true;
            // 
            // chkBoxVerrouiller
            // 
            this.chkBoxVerrouiller.AutoSize = true;
            this.chkBoxVerrouiller.Location = new System.Drawing.Point(49, 132);
            this.chkBoxVerrouiller.Name = "chkBoxVerrouiller";
            this.chkBoxVerrouiller.Size = new System.Drawing.Size(96, 17);
            this.chkBoxVerrouiller.TabIndex = 1;
            this.chkBoxVerrouiller.Text = "Liste vérouillée";
            this.chkBoxVerrouiller.UseVisualStyleBackColor = true;
            // 
            // btnAfficheSelection
            // 
            this.btnAfficheSelection.Location = new System.Drawing.Point(49, 218);
            this.btnAfficheSelection.Name = "btnAfficheSelection";
            this.btnAfficheSelection.Size = new System.Drawing.Size(159, 37);
            this.btnAfficheSelection.TabIndex = 2;
            this.btnAfficheSelection.Text = "Afficher sélection";
            this.btnAfficheSelection.UseVisualStyleBackColor = true;
            // 
            // btnSuppSelection
            // 
            this.btnSuppSelection.Location = new System.Drawing.Point(49, 261);
            this.btnSuppSelection.Name = "btnSuppSelection";
            this.btnSuppSelection.Size = new System.Drawing.Size(159, 37);
            this.btnSuppSelection.TabIndex = 3;
            this.btnSuppSelection.Text = "Supprimer sélection";
            this.btnSuppSelection.UseVisualStyleBackColor = true;
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(234, 12);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(236, 238);
            this.LstItems.TabIndex = 4;
            // 
            // TxtSaisie
            // 
            this.TxtSaisie.Location = new System.Drawing.Point(234, 257);
            this.TxtSaisie.Name = "TxtSaisie";
            this.TxtSaisie.Size = new System.Drawing.Size(236, 20);
            this.TxtSaisie.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(270, 283);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(159, 37);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmListSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 371);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.TxtSaisie);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.btnSuppSelection);
            this.Controls.Add(this.btnAfficheSelection);
            this.Controls.Add(this.chkBoxVerrouiller);
            this.Controls.Add(this.grpBoxType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListSimple_Load);
            this.grpBoxType.ResumeLayout(false);
            this.grpBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxType;
        private System.Windows.Forms.RadioButton rdBtnEtendue;
        private System.Windows.Forms.RadioButton rdBtnMultiple;
        private System.Windows.Forms.RadioButton rdBtnSimple;
        private System.Windows.Forms.CheckBox chkBoxVerrouiller;
        private System.Windows.Forms.Button btnAfficheSelection;
        private System.Windows.Forms.Button btnSuppSelection;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.TextBox TxtSaisie;
        private System.Windows.Forms.Button btnAjouter;
    }
}


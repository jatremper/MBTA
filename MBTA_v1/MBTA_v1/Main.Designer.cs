namespace MBTA_v1
{
    partial class Main
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
            this.cboRoutes = new System.Windows.Forms.ComboBox();
            this.cboStations = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.gvETAs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvETAs)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRoutes
            // 
            this.cboRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoutes.FormattingEnabled = true;
            this.cboRoutes.Location = new System.Drawing.Point(61, 12);
            this.cboRoutes.Name = "cboRoutes";
            this.cboRoutes.Size = new System.Drawing.Size(200, 21);
            this.cboRoutes.TabIndex = 0;
            this.cboRoutes.SelectedIndexChanged += new System.EventHandler(this.cboRoutes_SelectedIndexChanged);
            // 
            // cboStations
            // 
            this.cboStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStations.FormattingEnabled = true;
            this.cboStations.Location = new System.Drawing.Point(61, 39);
            this.cboStations.Name = "cboStations";
            this.cboStations.Size = new System.Drawing.Size(200, 21);
            this.cboStations.TabIndex = 1;
            this.cboStations.SelectedIndexChanged += new System.EventHandler(this.cboStations_SelectedIndexChanged);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(16, 15);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(39, 13);
            this.lblRoute.TabIndex = 2;
            this.lblRoute.Text = "Route:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(12, 42);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 13);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "Station:";
            // 
            // gvETAs
            // 
            this.gvETAs.AllowUserToAddRows = false;
            this.gvETAs.AllowUserToDeleteRows = false;
            this.gvETAs.AllowUserToResizeRows = false;
            this.gvETAs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gvETAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvETAs.Location = new System.Drawing.Point(12, 66);
            this.gvETAs.MultiSelect = false;
            this.gvETAs.Name = "gvETAs";
            this.gvETAs.RowHeadersVisible = false;
            this.gvETAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvETAs.Size = new System.Drawing.Size(249, 253);
            this.gvETAs.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 331);
            this.Controls.Add(this.gvETAs);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.cboStations);
            this.Controls.Add(this.cboRoutes);
            this.Name = "Main";
            this.Text = "T Time";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvETAs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRoutes;
        private System.Windows.Forms.ComboBox cboStations;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.DataGridView gvETAs;
    }
}


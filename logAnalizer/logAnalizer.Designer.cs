namespace logAnalizer
{
    partial class logAnalizer
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
            this.logResultText = new System.Windows.Forms.TextBox();
            this.logSelectionLbl = new System.Windows.Forms.Label();
            this.logSelectionBtn = new System.Windows.Forms.Button();
            this.generateMetricsBtn = new System.Windows.Forms.Button();
            this.numNodes = new System.Windows.Forms.TextBox();
            this.numPackets = new System.Windows.Forms.TextBox();
            this.numNodesLbl = new System.Windows.Forms.Label();
            this.numPacketsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logResultText
            // 
            this.logResultText.Location = new System.Drawing.Point(10, 177);
            this.logResultText.Multiline = true;
            this.logResultText.Name = "logResultText";
            this.logResultText.ReadOnly = true;
            this.logResultText.Size = new System.Drawing.Size(780, 268);
            this.logResultText.TabIndex = 0;
            // 
            // logSelectionLbl
            // 
            this.logSelectionLbl.AutoSize = true;
            this.logSelectionLbl.Location = new System.Drawing.Point(185, 63);
            this.logSelectionLbl.Name = "logSelectionLbl";
            this.logSelectionLbl.Size = new System.Drawing.Size(124, 13);
            this.logSelectionLbl.TabIndex = 1;
            this.logSelectionLbl.Text = "Nessun file selezionato...";
            // 
            // logSelectionBtn
            // 
            this.logSelectionBtn.Location = new System.Drawing.Point(12, 58);
            this.logSelectionBtn.Name = "logSelectionBtn";
            this.logSelectionBtn.Size = new System.Drawing.Size(155, 23);
            this.logSelectionBtn.TabIndex = 2;
            this.logSelectionBtn.Text = "Seleziona log del sink";
            this.logSelectionBtn.UseVisualStyleBackColor = true;
            this.logSelectionBtn.Click += new System.EventHandler(this.logSelectionBtn_Click);
            // 
            // generateMetricsBtn
            // 
            this.generateMetricsBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.generateMetricsBtn.FlatAppearance.BorderSize = 0;
            this.generateMetricsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateMetricsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateMetricsBtn.ForeColor = System.Drawing.Color.White;
            this.generateMetricsBtn.Location = new System.Drawing.Point(260, 95);
            this.generateMetricsBtn.Name = "generateMetricsBtn";
            this.generateMetricsBtn.Size = new System.Drawing.Size(265, 76);
            this.generateMetricsBtn.TabIndex = 3;
            this.generateMetricsBtn.Text = "Genera Statistiche";
            this.generateMetricsBtn.UseVisualStyleBackColor = false;
            this.generateMetricsBtn.Click += new System.EventHandler(this.generateMetricsBtn_Click);
            // 
            // numNodes
            // 
            this.numNodes.Location = new System.Drawing.Point(655, 29);
            this.numNodes.Name = "numNodes";
            this.numNodes.Size = new System.Drawing.Size(95, 20);
            this.numNodes.TabIndex = 4;
            // 
            // numPackets
            // 
            this.numPackets.Location = new System.Drawing.Point(655, 63);
            this.numPackets.Name = "numPackets";
            this.numPackets.Size = new System.Drawing.Size(95, 20);
            this.numPackets.TabIndex = 5;
            // 
            // numNodesLbl
            // 
            this.numNodesLbl.AutoSize = true;
            this.numNodesLbl.Location = new System.Drawing.Point(569, 32);
            this.numNodesLbl.Name = "numNodesLbl";
            this.numNodesLbl.Size = new System.Drawing.Size(81, 13);
            this.numNodesLbl.TabIndex = 6;
            this.numNodesLbl.Text = "Numero di nodi:";
            // 
            // numPacketsLbl
            // 
            this.numPacketsLbl.AutoSize = true;
            this.numPacketsLbl.Location = new System.Drawing.Point(535, 66);
            this.numPacketsLbl.Name = "numPacketsLbl";
            this.numPacketsLbl.Size = new System.Drawing.Size(117, 13);
            this.numPacketsLbl.TabIndex = 7;
            this.numPacketsLbl.Text = "Totale pacchetti inviati:";
            // 
            // logAnalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPacketsLbl);
            this.Controls.Add(this.numNodesLbl);
            this.Controls.Add(this.numPackets);
            this.Controls.Add(this.numNodes);
            this.Controls.Add(this.generateMetricsBtn);
            this.Controls.Add(this.logSelectionBtn);
            this.Controls.Add(this.logSelectionLbl);
            this.Controls.Add(this.logResultText);
            this.Name = "logAnalizer";
            this.Text = "Log Analizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logResultText;
        private System.Windows.Forms.Label logSelectionLbl;
        private System.Windows.Forms.Button logSelectionBtn;
        private System.Windows.Forms.Button generateMetricsBtn;
        private System.Windows.Forms.TextBox numNodes;
        private System.Windows.Forms.TextBox numPackets;
        private System.Windows.Forms.Label numNodesLbl;
        private System.Windows.Forms.Label numPacketsLbl;
    }
}


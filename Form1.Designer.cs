namespace CorsaMacchine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pbPista = new System.Windows.Forms.PictureBox();
            this.pbCar2 = new System.Windows.Forms.PictureBox();
            this.pbCar1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbPista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "START/RIVINCITA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPista
            // 
            this.pbPista.Image = global::CorsaMacchine.Properties.Resources.road_trip_background_10864211;
            this.pbPista.Location = new System.Drawing.Point(2, 98);
            this.pbPista.Name = "pbPista";
            this.pbPista.Size = new System.Drawing.Size(1285, 462);
            this.pbPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPista.TabIndex = 4;
            this.pbPista.TabStop = false;
            // 
            // pbCar2
            // 
            this.pbCar2.Image = global::CorsaMacchine.Properties.Resources.macchinarossa;
            this.pbCar2.Location = new System.Drawing.Point(-7, 402);
            this.pbCar2.Name = "pbCar2";
            this.pbCar2.Size = new System.Drawing.Size(166, 81);
            this.pbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar2.TabIndex = 3;
            this.pbCar2.TabStop = false;
            // 
            // pbCar1
            // 
            this.pbCar1.Image = global::CorsaMacchine.Properties.Resources.macchinabianca;
            this.pbCar1.Location = new System.Drawing.Point(2, 181);
            this.pbCar1.Name = "pbCar1";
            this.pbCar1.Size = new System.Drawing.Size(166, 81);
            this.pbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar1.TabIndex = 2;
            this.pbCar1.TabStop = false;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.pbCar2);
            this.Controls.Add(this.pbCar1);
            this.Controls.Add(this.pbPista);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbCar1;
        private System.Windows.Forms.PictureBox pbCar2;
        private System.Windows.Forms.PictureBox pbPista;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


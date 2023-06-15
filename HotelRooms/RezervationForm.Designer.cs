namespace HotelRooms
{
    partial class RezervationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowEmptyRooms = new System.Windows.Forms.Button();
            this.dtpRezervationDate = new System.Windows.Forms.DateTimePicker();
            this.dgvEmptyRooms = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeRezervation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation date:";
            // 
            // btnShowEmptyRooms
            // 
            this.btnShowEmptyRooms.Location = new System.Drawing.Point(227, 39);
            this.btnShowEmptyRooms.Name = "btnShowEmptyRooms";
            this.btnShowEmptyRooms.Size = new System.Drawing.Size(144, 23);
            this.btnShowEmptyRooms.TabIndex = 1;
            this.btnShowEmptyRooms.Text = "Show empty rooms";
            this.btnShowEmptyRooms.UseVisualStyleBackColor = true;
            this.btnShowEmptyRooms.Click += new System.EventHandler(this.btnShowEmptyRooms_Click);
            // 
            // dtpRezervationDate
            // 
            this.dtpRezervationDate.Location = new System.Drawing.Point(12, 40);
            this.dtpRezervationDate.Name = "dtpRezervationDate";
            this.dtpRezervationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpRezervationDate.TabIndex = 2;
            // 
            // dgvEmptyRooms
            // 
            this.dgvEmptyRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmptyRooms.Location = new System.Drawing.Point(15, 98);
            this.dgvEmptyRooms.MultiSelect = false;
            this.dgvEmptyRooms.Name = "dgvEmptyRooms";
            this.dgvEmptyRooms.ReadOnly = true;
            this.dgvEmptyRooms.RowHeadersWidth = 51;
            this.dgvEmptyRooms.RowTemplate.Height = 24;
            this.dgvEmptyRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmptyRooms.Size = new System.Drawing.Size(356, 150);
            this.dgvEmptyRooms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empty rooms:";
            // 
            // btnMakeRezervation
            // 
            this.btnMakeRezervation.Location = new System.Drawing.Point(227, 254);
            this.btnMakeRezervation.Name = "btnMakeRezervation";
            this.btnMakeRezervation.Size = new System.Drawing.Size(144, 23);
            this.btnMakeRezervation.TabIndex = 5;
            this.btnMakeRezervation.Text = "Make a rezervation";
            this.btnMakeRezervation.UseVisualStyleBackColor = true;
            this.btnMakeRezervation.Click += new System.EventHandler(this.btnMakeRezervation_Click);
            // 
            // RezervationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 291);
            this.Controls.Add(this.btnMakeRezervation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmptyRooms);
            this.Controls.Add(this.dtpRezervationDate);
            this.Controls.Add(this.btnShowEmptyRooms);
            this.Controls.Add(this.label1);
            this.Name = "RezervationForm";
            this.Text = "Room rezervation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowEmptyRooms;
        private System.Windows.Forms.DateTimePicker dtpRezervationDate;
        private System.Windows.Forms.DataGridView dgvEmptyRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeRezervation;
    }
}


namespace PresentationLayer.Forms
{
    partial class CareerForm
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
            label1 = new Label();
            nombreLabel = new Label();
            txtNameCareer = new TextBox();
            txtDescriptionCareer = new TextBox();
            descripcionLabel = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvCareers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCareers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 25);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Carreras";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(85, 94);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(189, 23);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre de la Carrera:";
            // 
            // txtNameCareer
            // 
            txtNameCareer.Location = new Point(85, 129);
            txtNameCareer.Name = "txtNameCareer";
            txtNameCareer.Size = new Size(174, 27);
            txtNameCareer.TabIndex = 2;
            // 
            // txtDescriptionCareer
            // 
            txtDescriptionCareer.Location = new Point(85, 235);
            txtDescriptionCareer.Multiline = true;
            txtDescriptionCareer.Name = "txtDescriptionCareer";
            txtDescriptionCareer.Size = new Size(193, 82);
            txtDescriptionCareer.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descripcionLabel.Location = new Point(85, 201);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(216, 23);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripción de la Carrera:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(19, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(130, 335);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(230, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCareers
            // 
            dgvCareers.AllowUserToAddRows = false;
            dgvCareers.AllowUserToDeleteRows = false;
            dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCareers.Location = new Point(394, 113);
            dgvCareers.Name = "dgvCareers";
            dgvCareers.ReadOnly = true;
            dgvCareers.RowHeadersWidth = 51;
            dgvCareers.Size = new Size(300, 188);
            dgvCareers.TabIndex = 8;
            // 
            // CareerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCareers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtDescriptionCareer);
            Controls.Add(descripcionLabel);
            Controls.Add(txtNameCareer);
            Controls.Add(nombreLabel);
            Controls.Add(label1);
            Name = "CareerForm";
            Text = "CareerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCareers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nombreLabel;
        private TextBox txtNameCareer;
        private TextBox txtDescriptionCareer;
        private Label descripcionLabel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvCareers;
    }
}
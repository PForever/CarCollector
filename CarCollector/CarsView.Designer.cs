namespace CarCollector
{
    partial class CarsView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.tbModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNumbere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbModel,
            this.tbDateCreate,
            this.tbNumbere});
            this.dgvCars.DataSource = this.bsCars;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(800, 450);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCarDoubleClickAsync);
            this.dgvCars.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnCarDeletingAsync);
            // 
            // tbModel
            // 
            this.tbModel.DataPropertyName = "Model";
            this.tbModel.HeaderText = "Модель";
            this.tbModel.Name = "tbModel";
            // 
            // tbDateCreate
            // 
            this.tbDateCreate.DataPropertyName = "DateCreate";
            this.tbDateCreate.HeaderText = "Дата Создания";
            this.tbDateCreate.Name = "tbDateCreate";
            this.tbDateCreate.ReadOnly = true;
            // 
            // tbNumbere
            // 
            this.tbNumbere.DataPropertyName = "CarNumber";
            this.tbNumbere.HeaderText = "Номер";
            this.tbNumbere.Name = "tbNumbere";
            // 
            // bsCars
            // 
            this.bsCars.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.OnCarsChangedAsync);
            // 
            // CarsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCars);
            this.Name = "CarsView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCars;
        internal System.Windows.Forms.BindingSource bsCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNumbere;
    }
}


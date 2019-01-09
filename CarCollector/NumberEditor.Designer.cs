namespace CarCollector
{
    partial class NumberEditor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCharacters = new System.Windows.Forms.TextBox();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.rbRus = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lbCharacters = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsNumber = new System.Windows.Forms.BindingSource(this.components);
            this.lbOther = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCharacters
            // 
            this.tbCharacters.Location = new System.Drawing.Point(113, 3);
            this.tbCharacters.Name = "tbCharacters";
            this.tbCharacters.Size = new System.Drawing.Size(36, 20);
            this.tbCharacters.TabIndex = 0;
            this.tbCharacters.TextChanged += new System.EventHandler(this.OnCharactersChanged);
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(202, 4);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(54, 20);
            this.tbNumbers.TabIndex = 1;
            this.tbNumbers.TextChanged += new System.EventHandler(this.OnNumbersChanged);
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(310, 4);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(58, 20);
            this.tbRegion.TabIndex = 2;
            this.tbRegion.TextChanged += new System.EventHandler(this.OnRegionChanged);
            // 
            // rbRus
            // 
            this.rbRus.AutoSize = true;
            this.rbRus.Checked = true;
            this.rbRus.Location = new System.Drawing.Point(3, 4);
            this.rbRus.Name = "rbRus";
            this.rbRus.Size = new System.Drawing.Size(48, 17);
            this.rbRus.TabIndex = 3;
            this.rbRus.TabStop = true;
            this.rbRus.Text = "RUS";
            this.rbRus.UseVisualStyleBackColor = true;
            this.rbRus.CheckedChanged += new System.EventHandler(this.OnIsRusChanged);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(3, 27);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(62, 17);
            this.rbOther.TabIndex = 4;
            this.rbOther.Text = "Другой";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(113, 27);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(255, 20);
            this.tbOther.TabIndex = 5;
            this.tbOther.TextChanged += new System.EventHandler(this.OnOtherChanged);
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(3, 71);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(365, 34);
            this.tbComments.TabIndex = 6;
            // 
            // lbCharacters
            // 
            this.lbCharacters.AutoSize = true;
            this.lbCharacters.Location = new System.Drawing.Point(69, 6);
            this.lbCharacters.Name = "lbCharacters";
            this.lbCharacters.Size = new System.Drawing.Size(38, 13);
            this.lbCharacters.TabIndex = 7;
            this.lbCharacters.Text = "буквы";
            // 
            // lbNumbers
            // 
            this.lbNumbers.AutoSize = true;
            this.lbNumbers.Location = new System.Drawing.Point(155, 6);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(41, 13);
            this.lbNumbers.TabIndex = 8;
            this.lbNumbers.Text = "цифры";
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(262, 6);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(42, 13);
            this.lbRegion.TabIndex = 9;
            this.lbRegion.Text = "регион";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Комментарии (не обязательно):";
            // 
            // bsNumber
            // 
            this.bsNumber.DataSourceChanged += new System.EventHandler(this.OnDatasourceChanged);
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Location = new System.Drawing.Point(69, 30);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(41, 13);
            this.lbOther.TabIndex = 11;
            this.lbOther.Text = "Номер";
            // 
            // NumberEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRegion);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.lbCharacters);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbRus);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.tbCharacters);
            this.Name = "NumberEditor";
            this.Size = new System.Drawing.Size(371, 110);
            ((System.ComponentModel.ISupportInitialize)(this.bsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCharacters;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.RadioButton rbRus;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lbCharacters;
        private System.Windows.Forms.Label lbNumbers;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsNumber;
        private System.Windows.Forms.Label lbOther;
    }
}

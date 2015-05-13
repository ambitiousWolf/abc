namespace Team2_Quiz5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxMaterial = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxShape = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConstant = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "材質類別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "形狀類別";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxMaterial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材質設定";
            // 
            // cboxMaterial
            // 
            this.cboxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMaterial.FormattingEnabled = true;
            this.cboxMaterial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cboxMaterial.Location = new System.Drawing.Point(110, 22);
            this.cboxMaterial.Name = "cboxMaterial";
            this.cboxMaterial.Size = new System.Drawing.Size(121, 20);
            this.cboxMaterial.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxShape);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtParameter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀設定";
            // 
            // cboxShape
            // 
            this.cboxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxShape.FormattingEnabled = true;
            this.cboxShape.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cboxShape.Location = new System.Drawing.Point(110, 18);
            this.cboxShape.Name = "cboxShape";
            this.cboxShape.Size = new System.Drawing.Size(121, 20);
            this.cboxShape.TabIndex = 6;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(138, 80);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "高";
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(18, 80);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(100, 22);
            this.txtParameter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "底邊";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(138, 28);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "數量";
            // 
            // txtConstant
            // 
            this.txtConstant.Location = new System.Drawing.Point(21, 273);
            this.txtConstant.Multiline = true;
            this.txtConstant.Name = "txtConstant";
            this.txtConstant.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConstant.Size = new System.Drawing.Size(256, 135);
            this.txtConstant.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(304, 46);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(363, 362);
            this.txtResult.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(478, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compare
            // 
            this.compare.FormattingEnabled = true;
            this.compare.Items.AddRange(new object[] {
            "order",
            "type"});
            this.compare.Location = new System.Drawing.Point(323, 15);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(121, 20);
            this.compare.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 420);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtConstant);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxMaterial;
        private System.Windows.Forms.ComboBox cboxShape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConstant;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox compare;
    }
}


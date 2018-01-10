namespace CaloriesCalculatorVer2
{
    partial class foodCalculator
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
            this.btnCaloriesProducts = new System.Windows.Forms.Button();
            this.btnBurnedCalories = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaloriesProducts
            // 
            this.btnCaloriesProducts.Location = new System.Drawing.Point(45, 61);
            this.btnCaloriesProducts.Name = "btnCaloriesProducts";
            this.btnCaloriesProducts.Size = new System.Drawing.Size(421, 79);
            this.btnCaloriesProducts.TabIndex = 0;
            this.btnCaloriesProducts.Text = "Calories In Food Products";
            this.btnCaloriesProducts.UseVisualStyleBackColor = true;
            this.btnCaloriesProducts.Click += new System.EventHandler(this.btnCaloriesProducts_Click);
            // 
            // btnBurnedCalories
            // 
            this.btnBurnedCalories.Location = new System.Drawing.Point(45, 158);
            this.btnBurnedCalories.Name = "btnBurnedCalories";
            this.btnBurnedCalories.Size = new System.Drawing.Size(421, 79);
            this.btnBurnedCalories.TabIndex = 1;
            this.btnBurnedCalories.Text = "Burned Calories";
            this.btnBurnedCalories.UseVisualStyleBackColor = true;
            this.btnBurnedCalories.Click += new System.EventHandler(this.btnBurnedCalories_Click);
            // 
            // btnStatics
            // 
            this.btnStatics.Location = new System.Drawing.Point(45, 255);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(421, 79);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.Text = "Personal Weight Statistic";
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food\'s Calories Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatics);
            this.Controls.Add(this.btnBurnedCalories);
            this.Controls.Add(this.btnCaloriesProducts);
            this.Name = "foodCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.foodCalculator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaloriesProducts;
        private System.Windows.Forms.Button btnBurnedCalories;
        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.Label label1;
    }
}


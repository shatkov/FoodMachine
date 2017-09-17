namespace FoodAutomat
{
    partial class MainForm
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
            this.btAddOrder = new System.Windows.Forms.Button();
            this.nUDCountSugar = new System.Windows.Forms.NumericUpDown();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.gbDrink = new System.Windows.Forms.GroupBox();
            this.rbGreenTea = new System.Windows.Forms.RadioButton();
            this.rbBlackTea = new System.Windows.Forms.RadioButton();
            this.rbCappuccino = new System.Windows.Forms.RadioButton();
            this.rbLatte = new System.Windows.Forms.RadioButton();
            this.rbExpresso = new System.Windows.Forms.RadioButton();
            this.gbAdditDrink = new System.Windows.Forms.GroupBox();
            this.cbSyrup = new System.Windows.Forms.CheckBox();
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.cbMilk = new System.Windows.Forms.CheckBox();
            this.gbAdditFood = new System.Windows.Forms.GroupBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbJam = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.gbFood = new System.Windows.Forms.GroupBox();
            this.rbBiscuit = new System.Windows.Forms.RadioButton();
            this.rbChips = new System.Windows.Forms.RadioButton();
            this.rbBun = new System.Windows.Forms.RadioButton();
            this.rbBread = new System.Windows.Forms.RadioButton();
            this.cbComplex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCountSugar)).BeginInit();
            this.gbDrink.SuspendLayout();
            this.gbAdditDrink.SuspendLayout();
            this.gbAdditFood.SuspendLayout();
            this.gbFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddOrder
            // 
            this.btAddOrder.Location = new System.Drawing.Point(216, 297);
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btAddOrder.TabIndex = 0;
            this.btAddOrder.Text = "Выдать";
            this.btAddOrder.UseVisualStyleBackColor = true;
            this.btAddOrder.Click += new System.EventHandler(this.btAddOrder_Click);
            // 
            // nUDCountSugar
            // 
            this.nUDCountSugar.Location = new System.Drawing.Point(80, 63);
            this.nUDCountSugar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDCountSugar.Name = "nUDCountSugar";
            this.nUDCountSugar.Size = new System.Drawing.Size(43, 20);
            this.nUDCountSugar.TabIndex = 3;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Location = new System.Drawing.Point(6, 19);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(68, 17);
            this.rbWater.TabIndex = 4;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Вода(20)";
            this.rbWater.UseVisualStyleBackColor = true;
            this.rbWater.CheckedChanged += new System.EventHandler(this.rbWater_CheckedChanged);
            // 
            // gbDrink
            // 
            this.gbDrink.Controls.Add(this.rbGreenTea);
            this.gbDrink.Controls.Add(this.rbBlackTea);
            this.gbDrink.Controls.Add(this.rbCappuccino);
            this.gbDrink.Controls.Add(this.rbLatte);
            this.gbDrink.Controls.Add(this.rbExpresso);
            this.gbDrink.Controls.Add(this.rbWater);
            this.gbDrink.Location = new System.Drawing.Point(12, 12);
            this.gbDrink.Name = "gbDrink";
            this.gbDrink.Size = new System.Drawing.Size(135, 161);
            this.gbDrink.TabIndex = 5;
            this.gbDrink.TabStop = false;
            this.gbDrink.Text = "Напитки";
            // 
            // rbGreenTea
            // 
            this.rbGreenTea.AutoSize = true;
            this.rbGreenTea.Location = new System.Drawing.Point(6, 134);
            this.rbGreenTea.Name = "rbGreenTea";
            this.rbGreenTea.Size = new System.Drawing.Size(110, 17);
            this.rbGreenTea.TabIndex = 9;
            this.rbGreenTea.TabStop = true;
            this.rbGreenTea.Text = "Чай зеленый(25)";
            this.rbGreenTea.UseVisualStyleBackColor = true;
            // 
            // rbBlackTea
            // 
            this.rbBlackTea.AutoSize = true;
            this.rbBlackTea.Location = new System.Drawing.Point(6, 111);
            this.rbBlackTea.Name = "rbBlackTea";
            this.rbBlackTea.Size = new System.Drawing.Size(103, 17);
            this.rbBlackTea.TabIndex = 8;
            this.rbBlackTea.TabStop = true;
            this.rbBlackTea.Text = "Чай черный(25)";
            this.rbBlackTea.UseVisualStyleBackColor = true;
            // 
            // rbCappuccino
            // 
            this.rbCappuccino.AutoSize = true;
            this.rbCappuccino.Location = new System.Drawing.Point(6, 88);
            this.rbCappuccino.Name = "rbCappuccino";
            this.rbCappuccino.Size = new System.Drawing.Size(90, 17);
            this.rbCappuccino.TabIndex = 7;
            this.rbCappuccino.TabStop = true;
            this.rbCappuccino.Text = "Капучино(70)";
            this.rbCappuccino.UseVisualStyleBackColor = true;
            this.rbCappuccino.CheckedChanged += new System.EventHandler(this.rbCappuccino_CheckedChanged);
            // 
            // rbLatte
            // 
            this.rbLatte.AutoSize = true;
            this.rbLatte.Location = new System.Drawing.Point(6, 65);
            this.rbLatte.Name = "rbLatte";
            this.rbLatte.Size = new System.Drawing.Size(73, 17);
            this.rbLatte.TabIndex = 6;
            this.rbLatte.TabStop = true;
            this.rbLatte.Text = "Латте(60)";
            this.rbLatte.UseVisualStyleBackColor = true;
            this.rbLatte.CheckedChanged += new System.EventHandler(this.rbLatte_CheckedChanged);
            // 
            // rbExpresso
            // 
            this.rbExpresso.AutoSize = true;
            this.rbExpresso.Location = new System.Drawing.Point(6, 42);
            this.rbExpresso.Name = "rbExpresso";
            this.rbExpresso.Size = new System.Drawing.Size(98, 17);
            this.rbExpresso.TabIndex = 5;
            this.rbExpresso.TabStop = true;
            this.rbExpresso.Text = "Экспрессо(50)";
            this.rbExpresso.UseVisualStyleBackColor = true;
            // 
            // gbAdditDrink
            // 
            this.gbAdditDrink.Controls.Add(this.cbSyrup);
            this.gbAdditDrink.Controls.Add(this.cbSugar);
            this.gbAdditDrink.Controls.Add(this.nUDCountSugar);
            this.gbAdditDrink.Controls.Add(this.cbMilk);
            this.gbAdditDrink.Location = new System.Drawing.Point(12, 179);
            this.gbAdditDrink.Name = "gbAdditDrink";
            this.gbAdditDrink.Size = new System.Drawing.Size(135, 89);
            this.gbAdditDrink.TabIndex = 6;
            this.gbAdditDrink.TabStop = false;
            this.gbAdditDrink.Text = "Добавки к напиткам";
            // 
            // cbSyrup
            // 
            this.cbSyrup.AutoSize = true;
            this.cbSyrup.Location = new System.Drawing.Point(6, 42);
            this.cbSyrup.Name = "cbSyrup";
            this.cbSyrup.Size = new System.Drawing.Size(69, 17);
            this.cbSyrup.TabIndex = 2;
            this.cbSyrup.Text = "Сироп(5)";
            this.cbSyrup.UseVisualStyleBackColor = true;
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.Location = new System.Drawing.Point(6, 65);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(68, 17);
            this.cbSugar.TabIndex = 1;
            this.cbSugar.Text = "Сахар(3)";
            this.cbSugar.UseVisualStyleBackColor = true;
            // 
            // cbMilk
            // 
            this.cbMilk.AutoSize = true;
            this.cbMilk.Location = new System.Drawing.Point(6, 19);
            this.cbMilk.Name = "cbMilk";
            this.cbMilk.Size = new System.Drawing.Size(83, 17);
            this.cbMilk.TabIndex = 0;
            this.cbMilk.Text = "Молоко(10)";
            this.cbMilk.UseVisualStyleBackColor = true;
            // 
            // gbAdditFood
            // 
            this.gbAdditFood.Controls.Add(this.cbCheese);
            this.gbAdditFood.Controls.Add(this.cbJam);
            this.gbAdditFood.Controls.Add(this.cbHam);
            this.gbAdditFood.Location = new System.Drawing.Point(159, 179);
            this.gbAdditFood.Name = "gbAdditFood";
            this.gbAdditFood.Size = new System.Drawing.Size(135, 89);
            this.gbAdditFood.TabIndex = 8;
            this.gbAdditFood.TabStop = false;
            this.gbAdditFood.Text = "Добавки к еде";
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(6, 42);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(65, 17);
            this.cbCheese.TabIndex = 2;
            this.cbCheese.Text = "Сыр(10)";
            this.cbCheese.UseVisualStyleBackColor = true;
            // 
            // cbJam
            // 
            this.cbJam.AutoSize = true;
            this.cbJam.Location = new System.Drawing.Point(6, 65);
            this.cbJam.Name = "cbJam";
            this.cbJam.Size = new System.Drawing.Size(69, 17);
            this.cbJam.TabIndex = 1;
            this.cbJam.Text = "Джем(7)";
            this.cbJam.UseVisualStyleBackColor = true;
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(6, 19);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(85, 17);
            this.cbHam.TabIndex = 0;
            this.cbHam.Text = "Ветчина(15)";
            this.cbHam.UseVisualStyleBackColor = true;
            // 
            // gbFood
            // 
            this.gbFood.Controls.Add(this.rbBiscuit);
            this.gbFood.Controls.Add(this.rbChips);
            this.gbFood.Controls.Add(this.rbBun);
            this.gbFood.Controls.Add(this.rbBread);
            this.gbFood.Location = new System.Drawing.Point(159, 12);
            this.gbFood.Name = "gbFood";
            this.gbFood.Size = new System.Drawing.Size(135, 161);
            this.gbFood.TabIndex = 7;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Еда";
            // 
            // rbBiscuit
            // 
            this.rbBiscuit.AutoSize = true;
            this.rbBiscuit.Location = new System.Drawing.Point(6, 88);
            this.rbBiscuit.Name = "rbBiscuit";
            this.rbBiscuit.Size = new System.Drawing.Size(86, 17);
            this.rbBiscuit.TabIndex = 7;
            this.rbBiscuit.TabStop = true;
            this.rbBiscuit.Text = "Печенье(29)";
            this.rbBiscuit.UseVisualStyleBackColor = true;
            this.rbBiscuit.CheckedChanged += new System.EventHandler(this.rbBiscuit_CheckedChanged);
            // 
            // rbChips
            // 
            this.rbChips.AutoSize = true;
            this.rbChips.Location = new System.Drawing.Point(6, 65);
            this.rbChips.Name = "rbChips";
            this.rbChips.Size = new System.Drawing.Size(77, 17);
            this.rbChips.TabIndex = 6;
            this.rbChips.TabStop = true;
            this.rbChips.Text = "Чипсы(34)";
            this.rbChips.UseVisualStyleBackColor = true;
            this.rbChips.CheckedChanged += new System.EventHandler(this.rbChips_CheckedChanged);
            // 
            // rbBun
            // 
            this.rbBun.AutoSize = true;
            this.rbBun.Location = new System.Drawing.Point(6, 42);
            this.rbBun.Name = "rbBun";
            this.rbBun.Size = new System.Drawing.Size(84, 17);
            this.rbBun.TabIndex = 5;
            this.rbBun.TabStop = true;
            this.rbBun.Text = "Булочка(15)";
            this.rbBun.UseVisualStyleBackColor = true;
            // 
            // rbBread
            // 
            this.rbBread.AutoSize = true;
            this.rbBread.Location = new System.Drawing.Point(6, 19);
            this.rbBread.Name = "rbBread";
            this.rbBread.Size = new System.Drawing.Size(68, 17);
            this.rbBread.TabIndex = 4;
            this.rbBread.TabStop = true;
            this.rbBread.Text = "Хлеб(10)";
            this.rbBread.UseVisualStyleBackColor = true;
            // 
            // cbComplex
            // 
            this.cbComplex.AutoSize = true;
            this.cbComplex.Location = new System.Drawing.Point(6, 274);
            this.cbComplex.Name = "cbComplex";
            this.cbComplex.Size = new System.Drawing.Size(298, 17);
            this.cbComplex.TabIndex = 9;
            this.cbComplex.Text = "Комплекс (Напиток с добавкой + Еда с добавкой)(90)";
            this.cbComplex.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 324);
            this.Controls.Add(this.cbComplex);
            this.Controls.Add(this.gbAdditFood);
            this.Controls.Add(this.gbAdditDrink);
            this.Controls.Add(this.gbFood);
            this.Controls.Add(this.gbDrink);
            this.Controls.Add(this.btAddOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Аппарат с едой";
            ((System.ComponentModel.ISupportInitialize)(this.nUDCountSugar)).EndInit();
            this.gbDrink.ResumeLayout(false);
            this.gbDrink.PerformLayout();
            this.gbAdditDrink.ResumeLayout(false);
            this.gbAdditDrink.PerformLayout();
            this.gbAdditFood.ResumeLayout(false);
            this.gbAdditFood.PerformLayout();
            this.gbFood.ResumeLayout(false);
            this.gbFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.NumericUpDown nUDCountSugar;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.GroupBox gbDrink;
        private System.Windows.Forms.RadioButton rbLatte;
        private System.Windows.Forms.RadioButton rbExpresso;
        private System.Windows.Forms.RadioButton rbGreenTea;
        private System.Windows.Forms.RadioButton rbBlackTea;
        private System.Windows.Forms.RadioButton rbCappuccino;
        private System.Windows.Forms.GroupBox gbAdditDrink;
        private System.Windows.Forms.CheckBox cbSyrup;
        private System.Windows.Forms.CheckBox cbSugar;
        private System.Windows.Forms.CheckBox cbMilk;
        private System.Windows.Forms.GroupBox gbAdditFood;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbJam;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.GroupBox gbFood;
        private System.Windows.Forms.RadioButton rbBiscuit;
        private System.Windows.Forms.RadioButton rbChips;
        private System.Windows.Forms.RadioButton rbBun;
        private System.Windows.Forms.RadioButton rbBread;
        private System.Windows.Forms.CheckBox cbComplex;
    }
}


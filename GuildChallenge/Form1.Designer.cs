
namespace GuildChallenge
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Give = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minutes_text = new System.Windows.Forms.TextBox();
            this.hours_text = new System.Windows.Forms.TextBox();
            this.tier_text = new System.Windows.Forms.Label();
            this.tier = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.point_text = new System.Windows.Forms.Label();
            this.coin_text = new System.Windows.Forms.Label();
            this.exp_text = new System.Windows.Forms.Label();
            this.level_text = new System.Windows.Forms.Label();
            this.alias_text = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.exp = new System.Windows.Forms.PictureBox();
            this.level = new System.Windows.Forms.Label();
            this.alias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capacity_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.NotGive = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Give.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Give);
            this.tabControl1.Controls.Add(this.NotGive);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(195, 228);
            this.tabControl1.TabIndex = 0;
            // 
            // Give
            // 
            this.Give.Controls.Add(this.label3);
            this.Give.Controls.Add(this.label4);
            this.Give.Controls.Add(this.minutes_text);
            this.Give.Controls.Add(this.hours_text);
            this.Give.Controls.Add(this.tier_text);
            this.Give.Controls.Add(this.tier);
            this.Give.Controls.Add(this.button1);
            this.Give.Controls.Add(this.point_text);
            this.Give.Controls.Add(this.coin_text);
            this.Give.Controls.Add(this.exp_text);
            this.Give.Controls.Add(this.level_text);
            this.Give.Controls.Add(this.alias_text);
            this.Give.Controls.Add(this.point);
            this.Give.Controls.Add(this.coin);
            this.Give.Controls.Add(this.exp);
            this.Give.Controls.Add(this.level);
            this.Give.Controls.Add(this.alias);
            this.Give.Controls.Add(this.label2);
            this.Give.Controls.Add(this.label1);
            this.Give.Controls.Add(this.capacity_text);
            this.Give.Controls.Add(this.id_text);
            this.Give.Location = new System.Drawing.Point(4, 22);
            this.Give.Name = "Give";
            this.Give.Padding = new System.Windows.Forms.Padding(3);
            this.Give.Size = new System.Drawing.Size(187, 202);
            this.Give.TabIndex = 0;
            this.Give.Text = "Give";
            this.Give.UseVisualStyleBackColor = true;
            this.Give.Click += new System.EventHandler(this.Give_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hours";
            // 
            // minutes_text
            // 
            this.minutes_text.Location = new System.Drawing.Point(75, 67);
            this.minutes_text.Name = "minutes_text";
            this.minutes_text.Size = new System.Drawing.Size(62, 20);
            this.minutes_text.TabIndex = 18;
            this.minutes_text.Text = "30";
            // 
            // hours_text
            // 
            this.hours_text.Location = new System.Drawing.Point(7, 67);
            this.hours_text.Name = "hours_text";
            this.hours_text.Size = new System.Drawing.Size(62, 20);
            this.hours_text.TabIndex = 17;
            this.hours_text.Text = "0";
            // 
            // tier_text
            // 
            this.tier_text.AutoSize = true;
            this.tier_text.Location = new System.Drawing.Point(32, 148);
            this.tier_text.Name = "tier_text";
            this.tier_text.Size = new System.Drawing.Size(48, 13);
            this.tier_text.TabIndex = 16;
            this.tier_text.Text = "test1234";
            this.tier_text.Visible = false;
            // 
            // tier
            // 
            this.tier.AutoSize = true;
            this.tier.Location = new System.Drawing.Point(5, 148);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(28, 13);
            this.tier.TabIndex = 15;
            this.tier.Text = "Tier:";
            this.tier.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сalculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // point_text
            // 
            this.point_text.AutoSize = true;
            this.point_text.Location = new System.Drawing.Point(134, 170);
            this.point_text.Name = "point_text";
            this.point_text.Size = new System.Drawing.Size(48, 13);
            this.point_text.TabIndex = 13;
            this.point_text.Text = "test1234";
            this.point_text.Visible = false;
            // 
            // coin_text
            // 
            this.coin_text.AutoSize = true;
            this.coin_text.Location = new System.Drawing.Point(134, 132);
            this.coin_text.Name = "coin_text";
            this.coin_text.Size = new System.Drawing.Size(48, 13);
            this.coin_text.TabIndex = 12;
            this.coin_text.Text = "test1234";
            this.coin_text.Visible = false;
            // 
            // exp_text
            // 
            this.exp_text.AutoSize = true;
            this.exp_text.Location = new System.Drawing.Point(133, 96);
            this.exp_text.Name = "exp_text";
            this.exp_text.Size = new System.Drawing.Size(48, 13);
            this.exp_text.TabIndex = 11;
            this.exp_text.Text = "test1234";
            this.exp_text.Visible = false;
            // 
            // level_text
            // 
            this.level_text.AutoSize = true;
            this.level_text.Location = new System.Drawing.Point(31, 124);
            this.level_text.Name = "level_text";
            this.level_text.Size = new System.Drawing.Size(48, 13);
            this.level_text.TabIndex = 10;
            this.level_text.Text = "test1234";
            this.level_text.Visible = false;
            // 
            // alias_text
            // 
            this.alias_text.AutoSize = true;
            this.alias_text.Location = new System.Drawing.Point(33, 99);
            this.alias_text.Name = "alias_text";
            this.alias_text.Size = new System.Drawing.Size(48, 13);
            this.alias_text.TabIndex = 9;
            this.alias_text.Text = "test1234";
            this.alias_text.Visible = false;
            // 
            // point
            // 
            this.point.Image = ((System.Drawing.Image)(resources.GetObject("point.Image")));
            this.point.Location = new System.Drawing.Point(99, 160);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(35, 37);
            this.point.TabIndex = 8;
            this.point.TabStop = false;
            this.point.Visible = false;
            // 
            // coin
            // 
            this.coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(102, 126);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(30, 29);
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            this.coin.Visible = false;
            // 
            // exp
            // 
            this.exp.Image = ((System.Drawing.Image)(resources.GetObject("exp.Image")));
            this.exp.Location = new System.Drawing.Point(102, 88);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(29, 30);
            this.exp.TabIndex = 6;
            this.exp.TabStop = false;
            this.exp.Visible = false;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(4, 124);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(29, 13);
            this.level.TabIndex = 5;
            this.level.Text = "LVL:";
            this.level.Visible = false;
            // 
            // alias
            // 
            this.alias.AutoSize = true;
            this.alias.Location = new System.Drawing.Point(4, 99);
            this.alias.Name = "alias";
            this.alias.Size = new System.Drawing.Size(32, 13);
            this.alias.TabIndex = 4;
            this.alias.Text = "Alias:";
            this.alias.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID resource";
            // 
            // capacity_text
            // 
            this.capacity_text.Location = new System.Drawing.Point(74, 29);
            this.capacity_text.Name = "capacity_text";
            this.capacity_text.Size = new System.Drawing.Size(62, 20);
            this.capacity_text.TabIndex = 1;
            this.capacity_text.Text = "1";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(6, 29);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(62, 20);
            this.id_text.TabIndex = 0;
            this.id_text.Text = "1";
            // 
            // NotGive
            // 
            this.NotGive.AutoScroll = true;
            this.NotGive.Location = new System.Drawing.Point(4, 22);
            this.NotGive.Name = "NotGive";
            this.NotGive.Padding = new System.Windows.Forms.Padding(3);
            this.NotGive.Size = new System.Drawing.Size(187, 202);
            this.NotGive.TabIndex = 1;
            this.NotGive.Text = "NotGive";
            this.NotGive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 232);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GuildChallenge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Give.ResumeLayout(false);
            this.Give.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Give;
        private System.Windows.Forms.TabPage NotGive;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label alias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacity_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.PictureBox exp;
        private System.Windows.Forms.PictureBox point;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label point_text;
        private System.Windows.Forms.Label coin_text;
        private System.Windows.Forms.Label exp_text;
        private System.Windows.Forms.Label level_text;
        private System.Windows.Forms.Label alias_text;
        private System.Windows.Forms.Label tier_text;
        private System.Windows.Forms.Label tier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minutes_text;
        private System.Windows.Forms.TextBox hours_text;
    }
}


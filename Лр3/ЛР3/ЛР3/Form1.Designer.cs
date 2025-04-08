namespace ЛР3
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
            this.listBox_groups = new System.Windows.Forms.ListBox();
            this.SelectionPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AddToZakaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.Location = new System.Drawing.Point(24, 50);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.Size = new System.Drawing.Size(120, 95);
            this.listBox_groups.TabIndex = 0;
            // 
            // SelectionPanel_flowLayoutPanel
            // 
            this.SelectionPanel_flowLayoutPanel.Location = new System.Drawing.Point(219, 50);
            this.SelectionPanel_flowLayoutPanel.Name = "SelectionPanel_flowLayoutPanel";
            this.SelectionPanel_flowLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.SelectionPanel_flowLayoutPanel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(489, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 284);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список групп";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заказы";
            // 
            // button_AddToZakaz
            // 
            this.button_AddToZakaz.Location = new System.Drawing.Point(39, 170);
            this.button_AddToZakaz.Name = "button_AddToZakaz";
            this.button_AddToZakaz.Size = new System.Drawing.Size(105, 59);
            this.button_AddToZakaz.TabIndex = 5;
            this.button_AddToZakaz.Text = "Добавить в заказ";
            this.button_AddToZakaz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AddToZakaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectionPanel_flowLayoutPanel);
            this.Controls.Add(this.listBox_groups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.FlowLayoutPanel SelectionPanel_flowLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AddToZakaz;
    }
}


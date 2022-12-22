
namespace WindowsLab2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChangeStyle = new System.Windows.Forms.Button();
            this.buttonRandFunc = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.labelScale = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBtnRoll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBtnRoll);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.buttonChangeColor);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonChangeStyle);
            this.groupBox1.Controls.Add(this.buttonRandFunc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(758, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(96, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 26);
            this.label.TabIndex = 4;
            this.label.Text = "y = x^2";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(59, 304);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(162, 36);
            this.buttonChangeColor.TabIndex = 3;
            this.buttonChangeColor.Text = "Цвет графика";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(59, 193);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 36);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChangeStyle
            // 
            this.buttonChangeStyle.Location = new System.Drawing.Point(59, 363);
            this.buttonChangeStyle.Name = "buttonChangeStyle";
            this.buttonChangeStyle.Size = new System.Drawing.Size(162, 36);
            this.buttonChangeStyle.TabIndex = 2;
            this.buttonChangeStyle.Text = "Изменить стиль";
            this.buttonChangeStyle.UseVisualStyleBackColor = true;
            this.buttonChangeStyle.Click += new System.EventHandler(this.buttonChangeStyle_Click);
            // 
            // buttonRandFunc
            // 
            this.buttonRandFunc.Location = new System.Drawing.Point(59, 134);
            this.buttonRandFunc.Name = "buttonRandFunc";
            this.buttonRandFunc.Size = new System.Drawing.Size(162, 36);
            this.buttonRandFunc.TabIndex = 0;
            this.buttonRandFunc.Text = "Случайная функция";
            this.buttonRandFunc.UseVisualStyleBackColor = true;
            this.buttonRandFunc.Click += new System.EventHandler(this.buttonRandFunc_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelScale);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(758, 632);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScale.Location = new System.Drawing.Point(698, 20);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(41, 15);
            this.labelScale.TabIndex = 0;
            this.labelScale.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkBtnRoll
            // 
            this.checkBtnRoll.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBtnRoll.Location = new System.Drawing.Point(59, 471);
            this.checkBtnRoll.Name = "checkBtnRoll";
            this.checkBtnRoll.Size = new System.Drawing.Size(162, 36);
            this.checkBtnRoll.TabIndex = 5;
            this.checkBtnRoll.Text = "Запустить шарик";
            this.checkBtnRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBtnRoll.UseVisualStyleBackColor = true;
            this.checkBtnRoll.CheckedChanged += new System.EventHandler(this.checkBtnRoll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 632);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "График";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRandFunc;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonChangeStyle;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelScale;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBtnRoll;
    }
}


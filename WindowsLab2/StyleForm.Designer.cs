
namespace WindowsLab2
{
    partial class StyleForm
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
            this.buttonStyleAxis = new System.Windows.Forms.Button();
            this.buttonStyleGrid = new System.Windows.Forms.Button();
            this.buttonStyleTrig = new System.Windows.Forms.Button();
            this.buttonStyleColor = new System.Windows.Forms.Button();
            this.buttonStyleGradient = new System.Windows.Forms.Button();
            this.buttonStyleClose = new System.Windows.Forms.Button();
            this.buttonStyleReset = new System.Windows.Forms.Button();
            this.labelStyleAxis = new System.Windows.Forms.Label();
            this.labelStyleGrid = new System.Windows.Forms.Label();
            this.labelStyleNumbers = new System.Windows.Forms.Label();
            this.trackBarGradAngle = new System.Windows.Forms.TrackBar();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.buttonAxisColor = new System.Windows.Forms.Button();
            this.buttonGridColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStyleAxis
            // 
            this.buttonStyleAxis.Location = new System.Drawing.Point(32, 24);
            this.buttonStyleAxis.Name = "buttonStyleAxis";
            this.buttonStyleAxis.Size = new System.Drawing.Size(127, 24);
            this.buttonStyleAxis.TabIndex = 0;
            this.buttonStyleAxis.Text = "Только оси";
            this.buttonStyleAxis.UseVisualStyleBackColor = true;
            this.buttonStyleAxis.Click += new System.EventHandler(this.buttonStyleAxis_Click);
            // 
            // buttonStyleGrid
            // 
            this.buttonStyleGrid.Location = new System.Drawing.Point(32, 59);
            this.buttonStyleGrid.Name = "buttonStyleGrid";
            this.buttonStyleGrid.Size = new System.Drawing.Size(127, 24);
            this.buttonStyleGrid.TabIndex = 0;
            this.buttonStyleGrid.Text = "Оси + сетка";
            this.buttonStyleGrid.UseVisualStyleBackColor = true;
            this.buttonStyleGrid.Click += new System.EventHandler(this.buttonStyleGrid_Click);
            // 
            // buttonStyleTrig
            // 
            this.buttonStyleTrig.Location = new System.Drawing.Point(32, 94);
            this.buttonStyleTrig.Name = "buttonStyleTrig";
            this.buttonStyleTrig.Size = new System.Drawing.Size(127, 24);
            this.buttonStyleTrig.TabIndex = 0;
            this.buttonStyleTrig.Text = "Оси + сетка (триг.)";
            this.buttonStyleTrig.UseVisualStyleBackColor = true;
            this.buttonStyleTrig.Click += new System.EventHandler(this.buttonStyleTrig_Click);
            // 
            // buttonStyleColor
            // 
            this.buttonStyleColor.Location = new System.Drawing.Point(32, 209);
            this.buttonStyleColor.Name = "buttonStyleColor";
            this.buttonStyleColor.Size = new System.Drawing.Size(127, 24);
            this.buttonStyleColor.TabIndex = 0;
            this.buttonStyleColor.Text = "Цвет фона";
            this.buttonStyleColor.UseVisualStyleBackColor = true;
            this.buttonStyleColor.Click += new System.EventHandler(this.buttonStyleColor_Click);
            // 
            // buttonStyleGradient
            // 
            this.buttonStyleGradient.Location = new System.Drawing.Point(32, 244);
            this.buttonStyleGradient.Name = "buttonStyleGradient";
            this.buttonStyleGradient.Size = new System.Drawing.Size(127, 24);
            this.buttonStyleGradient.TabIndex = 0;
            this.buttonStyleGradient.Text = "Градиент";
            this.buttonStyleGradient.UseVisualStyleBackColor = true;
            this.buttonStyleGradient.Click += new System.EventHandler(this.buttonStyleGradient_Click);
            // 
            // buttonStyleClose
            // 
            this.buttonStyleClose.Location = new System.Drawing.Point(32, 299);
            this.buttonStyleClose.Name = "buttonStyleClose";
            this.buttonStyleClose.Size = new System.Drawing.Size(127, 36);
            this.buttonStyleClose.TabIndex = 0;
            this.buttonStyleClose.Text = "Закрыть";
            this.buttonStyleClose.UseVisualStyleBackColor = true;
            this.buttonStyleClose.Click += new System.EventHandler(this.buttonStyleClose_Click);
            // 
            // buttonStyleReset
            // 
            this.buttonStyleReset.Location = new System.Drawing.Point(193, 299);
            this.buttonStyleReset.Name = "buttonStyleReset";
            this.buttonStyleReset.Size = new System.Drawing.Size(127, 36);
            this.buttonStyleReset.TabIndex = 0;
            this.buttonStyleReset.Text = "Сбросить";
            this.buttonStyleReset.UseVisualStyleBackColor = true;
            this.buttonStyleReset.Click += new System.EventHandler(this.buttonStyleReset_Click);
            // 
            // labelStyleAxis
            // 
            this.labelStyleAxis.AutoSize = true;
            this.labelStyleAxis.Location = new System.Drawing.Point(211, 30);
            this.labelStyleAxis.Name = "labelStyleAxis";
            this.labelStyleAxis.Size = new System.Drawing.Size(59, 13);
            this.labelStyleAxis.TabIndex = 1;
            this.labelStyleAxis.Text = "Цвет осей";
            // 
            // labelStyleGrid
            // 
            this.labelStyleGrid.AutoSize = true;
            this.labelStyleGrid.Location = new System.Drawing.Point(211, 65);
            this.labelStyleGrid.Name = "labelStyleGrid";
            this.labelStyleGrid.Size = new System.Drawing.Size(64, 13);
            this.labelStyleGrid.TabIndex = 1;
            this.labelStyleGrid.Text = "Цвет сетки";
            // 
            // labelStyleNumbers
            // 
            this.labelStyleNumbers.AutoSize = true;
            this.labelStyleNumbers.Location = new System.Drawing.Point(213, 217);
            this.labelStyleNumbers.Name = "labelStyleNumbers";
            this.labelStyleNumbers.Size = new System.Drawing.Size(87, 13);
            this.labelStyleNumbers.TabIndex = 1;
            this.labelStyleNumbers.Text = "Угол градиента";
            // 
            // trackBarGradAngle
            // 
            this.trackBarGradAngle.Location = new System.Drawing.Point(192, 244);
            this.trackBarGradAngle.Name = "trackBarGradAngle";
            this.trackBarGradAngle.Size = new System.Drawing.Size(127, 45);
            this.trackBarGradAngle.TabIndex = 2;
            this.trackBarGradAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGradAngle.Scroll += new System.EventHandler(this.trackBarGradAngle_Scroll);
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCircle.Checked = true;
            this.checkBoxCircle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCircle.Location = new System.Drawing.Point(108, 153);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(143, 17);
            this.checkBoxCircle.TabIndex = 3;
            this.checkBoxCircle.Text = "Единичная окружность";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.CheckedChanged += new System.EventHandler(this.checkBoxCircle_CheckedChanged);
            // 
            // buttonAxisColor
            // 
            this.buttonAxisColor.Location = new System.Drawing.Point(283, 27);
            this.buttonAxisColor.Name = "buttonAxisColor";
            this.buttonAxisColor.Size = new System.Drawing.Size(18, 18);
            this.buttonAxisColor.TabIndex = 4;
            this.buttonAxisColor.UseVisualStyleBackColor = true;
            this.buttonAxisColor.Click += new System.EventHandler(this.buttonAxisColor_Click);
            // 
            // buttonGridColor
            // 
            this.buttonGridColor.Location = new System.Drawing.Point(283, 62);
            this.buttonGridColor.Name = "buttonGridColor";
            this.buttonGridColor.Size = new System.Drawing.Size(18, 18);
            this.buttonGridColor.TabIndex = 4;
            this.buttonGridColor.UseVisualStyleBackColor = true;
            this.buttonGridColor.Click += new System.EventHandler(this.buttonGridColor_Click);
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 357);
            this.Controls.Add(this.buttonGridColor);
            this.Controls.Add(this.buttonAxisColor);
            this.Controls.Add(this.checkBoxCircle);
            this.Controls.Add(this.trackBarGradAngle);
            this.Controls.Add(this.labelStyleNumbers);
            this.Controls.Add(this.labelStyleGrid);
            this.Controls.Add(this.labelStyleAxis);
            this.Controls.Add(this.buttonStyleReset);
            this.Controls.Add(this.buttonStyleClose);
            this.Controls.Add(this.buttonStyleGradient);
            this.Controls.Add(this.buttonStyleColor);
            this.Controls.Add(this.buttonStyleTrig);
            this.Controls.Add(this.buttonStyleGrid);
            this.Controls.Add(this.buttonStyleAxis);
            this.Name = "StyleForm";
            this.Text = "Стиль";
            this.Load += new System.EventHandler(this.StyleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStyleAxis;
        private System.Windows.Forms.Button buttonStyleGrid;
        private System.Windows.Forms.Button buttonStyleTrig;
        private System.Windows.Forms.Button buttonStyleColor;
        private System.Windows.Forms.Button buttonStyleGradient;
        private System.Windows.Forms.Button buttonStyleClose;
        private System.Windows.Forms.Button buttonStyleReset;
        private System.Windows.Forms.Label labelStyleAxis;
        private System.Windows.Forms.Label labelStyleGrid;
        private System.Windows.Forms.Label labelStyleNumbers;
        private System.Windows.Forms.TrackBar trackBarGradAngle;
        private System.Windows.Forms.CheckBox checkBoxCircle;
        private System.Windows.Forms.Button buttonAxisColor;
        private System.Windows.Forms.Button buttonGridColor;
    }
}
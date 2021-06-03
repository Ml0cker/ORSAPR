
namespace OrsaprBedUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBuildBed = new System.Windows.Forms.Button();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.labelThickness = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuildBed
            // 
            this.buttonBuildBed.Location = new System.Drawing.Point(231, 261);
            this.buttonBuildBed.Name = "buttonBuildBed";
            this.buttonBuildBed.Size = new System.Drawing.Size(162, 29);
            this.buttonBuildBed.TabIndex = 0;
            this.buttonBuildBed.Text = "Начертить кровать";
            this.buttonBuildBed.UseVisualStyleBackColor = true;
            this.buttonBuildBed.Click += new System.EventHandler(this.buttonBuildBed_Click);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(41, 43);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(275, 20);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "Длина кровати L (от 1800 до 2100 мм):";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(568, 36);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(125, 27);
            this.textBoxLength.TabIndex = 2;
            this.textBoxLength.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(568, 73);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(125, 27);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(41, 80);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(290, 20);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Ширина кровати S (от 1000 до 2100 мм):";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(568, 111);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(125, 27);
            this.textBoxHeight.TabIndex = 6;
            this.textBoxHeight.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(41, 118);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(277, 20);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Высота кровати H (от 400 до 1200 мм):";
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(568, 156);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(125, 27);
            this.textBoxThickness.TabIndex = 12;
            this.textBoxThickness.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(41, 163);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(337, 20);
            this.labelThickness.TabIndex = 11;
            this.labelThickness.Text = "Толщина материала корпуса w (от 8 до 14 мм):";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(568, 198);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(125, 27);
            this.textBoxDistance.TabIndex = 14;
            this.textBoxDistance.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(41, 205);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(493, 20);
            this.labelDistance.TabIndex = 13;
            this.labelDistance.Text = "Расстояние от каркаса до верхней части кровати h (от 100 до 250мм):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 302);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.textBoxThickness);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.buttonBuildBed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Плагин Кровать";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuildBed;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelDistance;
    }
}


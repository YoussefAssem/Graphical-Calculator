﻿namespace DarkDemo
{
    partial class MatrixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.rowTxtBox = new System.Windows.Forms.TextBox();
            this.rowLbl = new System.Windows.Forms.Button();
            this.columnLbl = new System.Windows.Forms.Button();
            this.columnTxtBox = new System.Windows.Forms.TextBox();
            this.makeMatrixBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.mainTxt = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.transposeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transposeBtn);
            this.panel1.Controls.Add(this.multiplyBtn);
            this.panel1.Controls.Add(this.minusBtn);
            this.panel1.Controls.Add(this.plusBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 724);
            this.panel1.TabIndex = 2;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.FlatAppearance.BorderSize = 0;
            this.multiplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.ForeColor = System.Drawing.Color.White;
            this.multiplyBtn.Image = ((System.Drawing.Image)(resources.GetObject("multiplyBtn.Image")));
            this.multiplyBtn.Location = new System.Drawing.Point(0, 534);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(140, 187);
            this.multiplyBtn.TabIndex = 7;
            this.multiplyBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.White;
            this.minusBtn.Image = ((System.Drawing.Image)(resources.GetObject("minusBtn.Image")));
            this.minusBtn.Location = new System.Drawing.Point(0, 350);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(140, 178);
            this.minusBtn.TabIndex = 6;
            this.minusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.Image = ((System.Drawing.Image)(resources.GetObject("plusBtn.Image")));
            this.plusBtn.Location = new System.Drawing.Point(0, 154);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(140, 190);
            this.plusBtn.TabIndex = 5;
            this.plusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.plusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // rowTxtBox
            // 
            this.rowTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rowTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rowTxtBox.Location = new System.Drawing.Point(411, 132);
            this.rowTxtBox.Name = "rowTxtBox";
            this.rowTxtBox.Size = new System.Drawing.Size(62, 20);
            this.rowTxtBox.TabIndex = 1;
            // 
            // rowLbl
            // 
            this.rowLbl.FlatAppearance.BorderSize = 0;
            this.rowLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rowLbl.Location = new System.Drawing.Point(284, 128);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(72, 27);
            this.rowLbl.TabIndex = 5;
            this.rowLbl.Text = "Row";
            this.rowLbl.UseVisualStyleBackColor = true;
            // 
            // columnLbl
            // 
            this.columnLbl.FlatAppearance.BorderSize = 0;
            this.columnLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.columnLbl.Location = new System.Drawing.Point(739, 128);
            this.columnLbl.Name = "columnLbl";
            this.columnLbl.Size = new System.Drawing.Size(72, 27);
            this.columnLbl.TabIndex = 6;
            this.columnLbl.Text = "Column";
            this.columnLbl.UseVisualStyleBackColor = true;
            // 
            // columnTxtBox
            // 
            this.columnTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.columnTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.columnTxtBox.Location = new System.Drawing.Point(873, 132);
            this.columnTxtBox.Name = "columnTxtBox";
            this.columnTxtBox.Size = new System.Drawing.Size(62, 20);
            this.columnTxtBox.TabIndex = 2;
            // 
            // makeMatrixBtn
            // 
            this.makeMatrixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeMatrixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeMatrixBtn.Location = new System.Drawing.Point(1030, 122);
            this.makeMatrixBtn.Name = "makeMatrixBtn";
            this.makeMatrixBtn.Size = new System.Drawing.Size(153, 38);
            this.makeMatrixBtn.TabIndex = 3;
            this.makeMatrixBtn.Text = "Make Matrix";
            this.makeMatrixBtn.UseVisualStyleBackColor = true;
            this.makeMatrixBtn.Click += new System.EventHandler(this.makeMatrix_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1030, 280);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save Matrix";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splitter2
            // 
            this.splitter2.AutoSize = true;
            this.splitter2.Location = new System.Drawing.Point(252, 181);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(931, 13);
            this.splitter2.TabIndex = 9;
            this.splitter2.Text = "_________________________________________________________________________________" +
    "_________________________________________________________________________";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.splitter1.Location = new System.Drawing.Point(140, 76);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 724);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // resetBtn
            // 
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(1030, 750);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(153, 38);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Reset Matrix";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Controls.Add(this.mainTxt);
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 76);
            this.panel3.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(7, 2);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(93, 70);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click_1);
            // 
            // mainTxt
            // 
            this.mainTxt.AutoSize = true;
            this.mainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTxt.Location = new System.Drawing.Point(105, 2);
            this.mainTxt.Name = "mainTxt";
            this.mainTxt.Size = new System.Drawing.Size(212, 73);
            this.mainTxt.TabIndex = 7;
            this.mainTxt.Text = "Matrix";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1198, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 26);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = " X ";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // transposeBtn
            // 
            this.transposeBtn.FlatAppearance.BorderSize = 0;
            this.transposeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transposeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transposeBtn.ForeColor = System.Drawing.Color.White;
            this.transposeBtn.Image = ((System.Drawing.Image)(resources.GetObject("transposeBtn.Image")));
            this.transposeBtn.Location = new System.Drawing.Point(0, 6);
            this.transposeBtn.Name = "transposeBtn";
            this.transposeBtn.Size = new System.Drawing.Size(140, 142);
            this.transposeBtn.TabIndex = 8;
            this.transposeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.transposeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transposeBtn.UseVisualStyleBackColor = true;
            this.transposeBtn.Click += new System.EventHandler(this.transposeBtn_Click);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.makeMatrixBtn);
            this.Controls.Add(this.columnTxtBox);
            this.Controls.Add(this.columnLbl);
            this.Controls.Add(this.rowLbl);
            this.Controls.Add(this.rowTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatrixForm";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.MatrixForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.TextBox rowTxtBox;
        private System.Windows.Forms.Button rowLbl;
        private System.Windows.Forms.Button columnLbl;
        private System.Windows.Forms.TextBox columnTxtBox;
        private System.Windows.Forms.Button makeMatrixBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label mainTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button transposeBtn;
    }
}
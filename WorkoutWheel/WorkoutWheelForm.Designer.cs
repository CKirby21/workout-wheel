﻿
namespace WorkoutWheel
{
    partial class WorkoutWheelForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.timerRotation = new System.Windows.Forms.Timer(this.components);
            this.textBoxWorkout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.circlePictureBox1 = new WorkoutWheel.CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.Location = new System.Drawing.Point(522, 361);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(83, 53);
            this.buttonSpin.TabIndex = 1;
            this.buttonSpin.Text = "Spin!";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // timerRotation
            // 
            this.timerRotation.Tick += new System.EventHandler(this.timerRotation_Tick);
            // 
            // textBoxWorkout
            // 
            this.textBoxWorkout.Location = new System.Drawing.Point(17, 41);
            this.textBoxWorkout.Name = "textBoxWorkout";
            this.textBoxWorkout.Size = new System.Drawing.Size(237, 20);
            this.textBoxWorkout.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Workout(s):";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(18, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 53);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.toolTip.SetToolTip(this.buttonAdd, "Add one or multiple workouts seperated by commas.");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(135, 67);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(119, 53);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.toolTip.SetToolTip(this.buttonRemove, "Remove one or multiple workouts seperated by commas.");
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(518, 96);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 4;
            this.labelResult.Visible = false;
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.circlePictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Eight-colour-wheel-2D.p" +
    "ng/769px-Eight-colour-wheel-2D.png";
            this.circlePictureBox1.Location = new System.Drawing.Point(173, 6);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(764, 764);
            this.circlePictureBox1.TabIndex = 0;
            this.circlePictureBox1.TabStop = false;
            // 
            // WorkoutWheelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 782);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWorkout);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.circlePictureBox1);
            this.Name = "WorkoutWheelForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CirclePictureBox circlePictureBox1;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Timer timerRotation;
        private System.Windows.Forms.TextBox textBoxWorkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ToolTip toolTip;
    }
}


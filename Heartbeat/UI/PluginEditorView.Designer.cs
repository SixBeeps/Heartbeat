
namespace Heartbeat.UI {
    partial class PluginEditorView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tensionTbar = new System.Windows.Forms.TrackBar();
            this.tensionLabel = new System.Windows.Forms.Label();
            this.pumpAmtTbar = new System.Windows.Forms.TrackBar();
            this.pumpAmtUnit = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.beatDivLabel = new System.Windows.Forms.Label();
            this.directionTbar = new System.Windows.Forms.TrackBar();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pumpAmtLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.beatDivBox = new System.Windows.Forms.NumericUpDown();
            this.beatMultBox = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensionTbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpAmtTbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionTbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beatDivBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beatMultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.tensionTbar, 1, 4);
            tableLayoutPanel1.Controls.Add(this.tensionLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(this.pumpAmtTbar, 1, 3);
            tableLayoutPanel1.Controls.Add(this.pumpAmtUnit, 2, 3);
            tableLayoutPanel1.Controls.Add(this.directionLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(this.beatDivLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(this.directionTbar, 1, 5);
            tableLayoutPanel1.Controls.Add(this.aboutBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(this.pumpAmtLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 6);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(284, 272);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Heartbeat.Properties.Resources.logo1;
            this.pictureBox1.Image = global::Heartbeat.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tensionTbar
            // 
            this.tensionTbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tensionTbar.Location = new System.Drawing.Point(78, 129);
            this.tensionTbar.Name = "tensionTbar";
            this.tensionTbar.Size = new System.Drawing.Size(128, 45);
            this.tensionTbar.TabIndex = 4;
            // 
            // tensionLabel
            // 
            this.tensionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tensionLabel.AutoSize = true;
            this.tensionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tensionLabel.Location = new System.Drawing.Point(25, 144);
            this.tensionLabel.Name = "tensionLabel";
            this.tensionLabel.Size = new System.Drawing.Size(47, 15);
            this.tensionLabel.TabIndex = 3;
            this.tensionLabel.Text = "Tension";
            this.tensionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pumpAmtTbar
            // 
            this.pumpAmtTbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pumpAmtTbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pumpAmtTbar.Location = new System.Drawing.Point(78, 78);
            this.pumpAmtTbar.Name = "pumpAmtTbar";
            this.pumpAmtTbar.Size = new System.Drawing.Size(128, 45);
            this.pumpAmtTbar.TabIndex = 1;
            this.pumpAmtTbar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pumpAmtUnit
            // 
            this.pumpAmtUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pumpAmtUnit.AutoSize = true;
            this.pumpAmtUnit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pumpAmtUnit.Location = new System.Drawing.Point(212, 93);
            this.pumpAmtUnit.Name = "pumpAmtUnit";
            this.pumpAmtUnit.Size = new System.Drawing.Size(16, 15);
            this.pumpAmtUnit.TabIndex = 2;
            this.pumpAmtUnit.Text = "L.";
            // 
            // directionLabel
            // 
            this.directionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.directionLabel.AutoSize = true;
            this.directionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.directionLabel.Location = new System.Drawing.Point(17, 187);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(55, 30);
            this.directionLabel.TabIndex = 8;
            this.directionLabel.Text = "Direction Mode";
            this.directionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // beatDivLabel
            // 
            this.beatDivLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.beatDivLabel.AutoSize = true;
            this.beatDivLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.beatDivLabel.Location = new System.Drawing.Point(15, 231);
            this.beatDivLabel.Name = "beatDivLabel";
            this.beatDivLabel.Size = new System.Drawing.Size(57, 30);
            this.beatDivLabel.TabIndex = 10;
            this.beatDivLabel.Text = "Beat Snapping";
            this.beatDivLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // directionTbar
            // 
            this.directionTbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.directionTbar.Location = new System.Drawing.Point(78, 180);
            this.directionTbar.Name = "directionTbar";
            this.directionTbar.Size = new System.Drawing.Size(54, 45);
            this.directionTbar.TabIndex = 9;
            this.directionTbar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.Location = new System.Drawing.Point(252, 11);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(21, 23);
            this.aboutBtn.TabIndex = 12;
            this.aboutBtn.Text = "?";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Heartbeat.Properties.Resources.title;
            this.pictureBox2.Location = new System.Drawing.Point(78, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pumpAmtLabel
            // 
            this.pumpAmtLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pumpAmtLabel.AutoSize = true;
            this.pumpAmtLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pumpAmtLabel.Location = new System.Drawing.Point(21, 85);
            this.pumpAmtLabel.Name = "pumpAmtLabel";
            this.pumpAmtLabel.Size = new System.Drawing.Size(51, 30);
            this.pumpAmtLabel.TabIndex = 0;
            this.pumpAmtLabel.Text = "Pump Amount";
            this.pumpAmtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.beatDivBox);
            this.flowLayoutPanel1.Controls.Add(this.beatMultBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 228);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 36);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // beatDivBox
            // 
            this.beatDivBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.beatDivBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beatDivBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beatDivBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.beatDivBox.Location = new System.Drawing.Point(7, 7);
            this.beatDivBox.Name = "beatDivBox";
            this.beatDivBox.Size = new System.Drawing.Size(51, 19);
            this.beatDivBox.TabIndex = 11;
            this.beatDivBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // beatMultBox
            // 
            this.beatMultBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.beatMultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beatMultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beatMultBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.beatMultBox.Location = new System.Drawing.Point(64, 7);
            this.beatMultBox.Name = "beatMultBox";
            this.beatMultBox.Size = new System.Drawing.Size(51, 19);
            this.beatMultBox.TabIndex = 12;
            this.beatMultBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PluginEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::Heartbeat.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PluginEditorView";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(300, 288);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensionTbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpAmtTbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionTbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beatDivBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beatMultBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar pumpAmtTbar;
        private System.Windows.Forms.Label pumpAmtLabel;
        private System.Windows.Forms.Label pumpAmtUnit;
        private System.Windows.Forms.Label tensionLabel;
        private System.Windows.Forms.TrackBar tensionTbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.TrackBar directionTbar;
        private System.Windows.Forms.Label beatDivLabel;
        private System.Windows.Forms.NumericUpDown beatDivBox;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown beatMultBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

namespace UniqueCodeCreator
{
    partial class FormMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelPrefix = new Label();
            labelSufix = new Label();
            labelCount = new Label();
            textBoxSufix = new TextBox();
            textBoxPrefix = new TextBox();
            numericUpDownCount = new NumericUpDown();
            labelLength = new Label();
            numericUpDownLength = new NumericUpDown();
            checkBoxNumbersOnly = new CheckBox();
            buttonGenerate = new Button();
            buttonSaveFile = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBoxResult = new TextBox();
            buttonCopy = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonGenerate, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSaveFile, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(461, 228);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(checkBoxNumbersOnly, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(224, 192);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelPrefix, 0, 0);
            tableLayoutPanel3.Controls.Add(labelSufix, 0, 1);
            tableLayoutPanel3.Controls.Add(labelCount, 0, 2);
            tableLayoutPanel3.Controls.Add(textBoxSufix, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxPrefix, 1, 0);
            tableLayoutPanel3.Controls.Add(numericUpDownCount, 1, 2);
            tableLayoutPanel3.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel3.Controls.Add(numericUpDownLength, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(218, 156);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelPrefix
            // 
            labelPrefix.Anchor = AnchorStyles.Right;
            labelPrefix.AutoSize = true;
            labelPrefix.Location = new Point(41, 12);
            labelPrefix.Name = "labelPrefix";
            labelPrefix.Size = new Size(36, 15);
            labelPrefix.TabIndex = 0;
            labelPrefix.Text = "Prefix";
            // 
            // labelSufix
            // 
            labelSufix.Anchor = AnchorStyles.Right;
            labelSufix.AutoSize = true;
            labelSufix.Location = new Point(45, 52);
            labelSufix.Name = "labelSufix";
            labelSufix.Size = new Size(32, 15);
            labelSufix.TabIndex = 1;
            labelSufix.Text = "Sufix";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Right;
            labelCount.AutoSize = true;
            labelCount.Location = new Point(37, 92);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(40, 15);
            labelCount.TabIndex = 2;
            labelCount.Text = "Count";
            // 
            // textBoxSufix
            // 
            textBoxSufix.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSufix.Location = new Point(83, 48);
            textBoxSufix.Name = "textBoxSufix";
            textBoxSufix.Size = new Size(132, 23);
            textBoxSufix.TabIndex = 3;
            // 
            // textBoxPrefix
            // 
            textBoxPrefix.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrefix.Location = new Point(83, 8);
            textBoxPrefix.Name = "textBoxPrefix";
            textBoxPrefix.Size = new Size(132, 23);
            textBoxPrefix.TabIndex = 4;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownCount.Location = new Point(83, 88);
            numericUpDownCount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(132, 23);
            numericUpDownCount.TabIndex = 5;
            numericUpDownCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelLength
            // 
            labelLength.Anchor = AnchorStyles.Right;
            labelLength.AutoSize = true;
            labelLength.Location = new Point(33, 132);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(44, 15);
            labelLength.TabIndex = 6;
            labelLength.Text = "Length";
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownLength.Location = new Point(83, 128);
            numericUpDownLength.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(132, 23);
            numericUpDownLength.TabIndex = 7;
            numericUpDownLength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // checkBoxNumbersOnly
            // 
            checkBoxNumbersOnly.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            checkBoxNumbersOnly.AutoSize = true;
            checkBoxNumbersOnly.Location = new Point(60, 165);
            checkBoxNumbersOnly.Name = "checkBoxNumbersOnly";
            checkBoxNumbersOnly.Size = new Size(103, 24);
            checkBoxNumbersOnly.TabIndex = 1;
            checkBoxNumbersOnly.Text = "Numbers Only";
            checkBoxNumbersOnly.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonGenerate.AutoSize = true;
            buttonGenerate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonGenerate.Location = new Point(83, 201);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(64, 24);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonSaveFile.AutoSize = true;
            buttonSaveFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSaveFile.Location = new Point(307, 201);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(76, 24);
            buttonSaveFile.TabIndex = 1;
            buttonSaveFile.Text = "Save to File";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(textBoxResult, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCopy, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(233, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.Size = new Size(225, 192);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 3);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(219, 156);
            textBoxResult.TabIndex = 0;
            // 
            // buttonCopy
            // 
            buttonCopy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonCopy.AutoSize = true;
            buttonCopy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCopy.Location = new Point(90, 165);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(45, 24);
            buttonCopy.TabIndex = 1;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 228);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Unique Code Creator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelPrefix;
        private Label labelSufix;
        private Label labelCount;
        private TextBox textBoxSufix;
        private TextBox textBoxPrefix;
        private NumericUpDown numericUpDownCount;
        private Button buttonGenerate;
        private Button buttonSaveFile;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBoxResult;
        private Button buttonCopy;
        private Label labelLength;
        private NumericUpDown numericUpDownLength;
        private CheckBox checkBoxNumbersOnly;
    }
}

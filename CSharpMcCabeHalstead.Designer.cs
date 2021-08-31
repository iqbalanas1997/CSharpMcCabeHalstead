
namespace CSharpMcCabeHalstead
{
    partial class CSharpMcCabeHalstead
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mcCabeButton = new System.Windows.Forms.Button();
            this.cyclomaticComplexityLabel = new System.Windows.Forms.Label();
            this.halsteadButton = new System.Windows.Forms.Button();
            this.totalNumberOfOperatorsLabel = new System.Windows.Forms.Label();
            this.numberOfDistinctOperatorsLabel = new System.Windows.Forms.Label();
            this.totalNumberOfOperandsLabel = new System.Windows.Forms.Label();
            this.numberOfDistinctOperandsLabel = new System.Windows.Forms.Label();
            this.programVocabularyLabel = new System.Windows.Forms.Label();
            this.programLengthLabel = new System.Windows.Forms.Label();
            this.programVolumeLabel = new System.Windows.Forms.Label();
            this.mcCabeMetricLabel = new System.Windows.Forms.Label();
            this.halsteadMetricLabel = new System.Windows.Forms.Label();
            this.programDifficultyLabel = new System.Windows.Forms.Label();
            this.programEffortLabel = new System.Windows.Forms.Label();
            this.programErrorLabel = new System.Windows.Forms.Label();
            this.PlotGraph = new System.Windows.Forms.Button();
            
            this.sourceCodeTextBox = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1122, 25);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "C# source file (*.cs)|*.cs";
            this.openFileDialog.InitialDirectory = "d:\\Education\\Subjects\\3 Курс\\5 Семестр\\Предметы\\МССвИР\\LP\\Лабораторная работа №2\\" +
    "LAB2\\RubyMcCabeHalstead\\";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "C# source file (*.cs)|*.cs";
            this.saveFileDialog.InitialDirectory = "d:\\Education\\Subjects\\3 Курс\\5 Семестр\\Предметы\\МССвИР\\LP\\Лабораторная работа №2\\" +
    "LAB2\\RubyMcCabeHalstead\\";
            // 
            // mcCabeButton
            // 
            this.mcCabeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcCabeButton.Location = new System.Drawing.Point(700, 30);
            this.mcCabeButton.Name = "mcCabeButton";
            this.mcCabeButton.Size = new System.Drawing.Size(100, 23);
            this.mcCabeButton.TabIndex = 3;
            this.mcCabeButton.Text = "McCabe";
            this.mcCabeButton.UseVisualStyleBackColor = true;
            this.mcCabeButton.Click += new System.EventHandler(this.mcCabeButton_Click);
            // 
            // cyclomaticComplexityLabel
            // 
            this.cyclomaticComplexityLabel.AutoSize = true;
            this.cyclomaticComplexityLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclomaticComplexityLabel.Location = new System.Drawing.Point(606, 80);
            this.cyclomaticComplexityLabel.Name = "cyclomaticComplexityLabel";
            this.cyclomaticComplexityLabel.Size = new System.Drawing.Size(231, 16);
            this.cyclomaticComplexityLabel.TabIndex = 4;
            this.cyclomaticComplexityLabel.Text = "The cyclomatic complexity of a program: ";
            // 
            // halsteadButton
            // 
            this.halsteadButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halsteadButton.Location = new System.Drawing.Point(880, 30);
            this.halsteadButton.Name = "halsteadButton";
            this.halsteadButton.Size = new System.Drawing.Size(100, 23);
            this.halsteadButton.TabIndex = 5;
            this.halsteadButton.Text = "Halstead";
            this.halsteadButton.UseVisualStyleBackColor = true;
            this.halsteadButton.Click += new System.EventHandler(this.halsteadButton_Click);
            // 
            // totalNumberOfOperatorsLabel
            // 
            this.totalNumberOfOperatorsLabel.AutoSize = true;
            this.totalNumberOfOperatorsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberOfOperatorsLabel.Location = new System.Drawing.Point(606, 170);
            this.totalNumberOfOperatorsLabel.Name = "totalNumberOfOperatorsLabel";
            this.totalNumberOfOperatorsLabel.Size = new System.Drawing.Size(173, 16);
            this.totalNumberOfOperatorsLabel.TabIndex = 6;
            this.totalNumberOfOperatorsLabel.Text = "The total number of operators: ";
            // 
            // numberOfDistinctOperatorsLabel
            // 
            this.numberOfDistinctOperatorsLabel.AutoSize = true;
            this.numberOfDistinctOperatorsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDistinctOperatorsLabel.Location = new System.Drawing.Point(606, 120);
            this.numberOfDistinctOperatorsLabel.Name = "numberOfDistinctOperatorsLabel";
            this.numberOfDistinctOperatorsLabel.Size = new System.Drawing.Size(186, 16);
            this.numberOfDistinctOperatorsLabel.TabIndex = 7;
            this.numberOfDistinctOperatorsLabel.Text = "The number of distinct operators: ";
            // 
            // totalNumberOfOperandsLabel
            // 
            this.totalNumberOfOperandsLabel.AutoSize = true;
            this.totalNumberOfOperandsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberOfOperandsLabel.Location = new System.Drawing.Point(606, 190);
            this.totalNumberOfOperandsLabel.Name = "totalNumberOfOperandsLabel";
            this.totalNumberOfOperandsLabel.Size = new System.Drawing.Size(171, 16);
            this.totalNumberOfOperandsLabel.TabIndex = 8;
            this.totalNumberOfOperandsLabel.Text = "The total number of operands:";
            // 
            // numberOfDistinctOperandsLabel
            // 
            this.numberOfDistinctOperandsLabel.AutoSize = true;
            this.numberOfDistinctOperandsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDistinctOperandsLabel.Location = new System.Drawing.Point(606, 140);
            this.numberOfDistinctOperandsLabel.Name = "numberOfDistinctOperandsLabel";
            this.numberOfDistinctOperandsLabel.Size = new System.Drawing.Size(187, 16);
            this.numberOfDistinctOperandsLabel.TabIndex = 9;
            this.numberOfDistinctOperandsLabel.Text = "The number of distinct operands: ";
            // 
            // programVocabularyLabel
            // 
            this.programVocabularyLabel.AutoSize = true;
            this.programVocabularyLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programVocabularyLabel.Location = new System.Drawing.Point(606, 220);
            this.programVocabularyLabel.Name = "programVocabularyLabel";
            this.programVocabularyLabel.Size = new System.Drawing.Size(149, 16);
            this.programVocabularyLabel.TabIndex = 11;
            this.programVocabularyLabel.Text = "The program vocabulary: ";
            // 
            // programLengthLabel
            // 
            this.programLengthLabel.AutoSize = true;
            this.programLengthLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLengthLabel.Location = new System.Drawing.Point(606, 240);
            this.programLengthLabel.Name = "programLengthLabel";
            this.programLengthLabel.Size = new System.Drawing.Size(119, 16);
            this.programLengthLabel.TabIndex = 12;
            this.programLengthLabel.Text = "The program length: ";
            // 
            // programVolumeLabel
            // 
            this.programVolumeLabel.AutoSize = true;
            this.programVolumeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programVolumeLabel.Location = new System.Drawing.Point(606, 260);
            this.programVolumeLabel.Name = "programVolumeLabel";
            this.programVolumeLabel.Size = new System.Drawing.Size(126, 16);
            this.programVolumeLabel.TabIndex = 13;
            this.programVolumeLabel.Text = "The program volume: ";
            // 
            // mcCabeMetricLabel
            // 
            this.mcCabeMetricLabel.AutoSize = true;
            this.mcCabeMetricLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcCabeMetricLabel.Location = new System.Drawing.Point(800, 60);
            this.mcCabeMetricLabel.Name = "mcCabeMetricLabel";
            this.mcCabeMetricLabel.Size = new System.Drawing.Size(92, 15);
            this.mcCabeMetricLabel.TabIndex = 14;
            this.mcCabeMetricLabel.Text = "McCabe metric:";
            // 
            // halsteadMetricLabel
            // 
            this.halsteadMetricLabel.AutoSize = true;
            this.halsteadMetricLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halsteadMetricLabel.Location = new System.Drawing.Point(800, 100);
            this.halsteadMetricLabel.Name = "halsteadMetricLabel";
            this.halsteadMetricLabel.Size = new System.Drawing.Size(93, 15);
            this.halsteadMetricLabel.TabIndex = 15;
            this.halsteadMetricLabel.Text = "Halstead metric:";
            // 
            // programDifficultyLabel
            // 
            this.programDifficultyLabel.AutoSize = true;
            this.programDifficultyLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programDifficultyLabel.Location = new System.Drawing.Point(606, 280);
            this.programDifficultyLabel.Name = "programDifficultyLabel";
            this.programDifficultyLabel.Size = new System.Drawing.Size(129, 16);
            this.programDifficultyLabel.TabIndex = 23;
            this.programDifficultyLabel.Text = "The program difficulty: ";
            // 
            // programEffortLabel
            // 
            this.programEffortLabel.AutoSize = true;
            this.programEffortLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programEffortLabel.Location = new System.Drawing.Point(606, 300);
            this.programEffortLabel.Name = "programEffortLabel";
            this.programEffortLabel.Size = new System.Drawing.Size(112, 16);
            this.programEffortLabel.TabIndex = 24;
            this.programEffortLabel.Text = "The program effort: ";
            // 
            // programErrorLabel
            // 
            this.programErrorLabel.AutoSize = true;
            this.programErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programErrorLabel.Location = new System.Drawing.Point(606, 319);
            this.programErrorLabel.Name = "programErrorLabel";
            this.programErrorLabel.Size = new System.Drawing.Size(112, 16);
            this.programErrorLabel.TabIndex = 25;
            this.programErrorLabel.Text = "The program errors: ";
            // 
            // PlotGraph
            // 
            this.PlotGraph.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotGraph.Location = new System.Drawing.Point(983, 343);
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Size = new System.Drawing.Size(100, 23);
            this.PlotGraph.TabIndex = 27;
            this.PlotGraph.Text = "Plot";
            this.PlotGraph.UseVisualStyleBackColor = true;
            this.PlotGraph.Click += new System.EventHandler(this.PlotGraph_Click);
            
            
            // 
            // sourceCodeTextBox
            // 
            this.sourceCodeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceCodeTextBox.Location = new System.Drawing.Point(0, 25);
            this.sourceCodeTextBox.MaxLength = 2147483647;
            this.sourceCodeTextBox.Multiline = true;
            this.sourceCodeTextBox.Name = "sourceCodeTextBox";
            this.sourceCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceCodeTextBox.Size = new System.Drawing.Size(600, 656);
            this.sourceCodeTextBox.TabIndex = 1;
            this.sourceCodeTextBox.TextChanged += new System.EventHandler(this.sourceCodeTextBox_TextChanged);
            this.sourceCodeTextBox.DoubleClick += new System.EventHandler(this.sourceCodeTextBox_DoubleClick);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(1035, 30);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 30;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // CSharpMcCabeHalstead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1122, 681);
            this.Controls.Add(this.Refresh);
            
            this.Controls.Add(this.PlotGraph);
            this.Controls.Add(this.programErrorLabel);
            this.Controls.Add(this.programEffortLabel);
            this.Controls.Add(this.programDifficultyLabel);
            this.Controls.Add(this.halsteadMetricLabel);
            this.Controls.Add(this.mcCabeMetricLabel);
            this.Controls.Add(this.programVolumeLabel);
            this.Controls.Add(this.programLengthLabel);
            this.Controls.Add(this.programVocabularyLabel);
            this.Controls.Add(this.numberOfDistinctOperandsLabel);
            this.Controls.Add(this.totalNumberOfOperandsLabel);
            this.Controls.Add(this.numberOfDistinctOperatorsLabel);
            this.Controls.Add(this.totalNumberOfOperatorsLabel);
            this.Controls.Add(this.halsteadButton);
            this.Controls.Add(this.cyclomaticComplexityLabel);
            this.Controls.Add(this.mcCabeButton);
            this.Controls.Add(this.sourceCodeTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "CSharpMcCabeHalstead";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# analysis by McCabe and Halstead metrics";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button mcCabeButton;
        private System.Windows.Forms.Label cyclomaticComplexityLabel;
        private System.Windows.Forms.Button halsteadButton;
        private System.Windows.Forms.Label totalNumberOfOperatorsLabel;
        private System.Windows.Forms.Label numberOfDistinctOperatorsLabel;
        private System.Windows.Forms.Label totalNumberOfOperandsLabel;
        private System.Windows.Forms.Label numberOfDistinctOperandsLabel;
        private System.Windows.Forms.Label programVocabularyLabel;
        private System.Windows.Forms.Label programLengthLabel;
        private System.Windows.Forms.Label programVolumeLabel;
        private System.Windows.Forms.Label mcCabeMetricLabel;
        private System.Windows.Forms.Label halsteadMetricLabel;
        private System.Windows.Forms.Label programDifficultyLabel;
        private System.Windows.Forms.Label programEffortLabel;
        private System.Windows.Forms.Label programErrorLabel;
        private System.Windows.Forms.Button PlotGraph;
        
        private System.Windows.Forms.TextBox sourceCodeTextBox;
        private System.Windows.Forms.Button Refresh;


    }
}
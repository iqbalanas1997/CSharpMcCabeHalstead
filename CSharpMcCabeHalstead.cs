using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace CSharpMcCabeHalstead
{
    public partial class CSharpMcCabeHalstead : Form
    {
        private readonly SourceCodeEditor _sourceCodeEditor = new SourceCodeEditor();
        private const string CyclomaticComplexityText = "The cyclomatic complexity of a program: ";
        private const string TotalNumberOfOperatorsText = "The total number of operators: ";
        private const string TotalNumberOfOperandsText = "The total number of operands: ";
        private const string NumberOfDistinctOperatorsText = "The number of distinct operators: ";
        private const string NumberOfDistrinctOperandsText = "The number of distinct operands: ";
        private const string ProgramVocabularyText = "The program vocabulary: ";
        private const string ProgramLengthText = "The program length: ";
        private const string ProgramVolumeText = "The program volume: ";
        private const string ProgramdifficultyText = "The program difficulty: ";
        private const string ProgrameffortText = "The program effort: ";
        private const string ProgramerrorText = "The program error: ";

        public static int N_operator;
        public static int N_operand;
        public static int D_operator;
        public static int D_operand;

        public CSharpMcCabeHalstead()
        {
            this.InitializeComponent();

            var sourceCode = File.ReadAllText(@"G:\7 semester\VSA by ASIF ALI;  TOOBA;\aftermid\CSharpMcCabeHalstead\Program.cs") + Environment.NewLine;
            sourceCode += File.ReadAllText(@"G:\7 semester\VSA by ASIF ALI;  TOOBA;\aftermid\CSharpMcCabeHalstead\CSharpMcCabeHalstead.cs") + Environment.NewLine;
            sourceCode += File.ReadAllText(@"G:\7 semester\VSA by ASIF ALI;  TOOBA;\aftermid\CSharpMcCabeHalstead\SourceCodeEditor.cs") + Environment.NewLine;
            sourceCode += File.ReadAllText(@"G:\7 semester\VSA by ASIF ALI;  TOOBA;\aftermid\CSharpMcCabeHalstead\McCabe.cs") + Environment.NewLine;
            sourceCode += File.ReadAllText(@"G:\7 semester\VSA by ASIF ALI;  TOOBA;\aftermid\CSharpMcCabeHalstead\Halstead.cs");

            //this.sourceCodeTextBox.Text = this._sourceCodeEditor.RemoveUnnecessaryCharacters(sourceCode);
            if (sourceCodeTextBox.Text == "")
            {
                PlotGraph.Visible = false;
            }
            else
            {
                PlotGraph.Visible = true;
            }

        }

        private void ClearForm()
        {
            this.cyclomaticComplexityLabel.Text = CyclomaticComplexityText;
            this.totalNumberOfOperatorsLabel.Text = TotalNumberOfOperatorsText;
            this.totalNumberOfOperandsLabel.Text = TotalNumberOfOperandsText;
            this.numberOfDistinctOperatorsLabel.Text = NumberOfDistinctOperatorsText;
            this.numberOfDistinctOperandsLabel.Text = NumberOfDistrinctOperandsText;
            this.programVocabularyLabel.Text = ProgramVocabularyText;
            this.programLengthLabel.Text = ProgramLengthText;
            this.programVolumeLabel.Text = ProgramVolumeText;
            this.programDifficultyLabel.Text = ProgramdifficultyText;
            this.programEffortLabel.Text = ProgrameffortText;
            this.programErrorLabel.Text = ProgramerrorText;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sourceCodeTextBox.Clear();
            this.ClearForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._sourceCodeEditor.OpenFromFile(this.openFileDialog, this.sourceCodeTextBox);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SourceCodeEditor.SaveToFile(this.saveFileDialog, this.sourceCodeTextBox);
        }

        private void sourceCodeTextBox_DoubleClick(object sender, EventArgs e)
        {
            this._sourceCodeEditor.OpenFromFile(this.openFileDialog, this.sourceCodeTextBox);
        }

        private void mcCabeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mcCabe = new McCabe(this.sourceCodeTextBox.Text);
                this.cyclomaticComplexityLabel.Text = CyclomaticComplexityText
                    + Convert.ToString(mcCabe.CalculateCyclomaticComplexity());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK);
            }

        }

        private void halsteadButton_Click(object sender, EventArgs e)
        {
            try
            {

                PlotGraph.Visible = true;

                var halstead = new Halstead(this.sourceCodeTextBox.Text);

                this.totalNumberOfOperatorsLabel.Text = TotalNumberOfOperatorsText
                    + Convert.ToString(halstead.CountTotalNumberOfOperators());

                this.numberOfDistinctOperatorsLabel.Text = NumberOfDistinctOperatorsText
                    + Convert.ToString(halstead.CountNumberOfDistinctOperators());

                this.totalNumberOfOperandsLabel.Text = TotalNumberOfOperandsText
                    + Convert.ToString(halstead.CountTotalNumberOfOperands());

                this.numberOfDistinctOperandsLabel.Text = NumberOfDistrinctOperandsText
                    + Convert.ToString(halstead.CountNumberOfDistinctOperands());

                this.programVocabularyLabel.Text = ProgramVocabularyText + Convert.ToString(halstead.CalculateProgramVocabulary());

                this.programLengthLabel.Text = ProgramLengthText + Convert.ToString(halstead.CalculateProgramLength());

                this.programVolumeLabel.Text = ProgramVolumeText + Convert.ToString(halstead.CalculateProgramVolume());

                this.programDifficultyLabel.Text = ProgramdifficultyText + Convert.ToString(halstead.CalculateProgramDifficulty());

                this.programEffortLabel.Text = ProgrameffortText + Convert.ToString(Math.Round(halstead.CalculateProgramEffort()));

                this.programErrorLabel.Text = ProgramerrorText + Convert.ToString(halstead.CalculateProgramErrors());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK);
            }


        }

        private void sourceCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindDistinctOperatorPercentage(int val)
        {
            var halstead = new Halstead(this.sourceCodeTextBox.Text);

            decimal maxval = halstead.CountTotalNumberOfOperators();
            decimal minval = halstead.CountNumberOfDistinctOperators();

            val = Convert.ToInt32(minval);

            //decimal multi = (minval / maxval) * 100;

            //int percent = Convert.ToInt32(Math.Round(multi));

            //label1.Text = "" + minval;

        }


        private void PlotGraph_Click(object sender, EventArgs e)
        {
            plotGraph();
            PlotGraph.Visible = false;
        }

        private void plotGraph()
        {
            try
            {
                var halstead = new Halstead(this.sourceCodeTextBox.Text);

                decimal maxval = halstead.CountTotalNumberOfOperators();
                decimal minval = halstead.CountNumberOfDistinctOperators();

                
                PlotGraph.Visible = false;

            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show(ex.Message + "/n", "Error", MessageBoxButtons.OK);

            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                sourceCodeTextBox.Text = "";
                PlotGraph.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}

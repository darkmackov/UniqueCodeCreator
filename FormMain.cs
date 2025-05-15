namespace UniqueCodeCreator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDownCount.Value;
            int length = (int)numericUpDownLength.Value;

            string prefix = textBoxPrefix.Text.Trim();
            string sufix = textBoxSufix.Text.Trim();

            List<string> codes = CodeGenerator.GenerateUniqueCodes(count, length, prefix, sufix, checkBoxNumbersOnly.Checked);

            textBoxResult.Clear();
            codes.ForEach(codes => textBoxResult.AppendText(codes + Environment.NewLine));
        }

        private async void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                MessageBox.Show("No codes to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(textBoxResult.Text);

            string originalText = buttonCopy.Text;
            buttonCopy.Text = "Copied!";

            await Task.Delay(2000);

            buttonCopy.Text = originalText;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                MessageBox.Show("No codes to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Save Codes",
                FileName = $"UniqueCodes_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxResult.Text);
                MessageBox.Show("Codes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

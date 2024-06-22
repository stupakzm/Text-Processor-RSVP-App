namespace RSVPApplication {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            LoadSettings();
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            filePathTextBox = new TextBox();
            sentenceTextBox = new TextBox();
            wordProcessingTextBox = new TextBox();
            fontSizeNumericUpDown = new NumericUpDown();
            statusBar = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            browseButton = new Button();
            mainButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).BeginInit();
            statusBar.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // filePathTextBox
            // 
            filePathTextBox.Dock = DockStyle.Fill;
            filePathTextBox.Location = new Point(3, 3);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(398, 27);
            filePathTextBox.TabIndex = 0;
            filePathTextBox.Text = "Input filepath for file";
            // 
            // sentenceTextBox
            // 
            tableLayoutPanel.SetColumnSpan(sentenceTextBox, 2);
            sentenceTextBox.Dock = DockStyle.Fill;
            sentenceTextBox.Location = new Point(3, 33);
            sentenceTextBox.Multiline = true;
            sentenceTextBox.Name = "sentenceTextBox";
            sentenceTextBox.Size = new Size(499, 54);
            sentenceTextBox.TabIndex = 2;
            sentenceTextBox.Text = "Input filepath for file";
            // 
            // wordProcessingTextBox
            // 
            wordProcessingTextBox.Dock = DockStyle.Fill;
            wordProcessingTextBox.Font = new Font("Segoe UI", 18F);
            wordProcessingTextBox.Location = new Point(3, 123);
            wordProcessingTextBox.Name = "wordProcessingTextBox";
            wordProcessingTextBox.Size = new Size(398, 47);
            wordProcessingTextBox.TabIndex = 4;
            wordProcessingTextBox.Text = "RSVP";
            wordProcessingTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fontSizeNumericUpDown
            // 
            fontSizeNumericUpDown.Dock = DockStyle.Fill;
            fontSizeNumericUpDown.Location = new Point(407, 123);
            fontSizeNumericUpDown.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            fontSizeNumericUpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            fontSizeNumericUpDown.Size = new Size(95, 27);
            fontSizeNumericUpDown.TabIndex = 5;
            fontSizeNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            fontSizeNumericUpDown.ValueChanged += FontSizeNumericUpDown_ValueChanged;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusBar.Location = new Point(0, 274);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(505, 26);
            statusBar.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(485, 20);
            toolStripStatusLabel.Text = "Automatic: Off | Paused: Yes | Words per Frame: 1 | Frame Speed: 250 ms";
            // 
            // browseButton
            // 
            browseButton.Dock = DockStyle.Fill;
            browseButton.Location = new Point(407, 3);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(95, 24);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.Click += BrowseButton_Click;
            // 
            // mainButton
            // 
            tableLayoutPanel.SetColumnSpan(mainButton, 2);
            mainButton.Dock = DockStyle.Fill;
            mainButton.Location = new Point(3, 93);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(499, 24);
            mainButton.TabIndex = 3;
            mainButton.Text = "Start";
            mainButton.Click += MainButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Controls.Add(filePathTextBox, 0, 0);
            tableLayoutPanel.Controls.Add(browseButton, 1, 0);
            tableLayoutPanel.Controls.Add(sentenceTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(mainButton, 0, 2);
            tableLayoutPanel.Controls.Add(wordProcessingTextBox, 0, 3);
            tableLayoutPanel.Controls.Add(fontSizeNumericUpDown, 1, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(505, 274);
            tableLayoutPanel.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(505, 300);
            Controls.Add(tableLayoutPanel);
            Controls.Add(statusBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Word Processing App";
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).EndInit();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox filePathTextBox;
        private TextBox sentenceTextBox;
        private TextBox wordProcessingTextBox;
        private NumericUpDown fontSizeNumericUpDown;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Button browseButton;
        private Button mainButton;
        private TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Timer timer;
        private int wordsPerFrame = 1;
        private int frameSpeed = 250; // default frame speed in ms
        private bool isAutomatic = false;
        private bool isPaused = true;
        private string[] sentences;
        private int currentSentenceIndex = 0;
        private int currentWordIndex = 0;


        private void FontSizeNumericUpDown_ValueChanged(object? sender, EventArgs e) {
            wordProcessingTextBox.Font = new Font(wordProcessingTextBox.Font.FontFamily, (float)fontSizeNumericUpDown.Value);
        }

        private void BrowseButton_Click(object? sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                filePathTextBox.Text = openFileDialog.FileName;
                LoadFile(openFileDialog.FileName);
            }
        }

        private void LoadFile(string path) {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) {
                MessageBox.Show("Invalid file path. Please provide a valid path.");
                return;
            }
            string fileContent = File.ReadAllText(path);
            sentences = fileContent.Split('.').Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            currentSentenceIndex = 0;

            if (sentences.Length > 0 && sentences[0].StartsWith("sentence_index_")) {
                if (int.TryParse(sentences[0].Substring("sentence_index_".Length), out int savedIndex)) {
                    currentSentenceIndex = savedIndex;


                    DialogResult result = MessageBox.Show($"Do you want to continue from sentence {currentSentenceIndex}?", "Continue or Start Over", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No) {
                        currentSentenceIndex = 0;
                    }
                }
            }

            sentenceTextBox.Text = sentences[currentSentenceIndex];
        }


        private void MainButton_Click(object? sender, EventArgs e) {
            if (isPaused) {
                StartProcessing();
            }
            else {
                PauseProcessing();
            }
            UpdateMainButtonText();
        }

        private void StartProcessing() {
            if (string.IsNullOrWhiteSpace(filePathTextBox.Text) || !File.Exists(filePathTextBox.Text)) {
                MessageBox.Show("Invalid file path. Please provide a valid path.");
                return;
            }

            if (timer == null) {
                timer = new System.Windows.Forms.Timer();
                timer.Tick += Timer_Tick;
            }

            timer.Interval = frameSpeed;
            timer.Start();
            isPaused = false;
            UpdateMainButtonText();
            UpdateStatusBar();
        }

        private void PauseProcessing() {
            if (timer != null) {
                timer.Stop();
            }

            isPaused = true;
            UpdateMainButtonText();
            UpdateStatusBar();
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            if (currentSentenceIndex < sentences.Length) {
                string[] words = sentences[currentSentenceIndex].Split(' ');

                if (currentWordIndex < words.Length) {
                    string wordsString = string.Join(" ", words.Skip(currentWordIndex).Take(wordsPerFrame));
                    wordProcessingTextBox.Text = wordsString.Trim();

                    currentWordIndex += wordsPerFrame;

                    // If we've reached the end of the current sentence, move to the next one
                    if (currentWordIndex >= words.Length) {
                        currentSentenceIndex++;
                        currentWordIndex = 0;

                        if (currentSentenceIndex < sentences.Length) {
                            sentenceTextBox.Text = sentences[currentSentenceIndex];
                        }
                        else {
                            PauseProcessing();
                        }
                    }
                }
            }
            else {
                PauseProcessing();
            }
        }



        private void UpdateMainButtonText() {
            if (isPaused) {
                mainButton.Text = "Continue";
            }
            else {
                mainButton.Text = "Pause";
            }
        }

        private void UpdateStatusBar() {
            toolStripStatusLabel.Text = $"Automatic: {(isAutomatic ? "On" : "Off")} | Paused: {isPaused} | Words per Frame: {wordsPerFrame} | Frame Speed: {frameSpeed} ms";
        }

        // Key press event handler to toggle automatic mode and handle other key commands
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.A) {
                isAutomatic = !isAutomatic;
                UpdateStatusBar();
                return true;
            }
            else if (keyData == Keys.Up || keyData == Keys.Add) {
                frameSpeed = Math.Max(100, frameSpeed - 20); // Decrease speed, minimum 50ms
                UpdateStatusBar();
                SaveSettings();
                return true;
            }
            else if (keyData == Keys.Down || keyData == Keys.Subtract) {
                frameSpeed += 20; // Increase speed
                UpdateStatusBar();
                SaveSettings();
                return true;
            }
            else if (keyData == Keys.D1 || keyData == Keys.NumPad1) {
                wordsPerFrame = 1;
                UpdateStatusBar();
                SaveSettings();
                return true;
            }
            else if (keyData == Keys.D2 || keyData == Keys.NumPad2) {
                wordsPerFrame = 2;
                UpdateStatusBar();
                SaveSettings();
                return true;
            }
            else if (keyData == Keys.D3 || keyData == Keys.NumPad3) {
                wordsPerFrame = 3;
                UpdateStatusBar();
                SaveSettings();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoadSettings() {
            // Load wordsPerFrame and frameSpeed from local storage
            string settingsFile = "settings.txt";
            if (File.Exists(settingsFile)) {
                var settings = File.ReadAllLines(settingsFile);
                wordsPerFrame = int.Parse(settings[0]);
                frameSpeed = int.Parse(settings[1]);
            }
            else {
                SaveSettings();
            }

            UpdateStatusBar();
        }

        private void SaveSettings() {
            string settingsFile = "settings.txt";
            File.WriteAllLines(settingsFile, new string[] { wordsPerFrame.ToString(), frameSpeed.ToString() });
        }

        private void SaveFile(string path) {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) {
                //MessageBox.Show("Invalid file path. Please provide a valid path.");
                return;
            }

            if (sentences.Length > 0 && sentences[0].StartsWith("sentence_index_")) {
                sentences[0] = $"sentence_index_{currentSentenceIndex}";
            }
            else {
                var newSentences = new string[sentences.Length + 1];
                newSentences[0] = $"sentence_index_{currentSentenceIndex}";
                Array.Copy(sentences, 0, newSentences, 1, sentences.Length);
                sentences = newSentences;
            }
            if (currentSentenceIndex != 0) {
                sentences = sentences.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                File.WriteAllText(path, string.Join('.', sentences));
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);

            SaveFile(filePathTextBox.Text);

            SaveSettings();
        }

    }
}

namespace Law {
    public partial class Launcher : Form {
        private readonly List<(int, int, long)> results;

        public Launcher() {
            results = new();
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            if (int.TryParse(textNum.Text, out int N)) {
                if (N < 3) return;
                Measure m = new(N, results);
                m.Show();
                m.Next();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e) {
            if (results.Count == 0) return;
            SaveFileDialog sfd = new() {
                FileName = "Result.csv",
            };

            if (sfd.ShowDialog() == DialogResult.OK) {
                using StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("Distance, Area, Time");
                foreach ((int, int, long) iil in results.OrderBy(o => o.Item3).OrderBy(o => o.Item2).OrderBy(o => o.Item1))
                    sw.WriteLine($"{iil.Item1}, {iil.Item2}, {iil.Item3}");
            }
        }
    }
}
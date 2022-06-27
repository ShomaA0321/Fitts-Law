using System.Data;
using System.Diagnostics;

namespace Law {
    public partial class Measure : Form {
        private readonly int n;
        private int count;
        private long ts;
        private bool isRight;
        private bool isCon;
        private (int, int) task;
        private readonly List<(int, int, long)> results;
        private readonly Stack<(int, int)> tasks;
        private readonly Stopwatch sw;

        public Measure(int N, List<(int, int, long)> results) {
            n = N;
            this.results = results;
            tasks = new(
                new (int, int)[] {
                    (200, 20), (400, 20), (800, 20),
                    (200, 40), (400, 40), (800, 40),
                    (200, 80), (400, 80), (800, 80),
                }.OrderBy(_ => Guid.NewGuid()));
            sw = Stopwatch.StartNew();

            InitializeComponent();
        }

        public void Next() {
            if (tasks.TryPop(out task)) {
                count = 0;
                int width = task.Item2;
                int xL = 960 - task.Item1 - width / 2;
                int xR = 960 + task.Item1 - width / 2;
                labelL.Width = width;
                labelR.Width = width;
                labelL.Location = new(xL, 12);
                labelR.Location = new(xR, 12);
                isCon = false;
                SetRight();
            }
            else Close();
        }

        private void SetRight() {
            labelR.BackColor = Color.LightCoral;
            labelL.BackColor = Color.LightGray;
            isRight = true;
        }

        private void SetLeft() {
            labelR.BackColor = Color.LightGray;
            labelL.BackColor = Color.LightCoral;
            isRight = false;
        }

        private void Correct(long te) {
            if (isCon) {
                results.Add((task.Item1, task.Item2, te - ts));
                count++;
            }
            else isCon = true;
        }

        private void InCorrect() {
            isCon = false;
            SetRight();
        }

        private void Measure_Click(object sender, EventArgs e) {
            Debug.WriteLine($"InCorrect isRight{isRight}, isCon{isCon}");
            InCorrect();
        }

        private void Button_Click(object sender, EventArgs e) {
            long te = sw.ElapsedTicks;
            if (isRight) {
                if (sender.Equals(labelR)) {
                    Correct(te);
                    if (count == n) Next();
                    else SetLeft();
                }
                else
                    InCorrect();
            }
            else {
                if (sender.Equals(labelL)) {
                    Correct(te);
                    if (count == n) Next();
                    else SetRight();
                }
                else
                    InCorrect();
            }
            ts = te;
        }
    }
}

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutWheel
{
    public partial class WorkoutWheelForm : Form
    {
        public WorkoutWheelForm()
        {
            InitializeComponent();
        }

        private List<string> _workouts = new List<string>();
        private string _filePath;

        #region Buttons and Timers
        private void buttonSpin_Click(object sender, EventArgs e)
        {
            if (timerRotation.Enabled)
            {
                labelResult.Text = GetRandomWorkout();
                labelResult.Visible = true;
                buttonSpin.Text = "Spin!";
                timerRotation.Enabled = false;
            }
            else
            {
                if (!LoadWorkouts()) return;
                buttonSpin.Text = "Stop!";
                timerRotation.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveWorkouts();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _workouts.Add(textBoxWorkout.Text);
            textBoxWorkout.Clear();
        }

        private void timerRotation_Tick(object sender, EventArgs e)
        {
            Image imageToRotate = circlePictureBox1.Image;
            imageToRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
            circlePictureBox1.Image = imageToRotate;
        }
        #endregion

        #region Methods
        private bool LoadWorkouts()
        {
            if (File.Exists(_filePath))
            {
                ReadWorkoutsFile(_filePath);
                return true;
            }
            else
            {
                OpenFileDialog loadDialog = new OpenFileDialog();
                loadDialog.DefaultExt = ".txt";
                loadDialog.Filter = "Text Documents (.txt)|*.txt";
                if (loadDialog.ShowDialog() == DialogResult.OK && File.Exists(loadDialog.FileName))
                {
                    _filePath = loadDialog.FileName;
                    ReadWorkoutsFile(loadDialog.FileName);
                    return true;
                }
                return false;
            }
        }

        private void ReadWorkoutsFile(string path)
        {
            string lineIn;
            _workouts.Clear();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader inputReader = new StreamReader(fs))
            {
                while ((lineIn = inputReader.ReadLine()) != null)
                {
                    _workouts.Add(lineIn);
                }
            }
        }

        private void SaveWorkouts()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var workout in _workouts)
                sb.Append(workout + "\n");
            string workouts = sb.ToString();

            if (File.Exists(_filePath))
            {
                File.AppendAllText(_filePath, workouts);
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "workouts";
                saveDialog.DefaultExt = ".txt";
                saveDialog.Filter = "Text Documents (.txt)|*.txt";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveDialog.FileName))
                        File.AppendAllText(saveDialog.FileName, workouts);
                    else
                        File.WriteAllText(saveDialog.FileName, workouts);
                    _filePath = saveDialog.FileName;
                }
            }
        }

        private string GetRandomWorkout()
        {
            int numberOfWorkouts = _workouts.Count;
            Random r = new Random();
            int randomNumber = r.Next(numberOfWorkouts);
            string randomWorkout = _workouts[randomNumber];
            return randomWorkout;
        }
        #endregion
    }
}

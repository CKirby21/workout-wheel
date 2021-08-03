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
        private List<Color> _colors = new List<Color>() { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Gray, Color.Blue, Color.Violet, Color.Purple };
        private string _filePath;

        #region Buttons and Timers

        private void buttonSpinner_Click(object sender, EventArgs e)
        {
            if (timerRotation.Enabled)
            {
                labelResult.Text = GetRandomWorkout();
                labelResult.ForeColor = GetRandomColor();
                labelResult.Visible = true;
                timerRotation.Enabled = false;
            }
            else
            {
                if (!LoadWorkouts()) return;
                labelResult.Visible = true;
                timerRotation.Enabled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorkout.Text) || !LoadWorkouts())
                return;
            
            string[] workoutsToRemove = textBoxWorkout.Text.Split(',');
            foreach (string workout in workoutsToRemove)
            {
                _workouts.Remove(workout);
            }
            File.WriteAllText(_filePath, BuildWorkoutsCSV());
            textBoxWorkout.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorkout.Text))
                return;

            string[] workoutsToAdd = textBoxWorkout.Text.Split(',');
            foreach (string workout in workoutsToAdd)
            {
                _workouts.Add(workout);
            }
            SaveWorkouts();
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
            if (!String.IsNullOrEmpty(_filePath))
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

        private void SaveWorkouts()
        {
            string workoutsCSV = BuildWorkoutsCSV();
            if (File.Exists(_filePath))
            {
                File.AppendAllText(_filePath, workoutsCSV);
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
                        File.AppendAllText(saveDialog.FileName, workoutsCSV);
                    else
                        File.WriteAllText(saveDialog.FileName, workoutsCSV);
                    _filePath = saveDialog.FileName;
                }
            }
        }

        private void ReadWorkoutsFile(string path)
        {
            _workouts.Clear();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader inputReader = new StreamReader(fs))
            {
                string[] workoutsArray = inputReader.ReadLine().Split(',');
                _workouts = workoutsArray.ToList();
            }
        }

        private string BuildWorkoutsCSV()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var workout in _workouts)
            {
                sb.Append(workout + ",");
            }
            return sb.ToString().TrimEnd(',');
        }

        private string GetRandomWorkout()
        { 
            int numberOfWorkouts = _workouts.Count;
            if (numberOfWorkouts == 0)
                return "";
            Random r = new Random();
            int randomIndex = r.Next(numberOfWorkouts);
            return _workouts[randomIndex];
        }

        private Color GetRandomColor()
        {
            Random r = new Random();
            int randomIndex = r.Next(_colors.Count);
            return _colors[randomIndex];
        }
        #endregion

        
    }
}

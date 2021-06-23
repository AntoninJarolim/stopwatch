﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace MyStopwatch
{
    public partial class stopwatchForm : MetroFramework.Forms.MetroForm
    {
        Timer timer = new Timer();
        Stopwatch stopWatch = new Stopwatch();
        TimeSpan ts = new TimeSpan(); // timeSpan holding elapsed time

        public stopwatchForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timeToLabels()
        {
            ts = stopWatch.Elapsed;
            labelMs.Text = String.Format("{0:000}", ts.Milliseconds);
            labelSec.Text = String.Format("{0:00}", ts.Seconds);
            labelMin.Text = String.Format("{0:00}", ts.Minutes);
            labelHrs.Text = String.Format("{0:00}", ts.Hours);
        }
        private void msTick(Object myObject, EventArgs myEventArgs)
        {
            timeToLabels();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(msTick);
            timer.Interval = 10; // set interval to 10ms
            timer.Start();
            stopWatch.Start();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            timer.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stopWatch.Reset();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            if (timer.Enabled)
            {
                stopWatch.Start();
            }
            else
            {
                timeToLabels();
            }
        }
        private void createListViewItem(string name, string timeStamp)
        {
            ListViewItem item = new ListViewItem(name); // creates item with name
            item.SubItems.Add(timeStamp); // addes timestamp to item
            listView.Items.Add(item);
        }
        private void loadLineToListView(string line)
        {
            string[] columns = line.Split(';');
            createListViewItem(columns[0], columns[1]);
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            string line;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|all files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader file = new StreamReader(fileStream))
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            loadLineToListView(line);
                        }
                    }
                }
            }

        }

        private void showAlertBox(string message,  string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if(itemNameTextbox.Text == "" || itemNameTextbox.Text == "Enter item name")
            {
                const string message = "Please enter time stamp name.";
                const string caption = "No name entered";
                showAlertBox(message, caption);
            }
            else
            {
                // current timespan is saved in ts variable
                createListViewItem(itemNameTextbox.Text, ts.ToString());
            }
        }

        private void itemNameTextbox_Click(object sender, EventArgs e)
        {
            itemNameTextbox.Text = ""; // clears textbox when clicked  
        }

        private void saveToCss(string fileContent)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv|all files (*.*)|*.*|txt files (*.txt)|*.txt";
            saveFileDialog.Title = "Save to csv file.";
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(path, fileContent);
            }
            else
            {
                const string message = "Please enter valid file name.";
                const string caption = "Invalid file name";
                showAlertBox(message, caption);
            }            
        }
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            string fileContent = "";
            for (int i = 0; i < listView.Items.Count; i++)
            {
                fileContent += listView.Items[i].Text + ";" + listView.Items[i].SubItems[1].Text + Environment.NewLine;
            }
            saveToCss(fileContent);
        }
    }
}

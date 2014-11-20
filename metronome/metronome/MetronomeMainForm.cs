using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metronome
{
    /// <summary>
    /// The main GUI form for the metronome app. Very barebones and simple, but it does the trick.
    /// </summary>
	public partial class MetronomeMainForm : Form
	{
		Song song; //Object representing the song.
        int CurrentBoxIndex { get { return songOrderBox.Items.Count; } } //Returns the number of sections in the song.

        //Threshold error values for parsing inputs through the form.
        const int LOWER_TIME_SIG_THRESHOLD = 1;
        const int UPPER_TIME_SIG_THRESHOLD = 12;
        const int LOWER_TEMPO_THRESHOLD = 1;
        const int UPPER_TEMPO_THRESHOLD = 500;
        const int LOWER_MEASURE_THRESHOLD = 1;

        /// <summary>
        /// Initialization stuff. Populates the text fields with some default values so I could test easier.
        /// </summary>
		public MetronomeMainForm()
		{
			InitializeComponent();
			song = new Song();
            timeSigBox.Text = "4";
            tempoBox.Text = "120";
            measureBox.Text = "2";
		}

        /// <summary>
        /// Adds a section to the song using info in the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void add_button_Click(object sender, EventArgs e)
		{
            StringBuilder errorMessage = new StringBuilder(""); //String builder since we're going to be appending and modifying a single string.
            bool error = false; //checks for errors along the way

            //verify the entered data is good.
            //Time signature
            if (!Enumerable.Range(LOWER_TIME_SIG_THRESHOLD, UPPER_TIME_SIG_THRESHOLD).Contains(Convert.ToInt32(timeSigBox.Text)))
            {
                error = true;
                errorMessage.Append("Time signature must be between " + LOWER_TIME_SIG_THRESHOLD + "/4 and " + UPPER_TIME_SIG_THRESHOLD + "/4.\n");
            }
            //Tempo
            if (!Enumerable.Range(LOWER_TEMPO_THRESHOLD, UPPER_TEMPO_THRESHOLD).Contains(Convert.ToInt32(tempoBox.Text)))
            {
                error = true;
                errorMessage.Append("Tempo must be between " + LOWER_TEMPO_THRESHOLD + " and " + UPPER_TEMPO_THRESHOLD + ".\n");
            }
            //Measure count
            if (!(Convert.ToInt32(measureBox.Text) >= LOWER_MEASURE_THRESHOLD))
            {
                error = true;
                errorMessage.Append("Must have at least " + LOWER_MEASURE_THRESHOLD + " measures.\n");
            }

            //If there's an error, throw up a warning and return the method without action.
            if (error)
            {
                var errorWarning = MessageBox.Show(errorMessage.ToString(), "error!");
                return;
            }

            //If everything's okay, add the section to the song!
            else
            {
                song.addSection(Convert.ToInt32(timeSigBox.Text), Convert.ToInt32(tempoBox.Text), Convert.ToInt32(measureBox.Text));
                songOrderBox.Items.Insert(CurrentBoxIndex, song.songOrder[CurrentBoxIndex].TimeSig + "/4, " + song.songOrder[CurrentBoxIndex].Bpm + "bpm, " +
                                            song.songOrder[CurrentBoxIndex].SectionLength + " measures.");
            }
		}

        /// <summary>
        /// Starts the song from the beginning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void play_button_Click(object sender, EventArgs e)
		{
            song.stopSong();
			song.startSong();
		}

        /// <summary>
        /// Stops and rewinds the song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void stop_button_Click(object sender, EventArgs e)
		{
			song.stopSong();
		}

        /// <summary>
        /// Resets the song completely, removing all sections, and repopulates the default text box values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_button_Click(object sender, EventArgs e)
        {
            song.stopSong();
            song = new Song();
            songOrderBox.Items.Clear();
            timeSigBox.Text = "4";
            tempoBox.Text = "120";
            measureBox.Text = "2";
        }

        /// <summary>
        /// Removes the selected section from the song list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remove_button_Click(object sender, EventArgs e)
        {
            song.removeSection(songOrderBox.SelectedIndex);
            songOrderBox.Items.RemoveAt(songOrderBox.SelectedIndex);
        }

        private void MetronomeMainForm_Load(object sender, EventArgs e)
        {

        }
	}
}

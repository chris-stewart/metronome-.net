using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metronome
{
    /// <summary>
    /// This class models the song, which is a linear ordering of sections.
    /// </summary>
	public class Song
	{
		int currentSection; //current section that's playing.
		int currentInterval; //current beat spacing in milliseconds, used with the timer.

		public List<Section> songOrder; //The List<> modelling the song.
		System.Timers.Timer metronomeTimer; //Timer used to count through the beats at a (relatively) accurate clip.

        /// <summary>
        /// Constructor for creating a song object.
        /// </summary>
		public Song()
		{
			songOrder = new List<Section>();
            currentSection = 0; //Defaults to beginning of song.
			metronomeTimer = new System.Timers.Timer();
			metronomeTimer.Elapsed += new System.Timers.ElapsedEventHandler(playCurrentBeat);
		}

        /// <summary>
        /// Delegate for actually playing the audio beat and advancing through the measures and sections. Called
        /// by the timer.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
		void playCurrentBeat(object source, System.Timers.ElapsedEventArgs e)
		{
			//change the interval if the measure's time is up
			if (currentInterval != songOrder[currentSection].ActualWaitTime)
			{
				currentInterval = songOrder[currentSection].ActualWaitTime;
				metronomeTimer.Interval = currentInterval;
			}

			//play the beat, and go to next section if needed
			if (songOrder[currentSection].playNextBeat())
			{
				currentSection++;
				if (currentSection == songOrder.Count) { stopSong(); } //stop song if we're all done.
			}
		}

        /// <summary>
        /// Private method to reset the song. Small method to stave off potential future code duplication.
        /// </summary>
        void resetSong()
        {
            currentSection = 0;
            foreach (Section section in songOrder)
            {
                section.resetSection();
            }
        }

        /// <summary>
        /// Starts the song by initializing and starting the timer at a specified spot.
        /// </summary>
        /// <param name="startSection">The section to start at, linearly ordered. Defaults to the beginning.</param>
        /// <param name="startMeasure">The measure of the section to start at. Defaults to the section beginning.</param>
		public void startSong(int startSection = 0, int startMeasure = 0)
		{
			currentSection = startSection; //initializes the object's section counter
			songOrder[currentSection].CurrentMeasure = startMeasure; //initializes the section's starting measure.
			currentInterval = songOrder[currentSection].ActualWaitTime; //Gets the tempo for the timer
			metronomeTimer.Interval = currentInterval;
			metronomeTimer.Start(); //starts the timer
		}

        /// <summary>
        /// Pauses the song right where it's at.
        /// </summary>
        /// <remarks>
        /// TODO: Not implemented through GUI yet. Untested as well.
        /// </remarks>
		public void pauseSong()
		{
			metronomeTimer.Stop();
		}

        /// <summary>
        /// Resumes the song from where pause left off.
        /// </summary>
        /// <remarks>
        /// TODO: Not yet implemented through GUI. Untested.
        /// </remarks>
		public void resumeSong()
		{
			startSong(currentSection, songOrder[currentSection].CurrentMeasure);
		}

        /// <summary>
        /// Stops the song and rewinds it to the beginning.
        /// </summary>
		public void stopSong()
		{
			metronomeTimer.Stop();
			resetSong();
		}

        /// <summary>
        /// Adds a new section with the provided information.
        /// </summary>
        /// <param name="timeSig">Time signature, always x/4</param>
        /// <param name="bpm">Beats per minute</param>
        /// <param name="sectionLength">Number of measures in the section</param>
		public void addSection(int timeSig, int bpm, int sectionLength)
		{
			songOrder.Add(new Section(timeSig, bpm, sectionLength));
		}

        /// <summary>
        /// Removes a section from the song. The following sections are appended then to 
        /// the part right before the removal.
        /// </summary>
        /// <param name="index">Index value in the songOrder list to be culled.</param>
		public void removeSection(int index)
		{
			if (index > songOrder.Count) { throw new ArgumentException(); }
			songOrder.RemoveAt(index);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace metronome
{
    /// <summary>
    /// A section is a string of uniform measures. Typically a riff will be a uniform x measures of x time signature,
    /// so here we model a section as a chunk of measures sharing the same time signature and tempo.
    /// </summary>
	public class Section
	{
		int timeSig; //upper value of a time signature.
		int bpm; //Beats per minute for this section.
		int sectionLength; //number of measures played in this section.
		int currentBeat; //used to keep track of a measure's current beat.
		int currentMeasure; //used to keep track of the section's currently active measure.
		List<Beat> measure; //models the measure to be repeated in this section.

		public int ActualWaitTime { get { return (int)(1000.0 / ((bpm / 60.0))); } } //millisecond time bewteen beats, mathed from bpm.
		public int TimeSig { get { return timeSig; } }
		public int Bpm { get { return bpm; } }
		public int SectionLength { get { return sectionLength; } }
		public int CurrentBeat { get { return currentBeat; } }
		public int CurrentMeasure { get { return currentMeasure; } set { currentMeasure = value; } }

        /// <summary>
        /// Constructor for a song section.
        /// </summary>
        /// <param name="timeSig">Upper value of a time signature. For this metronome, everything is considered x/4. 
        /// If you want something like 6/8, just double the tempo.</param>
        /// <param name="bpm">Beats per minute for this section.</param>
        /// <param name="sectionLength">Number of measures played in this section.</param>
		public Section(int timeSig, int bpm, int sectionLength)
		{
			this.timeSig = timeSig;
			this.bpm = bpm;
			this.sectionLength = sectionLength;
			currentBeat = 0;
			currentMeasure = 0; 
			measure = new List<Beat>();
			measure.Add(new Beat(true)); //Add the first 'on-beat', the accented value
			for (int i = 1; i < timeSig; i++) // i = 1 since the accented beat is first. ex. 4/4, first beat accent, loop 3 times for remaining beats.
			{
				measure.Add(new Beat(false)); //add the rest of the beats
			}
		}

        /// <summary>
        /// Plays the beat audio then moves the counters to prepare for the next one.
        /// </summary>
        /// <returns>Returns true if it's time to move to a new section, false if we're looping this measure.</returns>
		public bool playNextBeat() 
		{
			measure[currentBeat].soundBeat(); //play the sound
            currentBeat++; //increment the beat
			currentBeat = currentBeat % timeSig; //loop it back around if we need to.
			if (currentBeat == 0) { currentMeasure++; } //Check if we're advancing measures towards the end of the section.
			if (currentMeasure == sectionLength) { return true; } //Check if this sections done or not.
			return false;
		}

        /// <summary>
        /// Sets the measure to start at in the section. We don't always have to start in the middle.
        /// </summary>
        /// <remarks>
        /// TODO. The GUI doesn't yet allow this functionality. This will be used eventually in pause/resume operations.
        /// </remarks>
        /// <param name="startMeasure">Measure to start at.</param>
		public void setMeasure(int startMeasure)
		{
			currentMeasure = startMeasure;
			currentBeat = 0; //we still always start on the down-beat.
		}

        /// <summary>
        /// Resets a section to start at the beginning.
        /// </summary>
		public void resetSection()
		{
			setMeasure(0);
		}
	}
}

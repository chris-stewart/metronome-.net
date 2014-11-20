using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace metronome
{
    /// <summary>
    /// Contains the information needed for a single beat, with adjustable frequency stuff for accented beats
    /// and whatnot.
    /// </summary>
	public class Beat
	{
		bool isAccent; //Accents are a higher pitch

        //following values all taken from the resources.resx file. More info on the options there.
        readonly int beepDuration = Convert.ToInt32(metronome.Properties.Resources.DEFAULT_BEEP_DURATION);
        readonly int frequency = Convert.ToInt32(metronome.Properties.Resources.DEFAULT_BEEP_FREQUENCY);
        readonly double multiplier = Convert.ToDouble(metronome.Properties.Resources.DEFAULT_BEEP_ACCENT_MULTIPLIER);

        /// <summary>
        /// Standard constructor to create a beat.
        /// </summary>
        /// <param name="isAccent">If true, the beat plays an accented tone. In this case it's always the first beat of a measure</param>
		public Beat(bool isAccent)
		{
			this.isAccent = isAccent;
            frequency = (isAccent) ? (int)(frequency * multiplier) : frequency; //normal frequency is multiplied
		}

        /// <summary>
        /// Method to actually play the sound. Just uses the system beep.
        /// </summary>
		public void soundBeat()
		{
			Console.Beep(frequency, beepDuration);
		}
	}
}

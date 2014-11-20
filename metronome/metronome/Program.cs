using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metronome
{
	/// <summary>
	/// The metronome namespace contains everything necessary to run the drummer's metronome app. This app is a proof of concept
	/// for a future android application, which would allow me to layout song orders on my phone and use the metronome while
	/// playing live. Currently I need to lug my laptop and some extra gear, so this app will save me a ton of pain with
	/// my band.
	/// </summary>
	class NamespaceDoc { }

	/// <summary>
	/// Parent class.
	/// </summary>
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MetronomeMainForm());
		}
	}
}

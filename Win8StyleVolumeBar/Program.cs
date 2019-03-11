using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win8StyleVolumeBar
{
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

			string[] args = Environment.GetCommandLineArgs();
			int? color = null;
			if (args.Length == 2)
			{
				int _color;
				if (int.TryParse(args[1], out _color))
				{
					color = _color | -0x1000000;
				}
				else
				{
					throw new ArgumentException($"\"{args[1]}\" could not be parsed to a number.\nYou need to use a decimal value here.");
				}
			}
			else if (args.Length == 1)
			{
				//hi
			}
			else if (args.Length == 3)
			{
				throw new ArgumentException("You used 2 arguments when starting the program, and that's kinda bad.\n(Hint: It's not supported. Try using a single argument instead.)");
			}
			else if (args.Length == 4)
			{
				throw new NotImplementedException("Too lazy; did not implement specifying each RGB channel as a separate argument.");
			}
			else
			{
				throw new ArgumentException($"You have too many arguments !!\n{args.Length - 1} whole arguments?\nThat's too much for me !!\n\nPotential solutions:\nA. Try arguing less\nB. Don't pass too many arguments to me (I can only deal with one)");
			}
			Application.Run(new VolumeBar(color));
        }
    }
}

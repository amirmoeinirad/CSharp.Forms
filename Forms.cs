
// Amir Moeini Rad
// September 2025

// Main Concept: Creating and displaying a simple Windows Form with specific properties + Message Loop.


using System.Windows.Forms;


namespace Tutorial
{
	class Forms
	{
		public static void Main()
		{
			Form myForm = new Form();

			myForm.StartPosition = FormStartPosition.CenterScreen;
			myForm.MaximizeBox = false;
			myForm.FormBorderStyle = FormBorderStyle.FixedSingle;			
            myForm.Text = "My Form";

            // Application.Run() starts a standard application message loop on the current thread
            // and makes the specified form visible.
            // A 'Message Loop' is a programming construct that waits for and dispatches messages or events in a program.
            // In the context of a Windows Forms application, the message loop is responsible for handling user input
			// like mouse clicks and keyboard presses.
            Application.Run(myForm);
		}
	}
}
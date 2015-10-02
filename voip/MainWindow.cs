using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	protected void OnBtnCallClicked (object sender, EventArgs e)
	{
		string ip = TextBoxIP.Text;
		string get_textview_value = TextViewStatus.Buffer.Text;


		TextViewStatus.Buffer.Text = get_textview_value + "Call Connecting to " + ip + "\n";
	}


	protected void OnBtnDisconnectClicked (object sender, EventArgs e)
	{
		string get_textview_value = TextViewStatus.Buffer.Text;
		TextViewStatus.Buffer.Text = get_textview_value + "Call Disconnected" + "\n";
	}

	protected void OnBtnClearStatusClicked (object sender, EventArgs e)
	{
		TextViewStatus.Buffer.Text = "";
	}
}

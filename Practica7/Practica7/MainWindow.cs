using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int Puntos = 0; 
		if (this.Leon.Active)
			Puntos++;
		if (this.Suma.Text == "4")
			Puntos++;
		if (this.Mexico.Active)
			Puntos++;

		DateTime fecha = this.calendario.GetDate();
		string fechaseleccionada = fecha.ToShortDateString();
		if(fechaseleccionada == "16/09/1810")
			Puntos++;
		this.entrycalificacion.Text = Puntos.ToString();


	} 
}

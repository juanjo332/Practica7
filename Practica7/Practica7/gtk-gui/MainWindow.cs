
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label label5;
	private global::Gtk.RadioButton Conejo;
	private global::Gtk.Label label6;
	private global::Gtk.RadioButton Leon;
	private global::Gtk.Label label7;
	private global::Gtk.RadioButton Pero;
	private global::Gtk.Label label8;
	private global::Gtk.RadioButton Pato;
	private global::Gtk.Label label3;
	private global::Gtk.ComboBox combobox1;
	private global::Gtk.Label label9;
	private global::Gtk.SpinButton Suma;
	private global::Gtk.Label label11;
	private global::Gtk.CheckButton Mexico;
	private global::Gtk.Label label12;
	private global::Gtk.CheckButton España;
	private global::Gtk.Label label13;
	private global::Gtk.CheckButton Japon;
	private global::Gtk.CheckButton Argentina;
	private global::Gtk.Label label14;
	private global::Gtk.Label label10;
	private global::Gtk.Label label4;
	private global::Gtk.Label label15;
	private global::Gtk.Calendar calendario;
	private global::Gtk.Entry entrycalificacion;
	private global::Gtk.Button TERMINAR;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("¿De los siguientes paises cuales son de america?");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w1.X = 11;
		w1.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w2.X = 10;
		w2.Y = 55;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.WidthRequest = 304;
		this.entry1.HeightRequest = 24;
		this.entry1.CanFocus = true;
		this.entry1.IsEditable = true;
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w3.X = 58;
		w3.Y = 11;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w4.X = 61;
		w4.Y = 53;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w5.X = 21;
		w5.Y = 179;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Conejo = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Conejo"));
		this.Conejo.CanFocus = true;
		this.Conejo.Name = "Conejo";
		this.Conejo.DrawIndicator = true;
		this.Conejo.UseUnderline = true;
		this.Conejo.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.Conejo);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Conejo]));
		w6.X = 41;
		w6.Y = 175;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.label6);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
		w7.X = 211;
		w7.Y = 176;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Leon = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Leon"));
		this.Leon.WidthRequest = 53;
		this.Leon.CanFocus = true;
		this.Leon.Name = "Leon";
		this.Leon.DrawIndicator = true;
		this.Leon.UseUnderline = true;
		this.Leon.Group = this.Conejo.Group;
		this.fixed1.Add (this.Leon);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Leon]));
		w8.X = 232;
		w8.Y = 175;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.label7);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label7]));
		w9.X = 383;
		w9.Y = 174;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Pero = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Perro"));
		this.Pero.CanFocus = true;
		this.Pero.Name = "Pero";
		this.Pero.DrawIndicator = true;
		this.Pero.UseUnderline = true;
		this.Pero.Group = this.Conejo.Group;
		this.fixed1.Add (this.Pero);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Pero]));
		w10.X = 402;
		w10.Y = 174;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.label8);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label8]));
		w11.X = 564;
		w11.Y = 174;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Pato = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Pato"));
		this.Pato.CanFocus = true;
		this.Pato.Name = "Pato";
		this.Pato.DrawIndicator = true;
		this.Pato.UseUnderline = true;
		this.Pato.Group = this.Conejo.Group;
		this.fixed1.Add (this.Pato);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Pato]));
		w12.X = 589;
		w12.Y = 173;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Grupo");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w13.X = 397;
		w13.Y = 15;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.combobox1 = global::Gtk.ComboBox.NewText ();
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("A"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("B"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("C"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("D"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("E"));
		global::Gtk.Tooltips w14 = new Gtk.Tooltips ();
		w14.SetTip (this.combobox1, "A\nB\nC\nD\nE", "A\nB\nC\nD\nE");
		this.combobox1.HeightRequest = 26;
		this.combobox1.Name = "combobox1";
		this.fixed1.Add (this.combobox1);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.combobox1]));
		w15.X = 439;
		w15.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("2-¿cuanto es 2+2?");
		this.fixed1.Add (this.label9);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label9]));
		w16.X = 14;
		w16.Y = 234;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Suma = new global::Gtk.SpinButton (0D, 100D, 1D);
		this.Suma.CanFocus = true;
		this.Suma.Name = "Suma";
		this.Suma.Adjustment.PageIncrement = 10D;
		this.Suma.ClimbRate = 1D;
		this.Suma.Numeric = true;
		this.fixed1.Add (this.Suma);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Suma]));
		w17.X = 12;
		w17.Y = 266;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.label11);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label11]));
		w18.X = 19;
		w18.Y = 361;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Mexico = new global::Gtk.CheckButton ();
		this.Mexico.CanFocus = true;
		this.Mexico.Name = "Mexico";
		this.Mexico.Label = global::Mono.Unix.Catalog.GetString ("Mexico");
		this.Mexico.Active = true;
		this.Mexico.DrawIndicator = true;
		this.Mexico.UseUnderline = true;
		this.fixed1.Add (this.Mexico);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Mexico]));
		w19.X = 40;
		w19.Y = 358;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.label12);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label12]));
		w20.X = 143;
		w20.Y = 359;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.España = new global::Gtk.CheckButton ();
		this.España.CanFocus = true;
		this.España.Name = "España";
		this.España.Label = global::Mono.Unix.Catalog.GetString ("España");
		this.España.DrawIndicator = true;
		this.España.UseUnderline = true;
		this.fixed1.Add (this.España);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.España]));
		w21.X = 165;
		w21.Y = 357;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.label13);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label13]));
		w22.X = 260;
		w22.Y = 357;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Japon = new global::Gtk.CheckButton ();
		this.Japon.CanFocus = true;
		this.Japon.Name = "Japon";
		this.Japon.Label = global::Mono.Unix.Catalog.GetString ("Japon");
		this.Japon.DrawIndicator = true;
		this.Japon.UseUnderline = true;
		this.fixed1.Add (this.Japon);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Japon]));
		w23.X = 279;
		w23.Y = 356;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Argentina = new global::Gtk.CheckButton ();
		this.Argentina.CanFocus = true;
		this.Argentina.Name = "Argentina";
		this.Argentina.Label = global::Mono.Unix.Catalog.GetString ("Argentina");
		this.Argentina.DrawIndicator = true;
		this.Argentina.UseUnderline = true;
		this.fixed1.Add (this.Argentina);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Argentina]));
		w24.X = 388;
		w24.Y = 356;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label14 = new global::Gtk.Label ();
		this.label14.Name = "label14";
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.label14);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label14]));
		w25.X = 358;
		w25.Y = 358;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("3-¿De los sguientes paises cuales son de america?");
		this.fixed1.Add (this.label10);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label10]));
		w26.X = 19;
		w26.Y = 313;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("1-¿ De los siguientes animales cual es felino?");
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w27.X = 22;
		w27.Y = 127;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label15 = new global::Gtk.Label ();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("4-.¿Indique la fecha de la independencia de Mexico?");
		this.fixed1.Add (this.label15);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label15]));
		w28.X = 14;
		w28.Y = 415;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calendario = new global::Gtk.Calendar ();
		this.calendario.CanFocus = true;
		this.calendario.Name = "calendario";
		this.calendario.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.calendario);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calendario]));
		w29.X = 73;
		w29.Y = 444;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entrycalificacion = new global::Gtk.Entry ();
		this.entrycalificacion.WidthRequest = 63;
		this.entrycalificacion.HeightRequest = 26;
		this.entrycalificacion.CanFocus = true;
		this.entrycalificacion.Name = "entrycalificacion";
		this.entrycalificacion.IsEditable = true;
		this.fixed1.Add (this.entrycalificacion);
		global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entrycalificacion]));
		w30.X = 600;
		w30.Y = 581;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.TERMINAR = new global::Gtk.Button ();
		this.TERMINAR.WidthRequest = 106;
		this.TERMINAR.HeightRequest = 23;
		this.TERMINAR.CanFocus = true;
		this.TERMINAR.Name = "TERMINAR";
		this.TERMINAR.UseUnderline = true;
		this.TERMINAR.Label = global::Mono.Unix.Catalog.GetString ("TERMINAR");
		this.fixed1.Add (this.TERMINAR);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.TERMINAR]));
		w31.X = 479;
		w31.Y = 583;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 830;
		this.DefaultHeight = 665;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.TERMINAR.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}

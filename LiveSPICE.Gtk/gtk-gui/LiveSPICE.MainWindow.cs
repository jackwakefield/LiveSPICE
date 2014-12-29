
// This file has been generated by the GUI designer. Do not modify.
namespace LiveSPICE
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action FileAction;
		
		private global::Gtk.Action EditAction;
		
		private global::Gtk.Action SimulateAction;
		
		private global::Gtk.Action ViewAction;
		
		private global::Gtk.Action newAction;
		
		private global::Gtk.Action openAction;
		
		private global::Gtk.Action saveAction;
		
		private global::Gtk.Action undoAction;
		
		private global::Gtk.Action redoAction;
		
		private global::Gtk.Action cutAction;
		
		private global::Gtk.Action copyAction;
		
		private global::Gtk.Action pasteAction;
		
		private global::Gtk.Action zoomInAction;
		
		private global::Gtk.Action zoomOutAction;
		
		private global::Gtk.Action zoom100Action;
		
		private global::Gtk.Action mediaPlayAction;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubar2;
		
		private global::Gtk.Toolbar toolbar1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Label GtkLabel2;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.Label GtkLabel3;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LiveSPICE.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
			this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
			w1.Add (this.EditAction, null);
			this.SimulateAction = new global::Gtk.Action ("SimulateAction", global::Mono.Unix.Catalog.GetString ("Simulate"), null, null);
			this.SimulateAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Simulate");
			w1.Add (this.SimulateAction, null);
			this.ViewAction = new global::Gtk.Action ("ViewAction", global::Mono.Unix.Catalog.GetString ("View"), null, null);
			this.ViewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("View");
			w1.Add (this.ViewAction, null);
			this.newAction = new global::Gtk.Action ("newAction", null, null, "gtk-new");
			w1.Add (this.newAction, null);
			this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
			w1.Add (this.openAction, null);
			this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
			w1.Add (this.saveAction, null);
			this.undoAction = new global::Gtk.Action ("undoAction", null, null, "gtk-undo");
			w1.Add (this.undoAction, null);
			this.redoAction = new global::Gtk.Action ("redoAction", null, null, "gtk-redo");
			w1.Add (this.redoAction, null);
			this.cutAction = new global::Gtk.Action ("cutAction", null, null, "gtk-cut");
			w1.Add (this.cutAction, null);
			this.copyAction = new global::Gtk.Action ("copyAction", null, null, "gtk-copy");
			w1.Add (this.copyAction, null);
			this.pasteAction = new global::Gtk.Action ("pasteAction", null, null, "gtk-paste");
			w1.Add (this.pasteAction, null);
			this.zoomInAction = new global::Gtk.Action ("zoomInAction", null, null, "gtk-zoom-in");
			w1.Add (this.zoomInAction, null);
			this.zoomOutAction = new global::Gtk.Action ("zoomOutAction", null, null, "gtk-zoom-out");
			w1.Add (this.zoomOutAction, null);
			this.zoom100Action = new global::Gtk.Action ("zoom100Action", null, null, "gtk-zoom-100");
			w1.Add (this.zoom100Action, null);
			this.mediaPlayAction = new global::Gtk.Action ("mediaPlayAction", null, null, "gtk-media-play");
			w1.Add (this.mediaPlayAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "LiveSPICE.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child LiveSPICE.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'/><menu name='EditAction' action='EditAction'/><menu name='SimulateAction' action='SimulateAction'/><menu name='ViewAction' action='ViewAction'/></menubar></ui>");
			this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
			this.menubar2.Name = "menubar2";
			this.vbox1.Add (this.menubar2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='newAction' action='newAction'/><toolitem name='openAction' action='openAction'/><toolitem name='saveAction' action='saveAction'/><separator/><toolitem name='undoAction' action='undoAction'/><toolitem name='redoAction' action='redoAction'/><separator/><toolitem name='cutAction' action='cutAction'/><toolitem name='copyAction' action='copyAction'/><toolitem name='pasteAction' action='pasteAction'/><separator/><toolitem name='zoomInAction' action='zoomInAction'/><toolitem name='zoomOutAction' action='zoomOutAction'/><toolitem name='zoom100Action' action='zoom100Action'/><separator/><toolitem name='mediaPlayAction' action='mediaPlayAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.toolbar1.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
			this.vbox1.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Components</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w5.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.frame2.Add (this.GtkAlignment1);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Properties</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.vbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame2]));
			w7.Position = 1;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Notebook tab
			global::Gtk.Label w9 = new global::Gtk.Label ();
			w9.Visible = true;
			this.notebook1.Add (w9);
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (w9, this.label1);
			this.label1.ShowAll ();
			this.hbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.notebook1]));
			w10.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w11.Position = 2;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 925;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
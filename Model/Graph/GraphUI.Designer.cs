namespace Graph
   {
   partial class GraphUI
      {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
         {
         if (disposing && (components != null))
            {
            components.Dispose();
            }
         base.Dispose(disposing);
         }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
         {
         this.components = new System.ComponentModel.Container();
         this.Chart = new Steema.TeeChart.TChart();
         this.PopupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.CopyToClipboardMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.CopyDataMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.EditGraphMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.RemoveAllFormattingMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.PrintForm = new TMGDevelopment.Windows.Forms.PrintForm(this.components);
         this.PopupMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // Chart
         // 
         // 
         // 
         // 
         this.Chart.Aspect.ColorPaletteIndex = 3;
         this.Chart.Aspect.ElevationFloat = 345;
         this.Chart.Aspect.RotationFloat = 345;
         this.Chart.Aspect.View3D = false;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.AxisPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
         this.Chart.Axes.Bottom.AxisPen.Width = 1;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.Bottom.Grid.Visible = false;
         this.Chart.Axes.Bottom.Grid.ZPosition = 0;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Labels.DateTimeFormat = "d/MM/yyyy";
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Labels.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
         this.Chart.Axes.Bottom.Labels.Font.Size = 9;
         this.Chart.Axes.Bottom.Labels.Separation = 80;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Labels.Shadow.Visible = false;
         this.Chart.Axes.Bottom.Labels.ValueFormat = "###0.###";
         this.Chart.Axes.Bottom.MaximumOffset = 10;
         this.Chart.Axes.Bottom.MinimumOffset = 10;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.MinorTicks.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Title.Caption = "Date";
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
         this.Chart.Axes.Bottom.Title.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Title.Font.Shadow.Visible = false;
         this.Chart.Axes.Bottom.Title.Font.Size = 11;
         this.Chart.Axes.Bottom.Title.Lines = new string[] {
        "Date"};
         // 
         // 
         // 
         this.Chart.Axes.Bottom.Title.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Depth.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.Depth.Grid.ZPosition = 0;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Depth.Labels.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Depth.Labels.Shadow.Visible = false;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Depth.Title.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Depth.Title.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.DepthTop.Grid.ZPosition = 0;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Labels.Shadow.Visible = false;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.DepthTop.Title.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Left.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.Left.AxisPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
         this.Chart.Axes.Left.AxisPen.Width = 1;
         // 
         // 
         // 
         this.Chart.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.Left.Grid.Visible = false;
         this.Chart.Axes.Left.Grid.ZPosition = 0;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Left.Labels.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Left.Labels.Font.Shadow.Visible = false;
         this.Chart.Axes.Left.Labels.Font.Size = 9;
         this.Chart.Axes.Left.Labels.Separation = 80;
         // 
         // 
         // 
         this.Chart.Axes.Left.Labels.Shadow.Visible = false;
         this.Chart.Axes.Left.Labels.ValueFormat = "###0.###";
         this.Chart.Axes.Left.MaximumOffset = 10;
         // 
         // 
         // 
         this.Chart.Axes.Left.MinorTicks.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         // 
         // 
         // 
         this.Chart.Axes.Left.Title.Caption = "Mild";
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
         this.Chart.Axes.Left.Title.Font.Name = "Tahoma";
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.Chart.Axes.Left.Title.Font.Shadow.Visible = false;
         this.Chart.Axes.Left.Title.Font.Size = 11;
         this.Chart.Axes.Left.Title.Lines = new string[] {
        "Mild"};
         // 
         // 
         // 
         this.Chart.Axes.Left.Title.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Right.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.Right.AxisPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
         this.Chart.Axes.Right.AxisPen.Width = 1;
         // 
         // 
         // 
         this.Chart.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.Right.Grid.Visible = false;
         this.Chart.Axes.Right.Grid.ZPosition = 0;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Right.Labels.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Right.Labels.Font.Shadow.Visible = false;
         this.Chart.Axes.Right.Labels.Font.Size = 9;
         this.Chart.Axes.Right.Labels.Separation = 80;
         // 
         // 
         // 
         this.Chart.Axes.Right.Labels.Shadow.Visible = false;
         this.Chart.Axes.Right.Labels.ValueFormat = "###0.###";
         // 
         // 
         // 
         this.Chart.Axes.Right.MinorTicks.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
         this.Chart.Axes.Right.Title.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Right.Title.Font.Shadow.Visible = false;
         this.Chart.Axes.Right.Title.Font.Size = 11;
         // 
         // 
         // 
         this.Chart.Axes.Right.Title.Shadow.Visible = false;
         this.Chart.Axes.Right.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Top.Automatic = true;
         // 
         // 
         // 
         this.Chart.Axes.Top.AxisPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
         this.Chart.Axes.Top.AxisPen.Width = 1;
         // 
         // 
         // 
         this.Chart.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
         this.Chart.Axes.Top.Grid.Visible = false;
         this.Chart.Axes.Top.Grid.ZPosition = 0;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Top.Labels.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Top.Labels.Font.Shadow.Visible = false;
         this.Chart.Axes.Top.Labels.Font.Size = 9;
         this.Chart.Axes.Top.Labels.Separation = 80;
         // 
         // 
         // 
         this.Chart.Axes.Top.Labels.Shadow.Visible = false;
         this.Chart.Axes.Top.Labels.ValueFormat = "###0.###";
         // 
         // 
         // 
         this.Chart.Axes.Top.MinorTicks.Visible = false;
         // 
         // 
         // 
         this.Chart.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
         this.Chart.Axes.Top.Title.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Axes.Top.Title.Font.Shadow.Visible = false;
         this.Chart.Axes.Top.Title.Font.Size = 11;
         // 
         // 
         // 
         this.Chart.Axes.Top.Title.Shadow.Visible = false;
         this.Chart.Axes.Top.Visible = false;
         this.Chart.BackColor = System.Drawing.SystemColors.Window;
         this.Chart.ContextMenuStrip = this.PopupMenu;
         this.Chart.Cursor = System.Windows.Forms.Cursors.Default;
         this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Footer.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Footer.Shadow.Visible = false;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Header.Font.Name = "Tahoma";
         // 
         // 
         // 
         this.Chart.Header.Font.Shadow.Visible = false;
         this.Chart.Header.Font.Size = 12;
         this.Chart.Header.Lines = new string[] {
        ""};
         // 
         // 
         // 
         this.Chart.Header.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
         this.Chart.Legend.CheckBoxes = true;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Legend.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Legend.Shadow.Visible = false;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Legend.Title.Font.Bold = true;
         // 
         // 
         // 
         this.Chart.Legend.Title.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Legend.Title.Pen.Visible = false;
         // 
         // 
         // 
         this.Chart.Legend.Title.Shadow.Visible = false;
         this.Chart.Legend.Transparent = true;
         this.Chart.Legend.Visible = false;
         this.Chart.Location = new System.Drawing.Point(0, 16);
         this.Chart.Name = "Chart";
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
         // 
         // 
         // 
         this.Chart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         // 
         // 
         // 
         this.Chart.Panel.ImageBevel.Width = 1;
         // 
         // 
         // 
         this.Chart.Panel.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Panning.MouseButton = System.Windows.Forms.MouseButtons.Middle;
         this.Chart.Size = new System.Drawing.Size(655, 525);
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.SubFooter.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.SubFooter.Shadow.Visible = false;
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.SubHeader.Font.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.SubHeader.Shadow.Visible = false;
         this.Chart.TabIndex = 3;
         // 
         // 
         // 
         // 
         // 
         // 
         this.Chart.Walls.Back.AutoHide = false;
         // 
         // 
         // 
         this.Chart.Walls.Back.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Walls.Bottom.AutoHide = false;
         // 
         // 
         // 
         this.Chart.Walls.Bottom.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Walls.Left.AutoHide = false;
         // 
         // 
         // 
         this.Chart.Walls.Left.Shadow.Visible = false;
         // 
         // 
         // 
         this.Chart.Walls.Right.AutoHide = false;
         // 
         // 
         // 
         this.Chart.Walls.Right.Shadow.Visible = false;
         this.Chart.Walls.Visible = false;
         // 
         // 
         // 
         this.Chart.Zoom.Animated = true;
         this.Chart.Zoom.AnimatedSteps = 4;
         this.Chart.Scroll += new System.EventHandler(this.OnScroll);
         this.Chart.UndoneZoom += new System.EventHandler(this.OnUndoZoom);
         this.Chart.Zoomed += new System.EventHandler(this.OnZoomed);
         // 
         // PopupMenu
         // 
         this.PopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToClipboardMenu,
            this.CopyDataMenu,
            this.toolStripSeparator1,
            this.EditGraphMenu,
            this.RemoveAllFormattingMenu});
         this.PopupMenu.Name = "ContextMenu";
         this.PopupMenu.Size = new System.Drawing.Size(195, 98);
         // 
         // CopyToClipboardMenu
         // 
         this.CopyToClipboardMenu.Name = "CopyToClipboardMenu";
         this.CopyToClipboardMenu.Size = new System.Drawing.Size(194, 22);
         this.CopyToClipboardMenu.Text = "Copy to clipboard";
         this.CopyToClipboardMenu.Click += new System.EventHandler(this.CopyToClipboardMenu_Click);
         // 
         // CopyDataMenu
         // 
         this.CopyDataMenu.Name = "CopyDataMenu";
         this.CopyDataMenu.Size = new System.Drawing.Size(194, 22);
         this.CopyDataMenu.Text = "Copy data to clipboard";
         this.CopyDataMenu.Click += new System.EventHandler(this.OnCopyDataClick);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
         // 
         // EditGraphMenu
         // 
         this.EditGraphMenu.Name = "EditGraphMenu";
         this.EditGraphMenu.Size = new System.Drawing.Size(194, 22);
         this.EditGraphMenu.Text = "Format graph";
         this.EditGraphMenu.Click += new System.EventHandler(this.OnEditGraphMenuClick);
         // 
         // RemoveAllFormattingMenu
         // 
         this.RemoveAllFormattingMenu.Name = "RemoveAllFormattingMenu";
         this.RemoveAllFormattingMenu.Size = new System.Drawing.Size(194, 22);
         this.RemoveAllFormattingMenu.Text = "Remove all formatting";
         this.RemoveAllFormattingMenu.Click += new System.EventHandler(this.OnRemoveAllFormattingMenu);
         // 
         // PrintForm
         // 
         this.PrintForm.BodyContainer = this;
         this.PrintForm.IgnoreVisibilityErrors = true;
         // 
         // GraphUI
         // 
         this.Controls.Add(this.Chart);
         this.Name = "GraphUI";
         this.Controls.SetChildIndex(this.MyHelpLabel, 0);
         this.Controls.SetChildIndex(this.Chart, 0);
         this.PopupMenu.ResumeLayout(false);
         this.ResumeLayout(false);

         }

      #endregion

      public Steema.TeeChart.TChart Chart;
      private System.Windows.Forms.ContextMenuStrip PopupMenu;
      private System.Windows.Forms.ToolStripMenuItem EditGraphMenu;
      private TMGDevelopment.Windows.Forms.PrintForm PrintForm;
      private System.Windows.Forms.ToolStripMenuItem CopyToClipboardMenu;
      private System.Windows.Forms.ToolStripMenuItem RemoveAllFormattingMenu;
      private System.Windows.Forms.ToolStripMenuItem CopyDataMenu;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

      }
   }
using System.ComponentModel;
using System.Windows.Forms;

namespace VisioDrawingControl
  {
  partial class MainForm
    {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.ribbon1 = new System.Windows.Forms.Ribbon();
      this.ribbonOrbNewMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbOpenMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbSaveMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbSaveAsMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbCloseMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbQuitMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
      this.ribbonFormatPanel = new System.Windows.Forms.RibbonPanel();
      this.ribbonToolPanel = new System.Windows.Forms.RibbonPanel();
      this.ribbonButtonDrawRect = new System.Windows.Forms.RibbonButton();
      this.ribbonButtonLineFill = new System.Windows.Forms.RibbonButton();
      this.axDrawingControl = new AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl();
      ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon1
      // 
      this.ribbon1.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.ribbon1.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.Minimized = false;
      this.ribbon1.Name = "ribbon1";
      // 
      // 
      // 
      this.ribbon1.OrbDropDown.BorderRoundness = 8;
      this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbNewMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbOpenMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbSaveMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbSaveAsMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbCloseMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbQuitMenuItem);
      this.ribbon1.OrbDropDown.Name = "";
      this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 386);
      this.ribbon1.OrbDropDown.TabIndex = 0;
      this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
      this.ribbon1.OrbText = "FILE";
      this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
      this.ribbon1.Size = new System.Drawing.Size(928, 150);
      this.ribbon1.TabIndex = 0;
      this.ribbon1.Tabs.Add(this.ribbonTab1);
      this.ribbon1.TabSpacing = 3;
      this.ribbon1.Text = "ribbon1";
      this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
      // 
      // ribbonOrbNewMenuItem
      // 
      this.ribbonOrbNewMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbNewMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbNewMenuItem.Image")));
      this.ribbonOrbNewMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbNewMenuItem.LargeImage")));
      this.ribbonOrbNewMenuItem.Name = "ribbonOrbNewMenuItem";
      this.ribbonOrbNewMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbNewMenuItem.SmallImage")));
      this.ribbonOrbNewMenuItem.Text = "New";
      this.ribbonOrbNewMenuItem.Click += new System.EventHandler(this.ribbonOrbNewMenuItem_Click);
      // 
      // ribbonOrbOpenMenuItem
      // 
      this.ribbonOrbOpenMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbOpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOpenMenuItem.Image")));
      this.ribbonOrbOpenMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOpenMenuItem.LargeImage")));
      this.ribbonOrbOpenMenuItem.Name = "ribbonOrbOpenMenuItem";
      this.ribbonOrbOpenMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOpenMenuItem.SmallImage")));
      this.ribbonOrbOpenMenuItem.Text = "Open";
      this.ribbonOrbOpenMenuItem.Click += new System.EventHandler(this.ribbonOrbOpenMenuItem_Click);
      // 
      // ribbonOrbSaveMenuItem
      // 
      this.ribbonOrbSaveMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbSaveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveMenuItem.Image")));
      this.ribbonOrbSaveMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveMenuItem.LargeImage")));
      this.ribbonOrbSaveMenuItem.Name = "ribbonOrbSaveMenuItem";
      this.ribbonOrbSaveMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveMenuItem.SmallImage")));
      this.ribbonOrbSaveMenuItem.Text = "Save";
      // 
      // ribbonOrbSaveAsMenuItem
      // 
      this.ribbonOrbSaveAsMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbSaveAsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.Image")));
      this.ribbonOrbSaveAsMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.LargeImage")));
      this.ribbonOrbSaveAsMenuItem.Name = "ribbonOrbSaveAsMenuItem";
      this.ribbonOrbSaveAsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.SmallImage")));
      this.ribbonOrbSaveAsMenuItem.Text = "Save As";
      this.ribbonOrbSaveAsMenuItem.Click += new System.EventHandler(this.ribbonOrbSaveAsMenuItem_Click);
      // 
      // ribbonOrbCloseMenuItem
      // 
      this.ribbonOrbCloseMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbCloseMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbCloseMenuItem.Image")));
      this.ribbonOrbCloseMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbCloseMenuItem.LargeImage")));
      this.ribbonOrbCloseMenuItem.Name = "ribbonOrbCloseMenuItem";
      this.ribbonOrbCloseMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbCloseMenuItem.SmallImage")));
      this.ribbonOrbCloseMenuItem.Text = "Close";
      this.ribbonOrbCloseMenuItem.Click += new System.EventHandler(this.ribbonOrbCloseMenuItem_Click);
      // 
      // ribbonOrbQuitMenuItem
      // 
      this.ribbonOrbQuitMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbQuitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbQuitMenuItem.Image")));
      this.ribbonOrbQuitMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbQuitMenuItem.LargeImage")));
      this.ribbonOrbQuitMenuItem.Name = "ribbonOrbQuitMenuItem";
      this.ribbonOrbQuitMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbQuitMenuItem.SmallImage")));
      this.ribbonOrbQuitMenuItem.Text = "Quit";
      this.ribbonOrbQuitMenuItem.Click += new System.EventHandler(this.ribbonOrbQuitMenuItem_Click);
      // 
      // ribbonTab1
      // 
      this.ribbonTab1.Name = "ribbonTab1";
      this.ribbonTab1.Panels.Add(this.ribbonToolPanel);
      this.ribbonTab1.Panels.Add(this.ribbonFormatPanel);
      this.ribbonTab1.Text = "Home";
      // 
      // ribbonToolPanel
      // 
      this.ribbonToolPanel.Items.Add(this.ribbonButtonDrawRect);
      this.ribbonToolPanel.Name = "ribbonToolPanel";
      this.ribbonToolPanel.Text = "Tools";
      // 
      // ribbonButtonDrawRect
      // 
      this.ribbonButtonDrawRect.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawRect.Image")));
      this.ribbonButtonDrawRect.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawRect.LargeImage")));
      this.ribbonButtonDrawRect.Name = "ribbonButtonDrawRect";
      this.ribbonButtonDrawRect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawRect.SmallImage")));
      this.ribbonButtonDrawRect.Text = "Rectangle";
      this.ribbonButtonDrawRect.Click += new System.EventHandler(this.ribbonButtonDrawRect_Click);
      // 
      // ribbonFormatPanel
      // 
      this.ribbonFormatPanel.Items.Add(this.ribbonButtonLineFill);
      this.ribbonFormatPanel.Name = "ribbonFormatPanel";
      this.ribbonFormatPanel.Text = "Format";
      // 
      // ribbonButtonLineFill
      // 
      this.ribbonButtonLineFill.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.Image")));
      this.ribbonButtonLineFill.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.LargeImage")));
      this.ribbonButtonLineFill.Name = "ribbonButtonLineFill";
      this.ribbonButtonLineFill.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.SmallImage")));
      this.ribbonButtonLineFill.Text = "Format Shape";
      this.ribbonButtonLineFill.Click += new System.EventHandler(this.ribbonButtonFormatFill_Click);
      // 
      // axDrawingControl
      // 
      this.axDrawingControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axDrawingControl.Enabled = true;
      this.axDrawingControl.Location = new System.Drawing.Point(0, 150);
      this.axDrawingControl.Name = "axDrawingControl";
      this.axDrawingControl.Size = new System.Drawing.Size(928, 341);
      this.axDrawingControl.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 491);
      this.Controls.Add(this.axDrawingControl);
      this.Controls.Add(this.ribbon1);
      this.KeyPreview = true;
      this.Name = "MainForm";
      this.Text = "Visio Drawing Control";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion

    private RibbonTab ribbonTab1;
    protected Ribbon ribbon1;
    private RibbonOrbMenuItem ribbonOrbNewMenuItem;
    private RibbonOrbMenuItem ribbonOrbOpenMenuItem;
    private RibbonOrbMenuItem ribbonOrbSaveMenuItem;
    private RibbonOrbMenuItem ribbonOrbSaveAsMenuItem;
    private RibbonOrbMenuItem ribbonOrbCloseMenuItem;
    private RibbonOrbMenuItem ribbonOrbQuitMenuItem;
    private AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl axDrawingControl;
    private RibbonPanel ribbonToolPanel;
    private RibbonPanel ribbonFormatPanel;
    private RibbonButton ribbonButtonDrawRect;   
    private RibbonButton ribbonButtonLineFill;
    }
  }
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
      this.ribbonSeparator6 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem2 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem3 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem4 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem5 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonOrbCloseMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonOrbPrintMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonSeparator5 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonDescriptionMenuItem6 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem7 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonDescriptionMenuItem8 = new System.Windows.Forms.RibbonDescriptionMenuItem();
      this.ribbonSeparator4 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonOrbQuitMenuItem = new System.Windows.Forms.RibbonOrbMenuItem();
      this.dropDownButtonSave = new System.Windows.Forms.RibbonButton();
      this.dropDownButtonPrint = new System.Windows.Forms.RibbonButton();
      this.dropDownButtonUndo = new System.Windows.Forms.RibbonButton();
      this.dropDownButtonOpen = new System.Windows.Forms.RibbonButton();
      this.ribbonButton42 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton43 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton44 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton45 = new System.Windows.Forms.RibbonButton();
      this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
      this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
      this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
      this.ribbonSeparator7 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
      this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
      this.ribbonPanelVisio = new System.Windows.Forms.RibbonPanel();
      this.ribbonButtonLineFill = new System.Windows.Forms.RibbonButton();
      this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
      this.ribbonOrbRecentItem2 = new System.Windows.Forms.RibbonOrbRecentItem();
      this.ribbonOrbRecentItem3 = new System.Windows.Forms.RibbonOrbRecentItem();
      this.axDrawingControl = new AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl();
      this.ribbonCheckBox1 = new System.Windows.Forms.RibbonCheckBox();
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
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator3);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbPrintMenuItem);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator4);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbQuitMenuItem);
      this.ribbon1.OrbDropDown.Name = "";
      this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 386);
      this.ribbon1.OrbDropDown.TabIndex = 0;
      this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
      this.ribbon1.OrbText = "FILE";
      // 
      // 
      // 
      this.ribbon1.QuickAccessToolbar.DropDownButtonItems.Add(this.dropDownButtonSave);
      this.ribbon1.QuickAccessToolbar.DropDownButtonItems.Add(this.dropDownButtonPrint);
      this.ribbon1.QuickAccessToolbar.DropDownButtonItems.Add(this.dropDownButtonUndo);
      this.ribbon1.QuickAccessToolbar.DropDownButtonItems.Add(this.dropDownButtonOpen);
      this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton42);
      this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton43);
      this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton44);
      this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton45);
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
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonSeparator6);
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem1);
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem2);
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem3);
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem4);
      this.ribbonOrbSaveAsMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem5);
      this.ribbonOrbSaveAsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.Image")));
      this.ribbonOrbSaveAsMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.LargeImage")));
      this.ribbonOrbSaveAsMenuItem.Name = "ribbonOrbSaveAsMenuItem";
      this.ribbonOrbSaveAsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSaveAsMenuItem.SmallImage")));
      this.ribbonOrbSaveAsMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
      this.ribbonOrbSaveAsMenuItem.Text = "Save as";
      // 
      // ribbonSeparator6
      // 
      this.ribbonSeparator6.Name = "ribbonSeparator6";
      this.ribbonSeparator6.Text = "Save a copy of the document";
      // 
      // ribbonDescriptionMenuItem1
      // 
      this.ribbonDescriptionMenuItem1.Description = "Save the document in the default file format";
      this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(46, 24, 315, 28);
      this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem1.Image = global::VisioDrawingControl.Properties.Resources.worddocument32;
      this.ribbonDescriptionMenuItem1.LargeImage = global::VisioDrawingControl.Properties.Resources.worddocument32;
      this.ribbonDescriptionMenuItem1.Name = "ribbonDescriptionMenuItem1";
      this.ribbonDescriptionMenuItem1.SmallImage = global::VisioDrawingControl.Properties.Resources.worddocument32;
      this.ribbonDescriptionMenuItem1.Text = "Word Document";
      // 
      // ribbonDescriptionMenuItem2
      // 
      this.ribbonDescriptionMenuItem2.Description = "Save the document as a template that can be used to format future documents";
      this.ribbonDescriptionMenuItem2.DescriptionBounds = new System.Drawing.Rectangle(46, 76, 315, 28);
      this.ribbonDescriptionMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem2.Image = global::VisioDrawingControl.Properties.Resources.wordtemplate32;
      this.ribbonDescriptionMenuItem2.LargeImage = global::VisioDrawingControl.Properties.Resources.wordtemplate32;
      this.ribbonDescriptionMenuItem2.Name = "ribbonDescriptionMenuItem2";
      this.ribbonDescriptionMenuItem2.SmallImage = global::VisioDrawingControl.Properties.Resources.wordtemplate32;
      this.ribbonDescriptionMenuItem2.Text = "Word Template";
      // 
      // ribbonDescriptionMenuItem3
      // 
      this.ribbonDescriptionMenuItem3.Description = "Save a copy of the document that is fully compatible with  Word 93 - 2007";
      this.ribbonDescriptionMenuItem3.DescriptionBounds = new System.Drawing.Rectangle(46, 128, 315, 28);
      this.ribbonDescriptionMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem3.Image = global::VisioDrawingControl.Properties.Resources.word2003doc32;
      this.ribbonDescriptionMenuItem3.LargeImage = global::VisioDrawingControl.Properties.Resources.word2003doc32;
      this.ribbonDescriptionMenuItem3.Name = "ribbonDescriptionMenuItem3";
      this.ribbonDescriptionMenuItem3.SmallImage = global::VisioDrawingControl.Properties.Resources.word2003doc32;
      this.ribbonDescriptionMenuItem3.Text = "Word 97 - 2003";
      // 
      // ribbonDescriptionMenuItem4
      // 
      this.ribbonDescriptionMenuItem4.Description = "Learn about add-ins to save to other formats like XPS or PDF";
      this.ribbonDescriptionMenuItem4.DescriptionBounds = new System.Drawing.Rectangle(46, 180, 315, 28);
      this.ribbonDescriptionMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem4.Image = global::VisioDrawingControl.Properties.Resources.addons32;
      this.ribbonDescriptionMenuItem4.LargeImage = global::VisioDrawingControl.Properties.Resources.addons32;
      this.ribbonDescriptionMenuItem4.Name = "ribbonDescriptionMenuItem4";
      this.ribbonDescriptionMenuItem4.SmallImage = global::VisioDrawingControl.Properties.Resources.addons32;
      this.ribbonDescriptionMenuItem4.Text = "Find add-ins for other file formats";
      // 
      // ribbonDescriptionMenuItem5
      // 
      this.ribbonDescriptionMenuItem5.Description = "Open the save as dialog to choose between the all available formats to save.";
      this.ribbonDescriptionMenuItem5.DescriptionBounds = new System.Drawing.Rectangle(46, 232, 315, 28);
      this.ribbonDescriptionMenuItem5.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem5.Image = global::VisioDrawingControl.Properties.Resources.saveas321;
      this.ribbonDescriptionMenuItem5.LargeImage = global::VisioDrawingControl.Properties.Resources.saveas321;
      this.ribbonDescriptionMenuItem5.Name = "ribbonDescriptionMenuItem5";
      this.ribbonDescriptionMenuItem5.SmallImage = global::VisioDrawingControl.Properties.Resources.saveas321;
      this.ribbonDescriptionMenuItem5.Text = "Other Formats";
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
      // ribbonSeparator3
      // 
      this.ribbonSeparator3.Name = "ribbonSeparator3";
      // 
      // ribbonOrbPrintMenuItem
      // 
      this.ribbonOrbPrintMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbPrintMenuItem.DropDownItems.Add(this.ribbonSeparator5);
      this.ribbonOrbPrintMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem6);
      this.ribbonOrbPrintMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem7);
      this.ribbonOrbPrintMenuItem.DropDownItems.Add(this.ribbonDescriptionMenuItem8);
      this.ribbonOrbPrintMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbPrintMenuItem.Image")));
      this.ribbonOrbPrintMenuItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbPrintMenuItem.LargeImage")));
      this.ribbonOrbPrintMenuItem.Name = "ribbonOrbPrintMenuItem";
      this.ribbonOrbPrintMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbPrintMenuItem.SmallImage")));
      this.ribbonOrbPrintMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
      this.ribbonOrbPrintMenuItem.Text = "Print";
      // 
      // ribbonSeparator5
      // 
      this.ribbonSeparator5.Name = "ribbonSeparator5";
      this.ribbonSeparator5.Text = "Preview and print the document";
      // 
      // ribbonDescriptionMenuItem6
      // 
      this.ribbonDescriptionMenuItem6.Description = "Select a printer, number of copies and other options before printing";
      this.ribbonDescriptionMenuItem6.DescriptionBounds = new System.Drawing.Rectangle(46, 45, 315, 28);
      this.ribbonDescriptionMenuItem6.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem6.Image = global::VisioDrawingControl.Properties.Resources.print321;
      this.ribbonDescriptionMenuItem6.LargeImage = global::VisioDrawingControl.Properties.Resources.print321;
      this.ribbonDescriptionMenuItem6.Name = "ribbonDescriptionMenuItem6";
      this.ribbonDescriptionMenuItem6.SmallImage = global::VisioDrawingControl.Properties.Resources.print321;
      this.ribbonDescriptionMenuItem6.Text = "Print";
      // 
      // ribbonDescriptionMenuItem7
      // 
      this.ribbonDescriptionMenuItem7.Description = "Send the document directly to the printer without making changes";
      this.ribbonDescriptionMenuItem7.DescriptionBounds = new System.Drawing.Rectangle(46, 97, 315, 28);
      this.ribbonDescriptionMenuItem7.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem7.Image = global::VisioDrawingControl.Properties.Resources.printquick32;
      this.ribbonDescriptionMenuItem7.LargeImage = global::VisioDrawingControl.Properties.Resources.printquick32;
      this.ribbonDescriptionMenuItem7.Name = "ribbonDescriptionMenuItem7";
      this.ribbonDescriptionMenuItem7.SmallImage = global::VisioDrawingControl.Properties.Resources.printquick32;
      this.ribbonDescriptionMenuItem7.Text = "Quick Print";
      // 
      // ribbonDescriptionMenuItem8
      // 
      this.ribbonDescriptionMenuItem8.Description = "Preview and make changes to pages before printing.";
      this.ribbonDescriptionMenuItem8.DescriptionBounds = new System.Drawing.Rectangle(46, 149, 315, 28);
      this.ribbonDescriptionMenuItem8.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonDescriptionMenuItem8.Image = global::VisioDrawingControl.Properties.Resources.printpreview32;
      this.ribbonDescriptionMenuItem8.LargeImage = global::VisioDrawingControl.Properties.Resources.printpreview32;
      this.ribbonDescriptionMenuItem8.Name = "ribbonDescriptionMenuItem8";
      this.ribbonDescriptionMenuItem8.SmallImage = global::VisioDrawingControl.Properties.Resources.printpreview32;
      this.ribbonDescriptionMenuItem8.Text = "Print Preview";
      // 
      // ribbonSeparator4
      // 
      this.ribbonSeparator4.Name = "ribbonSeparator4";
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
      // dropDownButtonSave
      // 
      this.dropDownButtonSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.dropDownButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButtonSave.Image")));
      this.dropDownButtonSave.LargeImage = ((System.Drawing.Image)(resources.GetObject("dropDownButtonSave.LargeImage")));
      this.dropDownButtonSave.Name = "dropDownButtonSave";
      this.dropDownButtonSave.SmallImage = global::VisioDrawingControl.Properties.Resources.exit16;
      this.dropDownButtonSave.Text = "Save";
      this.dropDownButtonSave.Click += new System.EventHandler(this.dropDownButtonSave_Click);
      // 
      // dropDownButtonPrint
      // 
      this.dropDownButtonPrint.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.dropDownButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButtonPrint.Image")));
      this.dropDownButtonPrint.LargeImage = ((System.Drawing.Image)(resources.GetObject("dropDownButtonPrint.LargeImage")));
      this.dropDownButtonPrint.Name = "dropDownButtonPrint";
      this.dropDownButtonPrint.SmallImage = global::VisioDrawingControl.Properties.Resources.exit16;
      this.dropDownButtonPrint.Text = "Print";
      this.dropDownButtonPrint.Click += new System.EventHandler(this.dropDownButtonPrint_Click);
      // 
      // dropDownButtonUndo
      // 
      this.dropDownButtonUndo.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.dropDownButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButtonUndo.Image")));
      this.dropDownButtonUndo.LargeImage = ((System.Drawing.Image)(resources.GetObject("dropDownButtonUndo.LargeImage")));
      this.dropDownButtonUndo.Name = "dropDownButtonUndo";
      this.dropDownButtonUndo.SmallImage = global::VisioDrawingControl.Properties.Resources.exit16;
      this.dropDownButtonUndo.Text = "Undo";
      this.dropDownButtonUndo.Click += new System.EventHandler(this.dropDownButtonUndo_Click);
      // 
      // dropDownButtonOpen
      // 
      this.dropDownButtonOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.dropDownButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButtonOpen.Image")));
      this.dropDownButtonOpen.LargeImage = ((System.Drawing.Image)(resources.GetObject("dropDownButtonOpen.LargeImage")));
      this.dropDownButtonOpen.Name = "dropDownButtonOpen";
      this.dropDownButtonOpen.SmallImage = global::VisioDrawingControl.Properties.Resources.exit16;
      this.dropDownButtonOpen.Text = "Open";
      this.dropDownButtonOpen.Click += new System.EventHandler(this.dropDownButtonOpen_Click);
      // 
      // ribbonButton42
      // 
      this.ribbonButton42.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton42.Image")));
      this.ribbonButton42.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton42.LargeImage")));
      this.ribbonButton42.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButton42.Name = "ribbonButton42";
      this.ribbonButton42.SmallImage = global::VisioDrawingControl.Properties.Resources.save16;
      this.ribbonButton42.Text = "ribbonButton42";
      this.ribbonButton42.ToolTip = "Save";
      // 
      // ribbonButton43
      // 
      this.ribbonButton43.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton43.Image")));
      this.ribbonButton43.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton43.LargeImage")));
      this.ribbonButton43.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButton43.Name = "ribbonButton43";
      this.ribbonButton43.SmallImage = global::VisioDrawingControl.Properties.Resources.printquick16;
      this.ribbonButton43.Text = "ribbonButton43";
      this.ribbonButton43.ToolTip = "Print";
      // 
      // ribbonButton44
      // 
      this.ribbonButton44.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton44.Image")));
      this.ribbonButton44.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton44.LargeImage")));
      this.ribbonButton44.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButton44.Name = "ribbonButton44";
      this.ribbonButton44.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton44.SmallImage")));
      this.ribbonButton44.Text = "ribbonButton44";
      this.ribbonButton44.ToolTip = "Undo";
      // 
      // ribbonButton45
      // 
      this.ribbonButton45.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton45.Image")));
      this.ribbonButton45.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton45.LargeImage")));
      this.ribbonButton45.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButton45.Name = "ribbonButton45";
      this.ribbonButton45.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton45.SmallImage")));
      this.ribbonButton45.Text = "ribbonButton45";
      this.ribbonButton45.ToolTip = "Open";
      // 
      // ribbonTab1
      // 
      this.ribbonTab1.Name = "ribbonTab1";
      this.ribbonTab1.Panels.Add(this.ribbonPanel1);
      this.ribbonTab1.Panels.Add(this.ribbonPanelVisio);
      this.ribbonTab1.Text = "Home";
      // 
      // ribbonPanel1
      // 
      this.ribbonPanel1.Items.Add(this.ribbonButton1);
      this.ribbonPanel1.Items.Add(this.ribbonSeparator7);
      this.ribbonPanel1.Items.Add(this.ribbonButton5);
      this.ribbonPanel1.Items.Add(this.ribbonButton6);
      this.ribbonPanel1.Items.Add(this.ribbonButton7);
      this.ribbonPanel1.Name = "ribbonPanel1";
      this.ribbonPanel1.Text = "Clipboard";
      // 
      // ribbonButton1
      // 
      this.ribbonButton1.DropDownItems.Add(this.ribbonButton2);
      this.ribbonButton1.DropDownItems.Add(this.ribbonButton3);
      this.ribbonButton1.DropDownItems.Add(this.ribbonButton4);
      this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
      this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
      this.ribbonButton1.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
      this.ribbonButton1.Name = "ribbonButton1";
      this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
      this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
      this.ribbonButton1.Text = "Paste";
      // 
      // ribbonButton2
      // 
      this.ribbonButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
      this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
      this.ribbonButton2.Name = "ribbonButton2";
      this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
      this.ribbonButton2.Text = "Paste";
      this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
      // 
      // ribbonButton3
      // 
      this.ribbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
      this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
      this.ribbonButton3.Name = "ribbonButton3";
      this.ribbonButton3.SmallImage = global::VisioDrawingControl.Properties.Resources.pastespecial16;
      this.ribbonButton3.Text = "Paste special...";
      // 
      // ribbonButton4
      // 
      this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
      this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
      this.ribbonButton4.Name = "ribbonButton4";
      this.ribbonButton4.SmallImage = global::VisioDrawingControl.Properties.Resources.pastelink16;
      this.ribbonButton4.Text = "Paste as link";
      // 
      // ribbonSeparator7
      // 
      this.ribbonSeparator7.Name = "ribbonSeparator7";
      // 
      // ribbonButton5
      // 
      this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
      this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
      this.ribbonButton5.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
      this.ribbonButton5.Name = "ribbonButton5";
      this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
      this.ribbonButton5.Text = "Cut";
      this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
      // 
      // ribbonButton6
      // 
      this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
      this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
      this.ribbonButton6.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
      this.ribbonButton6.Name = "ribbonButton6";
      this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
      this.ribbonButton6.Text = "Copy";
      // 
      // ribbonButton7
      // 
      this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
      this.ribbonButton7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.LargeImage")));
      this.ribbonButton7.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
      this.ribbonButton7.Name = "ribbonButton7";
      this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
      this.ribbonButton7.Text = "Paste";
      // 
      // ribbonPanelVisio
      // 
      this.ribbonPanelVisio.Items.Add(this.ribbonButtonLineFill);
      this.ribbonPanelVisio.Name = "ribbonPanelVisio";
      this.ribbonPanelVisio.Text = "Visio Command";
      // 
      // ribbonButtonLineFill
      // 
      this.ribbonButtonLineFill.DropDownItems.Add(this.ribbonCheckBox1);
      this.ribbonButtonLineFill.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.Image")));
      this.ribbonButtonLineFill.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.LargeImage")));
      this.ribbonButtonLineFill.Name = "ribbonButtonLineFill";
      this.ribbonButtonLineFill.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLineFill.SmallImage")));
      this.ribbonButtonLineFill.Text = "Line format";
      this.ribbonButtonLineFill.Click += new System.EventHandler(this.ribbonButtonLineFill_Click);
      // 
      // ribbonOrbRecentItem1
      // 
      this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
      this.ribbonOrbRecentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.LargeImage")));
      this.ribbonOrbRecentItem1.Name = "ribbonOrbRecentItem1";
      this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
      this.ribbonOrbRecentItem1.Text = "Recent Document 1";
      // 
      // ribbonOrbRecentItem2
      // 
      this.ribbonOrbRecentItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.Image")));
      this.ribbonOrbRecentItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.LargeImage")));
      this.ribbonOrbRecentItem2.Name = "ribbonOrbRecentItem2";
      this.ribbonOrbRecentItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.SmallImage")));
      this.ribbonOrbRecentItem2.Text = "Recent Document 2";
      // 
      // ribbonOrbRecentItem3
      // 
      this.ribbonOrbRecentItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem3.Image")));
      this.ribbonOrbRecentItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem3.LargeImage")));
      this.ribbonOrbRecentItem3.Name = "ribbonOrbRecentItem3";
      this.ribbonOrbRecentItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem3.SmallImage")));
      this.ribbonOrbRecentItem3.Text = "Recent Document 3";
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
      // ribbonCheckBox1
      // 
      this.ribbonCheckBox1.Name = "ribbonCheckBox1";
      this.ribbonCheckBox1.Text = "ribbonCheckBox1";
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
        private RibbonPanel ribbonPanel1;
        private RibbonButton ribbonButton1;
        protected Ribbon ribbon1;
        private RibbonButton ribbonButton2;
        private RibbonButton ribbonButton3;
        private RibbonButton ribbonButton4;
        private RibbonButton ribbonButton5;
        private RibbonButton ribbonButton6;
        private RibbonButton ribbonButton7;
        private RibbonButton ribbonButton42;
        private RibbonButton ribbonButton43;
        private RibbonButton ribbonButton44;
        private RibbonButton ribbonButton45;
        private RibbonOrbMenuItem ribbonOrbNewMenuItem;
        private RibbonOrbMenuItem ribbonOrbOpenMenuItem;
        private RibbonOrbMenuItem ribbonOrbSaveMenuItem;
        private RibbonOrbMenuItem ribbonOrbSaveAsMenuItem;
        private RibbonOrbMenuItem ribbonOrbCloseMenuItem;
        private RibbonSeparator ribbonSeparator3;
        private RibbonOrbMenuItem ribbonOrbPrintMenuItem;
        private RibbonSeparator ribbonSeparator4;
        private RibbonOrbMenuItem ribbonOrbQuitMenuItem;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem2;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem3;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem4;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem5;
        private RibbonSeparator ribbonSeparator5;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem6;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem7;
        private RibbonDescriptionMenuItem ribbonDescriptionMenuItem8;
        private RibbonSeparator ribbonSeparator6;
        private RibbonOrbOptionButton ribbonOrbOptionButton1;
        private RibbonOrbRecentItem ribbonOrbRecentItem1;
        private RibbonOrbRecentItem ribbonOrbRecentItem2;
        private RibbonOrbRecentItem ribbonOrbRecentItem3;
        private RibbonSeparator ribbonSeparator7;
        private RibbonButton dropDownButtonSave;
        private RibbonButton dropDownButtonPrint;
        private RibbonButton dropDownButtonUndo;
        private RibbonButton dropDownButtonOpen;
    private AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl axDrawingControl;
    private RibbonPanel ribbonPanelVisio;
    private RibbonButton ribbonButtonLineFill;
    private RibbonCheckBox ribbonCheckBox1;
    }
}
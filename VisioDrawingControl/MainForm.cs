// MainForm.cs
// Application VisioDrawingControl
// Copyright © ShareVisual Michel LAPLANE
// All rights reserved.

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VisioDrawingControl.Properties;
using static System.Windows.Forms.Theme;
using Visio = Microsoft.Office.Interop.Visio;

namespace VisioDrawingControl
  {
  public partial class MainForm : RibbonForm
    {
    public Visio.Application visApp = null;
    public Visio.Window visWindow;
    public Visio.Page visPage;
    public Visio.Document visDocument;
    public Visio.Documents visDocuments;
    public Visio.Document visStencil;

    string strStencilPath = @"D:\Dev\VisioDrawingControl\VisioDrawingControl\Stencils";
    string strDrawingPath = @"D:\Dev\VisioDrawingControl\VisioDrawingControl\Drawings";

    string strLastDocument="";

    public MainForm()
      {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
      }

    private Color GetRandomColor(Random r)
      {
      if (r == null)
        {
        r = new Random(DateTime.Now.Millisecond);
        }

      return Color.FromKnownColor((KnownColor)r.Next(1, 150));
      }

    private void MainForm_Load(object sender, EventArgs e)
      {
      visApp = (Visio.Application)axDrawingControl.Window.Application;
      visPage = (Visio.Page)axDrawingControl.Document.Pages[1];
      visWindow = (Visio.Window)axDrawingControl.Window;
      visDocument = (Visio.Document)axDrawingControl.Document;
      visDocuments = (Visio.Documents)axDrawingControl.Window.Application.Documents;
      axDrawingControl.NegotiateMenus = true;
      }

    private void ribbonOrbNewMenuItem_Click(object sender, EventArgs e)
      {
      axDrawingControl.Src = Path.Combine(strDrawingPath, "Blank.vsdx");
      string stencilPath = Path.Combine(strStencilPath, "VisioDrawingControl.vssx");
      visStencil = visDocuments.OpenEx(stencilPath, (short)Visio.VisOpenSaveArgs.visAddDocked);
      strLastDocument = "Blank.vsdx";
      }


    private void ribbonOrbOpenMenuItem_Click(object sender, EventArgs e)
      {
      OpenFileDialog dlgOpenFileDialog;

      dlgOpenFileDialog = new OpenFileDialog();
      dlgOpenFileDialog.Title = "Select a Diagram";
      dlgOpenFileDialog.Filter = "Drawing (*.vsdx)|*.vsdx";
      dlgOpenFileDialog.FilterIndex = 1;  // 1 based index
      dlgOpenFileDialog.InitialDirectory = strDrawingPath;

      if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
        {
        try
          {
          this.Text = "Project : " + dlgOpenFileDialog.FileName;
          // La ligne qui suit fait afficher le fichier
          this.axDrawingControl.Src = dlgOpenFileDialog.FileName;
          visApp = (Visio.Application)axDrawingControl.Window.Application;
          visPage = (Visio.Page)axDrawingControl.Document.Pages[1];
          visWindow = (Visio.Window)axDrawingControl.Window;
          visDocument = (Visio.Document)axDrawingControl.Document;
          visDocuments = (Visio.Documents)axDrawingControl.Window.Application.Documents;
          visStencil = (Visio.Document)axDrawingControl.Document;

          }
        catch (Exception excep)
          {

          }
        }
      }

    private void ribbonOrbSaveMenuItem_Click(object sender, EventArgs e)
      {
      if(strLastDocument == "Blank.vsdx")
        {
        SaveFileDialog dlgSaveFileDialog;

        dlgSaveFileDialog = new SaveFileDialog();
        dlgSaveFileDialog.Title = "Save as";
        dlgSaveFileDialog.Filter = "Dessin (*.vsdx)|*.vsdx";
        dlgSaveFileDialog.FilterIndex = 1;  // 1 based index
        dlgSaveFileDialog.InitialDirectory = strDrawingPath;

        if (dlgSaveFileDialog.ShowDialog() == DialogResult.OK)
          {
          try
            {
            this.Text = "Project : " + dlgSaveFileDialog.FileName;
            visDocument.SaveAs(dlgSaveFileDialog.FileName);
            // La ligne qui suit fait afficher le fichier
            this.axDrawingControl.Src = dlgSaveFileDialog.FileName;
            }
          catch (Exception excep)
            {
            }
          }
        }
      else
        {
        visDocument.Save();
        }
      }


      private void ribbonOrbSaveAsMenuItem_Click(object sender, EventArgs e)
      {
      SaveFileDialog dlgSaveFileDialog;

      dlgSaveFileDialog = new SaveFileDialog();
      dlgSaveFileDialog.Title = "Save as";
      dlgSaveFileDialog.Filter = "Drawing (*.vsdx)|*.vsdx";
      dlgSaveFileDialog.FilterIndex = 1;  // 1 based index
      dlgSaveFileDialog.InitialDirectory = strDrawingPath;

      if (dlgSaveFileDialog.ShowDialog() == DialogResult.OK)
        {
        try
          {
          this.Text = "Projet : " + dlgSaveFileDialog.FileName;
          visDocument.SaveAs(dlgSaveFileDialog.FileName);
          // La ligne qui suit fait afficher le fichier
          this.axDrawingControl.Src = dlgSaveFileDialog.FileName;
          }
        catch (Exception excep)
          {

          }
        }
      }

    private void ribbonOrbCloseMenuItem_Click(object sender, EventArgs e)
      {
      axDrawingControl.Src = Path.Combine(strDrawingPath, "Blank.vsdx");
      }


    private void ribbonOrbQuitMenuItem_Click(object sender, EventArgs e)
      {
      Close();
      }

    private void FindVisioWindows()
      {
      IntPtr windowVisioMHandle = NativeMethods.FindWindowEx((System.IntPtr)visApp.Window.WindowHandle32,
                                                              IntPtr.Zero, "VISIOM", null);
      IntPtr windowVisioGHandle = NativeMethods.FindWindowEx((System.IntPtr)windowVisioMHandle,
                                                              IntPtr.Zero, "VISIOG", null);
      IntPtr windowPrevHandle = NativeMethods.GetWindow(windowVisioGHandle, NativeMethods.GW_HWNDPREV);
      if (windowPrevHandle != null)
        {
        IntPtr windowFormeVisioHandle = NativeMethods.FindWindowEx((System.IntPtr)windowPrevHandle,
                                                              IntPtr.Zero, null, "Formes");
        NativeMethods.CloseWindow(windowFormeVisioHandle);
        }
      }


    public static int SendCommand(IOleCommandTarget commandTarget, uint uiCommand)
      {
      int iCompteRendu = -1;

      try
        {
        Guid CLSID_Application = new Guid("{0x00021A20, 0x0000, 0x0000," +
          "{0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46}}");
        iCompteRendu = commandTarget.Exec(ref CLSID_Application, uiCommand,
          0, null, null);
        }
      catch (COMException except)
        {
        MessageBox.Show("Application error: ");
        }
      return iCompteRendu;
      }

    private void ribbonButtonFormatFill_Click(object sender, EventArgs e)
      {
      SendCommand((IOleCommandTarget)axDrawingControl.GetOcx(),
                          (UInt32)Visio.VisUICmds.visCmdFormatFill);
      }

    private void ribbonButtonDrawRect_Click(object sender, EventArgs e)
      {
      SendCommand((IOleCommandTarget)axDrawingControl.GetOcx(),
                          (UInt32)Visio.VisUICmds.visCmdDRRectTool);
      }

    }



  [ComImport(), Guid("B722BCCB-4E68-101B-A2BC-00AA00404770"),
InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IOleCommandTarget
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pguidCmdGroup"></param>
    /// <param name="cCmds"></param>
    /// <param name="prgCmds"></param>
    /// <param name="pCmdText"></param>
    /// <returns></returns>
    [PreserveSig()]
    int QueryStatus([In, MarshalAs(UnmanagedType.Struct)] ref Guid
      pguidCmdGroup, [MarshalAs(UnmanagedType.U4)] int cCmds,
      [In, Out] IntPtr prgCmds, [In, Out] IntPtr pCmdText);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pguidCmdGroup"></param>
    /// <param name="nCmdID"></param>
    /// <param name="nCmdExecOpt"></param>
    /// <param name="pvaIn"></param>
    /// <param name="pvaOut"></param>
    /// <returns></returns>
    [PreserveSig()]
    int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdExecOpt,
      object[] pvaIn, [In, Out, MarshalAs(UnmanagedType.LPArray)]
      object[] pvaOut);
    }



  class NativeMethods
    {
    /// <summary>Windows constant - Sets a new window style.</summary>
    internal const short GWL_STYLE = (-16);

    /// <summary>Windows constant - search next window.</summary>
    public const int GW_HWNDNEXT = 2;
    public const int GW_HWNDPREV = 3;

    /// <summary>Windows constant - Creates a child window..</summary>
    internal const int WS_CHILD = 0x40000000;
    /// <summary>Windows constant - Creates a window that is initially
    /// visible.</summary>
    internal const int WS_VISIBLE = 0x10000000;
    /// <summary>Windows constant - Creates a window that is initially
    /// visible.</summary>
    internal const int WM_CLOSE = 0x0010;
    /// <summary>Declare a private constructor to prevent new instances
    /// of the NativeMethods class from being created. This constructor
    /// is intentionally left blank.</summary>
    /// 
    internal const int SW_HIDE = 0;
    internal const int SW_SHOWNORMAL = 1;
    internal const int SW_SHOWNOACTIVATE = 4;
    internal const int SW_SHOW = 5;
    internal const int SW_MINIMIZE = 6;
    internal const int SW_SHOWNA = 8;
    internal const int SW_SHOWMAXIMIZED = 11;
    internal const int SW_MAXIMIZE = 12;
    internal const int SW_RESTORE = 13;

    internal const int SWP_NOMOVE = 0x0002;

    private NativeMethods()
      {
      // No initialization is required.
      }

    //[StructLayout(LayoutKind.Sequential)]
    public struct RECT
      {
      public int Left;
      public int Top;
      public int Right;
      public int Bottom;
      }
    /// <summary>
    /// Prototype de SetParent() pour PInvoke</summary>
    /// </summary>
    /// <param name="hWndChild"></param>
    /// <param name="hWndNewParent"></param>
    /// <returns></returns>
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern int SetParent(int hWndChild,
      int hWndNewParent);
    /// <summary>Prototype of SetWindowLong() for PInvoke</summary>
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    internal static extern int SetWindowLongW(int hwnd,
      int nIndex,
      int dwNewLong);
    /// <summary>Prototype of FindWindow() for PInvoke</summary>
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    internal static extern int FindWindow(string strClassName, string strWindowName);
    // Find window by Caption only. Note you must pass 0 as the first parameter.
    [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
    internal static extern System.IntPtr FindWindowByCaption(int ZeroOnly, string lpWindowName);
    // Find window Ex.
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
    // Get Window
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern IntPtr GetWindow(IntPtr hWnd, int nGetWndCmd);
    // Get Window
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern int CloseWindow(IntPtr hWnd);


    // InvalidateRect
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);
    // UpdateWindow
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern bool UpdateWindow(IntPtr hWnd);


    // Destroy window
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern bool DestroyWindow(IntPtr hWnd);
    // Send message
    [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    // Show Window
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    // ScreenToClient
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);
    // GetWindowRect
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
    // GetClientRect
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
    // GetMapMode
    [DllImport("gdi32.dll")]
    internal static extern int GetMapMode(IntPtr hDC);
    // GetDC
    [DllImport("user32.dll")]
    internal static extern IntPtr GetDC(IntPtr hWnd);
    [DllImport("user32.dll")]
    internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int nFlags);
    }
  }
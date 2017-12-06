﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using EasyPaint.InterfaceClass;
using EasyPaint.Tool;

namespace EasyPaint
{
    public partial class MainWindow : Form
    {
        //private ITool ActiveTool;
        private Canvas DrawingCanvas;
        private System.Windows.Forms.TabControl tabControl;

        public MainWindow()
        {
            InitializeComponent();
            SetToolbox();
            SetCanvas();
        }

        private void SetToolbox()
        {
            System.Windows.Forms.ToolStrip ToolBox = new System.Windows.Forms.ToolStrip();
            LineTool LineToolStrip = new LineTool();
            LineToolStrip.TargetCanvas = DrawingCanvas;
            EllipseTool EllipseToolStrip = new EllipseTool();
            EllipseToolStrip.TargetCanvas = DrawingCanvas;
            RectangleTool RectangleToolStrip = new RectangleTool();
            RectangleToolStrip.TargetCanvas = DrawingCanvas;
            ToolStripSeparator ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            ToolStripSeparator ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator2.Size = new System.Drawing.Size(21, 6);

            ToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            LineToolStrip,
            ToolStripSeparator1,
            RectangleToolStrip,
            ToolStripSeparator2,
            EllipseToolStrip});
            ToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            ToolBox.Location = new System.Drawing.Point(0, 24);
            ToolBox.Name = "ToolBox";
            ToolBox.Size = new System.Drawing.Size(24, 418);
            ToolBox.TabIndex = 0;
            ToolBox.Text = "Toolbox";

            this.Controls.Add(ToolBox);
        }

        private void SetCanvas()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            DrawingCanvas = new Canvas();
            DrawingCanvas.Name = "Untitled";
            TabPage tabPage = new TabPage(DrawingCanvas.Name);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(tabPage);
            this.tabControl.Location = new System.Drawing.Point(30, 50);
            this.tabControl.Name = DrawingCanvas.Name;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(594, 390);
            this.tabControl.TabIndex = 3;
            tabPage.Controls.Add((Control)DrawingCanvas);
            this.Controls.Add(this.tabControl);

        }
    }
}

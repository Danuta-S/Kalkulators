
namespace Kalkulators
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalculatorDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Arrow = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Onex = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.displayInsideOfDisplay = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorDisplay
            // 
            this.CalculatorDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatorDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculatorDisplay.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorDisplay.Location = new System.Drawing.Point(16, 77);
            this.CalculatorDisplay.MaxLength = 16;
            this.CalculatorDisplay.Multiline = true;
            this.CalculatorDisplay.Name = "CalculatorDisplay";
            this.CalculatorDisplay.ReadOnly = true;
            this.CalculatorDisplay.Size = new System.Drawing.Size(194, 53);
            this.CalculatorDisplay.TabIndex = 0;
            this.CalculatorDisplay.Text = "0";
            this.CalculatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Arrow
            // 
            this.Arrow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Arrow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.Image = ((System.Drawing.Image)(resources.GetObject("Arrow.Image")));
            this.Arrow.Location = new System.Drawing.Point(16, 168);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(34, 26);
            this.Arrow.TabIndex = 5;
            this.Arrow.UseVisualStyleBackColor = false;
            this.Arrow.Click += new System.EventHandler(this.Arrow_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Four.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(16, 232);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(34, 26);
            this.Four.TabIndex = 7;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.button_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Seven.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(16, 200);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(34, 26);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.button_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Zero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(16, 296);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 26);
            this.Zero.TabIndex = 9;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.button_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.One.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(16, 264);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(34, 26);
            this.One.TabIndex = 8;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.button_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Two.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(57, 264);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(34, 26);
            this.Two.TabIndex = 14;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.button_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Five.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(57, 232);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(34, 26);
            this.Five.TabIndex = 13;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.button_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Eight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(57, 200);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(34, 26);
            this.Eight.TabIndex = 12;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.button_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(57, 168);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(34, 26);
            this.CE.TabIndex = 11;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(57, 136);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(34, 26);
            this.button12.TabIndex = 10;
            this.button12.Text = "MR";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DecimalButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.Location = new System.Drawing.Point(97, 296);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(34, 26);
            this.DecimalButton.TabIndex = 21;
            this.DecimalButton.Text = ",";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.dot_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Three.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(97, 264);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(34, 26);
            this.Three.TabIndex = 20;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.button_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Six.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(97, 232);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(34, 26);
            this.Six.TabIndex = 19;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.button_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Nine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(97, 200);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(34, 26);
            this.Nine.TabIndex = 18;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.button_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(97, 168);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(34, 26);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(97, 136);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(34, 26);
            this.button18.TabIndex = 16;
            this.button18.Text = "MS";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(176, 264);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(34, 58);
            this.Equal.TabIndex = 32;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Onex
            // 
            this.Onex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Onex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onex.Location = new System.Drawing.Point(176, 232);
            this.Onex.Name = "Onex";
            this.Onex.Size = new System.Drawing.Size(34, 26);
            this.Onex.TabIndex = 31;
            this.Onex.Text = "1/x";
            this.Onex.UseVisualStyleBackColor = false;
            this.Onex.Click += new System.EventHandler(this.Onex_Click);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Mod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod.Location = new System.Drawing.Point(176, 200);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(34, 26);
            this.Mod.TabIndex = 30;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Sqrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrt.Image = ((System.Drawing.Image)(resources.GetObject("Sqrt.Image")));
            this.Sqrt.Location = new System.Drawing.Point(176, 168);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(34, 26);
            this.Sqrt.TabIndex = 29;
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(176, 136);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(34, 26);
            this.button24.TabIndex = 28;
            this.button24.Text = "M-";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(137, 296);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(34, 26);
            this.Plus.TabIndex = 27;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(137, 264);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(34, 26);
            this.Minus.TabIndex = 26;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Multiply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(137, 232);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(34, 26);
            this.Multiply.TabIndex = 25;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(137, 200);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(34, 26);
            this.Divide.TabIndex = 24;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Operators_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlusMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinus.Image = ((System.Drawing.Image)(resources.GetObject("PlusMinus.Image")));
            this.PlusMinus.Location = new System.Drawing.Point(137, 168);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(34, 26);
            this.PlusMinus.TabIndex = 23;
            this.PlusMinus.UseVisualStyleBackColor = false;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(137, 136);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(34, 26);
            this.button30.TabIndex = 22;
            this.button30.Text = "M+";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(223, 29);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(223, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(223, 29);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 25);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 25);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(138, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(-1, 1);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(138, 23);
            this.toolStripContainer1.TabIndex = 34;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // displayInsideOfDisplay
            // 
            this.displayInsideOfDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInsideOfDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInsideOfDisplay.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.displayInsideOfDisplay.Location = new System.Drawing.Point(16, 43);
            this.displayInsideOfDisplay.Name = "displayInsideOfDisplay";
            this.displayInsideOfDisplay.Size = new System.Drawing.Size(194, 28);
            this.displayInsideOfDisplay.TabIndex = 35;
            this.displayInsideOfDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(222, 335);
            this.Controls.Add(this.displayInsideOfDisplay);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Onex);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculatorDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculatorDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Arrow;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Onex;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox displayInsideOfDisplay;
    }
}


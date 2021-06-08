using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace Transformation
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tRotDeg;
        private System.Windows.Forms.Label lblRotDeg;
        private System.Windows.Forms.CheckBox cbRotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransX;
        private System.Windows.Forms.TrackBar tTransX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransY;
        private System.Windows.Forms.TrackBar tTransY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRotY;
        private System.Windows.Forms.TrackBar tRotY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRotX;
        private System.Windows.Forms.TrackBar tRotX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblStrY;
        private System.Windows.Forms.TrackBar tStrY;
        private System.Windows.Forms.CheckBox cbStretch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblStrX;
        private System.Windows.Forms.TrackBar tStrX;
        private System.Windows.Forms.CheckBox cbTranslation;
        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.Container components = null;
        private CheckBox cbReflectX;
        private CheckBox cbReflectY;
        private CheckBox cbFlipY;
        private CheckBox cbShowRegionDemo;
        private Button buttonDown;
        private Button buttonUp;
        private Label label1;
        private Label lblShearY;
        private TrackBar tShearY;
        private CheckBox cbShear;
        private Label label6;
        private Label lblShearX;
        private TrackBar tShearX;
        private ListBox listBox1;
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tRotDeg = new System.Windows.Forms.TrackBar();
            this.lblRotDeg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRotate = new System.Windows.Forms.CheckBox();
            this.cbTranslation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransX = new System.Windows.Forms.Label();
            this.tTransX = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransY = new System.Windows.Forms.Label();
            this.tTransY = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRotY = new System.Windows.Forms.Label();
            this.tRotY = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRotX = new System.Windows.Forms.Label();
            this.tRotX = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStrY = new System.Windows.Forms.Label();
            this.tStrY = new System.Windows.Forms.TrackBar();
            this.cbStretch = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblStrX = new System.Windows.Forms.Label();
            this.tStrX = new System.Windows.Forms.TrackBar();
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbReflectX = new System.Windows.Forms.CheckBox();
            this.cbReflectY = new System.Windows.Forms.CheckBox();
            this.cbFlipY = new System.Windows.Forms.CheckBox();
            this.cbShowRegionDemo = new System.Windows.Forms.CheckBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShearY = new System.Windows.Forms.Label();
            this.tShearY = new System.Windows.Forms.TrackBar();
            this.cbShear = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShearX = new System.Windows.Forms.Label();
            this.tShearX = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShearY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShearX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tRotDeg
            // 
            this.tRotDeg.AutoSize = false;
            this.tRotDeg.LargeChange = 1;
            this.tRotDeg.Location = new System.Drawing.Point(496, 40);
            this.tRotDeg.Maximum = 90;
            this.tRotDeg.Minimum = -90;
            this.tRotDeg.Name = "tRotDeg";
            this.tRotDeg.Size = new System.Drawing.Size(104, 24);
            this.tRotDeg.TabIndex = 2;
            this.tRotDeg.TickFrequency = 30;
            this.tRotDeg.ValueChanged += new System.EventHandler(this.tRotDeg_ValueChanged);
            // 
            // lblRotDeg
            // 
            this.lblRotDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotDeg.Location = new System.Drawing.Point(600, 40);
            this.lblRotDeg.Name = "lblRotDeg";
            this.lblRotDeg.Size = new System.Drawing.Size(32, 24);
            this.lblRotDeg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(448, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Degree";
            // 
            // cbRotate
            // 
            this.cbRotate.Location = new System.Drawing.Point(424, 8);
            this.cbRotate.Name = "cbRotate";
            this.cbRotate.Size = new System.Drawing.Size(80, 16);
            this.cbRotate.TabIndex = 8;
            this.cbRotate.Text = "Rotation";
            this.cbRotate.CheckedChanged += new System.EventHandler(this.cbRotate_CheckedChanged);
            // 
            // cbTranslation
            // 
            this.cbTranslation.Location = new System.Drawing.Point(432, 144);
            this.cbTranslation.Name = "cbTranslation";
            this.cbTranslation.Size = new System.Drawing.Size(88, 16);
            this.cbTranslation.TabIndex = 12;
            this.cbTranslation.Text = "Translation";
            this.cbTranslation.CheckedChanged += new System.EventHandler(this.cbTranslation_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(448, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            // 
            // lblTransX
            // 
            this.lblTransX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransX.Location = new System.Drawing.Point(600, 176);
            this.lblTransX.Name = "lblTransX";
            this.lblTransX.Size = new System.Drawing.Size(32, 24);
            this.lblTransX.TabIndex = 10;
            // 
            // tTransX
            // 
            this.tTransX.AutoSize = false;
            this.tTransX.LargeChange = 1;
            this.tTransX.Location = new System.Drawing.Point(496, 176);
            this.tTransX.Maximum = 150;
            this.tTransX.Minimum = -150;
            this.tTransX.Name = "tTransX";
            this.tTransX.Size = new System.Drawing.Size(104, 24);
            this.tTransX.TabIndex = 9;
            this.tTransX.TickFrequency = 20;
            this.tTransX.ValueChanged += new System.EventHandler(this.tTransX_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(448, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            // 
            // lblTransY
            // 
            this.lblTransY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransY.Location = new System.Drawing.Point(600, 208);
            this.lblTransY.Name = "lblTransY";
            this.lblTransY.Size = new System.Drawing.Size(32, 24);
            this.lblTransY.TabIndex = 14;
            // 
            // tTransY
            // 
            this.tTransY.AutoSize = false;
            this.tTransY.LargeChange = 1;
            this.tTransY.Location = new System.Drawing.Point(496, 208);
            this.tTransY.Maximum = 150;
            this.tTransY.Minimum = -150;
            this.tTransY.Name = "tTransY";
            this.tTransY.Size = new System.Drawing.Size(104, 24);
            this.tTransY.TabIndex = 13;
            this.tTransY.TickFrequency = 20;
            this.tTransY.ValueChanged += new System.EventHandler(this.tTransY_ValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(448, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Y";
            // 
            // lblRotY
            // 
            this.lblRotY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotY.Location = new System.Drawing.Point(600, 104);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(32, 24);
            this.lblRotY.TabIndex = 22;
            // 
            // tRotY
            // 
            this.tRotY.AutoSize = false;
            this.tRotY.LargeChange = 1;
            this.tRotY.Location = new System.Drawing.Point(496, 104);
            this.tRotY.Maximum = 50;
            this.tRotY.Minimum = -50;
            this.tRotY.Name = "tRotY";
            this.tRotY.Size = new System.Drawing.Size(104, 24);
            this.tRotY.TabIndex = 21;
            this.tRotY.TickFrequency = 10;
            this.tRotY.ValueChanged += new System.EventHandler(this.tRotY_ValueChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(448, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "X";
            // 
            // lblRotX
            // 
            this.lblRotX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotX.Location = new System.Drawing.Point(600, 72);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(32, 24);
            this.lblRotX.TabIndex = 19;
            // 
            // tRotX
            // 
            this.tRotX.AutoSize = false;
            this.tRotX.LargeChange = 1;
            this.tRotX.Location = new System.Drawing.Point(496, 72);
            this.tRotX.Maximum = 50;
            this.tRotX.Minimum = -50;
            this.tRotX.Name = "tRotX";
            this.tRotX.Size = new System.Drawing.Size(104, 24);
            this.tRotX.TabIndex = 18;
            this.tRotX.TickFrequency = 10;
            this.tRotX.ValueChanged += new System.EventHandler(this.tRotX_ValueChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(448, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Y";
            // 
            // lblStrY
            // 
            this.lblStrY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrY.Location = new System.Drawing.Point(600, 312);
            this.lblStrY.Name = "lblStrY";
            this.lblStrY.Size = new System.Drawing.Size(32, 24);
            this.lblStrY.TabIndex = 29;
            // 
            // tStrY
            // 
            this.tStrY.AutoSize = false;
            this.tStrY.LargeChange = 1;
            this.tStrY.Location = new System.Drawing.Point(496, 312);
            this.tStrY.Maximum = 20;
            this.tStrY.Minimum = 1;
            this.tStrY.Name = "tStrY";
            this.tStrY.Size = new System.Drawing.Size(104, 24);
            this.tStrY.TabIndex = 28;
            this.tStrY.Value = 10;
            this.tStrY.ValueChanged += new System.EventHandler(this.tStrY_ValueChanged);
            // 
            // cbStretch
            // 
            this.cbStretch.Location = new System.Drawing.Point(432, 248);
            this.cbStretch.Name = "cbStretch";
            this.cbStretch.Size = new System.Drawing.Size(80, 16);
            this.cbStretch.TabIndex = 27;
            this.cbStretch.Text = "Scale";
            this.cbStretch.CheckedChanged += new System.EventHandler(this.cbStretch_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(448, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 26;
            this.label16.Text = "X";
            // 
            // lblStrX
            // 
            this.lblStrX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrX.Location = new System.Drawing.Point(600, 280);
            this.lblStrX.Name = "lblStrX";
            this.lblStrX.Size = new System.Drawing.Size(32, 24);
            this.lblStrX.TabIndex = 25;
            // 
            // tStrX
            // 
            this.tStrX.AutoSize = false;
            this.tStrX.LargeChange = 1;
            this.tStrX.Location = new System.Drawing.Point(496, 280);
            this.tStrX.Maximum = 20;
            this.tStrX.Minimum = 1;
            this.tStrX.Name = "tStrX";
            this.tStrX.Size = new System.Drawing.Size(104, 24);
            this.tStrX.TabIndex = 24;
            this.tStrX.Value = 10;
            this.tStrX.ValueChanged += new System.EventHandler(this.tStrX_ValueChanged);
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBase.Image")));
            this.pictureBoxBase.Location = new System.Drawing.Point(56, 448);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxBase.TabIndex = 32;
            this.pictureBoxBase.TabStop = false;
            this.pictureBoxBase.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(264, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 24);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbReflectX
            // 
            this.cbReflectX.Location = new System.Drawing.Point(679, 1);
            this.cbReflectX.Name = "cbReflectX";
            this.cbReflectX.Size = new System.Drawing.Size(130, 30);
            this.cbReflectX.TabIndex = 37;
            this.cbReflectX.Text = "Refect Along X axis";
            this.cbReflectX.CheckedChanged += new System.EventHandler(this.cbReflectX_CheckedChanged);
            // 
            // cbReflectY
            // 
            this.cbReflectY.Location = new System.Drawing.Point(679, 35);
            this.cbReflectY.Name = "cbReflectY";
            this.cbReflectY.Size = new System.Drawing.Size(130, 25);
            this.cbReflectY.TabIndex = 38;
            this.cbReflectY.Text = "Reflect Along Y axis";
            this.cbReflectY.CheckedChanged += new System.EventHandler(this.cbReflectY_CheckedChanged);
            // 
            // cbFlipY
            // 
            this.cbFlipY.Location = new System.Drawing.Point(0, 0);
            this.cbFlipY.Name = "cbFlipY";
            this.cbFlipY.Size = new System.Drawing.Size(104, 24);
            this.cbFlipY.TabIndex = 0;
            // 
            // cbShowRegionDemo
            // 
            this.cbShowRegionDemo.AutoSize = true;
            this.cbShowRegionDemo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowRegionDemo.Location = new System.Drawing.Point(541, 424);
            this.cbShowRegionDemo.Name = "cbShowRegionDemo";
            this.cbShowRegionDemo.Size = new System.Drawing.Size(89, 17);
            this.cbShowRegionDemo.TabIndex = 36;
            this.cbShowRegionDemo.Text = "Region Demo";
            this.cbShowRegionDemo.UseVisualStyleBackColor = true;
            this.cbShowRegionDemo.Visible = false;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(616, 382);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(16, 24);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "-";
            this.buttonDown.Visible = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(616, 352);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(16, 24);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "+";
            this.buttonUp.Visible = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(432, 352);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 56);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(673, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Y";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShearY
            // 
            this.lblShearY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShearY.Location = new System.Drawing.Point(825, 208);
            this.lblShearY.Name = "lblShearY";
            this.lblShearY.Size = new System.Drawing.Size(32, 24);
            this.lblShearY.TabIndex = 44;
            this.lblShearY.Click += new System.EventHandler(this.label4_Click);
            // 
            // tShearY
            // 
            this.tShearY.AutoSize = false;
            this.tShearY.LargeChange = 1;
            this.tShearY.Location = new System.Drawing.Point(721, 208);
            this.tShearY.Minimum = -10;
            this.tShearY.Name = "tShearY";
            this.tShearY.Size = new System.Drawing.Size(104, 24);
            this.tShearY.TabIndex = 43;
            this.tShearY.TickFrequency = 20;
            this.tShearY.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbShear
            // 
            this.cbShear.Location = new System.Drawing.Point(657, 144);
            this.cbShear.Name = "cbShear";
            this.cbShear.Size = new System.Drawing.Size(88, 16);
            this.cbShear.TabIndex = 42;
            this.cbShear.Text = "Shear";
            this.cbShear.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(673, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblShearX
            // 
            this.lblShearX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShearX.Location = new System.Drawing.Point(825, 176);
            this.lblShearX.Name = "lblShearX";
            this.lblShearX.Size = new System.Drawing.Size(32, 24);
            this.lblShearX.TabIndex = 40;
            this.lblShearX.Click += new System.EventHandler(this.label7_Click);
            // 
            // tShearX
            // 
            this.tShearX.AutoSize = false;
            this.tShearX.LargeChange = 1;
            this.tShearX.Location = new System.Drawing.Point(721, 176);
            this.tShearX.Minimum = -10;
            this.tShearX.Name = "tShearX";
            this.tShearX.Size = new System.Drawing.Size(104, 24);
            this.tShearX.TabIndex = 39;
            this.tShearX.TickFrequency = 20;
            this.tShearX.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(873, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShearY);
            this.Controls.Add(this.tShearY);
            this.Controls.Add(this.cbShear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblShearX);
            this.Controls.Add(this.tShearX);
            this.Controls.Add(this.cbReflectY);
            this.Controls.Add(this.cbReflectX);
            this.Controls.Add(this.cbShowRegionDemo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStrY);
            this.Controls.Add(this.tStrY);
            this.Controls.Add(this.cbStretch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblStrX);
            this.Controls.Add(this.tStrX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRotY);
            this.Controls.Add(this.tRotY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRotX);
            this.Controls.Add(this.tRotX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTransY);
            this.Controls.Add(this.tTransY);
            this.Controls.Add(this.cbTranslation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTransX);
            this.Controls.Add(this.tTransX);
            this.Controls.Add(this.cbRotate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblRotDeg);
            this.Controls.Add(this.tRotDeg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformation Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShearY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShearX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            Image img = new Bitmap(400, 400);


            pictureBox1.Image = img;
            Graphics g = Graphics.FromImage(pictureBox1.Image);


            Matrix mm1 = new Matrix();
            mm1.Translate(0, 0, MatrixOrder.Append);

            g.Transform = mm1;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                if (listBox1.Items[i].ToString() == "ReflectX")
                {
                    Matrix mreflex = new Matrix(1, 0, 0, -1, 0, 0);
                    mm1.Multiply(mreflex, MatrixOrder.Append);
                }

                if (listBox1.Items[i].ToString() == "ReflectY")
                {
                    Matrix mreflex = new Matrix(-1, 0, 0, 1, 0, 0);
                    mm1.Multiply(mreflex, MatrixOrder.Append);
                }

                if (listBox1.Items[i].ToString() == "Rotate")
                    mm1.RotateAt(
                        (cbFlipY.CheckState == CheckState.Checked ? -1 : 1) * int.Parse(lblRotDeg.Text),
                        new Point(int.Parse(lblRotX.Text), int.Parse(lblRotY.Text)),
                        MatrixOrder.Append);


                if (listBox1.Items[i].ToString() == "Translation")
                    mm1.Translate(int.Parse(lblTransX.Text), int.Parse(lblTransY.Text), MatrixOrder.Append);

                if (listBox1.Items[i].ToString() == "Scale")
                    mm1.Scale(float.Parse(lblStrX.Text), float.Parse(lblStrY.Text), MatrixOrder.Append);

                if (listBox1.Items[i].ToString() == "Shear")
                {
                    mm1.Shear(float.Parse(lblShearX.Text), float.Parse(lblShearY.Text), MatrixOrder.Append);
                }

            }
            GraphicsPath gp = new GraphicsPath();
            Image imgpic = (Image)pictureBoxBase.Image.Clone();

            PointF[] psrc;

            psrc = new PointF[] { new Point(0, imgpic.Height), new Point(imgpic.Width, imgpic.Height), new Point(0, 0) };

            gp.AddPolygon(psrc);

            gp.Transform(mm1);
            PointF[] pts = gp.PathPoints;

            g.DrawImage(imgpic, pts);


            pictureBox1.Refresh();


        }

        private void tRotDeg_ValueChanged(object sender, System.EventArgs e)
        {
            lblRotDeg.Text = tRotDeg.Value.ToString();
            cbRotate.CheckState = CheckState.Checked;
            button1_Click(sender, null);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

            tRotDeg.Value = 0;
            tRotX.Value = 0;
            tRotY.Value = 0;

            lblRotDeg.Text = tRotDeg.Value.ToString();
            lblRotX.Text = tRotX.Value.ToString();
            lblRotY.Text = tRotY.Value.ToString();

            tTransX.Value = 0;
            tTransY.Value = 0;

            lblTransX.Text = tTransX.Value.ToString();
            lblTransY.Text = tTransY.Value.ToString();

            tStrX.Value = 10;
            tStrY.Value = 10;

            lblStrX.Text = String.Format("{0:0.0}", (tStrX.Value / 10.0));
            lblStrY.Text = String.Format("{0:0.0}", (tStrY.Value / 10.0));

            tShearX.Value = 0;
            tShearY.Value = 0;

            lblShearX.Text = tShearX.Value.ToString();
            lblShearY.Text = tShearY.Value.ToString();


            cbFlipY.CheckState = CheckState.Checked;
            cbRotate.CheckState = CheckState.Unchecked;
            cbTranslation.CheckState = CheckState.Unchecked;
            cbStretch.CheckState = CheckState.Unchecked;
            cbShear.CheckState = CheckState.Unchecked;

            button1_Click(this, null);

        }

        private void reset_spacific_transition(string tName) {

            if (tName == "Translation")
            {
                tTransX.Value = 0;
                tTransY.Value = 0;

                lblTransX.Text = tTransX.Value.ToString();
                lblTransY.Text = tTransY.Value.ToString();
            }
            else if (tName == "Scale") {
                tStrX.Value = 10;
                tStrY.Value = 10;

                lblStrX.Text = String.Format("{0:0.0}", (tStrX.Value / 10.0));
                lblStrY.Text = String.Format("{0:0.0}", (tStrY.Value / 10.0));
            }
            else if (tName == "Shear")
            {
                tShearX.Value = 0;
                tShearY.Value = 0;

                lblShearX.Text = tShearX.Value.ToString();
                lblShearY.Text = tShearY.Value.ToString();
            }
            else if (tName == "Rotate")
            {
                tRotDeg.Value = 0;
                tRotX.Value = 0;
                tRotY.Value = 0;

                lblRotDeg.Text = tRotDeg.Value.ToString();
                lblRotX.Text = tRotX.Value.ToString();
                lblRotY.Text = tRotY.Value.ToString();

            }
            button1_Click(this, null);

        }

		private void buttonDown_Click(object sender, System.EventArgs e)
		{
			int index=listBox1.SelectedIndex;
			if (index>=listBox1.Items.Count-1)return;
			if ((index)<=-1 )return;
			string s=(string)listBox1.Items[index];
			listBox1.Items.RemoveAt(index);
			listBox1.Items.Insert(index+1,s);
			listBox1.SelectedIndex=index+1;
			button1_Click(sender,null);
		}

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
			int index=listBox1.SelectedIndex;
			if ((index)<=0 )return;
			string s=(string)listBox1.Items[index];
			listBox1.Items.RemoveAt(index);
			listBox1.Items.Insert(index-1,s);
			listBox1.SelectedIndex=index-1;	
			button1_Click(sender,null);

		}

		private void UpdateListBox(CheckBox cb, String s)
		{
			if (cb.CheckState==CheckState.Checked)
			{
				bool found=false;
				for(int i=0;i<listBox1.Items.Count;i++)
					if(listBox1.Items[i].ToString()==s)
					{
						found=true;
						break;
					}

				if (!found)
				{
					listBox1.Items.Add(s);
					listBox1.SelectedIndex=listBox1.Items.Count-1;
				}
		
			}
			else
			{
				for(int i=0;i<listBox1.Items.Count;i++)
				{
					if(listBox1.Items[i].ToString()==s)
					{
                        reset_spacific_transition(listBox1.Items[i].ToString());

                        listBox1.Items.RemoveAt(i);

						if(i>0) listBox1.SelectedIndex=i-1;
						if(i==0)
							if(listBox1.Items.Count>=1)
								listBox1.SelectedIndex=0;

						break;
					}
				}
			}
		}

		private void cbRotate_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender,"Rotate");
		}

		private void cbTranslation_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender,"Translation");
		}

		private void cbStretch_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender, "Scale");
		}

		private void tRotX_ValueChanged(object sender, System.EventArgs e)
		{
			lblRotX.Text =tRotX.Value.ToString() ;
			cbRotate.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void tRotY_ValueChanged(object sender, System.EventArgs e)
		{
			lblRotY.Text =tRotY.Value.ToString() ;
			cbRotate.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void tTransX_ValueChanged(object sender, System.EventArgs e)
		{
			lblTransX.Text =tTransX.Value.ToString() ;
			cbTranslation.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void tTransY_ValueChanged(object sender, System.EventArgs e)
		{
		    lblTransY.Text =tTransY.Value.ToString() ;
			cbTranslation.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void tStrX_ValueChanged(object sender, System.EventArgs e)
		{
			lblStrX.Text=String.Format("{0:0.0}",(tStrX.Value /10.0));
			cbStretch.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void tStrY_ValueChanged(object sender, System.EventArgs e)
		{
			lblStrY.Text=String.Format("{0:0.0}",(tStrY.Value/10.0));
			cbStretch.CheckState=CheckState.Checked;
			button1_Click(sender,null);
		}

		private void cbFlipY_CheckedChanged(object sender, System.EventArgs e)
		{
		  button1_Click(sender,null);
		}

		private void btnReset_Click(object sender, System.EventArgs e)
		{
		  Form1_Load(sender,null);

		}

        private void cbReflectX_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox((CheckBox)sender, "ReflectX");
            button1_Click(sender, null);
        }

        private void cbReflectY_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox((CheckBox)sender, "ReflectY");
            button1_Click(sender, null);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox((CheckBox)sender, "Shear");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblShearY.Text = tShearY.Value.ToString();
            cbShear.CheckState = CheckState.Checked;
            button1_Click(sender, null);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblShearX.Text = tShearX.Value.ToString();
            cbShear.CheckState = CheckState.Checked;
            button1_Click(sender, null);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

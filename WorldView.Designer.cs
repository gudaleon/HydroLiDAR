using Tao.Platform.Windows;
namespace TerraForm
{
    partial class WorldView
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
          animationThreadRunning = false;
          interactionThreadRunning = false;

          if (animationThread != null)
          {
            animationThread.Abort();
          }

          animationThread = null;

          if (interactionThread != null)
          {
              interactionThread.Abort();
          }

          interactionThread = null;

          if (disposing && (components != null))
          {
              components.Dispose();
          }
          simpleOpenGlControl.DestroyContexts();
          base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.simpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
          this.SuspendLayout();
          // 
          // simpleOpenGlControl
          // 
          this.simpleOpenGlControl.AccumBits = ((byte)(0));
          this.simpleOpenGlControl.AutoCheckErrors = false;
          this.simpleOpenGlControl.AutoFinish = false;
          this.simpleOpenGlControl.AutoMakeCurrent = true;
          this.simpleOpenGlControl.AutoSwapBuffers = true;
          this.simpleOpenGlControl.BackColor = System.Drawing.Color.Black;
          this.simpleOpenGlControl.ColorBits = ((byte)(32));
          this.simpleOpenGlControl.DepthBits = ((byte)(16));
          this.simpleOpenGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
          this.simpleOpenGlControl.Location = new System.Drawing.Point(0, 0);
          this.simpleOpenGlControl.Name = "simpleOpenGlControl";
          this.simpleOpenGlControl.Size = new System.Drawing.Size(1016, 766);
          this.simpleOpenGlControl.StencilBits = ((byte)(0));
          this.simpleOpenGlControl.TabIndex = 0;
          this.simpleOpenGlControl.MouseLeave += new System.EventHandler(this.OnMouseLeave);
          this.simpleOpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
          this.simpleOpenGlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
          this.simpleOpenGlControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
          this.simpleOpenGlControl.SizeChanged += new System.EventHandler(this.OnResize);
          this.simpleOpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
          // 
          // WorldView
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(1016, 766);
          this.Controls.Add(this.simpleOpenGlControl);
          this.Name = "WorldView";
          this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
          this.Text = "WorldView";
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldView_FormClosed);
          this.ResumeLayout(false);

        }

        #endregion

        private SimpleOpenGlControl simpleOpenGlControl;

    }
}
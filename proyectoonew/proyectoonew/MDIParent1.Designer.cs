﻿namespace proyectoonew
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARCOMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.eDITARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.aBRIRToolStripMenuItem,
            this.gUARDARToolStripMenuItem,
            this.gUARDARCOMOToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            this.aBRIRToolStripMenuItem.Click += new System.EventHandler(this.aBRIRToolStripMenuItem_Click);
            // 
            // gUARDARToolStripMenuItem
            // 
            this.gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            this.gUARDARToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gUARDARToolStripMenuItem.Text = "GUARDAR";
            this.gUARDARToolStripMenuItem.Click += new System.EventHandler(this.gUARDARToolStripMenuItem_Click);
            // 
            // gUARDARCOMOToolStripMenuItem
            // 
            this.gUARDARCOMOToolStripMenuItem.Name = "gUARDARCOMOToolStripMenuItem";
            this.gUARDARCOMOToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gUARDARCOMOToolStripMenuItem.Text = "GUARDAR COMO";
            this.gUARDARCOMOToolStripMenuItem.Click += new System.EventHandler(this.gUARDARCOMOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOLORToolStripMenuItem,
            this.fUENTEToolStripMenuItem});
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            // 
            // fUENTEToolStripMenuItem
            // 
            this.fUENTEToolStripMenuItem.Name = "fUENTEToolStripMenuItem";
            this.fUENTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fUENTEToolStripMenuItem.Text = "FUENTE";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUARDARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUARDARCOMOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUENTEToolStripMenuItem;

    }
}




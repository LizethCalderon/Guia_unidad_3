namespace Guia_1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosDeGuia1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCostosDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularSumaDe1ANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosDeGuia1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosDeGuia1ToolStripMenuItem
            // 
            this.ejerciciosDeGuia1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.calcularCostosDeGastosToolStripMenuItem,
            this.calcularSumaDe1ANToolStripMenuItem,
            this.formularioDLLToolStripMenuItem});
            this.ejerciciosDeGuia1ToolStripMenuItem.Name = "ejerciciosDeGuia1ToolStripMenuItem";
            this.ejerciciosDeGuia1ToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.ejerciciosDeGuia1ToolStripMenuItem.Text = "Menu Ejercicios G_1";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.loginToolStripMenuItem.Text = "Usuario";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // calcularCostosDeGastosToolStripMenuItem
            // 
            this.calcularCostosDeGastosToolStripMenuItem.Name = "calcularCostosDeGastosToolStripMenuItem";
            this.calcularCostosDeGastosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.calcularCostosDeGastosToolStripMenuItem.Text = "Calculo de Envío";
            this.calcularCostosDeGastosToolStripMenuItem.Click += new System.EventHandler(this.calcularCostosDeGastosToolStripMenuItem_Click);
            // 
            // calcularSumaDe1ANToolStripMenuItem
            // 
            this.calcularSumaDe1ANToolStripMenuItem.Name = "calcularSumaDe1ANToolStripMenuItem";
            this.calcularSumaDe1ANToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.calcularSumaDe1ANToolStripMenuItem.Text = "Calcular Suma de 1 hasta N";
            this.calcularSumaDe1ANToolStripMenuItem.Click += new System.EventHandler(this.calcularSumaDe1ANToolStripMenuItem_Click);
            // 
            // formularioDLLToolStripMenuItem
            // 
            this.formularioDLLToolStripMenuItem.Name = "formularioDLLToolStripMenuItem";
            this.formularioDLLToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.formularioDLLToolStripMenuItem.Text = "Formulario DLL";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosDeGuia1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCostosDeGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularSumaDe1ANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDLLToolStripMenuItem;
    }
}




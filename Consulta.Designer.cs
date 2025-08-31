
namespace CapaVista
{
    partial class Consulta
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
            this.dv_registros = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // dv_registros
            // 
            this.dv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_registros.Location = new System.Drawing.Point(54, 218);
            this.dv_registros.Name = "dv_registros";
            this.dv_registros.RowHeadersWidth = 62;
            this.dv_registros.RowTemplate.Height = 28;
            this.dv_registros.Size = new System.Drawing.Size(696, 220);
            this.dv_registros.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(630, 127);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(120, 56);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dv_registros);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dv_registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dv_registros;
        private System.Windows.Forms.Button btn_consultar;
    }
}

namespace Tatil_Rezervasyon_Otomasyonu
{
    partial class OtelArama
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.otelAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Otel İsmi";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 30);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "Kimlik";
            // 
            // otelAra
            // 
            this.otelAra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.otelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otelAra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.otelAra.Location = new System.Drawing.Point(566, 174);
            this.otelAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otelAra.Name = "otelAra";
            this.otelAra.Size = new System.Drawing.Size(108, 44);
            this.otelAra.TabIndex = 30;
            this.otelAra.Text = "Otel Ara";
            this.otelAra.UseVisualStyleBackColor = false;
            this.otelAra.Click += new System.EventHandler(this.otelAra_Click);
            // 
            // OtelArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 517);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.otelAra);
            this.Name = "OtelArama";
            this.Text = "OtelArama";
            this.Load += new System.EventHandler(this.OtelArama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button otelAra;
    }
}
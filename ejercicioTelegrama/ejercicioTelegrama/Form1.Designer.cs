using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensaje = new Label();
            txtTelegrama = new TextBox();
            btnCalcularPrecio = new Button();
            txtPrecio = new TextBox();
            label1 = new Label();
            radioOrdinario = new RadioButton();
            radioUrgente = new RadioButton();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(25, 32);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Mensaje";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(95, 32);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(635, 252);
            txtTelegrama.TabIndex = 3;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(381, 306);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(213, 109);
            btnCalcularPrecio.TabIndex = 4;
            btnCalcularPrecio.Text = "Calcular Precio";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(175, 373);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(109, 27);
            txtPrecio.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 380);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "Precio";
            // 
            // radioOrdinario
            // 
            radioOrdinario.AutoSize = true;
            radioOrdinario.Location = new Point(204, 323);
            radioOrdinario.Name = "radioOrdinario";
            radioOrdinario.Size = new Size(93, 24);
            radioOrdinario.TabIndex = 8;
            radioOrdinario.TabStop = true;
            radioOrdinario.Text = "Ordinario";
            radioOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            radioUrgente.AutoSize = true;
            radioUrgente.Location = new Point(96, 322);
            radioUrgente.Name = "radioUrgente";
            radioUrgente.Size = new Size(83, 24);
            radioUrgente.TabIndex = 9;
            radioUrgente.TabStop = true;
            radioUrgente.Text = "Urgente";
            radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioUrgente);
            Controls.Add(radioOrdinario);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(lblMensaje);
            Name = "Form1";
            Text = "Práctica Telegrama - DAS - 1º DAM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMensaje;
        private TextBox txtTelegrama;
        private Button btnCalcularPrecio;
        private TextBox txtPrecio;
        private Label label1;
        private RadioButton radioOrdinario;
        private RadioButton radioUrgente;
    }
}
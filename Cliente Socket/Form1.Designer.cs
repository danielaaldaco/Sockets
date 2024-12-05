namespace Cliente_Socket
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
            label1 = new Label();
            txtIP = new TextBox();
            txtPuerto = new TextBox();
            label2 = new Label();
            btnConectar = new Button();
            rtbMensaje = new RichTextBox();
            txtMensaje = new TextBox();
            label3 = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Servidor";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(21, 40);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 1;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(154, 40);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 19);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Puerto";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(309, 40);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // rtbMensaje
            // 
            rtbMensaje.Location = new Point(21, 92);
            rtbMensaje.Name = "rtbMensaje";
            rtbMensaje.Size = new Size(363, 225);
            rtbMensaje.TabIndex = 5;
            rtbMensaje.Text = "";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(21, 354);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(233, 23);
            txtMensaje.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 333);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Mensaje";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(309, 354);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(rtbMensaje);
            Controls.Add(btnConectar);
            Controls.Add(txtPuerto);
            Controls.Add(label2);
            Controls.Add(txtIP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cliente-Socket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private TextBox txtPuerto;
        private Label label2;
        private Button btnConectar;
        private RichTextBox rtbMensaje;
        private TextBox txtMensaje;
        private Label label3;
        private Button btnEnviar;
    }
}

namespace Sockets
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
            rtbMensaje = new RichTextBox();
            btnServidor = new Button();
            SuspendLayout();
            // 
            // rtbMensaje
            // 
            rtbMensaje.Location = new Point(49, 28);
            rtbMensaje.Name = "rtbMensaje";
            rtbMensaje.Size = new Size(256, 295);
            rtbMensaje.TabIndex = 0;
            rtbMensaje.Text = "";
            // 
            // btnServidor
            // 
            btnServidor.Location = new Point(126, 358);
            btnServidor.Name = "btnServidor";
            btnServidor.Size = new Size(75, 23);
            btnServidor.TabIndex = 1;
            btnServidor.Text = "button1";
            btnServidor.UseVisualStyleBackColor = true;
            btnServidor.Click += btnServidor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServidor);
            Controls.Add(rtbMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbMensaje;
        private Button btnServidor;
    }
}

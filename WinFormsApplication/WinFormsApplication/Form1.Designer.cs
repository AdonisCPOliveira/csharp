namespace WinFormsApplication
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
            txtResultado = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(34, 107);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 0;
            label1.Text = "Pressione Ok para preencher a caixa de texto";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(34, 148);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(391, 23);
            txtResultado.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(34, 177);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(391, 82);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 512);
            Controls.Add(btnOk);
            Controls.Add(txtResultado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResultado;
        private Button btnOk;
    }
}

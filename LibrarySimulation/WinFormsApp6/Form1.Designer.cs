namespace WinFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(35, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(166, 162);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(164, 94);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(432, 162);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(164, 94);
            listBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(207, 112);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de Libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(467, 112);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Lista de Usuarios";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(207, 283);
            button1.Name = "button1";
            button1.Size = new Size(82, 43);
            button1.TabIndex = 5;
            button1.Text = "Agregar Libro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(192, 0, 192);
            button2.Location = new Point(473, 283);
            button2.Name = "button2";
            button2.Size = new Size(82, 43);
            button2.TabIndex = 6;
            button2.Text = "Agregar Usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.FromArgb(192, 0, 192);
            button3.Location = new Point(207, 371);
            button3.Name = "button3";
            button3.Size = new Size(82, 43);
            button3.TabIndex = 7;
            button3.Text = "Eliminar Libro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(473, 371);
            button4.Name = "button4";
            button4.Size = new Size(82, 43);
            button4.TabIndex = 8;
            button4.Text = "EliminarUsuario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Red;
            button5.Location = new Point(207, 458);
            button5.Name = "button5";
            button5.Size = new Size(82, 43);
            button5.TabIndex = 9;
            button5.Text = "Ver Libro";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.FromArgb(192, 0, 192);
            button6.Location = new Point(473, 458);
            button6.Name = "button6";
            button6.Size = new Size(82, 43);
            button6.TabIndex = 10;
            button6.Text = "Ver Usuario";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.ForeColor = Color.FromArgb(192, 0, 192);
            button7.Location = new Point(342, 335);
            button7.Name = "button7";
            button7.Size = new Size(82, 43);
            button7.TabIndex = 11;
            button7.Text = "Hacer Prestamo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.ForeColor = Color.FromArgb(192, 0, 192);
            button8.Location = new Point(582, 448);
            button8.Name = "button8";
            button8.Size = new Size(89, 53);
            button8.TabIndex = 12;
            button8.Text = "Ver Prestamos Usuario";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.ForeColor = Color.FromArgb(192, 0, 192);
            button9.Location = new Point(342, 422);
            button9.Name = "button9";
            button9.Size = new Size(82, 43);
            button9.TabIndex = 13;
            button9.Text = "Devolver";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.ForeColor = Color.FromArgb(192, 0, 192);
            button10.Location = new Point(589, 371);
            button10.Name = "button10";
            button10.Size = new Size(82, 43);
            button10.TabIndex = 14;
            button10.Text = "Ver historial prestamos";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 525);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}

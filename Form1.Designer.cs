namespace WinFormsApp1
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
            btn_del = new Button();
            btn_del_all = new Button();
            txt_box = new TextBox();
            listBox2 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_del
            // 
            btn_del.Location = new Point(39, 272);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 23);
            btn_del.TabIndex = 2;
            btn_del.Text = "Törlés";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_del_all
            // 
            btn_del_all.Location = new Point(159, 272);
            btn_del_all.Name = "btn_del_all";
            btn_del_all.Size = new Size(106, 23);
            btn_del_all.TabIndex = 3;
            btn_del_all.Text = "Összes törlése";
            btn_del_all.UseVisualStyleBackColor = true;
            // 
            // txt_box
            // 
            txt_box.Location = new Point(39, 41);
            txt_box.Name = "txt_box";
            txt_box.Size = new Size(226, 23);
            txt_box.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(39, 112);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(226, 139);
            listBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(39, 83);
            button1.Name = "button1";
            button1.Size = new Size(226, 23);
            button1.TabIndex = 6;
            button1.Text = "Hozzáad";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 351);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(txt_box);
            Controls.Add(btn_del_all);
            Controls.Add(btn_del);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button masikNev;
        private Button btn_del;
        private Button btn_del_all;
        private TextBox txt_box;
        private ListBox listBox2;
        private Button button1;
    }
}

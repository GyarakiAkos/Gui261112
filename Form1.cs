namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        button1.Click += Button1_Click;
        btn_del.Click += Btn_del_Click;
        btn_del_all.Click += Btn_del_all_Click;
    }

    private void Btn_del_all_Click(object? sender, EventArgs e)
    {
        listBox2.Items.Clear();
    }

    private void Btn_del_Click(object? sender, EventArgs e)
    {
       
        listBox2.Items.Remove(listBox2.SelectedItem);
        
    }

    private void Button1_Click(object? sender, EventArgs e)
    {
        listBox2.Items.Add(txt_box.Text);
    }
}

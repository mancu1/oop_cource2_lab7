/*
 Создать приложение, в котором, при щелчке мыши на 
поверхности одной кнопки цвет фона формы становится, 
синим, а при нажатии на другую кнопку, красным.
 */

namespace lab7;

public partial class Form1 : Form
{
    private void button1_Click(object sender, EventArgs e)
    {
        this.BackColor = Color.Blue;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.BackColor = Color.Red;
    }

    public Form1()
    {
        // add 2 buttons

        Button button1 = new Button();
        button1.Text = "Blue";
        button1.Location = new Point(15, 15);
        button1.Click += new EventHandler(button1_Click);
        this.Controls.Add(button1);

        Button button2 = new Button();
        button2.Text = "Red";
        button2.Location = new Point(15, 55);
        button2.Click += new EventHandler(button2_Click);
        this.Controls.Add(button2);

        InitializeComponent();
    }
}
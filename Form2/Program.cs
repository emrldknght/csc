using System;
using System.Windows.Forms;
using System.Drawing;

class SimpleForm2 : Form
{ 
    
    Button button1;
    int counter = 0;

    public SimpleForm2()
    {
        this.Text = "Simple text";
        this.Size = new Size(400, 400);

        button1 = addButton("Click me!");
        button1.Click += new System.EventHandler(button1_clickHandler);
        this.Controls.Add(button1);

        PictureBox pic1 = addPic();
        this.Controls.Add(pic1);

        ListBox list = addList();
        this.Controls.Add(list);

    }

    ListBox addList()
    {
        ListBox myList = new System.Windows.Forms.ListBox();

        myList.Location = new System.Drawing.Point(20, 200);
        myList.Size = new Size(100, 100);
        myList.Items.Add("Forests");
        myList.Items.Add("Veld");
        myList.Items.Add("Lake");
        myList.Items.Add("Sea");
        myList.Items.Add("Ocean");

        myList.SelectedIndex = 2;
        return myList;
    }

    PictureBox addPic()
    {
        PictureBox myPic = new PictureBox();
        myPic.SizeMode = PictureBoxSizeMode.StretchImage;

        Bitmap zayac = new Bitmap("pic\\zayac.bmp");

        myPic.ClientSize = new Size(this.Width, 150);
        myPic.Image = zayac;

        return myPic;
    }

    Button addButton(string txt)
    {
        Button newButton = new Button();
        newButton.Text = txt;
        newButton.Width = 120;
        newButton.Height = 60;
        newButton.Top = 100;
        newButton.Left = 100;

        return newButton;
    }

    void button1_clickHandler(object sender, EventArgs e)
    {
        counter++;
        button1.Text = "Clicked " + counter +" times!";
    }

    static void Main()
    {
        Application.Run(new SimpleForm2());
    }
}
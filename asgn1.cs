using System.Windows.Forms;
using System.Drawing;
using System;

class AssignOne : Form {
	static string myName;

	public AssignOne(string title, string name){
		this.Text = title;		
		myName = name;
	}

	void p2Button_Click(object sender, EventArgs e) {
   	 MessageBox.Show("Clicked");
	}
}

class app {
 static void Main() {
	Form f = new AssignOne("First Form!", "Joseph");
	f.Size = new System.Drawing.Size(1167, 500); 	//Source: https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-resize-windows-forms
	Panel p1 = new Panel();
	Panel p2 = new Panel();
	Button p2Button = new Button();			//Source: myFirstApp.cs
	
	p1.Size = new System.Drawing.Size(583, 400);
	p2.Size = new System.Drawing.Size(583, 400);
	p1.BackColor = Color.FromArgb(200, 225, 200);	//Source: https://social.msdn.microsoft.com/Forums/en-US/81ee8efd-29cf-40a1-b0e7-5db96c34c970/wanting-to-change-a-forms-background-colour-with-the-click-of-a-radio-button?forum=csharpgeneral
	p2.BackColor = Color.FromArgb(145, 200, 200);	//Source: https://stackoverflow.com/questions/2891686/set-form-backcolor-to-custom-color
	p1.Location = new Point(0, 0);			//Source: https://stackoverflow.com/questions/23648371/point-class-in-c-sharp
	p2.Location = new Point(584, 0);		
	p2Button.Text = "Click here!";
	//p2Button.Click += p2Button_Click;
	p2Button.Location = new Point(800, 350); 

	f.Controls.Add(p2Button);
	f.Controls.Add(p1);				//Source: https://stackoverflow.com/questions/9401337/adding-panels-to-a-form-in-c-sharp-during-execution
	f.Controls.Add(p2);

	Application.Run(f);
	}
}
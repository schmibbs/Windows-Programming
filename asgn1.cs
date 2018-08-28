using System.Windows.Forms;
using System.Drawing;

class AssignOne : Form {
	static string myName;

	public AssignOne(string title, string name){
		this.Text = title;		
		myName = name;
	}
}

class app {
 static void Main() {
	Form f = new AssignOne("First Form!", "Joseph");
	f.Size = new System.Drawing.Size(1167, 500); 	//Source: https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-resize-windows-forms
	Panel p1 = new Panel();
	Panel p2 = new Panel();
	
	p1.Size = new System.Drawing.Size(583, 400);
	p2.Size = new System.Drawing.Size(583, 400);
	p1.BackColor = Color.Red;			//Source: https://social.msdn.microsoft.com/Forums/en-US/81ee8efd-29cf-40a1-b0e7-5db96c34c970/wanting-to-change-a-forms-background-colour-with-the-click-of-a-radio-button?forum=csharpgeneral
	p2.BackColor = Color.Blue;
	p1.Location = new Point(0, 0);			//Source: https://stackoverflow.com/questions/23648371/point-class-in-c-sharp
	p2.Location = new Point(584, 0);
	f.Controls.Add(p1);				//Source: https://stackoverflow.com/questions/9401337/adding-panels-to-a-form-in-c-sharp-during-execution
	f.Controls.Add(p2);
	Application.Run(f);
	}
}
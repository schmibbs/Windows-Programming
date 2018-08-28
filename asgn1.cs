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
	p1.BorderStyle = BorderStyle.FixedSingle;	//Source: https://stackoverflow.com/questions/28255438/programmatically-create-panel-and-add-picture-boxes
	p1.Location = new Point(50, 50);		//Source: https://stackoverflow.com/questions/23648371/point-class-in-c-sharp
	f.Controls.Add(p1);				//Source: https://stackoverflow.com/questions/9401337/adding-panels-to-a-form-in-c-sharp-during-execution
	Application.Run(f);
	}
}
using System.Windows.Forms;

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
	f.Size = new System.Drawing.Size(500, 500); //Source: https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-resize-windows-forms
	Application.Run(f);
	}
}
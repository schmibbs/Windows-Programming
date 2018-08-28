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
	Application.Run(f);
	}
}
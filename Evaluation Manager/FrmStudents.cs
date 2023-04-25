using System.Windows.Forms;
using System;

public partial class FrmStudents : Form {
    public FrmStudents() {
        InitializeComponent();
    }

    private void FrmStudents_Load(object sender, EventArgs e) {
        ShowStudents();
    }

    private void ShowStudents() {
        var students = StudentRepository.GetStudents();
        dgvStudents.DataSource = students;

        dgvStudents.Columns["Id"].DisplayIndex = 0;
        dgvStudents.Columns["FirstName"].DisplayIndex = 1;
        dgvStudents.Columns["LastName"].DisplayIndex = 2;
        dgvStudents.Columns["Grade"].DisplayIndex = 3;
    }
}
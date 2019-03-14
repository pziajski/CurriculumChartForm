using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample
{
    public partial class AddCourse : Form
    {
        #region Variables

        private AddCourseDel del;
        private List<Course> courses;

        #endregion

        public AddCourse(AddCourseDel del, List<Course> courses)
        {
            InitializeComponent();
            this.del = del;
            this.courses = courses;
        }

        #region Methods

        private void UpdatePrerequisiteListBox(List<Course> list)
        {
            this.prereqLB.Items.Clear();
            List<Course> temp = new List<Course>();
            string semester = (Convert.ToInt32(semesterTB.Text) - 1).ToString();
            temp.AddRange(list.Where(x => x.Semester == semester).Where(x => x.Program == programTB.Text).ToList());

            foreach (Course i in temp)
            {
                this.prereqLB.Items.Add(i.Name);
            }
        }

        public Course AddNewCourse()
        {
            Course newCourse = new Course()
            {
                Name = this.nameTB.Text,
                Semester = this.semesterTB.Text,
                Program = this.programTB.Text,
                Prerequisite = this.prereqLB.CheckedItems.OfType<string>().ToList()
            };
            return newCourse;
        }

        #endregion

        #region Events

        private void saveBN_Click(object sender, EventArgs e)
        {
            del(this.AddNewCourse());
            this.Close();
        }

        private void updateBN_Click(object sender, EventArgs e) => UpdatePrerequisiteListBox(this.courses);

        #endregion

    }
}

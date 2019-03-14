using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DatabaseExample
{
    public delegate void AddCourseDel(Course course);

    public partial class Main : Form
    {
        #region Variables

        private DataBaseManager db;

        #endregion

        public Main()
        {
            db = new DataBaseManager();
            InitializeComponent();
            db.Courselist = db.ReadFromXml();
        }

        #region Methods

        private void SaveToFile() => db.WriteToXml();

        private void StorePrerequisites(Course c, TreeNode node)
        {
            if (c != null)
            {
                foreach (string pre in c.Prerequisite)
                {
                    if (pre != "")
                    {
                        node.Nodes.Add(pre);
                        StorePrerequisites(db.Courselist.Where(x => x.Name == pre).FirstOrDefault(), node.Nodes[node.Nodes.Count - 1]);
                    }
                    else break;
                }
            }
        }

        private void UpdateTreeView()
        {
            this.treeView.Nodes.Clear();
            string[] programName = { "ECT", "EEN", "EET" };

            this.treeView.BeginUpdate();
            this.treeView.Nodes.Add("ECT");
            this.treeView.Nodes.Add("EEN");
            this.treeView.Nodes.Add("EET");

            for (int i = 0; i < 3; i++)
            {
                if (treeView.Nodes[i].Text == "EEN")
                {
                    treeView.Nodes[i].Nodes.Add("Semester 4");
                    treeView.Nodes[i].Nodes.Add("Semester 3");
                    treeView.Nodes[i].Nodes.Add("Semester 2");
                    treeView.Nodes[i].Nodes.Add("Semester 1");
                }
                else
                {
                    treeView.Nodes[i].Nodes.Add("Semester 6");
                    treeView.Nodes[i].Nodes.Add("Semester 5");
                    treeView.Nodes[i].Nodes.Add("Semester 4");
                    treeView.Nodes[i].Nodes.Add("Semester 3");
                    treeView.Nodes[i].Nodes.Add("Semester 2");
                    treeView.Nodes[i].Nodes.Add("Semester 1");
                }
            }

            foreach (Course i in db.Courselist)
            {
                for (int program = 0; program < 3; program++)
                {
                    if (treeView.Nodes[program].Text == "EEN")
                    {
                        for (int semester = 0; semester < 4; semester++)
                        {
                            if (i.Program == treeView.Nodes[program].Text & i.Semester == treeView.Nodes[program].Nodes[semester].Text.Split(' ').ElementAt(1))
                            {
                                this.treeView.Nodes[program].Nodes[semester].Nodes.Add(i.Name);
                                StorePrerequisites(i, this.treeView.Nodes[program].Nodes[semester].Nodes[this.treeView.Nodes[program].Nodes[semester].Nodes.Count - 1]);
                            }
                        }
                    }
                    else
                    {
                        for (int semester = 0; semester < 6; semester++)
                        {
                            if (i.Program == treeView.Nodes[program].Text & i.Semester == treeView.Nodes[program].Nodes[semester].Text.Split(' ').ElementAt(1))
                            {
                                this.treeView.Nodes[program].Nodes[semester].Nodes.Add(i.Name);
                                StorePrerequisites(i, this.treeView.Nodes[program].Nodes[semester].Nodes[this.treeView.Nodes[program].Nodes[semester].Nodes.Count - 1]);
                            }
                        }
                    }
                }
            }

            this.treeView.EndUpdate();
        }

        public void AddCourse(Course course)
        {
            db.Courselist.Add(course);
            SaveToFile();
        }

        #endregion

        #region Events

        private void Main_Load(object sender, EventArgs e) => UpdateTreeView();

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseDel del = new AddCourseDel(AddCourse);
            AddCourse form = new AddCourse(del, db.Courselist);
            form.ShowDialog();
            UpdateTreeView();
        }

        #endregion

    }
}

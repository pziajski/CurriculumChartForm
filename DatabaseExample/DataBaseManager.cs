using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DatabaseExample
{
    public class DataBaseManager
    {
        #region Attributes

        private string file = @"..\..\CourseInfo.xml";

        #endregion

        #region Properties

        public List<Course> Courselist { get; set; }

        #endregion

        #region Methods

        #region Private

        #endregion

        #region Public

        public void WriteToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Course>));
            using (TextWriter writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, Courselist);
            }
        }

        public List<Course> ReadFromXml()
        {
            List<Course> rtn = new List<Course>();
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(rtn.GetType());
                rtn = (List<Course>)serializer.Deserialize(fs);
            }
            return SortCourses(rtn);
        }

        public List<Course> SortCourses(List<Course> courses)
        {
            var rtn = courses.OrderBy(x => x.Name).ToList();
            foreach (Course c in rtn)
            {
                List<string> l = new List<string>();
                l.AddRange(c.Prerequisite);
                c.Prerequisite.Clear();
                c.Prerequisite.AddRange(l.OrderBy(x => x).ToList());
            }
            return rtn;
        }

        #endregion

        #endregion

        #region Events
        #endregion
    }
}

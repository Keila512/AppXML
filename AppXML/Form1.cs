using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppXML
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static void WriteXmlDocument()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("Employees");
            doc.AppendChild(root);

            XmlNode employeeNode = doc.CreateElement("Employee");
            XmlAttribute attribute = doc.CreateAttribute("Name");           
            attribute.Value = "Keila";
            employeeNode.Attributes.Append(attribute);
            XmlNode lastNameNode = doc.CreateElement("LastName");
            lastNameNode.InnerText = "de la Torre";
            XmlNode ageNode = doc.CreateElement("Age");
            ageNode.InnerText = "22";
            employeeNode.AppendChild(lastNameNode);
            employeeNode.AppendChild(ageNode);
            root.AppendChild(employeeNode);

            employeeNode = doc.CreateElement("Employee");
            attribute = doc.CreateAttribute("Name");
            attribute.Value = "Luis";
            employeeNode.Attributes.Append(attribute);
            lastNameNode = doc.CreateElement("LastName");
            lastNameNode.InnerText = "Fabela";
            ageNode = doc.CreateElement("Age");
            ageNode.InnerText = "19";
            employeeNode.AppendChild(lastNameNode);
            employeeNode.AppendChild(ageNode);
            root.AppendChild(employeeNode);

            employeeNode = doc.CreateElement("Employee");
            attribute = doc.CreateAttribute("Name");
            attribute.Value = "Yadira";
            employeeNode.Attributes.Append(attribute);
            lastNameNode = doc.CreateElement("LastName");
            lastNameNode.InnerText = "Quiroz";
            ageNode = doc.CreateElement("Age");
            ageNode.InnerText = "19";
            employeeNode.AppendChild(lastNameNode);
            employeeNode.AppendChild(ageNode);
            root.AppendChild(employeeNode);

            employeeNode = doc.CreateElement("Employee");
            attribute = doc.CreateAttribute("Name");
            attribute.Value = "Daylin";
            employeeNode.Attributes.Append(attribute);
            lastNameNode = doc.CreateElement("LastName");
            lastNameNode.InnerText = "Cruz";
            ageNode = doc.CreateElement("Age");
            ageNode.InnerText = "20";
            employeeNode.AppendChild(lastNameNode);
            employeeNode.AppendChild(ageNode);
            root.AppendChild(employeeNode);

            doc.Save("example.xml");
        }
        private void btnRead_Click_1(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\keila\source\repos\AppXML\AppXML\bin\Debug\example.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);
            dgvData.DataSource = dataSet.Tables[0];
            WriteXmlDocument();
        }
    }

}

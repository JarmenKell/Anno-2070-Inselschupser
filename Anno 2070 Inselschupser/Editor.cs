using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Anno_2070_Inselschupser
{
    public partial class Editor : Form
    {
        Bild picture;
        XmlDocument doc;
        new XmlNode Width;
        new XmlNode Height;
        string datei;
        public static Boolean opened;

        void datagrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            datagrid.Rows[datagrid.Rows.Count - 2].Cells[0].Value = datagrid.Rows.Count - 1;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int sizeto = int.Parse(leftto.Text);
            int tosize = int.Parse(toright.Text);
            int[,] islands = new int[datagrid.Rows.Count - 1,5];
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                islands[i, 0] = (int)datagrid.Rows[i].Cells[0].Value;

                switch (datagrid.Rows[i].Cells[1].Value.ToString())
                {
                    case "Normal Island":
                        islands[i, 1] = 0;
                        break;

                    case "Underwaterplateau":
                        islands[i, 1] = 1;
                        break;

                    case "Main Island":
                        islands[i, 1] = 2;
                        break;

                    case "E.T.O.":
                        islands[i, 1] = 3;
                        break;

                    case "Pirate Island":
                        islands[i, 1] = 4;
                        break;
                }

                islands[i, 2] = (int.Parse(datagrid.Rows[i].Cells[2].Value.ToString()) * sizeto) / tosize;
                islands[i, 3] = (int.Parse(datagrid.Rows[i].Cells[3].Value.ToString()) * sizeto) / tosize;
                islands[i, 4] = (int.Parse(datagrid.Rows[i].Cells[4].Value.ToString()) * sizeto) / tosize;
            }

            if (size.SelectedItem.ToString() == "Big")
            {
                Width.Value = "1792";
                Height.Value = "1792";
            }
            else if (size.SelectedItem.ToString() == "Medium")
            {
                Width.Value = "1664";
                Height.Value = "1664";
            }
            else if (size.SelectedItem.ToString() == "Small")
            {
                Width.Value = "1280";
                Height.Value = "1280";
            }
            else
            {
                Width.Value = "2560";
                Height.Value = "2560";
            }

            if (!opened)
            {
                opened = true;
                picture = new Bild();
                picture.Show();
            }
                picture.repaint(islands, (int.Parse(Width.Value) * sizeto) / tosize);
        }

        public Editor(string[] args)
        {
            InitializeComponent();
            datagrid.UserAddedRow += new DataGridViewRowEventHandler(datagrid_UserAddedRow);

            if (args.Length > 0)
            {
                datei = args[0];
                doc = new XmlDocument();
                doc.Load(datei);
                XmlNodeList RandomMapTemplate = doc.DocumentElement.ChildNodes;
                Width = RandomMapTemplate[1].FirstChild;
                Height = RandomMapTemplate[2].FirstChild;
                XmlNodeList IslandTemplates = RandomMapTemplate[3].ChildNodes;

                if (Width.Value == "1792")
                {
                    size.SelectedIndex = 0;
                }
                else if (Width.Value == "1664")
                {
                    size.SelectedIndex = 1;
                }
                else if (Width.Value == "1280")
                {
                    size.SelectedIndex = 2;
                }
                else
                {
                    size.SelectedIndex = 3;
                }

                for (int i = 0; i < IslandTemplates.Count / 2; i++)
                {
                    XmlNodeList Island = IslandTemplates[i * 2 + 1].ChildNodes[1].ChildNodes;
                    XmlNodeList Rect = Island[1].ChildNodes;
                    datagrid.Rows.Add();
                    datagrid.Rows[i].Cells[0].Value = i + 1;

                    switch (Island[0].FirstChild.Value)
                    {
                        case "0":
                            datagrid.Rows[i].Cells[1].Value = "Normal Island";
                            break;

                        case "1":
                            datagrid.Rows[i].Cells[1].Value = "Underwaterplateau";
                            break;

                        case "2":
                            datagrid.Rows[i].Cells[1].Value = "Main Island";
                            break;

                        case "3":
                            datagrid.Rows[i].Cells[1].Value = "E.T.O.";
                            break;

                        case "4":
                            datagrid.Rows[i].Cells[1].Value = "Pirate Island";
                            break;
                    }

                    datagrid.Rows[i].Cells[2].Value = Rect[0].FirstChild.Value;
                    datagrid.Rows[i].Cells[3].Value = Rect[1].FirstChild.Value;
                    datagrid.Rows[i].Cells[4].Value = (int.Parse(Rect[2].FirstChild.Value) - int.Parse(Rect[0].FirstChild.Value)).ToString();
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (datei != null)
            {
                if (size.SelectedItem.ToString() == "Big")
                {
                    Width.Value = "1792";
                    Height.Value = "1792";
                }
                else if (size.SelectedItem.ToString() == "Medium")
                {
                    Width.Value = "1664";
                    Height.Value = "1664";
                }
                else if (size.SelectedItem.ToString() == "Small")
                {
                    Width.Value = "1280";
                    Height.Value = "1280";
                }
                else
                {
                    Width.Value = "2560";
                    Height.Value = "2560";
                }

                string islandxml = "";
                for (int i = 0; i < datagrid.Rows.Count - 1; i++)
                {
                    int islandtype = 0;
                    islandxml += "\r\n<k>" + (i + 1) + "</k><v><hasValue>1</hasValue><Island><Type>";
                    switch (datagrid.Rows[i].Cells[1].Value.ToString())
                    {
                        case "Normal Island":
                            islandxml += 0;
                            islandtype = 0;
                            break;

                        case "Underwaterplateau":
                            islandxml += 1;
                            islandtype = 1;
                            break;

                        case "Main Island":
                            islandxml += 2;
                            islandtype = 2;
                            break;

                        case "E.T.O.":
                            islandxml += 3;
                            islandtype = 3;
                            break;

                        case "Pirate Island":
                            islandxml += 4;
                            islandtype = 4;
                            break;
                    }

                    int left = int.Parse(datagrid.Rows[i].Cells[2].Value.ToString());
                    int top = int.Parse(datagrid.Rows[i].Cells[3].Value.ToString());
                    int cardsize = int.Parse(datagrid.Rows[i].Cells[4].Value.ToString());
                    islandxml += "</Type><Rect><left>" + left + "</left><top>" + top + "</top><right>" + (left + cardsize) + "</right><bottom>" + (top + cardsize) + "</bottom></Rect><Climes>";

                    if (islandtype % 2 == 0)
                    {
                        islandxml += 1 + "</Climes></Island></v>";
                    }
                    else
                    {
                        islandxml += 2 + "</Climes></Island></v>";
                    }
                }

                doc.DocumentElement.ChildNodes[1].InnerXml = Width.OuterXml;
                doc.DocumentElement.ChildNodes[2].InnerXml = Height.OuterXml;
                doc.DocumentElement.ChildNodes[3].InnerXml = islandxml + "\r\n";
                StreamWriter file = new StreamWriter(datei);
                file.Write(doc.DocumentElement.OuterXml);
                file.Close();
            }
        }
    }
}

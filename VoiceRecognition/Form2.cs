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

namespace VoiceRecognition
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            string[] stuff = new string[12];
            stuff = Form1.recognized_list;

            for (int i = 0; i < stuff.Length; i++ )
            {

                if (stuff[i] != null)
                {
                    Recognized_words_text.Text += stuff[i];
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            XmlDocument myXmlDocument = new XmlDocument();
            string path = "L:\\Dropbox\\Projects\\VoiceRecognition\\grammar.xml";
            //string path = Directory.GetCurrentDirectory();
            try
            {
                myXmlDocument.Load(path);
            }
            catch
            {
                XmlTextWriter writer = new XmlTextWriter("grammar.xml", null);
                //writer.Formatting = Formatting.Indented;
                //doc.Save(writer);
            }
            XmlNode node;
            node = myXmlDocument.DocumentElement;

            foreach (XmlNode node1 in node.ChildNodes)
                foreach (XmlNode node2 in node1.ChildNodes)
                    if (node2.Name == "price")
                    {
                        Decimal price = Decimal.Parse(node2.InnerText);
                        // Increase all the book prices by 20%
                        String newprice = ((Decimal)price * (new Decimal(1.20))).ToString("#.00");
                        Console.WriteLine("Old Price = " + node2.InnerText + "\tNew price = " + newprice);
                        node2.InnerText = newprice;
                    }

            myXmlDocument.Save("grammar.xml");
             * */
        }


    }
}

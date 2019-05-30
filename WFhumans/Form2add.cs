using System;
using System.Windows.Forms;
using Kyrsach.citymapelement;

namespace WFhumans
{
    public partial class Form2add : Form
    {
        CityMapElement element = new CityMapElement();

        internal CityMapElement ElementAdd
        {
            get { return element; }
            set { element = value; }
        }
        public Form2add()
        {
            InitializeComponent();
        }

        private void btaddHuman_Click(object sender, EventArgs e)
        {
            // перехватчик ошибок, если кто-то захочет написать текст
            try
            {
                element.Area = Convert.ToInt32(textBoxArea.Text);
                element.Latitude = Convert.ToInt32(textBoxLatitude.Text);
                element.Longitude = Convert.ToInt32(textBoxLongitude.Text);
            }
            catch (Exception)
            {
                // что-то в случае ошибки
            }
        }
    }
}

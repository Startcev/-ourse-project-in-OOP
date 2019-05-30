using System;
using System.Windows.Forms;
using consHuman;
using Kyrsach.citymapelement;

namespace WFhumans
{
    public partial class Form1 : Form
    {
        Form2add fAdd;
        Store store = new Store();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form2add fAdd)
        {
            this.fAdd = fAdd;
            InitializeComponent();
        }

        public void addElementsInGW()
        {
            GW1.RowCount = 2;
            GW1.ColumnCount = 3;
            string[] row = new string[3];

            foreach (var x in store.ListElement)
            {
                row[0] = x.Area.ToString();
                row[1] = x.Latitude.ToString();
                row[2] = x.Longitude.ToString();
                GW1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2add f = new Form2add();
            f.ShowDialog();
            store.addListHuman(f.ElementAdd);
            addElementsInGW();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GW1.RowCount = 2;
            GW1.ColumnCount = 3;
            GW1.Rows[0].Cells[0].Value = "Плащадь";
            GW1.Rows[0].Cells[1].Value = "Широта";
            GW1.Rows[0].Cells[2].Value = "Долгота";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Store.safeObjects(store);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            store = (Store)Store.loadObjects();
            addElementsInGW();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbName.Checked)
                {
                    CityMapElement element = new CityMapElement();
                    element = store.searchElement(Convert.ToInt32(tbSearch.Text));
                    for (int i = 0; i < GW1.RowCount; i++)
                    {
                        for (int j = 0; j < GW1.ColumnCount; j++)
                        {
                            if (Convert.ToInt32(GW1.Rows[i].Cells[j].Value) == element.Area)
                            {
                                GW1.Rows[i].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // ошибка
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbName.Checked)
            {
                store.sortElement();
                addElementsInGW();
            }
        }
    }
}

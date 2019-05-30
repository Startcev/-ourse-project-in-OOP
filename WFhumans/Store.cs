using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Kyrsach.citymapelement;

namespace consHuman
{
    [Serializable]
    class Store
    {
        // лист с элементами
        private List<CityMapElement> listElement = new List<CityMapElement>();
        internal List<CityMapElement> ListElement
        {
            get { return listElement; }

        }

        // добавление объекта в файл
        static public void safeObjects(object elements)
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.Create("elementsData.dat");

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            myBinaryFormat.Serialize(myStream, elements);
            myStream.Close();
        }

        // загрузка объектов
        static public object loadObjects()
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.OpenRead("elementsData.dat");

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            object obj = myBinaryFormat.Deserialize(myStream);
            myStream.Close();
            return obj;
        }

        // добавление одного элемента в список
        public void addListHuman(CityMapElement element)
        {
            listElement.Add(element);
        }

        // удаление элемента из списка
        public void delListHuman(CityMapElement element)
        {
            listElement.Remove(element);
        }

        // поиск
        public CityMapElement searchElement(int aria)
        {
            return listElement.Find((t) => t.Area == aria); //лямбда выражения
        }

        // сортировака
        public void sortElement()
        {
            listElement.Sort((t, t1) => t.Area.CompareTo(t1.Area)); //лямбда выражения 
        }
    }
}

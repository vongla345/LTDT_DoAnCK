using demo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LTDT_GiaoDien
{
    internal class Main
    {
        public static void getQuan(Hashtable hashQuan, District[] listDistrict)
        {
            //List<District> listDistrict = new List<District>();
            for (int i = 0; i < listDistrict.Length; i++)
            {
                listDistrict[i].Name = "Quận " + (i + 1);
            }
        }
        public static void getItems(string[] inputItem, District[] listDistrict) {

                    //Gán vào hashtable     KEY = string(num)
                    //Item
            string[] tmp;
            
            foreach (string x in inputItem)
            {
                tmp = x.Split('|');

                Item tmpItem = new Item(tmp[2], tmp[1]);

                listDistrict[int.Parse(tmp[0]) - 1].getListItems().Add(tmpItem);
            }
        }
        public static void getNV(string[] inputNV, District[] listDistrict) { 
            //NV
            
            for (int i = 0; i < inputNV.Length; i++)
            {
                string[] tmpNV = inputNV[i].Split('|');
                Employee tmpEmployee = new Employee(tmpNV[0]);

                string[] tmpJob = tmpNV[1].Split('-');
                foreach (var z in tmpJob)
                {
                    listDistrict[int.Parse(z) - 1].getListEmployees().Add(tmpEmployee);
                }
            }
        }
        public static void getMap(string[] inputMap) {

            //Đọc map từ file, List chứa các đỉnh (Object đỉnh thì qua class Vertex xem)    =>>>> INDEX
            
            int LEN = inputMap.Length;

            int[,] map = new int[LEN, LEN];
            List<Vertex> vertexList = new List<Vertex>();

            string[] split;
            for (int a = 0; a < LEN; a++)
            {
                split = inputMap[a].Split(' ');

                Vertex tmpVertex = new Vertex(a);

                for (int b = 0; b < LEN; b++)
                {
                    map[a, b] = int.Parse(split[b]);

                    if (map[a, b] != 0)
                    {
                        tmpVertex.Add(b);
                    }
                }
                vertexList.Add(tmpVertex);
            }
        }
        /*
        public static void coloringMap(District[] listDistrict, Hashtable hashQuan, List<Vertex> vertexList, string[] color,int colorCount) { 
            //Cooring graph
            Function function = new Function();

            vertexList.Sort((a, b) => b.getAdjVertex().Count().CompareTo(a.getAdjVertex().Count()));
            function.coloringGraph(ref vertexList, ref hashQuan, color, ref colorCount);
            //Console.WriteLine();

            function.Output(listDistrict, hashQuan, vertexList, color, colorCount);
        }
        */
    }
}

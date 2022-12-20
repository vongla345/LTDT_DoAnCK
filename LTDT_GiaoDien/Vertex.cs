using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Vertex
    {
        List<int> adjVertex;
        string color;
        int id;
        public Vertex(int _id, string _color = "no color")
        {
            id = _id;
            adjVertex = new List<int>();
            color = _color;
        }

        public List<int> getAdjVertex()
        {
            return adjVertex;
        }
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public void Add(int num)
        {
            adjVertex.Add(num);
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}

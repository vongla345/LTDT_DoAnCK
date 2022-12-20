using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTDT_GiaoDien;
using MaterialSkin.Controls;

namespace demo
{
    internal class Function
    {

        //Hàm này chạy sẽ lâu vì nó bị chổ a=-1 (đọc sẽ thấy), nếu được thì ông tối ưu lại vòng for 'a'
        public void coloringGraph(ref List<Vertex> list, ref Hashtable hashQuan, string[] color, ref int colorCount)
        {
            List<Vertex> tmp = new List<Vertex>();
            List<Vertex> T = new List<Vertex>();
            
            while (list.Count > 0)
            {

                list[0].Color = color[colorCount];

                tmp.Add(list[0]);
                T.Add(list[0]);


                hashQuan.Add(color[colorCount], list[0].ID);


                list.RemoveAt(0);

                for (int a = 0; a < list.Count; a++)
                {
                    bool ok = true;
                    for (int b = 0, sizeB = T.Count; b < sizeB; b++)
                    {
                        for (int c = 0, sizeC = T[b].getAdjVertex().Count; c < sizeC; c++)
                        {
                            if (list[a].ID == T[b].getAdjVertex()[c])
                            {
                                ok = false;
                                break;
                            }
                        }
                        if (!ok)
                        {
                            break;
                        }
                    }
                    if (ok)
                    {
                        list[a].Color = color[colorCount];

                        T.Add(list[a]);
                        tmp.Add(list[a]);


                        hashQuan[color[colorCount]] = hashQuan[color[colorCount]] + "|" + list[a].ID;


                        list.RemoveAt(a);
                        a = -1;  //Được thì làm lại khúc này, thay vì cho chạy lại thì tìm cách lưu những index 'a' đã thêm rồi xóa sau
                    }
                }
                colorCount++;
                T.Clear();
            }
            list = tmp;
        }


        //Này xuất ra thôi ông k thích thì viết lại, tui đọc lại cũng lú r =))
        public MaterialListView Output(District[] listDistrict, Hashtable hashQuan, List<Vertex> list, string[] color, int colorCount)
        {
            MaterialListView ListMain = new MaterialListView();
            
            return ListMain;
        }
    }
}
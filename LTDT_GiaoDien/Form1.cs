using demo;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Data;


namespace LTDT_GiaoDien
{
    
    public partial class MainForm : MaterialForm
    {
        int idCount = 12;
        List<string> inputItem = new List<string>()
                {"1|A0001|Sữa tắm",
            "1|A0002|Tủ lạnh",
            "3|A0004|Ti vi",
            "4|A0005|Đồ ăn",
            "5|A0006|Hàng hóa online",
            "5|A0006.1|Máy lạnh",
            "5|A0006.2|Hàng hóa online",
            "5|A0006.3|Laptop",
            "6|A0007|Trà sữa",
            "7|A0008|Dầu gội",
            "8|A0009|Hàng hóa online",
            "9|A00010|Đồ ăn",
            "10|A00011|Tủ lạnh",
            "12|SP001|Dầu gội"};
        List<string> inputNV = new List<string>()
                {"Minh|1",
                "Minh|2",
                "Minh|3",
                "Nhân|3",
                "Nhân|4",
                "Nhân|5",
                "Giang|5",
                "Giang|6",
                "Giang|7",
                "Bảo|7",
                "Bảo|8",
                "Bảo|9",
                "Hoàng|9",
                "Hoàng|10",
                "Hoàng|1",
                "Cửu|10",
                "Cửu|1",
                "Cửu|2",
                "Anh|10",
                "Anh|11",
                "Anh|12"};
        const int MAX = 9999;
        const int n = 12;
        
        public static int[,] map = new int[20, 20];
        

        public MainForm()
        {
            InitializeComponent();
            FormSettings();
        }
        public void FormSettings()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình ?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShipper.Clear();
            txtHang.Clear();
            txtDiaDiem.Clear();
            txtShipper.Focus();
        }
        void Display()
        {
            cbbDiaDiem.Items.Clear();
            cbbKhuVuc.Items.Clear();
            ListShipper.Items.Clear();


            const int DISTRICT_COUNT = 12;
            District[] listDistrict = new District[DISTRICT_COUNT].Select(h => new District()).ToArray();

            string[] inputMap;
            Hashtable hashQuan = new Hashtable();
            string[] color = { "RED", "ORANGE", "YELLOW", "BLUE", "GREEN", "PURPLE" };
            List<Vertex> vertexList = new List<Vertex>();
            int colorCount = 0;
            int LEN;
            //MessageBox.Show(listDistrict.Length.ToString());
            for (int i = 0; i < listDistrict.Length; i++)
            {
                listDistrict[i].Name = "Quận " + (i + 1);
                cbbDiaDiem.Items.Add(listDistrict[i].Name);
                cbbKhuVuc.Items.Add(listDistrict[i].Name);
            }
            
            //int LEN;
            //string[] color = { "RED", "ORANGE", "YELLOW", "BLUE", "GREEN", "PURPLE" };
            //int colorCount = 0;


            //Gán vào hashtable     KEY = string(num)
            //Item
            string[] tmp;
            //inputItem = File.ReadAllLines("items.txt"); //item item1
            foreach (string x in inputItem)
            {
                tmp = x.Split('|');

                Item tmpItem = new Item(tmp[2], tmp[1]);

                listDistrict[int.Parse(tmp[0]) - 1].getListItems().Add(tmpItem);
            }
            //NV
            //inputNV = File.ReadAllLines("NV.txt");
            for (int i = 0; i < inputNV.Count; i++)
            {
                string[] tmpNV = inputNV[i].Split('|');
                Employee tmpEmployee = new Employee(tmpNV[0]);
                listDistrict[int.Parse(tmpNV[1]) - 1].getListEmployees().Add(tmpEmployee);
                ListViewItem item = new ListViewItem(new[] { tmpNV[0], "Quận " + tmpNV[1] });
                ListShipper.Items.Add(item);
                
            }

            //Đọc map từ file, List chứa các đỉnh (Object đỉnh thì qua class Vertex xem)    =>>>> INDEX
            inputMap = File.ReadAllLines("map.txt"); //map map1 map2
            LEN = inputMap.Length;
            

            int[,] map = new int[LEN, LEN];
            vertexList = new List<Vertex>();
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


            //Cooring graph
            Function function = new Function();

            vertexList.Sort((a, b) => b.getAdjVertex().Count().CompareTo(a.getAdjVertex().Count()));
            function.coloringGraph(ref vertexList, ref hashQuan, color, ref colorCount);
            //Console.WriteLine();

            string ngay = "", quan = "", ten = "", mondo = "";
            for (int a = 0; a < colorCount; a++)
            {
                string ca = "";
                int day= 1;
                int k = a + 1;
                while (k > 2)
                {
                    k -= 2;
                    day++;
                }
                if ((a + 1) % 2 != 0)
                {
                    ca = "Ca 1 ";
                }
                else ca = "Ca 2 ";
                ngay = ca + "Ngày " + day.ToString();

                string[] Quan = hashQuan[color[a]].ToString().Split('|');

                for (int b = 0; b < Quan.Length; b++)
                {

                    quan = listDistrict[int.Parse(Quan[b])].Name;

                    List<Item> item = listDistrict[(int.Parse(Quan[b]))].getListItems();
                    List<Employee> employee = listDistrict[int.Parse(Quan[b])].getListEmployees();

                    if (item.Count > 0 && employee.Count > 0)
                    {
                        int job = item.Count / employee.Count,
                            countItem = 0;

                        if (item.Count == 1 || job == 0)
                        {
                            ten = employee[0].Name;
                            mondo = item[countItem++].Name;
                            ListViewItem listViewItem = new ListViewItem(new[] { ngay, ten, mondo, quan });
                            ListMain.Items.Add(listViewItem);
                        }
                        else if (item.Count > 1)
                        {
                            int c = 0;
                            for (; c < employee.Count; c++)
                            {
                                ten = (employee[c].Name);


                                while (job-- > 0)
                                {
                                    mondo = (item[countItem++].Name);
                                    ListViewItem listViewItem = new ListViewItem(new[] { ngay, ten, mondo, quan });
                                    ListMain.Items.Add(listViewItem);
                                }
                                job = item.Count / employee.Count;

                            }
                            while (countItem < item.Count)
                            {
                                mondo = (item[countItem++].Name);
                                ListViewItem listViewItem = new ListViewItem(new[] { ngay, ten, mondo, quan });
                                ListMain.Items.Add(listViewItem);
                            }
                        }

                    }

                }
            }
        }
       

        void loadCbb()
        {
            cbbViTriHienTai.Items.Add("Công ti giao hàng");
            cbbViTriCanToi.Items.Add("Công ti giao hàng");
            for(int i=1; i<=12; i++)
            {
                string s = "Quận " + i.ToString();
                cbbViTriHienTai.Items.Add(s);
                cbbViTriCanToi.Items.Add(s);
            }
            cbbViTriHienTai.SelectedIndex = 0;
            cbbViTriCanToi.SelectedIndex = 0;
        }
        
        void loadItem()
        {
            foreach (string i in inputItem)
            {
                string[] tmp = i.Split('|');
                ListViewItem lsttmp = new ListViewItem(new[] { tmp[2], "Quận " + tmp[0] });
                ListHang.Items.Add(lsttmp);
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            Display();    
            loadCbb();
            loadItem();
        }

        private void ListMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListMain.SelectedItems.Count > 0)
            {
                txtDiaDiem.Text = ListMain.SelectedItems[0].SubItems[3].Text;
                txtShipper.Text = ListMain.SelectedItems[0].SubItems[1].Text;
                txtHang.Text = ListMain.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListMain.Items.Clear();
            Display();
        }

        private void btnXoaShip_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(ListShipper.SelectedItems.Count > 0)
            {
                index = ListShipper.Items.IndexOf(ListShipper.SelectedItems[0]);  
                ListShipper.Items.Remove(ListShipper.SelectedItems[0]);
            }
            ListShipper.Items.RemoveAt(index);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        // Thuat toan tim duong di ngan nhat
        void convertMap()
        {
            string[] inputMap = File.ReadAllLines("mapDijkstra.txt");
            for (int i = 0; i < inputMap.Length; i++)
            {
                string[] s = inputMap[i].Split(' ');
                map[int.Parse(s[0]), int.Parse(s[1])] = int.Parse(s[2]);
                map[int.Parse(s[1]), int.Parse(s[0])] = int.Parse(s[2]);
            }
            
        }
        int nhoNhat(int[] luu, int[] check)
        {
            int kq = 9999, k = 0;
            for (int i = 0; i <= n; i++)
            {
                if (luu[i] < kq && check[i] == 0)
                {
                    kq = luu[i];
                    k = i;
                }
            }
            check[k] = 1;
            return k;
        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            int s; // diem bat dau
            int end; // diem ket thuc
            if (cbbViTriHienTai.Text.Trim() == "Công ti giao hàng")
            {
                s = 0;
            }
            else
            {
                string[] tmp = cbbViTriHienTai.Text.Trim().Split(' ');
                s = int.Parse(tmp[1]);
            }
            if (cbbViTriCanToi.Text.Trim() == "Công ti giao hàng")
            {
                end = 0;
            }
            else
            {
                string[] tmp = cbbViTriCanToi.Text.Trim().Split(' ');
                end = int.Parse(tmp[1]);
            }
            //MessageBox.Show(s.ToString()+" "+end.ToString());
            
            Output(s, end);
        }

        void Dijsktra(int[] luu, int[] check, int[] trace)
        {
            for (int i = 0; i <= n; i++)
            {
                int k = nhoNhat(luu, check);
                for (int j = 0; j <= n; j++)
                {
                    if (map[k, j] != 0 && check[j] == 0)
                    {
                        int tmp = luu[k] + map[k, j];
                        if (tmp < luu[j])
                        {
                            luu[j] = tmp;
                            trace[j] = k;
                        }
                    }
                }
            }
        }
        void Output(int s, int end)
        {
            convertMap();
            int[] luu = new int[1000], check = new int[1000], trace = new int[1000];

            for (int i = 0; i <= n; i++)
            {
                luu[i] = MAX;
            }
            luu[s] = 0;
            Dijsktra(luu, check, trace);

            txtTongQuangDuongDi.Text = luu[end].ToString();
            txtThoiGianDuKien.Text = (double.Parse(luu[end].ToString()) / 4).ToString() + " giờ";
            int[] Quan = new int[100];
            int index = 0;
            int k = end;
            while(k!= s)
            {
                Quan[index] = k;
                index++;
                k = trace[k];
            }
            string t = cbbViTriHienTai.Text.Trim() + " -> ";
            for(int i=index-1; i>=0; i--)
            {
                t += "Quận " + Quan[i].ToString();
                if (i != 0)
                {
                    t += " -> ";
                }
            }
            txtDuongDiNganNhat.Text = t;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            string itemName = txtTenHang.Text;
            string quan = cbbDiaDiem.Text;
            ListViewItem tmplstItem = new ListViewItem(new[] { itemName, quan });
            ListHang.Items.Add(tmplstItem);
            quan = quan.Substring(5);
            string addItem = quan + '|' + "A00" + idCount.ToString() + '|' + itemName;
            idCount++;
            List<string> listTmpItem = inputItem.ToList();
            listTmpItem.Add(addItem);
            inputItem = listTmpItem;
            
        }
        
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(ListHang.SelectedItems.Count> 0)
            {
                index = ListHang.Items.IndexOf(ListHang.SelectedItems[0]);
                ListHang.Items.RemoveAt(index);
            }
            inputItem.RemoveAt(index);
            
        }

        private void ListHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListHang.SelectedItems.Count > 0)
            {
                txtTenHang.Text = ListHang.SelectedItems[0].SubItems[0].Text.Trim();
                cbbDiaDiem.Text = ListHang.SelectedItems[0].SubItems[1].Text.Trim();
            }
        }

        private void btnClearHang_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            cbbDiaDiem.SelectedIndex= 0;
            txtTenHang.Focus();
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (ListHang.SelectedItems.Count > 0)
            {
                index = ListHang.Items.IndexOf(ListHang.SelectedItems[0]);
                ListHang.Items.RemoveAt(index);
            }
            inputItem.RemoveAt(index);
            string itemName = txtTenHang.Text;
            string quan = cbbDiaDiem.Text;
            ListViewItem tmplstItem = new ListViewItem(new[] { itemName, quan });
            ListHang.Items.Add(tmplstItem);
            quan = quan.Substring(5);
            string addItem = quan + '|' + "A00" + idCount.ToString() + '|' + itemName;
            idCount++;
            List<string> listTmpItem = inputItem.ToList();
            listTmpItem.Add(addItem);
            inputItem = listTmpItem;
        }

        private void btnThemShip_Click(object sender, EventArgs e)
        {
            string name = txtTenShip.Text.Trim();
            string quan = cbbKhuVuc.Text.Trim();
            ListViewItem list = new ListViewItem(new[] { name, quan });
            ListShipper.Items.Add(list);
            string[] tmp = quan.Split(' ');
            string add = name+ "|" + tmp[1];
            inputNV.Add(add);
        }

        private void ListShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListShipper.SelectedItems.Count > 0)
            {
                txtTenShip.Text = ListShipper.SelectedItems[0].SubItems[0].Text.Trim();
                cbbKhuVuc.Text = ListShipper.SelectedItems[0].SubItems[1].Text.Trim();
            }
        }

        private void btnSuaShip_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (ListShipper.SelectedItems.Count > 0)
            {
                index = ListShipper.Items.IndexOf(ListShipper.SelectedItems[0]);
                ListShipper.Items.Remove(ListShipper.SelectedItems[0]);
            }
            ListShipper.Items.RemoveAt(index);
            string name = txtTenShip.Text.Trim();
            string quan = cbbKhuVuc.Text.Trim();
            ListViewItem list = new ListViewItem(new[] { name, quan });
            ListShipper.Items.Add(list);
            string[] tmp = quan.Split(' ');
            string add = name + "|" + tmp[1];
            inputNV.Add(add);
        }

        private void btnClearShip_Click(object sender, EventArgs e)
        {
            txtTenShip.Clear();
            txtTenShip.Focus();
            cbbKhuVuc.SelectedIndex= 0;
        }
    }
}
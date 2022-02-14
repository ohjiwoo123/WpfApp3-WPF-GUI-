using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Friend> ar = new List<Friend>();
        Friend friends = new Friend("",0,"");
        public MainWindow()
        {
            InitializeComponent();
            //return;
            /////////////////////////////////
            //string[] items = new string[] { "강호동", "유재석", "홍길동" };
            //this.ListBox.Items.Add(items[0]);
            //this.ListBox.Items.Add(items[1]);
            //this.ListBox.Items.Add(items[2]);
            /////////////////////////////////
            //Friend[] friends = new Friend[] { new Friend("홍길동", 10, "남성"),
            //                                new Friend("김길동", 20, "여성"),
            //                                new Friend("장길동", 30, "여성") };
            //foreach (var item in friends)
            //{
            //    this.ListView.Items.Add(item);
            //}
        }

        // 추가 버튼
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CheckBox.IsChecked == true)
                MessageBox.Show("안내장을 발송합니다");
            Friend friends = new Friend("", 0, "");
            friends.Name = NameBox.Text;
            friends.Age = Convert.ToInt32(AgeBox.Text);
            if (radio_M_Btn.IsChecked == true)
                friends.Gender = "남성";
            else if (radio_W_Btn.IsChecked == true)
                friends.Gender = "여성";

            // 리스트 박스에 추가
            this.ListBox.Items.Add(friends.Name);
            // 리스트 뷰에 추가 
            this.ListView.Items.Add((Friend)friends);
            // 배열에 추가
            ar.Add(friends);

            // 초기화
            NameBox.Text = "";
            AgeBox.Text = "";
            radio_M_Btn.IsChecked = false;
            radio_W_Btn.IsChecked = false;
            CheckBox.IsChecked = false;
        }

        // 삭제 버튼
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Friend
    {
        // 프로퍼티 (Properties)
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        //public bool gender {
        //    get { if (true) return gender; }
        //    set { gender = value; } 
        //}

        public Friend(string _name, int _age, string _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
    }
}

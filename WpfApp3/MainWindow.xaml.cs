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
        Friend friends = new Friend(false,"",0,"");

        public MainWindow()
        {
            InitializeComponent();
        }

        // 추가 버튼
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CheckBox.IsChecked == true)
                MessageBox.Show("안내장을 발송합니다");
            Friend friends = new Friend(false,"", 0, "");
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
            for (int i = this.ListView.Items.Count - 1; i >= 0; i--)
            {
                Friend fr = (Friend)ListView.Items[i];
                if (fr.Selected==true)
                {
                    ListView.Items.RemoveAt(i);
                    ar.RemoveAt(i);
                }
            }
            MessageBox.Show("삭제");
        }
    }
    public class Friend
    {
        // 프로퍼티 (Properties)
        public bool Selected { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Friend(bool _selected, string _name, int _age, string _gender)
        {
            Selected = _selected;
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
    }

}

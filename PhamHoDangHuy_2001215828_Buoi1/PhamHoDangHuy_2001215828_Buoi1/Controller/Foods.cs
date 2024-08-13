using PhamHoDangHuy_2001215828_Buoi1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamHoDangHuy_2001215828_Buoi1.Controller
{
    public partial class Foods : Form
    {
        private FoodsService foodService;
        private ListBox listBoxSelectedFoods;
        private Button buttonShowSelected;
        private HandleFoods handleFoods;
        private Button buttonClearTextBoxes;
        private List<TextBox> searchTextBoxes;

        private List<CheckBox> checkBoxes;

        public Foods()
        {
            InitializeComponent();

            checkBoxes = new List<CheckBox>();
            searchTextBoxes = new List<TextBox>();
            foodService = new FoodsService();
            handleFoods = new HandleFoods();

            listBoxSelectedFoods = new ListBox
            {
                Left = 200,
                Top = 10,
                Width = 150,
                Height = 400
            };
            Controls.Add(listBoxSelectedFoods);

            buttonShowSelected = new Button
            {
                Left = 10,
                Top = 400,
                Text = "Show Selected",
                Width = 150
            };
            buttonShowSelected.Click += ButtonShowSelected_Click;
            Controls.Add(buttonShowSelected);

            buttonClearTextBoxes = new Button
            {
                Left = 10,
                Top = 450,
                Text = "Clear Textboxes",
                Width = 150
            };
            buttonClearTextBoxes.Click += ButtonClearTextBoxes_Click;
            Controls.Add(buttonClearTextBoxes);

            CreateSearchTextBoxes();
        }

        private void ButtonClearTextBoxes_Click(object sender, EventArgs e)
        {
            handleFoods.ClearAllTextBoxes(this);
        }

        private void Foods_Load(object sender, EventArgs e)
        {
            string[] foods = handleFoods.GetFoods();
            ControlCheckBoxes(foods);
        }

        private void ButtonShowSelected_Click(object sender, EventArgs e)
        {
            listBoxSelectedFoods.Items.Clear();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    listBoxSelectedFoods.Items.Add(checkBox.Text);
                }
            }
        }

        private void ControlCheckBoxes(string[] foods)
        {
            int topPosition = 10;
            foreach (string food in foods)
            {
                CheckBox checkBox = new CheckBox
                {
                    Left = 10,
                    Top = topPosition,
                    Text = food
                };
                topPosition += 30;
                Controls.Add(checkBox);

                checkBoxes.Add(checkBox);
            }
        }

        private void CreateSearchTextBoxes()
        {
            int topPosition = 10;

            for (int i = 0; i < 1; i++)
            {
                TextBox searchTextBox = new TextBox
                {
                    Left = 400,
                    Top = topPosition,
                    Width = 150
                };
                topPosition += 30;
                searchTextBox.TextChanged += SearchTextBox_TextChanged;
                Controls.Add(searchTextBox);

                searchTextBoxes.Add(searchTextBox);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                string searchText = textBox.Text.ToLower();
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.Visible = checkBox.Text.ToLower().Contains(searchText);
                }
            }
        }
    }
}

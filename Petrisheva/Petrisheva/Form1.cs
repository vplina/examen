using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit.Sdk;
using Xunit;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Petrisheva
{
    public partial class Form1 : Form
    {

        public class Person
        {
            
            public string Name { get; set; }

            public string LastName { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        

       

    private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("TextBox is Empty");
            }


        }



        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength < 3 || nameTextBox.TextLength > 15) 
            {
                MessageBox.Show("Длина поля Имя должна быть больше 3 символов", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                nameTextBox.Focus();
            }
           

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.TextLength < 2)
            {
                MessageBox.Show("Длина поля Фамилия должна быть больше 2 символов", "Ошибка");
            }
            if (lastNameTextBox.TextLength > 25)
            {
                MessageBox.Show("Длина поля Фамиия не должна превышать 25 символов", "Ошибка");
            }
        }

        private void lastnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            

                if (nameTextBox.Text == string.Empty)
                {
                    MessageBox.Show("TextBox is Empty");
                }


            }
        }
    }


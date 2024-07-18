﻿using college.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace college.forms
{
    public partial class StudentForm : Form
    {
        private DbContext _dbContext;
        private string _Name;

        public StudentForm(DbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string Course = textBoxCourse.Text;
            string Name = textBoxName.Text;
            int StudentID = FindStudentByName(Name);
            int CourseID = FindCoursByName(Course);
            bool Succeeded = InsertCourse(StudentID, CourseID);
            if (Succeeded)
            {
                MessageBox.Show($"Dear {Name}, you have registered is Succeeded!");
            }
            else
            {
                MessageBox.Show("Try agin");
            }
            int Balnce = balancePayable(StudentID);
            labelCurrentBalance.Text = Balnce.ToString();
        }


        private void buttonPay_Click(object sender, EventArgs e)
        {
            int Amunet = Int32.Parse(textBoxAmunet.Text);
            string Name = textBoxName.Text;
            int StudentID = FindStudentByName(Name);
            bool Succeeded = InsertPay(StudentID, Amunet);
            if (Succeeded)
            {
                MessageBox.Show($"Dear {Name}, Your payment of NIS {textBoxAmunet.Text} has been successfully received!");
            }
            else
            {
                MessageBox.Show("Try another name");
            }

            int Balnce = balancePayable(StudentID);
            labelCurrentBalance.Text = Balnce.ToString();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            bool Succeeded = InsertStudent(Name);
            if (Succeeded)
            {
                MessageBox.Show($"Dear {Name}, you have registered as a new student in the system!");
            }
            else
            {
                MessageBox.Show("Try another name");
            }
        }

        public int FindStudentByName (string Name) 
        {
            string query = "select ID from Students where Name =@StudentName";
            SqlParameter[] parameters = { new SqlParameter("@StudentName", Name)};
            int Result = (int) _dbContext.ExecuteScalar(query, parameters);
            return Result;
      
        }
        public int FindCoursByName(string Name)
        {
            string query = "select ID from Courses where Name = @CourseName";
            SqlParameter[] parameters = { new SqlParameter("@CourseName", Name) };
            int Result = (int)_dbContext.ExecuteScalar(query, parameters);
            return Result;
        }
        public bool InsertCourse(int StudentID, int CourseID)
        {
            string query = "INSERT INTO Registrations (StudentID, CourseID) VALUES (@StudentID, @CourseID) ";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", StudentID),
                                          new SqlParameter("@CourseID", CourseID)};
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool InsertStudent(string name)
        {
            string query = "INSERT INTO Students (Name) VALUES (@StudentName)";
            SqlParameter[] parameters = { new SqlParameter("@StudentName", name) };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public bool InsertPay(int StudentID, int amount)
        {
            string query = "INSERT INTO Payments (StudentID, Amount) VALUES (@StudentID, @Amount)";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", StudentID),
                                          new SqlParameter("@Amount", amount)};

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public int TheAmountOfMoneyAlreadyPaid(int StudentID) 
        {
            string query = "select sum(Payments.amount) as 'already paid' from Payments join Students on Students.ID = Payments.StudentID where Students.ID = @StudentID";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", StudentID) };
            int Result = (int)_dbContext.ExecuteScalar(query, parameters);
            return Result;
        }
        public int TheAmountOfDebts(int StudentID)
        {
            string query = "select sum(Courses.price) as 'should pay' from Students join Registrations on Students.ID = Registrations.StudentID join Courses on Courses.ID = Registrations.CourseID where @StudentID = Students.ID";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", StudentID) };
            int Result = (int)_dbContext.ExecuteScalar(query, parameters);
            return Result;
        }

        public int balancePayable(int StudentID)
        {
            int Income = TheAmountOfMoneyAlreadyPaid(StudentID);
            int expenses = TheAmountOfDebts(StudentID);
            return expenses - Income;
        }
    }
}
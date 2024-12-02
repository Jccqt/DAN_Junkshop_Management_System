using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Employees
{
    public class EmployeeCRUD
    {
        private bool nameExist, accExist, detailsComplete;
        private int empIDCount, accIDCount;
        public void DisplayEmployee(int status)
        {
            PageObjects.employee.EmpFLP.Controls.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT EmpID, FirstName, MiddleName, LastName, EmpID, Position, Contact FROM Employees WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                DisplayEmployee displayEmployee = new DisplayEmployee();

                displayEmployee.EditButton.Tag = ConnectionObjects.reader.GetString(0);
                displayEmployee.lblFullName.Text = $"{ConnectionObjects.reader.GetValue(1).ToString()} {ConnectionObjects.reader.GetValue(2).ToString()} {ConnectionObjects.reader.GetValue(3).ToString()}";
                displayEmployee.lblEmployeeID.Text = ConnectionObjects.reader.GetValue(4).ToString();
                displayEmployee.lblPosition.Text = ConnectionObjects.reader.GetValue(5).ToString();
                displayEmployee.lblContact.Text = ConnectionObjects.reader.GetValue(6).ToString();

                PageObjects.employee.EmpFLP.Controls.Add(displayEmployee);

                displayEmployee.EditButton.Click += new EventHandler(PageObjects.employee.ClickEdit);
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            GC.Collect();
        }

        public bool EmployeeExistChecker(EmployeeDetails details)
        {
            nameExist = false;

            ConnectionObjects.conn.Open();
            // will check if the employee name was already existing
            ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, LastName, MiddleName FROM Employees" +
                " WHERE FirstName = @firstname AND LastName = @lastname AND MiddleName = @middlename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", details.FirstName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", details.LastName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", details.MiddleName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                MessageBox.Show("Employee was already existing!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameExist = true;     
            }
            else
            {
                nameExist = false;
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            return nameExist;
        }

        public bool AccExistChecker(EmployeeDetails details)
        {
            ConnectionObjects.conn.Open();

            // will check if the username was already existing
            ConnectionObjects.cmd = new SqlCommand("SELECT Username FROM Credentials WHERE Username = @username", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@username", details.Username);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                MessageBox.Show("Employee username was already existing! Please use another username", "Employee Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                accExist = true;
            }
            else
            {
                accExist = false;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            return accExist;
        }

        public void GetEmpIDCount(EmployeeDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand($"SELECT COUNT(EmpID) FROM Employees WHERE Position = @position ", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@position", details.Position);
            empIDCount = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();
        }

        public void GetAccIDCount()
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(UserID) FROM Credentials", ConnectionObjects.conn);
            accIDCount = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();
        }

        public void AddEmployee(EmployeeDetails details)
        {
            empIDCount += 1000;

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO Employees VALUES (@EmpID, @Position, @FirstName, @LastName, " +
                                        "@MiddleName, @Gender, @Birthdate, @Contact, @Address, @HireDate, @Status)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@EmpID", $"{details.Position.ToUpper()}{empIDCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@Position", details.Position);
            ConnectionObjects.cmd.Parameters.AddWithValue("@FirstName", details.FirstName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@LastName", details.LastName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@MiddleName", details.MiddleName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@Gender", details.Gender);
            ConnectionObjects.cmd.Parameters.AddWithValue("@Birthdate", Convert.ToDateTime(details.Birthdate));
            ConnectionObjects.cmd.Parameters.AddWithValue("@Contact", details.Contact);
            ConnectionObjects.cmd.Parameters.AddWithValue("@Address", details.Address);
            ConnectionObjects.cmd.Parameters.AddWithValue("@HireDate", localDate);
            ConnectionObjects.cmd.Parameters.AddWithValue("@Status", 1);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
        public void AddAccount(EmployeeDetails details)
        {
            accIDCount += 1000;

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO Credentials VALUES (@userid, @username, @password, @empID)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@userid", $"USER{accIDCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@username", details.Username);
            ConnectionObjects.cmd.Parameters.AddWithValue("@password", details.Password);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empID", $"{details.Position.ToUpper()}{empIDCount + 1}");
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
        public void UpdateEmployee(EmployeeDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("UPDATE Employees SET FirstName = @firstname, LastName = @lastname, MiddleName = @middlename, " +
                "Contact = @contact, Birthdate = @birthdate, Gender = @gender, Address = @address WHERE EmpID = @empid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.employee.EmployeeID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", details.FirstName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", details.LastName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", details.MiddleName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@contact", details.Contact);
            ConnectionObjects.cmd.Parameters.AddWithValue("@birthdate", Convert.ToDateTime(details.Birthdate));
            ConnectionObjects.cmd.Parameters.AddWithValue("@gender", details.Gender);
            ConnectionObjects.cmd.Parameters.AddWithValue("@address", details.Address);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
        public void UpdateCredential(EmployeeDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("UPDATE Credentials SET Username = @username, Password = @password WHERE EmpID = @empid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.employee.EmployeeID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@username", details.Username);
            ConnectionObjects.cmd.Parameters.AddWithValue("@password", details.Password);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
        public void GetEmployee(EmployeeDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT E.FirstName, E.LastName, E.MiddleName, E.Gender, E.Birthdate, " +
                "E.Contact, E.Address, E.Status, C.Username, C.Password, E.Position FROM Employees E JOIN Credentials C " +
                "ON E.EmpID = C.EmpID WHERE E.EmpID = @empid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.employee.EmployeeID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                details.FirstName = ConnectionObjects.reader.GetString(0);
                details.LastName = ConnectionObjects.reader.GetString(1);
                details.MiddleName = ConnectionObjects.reader.GetString(2);
                details.Gender = ConnectionObjects.reader.GetString(3);
                details.Birthdate = ConnectionObjects.reader.GetDateTime(4).ToString("yyyy-MM-dd");
                details.Contact = ConnectionObjects.reader.GetString(5);
                details.Address = ConnectionObjects.reader.GetString(6);

                if(ConnectionObjects.reader.GetInt32(7) == 1)
                {
                    details.Status = "Active";
                }
                else
                {
                    details.Status = "Inactive";
                }
                details.Username = ConnectionObjects.reader.GetString(8);
                details.Password = ConnectionObjects.reader.GetString(9);
                details.Position = ConnectionObjects.reader.GetString(10);
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }
        public DateTime GetLegalAge()
        {
            var localDate = DateTime.Now.ToString("yyyy-MM-dd");
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT DATEADD(year, -18, @birthdate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@birthdate", localDate);
            var legalAge = Convert.ToDateTime(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();

            return legalAge;
        }
        public int GetAge(DateTime Birthdate)
        {
            ConnectionObjects.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            // will get the total months of age based on the birth date
            ConnectionObjects.cmd = new SqlCommand("SELECT DATEDIFF(month, @birthDate, @currentDate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@birthDate", Convert.ToDateTime(Birthdate));
            ConnectionObjects.cmd.Parameters.AddWithValue("@currentDate", localDate);
            int yearDifferent = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();
            return yearDifferent /= 12;
        }
        public bool DetailsCompleteChecker(EmployeeDetails details)
        {
            if(details.Position == "" || details.FirstName == "" || details.LastName == "" || details.MiddleName == "" || 
                details.Gender == "" || details.Contact == "" || details.Address == "" || details.Username == "" || details.Password == "")
            {
                MessageBox.Show("Employee details was incomplete!" +
                    "\nPlease complete the employee details to save", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                detailsComplete = false;
            }
            else
            {
                detailsComplete = true;
            }
            return detailsComplete;
        }
    }
}

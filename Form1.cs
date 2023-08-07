using DemoWinformDAO.DAO;
using DemoWinformDAO.Models;

namespace DemoWinformDAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            //lấy list employee từ database

            List<Employee> employees = EmployeeDAO.getListEmployee();

            //gán dữ liệu cho datagridview
            dgvEmployee.DataSource = employees;
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            loadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = tbFirstName.Text;
            emp.LastName = tbLastName.Text;
            emp.Title = tbTitle.Text;
            //lấy giá trị selectd của combobox qua thuộc tính selecteditems
            emp.TitleOfCourtesy = cbTitleOfCourtesy.SelectedItem.ToString();
            //lấy date từ datetimepicker thông qua thuộc tính value
            emp.BirthDate = dtpBirthDate.Value;


            int k = EmployeeDAO.insertEmployee(emp);
            if (k > 0)
            {
                loadData();


                MessageBox.Show("inset successful");

            }
            else
            {
                MessageBox.Show("inset failed");
            }
        }

    }

}

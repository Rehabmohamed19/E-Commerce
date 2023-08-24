using Data.Dto;
using Service;

namespace LoginAndRegistration
{
    public partial class Form1 : Form
    {
        private readonly AdminService _userService;
        public Form1(AdminService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDto userDto = new AdminDto()
            {
                Email = emailBox.Text,
                FullName = nameBox.Text,
                Password = passwordBox.Text,
            };
            _userService.AddUser(userDto);
        }
    }
}
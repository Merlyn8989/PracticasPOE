using BusinessLayer.Services;

namespace PresentationLayer.Forms
{
    public partial class CareerForm : Form
    {
        private CareerService _careerService;
        public CareerForm()
        {
            _careerService = new CareerService();
            InitializeComponent();
            LoadCareerData();
        }

        private void LoadCareerData()
        {
            dtvCareers.DataSource = _careerService.GetAllCareers();
        }
    }
}

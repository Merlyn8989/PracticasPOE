using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class CareerForm : Form
    {
        private CareerService _careerService;
        private bool isEditing = false;
        public CareerForm()
        {
            _careerService = new CareerService();
            InitializeComponent();
            LoadCareerData();
        }

        private void LoadCareerData()
        {
            dgvCareers.DataSource = _careerService.GetAllCareers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Career career = new Career();
                career.nameCareer = txtNameCareer.Text;
                career.descriptionCareer = txtDescriptionCareer.Text;
                career.idCareer = int.Parse(dgvCareers.CurrentRow.Cells[0].Value.ToString());

                _careerService.UpdateCareer(career);
                LoadCareerData();
                cleanParameters();


                isEditing = false;


            }
            else
            {
                Career career = new Career();
                career.nameCareer = txtNameCareer.Text;
                career.descriptionCareer = txtDescriptionCareer.Text;
                
                _careerService.AddCareer(career);
                LoadCareerData();
                cleanParameters();
            }
        }

        public void cleanParameters()
        {
            txtNameCareer.Clear();
            txtDescriptionCareer.Clear();
            txtNameCareer.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCareers.SelectedRows.Count > 0)
            {
                txtNameCareer.Text = dgvCareers.CurrentRow.Cells[1].Value.ToString();
                txtDescriptionCareer.Text = dgvCareers.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila antes de Editar");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCareers.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var deleteConfim = new DialogResult();
                deleteConfim = MessageBox.Show("¿Desea borrar el registro", "Confim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(deleteConfim == DialogResult.Yes)
                {
                    int id = int.Parse(dgvCareers.CurrentRow.Cells[0].Value.ToString());
                    _careerService.DeleteCareer(id);
                    LoadCareerData();
                    cleanParameters();
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Trabajo_final_herramientas_II
{
    public partial class AdminMenu : Form
    {
        // Instancias persistentes de los formularios
        private RegistroClientes registroForm;
        private AdminClases adminClasesForm;
        private RegistroInstructor registroInstructorForm;
        private ReportesYEstadisticas reportesForm;
        private CambioRol cambioRolForm;
        private CreateAccount createAccountForm;

        public AdminMenu()
        {
            InitializeComponent();

            // Crear instancias pasando "this" para poder volver
            registroForm = new RegistroClientes(this);
            adminClasesForm = new AdminClases(this);
            registroInstructorForm = new RegistroInstructor(this);
            reportesForm = new ReportesYEstadisticas(this);
            cambioRolForm = new CambioRol(this);
            createAccountForm = new CreateAccount(this);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            adminClasesForm.Show();
        }

        private void llbGCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registroForm.Show();
        }

        private void llbGInstructores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registroInstructorForm.Show();
        }

        private void llbRepEstadis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reportesForm.Show();
        }

        private void llbCambRol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cambioRolForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            createAccountForm.Show();
        }
    }

   

    // Constructores actualizados para recibir AdminMenu como parámetro

    public partial class AdminClases : Form
    {
        private AdminMenu adminMenuRef;
        public AdminClases(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

    public partial class RegistroClientes : Form
    {
        private AdminMenu adminMenuRef;
        public RegistroClientes(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

    public partial class RegistroInstructor : Form
    {
        private AdminMenu adminMenuRef;
        public RegistroInstructor(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

    public partial class ReportesYEstadisticas : Form
    {
        private AdminMenu adminMenuRef;
        public ReportesYEstadisticas(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

    public partial class CambioRol : Form
    {
        private AdminMenu adminMenuRef;
        public CambioRol(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

    public partial class CreateAccount : Form
    {
        private AdminMenu adminMenuRef;
        public CreateAccount(AdminMenu menu)
        {
            InitializeComponent();
            adminMenuRef = menu;
        }
    }

   

  }
using Datos;
using Entidad;

namespace Test3

{
    public partial class Form1 : Form
    {


        private Datos_Docentes datos = new Datos_Docentes();
        private Lista_Docentes lista_docentes;
        public Form1()
        {
            InitializeComponent();
        }



        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }







        private void cargar_docentes()
        {
            dataGridDocentes.Rows.Clear();

            lista_docentes = datos.leer_docentes();

            if (datos.leer_docentes() == null)
            {

                return;
            }
            foreach (Docente docente in lista_docentes.coleccion_docentes())
            {
                dataGridDocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            }

        }
        private void guardar_docente()
        {
            string linea;
            linea = textBoxIddoc.Text + ";" + textBoxnomdoc.Text + ";" + textBoxTeldoc.Text;

            if (datos.GuardarDocente(linea) == true)
            {
                MessageBox.Show("Se guardo el docente correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el docente");
            }


        }



        private void bttondocen_Click(object sender, EventArgs e)
        {

        }

        private void btnaggdocen_Click(object sender, EventArgs e)
        {


        }

        private void butguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmenudocentes_Click(object sender, EventArgs e)
        {
            panelsubmenudoc.Visible = true;
        }

        private void Btnaggdocente_Click(object sender, EventArgs e)
        {
            GPsavedocente.Visible = true;
            panelsubmenudoc.Visible = false;
        }

        private void butonsave_Click(object sender, EventArgs e)
        {
            guardar_docente();
        }

        private void BtnVerdocentes_Click(object sender, EventArgs e)
        {
            GPverdocentes.Visible = true;
            panelsubmenudoc.Visible = false;
        }

        private void btnberdocentes_Click(object sender, EventArgs e)
        {
            cargar_docentes();
        }

        private void dataGridDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dataGridDocentes.CurrentRow.Index;
            textBoxIddoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textBoxnomdoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textBoxTeldoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }


        private void actualizar_docente()
        {
            lista_docentes = datos.leer_docentes();
            Docente docente = new Docente();
            docente.Id = textboxmodidocente.Text;
            docente.Nombre = textboxmodinombredoce.Text;
            docente.Telefono = textboxmoditeldoce.Text;
            lista_docentes.actualizar_docente(docente);

            string linea;

            foreach (Docente doc in lista_docentes.coleccion_docentes())
            {
                linea = doc.Id + ";" + doc.Nombre + ";" + doc.Telefono;
                datos.GuardarDocente(linea);
            }


        }

        private void btnmodificardoce_Click(object sender, EventArgs e)
        {
            actualizar_docente();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

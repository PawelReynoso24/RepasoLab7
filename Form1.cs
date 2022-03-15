using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoLab7
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Resumen> resumen = new List<Resumen>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarPropietarios(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.DPI = reader.ReadLine();
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarios.Add(propietario);
            }
            reader.Close();
        }
        private void CargarPropiedades(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.NumCasa = Convert.ToInt16(reader.ReadLine());
                propiedad.DPI_dueño = reader.ReadLine();
                propiedad.Cuota = Convert.ToInt16(reader.ReadLine());
                propiedades.Add(propiedad);
            }
            reader.Close();
        }
        private void CargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = resumen;
            dataGridView1.Refresh();
        }
        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            buttonOrdenarDatos.Enabled = true;
            CargarPropiedades("Propiedades.txt");
            CargarPropietarios("Propietarios.txt");

            for(int i = 0; i < propiedades.Count; i++)
            {
                Resumen datoTemp = new Resumen();

                for(int j = 0; j < propietarios.Count; j++)
                {
                    if(propiedades[i].DPI_dueño == propietarios[j].DPI)
                    {
                        datoTemp.Nombre = propietarios[j].Nombre;
                        datoTemp.Apellido = propietarios[j].Apellido;
                        datoTemp.NumCasa = propiedades[i].NumCasa;
                        datoTemp.Cuota = propiedades[i].Cuota;
                        resumen.Add(datoTemp);
                    }
                }
            }
            CargarGrid();
        }

        private void buttonOrdenarDatos_Click(object sender, EventArgs e)
        {
            buttonMayorMenor.Enabled = true;
            resumen = resumen.OrderBy(c => c.Cuota).ToList();
            CargarGrid();
        }

        private void buttonMayorMenor_Click(object sender, EventArgs e)
        {
            labelMenor1.Text = resumen[0].Cuota.ToString();
            labelMenor2.Text = resumen[1].Cuota.ToString();
            labelMenor3.Text = resumen[2].Cuota.ToString();

            int ultimo = resumen.Count();
            labelPropietario.Text = resumen[ultimo - 1].Apellido.ToString() + ", " + resumen[ultimo - 1].Nombre.ToString();
            labelMayor1.Text = resumen[ultimo -1].Cuota.ToString();
            labelMayor2.Text = resumen[ultimo -2].Cuota.ToString();
            labelMayor3.Text = resumen[ultimo -3].Cuota.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

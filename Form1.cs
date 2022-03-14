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

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
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
        }
    }
}

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

namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        List<GolAnotado> golesanotados = new List<GolAnotado>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GolAnotado goles = new GolAnotado();
            goles.Identificacion_de_jugador = Convert.ToInt32(textBoxIdentificacion.Text);
            goles.Fechadejuego = dateTimePickerFecha.Value;
            goles.Nombredeequipo = textBoxNombredeequipo.Text;
            goles.Numerodegoles = Convert.ToInt32(textBoxNombredeequipo.Text);

            golesanotados.Add(goles);

            Almacenar_datos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Goles.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                GolAnotado goles = new GolAnotado();
                goles.Identificacion_de_jugador = Convert.ToInt32(textBoxIdentificacion.Text);
                goles.Fechadejuego = Convert.ToDateTime(dateTimePickerFecha.Value);
                goles.Nombredeequipo = reader.ReadLine();
                goles.Numerodegoles = Convert.ToInt32(textBoxGolesanotados.Text);

                golesanotados.Add(goles);

            }
            reader.Close();
        }

        private void Almacenar_datos()
        {
            FileStream stream = new FileStream(@"..\..\Goles.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var goles in golesanotados)
            {
                writer.WriteLine(goles.Identificacion_de_jugador);
                writer.WriteLine(goles.Fechadejuego);
                writer.WriteLine(goles.Nombredeequipo);
                writer.WriteLine(goles.Numerodegoles);
            }

            writer.Close();
        }
    }
}

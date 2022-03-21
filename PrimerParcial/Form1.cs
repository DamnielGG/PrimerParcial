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
        List<Jugador> jugadores = new List<Jugador>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Goles.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Jugador jugador = new Jugador();
                jugador.Identificacion = Convert.ToInt32(textBoxIdentificacion.Text);
                jugador.Nombre = textBoxNombredeequipo.Text;
                jugador.Equipo = textBoxGolesanotados.Text;

                jugadores.Add(jugador);

            }
            reader.Close();
        }

        private void Almacenar_datos()
        {
            FileStream stream = new FileStream(@"..\..\Goles.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var jugador in jugadores)
            {
                writer.WriteLine(jugadores.);
                writer.WriteLine(jugadores.Nombre);
                writer.WriteLine(jugador.Modelo);
            }
            //Cerrar el archivo
            writer.Close();
        }
    }
}

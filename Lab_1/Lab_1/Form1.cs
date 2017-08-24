using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {

        Dictionary<string, Cancion> Musica = new Dictionary<string, Cancion>();
        Cancion CancionPorAgregar = null;
        Cancion CancionPorBuscar = null;
        string LlaveABuscar = "";

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (Musica.ContainsKey(txtNombre.Text.ToLower()) == false)
            {
                CancionPorAgregar = new Cancion(txtNombre.Text.ToLower(), txtTiempo.Text.ToLower());
                Musica.Add(CancionPorAgregar.Nombre, CancionPorAgregar);
                txtNombre.Clear();
                txtTiempo.Clear();
            }
            else
            {
                MessageBox.Show("La Cancion ya fue agregadada anteriomente");
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlaveABuscar = txtBuscar.Text;
            try
            {
                CancionPorBuscar = Musica[LlaveABuscar];
                lblResultado.Text = (string.Format("La Cancion que busco es : '{0}', con tiempo de : '{1}'", LlaveABuscar, CancionPorBuscar.Tiempo));
                txtBuscar.Clear();
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

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

        List<Cancion> PlayList = new List<Cancion>();
        List<Cancion> Tiempo = new List<Cancion>();


        bool play = false;
        string[] ArchivosMP3;
        string[] RutasArchivosMp3; 
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Musica.ContainsKey(txtNombre.Text) == false)
            {
                CancionPorAgregar = new Cancion(txtNombre.Text, txtTiempo.Text, txtArtista.Text);
                Musica.Add(CancionPorAgregar.Nombre, CancionPorAgregar);
                txtNombre.Clear();
                txtTiempo.Clear();
                txtArtista.Clear();

                CHLSTcanciones.Items.Insert(i, CancionPorAgregar.Nombre);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            for (int i = 0; i < CHLSTcanciones.Items.Count; i++)
            {
                if (CHLSTcanciones.GetItemChecked(i))
                {
                    CancionPorBuscar = Musica[CHLSTcanciones.Items[i].ToString()];
                    PlayList.Add(CancionPorBuscar);
                }
            }

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PlayList.Count; i++)
            {
                lstMusica.Items.Insert(i, PlayList[i].Nombre+ ", " + PlayList[i].Tiempo);
               
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (chknombre.Checked)
            {
                PlayList.Sort((q, p) => string.Compare(p.Nombre, q.Nombre));
                lstMusica.Items.Clear();
                for (int i = 0; i < PlayList.Count; i++)
                {
                    lstMusica.Items.Insert(i, PlayList[i].Nombre + ", " + PlayList[i].Tiempo);

                }
            }
            else
            {
                PlayList.Sort((p, q) => string.Compare(p.Nombre, q.Nombre));
                lstMusica.Items.Clear();
                for (int i = 0; i < PlayList.Count; i++)
                {
                    lstMusica.Items.Insert(i, PlayList[i].Nombre + ", " + PlayList[i].Tiempo);
            
                }
            }
        }

        private void btnduracion_Click(object sender, EventArgs e)
        {
            if (chkduracion.Checked)
            {
                PlayList.Sort((q, p) => string.Compare(p.Tiempo, q.Tiempo));
                lstMusica.Items.Clear();
                for (int i = 0; i < PlayList.Count; i++)
                {
                    lstMusica.Items.Insert(i, PlayList[i].Nombre + ", " + PlayList[i].Tiempo);

                }
            }
            else
            {
                PlayList.Sort((p, q) => string.Compare(p.Tiempo, q.Tiempo));
                lstMusica.Items.Clear();
                for (int i = 0; i < PlayList.Count; i++)
                {
                    lstMusica.Items.Insert(i, PlayList[i].Nombre + ", " + PlayList[i].Tiempo);

                }
            }

        }

        private void BtnReproducir_Click(object sender, EventArgs e)
        {

        }

        private void btnadjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajadeBusqueda = new OpenFileDialog();
            CajadeBusqueda.Multiselect = true;
            if (CajadeBusqueda.ShowDialog()== DialogResult.OK)
            {
                ArchivosMP3 = CajadeBusqueda.SafeFileNames;
                RutasArchivosMp3 = CajadeBusqueda.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    lstReproductor.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = RutasArchivosMp3[0];
                lstReproductor.SelectedIndex = 0;

            }
        }

        private void lstReproductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = RutasArchivosMp3[lstReproductor.SelectedIndex];
        }
    }
}

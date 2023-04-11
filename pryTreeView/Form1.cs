using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Declaramos los nodos
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;
            //Declaramos nodo raiz del tv
            //Texto nombre alumno
            //Clave del nodo es para buscar por ejemplo dni alumno
            //
            abuelo = tv.Nodes.Add("Alimentos", "Alimentos", 0, 3);
            //Declaramos el hijo de abuelo del tv
            padre = abuelo.Nodes.Add("Frutas", "Frutas", 1, 3);
            //Para agregar hijos al padre tiene que escribirse el codigo debajo
            hijo = padre.Nodes.Add("Uva", "Uva", 2, 3);
            hijo.Tag = "300";
            hijo = padre.Nodes.Add("Pera","Pera", 2, 3);
            hijo.Tag = "350";
            hijo = padre.Nodes.Add("Naranja", "Pera", 2, 3);
            hijo.Tag = "400";
            padre = abuelo.Nodes.Add("Verduras", "Verduras", 1, 3);
            hijo = padre.Nodes.Add("Acelga", "Acelga", 2, 3);
            hijo.Tag = "300";
            hijo = padre.Nodes.Add("Lechuga", "Acelga", 2, 3);
            hijo.Tag = "320";
            hijo = padre.Nodes.Add("Repollo", "Acelga", 2, 3);
            hijo.Tag = "320";

        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                MessageBox.Show("EL KILO VALE $ " + e.Node.Tag.ToString());
            }
        }
    }
}

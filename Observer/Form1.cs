using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        DataProductsEntities bd = new DataProductsEntities();
        int luno;
        int ldos;
        public Form1()
        {
            InitializeComponent();
            string connetionString = "Data Source=microservicessttk.database.windows.net;Initial Catalog=DataProducts;User ID=adminSttk;Password=@Softtek01";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            //SqlDependency.Stop(connetionString);
            //SqlDependency.Start(connetionString);           


            //SomeMethod(cnn);

            luno = bd.CatProviders.Count();
        }

        private void Ag_Click(object sender, EventArgs e)
        {
            var cat = new CatProviders() {Name = "tienda por millllll1",Description = "desc" };
            bd.CatProviders.Add(cat);
        }

        private void Elim_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private static void DisplayStates(IEnumerable<DbEntityEntry> entries, TextBox t)
        {
            foreach (var entry in entries)
            {
                t.Text = $"Entity: {entry.Entity.GetType().Name}, State: {entry.State}";
            }
            if (entries.Count() == 0)
            {
                t.Text = "no cambio nada";
            }
        }

        private void checa_Click(object sender, EventArgs e)
        {

            ldos = new DataProductsEntities().CatProviders.Count();
            //if (luno != ldos)
            //{
            //    textBox1.Text = "algo paso en la tabla" + luno + ldos;
            //}
            DisplayStates(bd.ChangeTracker.Entries(), textBox1);
            bd.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void conect_Click(object sender, EventArgs e)
        {
            //string connetionString = null;
            //SqlConnection cnn;
            //connetionString = "Data Source=microservicessttk.database.windows.net;Initial Catalog=DataProducts;User ID=adminSttk;Password=@Softtek01";
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    MessageBox.Show("Connection Open ! ");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! ");
            //}
        }
    }
}


using SerachAppForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerachAppForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using(SaleEntities db = new SaleEntities())
            {
                fillData(db.Products.ToList());
            }
            cmbName.Items.Add("Name");
            cmbName.Items.Add("Price");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            using (SaleEntities db =new SaleEntities())
            {
                if (txtWord.Text == "" && txtWord.Visible && txtMax.Text==""&&txtMin.Text=="") {
                    fillData(db.Products.ToList());
                    return;
                 }
                List<Product> products = new List<Product>();
                if (cmbName.Text == "Name")
                {
                    products = db.Products.Where(p => p.Name.Contains(txtWord.Text)).ToList();
                    fillData(products);
                }
                 else 
                {
                    decimal.TryParse(txtMin.Text, out decimal min);
                    decimal.TryParse(txtMax.Text, out decimal max);

                    if (txtMin.Text != "" && txtMax.Text != "")
                    {
                        products = db.Products.Where(p => p.Price < max && p.Price > min).ToList();
                    }
                    else
                    {
                        products = db.Products.Where(p => p.Price < max || p.Price > min).ToList();
                    }


                    fillData(products);
                }
            }
        }



        void fillData (List<Product> list)
        {
            this.dgvData.DataSource = list.Select( s=> new { s.Name, s.Price }).ToList();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex == 1)
            {
                grpPrice.Visible = true;
                txtWord.Visible = false;
            }
            else
            {
                grpPrice.Visible = false;
                txtWord.Visible = true;
            }
        } 
    }
}

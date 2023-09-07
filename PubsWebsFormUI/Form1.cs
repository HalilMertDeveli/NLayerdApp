using PubsBusiness.Abstract;
using PubsBusiness.Concrete;
using PubsDataAccess.Concrete;
using PubsDataAccess.Concrete.Hibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsWebsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IProductService _productService;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new NhProductDal());
            dgwProduct.DataSource= productManager.GetAll();
        }
    }
}

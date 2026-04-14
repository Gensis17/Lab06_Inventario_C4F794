using Inventario.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario.UI
{
    public partial class FormInventario : Form
    {
        public GestorInventario gestorInventario = new GestorInventario();
        public FormInventario()
        {
            InitializeComponent();

            lvProductos.View = View.Details;

            lvProductos.Columns.Add("Id", 150);
            lvProductos.Columns.Add("Nombre", 80);
            lvProductos.Columns.Add("Categoria", 80);
            lvProductos.Columns.Add("Precio", 120);
            lvProductos.Columns.Add("Stock", 120);


            this.cargarProductos();

        }

        private void cargarProductos()
        {
            lvProductos.Items.Clear();

            foreach (var producto in gestorInventario.ObtenerProductos())
            {
                ListViewItem item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                lvProductos.Items.Add(item);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();

            List<MODEL.Producto> listaProductos = [];

            if (cbCategoria.SelectedItem.ToString() == "Todos")
            {
                listaProductos = gestorInventario.ObtenerProductos();
            }
            else
            {
                listaProductos = gestorInventario.BuscarProductosPorCategoria(cbCategoria.SelectedItem.ToString());
            }


            foreach (var producto in listaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                lvProductos.Items.Add(item);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();

            string busqueda = textBox1.Text;


            foreach (var producto in gestorInventario.BuscarProductosPorNombre(busqueda))
            {
                ListViewItem item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                lvProductos.Items.Add(item);
            }
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {

            lvProductos.SelectedItems.Cast<ListViewItem>().ToList().ForEach(item =>
            {
                int idProducto = int.Parse(item.SubItems[1].Text);
                gestorInventario.EliminarProducto(idProducto);
                lvProductos.Items.Remove(item);
            });
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            MODEL.Producto nuevoProducto = new MODEL.Producto
            {
                Id = gestorInventario.ObtenerProductos().Count() + 1,
                Nombre = txtNombre.Text,
                Categoria = cbNuevaCategoria.SelectedItem.ToString(),
                Precio = double.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };

            gestorInventario.AgregarProducto(nuevoProducto);

            this.cargarProductos();

            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cbNuevaCategoria.SelectedItem = null;


        }
    }
}

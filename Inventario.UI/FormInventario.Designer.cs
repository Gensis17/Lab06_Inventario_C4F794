namespace Inventario.UI
{
    partial class FormInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvProductos = new ListView();
            textBox1 = new TextBox();
            lbBuscarPorNombreOCategoria = new Label();
            cbCategoria = new ComboBox();
            lbCategoria = new Label();
            btnEliminarSeleccionado = new Button();
            groupBox1 = new GroupBox();
            txtStock = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            cbNuevaCategoria = new ComboBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lbNombre = new Label();
            btnGuardarProducto = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProductos
            // 
            lvProductos.Location = new Point(32, 94);
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(374, 97);
            lvProductos.TabIndex = 0;
            lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbBuscarPorNombreOCategoria
            // 
            lbBuscarPorNombreOCategoria.AutoSize = true;
            lbBuscarPorNombreOCategoria.Location = new Point(32, 47);
            lbBuscarPorNombreOCategoria.Name = "lbBuscarPorNombreOCategoria";
            lbBuscarPorNombreOCategoria.Size = new Size(174, 15);
            lbBuscarPorNombreOCategoria.TabIndex = 2;
            lbBuscarPorNombreOCategoria.Text = "Buscar por Nombre o Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Todos", "Papelería", "Tecnología", "Mobiliario", "Otro" });
            cbCategoria.Location = new Point(285, 65);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 3;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(285, 47);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(110, 15);
            lbCategoria.TabIndex = 4;
            lbCategoria.Text = "Filtrar por categoría";
            // 
            // btnEliminarSeleccionado
            // 
            btnEliminarSeleccionado.Location = new Point(32, 197);
            btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            btnEliminarSeleccionado.Size = new Size(75, 23);
            btnEliminarSeleccionado.TabIndex = 5;
            btnEliminarSeleccionado.Text = "Eliminar Seleccionado";
            btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            btnEliminarSeleccionado.Click += btnEliminarSeleccionado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarProducto);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(cbNuevaCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lbNombre);
            groupBox1.Location = new Point(483, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 301);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 228);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(171, 23);
            txtStock.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Categoría";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 170);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(171, 23);
            txtPrecio.TabIndex = 3;
            // 
            // cbNuevaCategoria
            // 
            cbNuevaCategoria.FormattingEnabled = true;
            cbNuevaCategoria.Items.AddRange(new object[] { "Papelería", "Tecnología", "Mobiliario", "Otro" });
            cbNuevaCategoria.Location = new Point(12, 113);
            cbNuevaCategoria.Name = "cbNuevaCategoria";
            cbNuevaCategoria.Size = new Size(171, 23);
            cbNuevaCategoria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 152);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 23);
            txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(12, 32);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(12, 272);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(75, 23);
            btnGuardarProducto.TabIndex = 11;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnEliminarSeleccionado);
            Controls.Add(lbCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(lbBuscarPorNombreOCategoria);
            Controls.Add(textBox1);
            Controls.Add(lvProductos);
            Name = "FormInventario";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProductos;
        private TextBox textBox1;
        private Label lbBuscarPorNombreOCategoria;
        private ComboBox cbCategoria;
        private Label lbCategoria;
        private Button btnEliminarSeleccionado;
        private GroupBox groupBox1;
        private TextBox txtStock;
        private Label label3;
        private Label label2;
        private TextBox txtPrecio;
        private ComboBox cbNuevaCategoria;
        private Label label1;
        private TextBox txtNombre;
        private Label lbNombre;
        private Button btnGuardarProducto;
    }
}

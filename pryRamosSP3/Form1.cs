namespace pryRamosSP3
{
    public partial class Repuestos : Form
    {
        //declaracion de valores globales
        //array de 1 dimension - vector - sin elementos
        string[] vecRegistros;

        //array de 2 dimensiones - matriz - sin elementos
        string[] matRegistros;

        //array de 1 dimension - vector
        string[] vecRepuestos = new string[3];

        //array de 2 dimensiones - matriz
        string[,] matRepuestos = new string[2, 2];

        
        public Repuestos()
        {
            InitializeComponent();
        }
        string Marca;
        string Origen;
        string Descripcion;
        int Numero;
        int Precio;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string varMarca = cmbMarca.Text;
            string varOrigen;

            varOrigen = (rbNacional.Checked == true) ? "Nacional" : "Importado";

       

            lstRepuestos.Items.Add(varMarca + ' ' + varOrigen);

            //grabar en el vector . array de 1 dimension
            vecRepuestos[0] = "primerdato";
            vecRepuestos[1] = "segundodato";
            vecRepuestos[2] = "tercerdato";
        }
    }
}

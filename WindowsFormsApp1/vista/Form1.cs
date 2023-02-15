using DocumentFormat.OpenXml.Drawing.Charts;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.vista;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Controls;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form, Iform1
    {
        public string dir = @"C:\\Users\\Usuario\\Desktop\\SUPER CARPETA\\AGUA_backup.xlsx";



        public Form1()
        {

            InitializeComponent();

          

            EventosAsociadosVista();
            
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);


        }

        
        

        //eventos
        public event EventHandler EventoBuscar;
        public event EventHandler EventoSelecionarUsuario;

        private void EventosAsociadosVista()
        {
            button1.Click += delegate { EventoBuscar?.Invoke(this, EventArgs.Empty); };

            button2.Click += delegate { 


                tabControl1.TabPages.Remove(tabPage1);

                if (tabControl1.TabPages.Count == 0)
                {
                    tabControl1.TabPages.Add(tabPage2);
                }

                EventoSelecionarUsuario?.Invoke(this, EventArgs.Empty);
                

            };   
                                                    
            
        }


        


        public string UsuarioNombre 
        { 
            get => txtBuscar.Text; 
            set => txtBuscar.Text = value;  
        }
        public string Usuarioid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UsuarioEdad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UsuarioDiscapacidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BuscarUsuario { get => txtBuscar.Text; set => txtBuscar.Text = value; }
        public int PagoUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdObetnidoDataGrid { get => dataGridView1.CurrentRow.Cells[0].Value.ToString(); set => IdObetnidoDataGrid = dataGridView1.CurrentRow.Cells[0].Value.ToString(); }


        public void EstablecerListaDatagrid(BindingSource lista)
        {
            dataGridView1.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            tabControl1.TabPages.Remove(tabPage2);
            if (tabControl1.TabPages.Count == 0)
            {
                tabControl1.TabPages.Add(tabPage1);
            }
        }

        // funciones de combinacion de celdas
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dataGridView2[column, row];
            DataGridViewCell cell2 = dataGridView2[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dataGridView2.AdvancedCellBorderStyle.Top;
            }


        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
        ///
        public void EstablecerListaLecturaDatagrid(BindingSource lista)
        {
            
            dataGridView2.DataSource = lista;
            
            List<string> mes = new List<string>()
            {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio"
            };

            for (int i = 0; i < 1; i++)
            {
                
                dataGridView2.Rows[i].Cells[0].Value = mes[i];
                dataGridView2.Rows[i+1].Cells[0].Value = mes[i];
            }
            
            
            

            
        }

    }

     



        //    SLDocument sl = new SLDocument(dir, "LISTADO MARISCAL SUCRE");
        //    List<ModeloUsuarios> listUser = new List<ModeloUsuarios>();

        //    int num = 5;

        //    while (num != 80)
        //    {
        //        ModeloUsuarios md = new ModeloUsuarios();
        //        md.No = sl.GetCellValueAsString(num, 1);
        //        md.Nombre = sl.GetCellValueAsString(num, 2);
        //        md.Lectura = sl.GetCellValueAsString(num, 3);
        //        md.Consumo = sl.GetCellValueAsString(num, 4);
        //        md.Exceso = sl.GetCellValueAsString(num, 5);
        //        listUser.Add(md);
        //        num++;      
        //    }




        //    dataGridView1.DataSource = listUser;


        //}


    
}

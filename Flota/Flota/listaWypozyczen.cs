using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Flota
{
    public partial class listaWypozyczen : Form
    {
        MySqlConnection connect = null;
        String login;
        MySqlDataAdapter pojazd;
        
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DataTable tbpoj = new DataTable();
        public listaWypozyczen()
        {
            InitializeComponent();
        }

        private void listaWypozyczen_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia wy = new Wypozyczenia();
            wy.user(login);
            wy.Show();
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT poj.nr_rejestracyjny AS 'Numer rejestracyjny', prac.login AS 'Nazwa użytkownika', w.data_od AS 'Data od', w.data_do AS 'Data do', w.powod AS 'Powód' FROM pojazd AS poj JOIN wypozyczenia AS w ON poj.id_pojazdu = w.id_pojazdu JOIN pracownik AS prac ON w.id_pracownika = prac.id_pracownika WHERE((data_od >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_od <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_do >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_od <= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do >= '" + dataDo.Value.ToString("yyyy-MM-dd") + "')); ";
            MySqlDataAdapter aWyp = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbWyp = new DataTable();
            aWyp.Fill(tbWyp);
            listaWyp.DataSource = tbWyp;
        }

        private void helpListWyp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listaWyp.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "ListaWypozyczen.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }

                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Błąd:" + ex.Message);
                        }
                    }
                }
                if (!ErrorMessage)
                {

                    try
                    {
                        PdfPTable pTable = new PdfPTable(listaWyp.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn col in listaWyp.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                            pTable.AddCell(pCell);

                        }

                        foreach (DataGridViewRow viewRow in listaWyp.Rows)
                        {
                            foreach (DataGridViewCell dcell in viewRow.Cells)
                            {
                                if (dcell.Value != null)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                                else
                                {
                                    string empty = " ";
                                    pTable.AddCell(empty);
                                }
                            }
                        }

                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            document.Add(pTable);
                            document.Close();
                            fileStream.Close();


                        }
                        MessageBox.Show("Zapisano plik", "info");




                    }










                    catch (Exception ex)
                    {

                        MessageBox.Show("Nie można zapisać" + ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Brak wartości tabeli", "info");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace Flota
{
    public partial class historiaSerwis : Form
    {
        String login;
        public historiaSerwis()
        {
            InitializeComponent();
        }

        private void historiaSerwis_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Serwis sr = new Serwis();
            sr.user(login);
            sr.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT poj.nr_rejestracyjny AS 'Numer rejestracyjny', s.data_ostatniego_przegladu AS 'Data ostatniego przeglądu', s.nazwa_serwisu AS 'Nazwa serwisu', u.nazwa_uslugi AS 'Usługa', s.koszt AS 'Koszt usługi' FROM pojazd AS poj JOIN serwis AS s ON poj.id_pojazdu = s.id_pojazdu JOIN usluga AS u ON s.id_uslugi = u.id_uslugi WHERE s.data_ostatniego_przegladu >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND s.data_ostatniego_przegladu <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "'; ";
            MySqlDataAdapter aSerw = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbSerw = new DataTable();
            aSerw.Fill(tbSerw);
            listaSerwis.DataSource = tbSerw;
        }

        private void helpHisSer_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if (listaSerwis.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Serwis.pdf";
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
                        PdfPTable pTable = new PdfPTable(listaSerwis.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn col in listaSerwis.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                            pTable.AddCell(pCell);

                        }

                        foreach (DataGridViewRow viewRow in listaSerwis.Rows)
                        {
                            foreach (DataGridViewCell dcell in viewRow.Cells)
                            {
                                if(dcell.Value!=null)
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

        private void listaSerwis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

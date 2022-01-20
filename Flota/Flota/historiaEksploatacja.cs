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
    public partial class historiaEksploatacja : Form
    {
        String login;
        public historiaEksploatacja()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eksploatacja us = new Eksploatacja();
            us.user(login);
            us.Show();
        }

        private void historiaEksploatacja_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void listaEksplo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT prac.login AS 'Nazwa użytkownika', poj.nr_rejestracyjny AS 'Numer rejestracyjny', e.nazwa_czynnsci AS 'Czynność eksploatacyjna', e.data_wykonania AS 'Data wykonania', e.koszt AS 'Koszt eksploatacji' FROM pojazd AS poj  JOIN eksploatacja AS e ON poj.id_pojazdu = e.id_pojazdu  JOIN pracownik AS prac ON e.id_pracownika = prac.id_pracownika WHERE e.data_wykonania >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND e.data_wykonania <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "';";
            MySqlDataAdapter aEksplo = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbEksplo = new DataTable();
            aEksplo.Fill(tbEksplo);
            listaEksplo.DataSource = tbEksplo;
        }

        private void helpmenu_Click(object sender, EventArgs e)
        {

        }

        private void helpHisEks_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listaEksplo.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Eksploatacja.pdf";
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
                        PdfPTable pTable = new PdfPTable(listaEksplo.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn col in listaEksplo.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                            pTable.AddCell(pCell);

                        }

                        foreach (DataGridViewRow viewRow in listaEksplo.Rows)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Reflection;


namespace CRMagazine
{
    public partial class frmAjusteGeraCheckList : Form
    {
        public frmAjusteGeraCheckList(string OS)
        {
            InitializeComponent();
            txtChamado.Text = OS;
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        System.Drawing.Font fonteta;

        Conexao cx = new Conexao();
        Consulta consulta = new Consulta();

        public void LoadFont()
        {
            /*
            byte[] fontArray = CRMagazine.Properties.Resources.IDAutomationHC39M_Code_39_Barcode;
            int dataLength = CRMagazine.Properties.Resources.IDAutomationHC39M_Code_39_Barcode.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            fonteta = new System.Drawing.Font(ff, 15f, FontStyle.Regular);
             */

            
        }





        public static PrivateFontCollection private_fonts = new PrivateFontCollection();
        public static void LoadFont2()
        {


            // Use this if you can not find your resource System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            string resource = "PositivoPSRExterno.fre3of9x.ttf";
            // receive resource stream
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);

            //create an unsafe memory block for the data
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            //create a buffer to read in to
            Byte[] fontData = new Byte[fontStream.Length];
            //fetch the font program from the resource
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            //copy the bytes to the unsafe memory block
            Marshal.Copy(fontData, 0, data, (int)fontStream.Length);

            // We HAVE to do this to register the font to the system (Weird .NET bug !)
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

            //pass the font to the font collection
            private_fonts.AddMemoryFont(data, (int)fontStream.Length);
            //close the resource stream
            fontStream.Close();
            //free the unsafe memory
            Marshal.FreeCoTaskMem(data);
        }
        

        private void AllocFont(System.Drawing.Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new System.Drawing.Font(ff, size, fontStyle);
        }

        
        public string AutoSave = "";

        private void frmAjusteGeraCheckList_Load(object sender, EventArgs e)
        {
            LoadFont();
            

            if (txtChamado.Text.Length > 0)
            {
                AutoSave = "SIM";
                btnBusca.PerformClick();
                btnSalvar.PerformClick();
            }
            else
            {
                AutoSave = "NÃO";
                txtChamado.Select();
            }          
        }



        private void btnGerar_Click(object sender, EventArgs e)
        {
            GeraPDF("JACKSON DOS PANDEIROS", "NOTEBUCO", "12345", "1,99", false);
            if (MessageBox.Show("DESEJA LIMPAR TELA? ", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                consulta.LimparControles(this);
                txtChamado.Select();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*
            GeraPDF(txtChamado.Text, txtNumeroSerie.Text, txtDescricao.Text, txtTriador.Text, txtDataTriagem.Text, txtEstetico.Text, txtFuncional.Text, txtAcessoriosDisponiveis.Text, txtSAT.Text, txtCodSat.Text, true);

            if (AutoSave == "SIM")
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("DESEJA LIMPAR TELA? ", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    consulta.LimparControles(this);
                    txtChamado.Select();
                }
            }
             */
        }

        public void GeraPDF(string NOME, string PRODUTO, string CODIGO, string PRECO, bool Salvar)
        {
            

            

            var folder = "";          
            folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);            
            using (var fileStream = new System.IO.FileStream(folder + "\\" + txtChamado.Text + " " + consulta.dataParaArquivo + ".pdf", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                var document = new iTextSharp.text.Document();
                var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fileStream);
                document.Open();
                iTextSharp.text.FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");

                var fontGrand = iTextSharp.text.FontFactory.GetFont("Calibri", 16);
                var font = iTextSharp.text.FontFactory.GetFont("Calibri", 12);
                var fontPeq = iTextSharp.text.FontFactory.GetFont("Calibri", 9);

                var fontBranco = iTextSharp.text.FontFactory.GetFont("Calibri", 10, BaseColor.WHITE);
                //var CodBarra2 = iTextSharp.text.FontFactory.GetFont("IDAHC39M Code 39 Barcode", 9);


                /*
                var contentByte = pdfWriter.DirectContent;
                var image = iTextSharp.text.Image.GetInstance(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png);
                image.ScaleToFit(150, 46);
                image.SetAbsolutePosition(30, 800);
                contentByte.AddImage(image);

                PdfContentByte cb = pdfWriter.DirectContent;

                ColumnText titulo = new ColumnText(cb);
                titulo.SetSimpleColumn(new Phrase(new Chunk("VISTORIA POSITIVO", fontPeq)), 46, 670, 530, 36, 10, Element.ALIGN_LEFT | Element.ALIGN_LEFT);
                titulo.Go();
                 */

                // Figuras geométricas.
                var contentByte = pdfWriter.DirectContent;
                var image = iTextSharp.text.Image.GetInstance(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png);
                image.ScaleToFit(150, 46);
                image.SetAbsolutePosition(30, 780);
                contentByte.AddImage(image);
                
                var paragraph = new iTextSharp.text.Paragraph("", fontGrand);
                //paragraph.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
               // document.Add(paragraph);

                paragraph = new iTextSharp.text.Paragraph("\r\nRUA DORIVAL SPONCHIADO 125 PQ EMPRESARIAL\r\nOLARIA- VARZEA PAULISTA\r\n", font);
                paragraph.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                document.Add(paragraph);

                paragraph = new iTextSharp.text.Paragraph("comercial@jpeletronicos.com", fontPeq);
                paragraph.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                document.Add(paragraph);

                paragraph = new iTextSharp.text.Paragraph("\r\n\r\n");
                document.Add(paragraph);

                /*
                //CABEÇA
                PdfPTable TabCab = new PdfPTable(new float[] { 0f, 0f, 0f});
                TabCab.HorizontalAlignment = 0;
                TabCab.TotalWidth = 525f;
                TabCab.LockedWidth = true;
                PdfPCell cellCab = new PdfPCell();
                float[] widthsCab = new float[] { 100f, 300f, 100f};
                TabCab.SetWidths(widthsCab);

                cellCab = new PdfPCell(new Phrase("JP sefude: ", fontGrand));
                TabCab.AddCell(cellCab);
                cellCab = new PdfPCell(new Phrase("RUA DORIVAL SPONCHIADO 125 PQ EMPRESARIAL\r\nOLARIA- VARZEA PAULISRA: ", fontGrand));
                TabCab.AddCell(cellCab);
                cellCab = new PdfPCell(new Phrase("DATA: 25/07/2021", fontGrand));
                TabCab.AddCell(cellCab);
                document.Add(TabCab);
                TabCab.DeleteBodyRows();
                 */

                PdfPTable table = new PdfPTable(new float[] { 0f, 0f, 0f, 0f, 0f, 0f });
                table.HorizontalAlignment = 0;
                table.TotalWidth = 525f;
                table.LockedWidth = true;
                PdfPCell cell = new PdfPCell();
                float[] widths = new float[] { 50f, 75f, 220f, 50f, 50f, 80f };
                table.SetWidths(widths);
                //table.AddCell(cell);

                // CLIENTE
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.DeleteBodyRows();
                cell = new PdfPCell(new Phrase("CLIENTE: ", fontGrand));
                cell.Colspan = 6;
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Yellow);
                table.HorizontalAlignment = 0;
                table.AddCell(cell);
                document.Add(table);
                table.DeleteBodyRows();

                //TITULOS DA TABELA
                cell = new PdfPCell(new Phrase("DATA", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("REFERENCIA", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("DESCRICAO", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("QNT", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("VENDA", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("TOTAL", fontBranco));
                cell.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                document.Add(table);
                table.DeleteBodyRows();

                // DADOS DOS PRODUTOS
                for (int i = 0; i < 3; i++)
                {
                    cell = new PdfPCell(new Phrase("23/07/2021", fontPeq));
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("023526P", fontPeq));
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("COPA PRIME COMPLETO LQ PH900-B1000-BLQPR", fontPeq));
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("1", fontPeq));
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("R$ 30,50", fontPeq));
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("R$ 30,50", fontPeq));
                    table.AddCell(cell);
                }
                document.Add(table);
               
                paragraph = new iTextSharp.text.Paragraph("\r\n", fontPeq);
                document.Add(paragraph);

                //nova formatação de tabela
                PdfPTable tableDoc = new PdfPTable(new float[] { 0f, 0f });
                tableDoc.HorizontalAlignment = 0;
                tableDoc.TotalWidth = 300f;
                tableDoc.LockedWidth = true;
                PdfPCell cellDoc = new PdfPCell();
                widths = new float[] { 100f, 200f };
                tableDoc.SetWidths(widths);
                tableDoc.DefaultCell.Phrase = new Phrase() { Font = fontPeq };

                cellDoc = new PdfPCell(new Phrase("TOTAL 200,00", fontBranco));
                cellDoc.BackgroundColor = new BaseColor(System.Drawing.Color.Blue);
                cellDoc.Colspan = 2;
                cellDoc.HorizontalAlignment = 1;
                tableDoc.HorizontalAlignment = Element.ALIGN_RIGHT;
                tableDoc.AddCell(cellDoc);
                
                document.Add(tableDoc);

                paragraph = new iTextSharp.text.Paragraph("\r\n\r\n");
                document.Add(paragraph);

                tableDoc.HorizontalAlignment = Element.ALIGN_LEFT;
                tableDoc.DeleteBodyRows();
                cellDoc = new PdfPCell(new Phrase("INFORMAÇÃO BANCÁRIA", fontPeq));
                cellDoc.Colspan = 2;
                cellDoc.BackgroundColor = new BaseColor(System.Drawing.Color.Yellow);
                cellDoc.HorizontalAlignment = 0;
                tableDoc.AddCell(cellDoc);

                cellDoc = new PdfPCell(new Phrase("BANCO", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("SANTANDER", fontPeq)); tableDoc.AddCell(cellDoc);

                cellDoc = new PdfPCell(new Phrase("AGENCIA", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("0680", fontPeq)); tableDoc.AddCell(cellDoc);


                cellDoc = new PdfPCell(new Phrase("CONTA", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("0013008634-9", fontPeq)); tableDoc.AddCell(cellDoc);

                cellDoc = new PdfPCell(new Phrase("FAVORECIDO", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("SANTOS & PIMENTA ELETRONICOS LTDA", fontPeq)); tableDoc.AddCell(cellDoc);

                cellDoc = new PdfPCell(new Phrase("CNPJ", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("40.177.394/0001-72", fontPeq)); tableDoc.AddCell(cellDoc);

                cellDoc = new PdfPCell(new Phrase("PIX", fontPeq)); tableDoc.AddCell(cellDoc);
                cellDoc = new PdfPCell(new Phrase("40177394000172", fontPeq)); tableDoc.AddCell(cellDoc);
                document.Add(tableDoc);


                /*

                PdfPTable table = new PdfPTable(20);
                PdfPCell cell = new PdfPCell(new Phrase("Nome"));
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Código"));
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Produtos"));
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Preco"));
                table.AddCell(cell);
                for (int i = 0; i < 3; i++ )
                {
                    /*
                    iTextSharp.text.Image fotos = iTextSharp.text.Image.GetInstance(@"C:\imagens\" + item.Produto.ImagemUrl);
                    ViewBag.foto = fotos;
                    fotos.ScaleAbsolute(70, 70);
                    table.AddCell(fotos);
                    */
                /*
                    cell = new PdfPCell(new Phrase(NOME));
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(CODIGO));
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(PRODUTO));
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(PRECO));
                    table.AddCell(cell);
                }
                document.Add(table);
            */
               


                
                
                    document.Close();




                
                if (Salvar == true)
                {
                    
                }
                else
                {
                    System.Diagnostics.Process.Start(folder + "\\" + txtChamado.Text + " " + consulta.dataParaArquivo + ".pdf");
                }              
               
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            /*
            // MessageBox.Show("oi");
            consulta.OSViaVarejo = txtChamado.Text;
            consulta.consultarOS();
            if (consulta.Retorno == "ok")
            {
                //txtChamado.Text = consulta.Chamado;
                txtNumeroSerie.Text = consulta.NumeroSerie;
                txtDescricao.Text = consulta.Descricao;
                txtTipo.Text = consulta.TipoEquip;

                txtSAT.Text = "FILIAL: " + consulta.Filial + "\r\n";
                txtSAT.Text += "DT. ENTREGA: " + consulta.DataEntrega + "       DT. TROCA: " + consulta.DataAtendimento + "\r\n";
                txtSAT.Text += "DEFEITO RELATADO: " + consulta.DefeitoRelatado;

                txtCodSat.Text = consulta.CodBarrasSAT;

                txtAcessorio.Text = consulta.ItensFaltantes;
                txtFunc.Text = consulta.Funcional;
                txtEstetico.Text = consulta.Estetico;
                VerificaTriador();

                /*
                if (txtAcessorio.Text != "COMPLETO")
                {
                    PuxarDisponiveisCheckList();
                }
                else
                {
                    txtAcessoriosDisponiveis.Text = consulta.ItensFaltantes;
                }
                 */
            /*
                txtFuncional.Text = txtFunc.Text;
                txtAcessoriosDisponiveis.Text = txtAcessorio.Text;
                // PuxarDocumentosCheckList();
            }
        */
        }

        private void txtChamado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBusca.PerformClick();
            }
        }

        private void txtChamado_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public void PuxarDisponiveisCheckList()
        {             
            try
            {
                string sql = "";
                sql += " Select item from CheckListGeral ";
                sql += " where TipoEquip = '" + txtTipo.Text + "' and Especie = 'ACESSORIOS' and item != 'COMPLETO'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                //int i = 1;
                string texto = "";
                while (dr.Read())
                {
                    texto = dr["Item"].ToString();
                    if(txtAcessorio.Text.Contains(texto))
                    {
                        txtAcessoriosDisponiveis.Text += texto + ": SIM\r\n";        
                    }
                    else
                    {
                        txtAcessoriosDisponiveis.Text += texto + ": NÃO\r\n";  
                    }
                         
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta OS: \n" + x.Message);
            }
            cx.Desconectar();        
        }


        /*
        public void PuxarDocumentosCheckList()
        {
            try
            {
                string sql = "";
                sql += " Select item from CheckListGeral ";
                sql += " where TipoEquip = '" + txtTipo.Text + "' and Especie = 'ESTETICO'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                int i = 1;
                string texto = "";
                while (dr.Read())
                {
                    texto = dr["Item"].ToString();
                    if (txtFunc.Text.Contains(texto))
                    {
                        txtFuncional.Text += texto + ": SIM\r\n";
                    }
                    else
                    {
                        txtFuncional.Text += texto + ": NÃO\r\n";
                    }

                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta OS: \n" + x.Message);
            }
            cx.Desconectar();
        }
         */


        public void VerificaTriador()
        {
            string sql = "";           
            try
            {
                sql += "select distinct ";
                sql += "H.Usuario as Responsavel, Data from Historico H ";
                sql += "where ";
                sql += "H.idHistorico = (select max(idHistorico) from Historico where OsViaVarejo = '" + txtChamado.Text + "' and Status = 'VISTORIA' and OsViaVarejo = H.OsViaVarejo) ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    txtTriador.Text = dr["Responsavel"].ToString();
                    txtDataTriagem.Text = dr["Data"].ToString();
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta Triador: \n" + x.Message);
            }
            cx.Desconectar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAcessorio_TextChanged(object sender, EventArgs e)
        {
            txtAcessorio.Text = txtAcessorio.Text.Replace("|", "\r\n");
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            txtFunc.Text = txtFunc.Text.Replace("|", "\r\n");
        }

        private void txtEstetico_TextChanged(object sender, EventArgs e)
        {
            txtEstetico.Text = txtEstetico.Text.Replace("|", "\r\n");
        }

        private void txtDataTriagem_TextChanged(object sender, EventArgs e)
        {
            txtDataTriagem.Text = txtDataTriagem.Text.Replace("00:00:00", "");
        }

        private void txtAcessoriosDisponiveis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentosDisponiveis_TextChanged(object sender, EventArgs e)
        {

        }

       

        

      




    }
}

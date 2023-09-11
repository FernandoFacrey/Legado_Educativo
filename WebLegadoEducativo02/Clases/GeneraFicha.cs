using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace WebLegadoEducativo02.Clases
{
    public class GeneraFicha
    {
        public string GeneraFichaPago(string matricula, string depto, string cc, string fechaproceso, string importe)
        {
            string posicion = "1";
            string divisa = "MXN";
            string munEmpresa = "2632";
            DateTime fechaactual = DateTime.ParseExact(fechaproceso, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string fechadia = fechaactual.Day.ToString();
            string fechames = fechaactual.Month.ToString();
            string fechaanio = fechaactual.Year.ToString();
            string lineaCaptura = "";
            string Largo = (((Convert.ToInt16(fechaanio) - 2013) * 372) + ((Convert.ToInt16(fechames) - 1) * 31) + (Convert.ToInt16(fechadia) - 1)).ToString().PadLeft(4, '0');
            string importes = (Convert.ToDouble(importe) * 100).ToString().PadLeft(10, '0');
            int importe1, importe2, importe3, importe4, importe5, importe6, importe7, importe8, importe9, importe10 = 0;
            importe1 = Convert.ToInt16((importes.Substring(0, 10)).Substring(0, 1)) * 7;
            importe2 = Convert.ToInt16((importes.Substring(1, 9)).Substring(0, 1)) * 1;
            importe3 = Convert.ToInt16((importes.Substring(2, 8)).Substring(0, 1)) * 3;
            importe4 = Convert.ToInt16((importes.Substring(3, 7)).Substring(0, 1)) * 7;
            importe5 = Convert.ToInt16((importes.Substring(4, 6)).Substring(0, 1)) * 1;
            importe6 = Convert.ToInt16((importes.Substring(5, 5)).Substring(0, 1)) * 3;
            importe7 = Convert.ToInt16((importes.Substring(6, 4)).Substring(0, 1)) * 7;
            importe8 = Convert.ToInt16((importes.Substring(7, 3)).Substring(0, 1)) * 1;
            importe9 = Convert.ToInt16((importes.Substring(8, 2)).Substring(0, 1)) * 3;
            importe10 = Convert.ToInt16((importes.Substring(9, 1)).Substring(0, 1)) * 7;
            int suma = (importe1 + importe2 + importe3 + importe4 + importe5 + importe6 + importe7 + importe8 + importe9 + importe10) % 10;
            int suma39 = 0;
            int[] segunda = new int[39];
            int[] multiplica = { 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11, 23, 19, 17, 13, 11 };
            //            string[,] tablaletras = new string[36,5] { {"A","2","1","1","1"}, {"B","2","2","2","2"}, {"C","2","3","3","3"}, {"D","3","4","4","4"}, {"E","3","5","5","5"}, {"F","3","6","6","6"}, {"G","4","7","7","7"}, {"H","4","8","8","8"}, {"I","4","9","9","9"},
            //                                                           {"J","5","1","1","1"}, {"K","5","2","2","2"}, {"L","5","3","3","3"}, {"M","6","4","4","4"}, {"N","6","5","5","5"}, {"O","6","6","6","6"}, {"P","7","7","7","7"},
            //                                                           {"Q","7","8","8","8"}, {"R","7","9","9","9"}, {"S","8","2","1","1"}, {"T","8","3","2","2"}, {"U","8","4","3","3"}, {"V","9","5","4","4"}, {"W","9","6","5","5"},
            //                                                           {"X","9","7","6","6"}, {"Y","0","8","7","7"}, {"Z","0","9","8","8"}, {"1","1","1","1","1"}, {"2","2","2","2","2"}, {"3","3","3","3","3"}, {"4","4","4","4","4"},
            //                                                           {"5","5","5","5","5"}, {"6","6","6","6","6"}, {"7","7","7","7","7"}, {"8","8","8","8","8"}, {"9","9","9","9","9"}, {"0","0","0","0","0"} };
            string[] letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int[] POSICION1 = new int[] { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] POSICION2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] POSICION3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] POSICION4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            lineaCaptura = matricula.PadLeft(9, '0') + depto.PadLeft(4, '0') + cc.PadLeft(6, '0') + Largo + suma;
            for (int i = 0; i <= 38; i++)
            {
                segunda[i] = 0;
            }
            int ii = 0;
            for (int i = 38; i >= 1; i--)
            {
                if (lineaCaptura.Length < i)
                {
                    segunda[i] = 0;
                }
                else
                {
                    if (Regex.IsMatch((lineaCaptura).Substring(lineaCaptura.Length - i).Substring(0, 1), @"^[0-9]+$"))
                    {
                        segunda[i] = (Convert.ToInt16((lineaCaptura).Substring(lineaCaptura.Length - i).Substring(0, 1)) * multiplica[ii]);
                    }
                    else
                    {
                        int ind = Array.IndexOf(letras, (lineaCaptura).Substring(lineaCaptura.Length - i).Substring(0, 1));
                        if (posicion == "1")
                        {
                            segunda[i] = POSICION1[ind] * multiplica[ii];
                        }
                        else if (posicion == "2")
                        {
                            segunda[i] = POSICION2[ind] * multiplica[ii];
                        }
                        else if (posicion == "3")
                        {
                            segunda[i] = POSICION3[ind] * multiplica[ii];
                        }
                        else if (posicion == "4")
                        {
                            segunda[i] = POSICION4[ind] * multiplica[ii];
                        }
                    }
                    ii = ii + 1;
                    suma39 = suma39 + segunda[i];
                }
            }
            int ressuma39 = (suma39 % 97) + 1;
            Console.Write(matricula.PadLeft(9, '0') + depto.PadLeft(4, '0') + cc.PadLeft(6, '0') + Largo + suma + ressuma39.ToString().PadLeft(2, '0'));
            string linecapturafinal = matricula.PadLeft(9, '0') + depto.PadLeft(4, '0') + cc.PadLeft(6, '0') + Largo + suma + ressuma39.ToString().PadLeft(2, '0');

            string nombreRutaArchivo = imprimepdf(matricula.PadLeft(9, '0'), fechaactual.ToLongDateString(), importe, divisa, munEmpresa, linecapturafinal);

            return nombreRutaArchivo;
        }
        static string imprimepdf(string matricula, string fechaactual, string importe, string divisa, string munEmpresa, string lineadecaptura)
        {
            string archivo = "PDF/LineaCaptura" + matricula.PadLeft(9, '0') + ".pdf";
            string rutaArchivo = System.Web.Hosting.HostingEnvironment.MapPath("~/" + archivo);
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            Font font_nsmall = FontFactory.GetFont(FontFactory.HELVETICA, 7, Font.BOLD);
            Font font_n = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLD);
            Font font_celdas = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.NORMAL);
            Font font_pie = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12, Font.BOLD);
            doc.SetPageSize(PageSize.LEGAL);
            doc.SetMargins(20f, 20f, 20f, 20f);
            Rectangle pageBorder = new Rectangle(doc.PageSize);
            pageBorder.BorderWidth = 2f;
            pageBorder.BorderColor = BaseColor.BLACK;
            //            PdfWriter writer = PdfWriter.GetInstance
            doc.Open();
            Paragraph title = new Paragraph();
            string nombreArchivo = "titulo.png";
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image1 = Image.GetInstance(rutaArchivo02);
            image1.ScaleAbsoluteWidth(480);
            image1.ScaleAbsoluteHeight(50);
            doc.Add(image1);
            PdfPTable table = new PdfPTable(4) { WidthPercentage = 100f };
            float[] widths = new float[] { 20f, 20f, 20f, 20f };
            //            table.SetTotalWidth(widths);
            //            table.LockedWidth = true;
            //table.SetWidths(widths);
            //            table.HorizontalAlignment = 0;
            //            table.SpacingBefore = 50f;
            table.DefaultCell.Border = 0;

            //            PdfPCell celldg = new PdfPCell(new Phrase("DATOS GENERALES", font_n));
            //            celldg.Border = 0;
            //            celldg.Colspan = 4;
            //            celldg.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            //            table.AddCell(celldg);
            table.AddCell(new Phrase("FECHA LIMITE DE PAGO: ", font_n));
            PdfPCell cellflim = new PdfPCell(new Phrase(fechaactual, font_celdas));
            cellflim.Colspan = 4;
            cellflim.Border = 0;
            table.AddCell(cellflim);

            table.AddCell(new Phrase("CANTIDAD A PAGAR: ", font_n));
            PdfPCell cellcanPa = new PdfPCell(new Phrase(String.Format("{0:$###,###,###.00}", Convert.ToDecimal(importe), font_celdas) + " " + divisa));
            cellcanPa.Colspan = 4;
            cellcanPa.Border = 0;
            table.AddCell(cellcanPa);

            PdfPCell cellren1 = new PdfPCell(new Phrase("PARA TU COMODIDAD TE OFRECEMOS LAS SIGUIENTES FORMAS DE PAGO", font_celdas));
            cellren1.Colspan = 4;
            cellren1.Border = 0;
            cellren1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cellren1);


            doc.Add(new Paragraph("\n"));
            nombreArchivo = "logob.png";
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image2 = Image.GetInstance(rutaArchivo02);
            image2.ScaleAbsoluteWidth(200f);
            image2.ScaleAbsoluteHeight(50f);
            image2.SetAbsolutePosition(160f, 750f);
            image2.Alignment = Element.ALIGN_CENTER;
            //  Logo Banco 
            PdfPCell cellimg1 = new PdfPCell();
            cellimg1.Border = 0;
            cellimg1.AddElement(image2);
            cellimg1.Colspan = 4;
            cellimg1.Border = 0;
            cellimg1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cellimg1);

            //  Parte izquierda 
            nombreArchivo = "izquierdo1.png";
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image3 = Image.GetInstance(rutaArchivo02);
            image3.ScaleAbsoluteWidth(200f);
            image3.ScaleAbsoluteHeight(50f);
            image3.SetAbsolutePosition(50f, 700f);
            image3.Alignment = Element.ALIGN_CENTER;

            PdfPCell cellimg3 = new PdfPCell();
            cellimg3.AddElement(image3);
            cellimg3.Colspan = 2;
            cellimg3.HorizontalAlignment = Element.ALIGN_CENTER;
            cellimg3.Border = PdfPCell.NO_BORDER;
            cellimg3.BorderWidthRight = 1f;
            table.AddCell(cellimg3);

            nombreArchivo = "derecho1.png";
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image4 = Image.GetInstance(rutaArchivo02);
            image4.ScaleAbsoluteWidth(200f);
            image4.ScaleAbsoluteHeight(50f);
            image4.SetAbsolutePosition(300f, 700f);
            image4.Alignment = Element.ALIGN_CENTER;

            PdfPCell cellimg4 = new PdfPCell();
            cellimg4.AddElement(image4);
            cellimg4.Colspan = 2;
            cellimg4.HorizontalAlignment = Element.ALIGN_CENTER;
            cellimg4.Border = PdfPCell.NO_BORDER;
            cellimg4.BorderWidthLeft = 1f;
            table.AddCell(cellimg4);

            PdfPCell cel1 = new PdfPCell(new Phrase("EN SUCURSAL O BANORTE POR INTERNET (BXI)", font_celdas));
            cel1.Colspan = 2;
            cel1.Border = PdfPCell.NO_BORDER;
            cel1.BorderWidthRight = 1f;
            table.AddCell(cel1);

            PdfPCell cel2 = new PdfPCell(new Phrase("TRANSFERENCIA DE OTROS BANCOS", font_celdas));
            cel2.Colspan = 2;
            cel2.Border = PdfPCell.NO_BORDER;
            cel2.BorderWidthLeft = 1f;
            table.AddCell(cel2);

            PdfPCell cel3 = new PdfPCell(new Phrase("NÚMERO DE EMPRESA  " + munEmpresa, font_celdas));
            cel3.Colspan = 2;
            cel3.Border = PdfPCell.NO_BORDER;
            cel3.BorderWidthRight = 1f;
            table.AddCell(cel3);

            PdfPCell cel4 = new PdfPCell(new Phrase("CLABE INTERBANCARIA:  " + lineadecaptura, font_celdas));
            cel4.Colspan = 2;
            cel4.Border = PdfPCell.NO_BORDER;
            cel4.BorderWidthLeft = 1f;
            table.AddCell(cel4);

            PdfPCell cel5 = new PdfPCell(new Phrase("REFERENCIA: " + lineadecaptura, font_celdas));
            cel5.Colspan = 2;
            cel5.Border = PdfPCell.NO_BORDER;
            cel5.BorderWidthRight = 1f;
            table.AddCell(cel5);

            PdfPCell cel6 = new PdfPCell(new Phrase("REFERENCIA: " + lineadecaptura.Substring(0, 13), font_celdas));
            cel6.Colspan = 2;
            cel6.Border = PdfPCell.NO_BORDER;
            cel6.BorderWidthLeft = 1f;
            table.AddCell(cel6);

            PdfPCell cel7 = new PdfPCell(new Phrase(" ", font_celdas));
            cel7.Colspan = 2;
            cel7.Border = PdfPCell.NO_BORDER;
            cel7.BorderWidthRight = 1f;
            table.AddCell(cel7);

            PdfPCell cel8 = new PdfPCell(new Phrase(" ", font_celdas));
            cel8.Colspan = 2;
            cel8.Border = PdfPCell.NO_BORDER;
            cel8.BorderWidthLeft = 1f;
            table.AddCell(cel8);

            PdfPCell cel9 = new PdfPCell(new Phrase(" ", font_celdas));
            cel9.Colspan = 2;
            cel9.Border = PdfPCell.NO_BORDER;
            cel9.BorderWidthRight = 1f;
            table.AddCell(cel9);

            PdfPCell cel10 = new PdfPCell(new Phrase("Para identificar tu TRANSFERENCIA, favor de incluir el número ", font_celdas));
            cel10.Colspan = 2;
            cel10.Border = PdfPCell.NO_BORDER;
            cel10.BorderWidthLeft = 1f;
            table.AddCell(cel10);

            PdfPCell cel11 = new PdfPCell(new Phrase(" ", font_celdas));
            cel11.Colspan = 2;
            cel11.Border = PdfPCell.NO_BORDER;
            cel11.BorderWidthRight = 1f;
            table.AddCell(cel11);

            PdfPCell cel12 = new PdfPCell(new Phrase("de referencia ", font_celdas));
            cel12.Colspan = 2;
            cel12.Border = PdfPCell.NO_BORDER;
            cel12.BorderWidthLeft = 1f;
            table.AddCell(cel12);

            //  Parte izquierda 
            nombreArchivo = "Qrlegado.png";
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image5 = Image.GetInstance(rutaArchivo02);
            image5.ScaleAbsoluteWidth(200f);
            image5.ScaleAbsoluteHeight(50f);
            image5.SetAbsolutePosition(50f, 700f);
            image5.Alignment = Element.ALIGN_CENTER;

            PdfPCell cellimg5 = new PdfPCell();
            cellimg5.AddElement(image5);
            cellimg5.Colspan = 2;
            cellimg5.HorizontalAlignment = Element.ALIGN_CENTER;
            cellimg5.Border = PdfPCell.NO_BORDER;
            cellimg5.BorderWidthRight = 1f;
            table.AddCell(cellimg5);


            nombreArchivo = "sevenlegado.png";
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivo02 = Path.Combine(rutaBase, "Resources", nombreArchivo);
            Image image6 = Image.GetInstance(rutaArchivo02);
            image6.ScaleAbsoluteWidth(200f);
            image6.ScaleAbsoluteHeight(50f);
            image6.SetAbsolutePosition(300f, 700f);
            image6.Alignment = Element.ALIGN_CENTER;

            PdfPCell cellimg6 = new PdfPCell();
            cellimg6.AddElement(image6);
            cellimg6.Colspan = 2;
            cellimg6.HorizontalAlignment = Element.ALIGN_CENTER;
            cellimg6.Border = PdfPCell.NO_BORDER;
            cellimg6.BorderWidthLeft = 1f;
            table.AddCell(cellimg6);

            PdfPCell cel13 = new PdfPCell(new Phrase(" ", font_celdas));
            cel13.Colspan = 2;
            cel13.Border = PdfPCell.NO_BORDER;
            cel13.BorderWidthRight = 1f;
            table.AddCell(cel13);

            PdfPCell cel14 = new PdfPCell(new Phrase("CODIGO DE EMPRESA " + munEmpresa, font_celdas));
            cel14.Colspan = 2;
            cel14.Border = PdfPCell.NO_BORDER;
            cel14.BorderWidthLeft = 1f;
            table.AddCell(cel14);

            PdfPCell cel15 = new PdfPCell(new Phrase(" ", font_celdas));
            cel15.Colspan = 2;
            cel15.Border = PdfPCell.NO_BORDER;
            cel15.BorderWidthRight = 1f;
            table.AddCell(cel15);

            PdfPCell cel16 = new PdfPCell(new PdfPCell(new Phrase("REFERENCIA: " + lineadecaptura, font_celdas)));
            cel16.Colspan = 2;
            cel16.Border = PdfPCell.NO_BORDER;
            cel16.BorderWidthLeft = 1f;
            table.AddCell(cel16);

            PdfPCell cel17 = new PdfPCell(new Phrase("    RECUERDA CONSERVAR TU TICKET DE PAGO", font_pie));
            cel17.Colspan = 4;
            cel17.Border = 0;
            cel17.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel17);

            PdfPCell cel18 = new PdfPCell(new Phrase("  "));
            cel18.Colspan = 4;
            cel18.Border = 0;
            table.AddCell(cel18);

            PdfPCell cel19 = new PdfPCell(new Phrase("  Realizado el depósito póngase en contacto con el área correspondiente, e informe de inmediato en caso de requerir Factura Electrónica (CFDI). En caso  de", font_nsmall));
            cel19.Colspan = 4;
            cel19.Border = 0;
            cel19.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel19);

            PdfPCell cel20 = new PdfPCell(new Phrase("   no recibir aviso en cinco días hábiles  posteriores a la realización del depósito se factura como ventas al público en general.", font_nsmall));
            cel20.Colspan = 4;
            cel20.Border = 0;
            cel20.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel20);

            PdfPCell cel21 = new PdfPCell(new Phrase("   SEVEN ELEVEN y TELECOMM cobrarán la comisión vigente en la plaza donde se realice el pago por concepto de servicios, Incluido el I.V.A. correspondiente.", font_nsmall));
            cel21.Colspan = 4;
            cel21.Border = 0;
            cel21.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel21);

            PdfPCell cel22 = new PdfPCell(new Phrase("   En caso de cheque devuelto se hará un cargo del 20% del valor del cheque, más los cargos bancarios que se efectúen.", font_nsmall));
            cel22.Colspan = 4;
            cel22.Border = 0;
            cel22.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel22);

            PdfPCell cel23 = new PdfPCell(new Phrase("   Este documento no es un comprobante de pago.", font_nsmall));
            cel23.Colspan = 4;
            cel23.Border = 0;
            cel23.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cel23);

            doc.Add(table);
            doc.Close();

            string nombreRutaArchivo = archivo + "|" + rutaArchivo;
            return nombreRutaArchivo;
        }
    }
}
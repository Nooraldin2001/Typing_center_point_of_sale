using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Image = iTextSharp.text.Image;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;
using System.Security.Claims;
using iTextSharp.text.pdf.languages;

namespace H2H_App
{
    public partial class Invoice_Form : Form
    {
        public Invoice_Form()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Invoice_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            // Populate the employee combo box with some dummy data
            employeeComboBox.Items.Add("Hassan Abdalkadir Hassan");
            employeeComboBox.Items.Add("حسن");
            employeeComboBox.Items.Add("Hosni");
            employeeComboBox.Items.Add("Laila");

            // Populate the payment method combo box
            paymentMethodComboBox.Items.Add("Cash");
            paymentMethodComboBox.Items.Add("Bank Transfer");
        }

        private void ADD_Btn_Click(object sender, EventArgs e)
        {
            Add_Data_Togridview();
            Calculate_total();
        }

        private void Add_Data_Togridview()
        {
            // Get the user input
            string description = description_TB.Text;
            int quantity = Convert.ToInt32(Qty_TB.Text);
            double unitPrice = Convert.ToDouble(UnitPrice_TB.Text);

            //double VAT_PERCENTAGE = 0.5;

            // Calculate the subtotal, VAT( = 0 until specified) and total
            double subtotal = quantity * unitPrice;

            // double vat = subtotal * VAT_PERCENTAGE;
            //double total = subtotal + subtotal;

            // Add the data to the grid view

            dataGridView1.Rows.Add(description, quantity, unitPrice, subtotal);
        }

        private void Calculate_total()
        {
            // Update the subtotal and total labels
            //double runningSubtotal = 0;
            double runningTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                    runningTotal += Convert.ToDouble(row.Cells["subtotal_col"].Value?.ToString());
            }

            //SubTotal_lbl.Text = runningSubtotal.ToString("C");
            Total_lbl.Text = runningTotal.ToString("C");
        }

        private void Delete_Row(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the subtotal of the row to be deleted
                    double subtotal = (double)dataGridView1.SelectedRows[0].Cells["subtotal_col"].Value;

                    // Delete the selected row
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                    // Subtract the subtotal from the total 
                    double total = double.Parse(Total_lbl.Text.Substring(3)) - subtotal;

                    // Update the total label
                    Total_lbl.Text = total.ToString("C");
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            Delete_Row(e);
        }

        private void Refresh(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                dataGridView1.Rows.Clear();
                SubTotal_lbl.Text = "0";
                Total_lbl.Text = "$0";
            }
        }

        private void Invoice_Form_KeyDown(object sender, KeyEventArgs e)
        {
            Refresh(e);
        }

        private void Print_TB_Click(object sender, EventArgs e)
        {
            print();
        }

        private void print()
        {
            // Set the path of the background image file
            string backgroundImagePath = "C:\\Users\\abt01\\Downloads\\Debug\\background.jpg";

            // Set up the PDF document
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Invoice.pdf", FileMode.Create));

            doc.Open();

            //// Add a watermark with the background image to each page
            Image backgroundImage = Image.GetInstance(backgroundImagePath);
            backgroundImage.SetAbsolutePosition(0, 0);
            backgroundImage.ScaleAbsolute(doc.PageSize);
            writer.DirectContent.AddImage(backgroundImage);

            // Set the Arabic font
            //BaseFont arabicFont = BaseFont.CreateFont("C:\\H2H_App\\H2H_App\\bin\\Debug\\Cairo-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            //Font arabicCellFont = new Font(arabicFont, 12);

            BaseFont arabicFont = BaseFont.CreateFont("C:\\Users\\abt01\\Downloads\\Debug\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font arabicCellFont = new Font(arabicFont, 12);

            // Add the invoice table content to the PDF
            ArabicLigaturizer al = new ArabicLigaturizer();
            PdfPTable table = new PdfPTable(4);
            table.DefaultCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; // Right to left
            table.AddCell(new PdfPCell(new Phrase(al.Process("Description"), arabicCellFont)));
            table.AddCell(new PdfPCell(new Phrase("Quantity")));
            table.AddCell(new PdfPCell(new Phrase("Unit Price")));
            table.AddCell(new PdfPCell(new Phrase("Subtotal")));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                PdfPCell descriptionCell = new PdfPCell(new Phrase(al.Process(row.Cells[0].Value?.ToString()), arabicCellFont));
                descriptionCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(descriptionCell);

                PdfPCell quantityCell = new PdfPCell(new Phrase(row.Cells[1].Value?.ToString()));
                quantityCell.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(quantityCell);

                PdfPCell unitPriceCell = new PdfPCell(new Phrase(row.Cells[2].Value?.ToString()));
                unitPriceCell.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(unitPriceCell);

                PdfPCell subtotalCell = new PdfPCell(new Phrase(row.Cells[3].Value?.ToString()));
                subtotalCell.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(subtotalCell);
            }

            table.TotalWidth = 500f;
            table.WriteSelectedRows(0, -1, 50f, 700f, writer.DirectContent);

            //doc.Add(table);
            // Add the employee name, payment method,company name and total to the PDF
            Chunk companyChunk = new Chunk("Company Name: " + CompanyName_TB.Text);
            companyChunk.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk employeeChunk = new Chunk("Employee: " + employeeComboBox.SelectedItem.ToString());
            employeeChunk.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk paymentChunk = new Chunk("Payment Method: " + paymentMethodComboBox.SelectedItem.ToString());
            paymentChunk.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk totalChunk = new Chunk("Total: " + Total_lbl.Text);
            totalChunk.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            doc.Add(new Paragraph(companyChunk));
            doc.Add(new Paragraph(employeeChunk));
            doc.Add(new Paragraph(paymentChunk));
            doc.Add(new Paragraph(totalChunk));

            // Move the employee name, payment method, and total to the desired position
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(companyChunk), 50f, 450f, 0);
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(employeeChunk), 50f,465f, 0);
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(paymentChunk), 50f, 480f, 0);
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(totalChunk), 50f, 495f, 0);

            // Add today's date to the top left of the page
            string dateFormat = "MM/dd/yyyy HH:mm:ss";
            Chunk dateChunk2 = new Chunk(dateTimePicker1.Value.ToString(dateFormat));
            dateChunk2.Font = FontFactory.GetFont(FontFactory.HELVETICA);
            PdfPCell dateCell = new PdfPCell(new Phrase(dateChunk2));
            dateCell.HorizontalAlignment = Element.ALIGN_LEFT;
            dateCell.Border = PdfPCell.NO_BORDER;
            table = new PdfPTable(1);
            table.WidthPercentage = 100;
            table.AddCell(dateCell);
            doc.Add(table);

            //Close the document
            //writer.Close();
            doc.Close();

            //Open the PDF file in the default PDF viewer
            Process.Start("invoice.pdf");

        }
    }
}

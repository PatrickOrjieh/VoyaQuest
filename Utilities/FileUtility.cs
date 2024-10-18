using iTextSharp.text;
using iTextSharp.text.pdf;
using VoyaQuest.Models.FlightOffersResponse;

namespace VoyaQuest.Utilities
{
    /// <summary>
    /// This class contains utility methods for file operations.
    /// learnt the basics and took inspiration from https://gist.github.com/aaryan79831014/4fc83338f4fe7472b52f35db997ce3f0
    /// </summary>
    public static class FileUtility
    {
        private static readonly string logoPath = "wwwroot/images/icons8-truck.gif";
        // The company color used in the PDF based off the design of my website #ef732a
        private static readonly BaseColor companyColor = new BaseColor(239, 115, 42);

        public static byte[] GeneratePdfItinerary(string name, string email, FlightOffer selectedFlightOffer)
        {
            Document doc = new Document(PageSize.A4);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter.GetInstance(doc, memoryStream);
                doc.Open();

                if (File.Exists(logoPath))
                {
                    Image logo = Image.GetInstance(logoPath);
                    logo.ScaleToFit(100f, 50f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(logo);
                }

                // to add title
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, companyColor);
                Paragraph title = new Paragraph("Flight Itinerary", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(title);

                // Add space
                doc.Add(new Paragraph(" "));

                // Add passenger details
                Font regularFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                doc.Add(new Paragraph($"Name: {name}", regularFont));
                doc.Add(new Paragraph($"Email: {email}", regularFont));
                doc.Add(new Paragraph(" ", regularFont));

                // Add flight information in a table format
                PdfPTable table = new PdfPTable(2) { WidthPercentage = 100 };
                table.AddCell(GetStyledCell("Flight Carrier", companyColor));
                table.AddCell(selectedFlightOffer.itineraries.First().segments.First().carrierCode);
                table.AddCell(GetStyledCell("Departure", companyColor));
                table.AddCell($"{selectedFlightOffer.itineraries.First().segments.First().departure.iataCode}, {selectedFlightOffer.itineraries.First().segments.First().departure.at}");
                table.AddCell(GetStyledCell("Arrival", companyColor));
                table.AddCell($"{selectedFlightOffer.itineraries.First().segments.Last().arrival.iataCode}, {selectedFlightOffer.itineraries.First().segments.Last().arrival.at}");
                table.AddCell(GetStyledCell("Duration", companyColor));
                table.AddCell(selectedFlightOffer.itineraries.First().duration);
                table.AddCell(GetStyledCell("Price", companyColor));
                table.AddCell($"{selectedFlightOffer.price.currency} {selectedFlightOffer.price.total}");
                doc.Add(table);

                doc.Close();

                return memoryStream.ToArray();
            }
        }

        private static PdfPCell GetStyledCell(string text, BaseColor color)
        {
            Font font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, color);
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 5f
            };
            return cell;
        }
    }

}

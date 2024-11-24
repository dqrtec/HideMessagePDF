using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Pdf.IO;
using PdfSharp.Quality;

namespace HidePDF
{
    public partial class Form1 : Form
    {
        string namefile = "teste1.pdf";
        public Form1()
        {
            InitializeComponent();

            string stringEscondida = "fenix-55123".Encrypt();

            CreatePDF(namefile, stringEscondida);

            ReadPDF(namefile);
        }

        void ReadPDF(string namefile)
        {
            var document = PdfReader.Open(namefile);

            var secretMessage = document.Info.Title.Dencrypt();

            MessageBox.Show(secretMessage + "\n" + document.Info.Title);
        }

        void CreatePDF(string namefile, string stringEscondida)
        {
            var document = new PdfDocument(namefile);

            document.Info.Title = stringEscondida;

            var page = document.AddPage();

            var textAnnot = new PdfTextAnnotation
            {
                Title = "Escondido".Encrypt(),
                Subject = "Escondido".Encrypt(),
                Contents = "Escondido".Encrypt(),
                Icon = PdfTextAnnotationIcon.Help,
                Color = XColors.LimeGreen,
                Opacity = 1,
                Open = true
            };

            page.Annotations.Add(textAnnot);

            document.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

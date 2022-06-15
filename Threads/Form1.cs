using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Threading;

namespace Sprint2Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class codificacio
        {
            public String vocal { get; set; }
            public String codi { get; set; }
        }

        List<codificacio> codis = new List<codificacio>();

        private void btnGenerarCodificacio_Click(object sender, EventArgs e)
        {
            ArrayList numeros = new ArrayList()
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };

            for (int i = 0; i < 5; i++)
            {

                ArrayList numeroscopia = new ArrayList();
                numeroscopia.Clear();
                numeroscopia.AddRange(numeros);
                
                String[] vocales = new String[] { "a", "e", "i", "o", "u" };
                String codi = "";

                for (int x = 0; x < 10; x++)
                {

                    RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                    var bytearray = new byte[4];
                    provider.GetBytes(bytearray);
                    int RandomInteger = BitConverter.ToInt32(bytearray, 0);

                    Random random = new Random(RandomInteger);
                    int value = random.Next(0, (numeroscopia.Count - 1));

                    codi = codi + (string)numeroscopia[value];
                    numeroscopia.RemoveAt(value);

                }

                codificacio cod = new codificacio()
                {
                    vocal = vocales[i],
                    codi = codi,
                };

                codis.Add(cod);
            }

            FileStream fitxer = new FileStream("codificacio.txt", FileMode.Create, FileAccess.Write);
            StreamWriter escriptor = new StreamWriter(fitxer);

            for (int i = 0; i < codis.Count; i++)
            {

                escriptor.WriteLine(codis[i].vocal.ToUpper() + ": " + codis[i].codi);

            }

            escriptor.Close();
            fitxer.Close();

            MessageBox.Show("Codificació generada.");

        }
        
        private void btnGenerarFitxers_Click(object sender, EventArgs e)
        {

            int numarxius = Int32.Parse(txtnumfitxers.Text);

            Thread creacioarxius = new Thread(CrearArxius);
            Thread crearzip = new Thread(CrearZip);

            creacioarxius.Start();
            creacioarxius.Join();
            crearzip.Start(numarxius);

        }

        private void CrearArxius()
        {
            int numfitxers = Int32.Parse(txtnumfitxers.Text);
            int numvocals = Int32.Parse(txtnumlletres.Text);
            String path = "arxius";
            String[] vocales = new String[] { "A", "E", "I", "O", "U" };

            if (Directory.Exists(path))
            {
                foreach (var item in Directory.GetFiles(path))
                {
                    File.Delete(item);
                }
            }
            else
            {
                Directory.CreateDirectory("arxius");
            }

            Parallel.For(0, numfitxers,
                i =>
                {
                    String arxiu = path + @"\" + "fitxer" + i.ToString() + ".txt";
                    ArrayList codigos = new ArrayList();
                    FileStream fitxer = new FileStream(arxiu, FileMode.Create, FileAccess.Write);
                    StreamWriter escriptor = new StreamWriter(fitxer);

                    for (int x = 0; x < numvocals; x++)
                    {
                        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                        var bytearray = new byte[4];
                        provider.GetBytes(bytearray);
                        int RandomInteger = BitConverter.ToInt32(bytearray, 0);

                        Random random = new Random(RandomInteger);
                        int value = random.Next(0, (vocales.Length));

                        escriptor.Write(vocales[value]);

                        foreach (var item in codis)
                        {
                            if (item.vocal.ToUpper() == vocales[value])
                            {
                                codigos.Add(item.codi);
                            }
                        }
                    }

                    escriptor.WriteLine("");
                    escriptor.WriteLine("");

                    for (int y = 0; y < codigos.Count; y++)
                    {
                        escriptor.Write(codigos[i]);
                    }

                    codigos.Clear();
                    escriptor.Close();
                    fitxer.Close();

                });

            MessageBox.Show("Fitxers creats.");
        }

        private void CrearZip(object numarxius)
        {
            String path = "arxius";
            String[] arxius = Directory.GetFiles(path);
            String arxiuzip = "fitxers.zip";

            if (File.Exists(arxiuzip))
            {
                File.Delete(arxiuzip);
            }

            using (var archive = ZipFile.Open(arxiuzip, ZipArchiveMode.Create))
            {
                foreach (String ruta in arxius)
                {
                    archive.CreateEntryFromFile(ruta, Path.GetFileName(ruta));
                }
            }

            MessageBox.Show("Zip creat, amb " + numarxius.ToString() + " fitxers.");
        }

    }
}

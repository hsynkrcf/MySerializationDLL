using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SerilestirLib;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------XML DENEME-------------------------------
            SerilestirXml baba = new SerilestirXml();
            Ogrenci ogr = new Ogrenci("hüseyin","karacif");
            //baba.XmlSerialize(ogr,"ogrenci.xml");
            //ogr = baba.XmlDeserialize<Ogrenci>("ogrenci.xml");
            //MessageBox.Show(ogr.ToString());
            //-------------------BINARY DENEME----------------------------
            SerilestirBinary anne = new SerilestirBinary();
            //anne.BinarySerialize(ogr,"ogrenci.hsyn");
            //ogr = anne.BinaryDeserialize<Ogrenci>("ogrenci.hsyn");
            //MessageBox.Show(ogr.ToString());
            SerilestirJson cocuk = new SerilestirJson();
            //cocuk.JsonSerializer(ogr,"ogrenci.json");
            //ogr = cocuk.JsonDeserialize<Ogrenci>("ogrenci.json");
            //MessageBox.Show(ogr.ToString());
        }
    }
    [DataContract]
    [Serializable]
    public class Ogrenci
    {
        [DataMember]
        public string Ad { get; set; }
        [DataMember]
        public string Soyad { get; set; }

        public Ogrenci(string ad , string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
        public Ogrenci()
        {
            
        }
    }
}

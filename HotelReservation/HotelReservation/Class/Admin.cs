﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    class Admin
    {
        private string id, adi,sifre;
        public string getId
        {
            get { return id; }
        }
        public string getAdi
        {
            get { return adi; }
        }
        public string getSifre
        {
            get { return sifre; }
        }
        
        public Admin(string id, string adi, string sifre)
        {
            this.id = id;
            this.adi = adi;
            this.sifre = sifre;
        

        }
        public Admin()
        {

        }

        public void bilgileriGöster(Otel otel)
        {
            
        }

        public Forms.OtelEkleFormu OtelEkleFormu=new Forms.OtelEkleFormu();
        public static List<Otel> otels = new List<Otel>();
        public static List<string> sehir = new List<string>();
        Otel otel;
        //public void OtelEkle()
        //{
        //    if (OtelEkleFormu.comboBox1.SelectedIndex == 0)
        //    {
        //        otels.Add(new ButikOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
        //    }
        //    else if (OtelEkleFormu.comboBox1.SelectedIndex == 1)
        //    {
        //        otels.Add(new LuksOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
        //    }
        //    else if (OtelEkleFormu.comboBox1.SelectedIndex == 2)
        //    {
        //        otels.Add(new PansiyonOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
        //    }
        //    else if (OtelEkleFormu.comboBox1.SelectedIndex == 3)
        //    {
        //        otels.Add(new TatilKöyüOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
        //    }
        //    OtelEkleFormu.textBox1.Text = otels[0].getAd + "1";
        //    OtelEkleFormu.listBox1.Items.Add(otels.ToString());
        //}
        

        public List<Oda> OdaEkleme(Otel otel)
        {
            return new List<Oda>();
        }
        
        public List<Oda> OdaArama(Otel otel)
        {
            return new List<Oda>();
        }
        //public override string ToString()
        //{
        //    return $"Otel Adı :{otel.getAd}Şehir :{otel.getSehir} Yıldız :{otel.getYildiz} Sauna: {otel.getSauna}";
        //}
    }
   
}

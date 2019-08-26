using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        void HizmetIciEgitim(int B7a, int B7b, int B8a, int B8b, int B9a, int B9b, int K17a, int K17b, int K18a, int K18b, int K19a, int K19b, int K27a, int K27b, int K28a, int K28b, int K29a, int K29b, int K37a, int K37b, int K38a, int K38b, int K39a, int K39b)
        {

            int Bolum1Max = 5;
            int Bolum1Min =0;
            
            int Bolum2Max =12;
            int Bolum2Min =6;

            int Bolum3Max =19;
            int Bolum3Min =13;

            int Bolum4Max =27;
            int Bolum4Min =20;
            
            int Bolum5Max =37;
            int Bolum5Min =28;

            int Bolum6Max =50;
            int Bolum6Min =38;




    
    int puan = 0;

            int sayi = 0;
            if (K17a != 0 && K17b != 0)
                sayi++;
            if (K18a != 0 && K18b != 0)
                sayi++;
            if (K19a != 0 && K19b != 0)
                sayi++;
            if (K27a != 0 && K27b != 0)
                sayi++;
            if (K28a != 0 && K28b != 0)
                sayi++;
            if (K29a != 0 && K29b != 0)
                sayi++;
            if (K37a != 0 && K37b != 0)
                sayi++;
            if (K38a != 0 && K38b != 0)
                sayi++;
            if (K39a != 0 && K39b != 0)
                sayi++;






            if
                (B7a != 0 && B7b != 0 &&
                 B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
            {
               // 3 yıllık veri
                if (sayi == 1)
                    puan = Cizim1(B9a, Bolum4Max,Bolum4Min, B9b);


                if (sayi == 2)
                    puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 1) + Bolum4Min), B9b);
                else
                    if (sayi == 3)
                        puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 2) + Bolum4Min), B9b);
                    else
                        if (sayi == 4)
                            puan = Cizim1(B9a, Bolum5Max, Bolum5Min, B9b);
                        else
                            if (sayi == 5)
                                puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 1) + Bolum5Min), B9b);
                            else
                                if (sayi == 6)
                                    puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 2) + Bolum5Min), B9b);
                                else
                                    if (sayi == 7)
                                        puan = Cizim1(B9a, (Bolum6Max - ((int)(((Bolum6Max - Bolum6Min) / 10) * 8))), Bolum6Min, B9b);
                                    else
                                        if (sayi == 8)
                                            puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 1) + Bolum6Min), B9b);
                                        else
                                            if (sayi == 9)
                                                puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 2) + Bolum6Min), B9b);
                int buyuk;
                
                if (sayi > 7)
                {
                    buyuk = K19b;

                    buyuk = (buyuk < K29b) ? (K29b > K39b ? K29b : K39b) : (buyuk < K39b ? K39b : buyuk);


                    if(buyuk > B9b)
                    {
                        puan = puan - 1;
                    }


                }





            }
            else
                if (B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
                {
                    // 2 yıllık 
                    puan = Cizim1(B9a, Bolum3Max, Bolum3Min, B9b);
                }
                else if (B9a != 0 && B9b != 0)
                {
                    // 1 yıllık 
                    puan = Cizim1(B9a,Bolum2Max ,Bolum2Min, B9b);
                }
                else 
                {
                    puan = 1;
                }


            MessageBox.Show("Aldığınız Puan \n" + puan);


        }
        void OdulSayisi(int B7a, int B7b, int B8a, int B8b, int B9a, int B9b, int K17a, int K17b, int K18a, int K18b, int K19a, int K19b, int K27a, int K27b, int K28a, int K28b, int K29a, int K29b, int K37a, int K37b, int K38a, int K38b, int K39a, int K39b)
        {

            int Bolum1Max = 5;
            int Bolum1Min = 0;

            int Bolum2Max = 12;
            int Bolum2Min = 6;

            int Bolum3Max = 19;
            int Bolum3Min = 13;

            int Bolum4Max = 27;
            int Bolum4Min = 20;

            int Bolum5Max = 37;
            int Bolum5Min = 28;

            int Bolum6Max = 50;
            int Bolum6Min = 38;





            int puan = 0;

            int sayi = 0;
            if (K17a != 0 && K17b != 0)
                sayi++;
            if (K18a != 0 && K18b != 0)
                sayi++;
            if (K19a != 0 && K19b != 0)
                sayi++;
            if (K27a != 0 && K27b != 0)
                sayi++;
            if (K28a != 0 && K28b != 0)
                sayi++;
            if (K29a != 0 && K29b != 0)
                sayi++;
            if (K37a != 0 && K37b != 0)
                sayi++;
            if (K38a != 0 && K38b != 0)
                sayi++;
            if (K39a != 0 && K39b != 0)
                sayi++;






            if
                (B7a != 0 && B7b != 0 &&
                 B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
            {
                // 3 yıllık veri
                if (sayi == 1)
                    puan = Cizim1(B9a, Bolum4Max, Bolum4Min, B9b);


                if (sayi == 2)
                    puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 1) + Bolum4Min), B9b);
                else
                    if (sayi == 3)
                        puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 2) + Bolum4Min), B9b);
                    else
                        if (sayi == 4)
                            puan = Cizim1(B9a, Bolum5Max, Bolum5Min, B9b);
                        else
                            if (sayi == 5)
                                puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 1) + Bolum5Min), B9b);
                            else
                                if (sayi == 6)
                                    puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 2) + Bolum5Min), B9b);
                                else
                                    if (sayi == 7)
                                        puan = Cizim1(B9a, (Bolum6Max - ((int)(((Bolum6Max - Bolum6Min) / 10) * 8))), Bolum6Min, B9b);
                                    else
                                        if (sayi == 8)
                                            puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 1) + Bolum6Min), B9b);
                                        else
                                            if (sayi == 9)
                                                puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 2) + Bolum6Min), B9b);
                int buyuk;

                if (sayi > 7)
                {
                    buyuk = K19b;

                    buyuk = (buyuk < K29b) ? (K29b > K39b ? K29b : K39b) : (buyuk < K39b ? K39b : buyuk);


                    if (buyuk > B9b)
                    {
                        puan = puan - 1;
                    }


                }





            }
            else
                if (B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
                {
                    // 2 yıllık 
                    puan = Cizim1(B9a, Bolum3Max, Bolum3Min, B9b);
                }
                else if (B9a != 0 && B9b != 0)
                {
                    // 1 yıllık 
                    puan = Cizim1(B9a, Bolum2Max, Bolum2Min, B9b);
                }
                else
                {
                    puan = 1;
                }


            MessageBox.Show("Aldığınız Puan \n" + puan);


        }
        void TaktirTanima(int B7a, int B7b, int B8a, int B8b, int B9a, int B9b, int K17a, int K17b, int K18a, int K18b, int K19a, int K19b, int K27a, int K27b, int K28a, int K28b, int K29a, int K29b, int K37a, int K37b, int K38a, int K38b, int K39a, int K39b)
        {

            int Bolum1Max = 8;
            int Bolum1Min = 0;

            int Bolum2Max = 20;
            int Bolum2Min = 9;

            int Bolum3Max = 32;
            int Bolum3Min = 21;

            int Bolum4Max = 44;
            int Bolum4Min = 33;

            int Bolum5Max = 60;
            int Bolum5Min = 45;

            int Bolum6Max = 80;
            int Bolum6Min = 61;





            int puan = 0;

            int sayi = 0;
            if (K17a != 0 && K17b != 0)
                sayi++;
            if (K18a != 0 && K18b != 0)
                sayi++;
            if (K19a != 0 && K19b != 0)
                sayi++;
            if (K27a != 0 && K27b != 0)
                sayi++;
            if (K28a != 0 && K28b != 0)
                sayi++;
            if (K29a != 0 && K29b != 0)
                sayi++;
            if (K37a != 0 && K37b != 0)
                sayi++;
            if (K38a != 0 && K38b != 0)
                sayi++;
            if (K39a != 0 && K39b != 0)
                sayi++;



            if
                (B7a != 0 && B7b != 0 &&
                 B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
            {
                // 3 yıllık veri
                if (sayi == 1)
                    puan = Cizim1(B9a, Bolum4Max, Bolum4Min, B9b);


                if (sayi == 2)
                    puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 1) + Bolum4Min), B9b);
                else
                    if (sayi == 3)
                        puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 2) + Bolum4Min), B9b);
                    else
                        if (sayi == 4)
                            puan = Cizim1(B9a, Bolum5Max, Bolum5Min, B9b);
                        else
                            if (sayi == 5)
                                puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 1) + Bolum5Min), B9b);
                            else
                                if (sayi == 6)
                                    puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 2) + Bolum5Min), B9b);
                                else
                                    if (sayi == 7)
                                        puan = Cizim1(B9a, (Bolum6Max - ((int)(((Bolum6Max - Bolum6Min) / 10) * 8))), Bolum6Min, B9b);
                                    else
                                        if (sayi == 8)
                                            puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 1) + Bolum6Min), B9b);
                                        else
                                            if (sayi == 9)
                                                puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 2) + Bolum6Min), B9b);
                int buyuk;

                if (sayi > 7)
                {
                    buyuk = K19b;

                    buyuk = (buyuk < K29b) ? (K29b > K39b ? K29b : K39b) : (buyuk < K39b ? K39b : buyuk);


                    if (buyuk > B9b)
                    {
                        puan = puan - 1;
                    }


                }





            }
            else
                if (B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
                {
                    // 2 yıllık 
                    puan = Cizim1(B9a, Bolum3Max, Bolum3Min, B9b);
                }
                else if (B9a != 0 && B9b != 0)
                {
                    // 1 yıllık 
                    puan = Cizim1(B9a, Bolum2Max, Bolum2Min, B9b);
                }
                else
                {
                    puan = 1;
                }


            MessageBox.Show("Aldığınız Puan \n" + puan);


        }
        void Memnuniyet(int B7a, int B7b, int B8a, int B8b, int B9a, int B9b, int K17a, int K17b, int K18a, int K18b, int K19a, int K19b, int K27a, int K27b, int K28a, int K28b, int K29a, int K29b, int K37a, int K37b, int K38a, int K38b, int K39a, int K39b)
        {

            int Bolum1Max = 4;
            int Bolum1Min = 0;

            int Bolum2Max = 10;
            int Bolum2Min = 5;

            int Bolum3Max = 16;
            int Bolum3Min = 11;

            int Bolum4Max = 22;
            int Bolum4Min = 17;

            int Bolum5Max = 30;
            int Bolum5Min = 23;

            int Bolum6Max = 40;
            int Bolum6Min = 31;





            int puan = 0;

            int sayi = 0;
            if (K17a != 0 && K17b != 0)
                sayi++;
            if (K18a != 0 && K18b != 0)
                sayi++;
            if (K19a != 0 && K19b != 0)
                sayi++;
            if (K27a != 0 && K27b != 0)
                sayi++;
            if (K28a != 0 && K28b != 0)
                sayi++;
            if (K29a != 0 && K29b != 0)
                sayi++;
            if (K37a != 0 && K37b != 0)
                sayi++;
            if (K38a != 0 && K38b != 0)
                sayi++;
            if (K39a != 0 && K39b != 0)
                sayi++;






            if
                (B7a != 0 && B7b != 0 &&
                 B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
            {
                // 3 yıllık veri
                if (sayi == 1)
                    puan = Cizim1(B9a, Bolum4Max, Bolum4Min, B9b);


                if (sayi == 2)
                    puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 1) + Bolum4Min), B9b);
                else
                    if (sayi == 3)
                        puan = Cizim1(B9a, Bolum4Max, (int)((((Bolum4Max - Bolum4Min) / 3) * 2) + Bolum4Min), B9b);
                    else
                        if (sayi == 4)
                            puan = Cizim1(B9a, Bolum5Max, Bolum5Min, B9b);
                        else
                            if (sayi == 5)
                                puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 1) + Bolum5Min), B9b);
                            else
                                if (sayi == 6)
                                    puan = Cizim1(B9a, Bolum5Max, (int)((((Bolum5Max - Bolum5Min) / 3) * 2) + Bolum5Min), B9b);
                                else
                                    if (sayi == 7)
                                        puan = Cizim1(B9a, (Bolum6Max - ((int)(((Bolum6Max - Bolum6Min) / 10) * 8))), Bolum6Min, B9b);
                                    else
                                        if (sayi == 8)
                                            puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 1) + Bolum6Min), B9b);
                                        else
                                            if (sayi == 9)
                                                puan = Cizim1(B9a, Bolum6Max, (int)((((Bolum6Max - Bolum6Min) / 3) * 2) + Bolum6Min), B9b);
                int buyuk;

                if (sayi > 7)
                {
                    buyuk = K19b;

                    buyuk = (buyuk < K29b) ? (K29b > K39b ? K29b : K39b) : (buyuk < K39b ? K39b : buyuk);


                    if (buyuk > B9b)
                    {
                        puan = puan - 1;
                    }


                }





            }
            else
                if (B8a != 0 && B8b != 0 &&
                 B9a != 0 && B9b != 0)
                {
                    // 2 yıllık 
                    puan = Cizim1(B9a, Bolum3Max, Bolum3Min, B9b);
                }
                else if (B9a != 0 && B9b != 0)
                {
                    // 1 yıllık 
                    puan = Cizim1(B9a, Bolum2Max, Bolum2Min, B9b);
                }
                else
                {
                    puan = 1;
                }


            MessageBox.Show("Aldığınız Puan \n" + puan);


        }
        int Cizim1(int Hedef,int MaxPuan,int MinPuan,int Gerceklesen)
        {
            float i = Hedef / 4f;
            float Q = MaxPuan / 4f;
            int Puan = 0;

            switch (Gerceklesen / (int)i)
            { 
                case 1:
                    Puan = (int)Q;
                    break;

                case 2:
                    Puan = (int)(Q * 2);
                    break;

                case 3:
                    Puan = (int)(Q * 3);
                    break;

                case 4:
                    Puan = (int)(Q*4);
                    break;

                case 5:
                    Puan = (int)(Q*4);
                    break;

                case 6:
                    Puan = (int)(Q*3);
                    break;

                case 7:
                    Puan = (int)(Q*2);
                    break;

                case 8:
                    Puan = (int)Q;
                    break;

                default:
                    Puan = MinPuan;
                    break;
            
            }

            Puan = (Puan < MinPuan) ? MinPuan : Puan;

            return Puan;

        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                HizmetIciEgitim(int.Parse(B7a.Text==""?"0":B7a.Text), int.Parse(B7b.Text==""?"0":B7b.Text), int.Parse(B8a.Text==""?"0":B8a.Text), int.Parse(B8b.Text==""?"0":B8b.Text), int.Parse(B9a.Text==""?"0":B9a.Text), int.Parse(B9b.Text==""?"0":B9b.Text), int.Parse(K17a.Text==""?"0":K17a.Text), int.Parse(K17b.Text==""?"0":K17b.Text), int.Parse(K18a.Text==""?"0":K18a.Text), int.Parse(K18b.Text==""?"0":K18b.Text), int.Parse(K19a.Text==""?"0":K19a.Text), int.Parse(K19b.Text==""?"0":K19b.Text), int.Parse(K27a.Text==""?"0":K27a.Text), int.Parse(K27b.Text==""?"0":K27b.Text), int.Parse(K28a.Text==""?"0":K28a.Text), int.Parse(K28b.Text==""?"0":K28b.Text), int.Parse(K29a.Text==""?"0":K29a.Text), int.Parse(K29b.Text==""?"0":K29b.Text), int.Parse(K37a.Text==""?"0":K37a.Text), int.Parse(K37b.Text==""?"0":K37b.Text), int.Parse(K38a.Text==""?"0":K38a.Text), int.Parse(K38b.Text==""?"0":K38b.Text), int.Parse(K39a.Text==""?"0":K39a.Text), int.Parse(K39b.Text==""?"0":K39b.Text));

            }
            else if(radioButton2.Checked)
            {
                OdulSayisi(int.Parse(B7a.Text == "" ? "0" : B7a.Text), int.Parse(B7b.Text == "" ? "0" : B7b.Text), int.Parse(B8a.Text == "" ? "0" : B8a.Text), int.Parse(B8b.Text == "" ? "0" : B8b.Text), int.Parse(B9a.Text == "" ? "0" : B9a.Text), int.Parse(B9b.Text == "" ? "0" : B9b.Text), int.Parse(K17a.Text == "" ? "0" : K17a.Text), int.Parse(K17b.Text == "" ? "0" : K17b.Text), int.Parse(K18a.Text == "" ? "0" : K18a.Text), int.Parse(K18b.Text == "" ? "0" : K18b.Text), int.Parse(K19a.Text == "" ? "0" : K19a.Text), int.Parse(K19b.Text == "" ? "0" : K19b.Text), int.Parse(K27a.Text == "" ? "0" : K27a.Text), int.Parse(K27b.Text == "" ? "0" : K27b.Text), int.Parse(K28a.Text == "" ? "0" : K28a.Text), int.Parse(K28b.Text == "" ? "0" : K28b.Text), int.Parse(K29a.Text == "" ? "0" : K29a.Text), int.Parse(K29b.Text == "" ? "0" : K29b.Text), int.Parse(K37a.Text == "" ? "0" : K37a.Text), int.Parse(K37b.Text == "" ? "0" : K37b.Text), int.Parse(K38a.Text == "" ? "0" : K38a.Text), int.Parse(K38b.Text == "" ? "0" : K38b.Text), int.Parse(K39a.Text == "" ? "0" : K39a.Text), int.Parse(K39b.Text == "" ? "0" : K39b.Text));
            
            }
            else if (radioButton3.Checked)
            {
            TaktirTanima(int.Parse(B7a.Text==""?"0":B7a.Text), int.Parse(B7b.Text==""?"0":B7b.Text), int.Parse(B8a.Text==""?"0":B8a.Text), int.Parse(B8b.Text==""?"0":B8b.Text), int.Parse(B9a.Text==""?"0":B9a.Text), int.Parse(B9b.Text==""?"0":B9b.Text), int.Parse(K17a.Text==""?"0":K17a.Text), int.Parse(K17b.Text==""?"0":K17b.Text), int.Parse(K18a.Text==""?"0":K18a.Text), int.Parse(K18b.Text==""?"0":K18b.Text), int.Parse(K19a.Text==""?"0":K19a.Text), int.Parse(K19b.Text==""?"0":K19b.Text), int.Parse(K27a.Text==""?"0":K27a.Text), int.Parse(K27b.Text==""?"0":K27b.Text), int.Parse(K28a.Text==""?"0":K28a.Text), int.Parse(K28b.Text==""?"0":K28b.Text), int.Parse(K29a.Text==""?"0":K29a.Text), int.Parse(K29b.Text==""?"0":K29b.Text), int.Parse(K37a.Text==""?"0":K37a.Text), int.Parse(K37b.Text==""?"0":K37b.Text), int.Parse(K38a.Text==""?"0":K38a.Text), int.Parse(K38b.Text==""?"0":K38b.Text), int.Parse(K39a.Text==""?"0":K39a.Text), int.Parse(K39b.Text==""?"0":K39b.Text));
            }
            else if (radioButton4.Checked)
            {
                Memnuniyet(int.Parse(B7a.Text == "" ? "0" : B7a.Text), int.Parse(B7b.Text == "" ? "0" : B7b.Text), int.Parse(B8a.Text == "" ? "0" : B8a.Text), int.Parse(B8b.Text == "" ? "0" : B8b.Text), int.Parse(B9a.Text == "" ? "0" : B9a.Text), int.Parse(B9b.Text == "" ? "0" : B9b.Text), int.Parse(K17a.Text == "" ? "0" : K17a.Text), int.Parse(K17b.Text == "" ? "0" : K17b.Text), int.Parse(K18a.Text == "" ? "0" : K18a.Text), int.Parse(K18b.Text == "" ? "0" : K18b.Text), int.Parse(K19a.Text == "" ? "0" : K19a.Text), int.Parse(K19b.Text == "" ? "0" : K19b.Text), int.Parse(K27a.Text == "" ? "0" : K27a.Text), int.Parse(K27b.Text == "" ? "0" : K27b.Text), int.Parse(K28a.Text == "" ? "0" : K28a.Text), int.Parse(K28b.Text == "" ? "0" : K28b.Text), int.Parse(K29a.Text == "" ? "0" : K29a.Text), int.Parse(K29b.Text == "" ? "0" : K29b.Text), int.Parse(K37a.Text == "" ? "0" : K37a.Text), int.Parse(K37b.Text == "" ? "0" : K37b.Text), int.Parse(K38a.Text == "" ? "0" : K38a.Text), int.Parse(K38b.Text == "" ? "0" : K38b.Text), int.Parse(K39a.Text == "" ? "0" : K39a.Text), int.Parse(K39b.Text == "" ? "0" : K39b.Text));
            }
        }



    }
}

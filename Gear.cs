using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Legends_Tools
{
    public partial class Gear : Form
    {
        public Gear()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void setValues(int[] arr)
        {
            lM1L1.Text = arr[0].ToString();
            lM1L2.Text = arr[1].ToString();
            lM1L3.Text = arr[2].ToString();
            lM2L1.Text = arr[3].ToString();
            lM2L2.Text = arr[4].ToString();
            lM2L3.Text = arr[5].ToString();
            lM3L1.Text = arr[6].ToString();
            lM3L2.Text = arr[7].ToString();
            lM3L3.Text = arr[8].ToString();
            lM4L1.Text = arr[9].ToString();
            lM4L2.Text = arr[10].ToString();
            lM4L3.Text = arr[11].ToString();
            L_Essence.Text = arr[12].ToString();
        }
        public void setValuesTotal(int[] arr)
        {
            lt11.Text = arr[0].ToString();
            lt12.Text = arr[1].ToString();
            lt13.Text = arr[2].ToString();
            lt21.Text = arr[3].ToString();
            lt22.Text = arr[4].ToString();
            lt23.Text = arr[5].ToString();
            lt31.Text = arr[6].ToString();
            lt32.Text = arr[7].ToString();
            lt33.Text = arr[8].ToString();
            lt41.Text = arr[9].ToString();
            lt42.Text = arr[10].ToString();
            lt43.Text = arr[11].ToString();
            ltessence.Text = arr[12].ToString();

        }
        public int[] getValuesCurrent()
        {
            int[] arr = new int[]
            {
                Int32.Parse( lM1L1.Text),
                Int32.Parse( lM1L2.Text),
                Int32.Parse( lM1L3.Text),
                Int32.Parse( lM2L1.Text),
                Int32.Parse( lM2L2.Text),
                Int32.Parse( lM2L3.Text),
                Int32.Parse( lM3L1.Text),
                Int32.Parse( lM3L2.Text),
                Int32.Parse( lM3L3.Text),
                Int32.Parse( lM4L1.Text),
                Int32.Parse( lM4L2.Text),
                Int32.Parse( lM4L3.Text),
                Int32.Parse( L_Essence.Text)
            };
            return arr;
        }
        public int[] getValuesTotal()
        {
            int[] arr = new int[]
            {
                Int32.Parse( lt11.Text),
                Int32.Parse( lt12.Text),
                Int32.Parse( lt13.Text),
                Int32.Parse( lt21.Text),
                Int32.Parse( lt22.Text),
                Int32.Parse( lt23.Text),
                Int32.Parse( lt31.Text),
                Int32.Parse( lt32.Text),
                Int32.Parse( lt33.Text),
                Int32.Parse( lt41.Text),
                Int32.Parse( lt42.Text),
                Int32.Parse( lt43.Text),
                Int32.Parse( ltessence.Text)
            };
            return arr;
        }
        public int[] AddToTotal()
        {
            int [] arrCurrent= getValuesCurrent();
            int [] arrTotal = getValuesTotal();
            for(int i = 0; i < 13; i++)
            {
                arrTotal[i] += arrCurrent[i];
            }
            return arrTotal;
        }
        private void GearMaterials(int Start1,int Start2, int Start3, int Start4,int Start5, int Start6,int End1,int End2,int End3,int End4,int End5,int End6)
        {
            int[][] jaggedArray = new int[][]
                {
                new int[] { Start1, End1 },
                new int[] { Start2, End2 },
                new int[] { Start3, End3 },
                new int[] { Start4, End4 },
                new int[] { Start5, End5 },
                new int[] { Start6, End6 }
                };

            int[][] MaterialSlot1 = new int[11][];
            int[][] MaterialSlot2 = new int[11][];
            int[][] MaterialSlot3 = new int[11][];
            int[][] MaterialSlot4 = new int[11][];
            int[][] MaterialSlot5 = new int[11][];
            int[][] MaterialSlot6 = new int[11][];
            int Mat1Lv1 = 0; int Mat1Lv2 = 0; int Mat1Lv3 = 0;
            int Mat2Lv1 = 0; int Mat2Lv2 = 0; int Mat2Lv3 = 0;
            int Mat3Lv1 = 0; int Mat3Lv2 = 0; int Mat3Lv3 = 0;
            int Mat4Lv1 = 0; int Mat4Lv2 = 0; int Mat4Lv3 = 0;
            int Essence = 0;


            MaterialSlot1[0] = new int[] {  2,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  200 };
            MaterialSlot2[0] = new int[] {  0,  0,  0,  2,  0,  0,  0,  0,  0,  0,  0,  0,  200 };
            MaterialSlot3[0] = new int[] {  0,  0,  0,  0,  0,  0,  2,  0,  0,  0,  0,  0,  200 };
            MaterialSlot4[0] = new int[] {  0,  0,  0,  0,  0,  0,  0,  0,  0,  2,  0,  0,  200 };
            MaterialSlot5[0] = new int[] {  2,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  200 };
            MaterialSlot6[0] = new int[] {  0,  0,  0,  0,  0,  0,  0,  0,  0,  2,  0,  0,  200 };

            MaterialSlot1[1] = new int[] {  4,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  500 };            
            MaterialSlot2[1] = new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 500 };

            MaterialSlot1[2] = new int[] { 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000 };
            MaterialSlot2[2] = new int[] { 0, 0, 0, 6, 4, 0, 0, 0, 0, 0, 0, 0, 1000 };

            MaterialSlot1[3] = new int[] { 8, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3000 };
            MaterialSlot2[3] = new int[] { 0, 0, 0, 8, 6, 0, 0, 0, 0, 0, 0, 0, 3000 };

            MaterialSlot1[4] = new int[] {  10, 8,  6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6000 };
            MaterialSlot2[4] = new int[] {  0,  0,  0, 10, 8, 6, 0, 0, 0, 0, 0, 0, 6000 };
            MaterialSlot3[4] = new int[] {  0,  0,  0, 0, 0, 0, 10, 8, 0, 0, 0, 6, 6000 };
            MaterialSlot4[4] = new int[] {  0,  0,  0, 0, 0, 0, 0, 0, 0, 10, 8, 6, 6000 };
            MaterialSlot5[4] = new int[] {  10, 0,  0, 0, 8, 0, 0, 0, 6, 0, 0, 0, 6000 };
            MaterialSlot6[4] = new int[] {  0,  0,  0, 0, 0, 6, 0, 8, 0, 10, 0, 0, 6000 };

            MaterialSlot1[5] = new int[] { 12, 10, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10000 };
            MaterialSlot2[5] = new int[] { 0, 0, 0, 12, 10, 8, 0, 0, 0, 0, 0, 0, 10000 };

            MaterialSlot1[6] = new int[] { 14, 12, 10, 5, 0, 0, 0, 0, 0, 0, 0, 0, 15000 };
            MaterialSlot2[6] = new int[] { 0, 0, 0, 14, 12, 10, 5, 0, 0, 0, 0, 0, 15000 };

            MaterialSlot1[7] = new int[] { 16, 14, 12, 5, 0, 0, 0, 0, 0, 0, 10, 0, 21000 };
            MaterialSlot2[7] = new int[] { 0, 0, 0, 16, 14, 12, 5, 0, 0, 0, 10, 0, 21000 };

            MaterialSlot1[8] = new int[] { 18, 16, 14, 10, 0, 0, 0, 0, 0, 0, 15, 0, 30000 };
            MaterialSlot2[8] = new int[] { 0, 0, 0, 18, 16, 14, 10, 0, 0, 0, 15, 0, 30000 };

            MaterialSlot1[9] = new int[] { 20, 18, 16, 10, 0, 0, 0, 0, 0, 0, 0, 20, 45000 };
            MaterialSlot2[9] = new int[] { 0, 0, 0, 20, 18, 16, 10, 0, 0, 0, 0, 20, 45000 };

            MaterialSlot1[10] = new int[] { 40, 50, 30, 0, 0, 55, 0, 0, 0, 0, 45, 0, 70000 };
            MaterialSlot2[10] = new int[] { 0, 0, 0, 40, 50, 30, 0, 0, 55, 0, 45, 0, 70000 };

            
            MaterialSlot3[1] = new int[] { 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 500 };
            MaterialSlot3[2] = new int[] { 0, 0, 0, 0, 0, 0, 6, 4, 0, 0, 0, 0, 1000 };
            MaterialSlot3[3] = new int[] { 0, 0, 0, 0, 0, 0, 8, 6, 0, 0, 0, 0, 3000 };
            MaterialSlot3[5] = new int[] { 0, 0, 0, 0, 0, 0, 12, 10, 0, 0, 0, 8, 10000 };
            MaterialSlot3[6] = new int[] { 0, 0, 0, 5, 0, 0, 14, 12, 0, 0, 0, 10, 15000 };
            MaterialSlot3[7] = new int[] { 0, 10, 0, 5, 0, 0, 16, 14, 0, 0, 0, 12, 21000 };
            MaterialSlot3[8] = new int[] { 0, 15, 0, 10, 0, 0, 18, 16, 0, 0, 0, 14, 30000 };
            MaterialSlot3[9] = new int[] { 0, 0, 20, 10, 0, 0, 20, 18, 0, 0, 0, 16, 45000 };
            MaterialSlot3[10] = new int[] { 0, 45, 0, 0, 0, 55, 40, 0, 30, 0, 50, 0, 70000 };


            MaterialSlot4[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 500 };
            MaterialSlot4[2] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 4, 0, 1000 };
            MaterialSlot4[3] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 6, 0, 3000 };
            MaterialSlot4[5] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 12, 10, 8, 10000 };
            MaterialSlot4[6] = new int[] { 0, 0, 0, 0, 0, 0, 5, 0, 0, 14, 12, 10, 15000 };
            MaterialSlot4[7] = new int[] { 0, 10, 0, 0, 0, 0, 5, 0, 0, 16, 14, 12, 21000 };
            MaterialSlot4[8] = new int[] { 0, 15, 0, 0, 0, 0, 10, 0, 0, 18, 16, 14, 30000 };
            MaterialSlot4[9] = new int[] { 0, 0, 20, 0, 0, 0, 10, 0, 0, 20, 18, 16, 45000 };
            MaterialSlot4[10] = new int[] { 0, 45, 0, 0, 0, 0, 0, 0, 55, 40, 50, 30, 70000 };

           
            MaterialSlot5[1] = new int[] { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 500 };
            MaterialSlot5[2] = new int[] { 6, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 1000 };
            MaterialSlot5[3] = new int[] { 8, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 3000 };
            MaterialSlot5[5] = new int[] { 12, 0, 0, 0, 10, 0, 0, 0, 8, 0, 0, 0, 10000 };
            MaterialSlot5[6] = new int[] { 14, 0, 0, 5, 12, 0, 0, 0, 10, 0, 0, 0, 15000 };
            MaterialSlot5[7] = new int[] { 16, 10, 0, 5, 14, 0, 0, 0, 12, 0, 0, 0, 21000 };
            MaterialSlot5[8] = new int[] { 18, 15, 0, 10, 16, 0, 0, 0, 14, 0, 0, 0, 30000 };
            MaterialSlot5[9] = new int[] { 20, 0, 20, 10, 18, 0, 0, 0, 16, 0, 0, 0, 45000 };
            MaterialSlot5[10] = new int[] { 0, 45, 30, 40, 0, 55, 0, 50, 0, 0, 0, 0, 70000 };

            
            MaterialSlot6[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 500 };
            MaterialSlot6[2] = new int[] { 0, 0, 0, 0, 0, 0, 0, 4, 0, 6, 0, 0, 1000 };
            MaterialSlot6[3] = new int[] { 0, 0, 0, 0, 0, 0, 0, 6, 0, 8, 0, 0, 3000 };
            MaterialSlot6[5] = new int[] { 0, 0, 0, 0, 0, 8, 0, 10, 0, 12, 0, 0, 10000 };
            MaterialSlot6[6] = new int[] { 0, 0, 0, 0, 0, 10, 5, 12, 0, 14, 0, 0, 15000 };
            MaterialSlot6[7] = new int[] { 0, 0, 0, 0, 0, 12, 5, 14, 0, 16, 10, 0, 21000 };
            MaterialSlot6[8] = new int[] { 0, 0, 0, 0, 0, 14, 10, 16, 0, 18, 15, 0, 30000 };
            MaterialSlot6[9] = new int[] { 0, 0, 0, 0, 0, 16, 10, 18, 0, 20, 0, 20, 45000 };
            MaterialSlot6[10] = new int[] { 0, 0, 0, 0, 50, 0, 40, 0, 55, 0, 45, 30, 70000 };
            int a,b = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                a = jaggedArray[i][0];
                b = jaggedArray[i][1];
                while ( a< b)
                {
                    if (i == 0)
                    {
                        Mat1Lv1 += MaterialSlot1[a][0];
                        Mat1Lv2 += MaterialSlot1[a][1];
                        Mat1Lv3 += MaterialSlot1[a][2];

                        Mat2Lv1 += MaterialSlot1[a][3];
                        Mat2Lv2 += MaterialSlot1[a][4];
                        Mat2Lv3 += MaterialSlot1[a][5];

                        Mat3Lv1 += MaterialSlot1[a][6];
                        Mat3Lv2 += MaterialSlot1[a][7];
                        Mat3Lv3 += MaterialSlot1[a][8];

                        Mat4Lv1 += MaterialSlot1[a][9];
                        Mat4Lv2 += MaterialSlot1[a][10];
                        Mat4Lv3 += MaterialSlot1[a][11];

                        Essence += MaterialSlot1[a][12];

                    }
                    if (i == 1)
                    {
                        Mat1Lv1 += MaterialSlot2[a][0];
                        Mat1Lv2 += MaterialSlot2[a][1];
                        Mat1Lv3 += MaterialSlot2[a][2];

                        Mat2Lv1 += MaterialSlot2[a][3];
                        Mat2Lv2 += MaterialSlot2[a][4];
                        Mat2Lv3 += MaterialSlot2[a][5];

                        Mat3Lv1 += MaterialSlot2[a][6];
                        Mat3Lv2 += MaterialSlot2[a][7];
                        Mat3Lv3 += MaterialSlot2[a][8];

                        Mat4Lv1 += MaterialSlot2[a][9];
                        Mat4Lv2 += MaterialSlot2[a][10];
                        Mat4Lv3 += MaterialSlot2[a][11];

                        Essence += MaterialSlot2[a][12];

                    }
                    if (i == 2)
                    {
                        Mat1Lv1 += MaterialSlot3[a][0];
                        Mat1Lv2 += MaterialSlot3[a][1];
                        Mat1Lv3 += MaterialSlot3[a][2];

                        Mat2Lv1 += MaterialSlot3[a][3];
                        Mat2Lv2 += MaterialSlot3[a][4];
                        Mat2Lv3 += MaterialSlot3[a][5];

                        Mat3Lv1 += MaterialSlot3[a][6];
                        Mat3Lv2 += MaterialSlot3[a][7];
                        Mat3Lv3 += MaterialSlot3[a][8];

                        Mat4Lv1 += MaterialSlot3[a][9];
                        Mat4Lv2 += MaterialSlot3[a][10];
                        Mat4Lv3 += MaterialSlot3[a][11];

                        Essence += MaterialSlot3[a][12];

                    }
                    if (i == 3)
                    {
                        Mat1Lv1 += MaterialSlot4[a][0];
                        Mat1Lv2 += MaterialSlot4[a][1];
                        Mat1Lv3 += MaterialSlot4[a][2];

                        Mat2Lv1 += MaterialSlot4[a][3];
                        Mat2Lv2 += MaterialSlot4[a][4];
                        Mat2Lv3 += MaterialSlot4[a][5];

                        Mat3Lv1 += MaterialSlot4[a][6];
                        Mat3Lv2 += MaterialSlot4[a][7];
                        Mat3Lv3 += MaterialSlot4[a][8];

                        Mat4Lv1 += MaterialSlot4[a][9];
                        Mat4Lv2 += MaterialSlot4[a][10];
                        Mat4Lv3 += MaterialSlot4[a][11];

                        Essence += MaterialSlot4[a][12];

                    }
                    if (i == 4)
                    {
                        Mat1Lv1 += MaterialSlot5[a][0];
                        Mat1Lv2 += MaterialSlot5[a][1];
                        Mat1Lv3 += MaterialSlot5[a][2];

                        Mat2Lv1 += MaterialSlot5[a][3];
                        Mat2Lv2 += MaterialSlot5[a][4];
                        Mat2Lv3 += MaterialSlot5[a][5];

                        Mat3Lv1 += MaterialSlot5[a][6];
                        Mat3Lv2 += MaterialSlot5[a][7];
                        Mat3Lv3 += MaterialSlot5[a][8];

                        Mat4Lv1 += MaterialSlot5[a][9];
                        Mat4Lv2 += MaterialSlot5[a][10];
                        Mat4Lv3 += MaterialSlot5[a][11];

                        Essence += MaterialSlot5[a][12];

                    }
                    if (i == 5)
                    {
                        Mat1Lv1 += MaterialSlot6[a][0];
                        Mat1Lv2 += MaterialSlot6[a][1];
                        Mat1Lv3 += MaterialSlot6[a][2];

                        Mat2Lv1 += MaterialSlot6[a][3];
                        Mat2Lv2 += MaterialSlot6[a][4];
                        Mat2Lv3 += MaterialSlot6[a][5];

                        Mat3Lv1 += MaterialSlot6[a][6];
                        Mat3Lv2 += MaterialSlot6[a][7];
                        Mat3Lv3 += MaterialSlot6[a][8];

                        Mat4Lv1 += MaterialSlot6[a][9];
                        Mat4Lv2 += MaterialSlot6[a][10];
                        Mat4Lv3 += MaterialSlot6[a][11];

                        Essence += MaterialSlot6[a][12];

                    }
                    a++;
                }
            }

            int[] array = { Mat1Lv1, Mat1Lv2, Mat1Lv3, Mat2Lv1, Mat2Lv2, Mat2Lv3, Mat3Lv1, Mat3Lv2, Mat3Lv3, Mat4Lv1, Mat4Lv2, Mat4Lv3, Essence };

            setValues( array);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GearMaterials((int)GearStart1.Value, (int)GearStart2.Value, (int)GearStart3.Value, (int)GearStart4.Value, (int)GearStart5.Value, (int)GearStart6.Value, (int)GearEnd1.Value, (int)GearEnd2.Value, (int)GearEnd3.Value, (int)GearEnd4.Value, (int)GearEnd5.Value, (int)GearEnd6.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GearStart1.Value = numericUpDown6.Value;
            GearStart2.Value = numericUpDown6.Value;
            GearStart3.Value = numericUpDown6.Value;
            GearStart4.Value = numericUpDown6.Value;
            GearStart5.Value = numericUpDown6.Value;
            GearStart6.Value = numericUpDown6.Value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GearEnd1.Value = numericUpDown7.Value;
            GearEnd2.Value = numericUpDown7.Value;
            GearEnd3.Value = numericUpDown7.Value;
            GearEnd4.Value = numericUpDown7.Value;
            GearEnd5.Value = numericUpDown7.Value;
            GearEnd6.Value = numericUpDown7.Value;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            setValuesTotal(AddToTotal());
        }
        private void button4_Click(object sender, EventArgs e)
        {

            lt11.Text = "0";
            lt12.Text = "0";
            lt13.Text = "0";
            lt21.Text = "0";
            lt22.Text = "0";
            lt23.Text = "0";
            lt31.Text = "0";
            lt32.Text = "0";
            lt33.Text = "0";
            lt41.Text = "0";
            lt42.Text = "0";
            lt43.Text = "0";
            ltessence.Text = "0";
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }
    }
}

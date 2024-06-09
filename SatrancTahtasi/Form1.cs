using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancTahtasi
{
    public partial class FrmSatrancTahtasi : Form
    {
        public FrmSatrancTahtasi()
        {
            InitializeComponent();
        }

        //Formu kaplayacak şekilde 1 panel oluşturdum.Panele çift tıkladım.Yazdığım kodlarla kareler kendiliğinden oluştu.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel Kare = new Panel();
                    Kare.Size = new Size(85, 85);
                    Kare.Location = new Point(i * 85, j * 85);

                    if ((i + j) % 2 == 0)
                    {
                        Kare.BackColor = Color.Black;
                    }
                    else
                    {
                        Kare.BackColor = Color.White;
                    }

                    panel1.Controls.Add(Kare);
                }

            }
        }
    }
}

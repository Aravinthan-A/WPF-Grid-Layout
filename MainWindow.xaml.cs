using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtcode1.Text == "B1")
            {
                B1Product();
            }
            if (txtcode2.Text == "N1")
            {
                N1product();
            }
            if (txtcode3.Text == "A1")
            {
                A1product(); 
            }
            if (txtcode4.Text == "T1")
            {
                T1product();
            }
            if (txtcode5.Text == "K1")
            {
                K1product();
            }
            if (txtcode6.Text == "P1")
            {
                P1product();
            }
            if (txtcode2.Text == "B1")
            {
                B2product();
            }
            if (txtcode3.Text == "B1")
            {
                B3product();
            }
            if (txtcode4.Text == "B1")
            {
                B4product();
            }
            if  (txtcode5.Text == "B1")
            {
                B5product();
            }
            if (txtcode6.Text == "B1")
            {
                B6product();    
            }
            if (txtcode1.Text == "N1")
            {
                N2product();
            }
            if (txtcode3.Text == "N1")
            {
                N3product();
            }
            if (txtcode4.Text == "N1")
            {
                N4product();
            }
            if (txtcode5.Text == "N1")
            {
                N5product();
            }
            if (txtcode6.Text == "N1")
            {
                N6product();
            }
            if (txtcode1.Text == "A1")
            {
                A2product();
            }
            if (txtcode2.Text == "A1")
            {
                A3product();
            }
            if (txtcode4.Text == "A1")
            {
                A4product();
            }
            if (txtcode5.Text == "A1")
            {
                A5product();
            }
            if (txtcode6.Text == "A1")
            {
                A6product();
            }
            if (txtcode1.Text == "T1")
            {
                T2product();
            }
            if (txtcode2.Text == "T1")
            {
                T3product();
            }
            if (txtcode3.Text == "T1")
            {
                T4product();
            }
            if (txtcode5.Text == "T1")
            {
                T5product();
            }
            if (txtcode6.Text == "T1")
            {
                T6product();
            }
            if (txtcode1.Text == "K1")
            {
                K2product();
            }
            if (txtcode2.Text == "K1")
            {
                K3product();
            }
            if (txtcode3.Text == "K1")
            {
                K4product();
            }
            if (txtcode4.Text == "K1")
            {
                K5product();
            }
            if (txtcode6.Text == "K1")
            {
                K6product();
            }
            if (txtcode1.Text == "P1")
            {
                P2product();
            }
            if (txtcode2.Text == "P1")
            {
                P3product();
            }
            if (txtcode3.Text == "P1")
            {
                P4product();
            }
            if (txtcode4.Text == "P1")
            {
                P5product();
            }
            if (txtcode5.Text == "P1")
            {
                P6product();
            }

        }
        private int B1Product()
        {
            txtname1.Text = "BAT";
            txtprice1.Text = "500";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 500 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int N1product()
        {
            txtname2.Text = "Net";
            txtprice2.Text = "300";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int A1product()
        {
            txtname3.Text = "BALL";
            txtprice3.Text = "200";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int T1product()
        {
            txtname4.Text = "Tshirt";
            txtprice4.Text = "400";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int K1product()
        {
            txtname5.Text = "KITS";
            txtprice5.Text = "1000";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
        private int P1product()
        {
            txtname6.Text = "PAD";
            txtprice6.Text = "800";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int B2product()
        {
            txtname2.Text = "BAT";
            txtprice2.Text = "500";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int B3product()
        {
            txtname3.Text = "BAT";
            txtprice3.Text = "500";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int B4product()
        {
            txtname4.Text = "BAT";
            txtprice4.Text = "500";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 500 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int B5product()
        {
            txtname5.Text = "BAT";
            txtprice5.Text = "500";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 500 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
        private int B6product()
        {
            txtname6.Text = "BAT";
            txtprice6.Text = "500";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 500 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int N2product()
        {
            txtname1.Text = "NET";
            txtprice1.Text = "300";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int N3product()
        {
            txtname3.Text = "NET";
            txtprice3.Text = "300";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int N4product()
        {
            txtname4.Text = "NET";
            txtprice4.Text = "300";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int N5product()
        {
            txtname5.Text = "NET";
            txtprice5.Text = "300";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
        private int N6product()
        {
            txtname6.Text = "NET";
            txtprice6.Text = "300";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 300 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int A2product()
        {
            txtname1.Text = "BALL";
            txtprice1.Text = "200";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int A3product()
        {
            txtname2.Text = "BALL";
            txtprice2.Text = "200";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int A4product()
        {
            txtname4.Text = "BALL";
            txtprice4.Text = "200";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int A5product()
        {
            txtname5.Text = "BALL";
            txtprice5.Text = "200";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
        private int A6product()
        {
            txtname6.Text = "BALL";
            txtprice6.Text = "200";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 200 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int T2product()
        {
            txtname1.Text = "Tshirt";
            txtprice1.Text = "400";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int T3product()
        {
            txtname2.Text = "Tshirt";
            txtprice2.Text = "400";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int T4product()
        {
            txtname3.Text = "Tshirt";
            txtprice3.Text = "400";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int T5product()
        {
            txtname5.Text = "Tshirt";
            txtprice5.Text = "400";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
        private int T6product()
        {
            txtname6.Text = "Tshirt";
            txtprice6.Text = "400";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 400 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int K2product()
        {
            txtname1.Text = "KITS";
            txtprice1.Text = "1000";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int K3product()
        {
            txtname2.Text = "KITS";
            txtprice2.Text = "1000";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int K4product()
        {
            txtname3.Text = "KITS";
            txtprice3.Text = "1000";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int K5product()
        {
            txtname4.Text = "KITS";
            txtprice4.Text = "1000";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int K6product()
        {
            txtname6.Text = "KITS";
            txtprice6.Text = "1000";

            int quantity = Convert.ToInt32(txtqun6.Text);
            int productprice = 1000 * quantity;


            int discount = Convert.ToInt32(txtdis6.Text);
            int totalprice = productprice - discount;
            txttotal6.Text = totalprice.ToString();

            return 0;
        }
        private int P2product()
        {
            txtname1.Text = "PAD";
            txtprice1.Text = "800";

            int quantity = Convert.ToInt32(txtqun1.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis1.Text);
            int totalprice = productprice - discount;
            txttotal1.Text = totalprice.ToString();

            return 0;
        }
        private int P3product()
        {
            txtname2.Text = "PAD";
            txtprice2.Text = "800";

            int quantity = Convert.ToInt32(txtqun2.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis2.Text);
            int totalprice = productprice - discount;
            txttotal2.Text = totalprice.ToString();

            return 0;
        }
        private int P4product()
        {
            txtname3.Text = "PAD";
            txtprice3.Text = "800";

            int quantity = Convert.ToInt32(txtqun3.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis3.Text);
            int totalprice = productprice - discount;
            txttotal3.Text = totalprice.ToString();

            return 0;
        }
        private int P5product()
        {
            txtname4.Text = "PAD";
            txtprice4.Text = "800";

            int quantity = Convert.ToInt32(txtqun4.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis4.Text);
            int totalprice = productprice - discount;
            txttotal4.Text = totalprice.ToString();

            return 0;
        }
        private int P6product()
        {
            txtname5.Text = "PAD";
            txtprice5.Text = "800";

            int quantity = Convert.ToInt32(txtqun5.Text);
            int productprice = 800 * quantity;


            int discount = Convert.ToInt32(txtdis5.Text);
            int totalprice = productprice - discount;
            txttotal5.Text = totalprice.ToString();

            return 0;
        }
    }
}


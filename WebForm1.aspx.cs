using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace swap_2_num
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2; //temp;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);

            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            num1 = num1 + num2;//1..10+30=40   20+10=30
            num2 = num1 - num2;//2..10-30=-20  20-30=10
            num1 = num1 - num2;//1..10-30=-20  

            TextBox3.Text = Convert.ToString(num1);
            TextBox4.Text = Convert.ToString(num2);
        }
    }
}
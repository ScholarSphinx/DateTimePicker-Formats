using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muahhahaha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Below is the different formats to be used in the datetimepicker when being used shown as the symbol - what the represent - an example or two of the outputs
            //Please be weary of caps sensitivity
            //d   - 	The one- or two-digit day.  Eg. 1 or 28
            //dd  -  	The two-digit day. Single-digit day values are preceded by a 0. Eg. 04 or 12
            //ddd -     The three - character day - of - week abbreviation.  Eg. Fri
            //dddd-  	The full day-of-week name. Eg. Wednesday
            //h   -     The one - or two - digit hour in 12 - hour format. Eg. 1 or 12
            //hh  - 	The two-digit hour in 12-hour format. Single digit values are preceded by a 0.  Eg. 01 or 12
            //H   - 	The one- or two-digit hour in 24-hour format. Eg 1 or 24
            //HH  - 	The two-digit hour in 24-hour format. Single digit values are preceded by a 0. Eg. 01 or 24
            //m   - 	The one- or two-digit minute. Eg. 1 or 59
            //mm  - 	The two-digit minute. Single digit values are preceded by a 0. Eg. 01 or 59
            //M   - 	The one- or two-digit month number. Eg. 1 or 12
            //MM  - 	The two-digit month number. Single digit values are preceded by a 0. Eg. 01 or 12
            //MMM - 	The three-character month abbreviation. Eg. Feb
            //MMMM- 	The full month name. Eg. December
            //s   -     The one - or two - digit seconds. Eg. 1 or 59
            //ss  - 	The two-digit seconds. Single digit values are preceded by a 0. Eg. 01 or 59
            //t   - 	The one-letter A.M./P.M. abbreviation (A.M. is displayed as "A"). 
            //tt  - 	The two-letter A.M./P.M. abbreviation (A.M. is displayed as "AM").
            //y   - 	The one-digit year (2001 is displayed as "1").
            //yy  - 	The last two digits of the year (2001 is displayed as "01").
            //yyyy- 	The full year (2001 is displayed as "2001").


            //The idea is to add combinatons of these for custom formats
            //Change the format to customformat
            //Under the customformat you add these

            //You may use '/' or '-' or ':' or ' ' ideally to seperate different formats 
            //Eg. yyyy/MM/dd
            //Eg. yy-MMMM-dd
            //Eg. HH:mm

            //You can combine multiple formats with the same symmbol
            //Eg. yyyy MM dd dddd
        }
    }
}

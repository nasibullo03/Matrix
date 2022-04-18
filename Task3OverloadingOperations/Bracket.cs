using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task3OverloadingOperations
{
    public class Bracket
    {
        public PictureBox BrecketOpenPicture { get { return new PictureBox() } set { } }
        public PictureBox BrecketClosePicture { get; set; }
        private PictureBox brecket()
        {
            return new PictureBox();
        }
    }
}

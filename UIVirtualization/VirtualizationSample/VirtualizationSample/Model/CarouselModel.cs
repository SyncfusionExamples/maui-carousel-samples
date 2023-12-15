using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualizationSample.Model
{
    public class CarouselModel
    {
        public CarouselModel(string imagestring)
        {
            Image = imagestring;
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}

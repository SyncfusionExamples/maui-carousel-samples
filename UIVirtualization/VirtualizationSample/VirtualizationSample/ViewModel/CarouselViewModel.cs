using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualizationSample.Model;

namespace VirtualizationSample.ViewModel
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            for (int i = 0; i<145; i++)
            {
                ImageCollection.Add(new CarouselModel("image1.png"));
                ImageCollection.Add(new CarouselModel("image2.png"));
                ImageCollection.Add(new CarouselModel("image3.png"));
                ImageCollection.Add(new CarouselModel("image4.png"));
                ImageCollection.Add(new CarouselModel("image5.png"));
                ImageCollection.Add(new CarouselModel("image6.png"));
                ImageCollection.Add(new CarouselModel("image7.png"));
            }
        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}

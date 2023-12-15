namespace LoadMoreSample.Model
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

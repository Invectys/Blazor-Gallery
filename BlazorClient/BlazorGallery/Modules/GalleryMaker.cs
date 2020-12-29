using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGallery
{
    public class GalleryMaker
    {
        public int ColumnAmount { get; set; }
        public List<byte[]> Images => _bytes;

        private List<byte[]> _bytes = new List<byte[]>();


        public GalleryMaker(int columnAmount = 3)
        {
            ColumnAmount = columnAmount;
        }

        public void SetImages(List<byte[]> bytes)
        {
            _bytes = bytes;
        }
       


    }
}

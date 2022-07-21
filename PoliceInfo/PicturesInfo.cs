using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliceInfo
{
    public class PicturesInfo
    {
        public int MinRow { get; set; }
        public int MaxRow { get; set; }
        public int MinCol { get; set; }
        public int MaxCol { get; set; }
        public Byte[] PictureData { get; private set; }

        public PicturesInfo(int minRow, int maxRow, int minCol, int maxCol, Byte[] pictureData)
        {
            this.MinRow = minRow;
            this.MaxRow = maxRow;
            this.MinCol = minCol;
            this.MaxCol = maxCol;
            this.PictureData = pictureData;
        }
    }
}

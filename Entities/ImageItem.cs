using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using Entities;


namespace Entities
{
    public class ImageItem
    {

        public ImageItem()
        {
            IsActive = true;

        }

        public int Id { get; private set; }
        public string ImageName { get; set; }
        public string? ImageSource { get; set; }
        public string Category { get; set; }
        public Guid IdWeb { get; private set; }
        public DateTime InsertDate { get; private set; }
        public bool IsActive { get; private set; }


    }

  
}

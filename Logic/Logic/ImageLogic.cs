﻿using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ImageLogic : BaseContextLogic, IImageLogic
    {

        public ImageLogic(ServiceContext serviceContext) : base(serviceContext) { }

        void IImageLogic.DeleteImage(int id)
        {
            _serviceContext.Images.Remove(_serviceContext.Set<ImageItem>().Where(i => i.Id == id).FirstOrDefault());
            _serviceContext.SaveChanges();
        }

        public List<ImageItem> GetAll()
        {
            var allImages = _serviceContext.Set<ImageItem>().ToList();
            return allImages;
        }

        public List<ImageItem> GetImageByCriteria(string Category)
        {
            var categoryFilter = new ImageItem();
            categoryFilter.Category = Category;

            var resultList = _serviceContext.Set<ImageItem>()
                                .Where(i => i.Category == Category);

            if (categoryFilter.Category == Category)
            {
                resultList = resultList.Where(i => i.Category == Category);
            }


            return resultList.ToList();
        }

        public List<ImageItem> GetImageByName(string imageName)
     
        {
            var nameFilter = new ImageItem();
            nameFilter.ImageName = imageName;

            var resultList = _serviceContext.Set<ImageItem>()
                .Where(i => i.ImageName == imageName);

            if (nameFilter.ImageName == imageName)
            {
                resultList = resultList.Where(i => i.ImageName == imageName);
            }
            
            return resultList.ToList();

        }
        int IImageLogic.InsertImagetItem(ImageItem imageItem)
        {

            _serviceContext.Images.Add(imageItem);
            _serviceContext.SaveChanges();
            return imageItem.Id;
        }

        public void UpdateImage(ImageItem imageItem)
            
        {


            _serviceContext.Images.Update(imageItem);
            _serviceContext.SaveChanges();
        }

       
    }
}



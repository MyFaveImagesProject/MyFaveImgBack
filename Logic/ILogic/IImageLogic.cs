﻿using Entities.Entities;

namespace Logic.ILogic
{
    public interface IImageLogic

    {
        int InsertImagetItem(ImageItem imageItem);

        void DeleteImage(int id);

        void UpdateImage(ImageItem imageItem);

        List<ImageItem> GetImageByCriteria(string Category);

        public List<ImageItem> GetImageByName(string imageName);
        List<ImageItem> GetAll();
    }
}

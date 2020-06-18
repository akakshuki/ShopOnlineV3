﻿
using System;

namespace WebAdmin.Models.ModelViews

{
    public class ImageMv
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime DateCreate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int Status { get; set; }
        public Guid ProductId { get; set; }

        public ProductMv Product { get; set; }
       
    }
}
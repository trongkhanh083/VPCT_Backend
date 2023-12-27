﻿using System.ComponentModel.DataAnnotations;
namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class HoatDongKhac
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? ThoiGian { get; set; }
        public int ChuyenGiaId { get; set; }
        public virtual ChuyenGia? ChuyenGia
        {
            get; set;
        }
    }
}

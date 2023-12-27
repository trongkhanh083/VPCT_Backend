﻿using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class LanDieuChinh
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public double? KinhPhi { get; set; }
        public string? NoiDung { get; set; }
        public string? Khac { get; set; }
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
    }
}
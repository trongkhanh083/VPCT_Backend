﻿using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ProductModel.TaskProduct
{
    public class Product_II : SanPham
    {
        [Required]
        public int LoaiSanPhamId { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; } = null!; //Loại sản phẩm
        public string? YeuCau { get; set; } //Yêu cầu khoa học cần đạt
        public string? GhiChu { get; set; } //Ghi chú sản phẩm

        //Sản phẩm nổi bật
        public string? SocioEconomicEfficiency { get; set; } //Hiệu quả kinh tế xã hội
        public string? Scale { get; set; } //Quy mô áp dụng
        public string? Address { get; set; } //Địa chỉ áp dụng

        //Đã được tiêu thụ
        public bool IsConsumed { get; set; } = false;
        public int ConsumingQuantity { get; set; } = 0; //Số lượng
        public double ConsumingAmount { get; set; } = 0; //Số tiền (VNĐ)

        //Đã được chuyển giao
        public bool IsDelivered { get; set; } = false;
        public int DeliveryQuantity { get; set; } = 0; //Số lượng
        public double DeliveryAmount { get; set; } = 0; //Số tiền (VNĐ)

        //Hợp đồng cung cấp dịch vụ
        public bool ServiceProvisionContract { get; set; } = false;
        public string? ContractNumber { get; set; } //Số hợp đồng
        public double ContractAmount { get; set; } = 0;//Số tiền (VNĐ)

        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}

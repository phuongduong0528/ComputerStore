using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class NhaPhanPhoiAdaptor
    {
        public NhaPhanPhoiDto GetNhaPhanPhoiDto(NhaPhanPhoi nhaPhanPhoi)
        {
            NhaPhanPhoiDto x = new NhaPhanPhoiDto();
            x.MaNPP = nhaPhanPhoi.MaNPP;
            x.TenNPP = nhaPhanPhoi.TenNhaPhanPhoi;
            x.DiaChi = nhaPhanPhoi.DiaChi;
            x.SDT = nhaPhanPhoi.SDT;
            using(ComputerStoreEntities c = new ComputerStoreEntities())
            {
                x.SlMatHang = 
                    c.NhaPhanPhois.Any(npp => npp.MaNPP.Equals(x.MaNPP)) ? 
                    c.NhaPhanPhois.Single(npp => npp.MaNPP.Equals(x.MaNPP)).MatHangs.Count() : 0;
            }
            return x;
        }

        public List<NhaPhanPhoiDto> GetListNhaPhanPhoiDto(List<NhaPhanPhoi> nhaPhanPhois)
        {
            List<NhaPhanPhoiDto> nhaPhanPhoiDtos = new List<NhaPhanPhoiDto>();
            foreach(var npp in nhaPhanPhois)
            {
                nhaPhanPhoiDtos.Add(GetNhaPhanPhoiDto(npp));
            }
            return nhaPhanPhoiDtos;
        }

        public NhaPhanPhoi ToNhaPhanPhoiEntity(NhaPhanPhoiDto nhaPhanPhoiDto)
        {
            NhaPhanPhoi nhaPhanPhoi = new NhaPhanPhoi();
            nhaPhanPhoi.MaNPP = nhaPhanPhoiDto.MaNPP;
            nhaPhanPhoi.TenNhaPhanPhoi = nhaPhanPhoiDto.TenNPP;
            nhaPhanPhoi.DiaChi = nhaPhanPhoiDto.DiaChi;
            nhaPhanPhoi.SDT = nhaPhanPhoiDto.SDT;
            return nhaPhanPhoi;
        }
    }
}

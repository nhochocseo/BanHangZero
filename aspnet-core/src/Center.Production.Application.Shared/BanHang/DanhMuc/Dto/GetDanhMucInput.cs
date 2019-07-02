using Abp.Runtime.Validation;
using Center.Production.Authorization.Users.Dto;
using Center.Production.Dto;

namespace Center.Production.BanHang.DanhMuc.Dto
{
    public class GetDanhMucInput : PagedAndSortedInputDto, IShouldNormalize, IGetUsersInput
    {
        public string Filter { get; set; }

        public string Permission { get; set; }

        public int? Role { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name";
            }

            Filter = Filter?.Trim();
        }
    }
}

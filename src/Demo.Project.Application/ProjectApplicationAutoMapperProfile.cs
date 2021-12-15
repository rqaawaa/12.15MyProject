using AutoMapper;
using Demo.Project.Dto.GoodsDTO;
using Demo.Project.Dto.RBACDTO;
using Demo.Project.Dto.UserDTO;
using Demo.Project.Model.MyGoods;
using Demo.Project.Model.MyUserModel;
using Demo.Project.Model.RBAC;

namespace Demo.Project
{
    public class ProjectApplicationAutoMapperProfile : Profile
    {
        public ProjectApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<GoodsInfoAndType, GoodsInfoAndTypeDto>();
            CreateMap<CreateUpdateGoodsDto, GoodsInfoAndType>();

            CreateMap<MyGoodsAttributeModel, MyGoodsAttributeDto>();
            CreateMap<CreateUpdateGoodsDto, MyGoodsAttributeModel>();

            CreateMap<MyGoodsImgModel, MyGoodsImgDto>();
            CreateMap<CreateUpdateGoodsDto, MyGoodsImgModel>();

            CreateMap<MyGoodsInfoModel, MyGoodsInfoDto>();
            CreateMap<CreateUpdateGoodsDto, MyGoodsInfoModel>();

            CreateMap<MyGoodsNumModel, MyGoodsNumDto>();
            CreateMap<CreateUpdateGoodsDto, MyGoodsNumModel>();



            CreateMap<MenuRBACModel, MenuRBACDto>();
            CreateMap<CreateUpdateGoodsDto, MenuRBACModel>();

            CreateMap<RoleAndMenuModel, RoleAndMenuDto>();
            CreateMap<CreateUpdateGoodsDto, RoleAndMenuModel>();

            CreateMap<RoleRBACModel, RoleRBACDto>();
            CreateMap<CreateUpdateGoodsDto, RoleRBACModel>();

            CreateMap<UserAndRoleModel, UserAndRoleDto>();
            CreateMap<CreateUpdateGoodsDto, UserAndRoleModel>();



            CreateMap<LoginModel, LoginDto>();
            CreateMap<CreateUpdateGoodsDto, LoginModel>();

            CreateMap<MyUserInfoModel, MyUserInfoDto>();
            CreateMap<CreateUpdateGoodsDto, MyUserInfoModel>();
        }
    }
}

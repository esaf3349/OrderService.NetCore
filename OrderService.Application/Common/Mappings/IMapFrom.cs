using AutoMapper;

namespace OrderService.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        public void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}

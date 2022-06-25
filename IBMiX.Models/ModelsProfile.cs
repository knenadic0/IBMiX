using AutoMapper;
using IBMiX.Model.Common;
using IBMiX.Model.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Model
{
    public class ModelsProfile : Profile
    {
        public ModelsProfile()
        {
            CreateMap<BookXml, IBook>().As(typeof(Book));
            CreateMap<BookXml, Book>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Text))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title.Text))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Text))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Text))
                .ForMember(dest => dest.PublishDate, opt => opt.MapFrom(src => src.PublishDate.Text))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.Text));
        }
    }
}

using AutoMapper;
using BlogBLL.Interfaces;
using BlogBLL.Models;
using BlogDAL.Entities;
using BlogDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;
        }

        public void Add(PostModel model)
        {
            _unitOfWork.PostRepository.Add(_mapper.Map<Post>(model));
            _unitOfWork.Save();
        }

        public bool DeleteById(int modelId)
        {
            var result=_unitOfWork.PostRepository.DeleteById(modelId);
            _unitOfWork.Save();
            return result;

        }

        public IEnumerable<PostModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PostModel>>(_unitOfWork.PostRepository.FindAll());
        }

        public PostModel GetById(int id)
        {
            return _mapper.Map<PostModel>(_unitOfWork.PostRepository.GetById(id));
        }

        public void Update(PostModel model)
        {
            var post = _unitOfWork.PostRepository.GetById(model.Id);

            post.Title = model.Title;
            post.Subtitle=model.Subtitle;
            post.DatePosted=model.DatePosted;
            post.Author=model.Author;
            post.Content = model.Content;
            post.ImgDescription=model.ImgDescription;
            post.ImgPath = model.ImgPath;

            _unitOfWork.PostRepository.Update(post);
            _unitOfWork.Save();
        }
    }
}

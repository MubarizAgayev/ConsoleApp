using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryRepository _repo;
        private int _count=1;
        public LibraryService()
        {
            _repo= new LibraryRepository();
        }
        public Library Creat(Library library)
        {
            library.Id = _count;
            _repo.Creat(library);
            _count++;
            return library;
        }

        public Library Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> Search(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}

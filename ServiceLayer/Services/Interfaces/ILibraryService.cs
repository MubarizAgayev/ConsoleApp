using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Creat(Library library);
        Library Delete(int id);
        Library GetById(int id);
        List<Library> Search(string searchText);
        List<Library> GetAll();
    }
}

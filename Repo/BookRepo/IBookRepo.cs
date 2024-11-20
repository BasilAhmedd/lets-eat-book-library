using lets_eat_book_library.DTOs.BookDTOs;

namespace lets_eat_book_library.Repo.BookRepo
{
    public interface IBookRepo
    {
        IEnumerable<Book_Add_And_Get_All_DTO> GetAll();
        Book_Add_And_Get_All_DTO GetById(int id);

        void AddAll(Book_Add_And_Get_All_DTO dto);
        void AddById(Book_Add_All_By_ID_DTO dto); 
        void UpdateAll(Book_Add_And_Get_All_DTO dto,int id);
        void UpdateById(Book_Add_All_By_ID_DTO dto,int id);
        void Delete(int id);
    }
}

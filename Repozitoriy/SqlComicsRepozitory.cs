using Comics.Model;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repozitoriy
{
    public class SqlComicsRepozitory : Icomics
    {
        private readonly AppDbContext _appDbContext;

        public SqlComicsRepozitory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Model.Comics Add(Model.Comics comics)
        {
            throw new NotImplementedException();
        }

        public Model.Comics Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Comics.Model.Comics DeleteUser(int id)
        {
            var user = GetComicsById(id);
            _appDbContext.Remove(user);
            _appDbContext.SaveChanges();
            return user;
        }

        public List<Model.Comics> GetAll()
        {
            return _appDbContext.Comicss.ToList();
        }

        public Comics.Model.Comics? GetComicsById(int id)
        {
            return _appDbContext.Comicss.Where(u => u.ID == id).ToList().FirstOrDefault();
        }

        public List<Comics.Model.Comics> GetUsers()
        {
            return _appDbContext.Comicss.ToList();
        }

        public Comics.Model.Comics UpdateUser(Comics.Model.Comics upUser)
        {
            if (upUser.ID == 0) 
            {
                _appDbContext.Comicss.Add(upUser);
            }
            else
            {
                _appDbContext.Comicss.Update(upUser);
            }
            _appDbContext.SaveChanges();
            return upUser;
        }
    
    }
}

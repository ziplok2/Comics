using Comics.Model;

namespace Comics.Repozitoriy
{
    public class MocComics : Icomics
    {
        private List<Comics.Model.Comics> _comics;

        public MocComics()
        {
            _comics ??= new List<Model.Comics> ();
            _comics.Add(new() { ID = 1, Name = "Удивительный человек-пак", Year = 1984});
            _comics.Add(new() { ID = 2, Name = "Россомаха", Year = 1989 });
            _comics.Add(new() { ID = 3, Name = "Халк", Year = 1995 });
        }

        Comics.Model.Comics Icomics.Add(Comics.Model.Comics comic)
        {
            _comics.Add(comic);
            return comic;
        } 

        Comics.Model.Comics Icomics.Delete(int ID)
        {
            var comicBD = _comics.Where(u => u.ID == ID).ToList().FirstOrDefault();
            return comicBD;
        }   
            
        Comics.Model.Comics Icomics.Get(int ID)
        {
            return _comics.Where(u => u.ID == ID).ToList().FirstOrDefault();
        }

       List<Comics.Model.Comics> Icomics.GetAll()
        {
            return _comics;
        }

        Comics.Model.Comics Icomics.Update(Comics.Model.Comics comics)
        {
            var comicBD = _comics.Where(u => u.ID == comics.ID).ToList().FirstOrDefault();
            if (comicBD != null) 
            {
                _comics.Remove(comicBD);
            }
            _comics.Add(comics);
            return comics;
        }
    }
}

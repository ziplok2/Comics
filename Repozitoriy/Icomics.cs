﻿using Comics.Model;

namespace Comics.Repozitoriy
{
    public interface Icomics
    {
        public Comics.Model.Comics? Add(Comics.Model.Comics comics);
        public Comics.Model.Comics? GetComicsById (int Id);
        public Comics.Model.Comics? UpdateUser(Comics.Model.Comics comics);
        public List <Comics.Model.Comics> GetAll ();
        public Comics.Model.Comics? Delete (int ID);

        
    }
}

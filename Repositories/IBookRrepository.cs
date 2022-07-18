﻿namespace bookstore.Repositories
{
    public interface IBookRrepository<TEntity>
    {
        IList<TEntity> List();
        TEntity find(int id);
        void add(TEntity entity);
        void update(int id ,TEntity entity);
        void delete(int id);
        
    }
}

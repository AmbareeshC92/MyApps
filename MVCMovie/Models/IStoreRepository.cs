﻿namespace MVCMovie.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}

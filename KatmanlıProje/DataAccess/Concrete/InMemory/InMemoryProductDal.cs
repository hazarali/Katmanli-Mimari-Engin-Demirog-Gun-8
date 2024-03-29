﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        //CONSTRUCTOR
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1,CategoryId=1,ProductName="bardak",UnitPrice=4,UnitsInStock=15 },
            new Product{ProductId=2,CategoryId=1,ProductName="kamera",UnitPrice=4,UnitsInStock=3 },
            new Product{ProductId=3,CategoryId=1,ProductName="telefon",UnitPrice=4,UnitsInStock=2 },
            new Product{ProductId=4,CategoryId=2,ProductName="klavye",UnitPrice=4,UnitsInStock=65 },
            new Product{ProductId=5,CategoryId=2,ProductName="fare",UnitPrice=4,UnitsInStock=1 },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            
            //p=>p.ProductId==product.ProductId  ifadesi foreach gibidir. BİR ELEMAN ARAR
            //ARADIĞI ELEMAN BULUP p eşler
            // _products.SingleOrDefault LINQ METHODUDUR

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);


            //p=>p.ProductId==product.ProductId  ifadesi foreach gibidir. BİR ELEMAN ARAR
            //ARADIĞI ELEMAN BULUP p eşler
            // _products.SingleOrDefault LINQ METHODUDUR

            //_product= yukarı tanımladığımız GLOBAL DEĞİŞKEN

            //productToUpdate.ProductId,productToUpdate.ProductName GÜNCELLENECEK ESKİ OLACAK
            //productToUpdate.CategoryId, productToUpdate.UnitStock GÜNCELLENECEK ESKİ OLACAK

            //Product product BU İSE BİZİM BELİRLEDĞİMİZ DEĞER. YENİ OLAN DEĞER.

            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

    }
}

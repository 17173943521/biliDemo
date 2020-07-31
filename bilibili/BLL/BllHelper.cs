using bilibili.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Data.Entity;
namespace bilibili.BLL
{
    public class BllHelper
    {
        MyDbContext db = new MyDbContext();
        public List<T> SqlQuery<T>(string sql) where T:class ,new()
        {
            return db.Database.SqlQuery<T>(sql).ToList();
        }
        /// <returns></returns>
        public int Sql(string sql)
        {
            return db.Database.ExecuteSqlCommand(sql);
        }
        public int Insert<T>(T t)where T:class,new()
        {
            db.Set<T>().Add(t);
            return db.SaveChanges();
        }
        public int Delete<T>(int id) where T : class,new()
        {
            db.Set<T>().Remove(db.Set<T>().Find(id));
            return db.SaveChanges();
        }
        public int Update<T>(T t)where T:class,new()
        {
            db.Entry(t).State = EntityState.Modified;
            return db.SaveChanges();
        }
        public List<T> Select<T>() where T:class ,new()
        {
            return db.Set<T>().ToList();
        }
    }
}
